using System;

namespace _06.Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dizi mantığını anlayalım
            //int[] sayilar = { 10, 20, 30, 40, 50 };
            //Console.WriteLine(sayilar[4]); //ekrana 50 yazar

            //string[] isimler = { "Adem", "Jale", "Hasan" };
            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}

            //int[] sayilar2 = new int[3];
            //sayilar2[0] = 99;
            //sayilar2[1] = 87;
            //sayilar2[2] = 87;
            //foreach (var sayi in sayilar2)
            //{
            //    Console.WriteLine(sayi);
            //}
            #endregion

            #region İstanbulun ilçelerini bir diziye tanımlayalım
            //string[] ilceler = { "Ümraniye", "Kadıköy", "Beyoğlu" };
            //Console.WriteLine(ilceler[0]);
            //Console.WriteLine(ilceler[1]);
            //Console.WriteLine(ilceler[2]);

            //string[] ilceler2 = new string[4];
            //ilceler2[0] = "Üsküdar";
            //ilceler2[1] = "Beşiktaş";
            //ilceler2[2] = "Maltepe";
            //ilceler2[3] = Console.ReadLine(); //kullanıcadan alabiliriz
            //foreach (var ilce in ilceler2)
            //{
            //    Console.WriteLine(ilce);
            //}
            #endregion

            #region Kullanıcı 10 tane sayı girsin, bunları bir dizide tutup ekrana yazdıralım
            //int[] sayilar = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Sayı giriniz: ");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());

            //}

            //Console.WriteLine("Yazdırılan sayılar: ");

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            #endregion

            #region 5 adet çiçek ismini kullanıcıdan alıp listeleyelim
            //string[] cicekler = new string[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Çiçek adı giriniz: ");
            //    cicekler[i] = Console.ReadLine();
            //}

            //Console.WriteLine("Yazdırılan çiçek isimleri: ");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(cicekler[i]);
            //}

            #endregion

            #region Diziyi 5 adet random sayı ile dolduralım
            //Random random = new Random();

            //int[] sayilar = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    sayilar[i] = random.Next();

            //}

            //Console.WriteLine("Atanan rastgele 5 sayı şöyledir:");

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            #endregion

            #region Ortalama hesaplayalım
            //Dizinin eleman sayısı 1-20 arasında rastgele bir adet. Dizide tutulan değerler ise 1-100 arasında yine rastgele değerler olacak. Dizinin içindeki elemanların ortalamasını ekrana yazdıralım.

            //Random random = new Random();

            //int[] dizi = new int[random.Next(1, 20)];

            //int toplam = 0;

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = random.Next(1, 100);
            //    toplam = toplam + dizi[i];
            //    Console.WriteLine(i + ".hücre " + dizi[i]);
            //}

            //Console.WriteLine("Ortalama: " + toplam / dizi.Length);
            #endregion

            #region Çift ile tek sayıların farkını bulalım
            //200 adetli dizi olsun. Atanan sayılar 1-100 arası rastgele sayılar olsun. Atanan tek sayıların toplamı ile çift sayıların toplaması arasındaki farkı bulalım

            //Random random = new Random();

            //int[] dizi = new int[200];

            //int cift_toplam = 0, tek_toplam = 0;

            //for (int i = 0; i < 200; i++)
            //{
            //    dizi[i] = random.Next(1, 100);

            //    if (dizi[i] % 2 == 0)
            //    {
            //        cift_toplam = cift_toplam + dizi[i];
            //    }

            //    else
            //    {
            //        tek_toplam = tek_toplam + dizi[i];
            //    }
            //}

            //Console.WriteLine("Fark: " + (cift_toplam - tek_toplam));
            #endregion

            #region Kullanıcı herhangi bir cümle girsin. Son 3 karakterini ekrana yazdıralım
            //int a = 0;

            //Console.Write("Bir cümle giriniz: ");
            //string cumle = Console.ReadLine();

            //for (int i = cumle.Length - 1; i >= 0; i--)
            //{
            //    if (i >= cumle.Length - 3)
            //    {
            //        Console.WriteLine($"Sondan {a}. karakter: {cumle[i]}");
            //        a++;
            //    }
            //}
            #endregion

            #region Klavyeden girilen herhangi bir cümlede kaç tane sesli harf olduğunu bulalım
            //int toplam = 0;

            //char[] sesli = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            //Console.Write("Bir cümle giriniz: ");
            //string cumle = Console.ReadLine();

            //for (int i = 0; i < cumle.Length; i++)
            //{
            //    for (int j = 0; j < sesli.Length; j++)
            //    {
            //        if (cumle[i] == sesli[j])
            //        {
            //            toplam = toplam + 1;
            //        }
            //    }
            //}
            //Console.WriteLine("Toplam: " + toplam);
            #endregion

            #region A dizisi yapalım
            //Elemanları tam sayı olan bir A dizisinin(20 elemanlı) rastgele sayılar atayan, sonra elemanlarının aritmetik ortalamasını hesaplayan ve elemanlarından kaç tanesinin bu ortalamadan büyük ve küçük olduğunu sayan program.

            //Random random = new Random();
            //int[] A = new int[20];

            //int toplam = 0, ortalama;

            //for (int i = 0; i < 20; i++)
            //{
            //    A[i] = random.Next(1, 100);

            //    toplam = toplam + A[i];

            //}

            //Console.WriteLine("Toplam: " + toplam);

            //ortalama = toplam / 20;
            //Console.WriteLine("Ortalama: " + ortalama);

            //int buyukSayiAdedi = 0, kucukSayiAdedi = 0;
            //for (int i = 0; i < 20; i++)
            //{
            //    if (A[i] > ortalama)
            //    {
            //        buyukSayiAdedi++;
            //    }

            //    else
            //    {
            //        kucukSayiAdedi++;
            //    }
            //}

            //Console.WriteLine($"Ortalamadan büyük adet {buyukSayiAdedi} ve ortalamadan küçük adet {kucukSayiAdedi}");
            #endregion

            #region 100 ve 100den büyük olan sayıları bir diziye atayan programı yazalım
            //Kullanıcı kaç elemanlı dizi oluşturacağını belirleyecek. 1-200 arasında rastgele sayılar üretilecek. 100 ve 100den büyük olan sayıları bir diziye atayan programı yazalım

            //Random random = new Random();

            //Console.Write("Kaç elemanlı dizi istediğinizi söyleyin: ");
            //int eleman = Convert.ToInt16(Console.ReadLine());

            //int[] dizi = new int[eleman];

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    int value = random.Next(1, 200);

            //    if (value >= 100)
            //    {
            //        dizi[i] = value;
            //        Console.WriteLine(dizi[i]);
            //    }
            //}

            //Farklı çözüm

            //Random rnd = new Random();
            //int number = 0, i = 0;
            //int number_2;
            //int[] array;
            //Console.Write("dizinin uzunluğunu giriniz:");
            //number = int.Parse(Console.ReadLine());
            //array = new int[number];

            //while (number != i)
            //{
            //    number_2 = rnd.Next(1, 200);
            //    if (number_2 >= 100)
            //    {
            //        array[i] = number_2;
            //        i++;
            //    }
            //}
            //for (i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"{array[i]} ");
            //}


            //Kaç defada bulduğunu yazdırmak içinde sayaç ekleyebiliriz

            //int sayi = 0;
            //Console.WriteLine("bir adet giriniz: ");
            //int adet = int.Parse(Console.ReadLine());
            //Random rnd = new Random();
            //int[] sayilar = new int[adet];
            //for (int i = 0; i < adet;)
            //{
            //    sayi = rnd.Next(20, 180);
            //    if (sayi > 100)
            //    {
            //        sayilar[i] = sayi;
            //        i++;
            //    }
            //}
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine("sayilar:[" + sayi + "]=" + sayilar[i]);
            //}
            #endregion

            #region Girilen sayıda dizide kaç adet varsa o sayıyı ekrana yazdıralım
            //Kullanıcı kaç elamanlı dizi oluşturacağını söyleyecek. 1-9 arası random sayı komutu yazılacak. Girilen sayıda dizide kaç adet varsa o sayıyı ekrana yazdıralım

            //Console.Write("Kaç elemanlı dizi istediğinizi söyleyin: ");
            //int eleman = Convert.ToInt16(Console.ReadLine());

            //Console.Write("Dizide aranmasını istediğiniz 1-9 arasında olan sayıyı söyleyin ");
            //int aranan = Convert.ToInt16(Console.ReadLine());

            //int[] dizi = new int[eleman];

            //Random random = new Random();

            //int adet = 0;

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = random.Next(1, 9);

            //    if (dizi[i] == aranan)
            //    {
            //        adet++;
            //    }
            //}

            //Console.WriteLine($"{eleman} elemanlı dizide {aranan} rakamı {adet} adet var");
            #endregion

            #region Mahkum sorusunu çözelim
            //100 mahkumun her biri birer hücredir. Hücre sayıları 1den başlayarak 100e kadar sıralı. 1.mahkum kilidini bir kere çevirip çıkıyor. Yani 1.mahkum kilidi 1.hücredenden 100.hücreye kadar 1er defa, 2.mahkum kilidi 2.hücreden 100.hücreye kadar 2şer defa, 3.mahkum kilidi 3.hücreden 100.hücreye kadar 3er defa çevirecek. Süreç böyle devam ediyor. Süreç sonunda hangi mahkumlar serbest hangileri değil bunu iç içe forlar ile yazalım.

            //int toplam = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    toplam = i * (i + 1) / 2;
            //    if (toplam % 2 == 0)
            //    {
            //        Console.WriteLine(i + ". hücredeki mahkum çıkamaz" + "toplamı = " + toplam); ;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i + ". hücredeki mahkum çıkabilir" + "toplamı = " + toplam);
            //    }
            //}

            //Diğer çözüm

            //int toplam = 0;
            //int[] mahkum = new int[100];
            //for (int i = 0; i < 100; i++)
            //{
            //    toplam += i;
            //    if (toplam % 2 == 1)
            //    {
            //        mahkum[i] = i;
            //        Console.WriteLine($"çıkacak mahkumlar={mahkum[i]}");
            //    }
            //}
            #endregion

            #region Kullanıcı bir cümle girsin. Kelime sayısını ekrana yazdıralım
            //Console.Write("Bir cümle girin: ");
            //string metin = Console.ReadLine();
            //int sayac = 0;

            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if (metin[i] == ' ')
            //    {
            //        sayac++;
            //    }
            //}
            //Console.WriteLine(sayac + 1);
            #endregion

            #region 2 boyutlu diziye giriş
            //int[,] kup = new int[2, 3];

            //kup[0, 0] = 8;
            //kup[0, 1] = 8;
            //kup[0, 2] = 85;
            //kup[1, 0] = 4;
            //kup[1, 1] = 7;
            //kup[1, 2] = 2;

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("[" + i + "]" + "[" + j + "]" + "= " + kup[i, j]);
            //    }
            //}
            #endregion

            #region 2 boyutlu dizi ile sınıfımızdaki kişileri oluşturalım
            //string[,] sıra = new string[3, 5];

            //sıra[0, 0] = "Ahmet";
            //sıra[0, 1] = "Boş";
            //sıra[0, 2] = "İbrahim";
            //sıra[0, 3] = "Salih";
            //sıra[0, 4] = "Mustafa";

            //sıra[1, 0] = "Beyza";
            //sıra[1, 1] = "İlker";
            //sıra[1, 2] = "Fatih";
            //sıra[1, 3] = "Zeynep";
            //sıra[1, 4] = "Boş";

            //sıra[2, 0] = "Uğurcan";
            //sıra[2, 1] = "Musa";
            //sıra[2, 2] = "Furkan";
            //sıra[2, 3] = "Zehra";
            //sıra[2, 4] = "Ece";

            //Console.WriteLine(sıra[2, 1]);
            #endregion

            #region 2 boyutlu dizi oluşturup ortalama alalım
            //2 Boyutlu bir dizi oluşturulacak. Kullanıcı satır ve sütun sayısını girecek, diziye random değer atanacak. Dizinin ortalaması alınacak.

            //Console.Write("Satır sayısını giriniz: ");
            //int satir = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Sütun sayısını giriniz: ");
            //int sutun = Convert.ToInt32(Console.ReadLine());

            //int toplam = 0;

            //int[,] dizi = new int[satir, sutun];

            //Random random = new Random();

            //for (int i = 0; i < satir; i++)
            //{
            //    for (int j = 0; j < sutun; j++)
            //    {
            //        dizi[i, j] = random.Next(1, 100);
            //        toplam = toplam + dizi[i, j];
            //    }

            //}
            //int ortalama = toplam / (satir + sutun);
            //Console.WriteLine(ortalama);
            #endregion

            #region 2 boyutlu dizi oluşturup satır ve sütunlarun toplamlarını bulalım
            //İki boyutlu bir dizi oluşturulacak. Kullanıcı satır ve sütun sayısı girecek. Diziye random değer atanacak. Dizinin satır ve sütunlarının ayrı ayrı toplamlarını ekrana yazacak program.

            //Random rast = new Random();

            //Console.WriteLine("kaç satırdan oluşan dizi istiyorsunuz");
            //int satır = int.Parse(Console.ReadLine());
            //Console.WriteLine("kaç sütündan oluşan dizi istiyorsunuz");
            //int sutun = int.Parse(Console.ReadLine());

            //int[,] dizi = new int[satır, sutun];
            //int[] toplamsatır = new int[satır];
            //int[] toplamsutun = new int[sutun];
            //for (int i = 0; i < satır; i++)
            //{
            //    for (int j = 0; j < sutun; j++)
            //    {
            //        dizi[i, j] = rast.Next(500);
            //        Console.WriteLine("dizi[" + i + "," + j + "]" + "=" + dizi[i, j] + "\t");
            //    }
            //}
            //for (int i = 0; i < satır; i++)
            //{
            //    for (int j = 0; j < sutun; j++)
            //    {
            //        toplamsatır[i] = toplamsatır[i] + dizi[i, j];
            //    }
            //}

            //for (int i = 0; i < sutun; i++)
            //{
            //    for (int j = 0; j < satır; j++)
            //    {
            //        toplamsutun[i] = toplamsutun[i] + dizi[j, i];
            //    }
            //}

            //for (int i = 0; i < satır; i++)
            //{
            //    Console.WriteLine("{0}. satır toplamı={1}", i, toplamsatır[i]);
            //}

            //for (int i = 0; i < sutun; i++)
            //{
            //    Console.WriteLine("{0}. sutun toplamı={1}", i, toplamsutun[i]);
            //}
            #endregion

            #region İki adet 2 boyutlu dizi oluşturalım
            //İki adet çift boyutlu dizi oluşturulup bu dizilerin toplamlarını yeni bir çift boyutlu dizi içine atacak ve sayıların ortalamasını alacak program.

            //    Random rnd = new Random();
            //    int toplam = 0, Ortalama = 0, enb = 0, enk = 0, kckSay = 0, bykSay = 0, esit = 0;
            //    int[,] dizi = new int[4, 5];
            //    int[,] seri = new int[4, 5];
            //    int[,] ortak = new int[4, 5];
            //ket:
            //    for (int i = 0; i < dizi.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < dizi.GetLength(1); j++)
            //        {
            //            dizi[i, j] = rnd.Next(500);
            //            seri[i, j] = rnd.Next(500);
            //        }
            //    }
            //    for (int i = 0; i < dizi.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < dizi.GetLength(1); j++)
            //        {
            //            ortak[i, j] = dizi[i, j] + seri[i, j];
            //        }
            //    }
            //    Console.WriteLine("Dizi dizisi");
            //    for (int i = 0; i < dizi.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < dizi.GetLength(1); j++)
            //        {
            //            Console.Write(dizi[i, j] + "\t");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine("Seri dizisi");
            //    for (int i = 0; i < dizi.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < dizi.GetLength(1); j++)
            //        {
            //            Console.Write(seri[i, j] + "\t");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine("Ortak  dizisi");
            //    for (int i = 0; i < dizi.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < dizi.GetLength(1); j++)
            //        {
            //            toplam += ortak[i, j];
            //            Console.Write(ortak[i, j] + "\t");
            //        }
            //        Console.WriteLine();
            //    }
            //    Ortalama = toplam / 20;
            //    Console.WriteLine();
            //    Console.WriteLine("Toplam= " + toplam + "     Ortalama =" + Ortalama);
            #endregion

            #region 2 boyutlu dizi oluşturup sayıların ortalamasını, ortalamadan büyük ve küçük sayıları bulalım
            //İki adet çift boyutlu dizi oluşturulup bu dizilerin toplamlarını yeni bir çift boyutlu dizi içine atacak ve sayıların ortalamasını alacak ve ortalamadan büyük ve küçük sayıları yazan program.

            //int[,] diziçift = new int[3, 3];
            //int[] dizitek = new int[9];
            //Random rast = new Random();
            //int sayac = 0;
            //for (int i = 0; i < diziçift.GetLength(0); i++)
            //{
            //    for (int j = 0; j < diziçift.GetLength(1); j++)
            //    {
            //        diziçift[i, j] = rast.Next(1, 10);
            //        Console.WriteLine(diziçift[i, j] + "\t");
            //    }
            //    Console.WriteLine("\n");
            //}
            //for (int i = 0; i < diziçift.GetLength(0); i++)
            //{
            //    for (int j = 0; j < diziçift.GetLength(1); j++)
            //    {
            //        dizitek[sayac] = diziçift[i, j];
            //        sayac++;
            //    }
            //    Console.WriteLine("\n");
            //}
            #endregion

            #region Bir adet çift boyutlu dizi oluşturup bu diziyi tek boyutlu diziye dönüştürelim
            //int[,] diziçift = new int[3, 5];
            //int[] dizitek = new int[15];

            //Random rast = new Random();

            //int sayac = 0;

            //for (int i = 0; i < diziçift.GetLength(0); i++) //0.indeks demek yani 3
            //{
            //    for (int j = 0; j < diziçift.GetLength(1); j++)  //1.indeks demek yani 5
            //    {
            //        diziçift[i, j] = rast.Next(1, 10);
            //        Console.WriteLine(diziçift[i, j] + "\t");
            //    }
            //    Console.WriteLine("\n");
            //}

            //for (int i = 0; i < diziçift.GetLength(0); i++)
            //{
            //    for (int j = 0; j < diziçift.GetLength(1); j++)
            //    {
            //        dizitek[sayac] = diziçift[i, j];
            //        sayac++;
            //    }
            //    Console.WriteLine("\n");
            //}
            #endregion

            #region Takımlar oluşturup turnuva yapalım
            //int[] takımlar = new int[8];
            //for (int i = 0; i < 8; i++)
            //{
            //    takımlar[i] = i + 1;
            //}
            //int sayac = 0, sayac2 = 0, sayac3 = 0, sayac4 = 0;
            //Random ran = new Random();
            //int[] dizi2 = new int[takımlar.Length / 2];
            //int[] dizi3 = new int[takımlar.Length / 2];
            //for (int i = 0; i < takımlar.Length;)
            //{
            //    int eleman = ran.Next(1, 9);
            //    for (int j = 0; j < dizi2.Length; j++)
            //    {
            //        if (eleman == dizi2[j])
            //        {
            //            sayac++;
            //        }
            //        if (eleman == dizi3[j])
            //        {
            //            sayac++;
            //        }
            //    }
            //    if (sayac2 % 2 == 1)
            //    {
            //        if (sayac == 0)
            //        {
            //            dizi2[sayac3] = eleman;
            //            i++;
            //            sayac3++;
            //            sayac2++;
            //        }
            //    }
            //    else if (sayac2 % 2 == 0)
            //    {
            //        if (sayac == 0)
            //        {
            //            dizi3[sayac4] = eleman;
            //            i++;
            //            sayac4++;
            //            sayac2++;
            //        }
            //    }
            //    sayac = 0;
            //}
            //Console.WriteLine("İlk Turnuva Maçları\n----------------------");
            //for (int i = 0; i < dizi2.Length; i++)
            //{
            //    Console.WriteLine("Takım" + dizi2[i] + " Vs " + "Takım" + dizi3[i]);
            //}
            //for (int i = 0; i < dizi2.Length; i++)
            //{
            //    int mac = ran.Next(1, 3);
            //    if (mac == 1)
            //    {
            //        dizi2[i] = 0;
            //    }
            //    else if (mac == 2)
            //    {
            //        dizi3[i] = 0;
            //    }
            //}
            //int[] dizi4 = new int[4];
            //int sayac5 = 0;
            //Console.WriteLine("Maçlar Başlasın mı ?");
            //Console.Read();
            //Console.WriteLine("!!!!!...Turnuva 1 Başlıyor...!!!!");
            //for (int i = 0; i < dizi2.Length; i++)
            //{
            //    Console.Write((i + 1) + ". Maç Yapılıyor.");
            //    System.Threading.Thread.Sleep(1000);
            //    Console.Write(".");
            //    System.Threading.Thread.Sleep(1000);
            //    Console.Write(".\n");
            //    System.Threading.Thread.Sleep(1000);
            //    if (dizi2[i] != 0)
            //    {
            //        Console.WriteLine((i + 1) + ". Maçın Kazananı = Takım" + dizi2[i]);
            //        dizi4[sayac5] = dizi2[i];
            //        sayac5++;
            //    }
            //    else if (dizi3[i] != 0)
            //    {
            //        Console.WriteLine((i + 1) + ". Maçın Kazananı = Takım" + dizi3[i]);
            //        dizi4[sayac5] = dizi3[i];
            //        sayac5++;
            //    }
            //}

            //int[] dizi5 = new int[2];
            //int[] dizi6 = new int[2];
            //sayac4 = 0;
            //sayac3 = 0;
            //sayac5 = 0;
            //sayac2 = 0;
            //for (int i = 0; i < 4;)
            //{
            //    int eleman = ran.Next(0, 4);
            //    for (int j = 0; j < dizi5.Length; j++)
            //    {
            //        if (dizi4[eleman] == dizi5[j])
            //        {
            //            sayac++;
            //        }
            //        if (dizi4[eleman] == dizi6[j])
            //        {
            //            sayac++;
            //        }
            //    }
            //    if (sayac2 % 2 == 1)
            //    {
            //        if (sayac == 0)
            //        {
            //            dizi5[sayac3] = dizi4[eleman];
            //            i++;
            //            sayac3++;
            //            sayac2++;
            //        }
            //    }
            //    else if (sayac2 % 2 == 0)
            //    {
            //        if (sayac == 0)
            //        {
            //            dizi6[sayac4] = dizi4[eleman];
            //            i++;
            //            sayac4++;
            //            sayac2++;
            //        }
            //    }
            //    sayac = 0;
            //}
            //Console.WriteLine("5 Sn Sonra 1. Tur Turnuva Maçları Bitiyor");
            //System.Threading.Thread.Sleep(5000);
            //Console.Clear();
            //Console.WriteLine("2. Turnuva Maçları\n----------------------");
            //for (int i = 0; i < dizi5.Length; i++)
            //{
            //    Console.WriteLine("Takım" + dizi5[i] + " Vs " + "Takım" + dizi6[i]);
            //}
            //for (int i = 0; i < dizi6.Length; i++)
            //{
            //    int mac = ran.Next(1, 2);
            //    if (mac == 1)
            //    {
            //        dizi5[i] = 0;
            //    }
            //    else if (mac == 2)
            //    {
            //        dizi6[i] = 0;
            //    }
            //}
            //Console.WriteLine();
            //sayac5 = 0;
            //int[] dizi7 = new int[2];
            //Console.WriteLine("!!!!!...Turnuva 2 Başlıyor...!!!!");
            //Console.WriteLine("5 Sn Sonra 2. Turnuva Maçları Başlıyor");
            //System.Threading.Thread.Sleep(5000);
            //for (int i = 0; i < dizi5.Length; i++)
            //{
            //    Console.Write((i + 1) + ". Maç Yapılıyor.");
            //    System.Threading.Thread.Sleep(1000);
            //    Console.Write(".");
            //    System.Threading.Thread.Sleep(1000);
            //    Console.Write(".\n");
            //    System.Threading.Thread.Sleep(1000);
            //    if (dizi2[i] != 0)
            //    {
            //        Console.WriteLine((i + 1) + ". Maçın Kazananı = Takım" + dizi5[i]);
            //        dizi7[sayac5] = dizi5[i];
            //        sayac5++;
            //    }
            //    else if (dizi3[i] != 0)
            //    {
            //        Console.WriteLine((i + 1) + ". Maçın Kazananı = Takım" + dizi6[i]);
            //        dizi7[sayac5] = dizi6[i];
            //        sayac5++;
            //    }
            //}
            //Console.WriteLine("!!!! Final !!!!\n----------------");
            //Console.WriteLine("Takım" + dizi7[0] + " Vs " + "Takım" + dizi7[1]);
            //Console.WriteLine("Final 5 Sn sonra Başlıyacak ?");
            //System.Threading.Thread.Sleep(5000);
            //Console.Clear();
            //Console.WriteLine();
            //Console.WriteLine("!!!!!...Final Başlıyor...!!!!");
            //System.Threading.Thread.Sleep(2000);
            //Console.WriteLine("Maç Yapılıyor " + "Takım" + dizi7[0] + " Vs " + "Takım" + dizi7[1]);
            //System.Threading.Thread.Sleep(3000);
            //Console.Clear();
            //int mac2 = ran.Next(3, 5);
            //if (mac2 == 3)
            //{
            //    Console.WriteLine("Final Maçın Kazananı = Takım" + dizi7[0]);
            //}
            //else if (mac2 == 4)
            //{
            //    Console.WriteLine("Final Maçın Kazananı = Takım" + dizi7[1]);
            //}
            #endregion

        }
    }
}
