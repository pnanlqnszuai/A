using System.Windows;
using System.Windows.Controls;
using ContactManager.Aspects;
using ContactManager.Entities;
using PostSharp.Extensibility;

[assembly: ExceptionDialog(AttributeTargetTypes = "ContactManager.*Control",
    AttributeTargetMembers = "*Click",
    AttributeTargetMemberAttributes = MulticastAttributes.Private)]

namespace ContactManager
{
    /// <summary>
    /// Interaction logic for ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        private readonly Contact contact;

        public ContactControl()
        {
            InitializeComponent();
        }

        public ContactControl(Contact contact) : this()
        {
            DataContext = contact;
            this.contact = contact;
        }

        [WorkerThread]
        private void OnApplyClick(object sender, RoutedEventArgs e)
        {
            using (MainWindow.Instance.SetStatusText("Applying changes."))
            {
                contact.Save();
            }
        }

        [WorkerThread]
        private void OnDeleteClick(object sender, RoutedEventArgs e)
        {
            using (MainWindow.Instance.SetStatusText("Deleting"))
            {
                contact.Delete();
            }
        }
    }
}