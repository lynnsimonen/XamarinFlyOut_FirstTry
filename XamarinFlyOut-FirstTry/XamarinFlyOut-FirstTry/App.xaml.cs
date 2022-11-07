using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFlyOut_FirstTry.Services;
using XamarinFlyOut_FirstTry.Views;

namespace XamarinFlyOut_FirstTry
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
