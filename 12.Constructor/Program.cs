using System;

namespace _12.Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor metodu yapıcı bloktur. Nesnenin ramde oluşmasını sağlar. Tanımlanmazsa varsayılan (default olan) constructor çalışır.
            //Bir sınıfı oluştururken kolaylık sağladığı için kullanılır. new() lerken doğrudan parantez içerisne değerleri gönderebiliriz.
            //Constructor metotların overloadı vardır.
            //Constructor metotların geriye dönüşü yoktur. Geriye dönüşü olmayan tek metottur.
            //Kendimiz constructor tanımlarsak varsayılan iptal olur.

            #region Constructor mantığına bakalım
            //Personel p;
            //p = new Personel();

            //Personel p2 = new Personel();
            //Personel p3 = new Personel("Mehtap");

            //Personel o1 = new Personel();  //4 kere Bu sınıfı benim sayemde oluşturdun diyecek 
            #endregion

            #region Constructor deneyelim
            //Deneme deneme = new Deneme(); 
            #endregion

            #region Kişinin bilgilerini girelim
            //Console.Write("Adınızı giriniz: ");
            //string ad = Console.ReadLine();
            //Console.Write("Soyadınızı giriniz: ");
            //string soyad = Console.ReadLine();
            //Console.Write("Doğum yılınızı giriniz: ");
            //string dogumYili = Console.ReadLine();
            //Console.Write("Doğum yerinizi giriniz: ");
            //string dogumYeri = Console.ReadLine();
            //Console.Write("Mesleğinizi giriniz: ");
            //string meslek = Console.ReadLine();

            //Kisi kisi = new Kisi(ad, soyad, dogumYili, dogumYeri, meslek); 
            #endregion

            #region Programcıyı oluşturalım
            //Programci programci = new Programci(); //parametresiz
            //programci.showOzellikler();

            //Console.WriteLine("------------------------------------------");

            //Programci programci2 = new Programci("Aylin", 26); //2 parametreli
            //programci2.showOzellikler();

            //Console.WriteLine("------------------------------------------");

            //Programci programci3 = new Programci("Fatoş", "Anlı", 47, "C#"); //4 parametreli
            //programci3.showOzellikler();

            //Console.WriteLine("------------------------------------------");

            //Programci programci4 = new Programci //hangilerini bilip bilmediğimizi bilmeden doldurmak istedğimizde buna Object Initializer denir.
            //{
            //    Yasi = 58,
            //    KullandıgıProgram = "Pyhton"

            //};
            //programci4.showOzellikler();
            #endregion

            //Yıkıcı Metot: Sınıfta herhangi bir şey kalmadığında çalışır. ~ işareti ile sınıfımızın adıyla herhangi bir erişim belirleyici ve tür tanımlamasına gerek kalmadan tanımlanır

            #region Unvan kontrolü yapalım
            //Kisi kisi1 = new Kisi("Hasan", "Yılmaz", "Profesör");
            //kisi1.UnvanKontrol();

            //Kisi kisi2 = new Kisi("Mesut", "Saat", "Doçent");
            //kisi2.UnvanKontrol();
            #endregion

            #region Eşya örneği yapalım
            //Telefon telefon = new Telefon(); 
            #endregion


        }
    }

    #region Constructor mantığına bakalım
    //class Personel
    //{
    //    public Personel() 
    //    {
    //        Console.WriteLine("Bu sınıfı benim sayemde oluşturdun");
    //    }
    //    public Personel(string ad)
    //    {
    //        Console.WriteLine(ad);
    //    }
    //    public Personel(string _ad, string _soyad) //imzalar farklı olduğu için oluşturmama izin veriyor
    //    {
    //        Ad = _ad;
    //        Soyad = _soyad;

    //    }

    //    public string Ad { get; set; }
    //    public string Soyad { get; set; }
    //} 
    #endregion

    #region Constructor deneyelim
    //class Deneme
    //{
    //    public Deneme()
    //    {
    //        Console.WriteLine("Kisi classı newlendiğinde ekranda bu cümle yazacak.");
    //    }

    //} 
    #endregion

    #region Kişi classında ad, soyad, doğum yılı, doğum yeri, meslek olsun. Bunların değerlerini kullanıcıdan isteyelim. Constructor da tanımlayalım
    //class Kisi
    //{
    //    public Kisi(string _ad, string _soyad, string _dogumYili, string _dogumYeri, string _meslek)
    //    {
    //        Console.WriteLine("Ad: " + _ad);
    //        Console.WriteLine("Soyad: " + _soyad);
    //        Console.WriteLine("Doğum Yeri: " + _dogumYeri);
    //        Console.WriteLine("Doğum Yılı: " + _dogumYili);
    //        Console.WriteLine("Meslek: " + _meslek);

    //        Ad = _ad;
    //        Soyad = _soyad;
    //        DogumYeri = _dogumYeri;
    //        DogumYili = _dogumYili;
    //        Meslek = _meslek;
    //    }

    //    public string Ad { get; set; }
    //    public string Soyad { get; set; }
    //    public string DogumYili { get; set; }
    //    public string DogumYeri { get; set; }
    //    public string Meslek { get; set; }
    //}
    #endregion

    #region Programcı constructoru yapalım. Paramatresiz, 2 parametreli ve 4 parametreli olsun
    //class Programci
    //{
    //    public string Adi { get; set; }
    //    public string Soyadi { get; set; }
    //    public int Yasi { get; set; }
    //    public string KullandıgıProgram { get; set; }

    //    public Programci() //parametresiz
    //    {
    //        this.Adi = null;
    //        this.Soyadi = null;
    //        this.Yasi = 0;
    //        this.KullandıgıProgram = null;
    //    }

    //    public Programci(string _adi, int _yasi) //2 parametreli
    //    {
    //        this.Adi = _adi;
    //        this.Yasi = _yasi;
    //        this.Soyadi = null;
    //        this.KullandıgıProgram = null;
    //    }

    //    public Programci(string _adi, string _soyadi, int _yasi, string _kullandıgıProgram) //4 parametreli
    //    {
    //        this.Adi = _adi;
    //        this.Yasi = _yasi;
    //        this.Soyadi = _soyadi;
    //        this.KullandıgıProgram = _kullandıgıProgram;
    //    }

    //    public void showOzellikler()
    //    {
    //        if (this.Adi != null)
    //        {
    //            Console.WriteLine("Adı: " + this.Adi);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Adı bilgisi mevcut değil");
    //        }

    //        if (this.Soyadi != null)
    //        {
    //            Console.WriteLine("Soyadı: " + this.Soyadi);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Soyadı bilgisi mevcut değil");
    //        }

    //        if (this.Yasi != 0)
    //        {
    //            Console.WriteLine("Yaşı: " + this.Yasi);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Yaşı bilgisi mevcut değil");
    //        }

    //        if (this.KullandıgıProgram != null)
    //        {
    //            Console.WriteLine("Kullandığı program: " + this.KullandıgıProgram);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Kullandığı program bilgisi mevcut değil");
    //        }

    //    }
    //}
    #endregion

    #region Kişi classı oluşturalım, içerisinde UnvanKontrol metodu olsun. Kişinin unvanı profesör ise kaydı yapılsın, değilse yapılmasın
    //class Kisi
    //{
    //    public string Ad { get; set; }
    //    public string Soyad { get; set; }
    //    public string Unvan { get; set; }
    //    public void UnvanKontrol()
    //    {
    //        if (Unvan == "Profesör")
    //        {
    //            Console.WriteLine("Kaydınız yapıldı. Adınız: " + Ad);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Ünvanınız profesör olmadığı için kaydınız yapılamıyor.");
    //        }
    //    }

    //    public Kisi(string _ad, string _soyad, string _unvan)
    //    {
    //        this.Ad = _ad;
    //        this.Soyad = _soyad;
    //        this.Unvan = _unvan;
    //    }
    //}
    #endregion

    #region Constructor, Miras aldığı sınıf içinde nesne üretebilir. Eşya örneği yapalım
    //class Esya
    //{
    //    public string Adi { get; set; }
    //    public string Malzeme { get; set; }
    //    public Esya()
    //    {
    //        Console.WriteLine("Eşya sınıfı çalıştı");
    //    }
    //}

    //class ElektronikEsya : Esya
    //{
    //    public int GucKaynagi { get; set; }
    //    public ElektronikEsya()
    //    {
    //        Console.WriteLine("Elektronik eşya sınıfı çalıştı");
    //    }
    //}

    //class Telefon : ElektronikEsya
    //{
    //    public byte SarjSuresi { get; set; }
    //    public Telefon()
    //    {
    //        Console.WriteLine("Telefon sınıfı çalıştı");
    //    }
    //} 
    #endregion









}

