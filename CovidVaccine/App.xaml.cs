using Plugin.SharedTransitions;
using CovidVaccine.Models;
using Xamarin.Forms;


namespace CovidVaccine
{
    public partial class App : Application
    {
        public static AppModel Model { get; set; } = new AppModel();
        public App()
        {
            InitializeComponent();         

            var navigationPage = new SharedTransitionNavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.Transparent
            };

            MainPage = navigationPage;
        }

        protected override async void OnStart()
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
