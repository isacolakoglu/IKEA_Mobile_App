using IKEAMobil.Models;
using IKEAMobil.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace IKEAMobil.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            ItemTapped = new Command<Urunler>(OnItemSelected);
        }

        public Command<Urunler> ItemTapped { get; }

        public ICommand OpenWebCommand { get; }

        async void OnItemSelected(Urunler item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
        }
    }
}