using IKEAMobil.Models;
using IKEAMobil.Services;
using IKEAMobil.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IKEAMobil.Views
{
    public partial class AboutPage : ContentPage
    {
        public string Title { get; set; }
        public Command SepetimPageDirectCommand { get; set; }
        
        public Command AramaPageCommand { get; set; }
        public Command<Urunler> ItemTapped { get; }

        public List<IKEAMobil.Models.Slider> SliderDS { get; set; }
        public List<IKEAMobil.Models.Kategoriler> KategorList { get; set; }
        public List<IKEAMobil.Models.Urunler> UrunlerList { get; set; }
        public AboutPage()
        {
            InitializeComponent();

            SetValue(NavigationPage.HasNavigationBarProperty, false);

            SliderDataSource ds = new SliderDataSource();
            KategoriDataSource kategoriDataSource = new KategoriDataSource();
            UrunlerDataStore urunlerDataStore = new UrunlerDataStore();
            SliderDS = ds.DataSource;
            KategorList = kategoriDataSource.DataSource;
            UrunlerList = UrunlerDataStore.Items.Take(12).ToList(); //urunlerDataStore.Items.Take(12).ToList();
            ItemTapped = new Command<Urunler>(OnItemSelected);
            Title = "Anasayfa";


            SepetimPageDirectCommand = new Command(SepetimPageDirect);
            BindingContext = this;

            AramaPageCommand = new Command(AramaPageDirect);
            BindingContext = this;

        }
        async void SepetimPageDirect()
        {
            await Shell.Current.GoToAsync(nameof(SepetPage));
        }

        async void AramaPageDirect()
        {
            await Shell.Current.GoToAsync(nameof(AramaSayfası));
        }

        


        async void OnItemSelected(Urunler item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}