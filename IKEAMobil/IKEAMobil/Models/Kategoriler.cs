using IKEAMobil.ViewModels;
using IKEAMobil.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace IKEAMobil.Models
{
    public class Kategoriler
    {
        public Command<Kategoriler> ItemTapped { get; }

        public string Photo { get; set; }
        public string Name { get; set; }

        public Kategoriler()
        {
            ItemTapped = new Command<Kategoriler>(OnItemSelected);

        }

        async void OnItemSelected(Kategoriler item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(ItemsPage)}?{nameof(ItemsViewModel.CategoryName)}={item.Name}");
        }
    }
}
