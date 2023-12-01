using lab12.Services;
using lab12.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab12
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            // MainPage = new AppShell();
            MainPage = new lab12.Views.TaskView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
