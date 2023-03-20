using System;
using System.Collections;

namespace _15.Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Koleksiyonlar, dizide olan veri kaybını önler.

            #region Dizide değerin kaybolduğunu görelim
            //string[] dizi = new string[] { "Adem", "Salih", "Ahmet" };
            //Console.WriteLine("önce " + dizi[0]);
            //dizi[0] = "yeni";

            //Console.WriteLine("sonra" + dizi[0]); 
            #endregion

            #region Koleksiyona ait bazı metotları kullanalım
            //ArrayList liste = new ArrayList();
            //liste.Add(1);
            //liste.Add(2);
            //liste.Add(3);
            //liste.Add("Ece");
            //liste.Add('K');
            //int adet = liste.Count;
            //liste.Insert(3, adet);
            //liste.RemoveAt(2);
            //Console.WriteLine("Bulunduğu index: " + liste.IndexOf('K'));


            //if (liste.Contains(1))
            //{
            //    Console.WriteLine("içinde var");
            //}

            //foreach (var listeElemani in liste)
            //{
            //    Console.WriteLine(listeElemani);
            //}

            //liste.Remove("Ece"); 
            #endregion

            #region Araba örneği
            //int sayac = 0;
            //ArrayList arabalar = new ArrayList();

            //Console.WriteLine("Arabayı eklemek için 1");
            //Console.WriteLine("Arabayı silmek için 2");
            //Console.WriteLine("Arabayı bitirmek için 3");
            //Console.WriteLine("Arabaları listelemek için 4");
            //Console.WriteLine("tuşuna basınız");
            //int secim = Convert.ToInt32(Console.ReadLine());

            //switch (secim)
            //{
            //    case 1:
            //        Console.Write("Arabanın markasını giriniz: ");
            //        string marka = Console.ReadLine().ToLower();
            //        Console.Write("Arabanın modelini giriniz: ");
            //        string model = Console.ReadLine().ToLower();
            //        Console.Write("Arabanın rengini giriniz: ");
            //        string renk = Console.ReadLine().ToLower();
            //        sayac++;
            //        break;

            //    case 2:
            //        Console.WriteLine("Silmek istediğiniz arabanın markasını giriniz: ");
            //        string silinen = Console.ReadLine().ToLower();


            //        break;

            //    case 3:

            //        break;

            //    case 4:
            //        foreach (var ara in arabalar)
            //        {
            //            Console.WriteLine(ara);
            //        }



            //        break;

            //    default:
            //        Console.WriteLine("Lütfen 1 ile 4 arasında bir sayı giriniz");
            //        break;


            //        //İLKERİN ÇÖZÜMÜ

            //        ArrayList cars = new ArrayList();
            //        byte step = 0;
            //        while (true)
            //        {
            //            Console.Write("araba markasını gir:");
            //            string carBrand = Console.ReadLine().ToUpper();
            //            cars.Add(carBrand);
            //            Console.Write("araba modeli gir:");
            //            string carModel = Console.ReadLine().ToUpper();
            //            cars.Add(carModel);
            //            Console.Write("araba rengi gir:");
            //            string carColor = Console.ReadLine().ToUpper();
            //            cars.Add(carColor);
            //            Console.WriteLine("listelemek için 1'e basınız devam etmek için herhangi bir tuşa basın");
            //            string choose = Console.ReadLine();

            //            if (choose == "1")
            //                break;
            //        }
            //        foreach (var item in cars)
            //        {
            //            Console.Write(item + " ");
            //            step++;
            //            if (step == 3)
            //            {
            //                step = 0;
            //                Console.WriteLine();
            //            }
            //        }

            //}
            #endregion

            #region Enum'ı öğrenelim
            //Ogrenci ogrenci = new Ogrenci();
            //ogrenci.Adi = "Melih";
            //ogrenci.Soyadi = "Kale";
            //ogrenci.Alani = Alan.Sayisal;
            #endregion

            #region Enum ile günleri yazalım
            //Console.WriteLine(Enum.GetName(typeof(Gunler),3));    //Persembeyi getirecek

            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(Enum.GetName(typeof(Gunler),i));
            //} 
            #endregion

            #region Hashtable'ı öğrenelim
            //    Hashtable ht = new Hashtable();
            //    ht.Add("Üsküdar", "İstanbul");
            //    ht.Add("Kadıköy", "İstanbul");
            //    ht.Add("Sincan", "Ankara");
            //    ht.Add("Çankaya", "Ankara");
            //    ht.Add("İkizdere", "Rize");
            //    ht.Add("Çayeli", "Rize");
            //    ht.Add("Görele", "Giresun");
            //    ht.Add("Çanakçı", "Giresun");


            //label:
            //    Console.WriteLine("Hangi Şehir ile ilgili bilgileri istiyorsunuz ?\nİstanbul : 1\nAnkara   : 2\nRize     : 3\nGiresun  : 4");
            //    switch (Console.ReadLine())
            //    {
            //        case "1":
            //            Console.WriteLine("İstanbulun İlçeleri\n----------------------");
            //            foreach (DictionaryEntry hash in ht)
            //            {
            //                if (hash.Value.Equals("İstanbul"))
            //                {
            //                    Console.WriteLine(hash.Key);
            //                }
            //            }
            //            break;
            //        case "2":
            //            Console.WriteLine("\nAnkaranın İlçeleri\n---------------------");
            //            foreach (DictionaryEntry hash in ht)
            //            {
            //                if (hash.Value.Equals("Ankara"))
            //                {
            //                    Console.WriteLine(hash.Key);
            //                }
            //            }
            //            break;
            //        case "3":
            //            Console.WriteLine("\nRizenin İlçeleri\n---------------------");
            //            foreach (DictionaryEntry hash in ht)
            //            {
            //                if (hash.Value.Equals("Rize"))
            //                {
            //                    Console.WriteLine(hash.Key);
            //                }
            //            }
            //            break;
            //        case "4":
            //            Console.WriteLine("\nGiresunun İlçeleri\n---------------------");
            //            foreach (DictionaryEntry hash in ht)
            //            {
            //                if (hash.Value.Equals("Giresun"))
            //                {
            //                    Console.WriteLine(hash.Key);
            //                }
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Yanlış giriş Tekrar girin");
            //            goto label;
            //    } 
            #endregion

            #region Hastable özellikleri

            ////Örnek: Key ve value ile ekliyoruz.Keye göre value value ye göre key getirebiliyoruz.
            ////Not: Keyler Unique değerdir.Aynı keyden 2 tane olamaz.

            ////Özellikler:
            //Hashtable ht = new Hashtable();

            //ht.ContainsKey("");
            ////Girilen key değeri var ise True yok ise false döner.

            //ht.ContainsValue("");
            ////Girilen value değeri var ise True yok ise false döner.

            ////SortedList | : Hashtable ile aynı özelliklere sahiptir.
            ////extra olarak Liste içerisindeki tüm değerleri sıralar


            //SortedList sl = new SortedList();

            //sl.Add("Bilal", "B");
            //sl.Add("Can", "C");
            //sl.Add("Ayşe", "A");
            //sl.Add("Baran", "B");
            //sl.Add("Ali", "A");
            //sl.Add("Ceren", "C");

            //foreach (DictionaryEntry list in sl)
            //{
            //    Console.WriteLine(list.Key + " " + list.Value);
            //}

            ////Stack | İlk giren En son çıkar. (LİFO) kapasite = 10(Aşınca 2 katına çıakr)

            ////Push() : Ekleme
            ////Pop()  : Alma(Okuduğu elemanı siler.)
            ////Peek() : En son elemanı gösterir.

            //Stack stk = new Stack();

            //stk.Push(1);
            //stk.Push(2);
            //stk.Push(3);
            //stk.Push(4);
            //stk.Push(5);
            //stk.Push(6);

            //Console.WriteLine("En son eleman = {0}", stk.Peek());

            //int uzun = stk.Count;
            //for (int i = 0; i < uzun; i++)
            //{
            //    Console.WriteLine(stk.Pop());
            //}

            ////Queue-Kuyruk | İlk giren İlk Çıkar(FİFO) kapasite = 32(aşınca 2 katına çıkar)


            //Queue qu = new Queue();

            //qu.Enqueue("Bir");
            //qu.Enqueue("İki");
            //qu.Enqueue("Üç");
            //qu.Enqueue("Dört");
            //qu.Enqueue("Beş");
            //qu.Enqueue("Altı");

            //Console.WriteLine("Baş Eleman = " + qu.Peek());
            //Console.WriteLine("Baş Elemanı yazar ve onu çıkarır = " + qu.Dequeue());
            //Console.WriteLine("Baş Elemanı yazar ve onu çıkarır = " + qu.Dequeue());
            //Console.WriteLine("Baş Elemanı yazar ve onu çıkarır = " + qu.Dequeue()); 
            #endregion

            #region Sinema salonu yapalım. Seçilen koltuk dolu yazsın
            //    ArrayList koltukFilm1 = new ArrayList(20);
            //    ArrayList koltukFilm2 = new ArrayList(10);
            //    BosKoltukBilgisi boslar = new BosKoltukBilgisi();
            //    FilmBilgisi filmBilgisi = new FilmBilgisi();
            //    for (int i = 0; i < 20; i++)
            //    {
            //        koltukFilm1.Add(i + 1);
            //    }
            //    for (int i = 0; i < 10; i++)
            //    {
            //        koltukFilm2.Add(i + 1);
            //    }

            //tekrar:
            //t:
            //t1:
            //    Console.WriteLine("Şuan da vizyonda olan filmler ");
            //    Console.WriteLine("1-Mahşer\n2-Babam ve oğlum");
            //    Console.WriteLine("İzlemek istediğiniz filmi seçiniz : ");

            //    int secim = Convert.ToInt32(Console.ReadLine());

            //    if (secim == 1)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Şuan Boş Olan Koltuklar ");

            //        boslar.BosKoltuk(koltukFilm1);


            //        //Console.ForegroundColor = ConsoleColor.White;

            //        Console.WriteLine("Koltuk Seçiniz ");
            //        int koltuk1 = Convert.ToInt32(Console.ReadLine());

            //        if (koltukFilm1.Contains(koltuk1))
            //        {
            //            Console.Clear();
            //            koltukFilm1.RemoveAt(koltuk1 - 1);
            //            koltukFilm1.Insert(koltuk1 - 1, "dolu");
            //            Console.ForegroundColor = ConsoleColor.DarkCyan;
            //            Console.WriteLine("Yeriniz Ayrılmıştır.");
            //            Console.ForegroundColor = ConsoleColor.Gray;
            //            Console.WriteLine("%%%%%%%%%% Alınan Bilet Bilgisi %%%%%%%%%%");
            //            Console.ForegroundColor = ConsoleColor.DarkCyan;
            //            filmBilgisi.FilmeAitBilgiler("Mahşer", "Salon1", "12:30", koltuk1);
            //            Console.WriteLine("%%%%%%%%%% İyi Seyirler %%%%%%%%%%");
            //            Console.ForegroundColor = ConsoleColor.White;
            //            Console.WriteLine("Koltuk Seçimine Devam Etmek İstiyor musunuz ? (Evet/Hayır)");
            //            string devam = Console.ReadLine().ToUpper();
            //            if (devam == "EVET")
            //            {
            //                Console.Clear();
            //                goto t;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Sistemden Çıkış Sağlandı.");
            //            }
            //        }

            //        else
            //        {
            //            Console.WriteLine("Bu koltuk doludur");
            //            goto t;
            //        }


            //    }
            //    else if (secim == 2)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Şuan Boş Olan Koltuklar ");

            //        boslar.BosKoltuk(koltukFilm2);


            //        //Console.ForegroundColor = ConsoleColor.White;

            //        Console.WriteLine("Koltuk Seçiniz ");
            //        int koltuk2 = Convert.ToInt32(Console.ReadLine());

            //        if (koltukFilm2.Contains(koltuk2))
            //        {
            //            Console.Clear();
            //            koltukFilm2.RemoveAt(koltuk2 - 1);
            //            koltukFilm2.Insert(koltuk2 - 1, "dolu");
            //            Console.ForegroundColor = ConsoleColor.DarkCyan;
            //            Console.WriteLine("Yeriniz Ayrılmıştır.");
            //            Console.ForegroundColor = ConsoleColor.Gray;
            //            Console.WriteLine("%%%%%%%%%% Alınan Bilet Bilgisi %%%%%%%%%%");
            //            Console.ForegroundColor = ConsoleColor.DarkCyan;
            //            filmBilgisi.FilmeAitBilgiler("Babam ve Oğlum", "Salon2", "12:30", koltuk2);
            //            Console.WriteLine("%%%%%%%%%% İyi Seyirler %%%%%%%%%%");
            //            Console.ForegroundColor = ConsoleColor.White;
            //            Console.WriteLine("Koltuk Seçimine Devam Etmek İstiyor musunuz ? (Evet/Hayır)");
            //            string devam1 = Console.ReadLine().ToUpper();
            //            if (devam1 == "EVET")
            //            {
            //                Console.Clear();
            //                goto t1;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Sistemden Çıkış Sağlandı.");
            //            }
            //        }

            //        else
            //        {
            //            Console.WriteLine("Bu koltuk doludur");
            //            goto t1;
            //        }


            //    }
            //    else
            //    {
            //        Console.WriteLine("Böyle Bir Seçenek Mevcut Değildir!!!");
            //        goto tekrar;
            //    }
            #endregion

            #region Sinema salonunda istenen koltuğa kişinin ismini yazdıralım
            //    int koltuk = 0;
            //    string isim = "";
            //    ArrayList aksiyon = new ArrayList(15);
            //    ArrayList korku = new ArrayList(10);
            //    for (int i = 0; i < 15; i++)
            //    {
            //        aksiyon.Add(i + 1);
            //    }
            //    for (int i = 0; i < 10; i++)
            //    {
            //        korku.Add(i + 1);
            //    }
            //    int sayac = 0;
            //    int sayac2 = 0;
            //label:
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine("\n**** Sinema Salonuna Hoş Geldiniz ****\n");
            //    Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //    Console.WriteLine("-----AKSİYON SALONU BOŞ KOLTUKLAR-----");

            //    foreach (var item in aksiyon)
            //    {
            //        Console.ForegroundColor = ConsoleColor.DarkGreen;
            //        if (item.ToString() != "1" && item.ToString() != "2" && item.ToString() != "3" &&
            //            item.ToString() != "4" && item.ToString() != "5" && item.ToString() != "6" &&
            //            item.ToString() != "7" && item.ToString() != "8" && item.ToString() != "9" &&
            //            item.ToString() != "10" && item.ToString() != "11" && item.ToString() != "12"
            //            && item.ToString() != "13" && item.ToString() != "14" && item.ToString() != "15")
            //        {
            //            Console.ForegroundColor = ConsoleColor.DarkRed;
            //        }
            //        Console.Write(item + "\t");
            //        if (sayac == 4)
            //        {
            //            Console.Write("   \n");
            //            sayac = -1;
            //        }

            //        sayac++;
            //    }
            //    Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //    Console.WriteLine("--------------------------------------\n\n");
            //    Console.WriteLine("-----KORKU SALONU BOŞ KOLTUKLAR-------");
            //    foreach (var item in korku)
            //    {
            //        Console.ForegroundColor = ConsoleColor.DarkGreen;
            //        if (item.ToString() != "1" && item.ToString() != "2" && item.ToString() != "3" &&
            //            item.ToString() != "4" && item.ToString() != "5" && item.ToString() != "6" &&
            //            item.ToString() != "7" && item.ToString() != "8" && item.ToString() != "9" &&
            //            item.ToString() != "10")
            //        {
            //            Console.ForegroundColor = ConsoleColor.DarkRed;
            //        }
            //        Console.Write(item + "\t");
            //        if (sayac == 4)
            //        {
            //            Console.WriteLine();
            //            sayac = -1;
            //        }
            //        sayac++;
            //    }
            //    Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //    Console.WriteLine("--------------------------------------\n");
            //    Console.ForegroundColor = ConsoleColor.DarkBlue;
            //    Console.Write("Hangi Salon \nAksiyon : 1\nKorku   : 2 : ");
            //    switch (Console.ReadLine())
            //    {
            //        case "1":
            //            //Aksiyon
            //            Console.ForegroundColor = ConsoleColor.White;
            //        label2:
            //            Console.Write("Hangi Koltuğa Oturmak İstiyorsunuz : ");
            //            try
            //            {
            //                koltuk = Convert.ToInt32(Console.ReadLine());
            //            }
            //            catch
            //            {
            //                Console.WriteLine("Hatalı giriş");
            //                goto label2;
            //            }
            //            if (koltuk != 1 && koltuk != 2 && koltuk != 3 && koltuk != 4 && koltuk != 5 &&
            //                koltuk != 6 && koltuk != 7 && koltuk != 8 && koltuk != 9 && koltuk != 10 &&
            //                koltuk != 11 && koltuk != 12 && koltuk != 13 && koltuk != 14 && koltuk != 15)
            //            {
            //                Console.Clear();
            //                Console.WriteLine("Böyle bir Koltuk Yok");
            //                goto label;
            //            }
            //            else
            //            {
            //                if (aksiyon.Contains(koltuk))
            //                {
            //                label5:
            //                    Console.Write("İsminiz Nedir(En Fazla 7 Karakter Rakam İçeremez) ? : ");
            //                    isim = Console.ReadLine();
            //                    if (isim.Length <= 7 && isim.Length > 0)
            //                    {
            //                        for (int i = 0; i < isim.Length; i++)
            //                        {
            //                            if (isim[i] == '1' || isim[i] == '2' || isim[i] == '3' || isim[i] == '4' || isim[i] == '5' ||
            //                                isim[i] == '6' || isim[i] == '7' || isim[i] == '8' || isim[i] == '9')
            //                            {
            //                                sayac2++;
            //                            }
            //                        }
            //                        if (sayac2 == 0)
            //                        {
            //                            Console.Write("Rezervasyon Yapılıyor");
            //                            for (int i = 0; i < 5; i++)
            //                            {
            //                                Console.Write(".");
            //                                System.Threading.Thread.Sleep(1000);
            //                            }
            //                            aksiyon.RemoveAt(koltuk - 1);
            //                            aksiyon.Insert(koltuk - 1, isim);
            //                            Console.Clear();
            //                            Console.WriteLine("Rezervasyon Yapıldı !!!");
            //                            goto label;
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("İsim İçerisinde Rakam Bulunamaz ve İsim 7 Karakterden Fazla olamaz");
            //                            goto label5;
            //                        }
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("İsim İçerisinde Rakam Bulunamaz ve İsim 7 Karakterden Fazla olamaz");
            //                        goto label5;
            //                    }
            //                }
            //                else
            //                {
            //                    Console.Clear();
            //                    Console.WriteLine("Bu koltuk Dolu !!");
            //                    goto label;
            //                }

            //            }

            //        case "2":
            //            //Korku
            //            Console.ForegroundColor = ConsoleColor.White;
            //        label3:
            //            Console.Write("Hangi Koltuğa Oturmak İstiyorsunuz : ");
            //            try
            //            {
            //                koltuk = Convert.ToInt32(Console.ReadLine());
            //            }
            //            catch
            //            {
            //                Console.WriteLine("Hatalı giriş");
            //                goto label3;
            //            }
            //            if (koltuk != 1 && koltuk != 2 && koltuk != 3 && koltuk != 4 && koltuk != 5 &&
            //        koltuk != 6 && koltuk != 7 && koltuk != 8 && koltuk != 9 && koltuk != 10)
            //            {
            //                Console.Clear();
            //                Console.WriteLine("Böyle bir Koltuk Yok");
            //                goto label;
            //            }
            //            else
            //            {
            //                if (korku.Contains(koltuk))
            //                {
            //                label4:
            //                    Console.Write("İsminiz Nedir(En Fazla 7 Karakter Rakam İçeremez) ? : ");
            //                    isim = Console.ReadLine();
            //                    if (isim.Length <= 7 && isim.Length > 0)
            //                    {
            //                        for (int i = 0; i < isim.Length; i++)
            //                        {
            //                            if (isim[i] == '1' || isim[i] == '2' || isim[i] == '3' || isim[i] == '4' || isim[i] == '5' ||
            //                                isim[i] == '6' || isim[i] == '7' || isim[i] == '8' || isim[i] == '9')
            //                            {
            //                                sayac2++;
            //                            }
            //                        }
            //                        if (sayac2 == 0)
            //                        {
            //                            Console.Write("Rezervasyon Yapılıyor");
            //                            for (int i = 0; i < 5; i++)
            //                            {
            //                                Console.Write(".");
            //                                System.Threading.Thread.Sleep(1000);
            //                            }
            //                            korku.RemoveAt(koltuk - 1);
            //                            korku.Insert(koltuk - 1, isim);
            //                            Console.Clear();
            //                            Console.WriteLine("Rezervasyon Yapıldı !!!");
            //                            goto label;
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("İsim İçerisinde Rakam Bulunamaz ve İsim 7 Karakterden Fazla olamaz");
            //                            goto label4;
            //                        }
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("İsim İçerisinde Rakam Bulunamaz ve İsim 7 Karakterden Fazla olamaz");
            //                        goto label4;
            //                    }
            //                }
            //                else
            //                {
            //                    Console.Clear();
            //                    Console.WriteLine("Bu koltuk Dolu !!");
            //                    goto label;
            //                }

            //            }

            //        default:
            //            Console.Clear();
            //            Console.WriteLine("Yanlış Giriş");
            //            goto label;
            //    } 
            #endregion








        }

    }

    #region Enum'ı öğrenelim
    //class Ogrenci
    //{
    //    public string Adi { get; set; }
    //    public string Soyadi { get; set; }
    //    public Alan Alani { get; set; }
    //}
    //public enum Alan
    //{
    //    Sayisal,
    //    Sozel,
    //    EsitAgirlik,
    //    Dil
    //}
    #endregion

    #region Enum ile günleri yazalım
    //enum Gunler
    //{
    //    Pazartesi, Sali, Carsamba, Persembe, Cuma, Cumartesi, Pazar
    //} 
    #endregion

    #region Boş koltuk bilgisi ve Film bilgisi için classları ekleyelim
    //class BosKoltukBilgisi
    //{
    //    public void BosKoltuk(ArrayList koltuk)
    //    {
    //        int sayac = 0;
    //        foreach (var item in koltuk)
    //        {
    //            Console.ForegroundColor = ConsoleColor.DarkGreen;
    //            if (item.ToString() != "1" && item.ToString() != "2" && item.ToString() != "3" &&
    //                item.ToString() != "4" && item.ToString() != "5" && item.ToString() != "6" &&
    //                item.ToString() != "7" && item.ToString() != "8" && item.ToString() != "9" &&
    //                item.ToString() != "10" && item.ToString() != "11" && item.ToString() != "12"
    //                && item.ToString() != "13" && item.ToString() != "14" && item.ToString() != "15"
    //                && item.ToString() != "16" && item.ToString() != "17" && item.ToString() != "18"
    //                && item.ToString() != "19" && item.ToString() != "20")
    //            {
    //                Console.ForegroundColor = ConsoleColor.DarkRed;
    //            }
    //            Console.Write("\t" + item);
    //            sayac++;
    //            if (sayac == 5)
    //            {
    //                Console.WriteLine();
    //                sayac = 0;
    //            }

    //        }
    //        Console.WriteLine();
    //        Console.ForegroundColor = ConsoleColor.White;
    //    }
    //}
    //class FilmBilgisi
    //{
    //    private string filmAdi;

    //    public string FilmAdi
    //    {
    //        get { return filmAdi; }
    //        set { filmAdi = value; }
    //    }
    //    private string salonAdi;

    //    public string SalonAdi
    //    {
    //        get { return salonAdi; }
    //        set { salonAdi = value; }
    //    }
    //    public string saati;
    //    public string Saati
    //    {
    //        get { return saati; }
    //        set { saati = value; }
    //    }
    //    private int koltuk;

    //    public int Koltuk
    //    {
    //        get { return koltuk; }
    //        set { koltuk = value; }
    //    }
    //    public void FilmeAitBilgiler(string film, string salon, string saat, int numara)
    //    {
    //        this.FilmAdi = film;
    //        this.SalonAdi = salon;
    //        this.Saati = saat;
    //        this.Koltuk = numara;
    //        Console.WriteLine("Filmin Adı : " + FilmAdi + "\nSalon Adı : " + SalonAdi + "\nSaati : " + Saati + "\nKoltuk Numarası : " + koltuk);
    //    }
    //} 
    #endregion





}
