using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace IKEAMobil.Models
{
    public class ListItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public long UrunId { get; set; }
        public string UrunAd { get; set; }
        public decimal UrunFiyat { get; set; }
        public decimal UrunIndFiyat { get; set; }
        public string UrunFoto { get; set; }
        public string UrunBeden { get; set; }
        public DateTime Date { get; set; }


    }
}
