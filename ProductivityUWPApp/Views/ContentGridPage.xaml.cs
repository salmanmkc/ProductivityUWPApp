using System;

using ProductivityUWPApp.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace ProductivityUWPApp.Views
{
    public sealed partial class ContentGridPage : Page
    {
        private ContentGridViewModel ViewModel
        {
            get { return ViewModelLocator.Current.ContentGridViewModel; }
        }

        public ContentGridPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            await ViewModel.LoadDataAsync();
        }
    }
}
