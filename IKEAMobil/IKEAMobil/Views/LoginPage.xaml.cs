using IKEAMobil.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using IKEAMobil.Models;
using System.IO;
using SQLite;
using SQLitePCL;
using IKEAMobil.Tables;
using IKEAMobil.Views;
using Firebase.Auth;
using Newtonsoft.Json;

namespace IKEAMobil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public string WebAPIkey = "AIzaSyDTCNVQswWCO8xqM49wLPuneGFDUVU0o8k";

        public LoginPage()
        {
            InitializeComponent();
            

            if (Session.LoggedInUserData != null)
            {
                Application.Current.MainPage.Navigation.PushAsync(new AboutPage(), true);
            }
        }
        /*
        private void GirisTemizle()
        {
            giris_eposta.Text = "";
            giris_pass.Text = "";

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(giris_eposta.Text.Trim()) || string.IsNullOrEmpty(giris_pass.Text.Trim()))
            {
                await DisplayAlert("Uyarı", "Lütfen tüm alanları doldurunuz.", "Tamam");
            }

            User user = new User();
            user.Email = giris_eposta.Text.Trim();
            user.Password = giris_pass.Text;

            if (user.UserControl())
            {
                await Shell.Current.GoToAsync(nameof(AboutPage));
            }
            else
            {
                await DisplayAlert("Uyarı", "Kullanıcı bulunamadı.", "Tamam");
            }

            //entry_Eposta.Text = "";
            giris_pass.Text = "";
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UyeolPage());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SifremiUnuttum());
        }
        */
        private void Button_Clicked_1(object sender, EventArgs e) //GİRİŞ YAP SQLITE
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);

            var myquery = db.Table<RegUserTable>().Where(u => u.UserName.Equals(EntryUser.Text) && u.Password.Equals(EntryPassword.Text)).FirstOrDefault();

            if (myquery != null)
            {
                App.Current.MainPage = new NavigationPage(new AboutPage());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {

                    var result = await this.DisplayAlert("HATA", "Kullanıcı adı ve Şifre Geçersiz", "OK", "İptal");

                    if (result)
                        await Navigation.PushAsync(new LoginPage());
                    else
                    {
                        await Navigation.PushAsync(new LoginPage());
                    }

                });
            }
        }
        private async void Button_Clicked_3(object sender, EventArgs e) // HEMEN ÜYE OL GRİ OLAN. (SQLITE)
        {
            await Navigation.PushAsync(new UyeolPage());
        }

        async void Button_Clicked_4(object sender, EventArgs e) //GİRİŞ YAP (FIREBASE)
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
            try
            
            {
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebAPIkey));
                var auth = await authProvider.SignInWithEmailAndPasswordAsync(EntryUser.Text, EntryPassword.Text);
                var content = await auth.GetFreshAuthAsync();
                var serializedContent = JsonConvert.SerializeObject(content);
                await Navigation.PushAsync(new LoginPage());
            }
            catch
            {

            }

            /*var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);

            var myquery = db.Table<RegUserTable>().Where(u => u.UserName.Equals(EntryUser.Text) && u.Password.Equals(EntryPassword.Text)).FirstOrDefault();

            if(myquery!=null)
            {
                App.Current.MainPage = new NavigationPage(new AboutPage());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {

                    var result = await this.DisplayAlert("HATA", "Kullanıcı adı ve Şifre Geçersiz", "OK", "İptal");

                    if (result)
                        await Navigation.PushAsync(new LoginPage());
                    else
                    {
                        await Navigation.PushAsync(new LoginPage());
                    }

                });
            }*/
        }

        private async void Button_Clicked(object sender, EventArgs e) //HEMEN ÜYE OL WITH FIREBASE
        {
            await Navigation.PushAsync(new LoginFirebase());
        }

        
    }
}