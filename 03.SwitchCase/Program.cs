using System;

namespace _03.SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Kullanıcının girdiği rakama göre günleri yazdıralım
            //Console.Write("1 ile 7 arasında bir rakam giriniz: ");
            //int gun = Convert.ToInt16(Console.ReadLine());

            //switch (gun)
            //{
            //    case 1:
            //        Console.WriteLine("Pazar");
            //        break;
            //    case 2:
            //        Console.WriteLine("Pazartesi");
            //        break;
            //    case 3:
            //        Console.WriteLine("Salı");
            //        break;
            //    case 4:
            //        Console.WriteLine("Çarşamba");
            //        break;
            //    case 5:
            //        Console.WriteLine("Perşembe");
            //        break;
            //    case 6:
            //        Console.WriteLine("Cuma");
            //        break;
            //    case 7:
            //        Console.WriteLine("Cumartesi");
            //        break;
            //    default:
            //        Console.WriteLine("Lütfen 1 ile 7 arasında bir rakam giriniz");
            //        break;
            //}
            #endregion

            #region Kullanıcı 2 adet sayı girsin, yapmak istediği işlemi girsin. Sonucu yazdıralım
            //Console.Write("Birinci sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt16(Console.ReadLine());
            //Console.Write("İkinci sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt16(Console.ReadLine());

            //Console.Write("Toplama için 1, Çıkarma için 2, Çarpma için 3, Bölme için 4e basınız: ");
            //int islem = Convert.ToInt16(Console.ReadLine());

            //switch (islem)
            //{
            //    case 1:
            //        Console.WriteLine("Toplama işlemi seçtiniz. Sonuç: " + (sayi1 + sayi2));
            //        break;
            //    case 2:
            //        Console.WriteLine("Çıkarma işlemi seçtiniz. Sonuç: " + (sayi1 - sayi2));
            //        break;
            //    case 3:
            //        Console.WriteLine("Çarpma işlemi seçtiniz. Sonuç: " + (sayi1 * sayi2));
            //        break;
            //    case 4:
            //        Console.WriteLine("Bölme işlemi seçtiniz. Sonuç: " + (sayi1 / sayi2));
            //        break;

            //    default:
            //        Console.WriteLine("Lütfen 1 ile 4 arasında bir değer giriniz");
            //        break;
            //}
            #endregion

            #region Kırmızı ışıkta dur, sarı ışıkta hazırlan, yeşil ışıkta geç yapalım
            //Console.Write("Kırmızı ışıktaysanız 0, Yeşil ışıktasaysanız 1, Sarı ışıktaysanız 2 tuşuna basınız:  ");
            //int lamba = Convert.ToInt16(Console.ReadLine());

            //switch (lamba)
            //{
            //    case 0:
            //        Console.WriteLine("Kırmızı ışıkta olduğunuz için bekleyiniz");
            //        break;
            //    case 1:
            //        Console.WriteLine("Yeşil ışıkta olduğunuz için geçiniz");
            //        break;
            //    case 2:
            //        Console.WriteLine("Sarı ışıkta olduğunuz için hazırlanınız");
            //        break;

            //    default:
            //        Console.WriteLine("Geçerli bir lamba rengi giriniz");
            //        break;
            //}
            #endregion

            #region ATM uygulaması yapalım
            /*Kullanıcının bakiyesi 100.000 TL. 
               1-para çekme
               2-para yatırma
               3-havale gönder
               4-kart iade
               Sonucunda bakiye tutarını veren algoritmayı yazalım.
               */

            //    int guncel_bakiye = 100000;
            //git:
            //    Console.WriteLine("Para çekme işlemi için 1");
            //    Console.WriteLine("Para yatırma işlemi için 2");
            //    Console.WriteLine("Havale işlemi için 3");
            //    Console.WriteLine("Kart iadesi için 4");
            //    Console.Write("Tuşuna basınız: ");
            //    int tus = Convert.ToInt16(Console.ReadLine());

            //    switch (tus)
            //    {
            //        case 1:
            //            Console.Write("Çekmek istediğiniz tutarı giriniz: ");
            //            int cekilmek_istenen_tutar = Convert.ToInt16(Console.ReadLine());
            //            if (cekilmek_istenen_tutar > guncel_bakiye)
            //            {
            //                Console.WriteLine("Bakiye yetersiz");
            //            }

            //            else
            //            {
            //                guncel_bakiye = guncel_bakiye - cekilmek_istenen_tutar;
            //                Console.WriteLine("Güncel bakiyeniz: " + guncel_bakiye);
            //            }
            //            goto git;

            //        case 2:
            //            Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
            //            int yatirilmak_istenen_tutar = Convert.ToInt16(Console.ReadLine());
            //            guncel_bakiye = guncel_bakiye + yatirilmak_istenen_tutar;
            //            Console.WriteLine("Güncel bakiyeniz: " + guncel_bakiye);
            //            goto git;

            //        case 3:
            //            Console.Write("Havale göndermek istediğiniz tutarı giriniz: ");
            //            int havale = Convert.ToInt16(Console.ReadLine());
            //            guncel_bakiye = guncel_bakiye - havale;
            //            Console.WriteLine("Güncel bakiyeniz: " + guncel_bakiye);
            //            goto git;

            //        case 4:
            //            Console.Write("Kartınız iade ediliyor. Güncel bakiyeniz: " + guncel_bakiye + " TL. Sağlıklı günler dileriz.");
            //            break;

            //        default:
            //            Console.WriteLine("Lütfen 1 ile 4 arasında bir sayı giriniz");
            //            break;
            //    }

            //İLKERİN ÇÖZÜMÜ

        //    int balance = 100000;
        //Menu:
        //    Console.Clear();
        //    Console.WriteLine("Aktif Banka hoşgeldiniz");
        //    Console.WriteLine("Hangi işlemi yapmak istersiniz");
        //    Console.WriteLine("1-Para çekme");
        //    Console.WriteLine("2-Para yatırma");
        //    Console.WriteLine("3-Havale gönder");
        //    Console.WriteLine("4-Kart iade");
        //    Console.Write("Yapmak istediğiniz işlemi tuşlayın: ");
        //    byte choice = byte.Parse(Console.ReadLine());

        //    if (choice == 1)
        //    {
        //        Console.Clear();
        //    get_money1:
        //        Console.WriteLine($"bakiyeniz:{balance}");
        //        Console.Write("Ne kadar para çekme istiyorsunuz: ");
        //        int get_money = Convert.ToInt32(Console.ReadLine());
        //        if (get_money > balance)
        //        {
        //            Console.Clear();
        //            Console.WriteLine("Çekmek istediğiniz para miktarı büyük tekrardan bir değer giriniz:");
        //            goto get_money1;
        //        }
        //        balance -= get_money;
        //        Console.WriteLine("LÜTFEN BEKLEYİNİZ....");
        //        System.Threading.Thread.Sleep(1500);
        //        Console.Clear();
        //        Console.WriteLine($"güncel bakiyeniz:{balance}");
        //        Console.Write("Menüye geri dönmek isterseniz 1'e çıkış yapmak isteseniz 2'ye basınız: ");

        //    choice1:
        //        byte choice1 = byte.Parse(Console.ReadLine());
        //        if (choice1 == 1)
        //        {
        //            Console.WriteLine("LÜTFEN BEKLEYİNİZ....");
        //            System.Threading.Thread.Sleep(1500);
        //            goto Menu;
        //        }
        //        else if (choice1 == 2)
        //            Environment.Exit(0);
        //        else
        //        {
        //            Console.WriteLine("Yanlış seçim tekrar tuşa basınız");
        //            goto choice1;
        //        }
        //    }


        //    else if (choice == 2)
        //    {
        //        Console.Clear();
        //        Console.WriteLine($"bakiyeniz:{balance}");
        //        Console.Write("Ne kadar para yatırmak istiyorsunuz: ");
        //        int give_money = Convert.ToInt32(Console.ReadLine());

        //        balance += give_money;
        //        Console.WriteLine("LÜTFEN BEKLEYİNİZ....");
        //        System.Threading.Thread.Sleep(1500);
        //        Console.Clear();
        //        Console.WriteLine($"güncel bakiyeniz:{balance}");
        //        Console.Write("Menüye geri dönmek isterseniz 1'e çıkış yapmak isteseniz 2'ye basınız: ");
        //    choice2:
        //        byte choice2 = byte.Parse(Console.ReadLine());
        //        if (choice2 == 1)
        //        {
        //            Console.WriteLine("LÜTFEN BEKLEYİNİZ.......");
        //            System.Threading.Thread.Sleep(1500);
        //            goto Menu;
        //        }
        //        else if (choice2 == 2)
        //            Environment.Exit(0);
        //        else
        //        {
        //            Console.WriteLine("Yanlış seçim tekrar tuşa basınız");
        //            goto choice2;
        //        }

        //    }

        //    else if (choice == 3)
        //    {
        //        Console.Clear();
        //    send_money1:
        //        Console.WriteLine($"bakiyeniz:{balance}");
        //        Console.Write("Ne kadar para göndermek istiyorsunuz:");
        //        int send_money = Convert.ToInt32(Console.ReadLine());
        //        if (send_money > balance)
        //        {
        //            Console.Clear();
        //            Console.WriteLine("Çekmek istedeiğiniz para miktarı büyük tekrardan bir değer giriniz:");
        //            goto send_money1;
        //        }
        //        Console.Write("Kime bu parayı göndermek istiyorsunuz(ad soyad):");
        //        string receiver = Console.ReadLine();
        //        balance -= send_money;
        //        Console.WriteLine("LÜTFEN BEKLEYİNİZ....");
        //        System.Threading.Thread.Sleep(1500);
        //        Console.Clear();
        //        Console.WriteLine($"{receiver} kişisine {send_money} tl gönderildi");
        //        Console.WriteLine($"güncel bakiyeniz:{balance}");
        //        byte choice3;
        //        Console.Write("Menüye geri dönmek isterseniz 1'e çıkış yapmak isteseniz 2'ye basınız: ");
        //    choice3:
        //        choice3 = byte.Parse(Console.ReadLine());
        //        if (choice3 == 1)
        //        {
        //            Console.WriteLine("LÜTFEN BEKLEYİNİZ.......");
        //            System.Threading.Thread.Sleep(1500);
        //            goto Menu;
        //        }
        //        else if (choice3 == 2)
        //            Environment.Exit(0);
        //        else
        //        {
        //            Console.WriteLine("Yanlış seçim tekrar tuşa basınız");
        //            goto choice3;
        //        }

        //    }
        //    else if (choice == 4)
        //        Environment.Exit(0);
        //    else
        //    {
        //        Console.WriteLine("Yanlış tuşa bastınız");
        //        Console.WriteLine("Tekrar deneyiniz");
        //        System.Threading.Thread.Sleep(2000);
        //        goto Menu;
        //    }
            #endregion

            #region Hesaplamak istediğiniz geometrik şekli seçin. (Üçgen, kare, dikdörtgen). Daha sonra kenar bilgilerini alıp alan hesaplayalım
            //Console.Write("Üçgen için 1, kare için 2, dikdörtgen için 3 tuşuna basınız: ");
            //int tus = Convert.ToInt16(Console.ReadLine());

            //switch (tus)
            //{
            //    case 1:
            //        Console.Write("Taban kenarı giriniz: ");
            //        int taban = Convert.ToInt16(Console.ReadLine());
            //        Console.Write("Yükseklik giriniz: ");
            //        int yükseklik = Convert.ToInt16(Console.ReadLine());

            //        int ücgen_alan = (taban * yükseklik) / 2;
            //        Console.WriteLine("Üçgenin alanı: " + ücgen_alan);

            //        break;

            //    case 2:
            //        Console.Write("Karenin bir kenarını giriniz: ");
            //        int kenar = Convert.ToInt16(Console.ReadLine());

            //        int kare_alan = kenar * kenar;
            //        Console.WriteLine("Karenin alanı: " + kare_alan);

            //        break;

            //    case 3:
            //        Console.Write("Kısa kenarı giriniz: ");
            //        int kısa_kenar = Convert.ToInt16(Console.ReadLine());

            //        Console.Write("Uzun kenarı giriniz: ");
            //        int uzun_kenar = Convert.ToInt16(Console.ReadLine());

            //        int dikdörtgen_alan = kısa_kenar * uzun_kenar;
            //        Console.WriteLine("Dikdörtgenin alanı: " + dikdörtgen_alan);

            //        break;

            //    default:
            //        Console.WriteLine("Lütfen 1,2 veya 3 giriniz");
            //        break;
            //}
            #endregion
        }
    }
}
