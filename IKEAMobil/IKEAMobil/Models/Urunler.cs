using IKEAMobil.ViewModels;
using IKEAMobil.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace IKEAMobil.Models
{
    public class Urunler
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");
         
        public string UrunAd { get; set; }
        public string UrunFoto { get; set; } = "";
        public bool UcretsizKargo { get; set; } = false;
        public bool YenıUrun { get; set; } = false;
        public int Numara { get; set; } = 39;
        public string UrunFiyat { get; set; }
        public string Aciklama { get; set; }
        public List<Slider> ImageList { get; set; } = new List<Slider>();
        //public Kategoriler Kategori { get; set; } = Kategoriler.SporAyakkabi;
        public string Kategori { get; set; } = "IKEA Arayüz";

        public DateTime Date { get; set; }

        public Command<Urunler> ItemTapped { get; }

        public Urunler()
        {
            ItemTapped = new Command<Urunler>(OnItemSelected);
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
        }

        async void OnItemSelected(Urunler item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
        }
    }

    public class Furniture
    {
        public string Id { get; set; } //= Guid.NewGuid().ToString("N");
        public string UrunAd { get; set; }
        public string UrunFoto { get; set; }
        public bool UcretsizKargo { get; set; }
        public bool YeniUrun { get; set; }
        public int Numara { get; set; }
        public string UrunFiyat { get; set; }
        public string Aciklama { get; set; }
        public string Kategori { get; set; }
        public string ImageListJson { get; set; }
    }
}
