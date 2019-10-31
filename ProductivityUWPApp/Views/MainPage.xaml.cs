﻿using System;

using ProductivityUWPApp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace ProductivityUWPApp.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return ViewModelLocator.Current.MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
