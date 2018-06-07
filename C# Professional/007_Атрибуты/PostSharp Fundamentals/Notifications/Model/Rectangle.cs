using System.ComponentModel;
using Notifications.Annotations;
using Notifications.Aspects;

namespace Notifications.Model
{

  //  [NotifyPropertyChanged]
    public class Shape:INotifyPropertyChanged
    {
        public double X { get; set; }
        public double Y { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }
}