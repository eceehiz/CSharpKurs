using System;

namespace _07.Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Topla();

            //TekCift();

            //EnKucukEnBuyuk();

            //Islem();

            //Kare();

            //Daire();

            //Ucgen();

            #region Parametreli metot yapalım. Mesajı istenen adet kadar yazdıralım
            //Console.Write("Bir mesaj giriniz: ");
            //string mesaj = Console.ReadLine();
            //Console.Write("İstediğiniz adeti giriniz: ");
            //int adet = Convert.ToInt32(Console.ReadLine());
            //MesajYaz(mesaj, adet); 
            #endregion

            //IkıSayıGir();

            //TekCiftParametreli(11);

            #region Üs alalım
            //Console.Write("Tabanı belirleyin:");
            //int taban = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Üssü belirleyin:");
            //int üs = Convert.ToInt32(Console.ReadLine());
            //UsAlma(taban, üs); 
            #endregion

            #region Silindirin hacmini bulalım
            //Console.Write("Silindirin yarı çapını girin: ");
            //int yarıçap = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Silindirin yüksekliğini girin: ");
            //int yükseklik = Convert.ToInt32(Console.ReadLine());
            //SilindirHacimBul(yarıçap, yükseklik); 
            #endregion

            //Console.WriteLine(Isim());

            //Console.WriteLine(IkıSayıyıTopla());

            #region Yol, Hız, Zaman hesaplayalım
            //Console.WriteLine("Yolu hesaplamak için 1i, Hızı hesaplamak için 2, Zamanı hesaplamak için 3e basınız.");
            //int secim = Convert.ToInt32(Console.ReadLine());

            //if (secim == 1)
            //{
            //    Console.WriteLine(Yol());
            //}
            //else if (secim == 2)
            //{
            //    Console.WriteLine(Hız());
            //}
            //else if (secim == 3)
            //{
            //    Console.WriteLine(Zaman());
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen 1 ile 3 arasında bir tuşlama yapınız.");
            //}
            #endregion

            //Console.WriteLine(HesapAl());

            #region Parametreli kitap ve öğrenci metodu yapalım

            //Kitap("Serenad", "Zülfü Livaneli", 250, 40);
            //Ogrenci("Sinem Öztürk", 17, 929);

            #endregion

            //Console.WriteLine("Karenin alanı: " + KareAlan(7));

            //AracKiralama();

            //Topla(3, 9);
            //Topla(6, 7, 8);
            //Topla();

        }

        #region İki sayıyı toplayan metodu yazalım

        //static void Topla()
        //{
        //    Console.Write("Bir sayı girin: ");
        //    int sayi1 = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("İkinci sayı girin: ");
        //    int sayi2 = Convert.ToInt32(Console.ReadLine());

        //    int toplam = sayi1 + sayi2;
        //    Console.WriteLine(toplam);

        //}
        #endregion

        #region Tek mi Çift mi metodunu yapalım

        //static void TekCift()
        //{
        //    Console.Write("Bir sayı girin: ");
        //    int sayi = Convert.ToInt32(Console.ReadLine());

        //    if (sayi % 2 == 0)
        //    {
        //        Console.WriteLine("Çift sayıdır");
        //    }

        //    else
        //    {
        //        Console.WriteLine("Tek sayıdır");
        //    }

        //}
        #endregion

        #region Girilen 3 sayıdan büyük ve küçük olanı ekrana yazan metodu yapalım
        //static void EnKucukEnBuyuk()
        //{
        //    Console.Write("1.sayıyı giriniz: ");
        //    int sayi1 = int.Parse(Console.ReadLine());
        //    Console.Write("2.sayıyı giriniz: ");
        //    int sayi2 = int.Parse(Console.ReadLine());
        //    Console.Write("3.sayıyı giriniz: ");
        //    int sayi3 = int.Parse(Console.ReadLine());

        //    if (sayi1 > sayi2 && sayi2 > sayi3)
        //    {
        //        Console.WriteLine("En büyük sayı: " + sayi1);
        //        Console.WriteLine("En küçük sayı: " + sayi3);
        //    }
        //    else if (sayi1 > sayi3 && sayi3 > sayi2)
        //    {
        //        Console.WriteLine("En büyük sayı: " + sayi1);
        //        Console.WriteLine("En küçük sayı: " + sayi2);
        //    }
        //    else if (sayi2 > sayi1 && sayi1 > sayi3)
        //    {
        //        Console.WriteLine("En büyük sayı: " + sayi2);
        //        Console.WriteLine("En küçük sayı: " + sayi3);
        //    }
        //    else if (sayi2 > sayi3 && sayi3 > sayi1)
        //    {
        //        Console.WriteLine("En büyük sayı: " + sayi2);
        //        Console.WriteLine("En küçük sayı: " + sayi1);
        //    }
        //    else if (sayi3 > sayi2 && sayi2 > sayi1)
        //    {
        //        Console.WriteLine("En büyük sayı: " + sayi3);
        //        Console.WriteLine("En küçük sayı: " + sayi1);
        //    }
        //    else if (sayi3 > sayi1 && sayi1 > sayi2)
        //    {
        //        Console.WriteLine("En büyük sayı: " + sayi3);
        //        Console.WriteLine("En küçük sayı: " + sayi2);
        //    }

        //    else
        //    {
        //        Console.WriteLine("Herhangi iki sayı eşit");
        //    }

        //}
        #endregion

        #region Kullanıcı istediği işlemi ve 2 adet sayı girsin. İşlemi yapalım
        //static void Islem()
        //{
        //    Console.Write("Toplama için 1, Çıkarma için 2, Çarpma için 3, Bölme için 4e basınız: ");
        //    int islem = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("1. sayıyı giriniz: ");
        //    int sayi1 = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("2. sayıyı giriniz: ");
        //    int sayi2 = Convert.ToInt32(Console.ReadLine());


        //    if (islem == 1)
        //    {
        //        Console.WriteLine("Toplama işlemi yapılıyor");
        //        Console.WriteLine("Sonuç:" + (sayi1 + sayi2));
        //    }
        //    else if (islem == 2)
        //    {
        //        Console.WriteLine("Çıkarma işlemi yapılıyor");
        //        Console.WriteLine("Sonuç:" + (sayi1 - sayi2));
        //    }
        //    else if (islem == 3)
        //    {
        //        Console.WriteLine("Çarpma işlemi yapılıyor");
        //        Console.WriteLine("Sonuç:" + (sayi1 * sayi2));
        //    }
        //    else if (islem == 4)
        //    {
        //        if (sayi2 > sayi1)
        //        {
        //            int joker = sayi2;
        //            sayi2 = sayi1;
        //            sayi1 = joker;
        //        }

        //        Console.WriteLine("Bölme işlemi yapılıyor");
        //        Console.WriteLine("Sonuç:" + (sayi1 / sayi2));
        //    }
        //    else
        //    {
        //        Console.WriteLine("1 ile 4 arası tuşlama yapınız");
        //    }
        //}
        #endregion

        #region Karenin alanını bulalım
        //static void Kare()
        //{
        //    Console.Write("Karenin bir kenar uzunluğunu giriniz: ");
        //    int kenar = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Alan: " + (kenar * kenar));
        //}
        #endregion

        #region Dairenin alanını bulalım
        //static void Daire()
        //{
        //    Console.Write("Dairenin yarıçap uzunluğunu giriniz: ");
        //    int yaricap = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Alan: " + (3.14 * yaricap * yaricap));
        //}
        #endregion

        #region Üçgenin alanını bulalım
        //static void Ucgen()
        //{
        //    Console.Write("Ücgenin kenar uzunluğunu giriniz: ");
        //    int kenar = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Ücgenin yükseklik uzunluğunu giriniz: ");
        //    int yukseklık = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Alan: " + (kenar * yukseklık / 2));
        //}
        #endregion

        #region Parametreli metot yapalım. Mesajı istenen adet kadar yazdıralım
        //static void MesajYaz(string mesaj, int adet)
        //{
        //    for (int i = 0; i < adet; i++)
        //    {
        //        Console.WriteLine(mesaj);
        //    }
        //}
        #endregion

        #region İki sayı alalım
        //static void IkıSayıGir()
        //{
        //    Console.Write("1. sayıyı giriniz: ");
        //    int sayi1 = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("2. sayıyı giriniz: ");
        //    int sayi2 = Convert.ToInt32(Console.ReadLine());
        //}
        #endregion

        #region Parametreli olarak tek mi çift mi olduğunu bulalım
        //static void TekCiftParametreli(int sayi)
        //{
        //    if (sayi % 2 == 0)
        //    {
        //        Console.WriteLine("Çift sayıdır");
        //    }

        //    else
        //    {
        //        Console.WriteLine("Tek sayıdır");
        //    }
        //}
        #endregion

        #region Üs alalım
        //static void UsAlma(int taban, int üs)
        //{
        //    double sonuc = Math.Pow(taban, üs);
        //    Console.WriteLine(sonuc);

        //}
        #endregion

        #region Silindirin hacmini bulalım
        //static void SilindirHacimBul(int yarıçap, int yükseklik)
        //{
        //    double hacim = (3.14 * yarıçap * yarıçap * yükseklik);
        //    Console.WriteLine(hacim);
        //}
        #endregion

        #region Return ile isim yazdıralım
        //static string Isim()
        //{
        //    Console.Write("İsim giriniz: ");
        //    string isim = Console.ReadLine();

        //    return isim;
        //}
        #endregion

        #region İki sayıyı return kullanarak toplayıp yazdıralım
        //static int IkıSayıyıTopla()
        //{
        //    Console.Write("1. sayıyı giriniz: ");
        //    int sayi1 = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("2. sayıyı giriniz: ");
        //    int sayi2 = Convert.ToInt32(Console.ReadLine());

        //    int sonuc = sayi1 + sayi2;
        //    return sonuc;
        //}
        #endregion

        #region Yol, Hız, Zaman hesaplayalım
        //static int Yol()
        //{
        //    Console.Write("Hızı girin: ");
        //    int hız = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Zamanı girin: ");
        //    int zaman = Convert.ToInt32(Console.ReadLine());

        //    int yol = hız * zaman;
        //    return yol;
        //}
        //static int Hız()
        //{
        //    Console.Write("Yolu girin: ");
        //    int yol = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Zamanı girin: ");
        //    int zaman = Convert.ToInt32(Console.ReadLine());

        //    int hız = yol / zaman;
        //    return hız;
        //}
        //static int Zaman()
        //{
        //    Console.Write("Yolu girin: ");
        //    int yol = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Hızı girin: ");
        //    int hız = Convert.ToInt32(Console.ReadLine());

        //    int zaman = yol / hız;
        //    return zaman;
        //}
        #endregion

        #region Hesap alalım
        //static int HesapAl()
        //{
        //    int hamburger_f = 50, cigkofte_f = 20, patates_f = 25, kola_f = 15, ayran_f = 10, su_f = 5;
        //    int hesap = 0;

        //    Console.Write("Hamburger için 1, Çiğköfte için 2, Patates kızartması için 3e basınız: ");
        //    int yiyecek = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Kola için 1, Ayran için 2, Su için 3e basınız: ");
        //    int icecek = Convert.ToInt32(Console.ReadLine());

        //    if (yiyecek == 1)
        //    {
        //        hesap = hesap + hamburger_f;
        //    }
        //    else if (yiyecek == 2)
        //    {
        //        hesap = hesap + cigkofte_f;
        //    }
        //    else if (yiyecek == 3)
        //    {
        //        hesap = hesap + patates_f;
        //    }

        //    if (icecek == 1)
        //    {
        //        hesap = hesap + kola_f;
        //    }
        //    else if (icecek == 2)
        //    {
        //        hesap = hesap + ayran_f;
        //    }
        //    else if (icecek == 3)
        //    {
        //        hesap = hesap + su_f;
        //    }

        //    return hesap;
        //}
        #endregion

        #region Parametreli kitap ve öğrenci metodu yapalım
        //static void Kitap(string kitapAdi, string yazari, int sayfaSayisi, int fiyat)
        //{
        //    Console.WriteLine("Kitabın adı: " + kitapAdi);
        //    Console.WriteLine("Kitabın yazarı: " + yazari);
        //    Console.WriteLine("Kitabın sayfa sayısı: " + sayfaSayisi);
        //    Console.WriteLine("Kitabın fiyatı: " + fiyat);
        //}
        //static void Ogrenci(string ogrenciAdi, int yas, int okulNo)
        //{
        //    Console.WriteLine("Öğrencinin adı:" + ogrenciAdi);
        //    Console.WriteLine("Öğrencinin yaşı:" + yas);
        //    Console.WriteLine("Öğrencinin okul numarası:" + okulNo);

        //}
        #endregion

        #region Parametreli ve return kullanarak karenin alanını hesaplayalım
        //static int KareAlan(int kenar)
        //{
        //    int alan = kenar * kenar;
        //    return alan;
        //}
        #endregion

        #region Araç kiralama yapalım
        //static void AracKiralama()
        //{
        //    Console.WriteLine("Araba kiralama şirketimize hoşgeldiniz");
        //    Console.WriteLine("********************************************");
        //    Console.Write("Kiralayan kişinin adı: ");
        //    string ad = Console.ReadLine();
        //    Console.Write("Kiralayan kişinin soyadı: ");
        //    string soyad = Console.ReadLine();
        //    Kiralayan(ad, soyad);
        //    Console.Write("Kaç saat kiralayacaksınız: ");
        //    double saat = double.Parse(Console.ReadLine());
        //    double deger = SaatFiyat(saat); Console.WriteLine(deger + " indirim yapılmadı");
        //    Console.WriteLine(IndırımYap(deger));
        //    Console.WriteLine($"Toplam kiralanacak saat= {saat}");
        //    Console.WriteLine($"kiralayan kişinin adı ={ad}");
        //    Console.WriteLine($"kiralayan kişinin soyadı ={soyad}");

        //}

        //static double IndırımYap(double ucret)
        //{
        //    if (ucret > 1500)
        //    {
        //        ucret = ucret - ucret * 0.10;
        //        return ucret;
        //    }
        //    else
        //    {
        //        return ucret;
        //    }
        //}
        //static string Kiralayan(string ad, string soyad)
        //{
        //    return "";
        //}
        //static double SaatFiyat(double saat)
        //{

        //    Console.WriteLine("Hangi arabayı kiralayacaksınız(Lütfen 1-4 arasında bir sayı giriniz)=\n1-reanult saati=700 Tl\n2-porsche saati=950 Tl\n3-fiat saati=500 Tl\n4-volvo saati=785 Tl");
        //    string secim = Console.ReadLine();
        //    if (secim == "1")
        //    {
        //        double renault = 700;
        //        return renault * saat;

        //    }
        //    else if (secim == "2")
        //    {
        //        int porsche = 950;
        //        return porsche * saat;

        //    }
        //    else if (secim == "3")
        //    {
        //        int fiat = 500;
        //        return fiat * saat;

        //    }
        //    else if (secim == "4")
        //    {
        //        int volvo = 785;
        //        return volvo * saat;

        //    }
        //    else
        //    {
        //        Console.WriteLine("Lütfen 1 ile 4 arasında bir sayı giriniz");
        //    }
        //    return 0;

        //}
        #endregion

        #region 3 tane Topla metodu yapalım, biri hiç parametre almasın, biri 2 adet parametre alsın, biri 3 adet patametre alsın
        //static void Topla(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}

        //static void Topla(int sayi1, int sayi2, int sayi3)
        //{
        //    Console.WriteLine(sayi1 + sayi2 + sayi3);
        //}
        //static void Topla()
        //{
        //    Console.Write("1. sayıyı giriniz: ");
        //    int sayi1 = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("2 sayıyı giriniz: ");
        //    int sayi2 = Convert.ToInt32(Console.ReadLine());

        //    int toplam = sayi1 + sayi2;
        //    Console.WriteLine(toplam);

        //}
        #endregion

    }
}
