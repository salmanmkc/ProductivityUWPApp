using System;

using ProductivityUWPApp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace ProductivityUWPApp.Views
{
    public sealed partial class ToDoPage : Page
    {
        private ToDoViewModel ViewModel
        {
            get { return ViewModelLocator.Current.ToDoViewModel; }
        }

        public ToDoPage()
        {
            InitializeComponent();
        }
    }
}
