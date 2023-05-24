using IKEAMobil.ViewModels;
using IKEAMobil.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKEAMobil.Models;
using Xamarin.Forms.Xaml;
using Firebase.Auth;
using Xamarin.Essentials;
using Newtonsoft.Json;


namespace IKEAMobil
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public string WebAPIkey = "AIzaSyDTCNVQswWCO8xqM49wLPuneGFDUVU0o8k";
        public string Title { get; set; }
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(ItemsPage), typeof(ItemsPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(SepetPage), typeof(SepetPage));
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));

            BindingContext = this;

            Title = "IKEA";
        }

        async void GetProfileInformationAndRefreshToken()
        {
            var authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebAPIkey));
            try
            {
                //This is the saved firebaseauthentication that was saved during the time of login
                var savedfirebaseauth = JsonConvert.DeserializeObject<Firebase.Auth.FirebaseAuth>(Preferences.Get("MyFirebaseRefreshToken", ""));
                //Here we are Refreshing the token
                var RefreshedContent = await authProvider.RefreshAuthAsync(savedfirebaseauth);
                Preferences.Set("MyFirebaseRefreshToken", JsonConvert.SerializeObject(RefreshedContent));
                //Now lets grab user information
                MyUserName.Text = savedfirebaseauth.User.Email;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                await App.Current.MainPage.DisplayAlert("Alert", "Oh no !  Token expired", "OK");
            }



        }

    }

}
