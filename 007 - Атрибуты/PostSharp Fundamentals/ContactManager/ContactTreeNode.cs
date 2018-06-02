using System.ComponentModel;
using System.Windows.Controls;
using ContactManager.Entities;

namespace ContactManager
{
    internal class ContactTreeNode : TreeViewItem
    {
        private bool deleted;

        public ContactTreeNode(Contact contact)
        {
            Contact = contact;

            // Post.Cast<Contact, INotifyPropertyChanged>(this.Contact).PropertyChanged += OnContactChanged;

            SetHeader();
        }

        public Contact Contact { get; private set; }


        private void SetHeader()
        {
            string header = string.Format("{0} {1}", Contact.FirstName,
                                          Contact.LastName);
            if (!string.IsNullOrEmpty(Contact.Company))
                header += string.Format(" ({0})", Contact.Company);

            Header = header;
        }

        private void OnContactChanged(object sender, PropertyChangedEventArgs e)
        {
            if (Contact.IsDeleted)
            {
                if (!deleted)
                {
                    deleted = true;
                    ((ItemsControl) Parent).Items.Remove(this);
                }
            }
            else
            {
                SetHeader();
            }
        }
    }
}