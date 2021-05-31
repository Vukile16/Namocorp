using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contacts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashScreenPage : ContentPage
    {
        public SplashScreenPage()
        {
            InitializeComponent();            
            SplashScreen();
        }

        async void SplashScreen()
        {            
            splashImage.Opacity = 0;
            await splashImage.FadeTo(1,4000);;
            Application.Current.MainPage = new NavigationPage( new ContactPage());
        }
    }
}