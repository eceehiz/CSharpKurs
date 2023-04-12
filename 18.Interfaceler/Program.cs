using System;

namespace _18.Interfaceler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface, kendisinden miras alacak sınıflarda imzasını barındıran bir yapıdır
            //İmzalarda erişim belirleyicilerin olmasına gerek yok, default olarak publictir
            //Bir şablon olarak kullanırız
            //Newlenemez
            //Bir sınıfa yetenek ve özellik kazandırmak için kullanılır

            #region Hayvanlar alemi
            ////Penguen penguen = new Penguen("yusuf");
            ////Yarasa yarasa = new Yarasa("nafih");
            ////Papagan papagan = new Papagan("talha");
            ////Kus genelkus = new Papagan("Cenkalp");

            ////genelkus.OzellikleriGoster();

            ////Console.WriteLine("\n**************************************\n");

            ////penguen.Konusmak();
            ////yarasa.Konusmak();
            ////papagan.Konusmak();

            ////Console.WriteLine("\n**************************************\n");

            ////penguen.Yuzmek();
            ////yarasa.Dogurmak();

            ////Console.WriteLine("\n**************************************\n");

            ////yarasa.Ucmak();
            ////papagan.Ucmak();

            ////Console.WriteLine("\n**************************************\n");

            ////yarasa.Dogurmak(); 
            #endregion

            #region Baba, anne, çocuklar için değerler girelim
            //Baba baba = new Baba();
            //baba.Adi = "Muzaffer";
            //baba.Soyadi = "Konak";
            //baba.Yas = 55;
            //baba.SacRengi = "Beyaz";
            //baba.GozRengi = "Siyah";
            //baba.Maas = 10000;
            //baba.Sakal = true;

            //Anne anne = new Anne();
            //anne.Adi = "Hediye";
            //anne.Soyadi = "Konak";
            //anne.Yas = 52;
            //anne.SacRengi = "Siyah";
            //anne.GozRengi = "Yeşil";
            //anne.Orgu = true;
            //anne.Makyaj = false;
            //anne.Tesettur = true;

            //ErkekCocuk erkekcocuk = new ErkekCocuk();
            //erkekcocuk.Adi = "Ege";
            //erkekcocuk.Soyadi = "Konak";
            //erkekcocuk.Yas = 10;
            //erkekcocuk.SacRengi = "Kahverengi";
            //erkekcocuk.GozRengi = "Ela";
            //erkekcocuk.Sakal = false;
            //erkekcocuk.OkulNo = 989;

            //KizCocuk kizCocuk = new KizCocuk();
            //kizCocuk.Adi = "Sinem";
            //kizCocuk.Soyadi = "Konak";
            //kizCocuk.Yas = 15;
            //kizCocuk.SacRengi = "Sarı";
            //kizCocuk.GozRengi = "Mavi";
            //kizCocuk.Makyaj = true;
            //kizCocuk.Tesettur = false;
            //kizCocuk.OkulNo = 125;

            //Console.WriteLine("***************KONAK AİLESİNİN ÜYELERİ*******************************");
            //Console.WriteLine("1- Baba");
            //Console.WriteLine("Babanın Adı: " + baba.Adi + "\nBabanın Yaşı: " + baba.Yas);
            //baba.YetenekBelirt();
            //Console.WriteLine();
            //Console.WriteLine("2- Anne");
            //Console.WriteLine("Annenin Adı: " + anne.Adi + "\nAnnenin Yaşı: " + anne.Yas);
            //anne.YetenekBelirt();
            //Console.WriteLine();
            //Console.WriteLine("3- Erkek Çocuk");
            //Console.WriteLine("Erkek Çocuğun Adı: " + erkekcocuk.Adi + "\nErkek Çocuğun Yaşı: " + erkekcocuk.Yas);
            //erkekcocuk.YetenekBelirt();
            //Console.WriteLine();
            //Console.WriteLine("4- Kız Çocuk");
            //Console.WriteLine("Kız Çocuğun Adı: " + kizCocuk.Adi + "\nKız Çocuğun Yaşı: " + kizCocuk.Yas);
            //kizCocuk.YetenekBelirt(); 
            #endregion

            #region Satıcı, alıcı, kargocu için değerler girelim
            //Satici satici = new Satici();
            //satici.Id = 1;
            //satici.Adi = "Fatma";
            //satici.Soyadi = "Can";
            //satici.Bolge = "Türkiye";

            //Alici alici = new Alici();
            //alici.Adi = "Fadime";
            //alici.Soyadi = "Deniz";

            //Urun urun = new Urun();
            //urun.UrunAdi = "Fasulye";
            //urun.Turu = "Gıda";
            //urun.Fiyat = 30;
            //urun.Agirlik = 5;

            //Urun urun3 = new Urun();
            //urun3.UrunAdi = "Buzdolabı";
            //urun3.Turu = "Beyaz Eşya";
            //urun3.Agirlik = 30;

            //Console.WriteLine(satici.Adi + " adlı satıcı " + alici.Adi + " adlı alıcıya " + urun.UrunAdi + " ürününü sattı");

            //Kargocu kargocu = new Kargocu();
            //kargocu.TasimaKapasitesi(urun);
            //kargocu.TasimaKapasitesi(urun3);
            #endregion

            #region Oyuncu, oyun için değerler girelim
            //Oyuncu oyuncu = new Oyuncu();
            //oyuncu.Id = 1;
            //oyuncu.NickName = "BüyükBalik";
            //oyuncu.Ad = "Emre";
            //oyuncu.Yas = 24;

            //oyuncu.Silahi = new Kanas();

            //Silah AK47 = new Kanas();

            //Console.Write("Kaç kademe yaklaştırmak istiyorsunuz: ");
            //int oran = Convert.ToInt32(Console.ReadLine());
            //Kanas kanas = new Kanas();
            //kanas.Yakinlastir(oran); 
            #endregion

            #region Nüfus cüzdanı, ehliyet için değerler girelim
            //NufusCuzdani nfs = new NufusCuzdani();
            //nfs.Ad = "Engin";
            //nfs.Soyad = "Demir";
            //DateTime dt = new DateTime(1998, 03, 18);
            //nfs.DogumTarihi = dt;
            //nfs.DogumYeri = "Adana";
            //nfs.Kullanim();


            //Ehliyet ehl = new Ehliyet();
            //ehl.Ad = nfs.Ad;
            //ehl.Soyad = ehl.Soyad;
            //ehl.Kullanim();

            //Kontrol kontrol = new Kontrol();
            //kontrol.KontrolEt(ehl); 
            #endregion

            #region Tapu için değerler girelim
            //Ev ev1 = new Ev()
            //{
            //    Ad = "Hakkı",
            //    Soyad = "Bulut",
            //    Il = "Edirne",
            //    Ilce = "Merkez",
            //    Mahalle = "Bosnaköy",
            //    Hisse = "Tam",
            //    Nitelik = "Arsa",
            //    YuzOlcumu = 5000,
            //    Tarih = "23.03.2023"
            //};
            //// Ev1.Olustur();

            //Kontrol k1 = new Kontrol();
            //k1.KontrolEt(ev1); 
            #endregion






        }
    }

    #region Interface'i öğrenelim
    //interface IArayuz
    //{
    //    int Sayfa { get; set; }
    //    void SayfaOlustur(); //metodun gövdesi yok
    //    string SayfaSayisi();
    //    int KenarBosluklari { get; set; }
    //}
    //class Gazete : Haberler, IArayuz, IIcerik
    //{
    //    public int Sayfa { get; set; }
    //    public int KenarBosluklari { get; set; }
    //    public string Manset { get; set; }
    //    public string Baslik { get; set; }

    //    public void SayfaOlustur()
    //    {
    //        Console.WriteLine("Gazete sayfası oluşturuldu");
    //    }

    //    public string SayfaSayisi()
    //    {
    //        return "15";
    //    }
    //}

    //class Haberler
    //{
    //    public string Adres { get; set; }
    //    public string HaberTuru { get; set; }
    //}

    //interface IIcerik
    //{
    //    string Manset { get; set; }
    //    string Baslik { get; set; }
    //} 
    #endregion

    #region Çalışan interfacei yapalım
    //class Calisan
    //{
    //    public string Adi { get; set; }
    //    public string Soyadi { get; set; }
    //    public decimal Maas { get; set; }
    //    public string Gorev { get; set; }
    //}
    //class Memur : Calisan, IYemekYiyebilme, IMaasAlabilme
    //{
    //    public string Departman { get; set; }

    //    public void MaasAlma()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Yemek()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //class Sekreter: Calisan, IYemekYiyebilme, IMaasAlabilme
    //{
    //    public string Departman { get; set; }

    //    public void MaasAlma()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Yemek()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //class Patron : Calisan, IYemekYiyebilme
    //{
    //    public void Yemek()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //class Robot: Calisan
    //{

    //}

    //interface IYemekYiyebilme
    //{
    //    void Yemek();
    //}
    //interface IMaasAlabilme
    //{
    //    void MaasAlma();
    //} 
    #endregion

    #region Hayvanlar alemi için interface yapalım
    //interface IYuzmeDavranisi
    //{
    //    void Yuzmek();
    //}

    //interface IUcmaDavranisi
    //{
    //    void Ucmak();
    //}

    //interface IKonusmaDavranisi
    //{
    //    void Konusmak();
    //}

    //interface IDogurganlik
    //{
    //    void Dogurmak();
    //}

    //abstract class Kus
    //{
    //    public virtual string KusAdi { get; set; }
    //    public string KusTipi = "Genel kuş tipi";

    //    public void OzellikleriGoster()
    //    {
    //        Console.WriteLine("{0}'in yetenekleri belirsizdir...kuştan kuşa değişir.", KusAdi);
    //    }

    //}

    //class Papagan : Kus, IKonusmaDavranisi, IUcmaDavranisi
    //{
    //    public Papagan(string KusAdi)
    //    {
    //        this.KusAdi = KusAdi;
    //        base.KusTipi = "Papağan";
    //    }

    //    public override string KusAdi { get; set; }

    //    public void Konusmak()
    //    {
    //        Console.WriteLine("{0}'in {1} konusmasi 'insanınki gibidir'", KusAdi, KusTipi);
    //    }

    //    public void Ucmak()
    //    {
    //        Console.WriteLine("{0}'in standart kuş uçuşu", KusAdi);
    //    }
    //}
    //class Penguen : Kus, IYuzmeDavranisi, IKonusmaDavranisi
    //{
    //    public Penguen(string KusAdi)
    //    {
    //        this.KusAdi = KusAdi;
    //        base.KusTipi = "Penguen";
    //    }

    //    public override string KusAdi { get; set; }

    //    public void Konusmak()
    //    {
    //        Console.WriteLine("{0}'nın {1} konusmasi 'wak wak'", KusAdi, KusTipi);
    //    }

    //    public void Yuzmek()
    //    {
    //        Console.WriteLine("{0}'nın {1} yüzüşü 'yüzebilen tek kuş türüdür'", KusAdi, KusTipi);
    //    }
    //}
    //class Yarasa : Kus, IKonusmaDavranisi, IUcmaDavranisi, IDogurganlik
    //{
    //    public Yarasa(string KusAdi)
    //    {
    //        this.KusAdi = KusAdi;
    //        base.KusTipi = "Yarasa";
    //    }

    //    public override string KusAdi { get; set; }

    //    public void Dogurmak()
    //    {
    //        Console.WriteLine("{0}'in {1} yumurtlaması 'memeli olan tek kuş türü olduğu için'", KusAdi, KusTipi);
    //    }

    //    public void Konusmak()
    //    {
    //        Console.WriteLine("{0}'in {1} konusmasi 'Cik cik'", KusAdi, KusTipi);
    //    }

    //    public void Ucmak()
    //    {
    //        Console.WriteLine("{0}'in standart kuş uçuşu", KusAdi);
    //    }
    //} 
    #endregion

    #region Kişi, Kadın, Erkek interfacelerini oluşturalım
    //abstract class Kisi
    //{
    //    public string Adi { get; set; }
    //    public string Soyadi { get; set; }
    //    public byte Yas { get; set; }
    //    public string SacRengi { get; set; }
    //    public string GozRengi { get; set; }
    //    public abstract void YetenekBelirt();

    //}
    //interface IKadin
    //{
    //    public bool Makyaj { get; set; }
    //    public bool Tesettur { get; set; }
    //}
    //interface IErkek
    //{
    //    public bool Sakal { get; set; }
    //}
    //class Baba : Kisi, IErkek
    //{
    //    public decimal Maas { get; set; }
    //    public bool Sakal { get; set; }

    //    public override void YetenekBelirt()
    //    {
    //        Console.WriteLine("Tadilat işlerinden anlar");
    //    }
    //}
    //class Anne : Kisi, IKadin
    //{
    //    public bool Orgu { get; set; }
    //    public bool Makyaj { get; set; }
    //    public bool Tesettur { get; set; }

    //    public override void YetenekBelirt()
    //    {
    //        Console.WriteLine("Örgü örebilir");
    //    }
    //}
    //class ErkekCocuk : Kisi, IErkek
    //{
    //    public int OkulNo { get; set; }
    //    public bool Sakal { get; set; }

    //    public override void YetenekBelirt()
    //    {
    //        Console.WriteLine("İyi futbol oynar");
    //    }
    //}
    //class KizCocuk : Kisi, IKadin
    //{
    //    public int OkulNo { get; set; }
    //    public bool Makyaj { get; set; }
    //    public bool Tesettur { get; set; }

    //    public override void YetenekBelirt()
    //    {
    //        Console.WriteLine("Güzel seksek oynar");
    //    }
    //} 
    #endregion

    #region Kişi interfacei yapalım. Satıcı, Alıcı, Kargocu oluşturalım
    //class Satici : IKisi
    //{
    //    public int Id { get; set; }
    //    public string Adi { get; set; }
    //    public string Soyadi { get; set; }
    //    public int VergiNo { get; set; }
    //    public string Bolge { get; set; }
    //    public string TcNo { get; set; }
    //}
    //class Alici : IKisi
    //{
    //    public int Id { get; set; }
    //    public string Adi { get; set; }
    //    public string Soyadi { get; set; }
    //    public string TcNo { get; set; }
    //}
    //class Kargocu : IKisi, ITasiyabilirlik
    //{
    //    public int Id { get; set; }
    //    public string Adi { get; set; }
    //    public string Soyadi { get; set; }
    //    public string Bolge { get; set; }
    //    public Arac Araci { get; set; }

    //    public void TasimaKapasitesi(Urun urun)
    //    {
    //        if (urun.Agirlik > 10)
    //        {
    //            Console.WriteLine("Ağırlık 10 kilodan fazla olduğundan kargoyu araba ile gönder");
    //        }
    //        else if (urun.Agirlik > 5)
    //        {
    //            Console.WriteLine("Ağırlık 5 kilodan fazla olduğundan kargoyu motorsiklet ile gönder");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Ağırlık 5 kilodan az olduğundan kargoyu bisiklet ile gönder");
    //        }
    //    }

    //}

    //interface ITasiyabilirlik
    //{
    //    public void TasimaKapasitesi(Urun urun);

    //}
    //class Arac
    //{
    //    public static string AracTuru { get; set; }
    //}
    //class Urun
    //{
    //    public string UrunAdi { get; set; }
    //    public string Turu { get; set; }
    //    public int Fiyat { get; set; }
    //    public int Agirlik { get; set; }

    //}
    //interface IKisi
    //{
    //    public int Id { get; set; }
    //    public string Adi { get; set; }
    //    public string Soyadi { get; set; }
    //}
    #endregion

    #region Oyuncu, Silah ve çeşitlerini oluşturalım
    //class Oyuncu
    //{
    //    public int Id { get; set; }
    //    public string NickName { get; set; }
    //    public string Ad { get; set; }
    //    public int Yas { get; set; }
    //    public string Milleti { get; set; }
    //    public Silah Silahi { get; set; }
    //    public string NisanAl()
    //    {
    //        return " ";
    //    }
    //    public void Saldir()
    //    {

    //    }

    //}

    //class Silah
    //{
    //    public int VurusGücü { get; set; }
    //    public double Agirlik { get; set; }
    //    public int Mesafe { get; set; }
    //}
    //class AtesliSilahlar : Silah
    //{
    //    public string MaxMermiMiktari { get; set; }
    //    public int MermiSayisi { get; set; }
    //    public void SarjorDegistir(int adet)
    //    {
    //        while (adet > 0)
    //        {
    //            Console.ReadLine();
    //            Console.WriteLine("Mermi sayısı: " + adet);
    //            adet--;
    //        }
    //        if (adet == 0)
    //        {
    //            Console.WriteLine("Şarjör değiştir");
    //        }
    //    }
    //}
    //class KesiciSilahlar : Silah
    //{
    //    public float Dayaniklilik { get; set; }
    //}
    //interface IYakinlastirilabilir
    //{
    //    void Yakinlastir(int oran);
    //}
    //class Kanas : AtesliSilahlar, IYakinlastirilabilir
    //{
    //    public void Yakinlastir(int oran)
    //    {
    //        if (oran == 1)
    //        {
    //            Console.WriteLine("%25 yakınlaştı");
    //        }
    //        else if (oran == 2)
    //        {
    //            Console.WriteLine("%50 yakınlaştı");
    //        }
    //        else if (oran == 3)
    //        {
    //            Console.WriteLine("%75 yakınlaştı");
    //        }
    //        else if (oran == 4)
    //        {
    //            Console.WriteLine("%100 yakınlaştı");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Yanlış seçim");
    //        }

    //    }
    //} 
    #endregion

    #region Kimlik interfacei yapalım
    //interface IKimlik
    //{
    //    public string Ad { get; set; }
    //    public string Soyad { get; set; }
    //    public string TcNo { get; set; }
    //    public void Kullanim();

    //}
    //class NufusCuzdani : IKimlik
    //{
    //    public DateTime DogumTarihi { get; set; }
    //    public string DogumYeri { get; set; }
    //    public string Ad { get; set; }
    //    public string Soyad { get; set; }
    //    public string TcNo { get; set; }
    //    public void Kullanim()
    //    {
    //        Console.WriteLine("Nüfus cüzdanı kullanıldı");
    //    }
    //}
    //class Ehliyet : IKimlik
    //{
    //    public string Sinif { get; set; }
    //    public string Ad { get; set; }
    //    public string Soyad { get; set; }
    //    public string TcNo { get; set; }

    //    public void Kullanim()
    //    {
    //        Console.WriteLine("Ehliyet kullanıldı");
    //    }
    //}
    //class OkulKarti : IKimlik
    //{
    //    public string OkulAdi { get; set; }
    //    public string Ad { get; set; }
    //    public string Soyad { get; set; }
    //    public string TcNo { get; set; }

    //    public void Kullanim()
    //    {
    //        Console.WriteLine("Okul kartı kullanıldı");
    //    }
    //}
    //class Kontrol
    //{
    //    public void KontrolEt(IKimlik kml)
    //    {
    //        kml.Kullanim();

    //    }
    //} 
    #endregion

    #region Tapu interfacei yapalım
    //interface ITapu
    //{
    //    string Ad { get; set; }
    //    string Soyad { get; set; }
    //    string Tarih { get; set; }
    //    string Nitelik { get; set; }
    //    string Hisse { get; set; }
    //    int YuzOlcumu { get; set; }
    //    string Il { get; set; }
    //    string Ilce { get; set; }
    //    string Mahalle { get; set; }
    //    public void Olustur();
    //}
    //class Ev : ITapu
    //{
    //    public string Ad { get; set; }
    //    public string Soyad { get; set; }
    //    public string Tarih { get; set; }
    //    public string Nitelik { get; set; }
    //    public string Hisse { get; set; }
    //    public int YuzOlcumu { get; set; }
    //    public string Il { get; set; }
    //    public string Ilce { get; set; }
    //    public string Mahalle { get; set; }

    //    public void Olustur()
    //    {
    //        Console.WriteLine("Ev Tapusu Oluşturuldu.");
    //        Console.WriteLine("Adı: " + Ad + "\n" + "Soyadı: " + Soyad + "\n" + "İl: " + Il + "\n" + "İlce:" + Ilce + "\n" + "Mahalle: " + Mahalle + "\n" + "Hissesi: " + Hisse + "\n" + "Yüzölçümü: " + YuzOlcumu + "m2" + "\n" + "Tarih: " + Tarih);
    //    }
    //}

    //class Arsa : ITapu
    //{
    //    public string Ad { get; set; }
    //    public string Soyad { get; set; }
    //    public string Tarih { get; set; }
    //    public string Nitelik { get; set; }
    //    public string Hisse { get; set; }
    //    public int YuzOlcumu { get; set; }
    //    public string Il { get; set; }
    //    public string Ilce { get; set; }
    //    public string Mahalle { get; set; }

    //    public void Olustur()
    //    {
    //        Console.WriteLine("Arsa Tapusu Oluşturuldu.");
    //    }
    //}
    //class Kontrol
    //{
    //    public void KontrolEt(ITapu tapu)
    //    {
    //        tapu.Olustur();
    //    }
    //} 
    #endregion





}
