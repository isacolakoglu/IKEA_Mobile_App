using IKEAMobil.Models;
using IKEAMobil.Views;
using IKEAMobil.Services;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IKEAMobil.ViewModels
{
    [QueryProperty(nameof(CategoryName), nameof(CategoryName))]
    public class ItemsViewModel : BaseViewModel
    {

        public List<string> Kategoriler { get; set; }
        private Urunler _selectedItem;
        public string _CategoryName { get; set; } = "";
        private string _CountProduct { get; set; } = "0 Adet";
        public string CountProduct
        {
            get { return _CountProduct; }
            set
            {
                _CountProduct = value;
                OnPropertyChanged(nameof(CountProduct));
            }

        }
        private string _SearchText { get; set; } = "";
        public string SearchText
        {
            get { return _SearchText; }
            set
            {
                _SearchText = value;
                SearchFilter(value);
                OnPropertyChanged(nameof(SearchText));
            }
        }

        public void SearchFilter(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                var items = Items.ToList();
                Items.Clear();
                foreach (var item in items)
                {
                    var asd = item.UrunAd.ToLower();
                    if (item.UrunAd.ToLower().Contains(value.ToLower()))
                    {
                        Items.Add(item);
                    }
                }
                CountProduct = string.Format("{0} Adet", Items.Count);
            }
            else
                ExecuteLoadItemsCommand();
        }

        private bool _AzalanFiyataGore { get; set; } = false;
        public bool AzalanFiyataGore
        {
            get => _AzalanFiyataGore;
            set
            {
                _AzalanFiyataGore = value;

                if (ArtanFiyataGore)
                    ArtanFiyataGore = !value;

                if (value)
                    DataSourceSırala();
                OnPropertyChanged(nameof(AzalanFiyataGore));
            }
        }
        private bool _ArtanFiyataGore { get; set; } = false;
        public bool ArtanFiyataGore
        {
            get => _ArtanFiyataGore;
            set
            {
                _ArtanFiyataGore = value;

                if (AzalanFiyataGore)
                    AzalanFiyataGore = !value;

                if (value)
                    DataSourceSırala();
                OnPropertyChanged(nameof(ArtanFiyataGore));
            }
        }

        public void DataSourceSırala()
        {
            UrunlerDataStore ds = new UrunlerDataStore();
            Items.Clear();

            var itemsVirtual = ds.GetToCategory(CategoryName).Result;

            if (ArtanFiyataGore)
            {
                itemsVirtual = itemsVirtual.OrderBy(o => o.UrunFiyat).ToList();
            }
            else
            {
                itemsVirtual = itemsVirtual.OrderByDescending(o => o.UrunFiyat).ToList();
            }

            foreach (var item in itemsVirtual)
            {
                Items.Add(item);
            }
        }

        private bool _SiralamaMenusuVisible { get; set; } = false;
        public bool SiralamaMenusuVisible
        {
            get => _SiralamaMenusuVisible;
            set
            {
                _SiralamaMenusuVisible = value;
                if (value)
                    FiltreMenusuVisible = !value;
                OnPropertyChanged(nameof(SiralamaMenusuVisible));
            }
        }

        private bool _FiltreMenusuVisible { get; set; } = false;
        public bool FiltreMenusuVisible
        {
            get => _FiltreMenusuVisible;
            set
            {
                _FiltreMenusuVisible = value;
                if (value)
                    SiralamaMenusuVisible = !value;
                OnPropertyChanged(nameof(FiltreMenusuVisible));
            }
        }


        public string CategoryName { get { return _CategoryName; } set { _CategoryName = value; ExecuteLoadItemsCommand(); } }

        //public ObservableCollection<Urunler> Items { get; }

        private ObservableCollection<Urunler> _Items { get; set; } = new ObservableCollection<Urunler>();
        public ObservableCollection<Urunler> Items
        {
            get => _Items;
            set
            {
                _Items = value;
                OnPropertyChanged(nameof(Items));
            }
        }


        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<Urunler> ItemTapped { get; }

        public ItemsViewModel()
        {
            Title = CategoryName;
            Items = new ObservableCollection<Urunler>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ItemTapped = new Command<Urunler>(OnItemSelected);

            AddItemCommand = new Command(OnAddItem);

            Kategoriler = new List<string>();

            Kategoriler.Add("Spor Ayakkabı ve Babetler");
            Kategoriler.Add("Spor Ayakkabı");
            Kategoriler.Add("Topuklu Ayakkabılar");
            Kategoriler.Add("Hakiki Deri");
            Kategoriler.Add("Terlikler");
            Kategoriler.Add("Makosenler");
            Kategoriler.Add("Stilettolar");
        }

        public Command Siralama_Clicked_FuncCommand
        {
            get
            {
                return new Command(() => { Siralama_Clicked_FuncCommandMethod(); });
            }
        }

        private void Siralama_Clicked_FuncCommandMethod()
        {
            SiralamaMenusuVisible = !SiralamaMenusuVisible;
        }

        public Command Filtre_Clicked_FuncCommand
        {
            get
            {
                return new Command(() => { Filtre_Clicked_FuncCommandMethod(); });
            }
        }

        private void Filtre_Clicked_FuncCommandMethod()
        {
            FiltreMenusuVisible = !FiltreMenusuVisible;
        }

        public EventHandler RadioButton_CheckedChangedCommand
        {
            get
            {
                return new EventHandler(RadioButton_CheckedChangedCommandMethod);
            }
        }

        private void RadioButton_CheckedChangedCommandMethod(object sender, EventArgs e)
        {
            AzalanFiyataGore = false;
            ArtanFiyataGore = true;
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                UrunlerDataStore ds = new UrunlerDataStore();
                Items.Clear();
                var items = await ds.GetToCategory(CategoryName);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
                CountProduct = string.Format("{0} Adet", Items.Count);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public Urunler SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        private async void OnAddItem(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewItemPage));
        }

        async void OnItemSelected(Urunler item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
        }
    }
}