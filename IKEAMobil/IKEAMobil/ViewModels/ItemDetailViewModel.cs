using IKEAMobil.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IKEAMobil.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string _UrunAd;
        private string _UrunFiyat;
        private string _Aciklama;
        private List<Models.Slider> _SliderData = new List<Models.Slider>();
        public string Id { get; set; }

        public string Aciklama
        {
            get => _Aciklama;
            set => SetProperty(ref _Aciklama, value);
        }
        public List<Models.Slider> SliderData
        {
            get => _SliderData;
            set => SetProperty(ref _SliderData, value);
        }

        public Command SepeteEkle { get; set; }

        public ItemDetailViewModel()
        {
            SepeteEkle = new Command(SepeteEkleFunc);
        }

        public string UrunAd
        {
            get => _UrunAd;
            set => SetProperty(ref _UrunAd, value);
        }

        public string UrunFiyat
        {
            get => _UrunFiyat;
            set => SetProperty(ref _UrunFiyat, value);
        }


        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string ItemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                UrunAd = item.UrunAd;
                UrunFiyat = item.UrunFiyat + " (KDV Dahil)";
                Aciklama = item.Aciklama;
                SliderData = item.ImageList;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }

        public async void SepeteEkleFunc()
        {
            Urunler item = await DataStore.GetItemAsync(itemId);

            if (item != null)
            {
                Session.UserSepet.TotalPrice = Session.UserSepet.TotalPrice + Convert.ToDouble(item.UrunFiyat.Replace('₺', ' ').Trim().Replace(',', '.'));
                Session.UserSepet.Urunlers.Add(item);

                // await DisplayAlert("Uyarı", "Ürün sepete eklendi.", "Tamam");
            }
        }
    }
}
