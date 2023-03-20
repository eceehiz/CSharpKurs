using System;

namespace _05.Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            #region For döngüsünü anlayalım
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i + ". merhaba");
            //}
            #endregion

            #region Kullanıcıdan bir mesaj alalım. 5 kere ekrana yazdıralım
            //Console.Write("Bir mesaj yazın: ");
            //string cumle = Console.ReadLine();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(cumle);
            //}
            #endregion

            #region  Kullanıcının istediği cümleyi yine kullanıcının istediği kadar ekrana yazdıralım
            //Console.Write("Bir mesaj yazın: ");
            //string cumle = Console.ReadLine();

            //Console.Write("Kaç kere yazdırmak istediğinizi tuşlayın: ");
            //int tekrar = Convert.ToInt16(Console.ReadLine());

            //for (int i = 0; i < tekrar; i++)
            //{
            //    Console.WriteLine(cumle);
            //}

            //Aynı şekilde rakam yerine harfte yazdırabiliriz:
            //for (char i = 'A'; i <= 'Z'; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 1 ile 100 arasındaki çift sayıları ekrana yazdıralım
            //for (int i = 2; i < 101; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Kullanıcının girdiği iki sayı arasındaki tek sayıları bulup ekrana yazdıralım
            //int joker, sayi1, sayi2;

            //Console.Write("1. sayıyı giriniz: ");
            //sayi1 = Convert.ToInt16(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz: ");
            //sayi2 = Convert.ToInt16(Console.ReadLine());

            //if (sayi1 > sayi2)
            //{
            //    joker = sayi2;
            //    sayi2 = sayi1;
            //    sayi1 = joker;
            //}

            //for (int i = sayi1; i < sayi2; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region 1den 10a kadar sayıları toplayan programı yazalım
            //int toplam = 0;
            //for (int i = 1; i < 10; i++)
            //{
            //    toplam = toplam + i;
            //}

            //Console.WriteLine(toplam);
            #endregion

            #region Kullanıcının girdiği aralıktaki çift sayıların ortalamasını alan programı yazalım
            //int joker, sayi1, sayi2;

            //int toplam = 0, adet = 0;
            //int ortalama;

            //Console.Write("1. sayıyı giriniz: ");
            //sayi1 = Convert.ToInt16(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz: ");
            //sayi2 = Convert.ToInt16(Console.ReadLine());

            //if (sayi1 > sayi2)
            //{
            //    joker = sayi2;
            //    sayi2 = sayi1;
            //    sayi1 = joker;
            //}

            //for (int i = sayi1; i < sayi2; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        toplam = toplam + i;
            //        adet = adet + 1;
            //    }
            //}

            //ortalama = toplam / adet;
            //Console.WriteLine("1. sayı ile 2. sayının arasında bulunan çift sayıların ortalaması: " + ortalama);

            //Ahmetin çözümü
            //int sayi1 = 0, sayi2 = 0, toplam = 0, adet = 0;

            //Console.Write("İlk sayı küçük olan ");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci sayı büyük olan ");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //for (; sayi1 < sayi2; sayi1++)
            //{
            //    if (sayi1 % 2 == 0)
            //    {
            //        toplam += sayi1;
            //        adet = adet + 1;
            //    }
            //}
            //Console.WriteLine(toplam / adet);
            #endregion

            #region İstenilen aralıkta girilen sayıların son rakamı 5 ve 5 ten büyük olanların ortalamasını alan programı yazalım
            //int joker, sayi1, sayi2;
            //int toplam = 0; int adet = 0;

            //Console.Write("1. sayıyı giriniz: ");
            //sayi1 = Convert.ToInt16(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz: ");
            //sayi2 = Convert.ToInt16(Console.ReadLine());

            //if (sayi1 > sayi2)
            //{
            //    joker = sayi2;
            //    sayi2 = sayi1;
            //    sayi1 = joker;
            //}
            //for (int i = sayi1; i <= sayi2; i++)
            //{
            //    if (i % 10 >= 5)
            //    {
            //        toplam = toplam + i;
            //        adet = adet + 1;

            //    }
            //}
            //int ortalama = toplam / adet;
            //Console.WriteLine(ortalama);
            #endregion

            #region Kullanıcının girdiği 10 sayıdan en büyük ve en küçük olanı ekrana yazdıralım
            //Console.Write("Bir sayıyı giriniz: ");
            //int gecici = Convert.ToInt16(Console.ReadLine());

            //int enBuyuk = gecici;
            //int enKucuk = gecici;

            //for (int i = 0; i < 9; i++)
            //{
            //    Console.Write("Bir sayıyı giriniz: ");
            //    int sayi = Convert.ToInt16(Console.ReadLine());

            //    if (sayi > enBuyuk)
            //    {
            //        enBuyuk = sayi;
            //    }


            //    if (sayi < enKucuk)
            //    {
            //        enKucuk = sayi;
            //    }
            //}

            //Console.WriteLine("En büyük sayı: " + enBuyuk);
            //Console.WriteLine("En küçük sayı: " + enKucuk);
            #endregion

            #region İstenilen aralıkta girilen sayıların tek olanların karesi, çift olanların küpünü alacak ve toplayacak programı yapalım
            //Console.Write("1. sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt16(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt16(Console.ReadLine());

            //int joker;

            //if (sayi1 > sayi2)
            //{
            //    joker = sayi2;
            //    sayi2 = sayi1;
            //    sayi1 = joker;
            //}

            //int toplam_tek = 0;
            //int toplam_cift = 0;

            //for (int i = sayi1; i < sayi2; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        toplam_cift = toplam_cift + (i * i * i);

            //    }

            //    else
            //    {
            //        toplam_tek = toplam_tek + (i * i);
            //    }
            //}

            //Console.WriteLine(toplam_tek + toplam_cift);

            //İlkerin çözümü:

            //int number_1, number_2;
            //int joker;
            //Console.Write("bir sayı gir:");
            //number_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("bir sayı gir:");
            //number_2 = Convert.ToInt32(Console.ReadLine());

            //int even_pieces = 0, odd_pieces = 0;
            //int even_square = 0, odd_cube = 0;

            //if (number_1 > number_2)
            //{
            //    joker = number_2;
            //    number_2 = number_1;
            //    number_1 = joker;
            //}
            //for (int i = number_1; i <= number_2; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        even_pieces++;
            //        even_square += i * i * i;
            //    }
            //    else
            //    {
            //        odd_pieces++;
            //        odd_cube += i * i;
            //    }
            //}
            //Console.WriteLine($"çift adedi:{even_pieces} çiftlerin karesi toplam:{even_square}\n" +
            //    $"tek adedi:{odd_pieces} teklerin küpü toplam:{odd_cube}");

            #endregion

            #region Random olarak 1den 6ya kadar 1000 tane sayı üretilsin. 1den kaç tane geldiğini, .... 6dan kaç tane geldiğini bulalım
            //int bir_sayisi = 0, iki_sayisi = 0, uc_sayisi = 0, dort_sayisi = 0, bes_sayisi = 0, alti_sayisi = 0;

            //Random random = new Random();

            //for (int i = 0; i < 1000; i++)
            //{
            //    int uretilen_sayi = (random.Next(1, 7));

            //    if (uretilen_sayi == 1)
            //    {
            //        bir_sayisi = bir_sayisi + 1;
            //    }

            //    else if (uretilen_sayi == 2)
            //    {
            //        iki_sayisi = iki_sayisi + 1;
            //    }

            //    else if (uretilen_sayi == 3)
            //    {
            //        uc_sayisi = uc_sayisi + 1;
            //    }

            //    else if (uretilen_sayi == 4)
            //    {
            //        dort_sayisi = dort_sayisi + 1;
            //    }

            //    else if (uretilen_sayi == 5)
            //    {
            //        bes_sayisi = bes_sayisi + 1;
            //    }
            //    else
            //    {
            //        alti_sayisi = alti_sayisi + 1;
            //    }

            //}

            //Console.WriteLine("1 sayısı {0}\n2 sayısı {1}\n3 sayısı {2}\n4 sayısı {3}\n5 sayısı {4}\n6 sayısı {5} kere gelmiştir", bir_sayisi, iki_sayisi, uc_sayisi, dort_sayisi, bes_sayisi, alti_sayisi);
            #endregion

            #region Fren-Hız çözelim
            //100 km hızla giden aracın frenine basınca aracın hızı her saniyede % 10 azalıyor. Aracın frene kaç saniye basacağını kullanıcı girecek, sonraki hızı ne olur ekrana yazdıralım

            //double hız = 100;

            //Console.Write("Kaç saniye frene bastığınızı giriniz: ");
            //int saniye = Convert.ToInt16(Console.ReadLine());

            //for (int i = 0; i < saniye; i++)
            //{
            //    hız = hız - (hız * 0.1);
            //}

            //Console.WriteLine("Hızınız: " + hız);
            #endregion



            #region İç içe for döngüsüne bakalım
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine(i + " için " + j);
            //    }
            //}
            #endregion

            #region Çarpım tablosunu yapalım
            //for (int a = 1; a <= 10; a++)
            //{
            //    for (int b = 1; b <= 5; b++)
            //    {
            //        Console.Write(b + "x" + a + "=" + (a * b) + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Write("------------------------------------------------------------------------------------");
            //Console.Write("\n");
            //for (int a = 1; a <= 10; a++)
            //{
            //    for (int b = 6; b <= 10; b++)
            //    {
            //        Console.Write(b + "x" + a + "=" + (a * b) + "\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region * sayısını ve sıra sayısını kullanıcıdan alıp ekrana yazdıralım
            //Console.Write("Yıldız sayısı yazın: ");
            //int yıldız_sayisi = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Sıra sayısı girin: ");
            //int sıra_sayisi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= sıra_sayisi; i++)
            //{
            //    for (int j = 1; j <= yıldız_sayisi; j++)
            //    {
            //        Console.WriteLine("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region * karakterinden üçgen yapalım
            //int num_1 = 0;
            //Console.Write("sayı giriniz:");
            //num_1 = int.Parse(Console.ReadLine());
            //for (int i = 0; i < num_1; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region * karakterinden baklava dilimi yapalım
            //Console.Write("Baklava dilimi boyut yazın: ");
            //int boyut = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= boyut; i++)
            //{
            //    for (int j = 1; j <= boyut - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = boyut - 1; i >= 1; i--)
            //{
            //    for (int j = 1; j <= boyut - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}


            //İlkerin çözümü

            //int num_1 = 0;
            //Console.Write("sayı gir:");
            //Console.WriteLine();
            //num_1 = int.Parse(Console.ReadLine());
            //for (int i = 0; i < num_1; i++)
            //{
            //    for (int z = num_1; z > i + 1; z--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i < num_1; i++)
            //{
            //    for (int z = 1; z < i + 1; z++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = num_1; j > i; j--)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region While döngüsüne bakalım
            //Console.Write("Bir sayı giriniz: ");
            //int x = Convert.ToInt32(Console.ReadLine());

            //while (x < 56)
            //{
            //    Console.WriteLine("Bravooooooooo kazandınız");
            //    x++;
            //}
            #endregion

            #region Ekrana 10 kere adımızı yazdıralım
            //int x = 0;

            //while (x < 10)
            //{
            //    Console.WriteLine("ece");
            //    x++;
            //}
            #endregion

            #region Kullanıcının istediği metni yine onun istediği kadar ekrana yazdıralım
            //Console.Write("Bir metin giriniz: ");
            //string metin = Console.ReadLine();

            //Console.Write("Bir sayı giriniz: ");
            //int tekrar = Convert.ToInt32(Console.ReadLine());

            //int x = 0;

            //while (x < tekrar)
            //{
            //    Console.WriteLine(metin);
            //    x++;
            //}
            #endregion

            #region 1den 10a kadar sayıları ekrana yazdırıp toplamını bulalım
            //int i = 1;
            //int toplam = 0;

            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //    toplam = toplam + i;
            //}

            //Console.WriteLine("Toplam: " + toplam);
            #endregion

            #region 1den 50ye kadar olan tek sayıları toplayıp ekrana yazdıralım

            //int i = 0;
            //int toplam = 0;

            //while (i < 51)
            //{
            //    if (i % 2 == 1)
            //    {
            //        toplam = toplam + i;
            //    }

            //    i++;
            //}

            //Console.WriteLine("Toplam: " + toplam);
            #endregion

            #region Klavyeden girilen sayı 0 olana kadar girilen sayıları toplayıp ortalamasını alan programı yazalım
            //int toplam = 0, adet = 0;
            //while (true)
            //{
            //    Console.Write("Bir sayı giriniz: ");
            //    int sayi = Convert.ToInt16(Console.ReadLine());
            //    if (sayi == 0)
            //    {
            //        break;
            //    }
            //    toplam = toplam + sayi;
            //    adet = adet + 1;

            //}
            //Console.WriteLine("Toplam: " + toplam);
            //Console.WriteLine("Ortalama: " + toplam / adet);
            #endregion

            #region  Klavyeden girilen sayıların toplamı 100'ü bulduğunda kullanıcı kaç sayı girdiğinde 100ü geçmiş bunu ekran yazdıralım
            //int toplam = 0, i = 0;

            //while (true)
            //{
            //    Console.Write("Bir sayı giriniz: ");
            //    int sayi = Convert.ToInt16(Console.ReadLine());
            //    toplam = toplam + sayi;
            //    i++;

            //    if (toplam >= 100)
            //    {
            //        Console.WriteLine("Sayıların toplamı: " + toplam);
            //        Console.WriteLine(i + " kerede ulaşıldı");
            //        break;
            //    }
            //}

            //Diğer yöntem

            //int toplam = 0, adet = 0;
            //while (toplam <= 100)
            //{
            //    Console.Write("Sayı girin:");
            //    int sayi = Convert.ToInt16(Console.ReadLine());
            //    adet++;
            //    toplam = toplam + sayi;
            //}

            //Console.WriteLine("Girilen adet sayısı: " + adet + "ve toplam sayısı: " + toplam);
            #endregion

            #region 0-100 arası random sayı üretilecek. x sayısını y defa bulmak için kaç deneme yapılmalı, bunu ekrana yazdıralım
            //Random rnd = new Random();
            //int sayi_1, sayi_2;
            //int sayac_1 = 0, sayac_2 = 0;
            //int tekrar = 0;

            //Console.Write("Hangi sayıyı bulmak istiyorsunuz: ");
            //sayi_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Kaç kere bulmak istiyorsunuz: ");
            //tekrar = Convert.ToInt32(Console.ReadLine());

            //while (sayac_1 < tekrar)
            //{
            //    sayi_2 = rnd.Next(1, 101);
            //    if (sayi_1 == sayi_2)
            //        sayac_1++;
            //    sayac_2++;
            //}
            //Console.WriteLine($"seçilen sayı:{sayi_1}, {sayac_1} kere bulundu ve toplam:{sayac_2} deneme yapıldı");

            //Diğer çözüm

            //Random random = new Random();
            //int sayi = 0, adet = 0, sayacsayi = 0, sayacdongu = 0;
            //int rnd;

            //bool bl = true;

            //Console.Write("Bulunacak sayi:");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Adet sayisi");
            //adet = Convert.ToInt32(Console.ReadLine());

            //while (bl)
            //{
            //    rnd = random.Next(0, 100);
            //    sayacdongu++;
            //    if (sayi == rnd)
            //    {
            //        sayacsayi++;
            //        if (sayacsayi == adet)
            //        {
            //            bl = false;
            //        }
            //    }
            //}

            //Console.WriteLine("Üretilen toplam rasgele sayı:" + sayacdongu);

            #endregion



            #region Do while döngüsüne bakalım
            //do
            //{
            //    Console.WriteLine("Bir kere çalışır");
            //} while (false); 
            #endregion

            #region 10 kere ekrana selam yazdıralım
            //int x = 0;
            //do
            //{
            //    Console.WriteLine("selam");
            //    x++;
            //} while (x < 10);
            #endregion

            #region 1den 10a kadar olan sayıları do while ile ekrana yazdıralım
            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i < 11);

            #endregion

            #region Kullanıcı 10 adet sayı girsin, en büyük ve en küçüğü ekrana yazdıralım
            //int enKucuk = 0, enBuyuk = 0;
            //int i = 0;

            //do
            //{
            //    Console.Write("Bir sayı giriniz: ");
            //    int sayi = Convert.ToInt16(Console.ReadLine());

            //    if (sayi < enKucuk)
            //    {
            //        enKucuk = sayi;
            //    }

            //    if (sayi > enBuyuk)
            //    {
            //        enBuyuk = sayi;
            //    }

            //    i++;

            //} while (i < 10);

            //Console.WriteLine("En büyük sayı:" + enBuyuk);
            //Console.WriteLine("En küçük sayı:" + enKucuk);
            #endregion

            #region Girilen sayının asal olup olmadığını ekrana yazdıralım
            //Console.Write("Bir sayı giriniz: ");
            //int sayı = Convert.ToInt32(Console.ReadLine());
            //int kalan = 0;

            //for (int i = sayı; i > 0; i--)
            //{
            //    if (sayı % i == 0)
            //    {
            //        kalan++;
            //    }
            //}
            //if (kalan > 2)
            //{
            //    Console.WriteLine("Asal sayı değil");
            //}
            //else
            //{
            //    Console.WriteLine("Asal");
            //}
            #endregion

            #region Kullanıcı bir sayı girsin. Bu sayıdan küçük asal sayıları ekrana yazdıracak programı yazdıralım
            //Console.Write("Bir sayı girin: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(sayi +" sayısından küçük asal sayılar şöyledir:" );

            //for (int i = 2; i < sayi; i++)
            //{
            //    int kalan = 0;
            //    for (int j = i; j > 0; j--)
            //    {
            //        if (i % j == 0)
            //        {
            //            kalan++;
            //        }
            //    }
            //    if (kalan == 2)
            //    {
            //        Console.Write("{0} ", i);
            //    }
            //}

            #endregion

            #region Maaş hesaplayalım
            /*Aynı firmada çalışan Ahmet ve Hasan 2 işçiden 1.sinin Ahmedin ücreti ilk ay % 50 artmakta 2.ay % 25 azalmaktadır. Diğerinin(Hasanın) ise ücreti her ay % 25 artmaktadır. Her ikisinin de yılbaşındaki başlangıç ücretleri ve hesaplanacak. Ay bilgisi klavyeden girildikten sonra ay ay ücretlerinin ne olacağını ve en sonunda hangi işçinin daha fazla(Veya eşit) ücret alacağını hesaplayan programı yazınız. */

            //double ahmetMaas = 5000;
            //double hasanMaas = 5000;

            //Console.Write("Kaç ayın ücretini hesaplamak istiyorsunuz: ");
            //int aySayisi = Convert.ToInt16(Console.ReadLine());

            //for (int ay = 1; ay <= aySayisi; ay++)
            //{
            //    if (ay % 2 == 1)
            //    {
            //        ahmetMaas = ahmetMaas * 1.5;
            //    }

            //    else
            //    {
            //        ahmetMaas = ahmetMaas * 0.75;
            //    }

            //    hasanMaas = hasanMaas * 1.25;

            //    Console.WriteLine("{0}. Ay, Ahmetin maaşı {1}, Hasanın maaşı {2}", ay, ahmetMaas, hasanMaas);

            //}

            //if (ahmetMaas > hasanMaas)
            //{
            //    Console.WriteLine("Ahmetin maaşı Hasanın maaşından fazladır");
            //}
            //else if (hasanMaas > ahmetMaas)
            //{
            //    Console.WriteLine("Hasanın maaşı Ahmetin maaşından fazladır");
            //}
            //else
            //{
            //    Console.WriteLine("Ahmetin maaşı ile Hasanın maaşı eşittir");
            //}
            #endregion

            #region Bakteri sorusu
            //Her 2 saniyede 2 ye bölünen bakteri kolonisi var başlangıç durumunda 16 tane var 24.sn deki bakteri sayısı 12.saniyedeki bakteri sayısının kaç katıdır

            //Console.Write("Saniye Girin: ");
            //int saniye = Convert.ToInt32(Console.ReadLine());
            //int bakteri = 16;
            //int bakteri1 = 16;
            //int bakteri2 = 16;

            //for (int i = 1; i <= saniye; i += 2)
            //{
            //    bakteri = bakteri * 2;
            //    Console.WriteLine($"{i}.Saniyede Bakteri Sayısı={bakteri}");
            //    Console.WriteLine($"{i + 1}.Saniyede Bakteri Sayısı={bakteri}");

            //}
            //Console.WriteLine($"******************************************");


            //for (int i = 1; i <= 12; i += 2)
            //{
            //    bakteri1 = bakteri1 * 2;
            //}

            //for (int i = 1; i <= 24; i += 2)
            //{
            //    bakteri2 = bakteri2 * 2;
            //}

            //int sonuc = bakteri2 / bakteri1;

            //Console.WriteLine($"12.Saniyede Bakteri Sayısı = {bakteri1}");
            //Console.WriteLine($"24.Saniyede Bakteri Sayısı = {bakteri2}");
            //Console.WriteLine($"kat = {sonuc}");
            #endregion

            #region 2 ile çarpılıp 2 ile bölünen sayılar
            //İki sayı çarpılmak isteniyor. Birinci sayıyı devamlı 2 ile çarpılıyor, ikinci sayı devamlı 2ye bölünüyor. 2ye bölünen kısımda sonuç tek sayı ise karşılığını işaretliyoruz. Bu işaretlenenlerin toplamı iki sayının çarpımına eşit oluyor

            //int toplam = 0;
            //Console.Write("Birinci sayıyı giriniz=");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.Write("İkinci sayıyı giriniz=");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Bölümler   Çarpımlar");

            //do
            //{
            //    if (sayi1 % 2 == 1)
            //    {
            //        toplam = toplam + sayi2;
            //    }
            //    sayi1 = sayi1 / 2;
            //    ;
            //    Console.Write(sayi1);
            //    sayi2 = sayi2 * 2;

            //    Console.Write("\t" + "\t" + sayi2);
            //    Console.WriteLine("\n");
            //} while (sayi1 >= 1);
            //Console.WriteLine("Sonuç = " + toplam);
            #endregion

            #region Mükemmel sayıyı bulalım
            //int sayi, toplam = 0;
            //Console.Write("Bir sayı giriniz: ");
            //sayi = Convert.ToInt16(Console.ReadLine());

            //for (int i = 1; i < sayi; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        toplam = toplam + i;
            //        Console.WriteLine(i);
            //    }

            //}

            //if (toplam == sayi)
            //{
            //    Console.WriteLine(sayi + " mükemmel sayıdır");
            //}
            //else
            //{
            //    Console.WriteLine(sayi + " mükemmel sayı değildir");
            //}
            #endregion

            #region Belli bir sayıdan geriye doğru gelirken her mükemmel sayıyı ekrana yazdıralım

            //int toplam = 0;
            //Console.WriteLine("Bir sayı giriniz");
            //int aralik = Convert.ToInt32(Console.ReadLine());
            //for (int i = aralik; i > 0; i--)
            //{
            //    toplam = 0;
            //    for (int j = i - 1; j > 0; j--)
            //    {
            //        if (i % j == 0)
            //        {
            //            toplam += j;
            //        }
            //    }
            //    if (toplam == i)
            //    {
            //        Console.WriteLine(i + " mükemmel sayı");
            //    }
            //}
            #endregion



            // --------------- KENDİ SORULARIM ---------------

            #region Kareleri 100den küçük pozitif tam sayıları ekrana yazıralım
            //int sayı;

            //for (int i = 1; i < 10; i++)
            //{
            //    sayı = i * i;
            //    Console.WriteLine(sayı);
            //}
            #endregion

            #region 100 ile 200 arasındaki çift sayıların toplamını veren programı yazalım
            //int toplam = 0;

            //for (int i = 100; i < 200; i += 2)
            //{
            //    toplam = toplam + i;
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Toplam: " + toplam);
            #endregion

            #region 100 ile 200 arasında 7ye kalansız bölünebilen sayıların toplamını veren programı yazalım
            //int toplam = 0;

            //for (int i = 100; i < 200; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        toplam = toplam + i;
            //        Console.WriteLine(i);

            //    }
            //}
            //Console.WriteLine("Toplam: " + toplam);
            #endregion

            #region * Karakterinden şekil çıkaralım
            //Console.Write("Sayı giriniz: ");
            //int sayı = Convert.ToInt16(Console.ReadLine());

            //for (int i = 0; i < sayı; i++)
            //{
            //    for (int j = 0; j < sayı; j++)
            //    {
            //        Console.Write(" * ");
            //    }
            //    Console.WriteLine();

            //}

            //for (int i = 0; i < sayı; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < sayı; i++)
            //{
            //    for (int j = sayı; j > i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= sayı; i++)
            //{
            //    for (int j = 1; j <= sayı - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Faktöriyel bulalım. Hem while hem for ile yapalım
            //Console.Write("Bir sayı giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());

            //int sonuc = 1;
            //string yazi = "";

            //while (sayi > 0)
            //{
            //    sonuc = sonuc * sayi;

            //    if (sayi != 1)
            //    {
            //        yazi = yazi + $"{sayi} x ";
            //    }

            //    else
            //    {
            //        yazi = yazi + $"{sayi} = {sonuc}";
            //    }
            //    sayi--;

            //}

            //Console.Write(yazi);

            //-----------------------------------

            //Console.Write("Bir sayı giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());

            //int sonuc = 1;
            //string yazi = "";

            //for (int i = sayi; i > 0; i--)
            //{
            //    sonuc = sonuc * i;

            //    if (i != 1)
            //    {
            //        yazi = yazi + $"{i} x ";
            //    }

            //    else
            //    {
            //        yazi = yazi + $"{i} = {sonuc}";
            //    }

            //}

            //Console.Write(yazi);
            #endregion

            #region Toplam meyveyi bulalım
            //Elma, armut ve çileklerden oluşan bir sepetimiz var.Bu sepetin içinde kaç tane elma, kaç tane armut ve kaç tane çilek olduğunu belirten bir dizi oluşturalım. Bu dizideki tüm elemanları toplayarak sepetimizdeki toplam meyve sayısını bulalım

            //int[] sepet = new int[] { 3, 8, 5 };

            //int toplamMeyve = 0;

            //for (int i = 0; i < sepet.Length; i++)
            //{
            //    for (int j = 0; j < sepet[i]; j++)
            //    {
            //        toplamMeyve++;
            //    }
            //}

            //Console.WriteLine(toplamMeyve);
            #endregion

            #region Taban ve üs değerlerini kullanarak bir sayının üssünü hesaplayan bir program yazalım
            //Console.Write("Taban değeri giriniz: ");
            //int taban = int.Parse(Console.ReadLine());
            //Console.Write("Üs değeri giriniz: ");
            //int üs = int.Parse(Console.ReadLine());

            //int sonuc = 1;

            //for (int i = 1; i <= üs; i++)
            //{
            //    sonuc = sonuc * taban;
            //}
            //Console.WriteLine(sonuc);

            #endregion



        }
    }
}
