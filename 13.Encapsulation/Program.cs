using System;
using System.Linq;

namespace _13.Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cinsiyet için kişi oluşturalım
            //Kisi kisi1 = new Kisi();
            //kisi1.Ad = "Uğur";
            //kisi1.Soyad = "Bulut";
            //kisi1.Cinsiyet = "Erkek";

            //Kisi kisi2 = new Kisi();
            //kisi2.Ad = "Selma";
            //kisi2.Soyad = "Bulut";
            //kisi2.Cinsiyet = "Kadın";

            //Console.WriteLine(kisi1.Cinsiyet + " " + kisi1.Ad + " " + kisi1.Soyad);
            //Console.WriteLine(kisi2.Cinsiyet + " " + kisi2.Ad + " " + kisi2.Soyad); 
            #endregion

            #region Ürünleri oluşturalım
            //Urun urun1 = new Urun();
            //urun1.EsyaAdi = "koltuk takımı";
            //urun1.EsyaTuru = "mobilya";

            //Urun urun2 = new Urun();
            //urun2.EsyaAdi = "tencere takımı";
            //urun2.EsyaTuru = "züccaciye";

            //Urun urun3 = new Urun();
            //urun3.EsyaAdi = "televizyon";
            //urun3.EsyaTuru = "elektronik";

            //Console.WriteLine(urun1.EsyaTuru);
            //Console.WriteLine(urun2.EsyaTuru);
            //Console.WriteLine(urun3.EsyaTuru); 
            #endregion

            #region İlkerin çeyiz çözümü
            //Ceyiz buzdolabı = new Ceyiz("buzdolabı", 10000);
            //Ceyiz koltuk = new Ceyiz("koltuk", 5000);
            //Ceyiz masa = new Ceyiz("masa", 2500);
            //Nisanli merve = new Nisanli("merve", "yılmaz");
            //merve.CeyizEkle(masa);
            //merve.CeyizEkle(buzdolabı);
            //merve.CeyizEkle(koltuk);
            //merve.CeyizlerListele();
            //Console.WriteLine();
            //decimal toplam_maliyet = merve.CeyizlerMaliyet();
            //Console.WriteLine($"{merve.Name} nin çeyiz maliyeti={toplam_maliyet}"); 
            #endregion

            #region Dikdörtgeni oluşturalım, değer girelim
            //Dikdortgen dikdortgen = new Dikdortgen();
            //dikdortgen.uzunlukYazdir(10, -9);
            #endregion

            #region Seçmen, Milletvekili, Cumhurbaşkanı için değerler girelim
            //Secmen secmen1 = new Secmen("Hasan" , "Kuyu" , 15);
            //Milletvekili milletvekili = new Milletvekili("Selami" , "Yiğit" , 41);
            //Cumhurbaskani cumhurbaskani = new Cumhurbaskani("Hülya" , "Erkoç" , 28); 
            #endregion

            #region Seçim sorusu farklı çözüm
            //Secim secim2023 = new Secim();
            //CumhurbaskaniAdayi ahmet = new CumhurbaskaniAdayi("ahmet", "aslan", 55);
            //CumhurbaskaniAdayi mehmet = new CumhurbaskaniAdayi("mehmet", "kısa", 49);
            //MilletvekiliAday fatih = new MilletvekiliAday("fatih", "polat", 26);
            //MilletvekiliAday beyza = new MilletvekiliAday("beyza", "daldal", 22);
            //Vatandas furkan = new Vatandas("furkan", "ertantu", 26);
            //Vatandas akif = new Vatandas("akif", "sezer", 53);
            //Vatandas sezgin = new Vatandas("sezgin", "bezgin", 17);


            //Vatandas ilker = new Vatandas("ilker", "şenel", 26);

            //ahmet.OyKulan(beyza, ahmet);
            //mehmet.OyKulan(beyza, mehmet);
            //beyza.OyKulan(beyza, ahmet);
            //fatih.OyKulan(beyza, ahmet);
            //ilker.OyKulan(fatih, ahmet);
            //furkan.OyKulan(fatih, mehmet);
            //akif.OyKulan(fatih, ahmet);
            //sezgin.OyKulan(fatih, mehmet);


            //secim2023.CbEkle(mehmet);
            //secim2023.CbEkle(ahmet);
            //secim2023.MvEkle(beyza);
            //secim2023.MvEkle(fatih);

            //secim2023.SecimSonuclari(); 
            #endregion

            #region Kredi kartı oluşturalım
            //CreditCard card = new CreditCard("1234567890123456", "567", new DateTime(2025, 12, 05));
            //Console.WriteLine("Kart numarası:" + card.CardNo);
            //Console.WriteLine("Cvv numarası:" + card.CVV);
            //Console.WriteLine("Son kullanma tarihi:" + card.LastDate);
            #endregion





        }
    }



    #region Kişi için encapsulation yapalım. (hem Ad  hem Cinsiyete)
    //class Kisi
    //{
    //    private string ad;

    //    public string Ad
    //    {
    //        get
    //        {
    //            if (this.cinsiyet == "ERKEK")
    //            {
    //                return "Bay " + ad;
    //            }
    //            else
    //            {
    //                return "Bayan " + ad;
    //            }

    //        }
    //        set { ad = value; }
    //    }


    //    public string Soyad { get; set; }

    //    private string cinsiyet;

    //    public string Cinsiyet
    //    {
    //        get
    //        {
    //            if (cinsiyet == "ERKEK")
    //            {
    //                return "Beyfendi";
    //            }
    //            else
    //            {
    //                return "Hanımefendi";
    //            }

    //        }
    //        set
    //        {
    //            cinsiyet = value.ToUpper();
    //        }
    //    }
    //} 
    #endregion

    #region Ürün classı oluşturalım. Eşya türüne göre elektronik, mobilya veya züccaciye vs yazsın
    //class Urun
    //{
    //    public string EsyaAdi { get; set; }

    //    private string esyaTuru;

    //    public string EsyaTuru
    //    {
    //        get
    //        {
    //            if (esyaTuru == "elektronik")
    //            {
    //                return EsyaAdi + " bir " + esyaTuru + " türüdür";
    //            }

    //            else if (esyaTuru == "mobilya")
    //            {
    //                return EsyaAdi + " bir " + esyaTuru + " türüdür";
    //            }

    //            else if (esyaTuru == "züccaciye")
    //            {
    //                return EsyaAdi + " bir " + esyaTuru + " türüdür";
    //            }
    //            else
    //            {
    //                return EsyaAdi;
    //            }

    //        }
    //        set { esyaTuru = value; }
    //    }

    //}
    #endregion

    #region İlkerin çeyiz çözümü
    //class Ceyiz
    //{
    //    private string ad;
    //    public string Ad { get { return ad; } set { ad = value.ToUpper(); } }

    //    private decimal fiyat;
    //    public decimal Fiyat
    //    {
    //        get
    //        {
    //            if (fiyat > 800)
    //            {
    //                Console.WriteLine($"{this.Ad} ürününe 800 tlden fazla olduğu için yüzde 20 indirim yapıldı");
    //                Console.WriteLine("güle güle kullansın");
    //                Console.WriteLine();
    //                return fiyat * 0.8m;
    //            }
    //            else
    //                return fiyat;
    //        }
    //        set
    //        {
    //            fiyat = value;
    //        }
    //    }

    //    public Ceyiz(string ad, decimal fiyat)
    //    {
    //        Ad = ad;
    //        Fiyat = fiyat;
    //    }
    //}

    //class Nisanli
    //{
    //    private string name;
    //    public string Name { get => name; set => name = value.ToUpper(); }

    //    private string surname;
    //    public string Surname { get => surname; set => surname = value.ToUpper(); }

    //    public string[] Ceyizler { get; set; } = new string[10];
    //    public decimal[] CeyizFiyatlari { get; set; } = new decimal[10];

    //    private byte ceyizAdedi = 0;

    //    public Nisanli(string name, string surname)
    //    {
    //        this.Name = name;
    //        this.Surname = surname;
    //    }
    //    public void CeyizEkle(Ceyiz ceyiz)
    //    {
    //        Ceyizler[ceyizAdedi] = ceyiz.Ad;
    //        CeyizFiyatlari[ceyizAdedi] = ceyiz.Fiyat;
    //        ceyizAdedi++;
    //    }
    //    public void CeyizlerListele()
    //    {
    //        Console.WriteLine($"{this.Name} {this.Surname} aldığı çeyizler");
    //        for (int j = 0; j < ceyizAdedi; j++)
    //        {
    //            Console.WriteLine(Ceyizler[j] + " " + CeyizFiyatlari[j] + " TL");
    //        }
    //    }
    //    public decimal CeyizlerMaliyet()
    //    {

    //        decimal toplam_ucret = CeyizFiyatlari.Sum();
    //        if (toplam_ucret > 1500)
    //        {
    //            Console.WriteLine("toplam ücrete yüzde 5 indirim yapıldı");
    //            return toplam_ucret * 0.95m;
    //        }
    //        else
    //            return toplam_ucret;
    //    }

    //} 
    #endregion

    #region Dikdörtgen classı oluşturalım. En ve boyun 0dan küçük olması durumunda değeri 5 alsın
    //public class Dikdortgen
    //{
    //    private int en;

    //    public int En
    //    {
    //        get { return en; }
    //        set
    //        {
    //            if (value <= 0)
    //            {
    //                Console.WriteLine("en 0'dan küçük olamaz");
    //                en = 5;
    //            }
    //            else

    //                en = value;
    //        }
    //    }

    //    private int boy;
    //    public int Boy
    //    {
    //        get
    //        {
    //            return boy;
    //        }

    //        set
    //        {
    //            if (value <= 0)
    //            {
    //                Console.WriteLine("boy 0'dan küçük olamaz");
    //                boy = 5;
    //            }
    //            else

    //                boy = value;
    //        }

    //    }

    //    public void uzunlukYazdir(int enn, int boyy)
    //    {
    //        this.En = enn;
    //        this.Boy = boyy;
    //        Console.WriteLine("Dikdörtgenin eni: " + this.En);
    //        Console.WriteLine("Dikdörtgenin boyu: " + this.Boy);

    //    }

    //}
    #endregion

    #region Seçmen, Milletvekili ve Cumhurbaşkanı için yaş şartları koyalım 
    //class Kisi
    //{
    //    public string Ad { get; set; }
    //    public string Soyad { get; set; }
    //}
    //class Secmen: Kisi
    //{
    //    public Secmen(string ad, string soyad, int yas)
    //    {
    //        this.Ad = ad;
    //        this.Soyad = soyad;
    //        this.Yas = yas;
    //    }
    //    private int yas;

    //    public int Yas
    //    {
    //        get { return yas; }
    //        set 
    //        {
    //            if (value>18)
    //            {
    //                Console.WriteLine("Seçmen olabilirsiniz");
    //            }
    //            else
    //            {
    //                Console.WriteLine("Yaşınız 18den küçük olduğu için Seçmen olamazsınız");
    //                yas = value;
    //            }
    //        }
    //    }
    //}

    //class Milletvekili: Kisi
    //{
    //    public Milletvekili(string ad, string soyad, int yas)
    //    {
    //        this.Ad = ad;
    //        this.Soyad = soyad;
    //        this.Yas = yas;
    //    }
    //    private int yas;

    //    public int Yas
    //    {
    //        get { return yas; }
    //        set
    //        {
    //            if (value > 30)
    //            {
    //                Console.WriteLine("Milletvekili olabilirsiniz");
    //            }
    //            else
    //            {
    //                Console.WriteLine("Yaşınız 30dan küçük olduğu için Milletvekili olamazsınız");
    //                yas = value;
    //            }
    //        }
    //    }
    //}

    //class Cumhurbaskani : Kisi
    //{
    //    public Cumhurbaskani(string ad, string soyad, int yas)
    //    {
    //        this.Ad = ad;
    //        this.Soyad = soyad;
    //        this.Yas = yas;
    //    }

    //    private int yas;

    //    public int Yas
    //    {
    //        get { return yas; }
    //        set
    //        {
    //            if (value > 40)
    //            {
    //                Console.WriteLine("Cumhurbaşkanı olabilirsiniz");
    //            }
    //            else
    //            {
    //                Console.WriteLine("Yaşınız 40dan küçük olduğu için Cumhurbaşkanı olamazsınız");
    //                yas = value;
    //            }
    //        }
    //    }
    //} 
    #endregion

    #region Seçim
    //    internal class Secim
    //    {
    //        private byte i = 0;
    //        private byte j = 0;
    //        public string[] CbAdayAd { get; set; } = new string[10];
    //        public string[] CbAdaySoyad { get; set; } = new string[10];
    //        public int[] CbOySayisi { get; set; } = new int[10];

    //        public string[] MvAdayAd { get; set; } = new string[10];
    //        public string[] MvAdaySoyad { get; set; } = new string[10];
    //        public int[] MvOySayisi { get; set; } = new int[10];
    //        public void CbEkle(CumhurbaskaniAdayi cumhurbaskani)
    //        {
    //            CbAdayAd[i] = cumhurbaskani.Ad;
    //            CbAdaySoyad[i] = cumhurbaskani.Soyad;
    //            CbOySayisi[i] = cumhurbaskani._oySayisi;
    //            i++;
    //        }

    //        public void MvEkle(MilletvekiliAday milletvekili)
    //        {
    //            MvAdayAd[j] = milletvekili.Ad;
    //            MvAdaySoyad[j] = milletvekili.Soyad;
    //            MvOySayisi[j] = milletvekili._oySayisi;
    //            j++;

    //        }

    //        public void SecimSonuclari()
    //        {
    //            byte cb = 0;
    //            byte mv = 0;
    //            int enYuksekOyMv = 0;
    //            int enYuksekOyCb = 0;
    //            enYuksekOyMv = MvOySayisi.Max();
    //            enYuksekOyCb = CbOySayisi.Max();
    //            for (int i = 0; i < this.i; i++)
    //            {
    //                if (enYuksekOyMv == MvOySayisi[i])
    //                {
    //                    Console.WriteLine($"{MvAdayAd[i]} {MvAdaySoyad[i]} {enYuksekOyMv} oyla mv seçilmiştir hayırlı olsun");
    //                    mv++;

    //                }
    //            }
    //            for (int i = 0; i < this.j; i++)
    //            {
    //                if (enYuksekOyCb == CbOySayisi[i])
    //                {
    //                    Console.WriteLine($"{CbAdayAd[i]} {CbAdaySoyad[i]} {enYuksekOyCb} oyla cb seçilmiştir hayırlı olsun");
    //                    cb++;
    //                }
    //            }
    //            if (cb > 1)
    //                Console.WriteLine($"Cumhurbaşkanlığı seçiminde {cb} aday eşit oy almıştır seçim ikinci tura kaldı");
    //            if (mv > 1)
    //                Console.WriteLine($"Milletvekilliği seçiminde {mv} aday eşit oy almıştır seçim ikinci tura kaldı");
    //        }

    //    }
    //}


    //internal class CumhurbaskaniAdayi : Vatandas
    //{
    //    public int _oySayisi = 0;
    //    public CumhurbaskaniAdayi() : base()
    //    {

    //    }
    //    public CumhurbaskaniAdayi(string ad, string soyad, byte yas) : base(ad, soyad, yas)
    //    {
    //        if (yas < 18)
    //        {
    //            this.Ad = null;
    //            this.Soyad = null;
    //            this.Yas = 0;
    //            Console.WriteLine($"yaşı 18'den küçük olduğu için aday olamaz  ");
    //        }
    //    }
    //    public void OyKulan(MilletvekiliAday milletvekiliAday, CumhurbaskaniAdayi cumhurbaskaniAdayi)
    //    {
    //        milletvekiliAday._oySayisi++;
    //        cumhurbaskaniAdayi._oySayisi++;

    //    }
    //}


    //internal class MilletvekiliAday : Vatandas
    //{
    //    public int _oySayisi = 0;
    //    public MilletvekiliAday() : base()
    //    {

    //    }
    //    public MilletvekiliAday(string ad, string soyad, byte yas) : base(ad, soyad, yas)
    //    {
    //        if (yas < 18)
    //        {
    //            this.Ad = null;
    //            this.Soyad = null;
    //            this.Yas = 0;
    //            Console.WriteLine($"yaşı 18'den küçük olduğu için aday olamaz  ");
    //        }
    //    }
    //    public void OyKulan(MilletvekiliAday milletvekiliAday, CumhurbaskaniAdayi cumhurbaskaniAdayi)
    //    {
    //        milletvekiliAday._oySayisi++;
    //        cumhurbaskaniAdayi._oySayisi++;

    //    }
    //}

    //class Vatandas
    //{
    //    private string ad;
    //    public string Ad { get => ad; set => ad = value.ToUpper(); }
    //    private string soyad;
    //    public string Soyad { get => soyad; set => soyad = value.ToUpper(); }

    //    private byte yas;
    //    public byte Yas
    //    {
    //        get { return yas; }
    //        set
    //        {
    //            if (value > 17)
    //                yas = value;
    //            else
    //            {
    //                // Console.WriteLine("yas 18 den küçük olduğu için oy kullanamaz");
    //                yas = value;
    //            }

    //        }

    //    }
    //    public Vatandas()
    //    {

    //    }

    //    public Vatandas(string ad, string soyad, byte yas)
    //    {
    //        this.Ad = ad;
    //        this.Soyad = soyad;
    //        this.Yas = yas;

    //    }

    //    public void OyKulan(MilletvekiliAday milletvekiliAday, CumhurbaskaniAdayi cumhurbaskaniAdayi)
    //    {
    //        if (this.Yas > 17)
    //        {
    //            milletvekiliAday._oySayisi++;
    //            cumhurbaskaniAdayi._oySayisi++;
    //        }
    //        else
    //            Console.WriteLine(this.Ad + " " + this.Soyad + " yaşı küçük olduğu için oy kullanamaz");

    //    }

    //} 
    #endregion

    #region Kredi kartı yapalım
    ////Kart no 16 karakterli, tarih 5 karakterli, cvv 3 karakterli olmalıdır. Çıktı olarak gösterilirken kart no 1234**********45 şeklinde, cvv **1 şeklinde gözükmeli

    //class CreditCard
    //{
    //    private string _cardNo;
    //    public string CardNo
    //    {
    //        get
    //        {

    //            return _cardNo.Substring(0, 4) + "**********" + _cardNo.Substring(14, 2);

    //        }
    //        set
    //        {
    //            if (value.Length == 16)
    //                _cardNo = value;
    //            else
    //            {
    //                Console.WriteLine("Kart no 16 haneli olmalıdır numaranızı tekrar girin");
    //                _cardNo = "****************";
    //            }
    //        }
    //    }

    //    private string _cvv;
    //    public string CVV
    //    {
    //        get
    //        {
    //            return "**" + _cvv.Substring(2);
    //        }
    //        set
    //        {
    //            if (value.Length == 3)
    //                _cvv = value;
    //            else
    //            {
    //                Console.WriteLine("CVV 3 haneli olmalıdır numaranızı tekrar girin");
    //                _cvv = "***";
    //            }
    //        }
    //    }

    //    private DateTime _lastdate;

    //    public DateTime LastDate
    //    {
    //        get
    //        {
    //            return _lastdate;
    //        }
    //        set { _lastdate = value; }
    //    }



    //    public CreditCard()
    //    {

    //    }
    //    public CreditCard(string cardNo, string cvv, DateTime date)
    //    {
    //        this.CardNo = cardNo;
    //        this.CVV = cvv;
    //        this.LastDate = date;
    //    }

    //}
    #endregion














}


