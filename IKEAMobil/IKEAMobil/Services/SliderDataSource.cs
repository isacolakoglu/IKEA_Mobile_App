using System;
using System.Collections.Generic;
using System.Text;
using IKEAMobil.Models;

namespace IKEAMobil.Services
{
    public class SliderDataSource
    {
        public List<Slider> DataSource { get; set; }
        public SliderDataSource()
        {
            DataSource = new List<Slider>();
            DataSource.Add(new Slider() { Uri = "https://cdn.ikea.com.tr/Banner/web/cy21-zuccaciye-cek1-TR.jpg" });
            DataSource.Add(new Slider() { Uri = "https://cdn.ikea.com.tr/Banner/web/cy21-yaz-urunleri-TR.jpg" });
            DataSource.Add(new Slider() { Uri = "https://cdn.ikea.com.tr/Banner/web/cy21-ikea-yeni-ne-var1-TR.jpg" });
            DataSource.Add(new Slider() { Uri = "https://cdn.ikea.com.tr/Banner/web/isvec-gida-marketi-y8-TR.jpg" });
            DataSource.Add(new Slider() { Uri = "https://cdn.ikea.com.tr/Banner/web/cy21-2021-katalog-TR.jpg" });
            DataSource.Add(new Slider() { Uri = "https://cdn.ikea.com.tr/Banner/web/click-collect-v1-TR.jpg" });
        }
    }
}
