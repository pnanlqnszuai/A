using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using PostSharp.Extensibility;
using PostSharp.Laos;

namespace ContactManager.Aspects
{
    /// <summary>
    /// Custom attribute that, when applied on a type (designated <i>target type</i>), implements the interface
    /// <see cref="INotifyPropertyChanged"/> and raises the <see cref="INotifyPropertyChanged.PropertyChanged"/>
    /// event when any property of the target type is modified.
    /// </summary>
    /// <remarks>
    /// Event raising is implemented by appending logic to the <b>set</b> accessor of properties. The 
    /// <see cref="INotifyPropertyChanged.PropertyChanged"/> is raised only when accessors successfully complete.
    /// </remarks>
    [MulticastAttributeUsage( MulticastTargets.Class | MulticastTargets.Struct )]
    [Serializable]
    public sealed class NotifyPropertyChangedAttribute : CompoundAspect
    {
        [NonSerialized] private int aspectPriority;

      /// <summary>
        /// Gets or sets the priority of the property-level aspect.
        /// </summary>
        /// <remarks>
        /// Give a large number to have the event raisen after any other
        /// on-success aspect on the properties of this type. The default value
        /// is 0.
        /// </remarks>
        public int AspectPriority { get { return aspectPriority; } set { aspectPriority = value; } }

      /// <summary>
      /// Method called at compile time to get individual aspects required by the current compound
      /// aspect.
      /// </summary>
      /// <param name="targetElement">Metadata element (<see cref="Type"/> in our case) to which
      /// the current custom attribute instance is applied.</param>
      /// <param name="collection">Collection of aspects to which individual aspects should be
      /// added.</param>
      public override void ProvideAspects( object targetElement, LaosReflectionAspectCollection collection )
      {
        // Get the target type.
        Type targetType = (Type) targetElement;

        // On the type, add a Composition aspect to implement the INotifyPropertyChanged interface.
        collection.AddAspect( targetType, new AddNotifyPropertyChangedInterfaceAdvice() );

        // Add a OnMethodBoundaryAspect on each writable non-static property.
        foreach ( PropertyInfo property in 
          from PropertyInfo p in targetType.UnderlyingSystemType.GetProperties() 
          where p.DeclaringType == targetType 
                && p.CanWrite 
                && !p.GetSetMethod(true).IsStatic
          select p)
        {
          collection.AddAspect(property.GetSetMethod(true), new OnPropertySetAdvice(property.Name, this));
        }
      }

      #region Nested type: AddNotifyPropertyChangedInterfaceAdvice

      /// <summary>
        /// Implementation of <see cref="CompositionAspect"/> that adds the <see cref="INotifyPropertyChanged"/>
        /// interface to the type to which it is applied.
        /// </summary>
        [Serializable]
        internal class AddNotifyPropertyChangedInterfaceAdvice : CompositionAspect
        {
            /// <summary>
            /// Called at runtime, creates the implementation of the <see cref="INotifyPropertyChanged"/> interface.
            /// </summary>
            /// <param name="eventArgs">Execution context.</param>
            /// <returns>A new instance of <see cref="NotifyPropertyChangedImpl"/>, which implements
            /// <see cref="INotifyPropertyChanged"/>.</returns>
            public override object CreateImplementationObject( InstanceBoundLaosEventArgs eventArgs )
            {
                return new NotifyPropertyChangedImpl( eventArgs.Instance );
            }

            /// <summary>
            /// Called at compile-time, gets the interface that should be publicly exposed.
            /// </summary>
            /// <param name="containerType">Type on which the interface will be implemented.</param>
            /// <returns></returns>
            public override Type GetPublicInterface( Type containerType )
            {
                return typeof(INotifyPropertyChanged);
            }

            public override Type[] GetProtectedInterfaces(Type containerType)
            {
                return new[] {typeof(IFirePropertyChanged)};
            }

            /// <summary>
            /// Gets weaving options.
            /// </summary>
            /// <returns>Weaving options specifying that the implementation accessor interface (<see cref="IComposed{T}"/>)
            /// should be exposed, and that the implementation of interfaces should be silently ignored if they are
            /// already implemented in the parent types.</returns>
            public override CompositionAspectOptions GetOptions()
            {
                return CompositionAspectOptions.IgnoreIfAlreadyImplemented;
            }
        }

      #endregion

      #region Nested type: NotifyPropertyChangedImpl

      /// <summary>
        /// Implementation of the <see cref="INotifyPropertyChanged"/> interface.
        /// </summary>
        internal class NotifyPropertyChangedImpl : INotifyPropertyChanged, IFirePropertyChanged
        {
            // Instance that exposes the current implementation.
            private readonly object instance;

            /// <summary>
            /// Initializes a new <see cref="NotifyPropertyChangedImpl"/> instance.
            /// </summary>
            /// <param name="instance">Instance that exposes the current implementation.</param>
            public NotifyPropertyChangedImpl( object instance )
            {
                this.instance = instance;
            }

        #region IFirePropertyChanged Members

        /// <summary>
            /// Raises the <see cref="PropertyChanged"/> event. Called by the
            /// property-level aspect (<see cref="AddNotifyPropertyChangedInterfaceAdvice"/>)
            /// at the end of property set accessors.
            /// </summary>
            /// <param name="propertyName">Name of the changed property.</param>
            public void FirePropertyChanged( string propertyName )
            {
                if ( PropertyChanged != null )
                {
                    PropertyChanged( instance, new PropertyChangedEventArgs( propertyName ) );
                }
            }

        #endregion

        #region INotifyPropertyChanged Members

        /// <summary>
        /// Event raised when a property is changed on the instance that
        /// exposes the current implementation.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
        }

      #endregion

      #region Nested type: OnPropertySetAdvice

      /// <summary>
      /// Implementation of <see cref="OnMethodBoundaryAspect"/> that raises the 
      /// <see cref="INotifyPropertyChanged.PropertyChanged"/> event when a property set
      /// accessor completes successfully.
      /// </summary>
      [Serializable]
      internal class OnPropertySetAdvice : OnMethodBoundaryAspect
      {
        private readonly string propertyName;

        /// <summary>
        /// Initializes a new <see cref="OnPropertySetAdvice"/>.
        /// </summary>
        /// <param name="propertyName">Name of the property to which this set accessor belong.</param>
        /// <param name="parent">Parent <see cref="NotifyPropertyChangedAttribute"/>.</param>
        public OnPropertySetAdvice( string propertyName, NotifyPropertyChangedAttribute parent )
        {
          AspectPriority = parent.AspectPriority;
          this.propertyName = propertyName;
        }

        /// <summary>
        /// Executed when the set accessor successfully completes. Raises the 
        /// <see cref="INotifyPropertyChanged.PropertyChanged"/> event.
        /// </summary>
        /// <param name="eventArgs">Event arguments with information about the 
        /// current execution context.</param>
        public override void OnSuccess( MethodExecutionEventArgs eventArgs )
        {
          // Get the implementation of INotifyPropertyChanged. We have access to it through the IComposed interface,
          // which is implemented at compile time.
          IFirePropertyChanged fireSemantic =
            ((IProtectedInterface<IFirePropertyChanged>)eventArgs.Instance).GetInterface(eventArgs.InstanceCredentials );

          // Raises the PropertyChanged event.
          fireSemantic.FirePropertyChanged(propertyName);
        }
      }

      #endregion
    }
}