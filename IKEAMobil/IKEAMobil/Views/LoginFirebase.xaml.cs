using System;
using IKEAMobil.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//using IKEAMobil.Helpers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Auth;
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace IKEAMobil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginFirebase : ContentPage
    {
        public string WebAPIkey = "AIzaSyDTCNVQswWCO8xqM49wLPuneGFDUVU0o8k";
        public LoginFirebase()
        {
            InitializeComponent();

        }

        async void KayıtOl_Clicked(object sender, EventArgs e)
        {
            try
            {
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebAPIkey));
                var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(UserNewEmail.Text, UserNewPassword.Text);
                string gettoken = auth.FirebaseToken;
                await App.Current.MainPage.DisplayAlert("Alert", gettoken, "Ok");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
            }
            await Navigation.PushAsync(new UyeOlFirebase());
        }

        private async void GirisYap_Clicked(object sender, EventArgs e)
        {
            try
            {
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebAPIkey));
                var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(UserNewEmail.Text, UserNewPassword.Text);
                string gettoken = auth.FirebaseToken;
                await App.Current.MainPage.DisplayAlert("Alert", gettoken, "Ok");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
            }
        }
    }
}