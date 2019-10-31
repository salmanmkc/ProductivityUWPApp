using System;

using ProductivityUWPApp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace ProductivityUWPApp.Views
{
    public sealed partial class MailPage : Page
    {
        private MailViewModel ViewModel
        {
            get { return ViewModelLocator.Current.MailViewModel; }
        }

        public MailPage()
        {
            InitializeComponent();
        }
    }
}
