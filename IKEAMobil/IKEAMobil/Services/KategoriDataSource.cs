using System;
using System.Collections.Generic;
using System.Text;

namespace IKEAMobil.Services
{
    public class KategoriDataSource
    {
        public List<IKEAMobil.Models.Kategoriler> DataSource { get; set; }

        public KategoriDataSource()
        {
            DataSource = new List<Models.Kategoriler>();

            DataSource.Add(new Models.Kategoriler() { Name = "YATAK ODALARI", Photo = "https://cdn.ikea.com.tr/ozgur-icerik/departmanlar/yatak-odalari/yatak-odasi-nordli.jpg" });
            DataSource.Add(new Models.Kategoriler() { Name = "OTURMA ODALARI", Photo = "https://cdn.ikea.com.tr/ozgur-icerik/departmanlar/oturma-odalari/oturma-odalari-kivik1.jpg" });
            DataSource.Add(new Models.Kategoriler() { Name = "YEMEK ODALARI", Photo = "https://cdn.ikea.com.tr/ozgur-icerik/departmanlar/yemek-odalari/cy21-yemek-odalari-ovraryd-backaryd.jpg" });
            DataSource.Add(new Models.Kategoriler() { Name = "ÇALIŞMA ALANLARI", Photo = "https://cdn.ikea.com.tr/ozgur-icerik/departmanlar/calisma-alanlari/cy21-calisma-odalari-masalar-1.jpg" });
            DataSource.Add(new Models.Kategoriler() { Name = "EV DEKORASYONU", Photo = "https://cdn.ikea.com.tr/ozgur-icerik/departmanlar/ev-dekorasyonu/ev-deko-cerceveler.jpg" });
            DataSource.Add(new Models.Kategoriler() { Name = "MUTFAKLAR", Photo = "https://cdn.ikea.com.tr/ozgur-icerik/departmanlar/mutfaklar/mutfaklar-knoxhult-1.jpg" });
        }
    }
}
