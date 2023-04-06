using System;

namespace _02.Kosullar
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Suyun kaynayıp kaynamadığını değerlendirelim
            //Console.Write("Sıcaklık değerini giriniz: ");
            //int T = Convert.ToInt16(Console.ReadLine());

            //if (T >= 100)
            //{
            //    Console.WriteLine("Su kaynadı ve sıcaklık:" + " " + T);
            //}
            //else
            //{
            //    Console.WriteLine("Su henüz kaynamadı");
            //}
            #endregion

            #region Kullanıcının girdiği sayının pozitif veya negatif olduğunu bulalım
            //Console.Write("Bir sayı giriniz: ");
            //int sayi = Convert.ToInt16(Console.ReadLine());

            //if (sayi > 0)
            //{
            //    Console.WriteLine("Sayı pozitiftir ve değeri: " + "+" + sayi);
            //}
            //else if (sayi < 0)
            //{
            //    Console.WriteLine("Sayı negatiftir ve değeri: " + sayi);
            //}
            //else
            //{
            //    Console.WriteLine("Sayı sıfırdır");
            //}
            #endregion

            #region Öğrencinin sınav notlarını isteyelim, başarı durumunu ekrana yazdıralım
            //Console.Write("Vize notunuzu giriniz: ");
            //int vize = Convert.ToInt16(Console.ReadLine());

            //Console.Write("Final notunuzu giriniz: ");
            //int final = Convert.ToInt16(Console.ReadLine());

            //int basari = (vize * 40 + final * 60) / 100;

            //if (basari < 60)
            //{
            //    Console.WriteLine("Dersi geçemediniz ve ortalamanız : " + basari);
            //}

            //else if (basari > 60)
            //{
            //    Console.WriteLine("Dersi geçtiniz ve ortalamanız: " + basari);
            //}

            //else
            //{
            //    Console.WriteLine("Dersi kısmen geçtiniz ve ortalamanız 60");
            //}
            #endregion

            #region Sisteme girmek isteyen kişiyi test edelim
            //string kullanici_adi = "ecehiz";
            //int parola = 123456;

            //Console.Write("Kullanıcı adınızı giriniz: ");
            //string ad = Console.ReadLine();

            //Console.Write("Şifrenizi giriniz: ");
            //int sifre = Convert.ToInt32(Console.ReadLine());


            //if (kullanici_adi == ad && parola == sifre)
            //{
            //    Console.WriteLine("Kullanıcı adı ve şifre doğru. Giriş izni verilmiştir.");
            //}

            //else
            //{
            //    Console.WriteLine("Kullanıcı adı veya şifre yanlış. Tekrar deneyiniz");
            //}
            #endregion

            #region Kullanıcıdan alınan sayıları kıyaslayalım
            //Console.Write("Birinci sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt16(Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt16(Console.ReadLine());

            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("1.sayı 2.sayıdan büyüktür");
            //}

            //else if (sayi2 > sayi1)
            //{
            //    Console.WriteLine("2.sayı 1.sayıdan büyüktür");
            //}

            //else
            //{
            //    Console.WriteLine("İki sayı birbirine eşittir");
            //}
            #endregion

            #region Kullanıcının girdiği 3 sayıyı kıyaslayalım. En büyük olanı ekrana yazdıralım
            //Console.Write("Birinci sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt16(Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt16(Console.ReadLine());

            //Console.Write("Üçüncü sayıyı giriniz: ");
            //int sayi3 = Convert.ToInt16(Console.ReadLine());

            //if (sayi1 > sayi2 && sayi1 > sayi3)
            //{
            //    Console.WriteLine("En büyük sayı: " + sayi1);
            //}

            //else if (sayi2 > sayi1 && sayi2 > sayi3)
            //{
            //    Console.WriteLine("En büyük sayı: " + sayi2);
            //}

            //else if (sayi3 > sayi1 && sayi3 > sayi2)
            //{
            //    Console.WriteLine("En büyük sayı: " + sayi3);
            //}
            #endregion

            #region Kullanıcı ekrana 3 not girecek, not ortalamasını alınacak. Ortalama, harflerden hangisine uyuyorsa ekrana o harfi yazdıralım

            /*F – 0 - 45
            D – 45 - 55
            C – 55 - 70
            B – 70 - 85
            A – 85 - 100
            */

            //Console.Write("Birinci vize notunu giriniz: ");
            //int vize1 = Convert.ToInt16(Console.ReadLine());

            //Console.Write("İkinci vize notunu giriniz: ");
            //int vize2 = Convert.ToInt16(Console.ReadLine());

            //Console.Write("Final notunu giriniz: ");
            //int final = Convert.ToInt16(Console.ReadLine());

            //int ortalama = (vize1 * 20 + vize2 * 20 + final * 60) / 100;

            //if (ortalama <= 45)
            //{
            //    Console.WriteLine("Harf notunuz: F ve ortalamanız: " + ortalama);
            //}

            //else if (ortalama > 45 && ortalama <= 55)
            //{
            //    Console.WriteLine("Harf notunuz: D ve ortalamanız: " + ortalama);
            //}

            //else if (ortalama > 55 && ortalama <= 70)
            //{
            //    Console.WriteLine("Harf notunuz: C ve ortalamanız: " + ortalama);
            //}

            //else if (ortalama > 70 && ortalama <= 85)
            //{
            //    Console.WriteLine("Harf notunuz: B ve ortalamanız: " + ortalama);
            //}

            //else if (ortalama > 85 && ortalama <= 100)
            //{
            //    Console.WriteLine("Harf notunuz: A ve ortalamanız: " + ortalama);
            //}
            #endregion

            #region Kullanıcı iki sayı girecek ve işlem seçecek. Kullanıcı hangi işlemi seçerse o işlemi yaptırıp ekrana yazdıralım
            //Console.Write("1. sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Toplama için 1, Çıkarma için 2, Çarpma için 3, Bölme için 4 e basınız:");
            //int islem = Convert.ToInt16(Console.ReadLine());

            //if (islem == 1)
            //{
            //    Console.WriteLine("Sayıların toplama: " + (sayi1 + sayi2));
            //}

            //else if (islem == 2)
            //{
            //    Console.WriteLine("Sayıların farkı: " + (sayi1 - sayi2));
            //}

            //else if (islem == 3)
            //{
            //    Console.WriteLine("Sayıların çarpımı: " + (sayi1 * sayi2));
            //}

            //else if (islem == 4)
            //{
            //    Console.WriteLine("Sayıların bölümü: " + (sayi1 / sayi2));
            //}

            //else
            //{
            //    Console.WriteLine("Lütfen 1 ile 4 arasında bir rakam giriniz");
            //}
            #endregion

            #region Bankamatiğe istenilen tutar girildiğinde kaç tane 200lük, kaç tane 100lük, kaç tane 20lik vs geldiğini bulalım
            //Console.Write("Çekmek istediğiniz tutarı giriniz: ");
            //int para = Convert.ToInt16(Console.ReadLine());

            //int ikiyüzlük_sayisi = para / 200;
            //int yüzlük_sayisi = (para % 200) / 100;
            //int ellilik_sayisi = (para % 100) / 50;
            //int yirmilik_sayisi = (para % 50) / 20;
            //int onluk_sayisi = (para % 20) / 10;
            //int beslik_sayisi = (para % 10) / 5;
            //int birlik_sayisi = para % 5;

            //Console.WriteLine("{0} adet 200'lük, {1} adet 100'lük, {2} adet 50'lik, {3} adet 20'lik, {4} adet 10luk, {5} adet 5'lik, {6} adet 1'lik banknot verilecek", ikiyüzlük_sayisi, yüzlük_sayisi, ellilik_sayisi, yirmilik_sayisi, onluk_sayisi, beslik_sayisi, birlik_sayisi);
            #endregion

            #region Kullanıcının girdiği sayının tek veya çift olduğunu bulalım
            //Console.Write("Bir sayı giriniz: ");
            //int sayi = Convert.ToInt16(Console.ReadLine());

            //int kalan = (sayi % 2);
            //if (kalan == 0)
            //{
            //    Console.WriteLine("Sayı çift sayıdır");
            //}

            //else
            //{
            //    Console.WriteLine("Sayı tek sayıdır");
            //}

            #endregion

            #region Kullancı mevsimleri ekrandan girdiğinde mevsimlere ait aylar gelsin
            //Console.Write("Kış için 1, İlkbahar için 2, Yaz için 3, Sonbahar için 4 tuşuna basınız: ");
            //int mevsim = Convert.ToInt16(Console.ReadLine());

            //if (mevsim == 1)
            //{
            //    Console.WriteLine("Kış mevsiminin ayları: Aralık Ocak Şubat");
            //}

            //else if (mevsim == 2)
            //{
            //    Console.WriteLine("İlkbahar mevsiminin ayları: Mart Nisan Mayıs");
            //}

            //else if (mevsim == 3)
            //{
            //    Console.WriteLine("Yaz mevsiminin ayları: Haziran Temmuz Ağustos");
            //}

            //else if (mevsim == 4)
            //{
            //    Console.WriteLine("Sonbahar mevsiminin ayları: Eylül Ekim Kasım");
            //}

            //else
            //{
            //    Console.WriteLine("Lütfen 1 ile 4 arasında bir sayı giriniz");
            //}
            #endregion

            #region Kullanıcı taksinin gittiği km yi girecek. Aşağıdaki şartlara göre taksi ücretini hesaplayalım 

            /*5 km e kadar = 2tl per km
            12 km e kadar = 1tl per km
            12 km üstü = 0,5tl per km*/

            //Console.Write("Gittiğiniz km uzunluğunu giriniz: ");
            //int km = Convert.ToInt16(Console.ReadLine());

            //double ucret;

            //if (km <= 5)
            //{
            //    ucret = km * 2;
            //}
            //else if (km <= 12)
            //{
            //    ucret = 5 * 2 + (km - 5) * 1;
            //}
            //else
            //{
            //    ucret = 5 * 2 + 7 * 1 + (km - 12) * 0.5;
            //}

            //Console.WriteLine("Taksi ücreti: " + ucret);
            #endregion

            #region Cinsiyet ve yaşlara göre durumlar oluşturalım
            /*Kadınlar için yaş 5ten küçükse bebek, 10dan küçükse çocuk, 35ten küçükse genç, 55ten küçükse orta yaşlı, diğer türlü emekli.
             Erkekler için  yaş 5ten küçükse bebek, 10dan küçükse çocuk, 25ten küçükse genç, 50den küçükse orta yaşlı, diğer türlü emekli.
             Kullanıcıdan cinsiyet ve doğum tarihi istenecek. Durumları oluşturalım.*/

            //Console.Write("Lütfen kadın için 1, erkek için 2 giriniz: ");
            //int cinsiyet = Convert.ToInt16(Console.ReadLine());

            //Console.Write("Lütfen doğum tarihinizi giriniz: ");
            //int yas = 2023 - Convert.ToInt16(Console.ReadLine());

            //if (cinsiyet == 1)
            //{
            //    if (yas <= 5)
            //    {
            //        Console.WriteLine("Bebek");
            //    }
            //    else if (yas > 5 && yas <= 10)
            //    {
            //        Console.WriteLine("Çocuk");
            //    }
            //    else if (yas > 10 && yas <= 35)
            //    {
            //        Console.WriteLine("Genç");
            //    }
            //    else if (yas > 35 && yas <= 55)
            //    {
            //        Console.WriteLine("Orta yaşlı");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Emekli");
            //    }
            //}

            //if (cinsiyet == 2)
            //{
            //    if (yas <= 5)
            //    {
            //        Console.WriteLine("Bebek");
            //    }
            //    else if (yas > 5 && yas <= 10)
            //    {
            //        Console.WriteLine("Çocuk");
            //    }
            //    else if (yas > 10 && yas <= 25)
            //    {
            //        Console.WriteLine("Genç");
            //    }
            //    else if (yas > 25 && yas <= 50)
            //    {
            //        Console.WriteLine("Orta yaşlı");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Emekli");
            //    }
            //}
            #endregion

            #region Mevsim durumu oluşturalım

            /*Mevsime bağlı olarak uygulanan hayali ve ters bir diyet programında aşağıdaki şartlara bağlı olarak mesaj veren iç içe if sorguları yazın.
           Bahar mevsimi ise: kişi 70 ile 75 kilo arasında olmalıdır
           Yaz mevsimi ise: kişi 80 ile 85 kilo arasında olmalıdır
           Kış mevsimi ise: kişi 60 ile 65 kilo arasında olmalıdır
           */

            //Console.Write("Bahar mevsimi için 0, Yaz mevsimi için 1, Kış mevsimi için 2 tuşuna basınız: ");
            //int mevsim = Convert.ToInt16(Console.ReadLine());

            //Console.Write("Kaç kiloda olduğunuzu söyleyiniz: ");
            //int kilo = Convert.ToInt16(Console.ReadLine());

            //if (mevsim == 0)
            //{
            //    if (kilo > 70 && kilo < 75)
            //    {
            //        Console.WriteLine("İdeal kilonuzdasınız");
            //    }
            //    else if (kilo < 70)
            //    {
            //        Console.WriteLine("Şu kadar kilo almalısnız: " + (70 - kilo));
            //    }

            //    else if (kilo > 75)
            //    {
            //        Console.WriteLine("Şu kadar kilo vermelisiniz: " + (kilo - 75));
            //    }

            //}

            //else if (mevsim == 1)
            //{
            //    if (kilo > 80 && kilo < 85)
            //    {
            //        Console.WriteLine("İdeal kilonuzdasınız");
            //    }
            //    else if (kilo < 80)
            //    {
            //        Console.WriteLine("Şu kadar kilo almalısnız: " + (80 - kilo));
            //    }
            //    else if (kilo > 80)
            //    {
            //        Console.WriteLine("Şu kadar kilo vermelisiniz: " + (kilo - 80));
            //    }
            //}

            //else if (mevsim == 2)
            //{
            //    if (kilo > 60 && kilo < 65)
            //    {
            //        Console.WriteLine("İdeal kilonuzdasınız: ");
            //    }
            //    else if (kilo < 60)
            //    {
            //        Console.WriteLine("Şu kadar kilo almalısnız: " + (60 - kilo));
            //    }
            //    else if (kilo > 65)
            //    {
            //        Console.WriteLine("Şu kadar kilo vermelisiniz: " + (kilo - 65));
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Lütfen ilk satıra 0, 1 veya 2 giriniz");
            //}
            #endregion

        }
    }
}
