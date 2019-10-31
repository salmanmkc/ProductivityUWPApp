using System;

using ProductivityUWPApp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace ProductivityUWPApp.Views
{
    public sealed partial class CalendarPage : Page
    {
        private CalendarViewModel ViewModel
        {
            get { return ViewModelLocator.Current.CalendarViewModel; }
        }

        public CalendarPage()
        {
            InitializeComponent();
        }
    }
}
