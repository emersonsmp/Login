using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Login.Paginas;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Login
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new LoginPage());
            MainPage = new LoginPage();
            //MainPage = new CadastroPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
