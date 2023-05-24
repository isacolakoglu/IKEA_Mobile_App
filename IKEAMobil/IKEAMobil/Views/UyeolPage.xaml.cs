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

namespace IKEAMobil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UyeolPage : ContentPage
    {
        //public Command RegisterCommand { get; set; }
        public UyeolPage()
        {
            InitializeComponent();

            //RegisterCommand = new Command(OnRegisterClicked);
            
            //this.BindingContext = this;



        }
        /*private async void OnRegisterClicked(object obj)
        {
            if (string.IsNullOrEmpty(uyeol_name.Text.Trim()) || string.IsNullOrEmpty(uyeol_surname.Text.Trim()) || string.IsNullOrEmpty(uyeol_eposta.Text.Trim())
                || string.IsNullOrEmpty(uyeol_pass.Text.Trim()) || string.IsNullOrEmpty(uyeol_telno.Text.Trim()))
            {
                await DisplayAlert("Uyarı", "Lütfen tüm alanları doldurunuz.", "Tamam");
                return;
            }

            if (!sozlesme.IsChecked)
            {
                await DisplayAlert("Uyarı", "Lütfen üyelik sözleşmesini onaylayınız.", "Tamam");
                return;
            }

            User user = new User();
            user.Name = uyeol_name.Text.Trim();
            user.SurName = uyeol_surname.Text.Trim();
            user.Password = uyeol_pass.Text.Trim();
            user.Email = uyeol_eposta.Text.Trim();
            user.PhoneNumber = uyeol_telno.Text.Trim();

            if (user.UserRegister())
            {
                await DisplayAlert("Uyarı", "Hesabınız oluşturuldu. Giriş yapabilirsiniz.", "Tamam");
                ClearForm();
                return;
            }
            else
            {
                await DisplayAlert("Uyarı", "Hesabınız oluşturulurken bir sorun oluştu..", "Tamam");
                return;
            }
        }
        private void ClearForm()
            {
                uyeol_name.Text = string.Empty;
                uyeol_surname.Text = string.Empty;
                uyeol_eposta.Text = string.Empty;
                uyeol_pass.Text = string.Empty;
                uyeol_telno.Text = string.Empty;

                sozlesme.IsChecked = false;
            }
        */

        async void Button_Clicked(object sender, EventArgs e) //ÜYE OL SQLITE
        {
            if (string.IsNullOrEmpty(EntryUserName.Text.Trim()) || string.IsNullOrEmpty(EntryUserPassword.Text.Trim()) || string.IsNullOrEmpty(EntryUserEmail.Text.Trim())
                || string.IsNullOrEmpty(EntryUserEmail.Text.Trim()) || string.IsNullOrEmpty(EntryUserPhoneNumber.Text.Trim()))
            {
                await DisplayAlert("Uyarı", "Lütfen tüm alanları doldurunuz.", "Tamam");
                return;
            }

            if (!sozlesme.IsChecked)
            {
                await DisplayAlert("Uyarı", "Lütfen üyelik sözleşmesini onaylayınız.", "Tamam");
                return;
            }


            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<RegUserTable>();

            var item = new RegUserTable()
            {
                UserName = EntryUserName.Text,
                Password = EntryUserPassword.Text,
                Email = EntryUserEmail.Text,
                PhoneNumber = EntryUserPhoneNumber.Text
            };

            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {

                var result = await this.DisplayAlert("Tebrikler", "Başarıyla Giriş Yaptınız", "Devam Et", "Kal");

                if (result)
                    await Navigation.PushAsync(new LoginPage());

            });
        }
    }
}