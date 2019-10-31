using System;

using GalaSoft.MvvmLight.Ioc;

using ProductivityUWPApp.Services;
using ProductivityUWPApp.Views;

namespace ProductivityUWPApp.ViewModels
{
    [Windows.UI.Xaml.Data.Bindable]
    public class ViewModelLocator
    {
        private static ViewModelLocator _current;

        public static ViewModelLocator Current => _current ?? (_current = new ViewModelLocator());

        private ViewModelLocator()
        {
            SimpleIoc.Default.Register(() => new NavigationServiceEx());
            SimpleIoc.Default.Register<ShellViewModel>();
            Register<MainViewModel, MainPage>();
            Register<MailViewModel, MailPage>();
            Register<CalendarViewModel, CalendarPage>();
            Register<ToDoViewModel, ToDoPage>();
            Register<InkDrawViewModel, InkDrawPage>();
            Register<ContentGridViewModel, ContentGridPage>();
            Register<ContentGridDetailViewModel, ContentGridDetailPage>();
            Register<SettingsViewModel, SettingsPage>();
        }

        public SettingsViewModel SettingsViewModel => SimpleIoc.Default.GetInstance<SettingsViewModel>();

        public ContentGridDetailViewModel ContentGridDetailViewModel => SimpleIoc.Default.GetInstance<ContentGridDetailViewModel>();

        public ContentGridViewModel ContentGridViewModel => SimpleIoc.Default.GetInstance<ContentGridViewModel>();

        public InkDrawViewModel InkDrawViewModel => SimpleIoc.Default.GetInstance<InkDrawViewModel>();

        public ToDoViewModel ToDoViewModel => SimpleIoc.Default.GetInstance<ToDoViewModel>();

        public CalendarViewModel CalendarViewModel => SimpleIoc.Default.GetInstance<CalendarViewModel>();

        public MailViewModel MailViewModel => SimpleIoc.Default.GetInstance<MailViewModel>();

        public MainViewModel MainViewModel => SimpleIoc.Default.GetInstance<MainViewModel>();

        public ShellViewModel ShellViewModel => SimpleIoc.Default.GetInstance<ShellViewModel>();

        public NavigationServiceEx NavigationService => SimpleIoc.Default.GetInstance<NavigationServiceEx>();

        public void Register<VM, V>()
            where VM : class
        {
            SimpleIoc.Default.Register<VM>();

            NavigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}
