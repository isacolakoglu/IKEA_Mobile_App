using System;
using System.Collections.Generic;
using System.Text;
using IKEAMobil.Models;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;


namespace IKEAMobil.Services
{
    public class UrunlerDataStore : IDataStore<Urunler>
    {
        public static List<Urunler> Items;


        public UrunlerDataStore()
        {
            #region DataSource
            
            Items = new List<Urunler>()
            {
                new Urunler {
                    Id="1",
                    UrunAd = "LEIRVIK/LURÖY",
                    Kategori="YATAK ODALARI",
                    UrunFoto ="https://cdn.ikea.com.tr/urunler/500_500/PH133783.jpg",
                    UrunFiyat="₺1399",
                    ImageList = new List<Slider>(){
                        new Slider() {Uri= "https://cdn.ikea.com.tr/urunler/500_500/PE660118.jpg" },
                        new Slider() {Uri= "https://cdn.ikea.com.tr/urunler/500_500/PH099006.jpg" },
                        new Slider() {Uri= "https://cdn.ikea.com.tr/urunler/500_500/PH120916.jpg" },
                        new Slider() {Uri= "https://cdn.ikea.com.tr/urunler/500_500/PH133783.jpg" },
                    },
                    Aciklama=@"Çift Kişilik Karyola, Beyaz 140x200cm"
                },
                new Urunler {
                    Id="2",
                    UrunAd = "TARVA/LURÖY 160x200cm",
                    Kategori="YATAK ODALARI",
                    UrunFoto ="https://cdn.ikea.com.tr/urunler/500_500/PH100102.jpg" ,
                    UrunFiyat="₺1099" ,
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PH100102.jpg"},
                        new Slider() {Uri= "https://cdn.ikea.com.tr/urunler/500_500/PE566702.jpg" },
                        new Slider() {Uri= "https://cdn.ikea.com.tr/urunler/500_500/PE555571.jpg" },
                        new Slider() {Uri= "https://cdn.ikea.com.tr/urunler/500_500/PE327865.jpg" },
                    },
                    Aciklama=@"Çift Kişilik Karyola, Çam 160x200cm"
                },
                new Urunler {
                    Id="3",
                    UrunAd = "GILLINGE",
                    Kategori="OTURMA ODALARI",
                    UrunFoto ="https://cdn.ikea.com.tr/urunler/500_500/PE713250.jpg" ,
                    UrunFiyat="₺5299",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE713250.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE713247.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE713248.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE713249.jpg"},
                    },
                    Aciklama=@"3'lü Kanepe, Jarstad Eskitilmiş",
                },
                new Urunler {  
                    Id="4", 
                    UrunAd = "SÖDERHAMN",
                    Kategori="OTURMA ODALARI", 
                    UrunFoto ="https://cdn.ikea.com.tr/urunler/500_500/PE599202.jpg" , 
                    UrunFiyat="₺5899",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE599202.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE301314.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE596613.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE585774.jpg"},
                    },
                    Aciklama=@"3'lü Kanepe ve Uzanma Koltuğu, Samsta Koyu Gri",
                },
                new Urunler {  
                    Id="5", 
                    UrunAd = "JOKKMOKK",
                    Kategori="YEMEK ODALARI", 
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE716638.jpg" ,
                    UrunFiyat="₺1599",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE716638.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE278490.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE594898.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE197452.jpg"},

                    },
                    Aciklama=@"Yemek Masası ve Sandalye Seti, Antika Vernik",
                },
                new Urunler {  
                    Id="6", 
                    UrunAd = "MELLTORP/ADDE",
                    Kategori="YEMEK ODALARI", 
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE716741.jpg" ,
                    UrunFiyat="₺858",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE716741.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE594905.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE388055.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE595021.jpg"},
                    },
                    Aciklama=@"Yemek Masası ve Sandalye Seti, Beyaz",
                },
                new Urunler {  
                    Id="7", 
                    UrunAd = "MALM",
                    Kategori="ÇALIŞMA ALANLARI", 
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE711832.jpg" ,
                    UrunFiyat="₺1099",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE711832.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE709628.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE602578.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE740309.jpg"},
                    },
                    Aciklama=@"Çalışma Masası, Beyaz, 140x65cm",
                },
                new Urunler {  
                    Id="8", 
                    UrunAd = "FREDDE",
                    Kategori="ÇALIŞMA ALANLARI", 
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PH170052.jpg" ,
                    UrunFiyat="₺1899",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PH170052.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PH165599.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PH123653.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE740351.jpg"},
                    },
                    Aciklama=@"Çalışma Masası, Siyah, 185x74cm",
                },
                new Urunler {
                    Id="9",
                    UrunAd = "FEJKA",
                    Kategori="EV DEKORASYONU",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE658007.jpg" ,
                    UrunFiyat="₺1899",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE658007.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE658006.jpg"},
                        
                    },
                    Aciklama=@"Yapay Bitki, Benjamin 21cm",
                },
                new Urunler {
                    Id="10",
                    UrunAd = "DAIDAI",
                    Kategori="EV DEKORASYONU",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE643427.jpg" ,
                    UrunFiyat="₺19",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE643427.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE643428.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE643426.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE699221.jpg"},

                    },
                    Aciklama=@"Saksı, Pirinç Rengi, 12cm",
                },
                new Urunler {
                    Id="11",
                    UrunAd = "ENHET",
                    Kategori="MUTFAKLAR",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE782953.jpg" ,
                    UrunFiyat="₺5069",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE782953.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE775456.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE789896.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE784874.jpg"},

                    },
                    Aciklama=@"Mutfak Dolabı Kombinasyonu, Beyaz-Antrasit, 243x63.5x241cm",
                },
                new Urunler {
                    Id="12",
                    UrunAd = "KNOXHULT",
                    Kategori="MUTFAKLAR",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE759063.jpg" ,
                    UrunFiyat="₺2347",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE759063.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE605388.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE754305.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE759103.jpg"},

                    },
                    Aciklama=@"Mutfak Dolabı Kombinasyonu, Gri, 120x61x220cm",
                },
                new Urunler {
                    Id="13",
                    UrunAd = "NEIDEN/LURÖY",
                    Kategori="YATAK ODALARI",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE739491.jpg" ,
                    UrunFiyat="₺529",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE739491.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE664781.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE664784.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE664782.jpg"},

                    },
                    Aciklama=@"Tek Kişilik Karyola, Huş, 90x200cm",
                },
                new Urunler {
                    Id="14",
                    UrunAd = "BRIMNES/LURÖY",
                    Kategori="YATAK ODALARI",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE739475.jpg" ,
                    UrunFiyat="₺2719",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE739475.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE741607.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE614971.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE699029.jpg"},

                    },
                    Aciklama=@"Çift Kişilik Karyola, Beyaz-Yatak Başlıklı, 160x200cm",
                },
                new Urunler {
                    Id="15",
                    UrunAd = "HEMNES/LURÖY",
                    Kategori="YATAK ODALARI",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PH156773.jpg" ,
                    UrunFiyat="₺2599",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PH156773.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PH120418.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PH133265.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE698353.jpg"},

                    },
                    Aciklama=@"Çift Kişilik Karyola, Beyaz Vernik, 160x200cm",
                },
                new Urunler {
                    Id="16",
                    UrunAd = "KIVIK",
                    Kategori="OTURMA ODALARI",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE625099.jpg" ,
                    UrunFiyat="₺3099",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE625099.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE625100.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE625075.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE619105.jpg"},

                    },
                    Aciklama=@"3'lü Kanepe, Hillared Antrasit",
                },
                new Urunler {
                    Id="17",
                    UrunAd = "KIVIK",
                    Kategori="OTURMA ODALARI",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE625099.jpg" ,
                    UrunFiyat="₺3099",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE625099.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE625100.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE625075.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE619105.jpg"},

                    },
                    Aciklama=@"3'lü Kanepe, Hillared Antrasit",
                },
                new Urunler {
                    Id="18",
                    UrunAd = "EKTORP",
                    Kategori="OTURMA ODALARI",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE774494.jpg" ,
                    UrunFiyat="₺3099",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE774494.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE792488.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE793853.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE774495.jpg"},

                    },
                    Aciklama=@"3'lü Kanepe, Hillared Antrasit",
                },
                new Urunler {
                    Id="19",
                    UrunAd = "ESKULSTUNA",
                    Kategori="OTURMA ODALARI",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE767202.jpg" ,
                    UrunFiyat="₺8499",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE767202.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE765710.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE767203.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE767201.jpg"},

                    },
                    Aciklama=@"2'li Kanepe ve Uzanma Koltuğu, Hillared Antrasit",
                },
                new Urunler {
                    Id="20",
                    UrunAd = "INGATORP/INGOLF",
                    Kategori="YEMEK ODALARI",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE716644.jpg" ,
                    UrunFiyat="₺4673",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE716644.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE741101.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE305745.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE390540.jpg"},

                    },
                    Aciklama=@"2'li Kanepe ve Uzanma Koltuğu, Hillared Antrasit",
                },
                new Urunler {
                    Id="21",
                    UrunAd = "MELLTORP/JANINGE",
                    Kategori="YEMEK ODALARI",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE716739.jpg" ,
                    UrunFiyat="₺4673",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE716739.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE595123.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE595634.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE594905.jpg"},

                    },
                    Aciklama=@"Yemek Masası ve Sandalye Seti, Beyaz, 125cm",
                },
                new Urunler {
                    Id="22",
                    UrunAd = "MELLTOP/ADDE",
                    Kategori="YEMEK ODALARI",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE716740.jpg" ,
                    UrunFiyat="₺858",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE716740.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE595125.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE595674.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE594905.jpg"},

                    },
                    Aciklama=@"Yemek Masası ve Sandalye Seti, Beyaz-Siyah, 125cm",
                },
                new Urunler {
                    Id="23",
                    UrunAd = "MICKE",
                    Kategori="ÇALIŞMA ALANLARI",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PH165486.jpg" ,
                    UrunFiyat="₺729",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PH165486.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PH165484.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PH165487.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE740299.jpg"},

                    },
                    Aciklama=@"Çalışma Masası, Venge, 105x50cm",
                },
                new Urunler {
                    Id="24",
                    UrunAd = "HEMNES",
                    Kategori="ÇALIŞMA ALANLARI",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PH165502.jpg" ,
                    UrunFiyat="₺1.249",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PH165502.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE711435.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE710085.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE740339.jpg"},

                    },
                    Aciklama=@"Çalışma Masası, Beyaz Vernik 120x47cm",
                },
                new Urunler {
                    Id="25",
                    UrunAd = "PAHL",
                    Kategori="ÇALIŞMA ALANLARI",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE646906.jpg" ,
                    UrunFiyat="₺779",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE646906.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE740272.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE558645.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE593846.jpg"},

                    },
                    Aciklama=@"Çalışma Masası, Beyaz 128x58cm",
                },
                new Urunler {
                    Id="26",
                    UrunAd = "KRYDDPEPPAR",
                    Kategori="EV DEKORASYONU",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE724973.jpg" ,
                    UrunFiyat="₺239",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE724973.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE724972.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE724974.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE724921.jpg"},

                    },
                    Aciklama=@"Çiçeklik, Bej, 65cm",
                },
                new Urunler {
                    Id="27",
                    UrunAd = "FEJKA",
                    Kategori="EV DEKORASYONU",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE687832.jpg" ,
                    UrunFiyat="₺39",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE687832.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE687831.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE686817.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE686818.jpg"},

                    },
                    Aciklama=@"Yapay Bitki, Senecio, 9cm",
                },
                new Urunler {
                    Id="28",
                    UrunAd = "FEJKA",
                    Kategori="EV DEKORASYONU",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE643391.jpg" ,
                    UrunFiyat="₺39",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE643391.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE675034.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE660547.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE697841.jpg"},

                    },
                    Aciklama=@"Yapay Bitki, Yeşil-Lila, 26x26cm",
                },
                new Urunler {
                    Id="29",
                    UrunAd = "ENHET",
                    Kategori="MUTFAKLAR",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE783012.jpg" ,
                    UrunFiyat="₺8.285",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE783012.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE775522.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE795136.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE784877.jpg"},

                    },
                    Aciklama=@"Köşe Mutfak Dolabı Kombinasyonu, Beyaz-Meşe",
                },
                new Urunler {
                    Id="30",
                    UrunAd = "ENHET",
                    Kategori="MUTFAKLAR",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE783073.jpg" ,
                    UrunFiyat="₺8.491",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE783073.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE775574.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE783443.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE784877.jpg"},

                    },
                    Aciklama=@"Köşe Mutfak Dolabı Kombinasyonu, Beyaz-Meşe",
                },
                new Urunler {
                    Id="31",
                    UrunAd = "KNOXHULT",
                    Kategori="MUTFAKLAR",
                    UrunFoto = "https://cdn.ikea.com.tr/urunler/500_500/PE759067.jpg" ,
                    UrunFiyat="₺4.307",
                    ImageList = new List<Slider>()
                    {
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE759067.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE759114.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE754293.jpg"},
                        new Slider(){Uri="https://cdn.ikea.com.tr/urunler/500_500/PE605390.jpg"},

                    },
                    Aciklama=@"Mutfak Dolabı Kombinasyonu, Parlak Cila Beyaz, 220x61x220cm",
                },
            };
            #endregion
        }

        public async Task<List<Urunler>> GetToCategory(string Kategori)
        {
            List<Urunler> urun = Items.FindAll(x => x.Kategori == Kategori);

            return await Task.FromResult(urun);
        }

        public async Task<bool> AddItemAsync(Urunler Urunler)
        {
            Items.Add(Urunler);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Urunler Urunler)
        {
            var oldUrunler = Items.Where((Urunler arg) => arg.Id == Urunler.Id).FirstOrDefault();
            Items.Remove(oldUrunler);
            Items.Add(Urunler);

            return await Task.FromResult(true);
        }

        //String id yerine int id yaptım.
        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldUrunler = Items.Where((Urunler arg) => arg.Id == id).FirstOrDefault();
            Items.Remove(oldUrunler);

            return await Task.FromResult(true);
        }

        //String yerine int id yaptım.
        public async Task<Urunler> GetItemAsync(string id)
        {
            return await Task.FromResult(Items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Urunler>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(Items);
        }
    }
}
