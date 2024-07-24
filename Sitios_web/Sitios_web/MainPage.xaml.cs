using System;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Sitios_web
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Event handler for btnVer
        private void btnVer_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://juancitopena.github.io/PORTAFOLIOJPV/index.html", BrowserLaunchMode.SystemPreferred);
        }

        // Event handler for BTNVER1
        private void BTNVER1_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.instagram.com/miguelortega_07/", BrowserLaunchMode.SystemPreferred);
        }

        // Event handler for btnver2
        private void btnver2_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.linkedin.com/in/yourprofile", BrowserLaunchMode.SystemPreferred);
        }

        // Event handler for btnver3
        private void btnver3_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://twitter.com/yourprofile", BrowserLaunchMode.SystemPreferred);
        }

        // Event handler for btnver4
        private void btnver4_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.facebook.com/yourprofile", BrowserLaunchMode.SystemPreferred);
        }

        // Event handler for btnver6
        private void btnver6_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.netflix.com/yourprofile", BrowserLaunchMode.SystemPreferred);
        }

        // Event handler for btnver7
        private void btnver7_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://yourwebsite.com/javierberiguete", BrowserLaunchMode.SystemPreferred);
        }
    }
}
