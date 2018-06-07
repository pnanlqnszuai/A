using System;
using System.Windows;
using ContactManager.Aspects;
using ContactManager.Entities;

namespace ContactManager
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      public MainWindow()
        {
            Instance = this;
            InitializeComponent();
        }

      public static MainWindow Instance { get; private set; }

      private void treeView_SelectedItemChanged(object sender, RoutedEventArgs e)
        {
            detailPanel.Children.Clear();

            ContactTreeNode contactTreeNode = treeView.SelectedItem as ContactTreeNode;
            if (contactTreeNode != null)
            {
                detailPanel.Children.Add(new ContactControl(contactTreeNode.Contact));
            }
        }

        private void OnAddContactClick(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact {FirstName = "New", LastName = "Contact"};
            ContactTreeNode contactTreeNode = new ContactTreeNode(contact);
            treeView.Items.Add(contactTreeNode);
            contactTreeNode.IsSelected = true;
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            Entity.Initialize();

            foreach (Contact contact in Contact.GetContacts())
            {
                ContactTreeNode contactTreeNode = new ContactTreeNode(contact);
                treeView.Items.Add(contactTreeNode);
            }
        }

        [GuiThread]
        public DisposableStatusText SetStatusText(string text)
        {
            if (text != null)
            {
                pendingOperationStatusBarItem.Content = text;
                return new DisposableStatusText(this);
            }
            else
            {
                pendingOperationStatusBarItem.Content = text;
                return new DisposableStatusText(null);
            }
        }

        private void OnRefreshClick(object sender, RoutedEventArgs e)
        {
            treeView.Items.Clear();
            foreach (Contact contact in Contact.GetContacts())
            {
                ContactTreeNode contactTreeNode = new ContactTreeNode(contact);
                treeView.Items.Add(contactTreeNode);
            }
        }

        private void OnRepopulateClick(object sender, RoutedEventArgs e)
        {
            Entity.Repopulate();
            MessageBox.Show("You need to restart the application.");
            Close();
        }

      #region Nested type: DisposableStatusText

      public struct DisposableStatusText : IDisposable
        {
            private readonly MainWindow window;

            public DisposableStatusText(MainWindow window)
            {
                this.window = window;
            }

        #region IDisposable Members

        public void Dispose()
            {
                if (window != null) window.SetStatusText("Ready");
            }

        #endregion
        }

      #endregion
    }
}