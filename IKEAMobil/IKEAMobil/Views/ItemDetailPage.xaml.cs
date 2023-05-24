using IKEAMobil.Models;
using IKEAMobil.Services;
using IKEAMobil.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Xamarin.Forms;

namespace IKEAMobil.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();

            //SepeteEkle = new Command(SepeteEkleFunc);
            //LoadItemId(itemId);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }














        /*private string itemId;
        private string _UrunAd;
        private string _UrunFiyat;
        private string _Aciklama;
        private List<Models.Slider> _SliderData = new List<Models.Slider>();
        public string Id { get; set; }

        public string Aciklama
        {
            get => _Aciklama;
            set => _Aciklama = value;
        }
        public List<Models.Slider> SliderData
        {
            get => _SliderData;
            set => _SliderData = value;
        }

        public Command SepeteEkle { get; set; }

        public string UrunAd
        {
            get => _UrunAd;
            set => _UrunAd = value;
        }

        public string UrunFiyat
        {
            get => _UrunFiyat;
            set => _UrunFiyat = value;
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

        public async void LoadItemId(string itemId)
        {
            try
            {
                UrunlerDataStore ds = new UrunlerDataStore();
                var item = await ds.GetItemAsync(itemId);
                Id = item.Id;
                UrunAd = item.UrunAd;
                UrunFiyat = item.UrunFiyat + " (KDV Dahil)";
                Aciklama = item.Aciklama;
                SliderData.AddRange(item.ImageList);
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }

        public async void SepeteEkleFunc()
        {
            UrunlerDataStore ds = new UrunlerDataStore();

            Urunler item = await ds.GetItemAsync(itemId);

            if (item != null)
            {
                Session.UserSepet.TotalPrice = Session.UserSepet.TotalPrice + Convert.ToDouble(item.UrunFiyat.Replace('₺', ' ').Trim().Replace(',', '.'));
                Session.UserSepet.Urunlers.Add(item);
            }
        }
        */
    }
}