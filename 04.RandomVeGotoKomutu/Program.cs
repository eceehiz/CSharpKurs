using System;

namespace _04.RandomVeGotoKomutu
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Random mantığını anlayalım
            //Maximum değer vererek rastgele bir sayı isteyebiliriz:

            //Random random = new Random();
            //Console.WriteLine(random.Next(5000));

            //İki değer arasında rastgele bir sayı isteyebiliriz:
            //Random random2 = new Random();
            //Console.WriteLine(random2.Next(1,7));  
            #endregion

            #region Kullanıcının girdiği 2 sayı arasında random sayı üreten programı yazalım
            //Random random = new Random();
            //git:
            //    Console.Write("Alt limiti giriniz: ");
            //    int alt_limit = Convert.ToInt16(Console.ReadLine());

            //    Console.Write("Üst limit giriniz: ");
            //    int ust_limit = Convert.ToInt16(Console.ReadLine());

            //    if (alt_limit > ust_limit)
            //    {
            //        Console.WriteLine("Alt limit üst limitten yüksek olamaz");
            //        goto git;
            //    }

            //    else
            //    {
            //        Console.WriteLine(random.Next(alt_limit, ust_limit));

            //    } 
            #endregion

            #region Rastgele 10 adet sayıyı toplayan programı yazalım
            //    Random random = new Random();

            //    int i = 0, toplam = 0;
            //git:
            //    if (i < 10)
            //    {
            //        int uretilen_sayi = random.Next(500);
            //        toplam = toplam + uretilen_sayi;
            //        i = i + 1;
            //        Console.WriteLine(random.Next(uretilen_sayi));
            //        goto git;
            //    }

            //    Console.WriteLine("Toplam sonuc: " + toplam); 
            #endregion

            #region 500 kere zar atılıyor. 1den kaç kere geldi 2den kaç kere geldi.... 6dan kaç kere geldi bulalım
            //    int i = 0;

            //    int bir_sayisi = 0, iki_sayisi = 0, uc_sayisi = 0, dort_sayisi = 0, bes_sayisi = 0, alti_sayisi = 0;

            //    Random random = new Random();

            //git:

            //    if (i < 500)
            //    {
            //        int uretilen_sayi = random.Next(1, 7);

            //        switch (uretilen_sayi)
            //        {
            //            case 1:
            //                bir_sayisi = bir_sayisi + 1;
            //                break;
            //            case 2:
            //                iki_sayisi = iki_sayisi + 1;
            //                break;
            //            case 3:
            //                uc_sayisi = uc_sayisi + 1;
            //                break;
            //            case 4:
            //                dort_sayisi = dort_sayisi + 1;
            //                break;
            //            case 5:
            //                bes_sayisi = bes_sayisi + 1;
            //                break;
            //            case 6:
            //                alti_sayisi = alti_sayisi + 1;
            //                break;
            //        }

            //        i = i + 1;
            //        goto git;
            //    }

            //    Console.WriteLine("1 sayısı: " + bir_sayisi + " kere gelmiştir");
            //    Console.WriteLine("2 sayısı: " + iki_sayisi + " kere gelmiştir");
            //    Console.WriteLine("3 sayısı: " + uc_sayisi + " kere gelmiştir");
            //    Console.WriteLine("4 sayısı: " + dort_sayisi + " kere gelmiştir");
            //    Console.WriteLine("5 sayısı: " + bes_sayisi + " kere gelmiştir");
            //    Console.WriteLine("6 sayısı: " + alti_sayisi + " kere gelmiştir");
            #endregion

            #region Kulllanıcı bir cümle ve bu cümleyi kaç kere yazdırmak istediğini ekrana girsin. O kadar ekrana yazdıralım
            //    int i = 0;

            //    Console.Write("Yazdırmak istediğiniz cümleyi söyleyiniz: ");
            //    string cumle = Console.ReadLine();

            //    Console.Write("Kaç defa yazdırmak istediğinizi söyleyiniz: ");
            //    int tekrar = Convert.ToInt16(Console.ReadLine());


            //git:
            //    if (i < tekrar)
            //    {
            //        Console.WriteLine(cumle);
            //        i = i + 1;
            //        goto git;
            //    }
            #endregion

            #region 1den 10a kadar olan sayıların toplamı için programı yazalım
            //    int i = 0, toplam = 0;
            //git:
            //    if (i < 11)
            //    {
            //        toplam = toplam + i;
            //        i = i + 1;
            //        goto git;

            //    }
            //    Console.WriteLine(toplam);
            #endregion

            #region 10 adet random sayı girilecek. Bu sayıların 5 ile bölünmeyenlerin sayısını ekrana yazdıralım
        //    Random rnd = new Random();

        //    int adet = 0, i = 0;

        //    Console.WriteLine("Bilgisayar tarafından üretilen 10 rastgele sayı: ");
        //git:
        //    int uretilen_sayi = rnd.Next(1, 100);

        //    Console.WriteLine("{0}. sayı: {1}", i = i + 1, uretilen_sayi);

        //    if (uretilen_sayi % 5 != 0)
        //    {
        //        adet = adet + 1;
        //    }
        //    if (i < 10)
        //    {
        //        goto git;
        //    }
        //    Console.WriteLine("Üretilen sayılar arasında 5'e bölünmeyenlerin sayısı: {0}", adet);
            #endregion
        }
    }
}
