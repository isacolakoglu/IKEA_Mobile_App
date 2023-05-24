using IKEAMobil.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Firebase.Database;
using Firebase.Database.Query;

namespace IKEAMobil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SepetPage : ContentPage
    {
        public List<Urunler> SepetUrunler;
        public string TotalPrice;
        public Command<Urunler> SilCommand { get; }

        //public Command OdemePageCommand { get; set; }

        public SepetPage()
        {
            InitializeComponent();
            SilCommand = new Command<Urunler>(SilFunc);
            lst1.ItemsSource = new ObservableCollection<Urunler>(Session.UserSepet.Urunlers);
            TotalPrice = string.Format("₺ {0}", Session.UserSepet.TotalPrice.ToString("N2"));
            lbl_PriceInfo.Text = string.Format("Toplam Fiyat: ₺ {0}", Session.UserSepet.TotalPrice.ToString("N2"));
            BindingContext = this;

            //OdemePageCommand = new Command(OnOdemeClicked);

            //this.BindingContext = this;
        }

        private void SilFunc(Urunler item)
        {
            if (item == null)
                return;

            Session.UserSepet.Urunlers.Remove(item);

            Session.UserSepet.TotalPrice = 0;
            foreach (Urunler urun in Session.UserSepet.Urunlers)
            {
                Session.UserSepet.TotalPrice = Session.UserSepet.TotalPrice + Convert.ToDouble(urun.UrunFiyat.Replace('₺', ' ').Trim().Replace(',', '.'));
            }

            lst1.ItemsSource = new ObservableCollection<Urunler>(Session.UserSepet.Urunlers);
            TotalPrice = string.Format("₺ {0}", Session.UserSepet.TotalPrice.ToString("N2"));
            lbl_PriceInfo.Text = string.Format("Toplam Fiyat: ₺ {0}", Session.UserSepet.TotalPrice.ToString("N2"));

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Xamarin.Forms.Button btn = (sender as Xamarin.Forms.Button);
        }

        /*private async void OnOdemeClicked(object obj)
        {
            await Navigation.PushAsync(new OdemePage());
        }*/

        /*private async void SiparisVer(object sender, EventArgs e)
        {
            var urun = (Urunler)BindingContext;
            urun.Date = DateTime.Now;
            await App.Database.SaveListsAsync(urun);
            await Navigation.PushAsync(new OdemePage());


            FirebaseClient fc = new FirebaseClient("https://ikeafirebase-default-rtdb.europe-west1.firebasedatabase.app/");
            var result = await fc.Child("Urunler").PostAsync(new Urunler() { UrunFoto = urun.UrunFoto, UrunAd = urun.UrunAd, UrunFiyat = urun.UrunFiyat });
            
            await Navigation.PushAsync(new OdemePage());
        }*/
    }
}