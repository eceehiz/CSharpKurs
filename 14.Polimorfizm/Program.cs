using System;

namespace _14.Polimorfizm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metot ismi aynı olduğu durumlarda, içeriğin farklı olmasını istiyorsak o metodu ezmemiz gerekiyor.

            #region SelamVer metodunu kullanalım
            //Turk turk = new Turk();
            //Console.WriteLine(turk.SelamVer());

            //Ingiliz ingiliz = new Ingiliz();
            //Console.WriteLine(ingiliz.SelamVer());

            //Alman alman = new Alman();
            //Console.WriteLine(alman.SelamVer()); 
            #endregion

            #region SunumGoster metodunu kullanalım

            //AnaYemek ana = new AnaYemek();
            //SebzeYemekleri sebze = new SebzeYemekleri();
            //AraSıcaklar ara = new AraSıcaklar();
            //Tatlılar tatli = new Tatlılar();

            //ana.Adi = "Patlıcan Kebabı";
            //sebze.Adi = "Pastırmalı Kuru Fasulye";
            //ara.Adi = "Paçanga";
            //tatli.Adi = "Kalbura bastı";

            //Console.WriteLine(ana.Adi + " " + ana.SunumSekli());
            //Console.WriteLine(sebze.Adi + " " + sebze.SunumSekli());
            //Console.WriteLine(ara.Adi + " " + ara.SunumSekli());
            //Console.WriteLine(tatli.Adi + " " + tatli.SunumSekli());

            //Console.WriteLine("=============================================");

            //Sunumlar snm = new Sunumlar();
            //snm.SunumGoster(ana);
            //snm.SunumGoster(ara);
            //snm.SunumGoster(sebze);
            //snm.SunumGoster(tatli);

            #endregion

            #region FiyatGoster metodunu kullanalım
            //Tekstil tekstil = new Tekstil();
            //Unlu unlu = new Unlu();
            //Elektronik elektronik = new Elektronik();

            //Fiyatlar fiyat = new Fiyatlar();
            //fiyat.FiyatGoster(tekstil);
            //fiyat.FiyatGoster(unlu);
            //fiyat.FiyatGoster(elektronik); 
            #endregion







        }
    }

    #region Person classı ve miras vereceği alt classları oluşturalım. Selam ver metodu olsun, bunu ezelim

    //class Person
    //{
    //    public virtual string SelamVer()
    //    {
    //        return " ";
    //    }
    //}

    //class Turk : Person
    //{
    //    public override string SelamVer()
    //    {
    //        //return base.SelamVer(); //otomatik geldi. base: miras aldığı sınıf. bunu alt satırda ezelim
    //        return "Merhaba";
    //    }

    //}

    //class Ingiliz : Person
    //{
    //    public override string SelamVer()
    //    {
    //        // return base.SelamVer(); //eziyoruz
    //        return "Hi";
    //    }
    //}
    //class Alman : Person
    //{
    //    public override string SelamVer()
    //    {
    //        // return base.SelamVer(); //eziyoruz
    //        return "Hallo";
    //    }
    //}
    #endregion

    #region Yemek classı ve miras vereceği classları oluşturalım. Sunum şekli metodu olsun, bunu ezelim
    //class Yemek
    //{
    //    public string Adi { get; set; }
    //    public string PismeSuresi { get; set; }
    //    public string Malzemeler { get; set; }
    //    public string AciTipi { get; set; }
    //    public string Asci { get; set; }
    //    public string PismeSekli { get; set; }
    //    public string PismeYeri { get; set; }
    //    public virtual string SunumSekli()
    //    {
    //        return "Pilav ile ";
    //    }
    //}
    //class AnaYemek : Yemek
    //{
    //    public string Cesit { get; set; }
    //    public override string SunumSekli()
    //    {
    //        return "Salata ile ";
    //    }

    //}
    //class SebzeYemekleri : Yemek
    //{
    //    public string SebzeTipi { get; set; }
    //    public string SuluSusuz { get; set; }
    //    public override string SunumSekli()
    //    {
    //        return "Yoğurt ile ";
    //    }
    //}
    //class Tatlılar : Yemek
    //{
    //    public override string SunumSekli()
    //    {
    //        return "Kaymak ile ";
    //    }
    //}
    //class AraSıcaklar : Yemek
    //{
    //    public override string SunumSekli()
    //    {
    //        return "Haydari ile ";
    //    }
    //}
    //class Sunumlar
    //{
    //    public void SunumGoster(Yemek yemek)
    //    {
    //        Console.WriteLine(yemek.SunumSekli());

    //    }
    //}
    #endregion

    #region Urun classı ve miras vereceği classları yapalım. Kdv hesapla metodu olsun, bunu ezelim
    //class Urun
    //{
    //    public string Ad { get; set; }
    //    public decimal Fiyat { get; set; }
    //    public virtual decimal KdvHesapla(decimal fiyat)
    //    {
    //        return fiyat;
    //    }

    //}
    //class Tekstil : Urun
    //{
    //    public override decimal KdvHesapla(decimal fiyat)
    //    {
    //        return fiyat = fiyat + fiyat * 8 / 100;
    //    }
    //}
    //class Unlu : Urun
    //{
    //    public override decimal KdvHesapla(decimal fiyat)
    //    {
    //        return fiyat = fiyat + fiyat * 1 / 100;
    //    }
    //}
    //class Elektronik : Urun
    //{
    //    public override decimal KdvHesapla(decimal fiyat)
    //    {
    //        return fiyat = fiyat + fiyat * 18 / 100;
    //    }
    //}
    //class Fiyatlar
    //{
    //    public void FiyatGoster(Urun urun)
    //    {
    //        Console.WriteLine("Ürünün kdv dahil fiyatı: " + urun.KdvHesapla(100));

    //    }
    //} 
    #endregion




}
