using System;
using System.Collections.Generic;
using System.Text;

namespace IKEAMobil.Models
{
    public static class Session
    {
        public static User LoggedInUserData { get; set; }
        public static DateTime LoginDate { get; set; }
        public static Sepet UserSepet { get; set; } = new Sepet();
    }

    public class Sepet
    {
        public double TotalPrice { get; set; }
        public List<Urunler> Urunlers { get; set; } = new List<Urunler>();
    }
}
