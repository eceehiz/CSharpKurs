using System;

namespace _08.ClasslaraGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Kişi oluşturalım
            //Kisi adem = new Kisi();
            //adem.ad = "Adem";
            //adem.soyad = "Öztürk";
            //adem.yas = 16;

            //Kisi sinan = new Kisi();
            //sinan.ad = "Sinan";
            //sinan.soyad = "Kılıç";
            //sinan.yas = 38;

            //Kisi ece = new Kisi();
            //ece.yas = 24;
            //ece.ad = "Ece";
            //ece.soyad = "Hız";
            //ece.cinsiyet = "Kadın";
            //ece.gozrengi = "Kahverengi";
            //ece.ırk = "TC";

            //ece.Ozellik();
            #endregion

            #region Kitap oluşturalım
            //Kitap kitap = new Kitap();
            //kitap.KitapAdi = "Serenad";
            //kitap.Yazari = "Lütfü Livaneli";
            //kitap.SayfaSayisi = 350;
            //kitap.BasimYili = 1980;

            //kitap.KitapSec();
            #endregion

            #region Dörtgen oluşturalım
            //Dortgen dortgen = new Dortgen();
            //Console.Write("Uzun kenarı giriniz: ");
            //dortgen.UzunKenar = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Kısa kenarı giriniz: ");
            //dortgen.KısaKenar = Convert.ToInt32(Console.ReadLine());
            //dortgen.CevreHesapla();
            //dortgen.AlanHesapla();
            #endregion

            #region Arac ve Müşteri oluşturalım
            //Arac arac1 = new Arac();
            //arac1.Marka = "Volkswagen";
            //arac1.Model = 2017;
            //arac1.Renk = "Mavi";
            //arac1.YakıtTipi = "Dizel";
            //arac1.Vites = "Otomatik";

            //Arac arac2 = new Arac();
            //arac2.Marka = "Renault";
            //arac1.Model = 2022;
            //arac1.Renk = "Kum Beji";
            //arac1.YakıtTipi = "Benzin";
            //arac1.Vites = "Manuel";

            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Selim";
            //musteri1.Soyadi = "Güngör";
            //musteri1.Yasi = 28;

            //Musteri musteri2 = new Musteri();
            //musteri2.Adi = "Murat";
            //musteri2.Soyadi = "Yıldız";
            //musteri2.Yasi = 54;

            //arac2.AracAlma(musteri1);
            #endregion

            #region Öğretmen, öğrenci ve kitabı oluşturalım
            //Ogretmen ogretmen1 = new Ogretmen();
            //ogretmen1.OgretmenAdi = "Selma";
            //ogretmen1.OgretmenBransi = "Türkçe";
            //Ogretmen ogretmen2 = new Ogretmen();
            //ogretmen2.OgretmenAdi = "Arif";
            //ogretmen2.OgretmenBransi = "Matematik";

            //Ogrenci ogrenci1 = new Ogrenci();
            //ogrenci1.OgrenciAdi = "Ali";
            //ogrenci1.OgrenciNo = 123;
            //Ogrenci ogrenci2 = new Ogrenci();
            //ogrenci2.OgrenciAdi = "Veli";
            //ogrenci2.OgrenciNo = 456;

            //Kitap kitap1 = new Kitap();
            //kitap1.KitapAdi = "Serenad";
            //kitap1.KitapSayfaSayisi = 350;
            //Kitap kitap2 = new Kitap();
            //kitap2.KitapAdi = "Kürk Mantolu Madonna";
            //kitap2.KitapSayfaSayisi = 270;

            //kitap1.KitapVer(ogretmen1, ogrenci1);
            //kitap2.KitapVer(ogretmen2, ogrenci2);
            //kitap1.KitapVer(ogretmen1, ogrenci2);
            //kitap2.KitapVer(ogretmen2, ogrenci1);
            #endregion

            #region Ref'i kullanalım
            //int a = 20;
            //int b = 30;
            //Console.WriteLine(a + b);
            //var net = Referans(ref a, b);
            //Console.WriteLine(net);
            //Console.WriteLine(a + b);
            #endregion

            #region Ürün ve Sepet oluşturalım

            //double sayac = 0, sepet_toplam = 0;

            //Urun urun1 = new Urun();

            //urun1.Ad = "Süt";
            //urun1.Fiyat = 18;
            //urun1.Kategori = "İçecek";
            //urun1.SonKullanmaTarihi = 2024;
            //Console.WriteLine("Eklenen ürün : " + urun1.Ad + " Fiyatı : " + urun1.Fiyat + " TL ");

            //sayac++;

            //sepet_toplam = sepet_toplam + urun1.Fiyat;

            //Urun urun2 = new Urun();

            //urun2.Ad = "Ekmek";
            //urun2.Fiyat = 5;
            //urun2.Kategori = "Yiyecek";
            //urun2.SonKullanmaTarihi = 2023;
            //Console.WriteLine("Eklenen ürün : " + urun2.Ad + " Fiyatı : " + urun2.Fiyat + " TL ");

            //sayac++;

            //if (sayac >= 2)
            //{
            //    urun2.Fiyat = urun2.Fiyat * 0.8;
            //    Console.WriteLine("2.üründe %20 indirim uygulandı");
            //}

            //sepet_toplam = sepet_toplam + urun2.Fiyat;

            //Sepet sepet = new Sepet();

            //sepet.Sepet_Toplam = sepet_toplam;
            //Console.WriteLine("Sepet toplam: " + sepet.Sepet_Toplam);
            #endregion

            #region İndirim yapalım
            //Tanesi 100 TL olan kitaplardan kullanıcı 2 adet ve daha fazlasını alırsa toplam tutardan yüzde 20 indirim yapalım
            //short indirimOrani = 0;

            //Console.Write("Kaç adet kitap istiyorsunuz: ");
            //byte adet = byte.Parse(Console.ReadLine());

            //decimal ucret = adet * 100;

            //Console.WriteLine("İndirim yapılmamış fiyat: " + ucret);

            //decimal toplam = IndirimYap(adet, ref indirimOrani, ucret);
            //Console.WriteLine("Aldığınız kitaplara yüzde " + indirimOrani + " indirim yapılmıştır. Toplam fiyat: " + toplam);
            #endregion

            #region Kdvli fiyat hesaplayalım
            //decimal kdvOranı; //out kullanmak istersek başta değer vermeyeceğiz

            //Console.Write("Unlu mamul için 1, kırtasiye için 2, diğer ürünler için 3ü tuşlayın: ");
            //int urun = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ürünün fiyatını giriniz: ");
            //decimal urunFiyati = Convert.ToInt32(Console.ReadLine());

            //decimal maliyet = FiyatHesapla(urun, out kdvOranı, urunFiyati);
            //Console.WriteLine("Aldığınız ürünün toplam maliyeti: " + maliyet);
            #endregion

            #region Metotta değer sabitleme
            //Console.WriteLine(KdvHesapla(7000, 8));
            //Console.WriteLine(KdvHesapla(8500));
            //Console.WriteLine(KdvHesapla()); 
            #endregion

            #region Params'ı kullanalım
            //Console.WriteLine(Topla(8,9,11,8)); 
            #endregion

            #region Baba, Anne ve Çocuğu oluşturalım
            //Baba baba1 = new Baba();
            //baba1.BabaAdi = "Sinan";
            //baba1.BabaYasi = 50;
            //baba1.BabaMeslek = "Öğretmen";

            //Baba baba2 = new Baba();
            //baba2.BabaAdi = "Hüseyin";
            //baba2.BabaYasi = 55;
            //baba2.BabaMeslek = "Marangoz";

            //Anne anne1 = new Anne();
            //anne1.AnneAdi = "Ayşe";
            //anne1.AnneYasi = 48;
            //anne1.AnneMeslek = "Mühendis";

            //Anne anne2 = new Anne();
            //anne2.AnneAdi = "Fatma";
            //anne2.AnneYasi = 45;
            //anne2.AnneMeslek = "Hemşire";

            //Cocuk cocuk1 = new Cocuk();
            //cocuk1.CocukAdi = "Salih";
            //cocuk1.CocukYasi = 15;
            //cocuk1.CocukMeslek = "Öğrenci";

            //Cocuk cocuk2 = new Cocuk();
            //cocuk2.CocukAdi = "Nazlı";
            //cocuk2.CocukYasi = 12;
            //cocuk2.CocukMeslek = "Öğrenci";

            //EvHalkı evHalkı = new EvHalkı();
            //evHalkı.Konak(baba1,anne1,cocuk1); 
            //evHalkı.Deniz(baba2, anne2, cocuk2); 
            #endregion

        }

        #region Ref mantığını öğrenelim
        //static int Referans(ref int a, int b)
        //{
        //    a = 40;
        //    int sonuc = a + b;

        //    return sonuc;
        //}
        #endregion

        #region İndirim Yap metodu oluşturalım
        //static decimal IndirimYap(byte adet, ref short indirimOrani, decimal ucret)
        //{
        //    if (adet > 1)
        //    {
        //        indirimOrani = 20;
        //        ucret = ucret - ucret * indirimOrani / 100;
        //    }
        //    return ucret;
        //}
        #endregion

        #region Fiyat Hesapla metodu yapalım, kdv kullanalım
        static decimal FiyatHesapla(int urun, out decimal kdvOranı, decimal urunFiyati)
        {
            kdvOranı = 0; //out kullandığımız için burda değer verdik

            if (urun == 1)
            {
                kdvOranı = 1;
                urunFiyati = urunFiyati + urunFiyati * kdvOranı / 100;
            }
            else if (urun == 2)
            {
                kdvOranı = 8;
                urunFiyati = urunFiyati + urunFiyati * kdvOranı / 100;
            }
            else if (urun == 3)
            {
                kdvOranı = 18;
                urunFiyati = urunFiyati + urunFiyati * kdvOranı / 100;
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama");
            }
            return urunFiyati;
        }
        #endregion

        #region Metotta değer sabitleme
        //static decimal KdvHesapla(decimal fiyat=2000, int kdv=18)
        //{
        //    fiyat = fiyat + fiyat * kdv / 100;
        //    return fiyat;
        //} 
        #endregion

        #region Params'ı kullanalım
        //static int Topla(params int[] dizininAdi)
        //{
        //    return dizininAdi.Sum();
        //} 
        #endregion

        #region Kişi classı oluşturalım
        //class Kisi
        //{
        //    public int yas;
        //    public string ad;
        //    public string soyad;
        //    public string cinsiyet;
        //    public string gozrengi;
        //    public string ırk;

        //    public void Ozellik()
        //    {
        //        Console.WriteLine("Adı: " + ad + "\nSoyadı: " + soyad + "\nYaşı: " + yas + "\nGöz Rengi : " + gozrengi + "\nIrkı : " + ırk);
        //    }
        //}
        #endregion

        #region Kitap classı oluşturalım
        //class Kitap
        //{
        //    public string KitapAdi;
        //    public string Yazari;
        //    public int SayfaSayisi;
        //    public int BasimYili;

        //    public void KitapSec()
        //    {
        //        Console.WriteLine("Kitabın Adı: " + KitapAdi + "\nKitabın Yazarı: " + Yazari + "\nSayfa Sayısı: " + SayfaSayisi + "\nBasım Yılı: " + BasimYili);

        //    }
        //}
        #endregion

        #region Dörtgen classı oluşturalım
        //class Dortgen
        //{
        //    public int UzunKenar;
        //    public int KısaKenar;

        //    public void CevreHesapla()
        //    {
        //        int cevre = (UzunKenar * 2 + KısaKenar * 2);
        //        Console.WriteLine("Dörtgenin çevresi: " + cevre);
        //    }
        //    public void AlanHesapla()
        //    {
        //        int alan = (UzunKenar * KısaKenar);
        //        Console.WriteLine("Dörtgenin alanı: " + alan);
        //    }
        //}
        #endregion

        #region Arac ve Müşteri classlarını oluşturalım
        //class Arac
        //{
        //    public string Marka;
        //    public short Model;
        //    public string Renk;
        //    public string YakıtTipi;
        //    public string Vites;
        //    //------------   BU ŞEKİLDE İSİM SOYİSİM GÖNDERİLEBİLİR   --------------
        //    //public void AracAlma(string Adi, string Soyadi)
        //    //{
        //    //    Console.WriteLine(Marka + " marka aracı " + Adi + " " + Soyadi + " müsterisi aldı");
        //    //}
        //    //----------- BU ŞEKİLDE İSE TÜM ÖZELLİKLER GÖNDERİLEBİLİR ------------
        //    public void AracAlma(Musteri musteri)
        //    {
        //        Console.WriteLine(Marka + " marka aracı " + musteri.Adi + " " + musteri.Soyadi + " adlı müşteri kiraladı");
        //    }
        //}

        //class Musteri
        //{
        //    public string Adi;
        //    public string Soyadi;
        //    public int Yasi;

        //}
        #endregion

        #region Öğretmen, Öğrenci ve Kitap classlarını oluşturalım
        //class Ogretmen
        //{
        //    public string OgretmenAdi;
        //    public string OgretmenBransi;

        //}

        //class Ogrenci
        //{
        //    public int OgrenciNo;
        //    public string OgrenciAdi;
        //}

        //class Kitap
        //{
        //    public string KitapAdi;
        //    public int KitapSayfaSayisi;

        //    public void KitapVer(Ogretmen ogretmen, Ogrenci ogrenci)
        //    {
        //        Console.WriteLine(ogretmen.OgretmenBransi + " branşlı " + ogretmen.OgretmenAdi + " öğretmen " + ogrenci.OgrenciAdi + " adlı öğrenciye " + KitapAdi + " adlı kitabı verdi ");
        //    }
        //}
        #endregion

        #region Sepet ve Ürün classı oluşturalım
        //public class Sepet
        //{
        //    public double Sepet_Toplam = 0;
        //}
        //public class Urun
        //{
        //    public string Ad;
        //    public double Fiyat;
        //    public double SonKullanmaTarihi;
        //    public string Kategori;
        //}
        #endregion

        #region Baba, Anne ve Çocuk classı oluşturalım
        //class Baba
        //{
        //    public string BabaAdi;  //field
        //    public int BabaYasi;
        //    public string BabaMeslek;
        //}
        //class Anne
        //{
        //    public string AnneAdi;
        //    public int AnneYasi;
        //    public string AnneMeslek;
        //}
        //class Cocuk
        //{
        //    public string CocukAdi;
        //    public int CocukYasi;
        //    public string CocukMeslek;
        //}
        //class EvHalkı
        //{
        //    public void Konak(Baba baba, Anne anne, Cocuk cocuk)
        //    {
        //        Console.WriteLine("Konak ailesinin üyeleri" + "\nBaba: " + baba.BabaAdi + "\nBabanın yaşı: " + baba.BabaYasi + "\nBabanın Mesleği: " + baba.BabaMeslek + "\nAnne: " + anne.AnneAdi + "\nAnnenin yaşı: " + anne.AnneYasi + "\nAnnenin Mesleği: " + anne.AnneMeslek + "\nÇocuk: " + cocuk.CocukAdi + "\nÇocuğun Yaşı: " + cocuk.CocukYasi + "\nÇocuk Mesleği: " + cocuk.CocukMeslek);
        //        Console.WriteLine();
        //    }
        //    public void Deniz(Baba baba, Anne anne, Cocuk cocuk)
        //    {
        //        Console.WriteLine("Deniz ailesinin üyeleri" + "\nBaba: " + baba.BabaAdi + "\nBabanın yaşı: " + baba.BabaYasi + "\nBabanın Mesleği: " + baba.BabaMeslek + "\nAnne: " + anne.AnneAdi + "\nAnnenin yaşı: " + anne.AnneYasi + "\nAnnenin Mesleği: " + anne.AnneMeslek + "\nÇocuk: " + cocuk.CocukAdi + "\nÇocuğun Yaşı: " + cocuk.CocukYasi + "\nÇocuk Mesleği: " + cocuk.CocukMeslek);
        //    }
        //} 
        #endregion

    }
}

