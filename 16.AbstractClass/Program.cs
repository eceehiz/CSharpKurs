using System;

namespace _16.AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstract sınıflar sadece miras almak için tasarlanan sınıflardır
            //abstract sınıfın içindeki metotların abstract olması gerekmez, ama mantıken olmalıdır. (yani abstract sınıflarda, abstract metot yada property haricinde abstract olmayan metot, property olabilir)
            //abstract metodların gövdesi olmaz 
            //abstract classlar newlenemez

            #region Müzik aletleri
            //Keman keman = new Keman();
            //keman.Cal();
            //keman.Sarki(); 
            #endregion

            #region Hayvan sesleri
            //Kopek kopek = new Kopek();
            //kopek.SesVer();
            //kopek.AyakSayisi = 4;
            //Console.WriteLine("Köpeğin ayak sayısı: " + kopek.AyakSayisi);

            //Kedi kedi = new Kedi();
            //kedi.SesVer();
            //Kus kus = new Kus();

            //kus.SesVer();
            #endregion

            #region Ayakkabı çeşitleri
            //    Kosu Run = new Kosu();
            //    Futbol Foot = new Futbol();
            //    Bot Bot = new Bot();
            //    Sandalet Terlik = new Sandalet();
            //bidaha:
            //    Console.Clear();
            //    Console.WriteLine("**********Hoşgeldiniz**********\n\n\tAyakkabı Türü Seçiniz\n\t1-Bot\n\t2-Koşu\n\t3-Futbol\n\t4-Sandalet");
            //    byte Secim = byte.Parse(Console.ReadLine());
            //    if (Secim < 1 || Secim > 4)
            //    {
            //        Console.WriteLine("Geçersiz Bir Seçim\nProgram Tekrar Başlatılıyor.");
            //        System.Threading.Thread.Sleep(2000);
            //        goto bidaha;
            //    }
            //    Console.WriteLine("Ayakkabı Rengini Giriniz(Mavi,Yeşil,Siyah...)");
            //    string Renk = Console.ReadLine();
            //    Console.WriteLine("Bağcık var mı? (true/false)");
            //    Boolean Bagcik = Boolean.Parse(Console.ReadLine());
            //tekrar:
            //    Console.WriteLine("Ayakkabı Numarası Seçiniz(1/47)");
            //    byte Numara = byte.Parse(Console.ReadLine());
            //    switch (Secim)
            //    {
            //        case 1:
            //            Bot.AyakkabiTuru = "Bot";
            //            Bot.AyakkabiNum = Numara;
            //            Bot.AyakkabiRenk = Renk;
            //            Bot.Bagcik = Bagcik;
            //            if (Numara < 30 && Numara > 18)
            //            {
            //                Bot.Fiyat = 79;
            //            }
            //            else if (Numara >= 30 && Numara < 40)
            //            {
            //                Bot.Fiyat = 89;
            //            }
            //            else if (Numara >= 40 && Numara <= 47)
            //            {
            //                Bot.Fiyat = 109;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Geçersiz bir numara");
            //                goto tekrar;
            //            }
            //            Bot.Ozellikler();
            //            break;

            //        case 2:
            //            Run.AyakkabiTuru = "Koşu Ayakkabısı";
            //            Run.AyakkabiNum = Numara;
            //            Run.AyakkabiRenk = Renk;
            //            Run.Bagcik = Bagcik;
            //            if (Numara < 30 && Numara > 0)
            //            {
            //                Run.Fiyat = 129;
            //            }
            //            else if (Numara >= 30 && Numara < 40)
            //            {
            //                Run.Fiyat = 139;
            //            }
            //            else if (Numara >= 40 && Numara <= 47)
            //            {
            //                Run.Fiyat = 159;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Geçersiz bir numara");
            //                goto tekrar;
            //            }
            //            Run.Ozellikler();
            //            break;

            //        case 3:
            //            Foot.AyakkabiTuru = "Futbol Ayakkabısı";
            //            Foot.AyakkabiNum = Numara;
            //            Foot.AyakkabiRenk = Renk;
            //            Foot.Bagcik = Bagcik;
            //            if (Numara < 30 && Numara > 0)
            //            {
            //                Foot.Fiyat = 170;
            //            }
            //            else if (Numara >= 30 && Numara < 40)
            //            {
            //                Foot.Fiyat = 185;
            //            }
            //            else if (Numara >= 40 && Numara <= 47)
            //            {
            //                Foot.Fiyat = 199;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Geçersiz bir numara");
            //                goto tekrar;
            //            }
            //            Foot.Ozellikler();
            //            break;

            //        case 4:
            //            Terlik.AyakkabiTuru = "Sandalet";
            //            Terlik.AyakkabiNum = Numara;
            //            Terlik.AyakkabiRenk = Renk;
            //            Terlik.Bagcik = Bagcik;
            //            if (Numara < 30 && Numara > 0)
            //            {
            //                Terlik.Fiyat = 29;
            //            }
            //            else if (Numara >= 30 && Numara < 40)
            //            {
            //                Terlik.Fiyat = 39;
            //            }
            //            else if (Numara >= 40 && Numara <= 47)
            //            {
            //                Terlik.Fiyat = 49;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Geçersiz bir numara");
            //                goto tekrar;
            //            }
            //            Terlik.Ozellikler();
            //            break;

            //        default:
            //            break;
            //    }




            #endregion

            #region Çalışan çeşitleri
            //Console.Write("Müdür 1, memur 2, sekreter 3: ");
            //int secim = Convert.ToInt32(Console.ReadLine());

            //if (secim==1)
            //{
            //    Mudur mudur = new Mudur();
            //    mudur.MaasHesapla();

            //}
            //else if (secim==2)
            //{
            //    Memur memur = new Memur();
            //    memur.MaasHesapla();
            //}
            //else if (secim == 3)
            //{
            //    Sekreter sekreter = new Sekreter();
            //    sekreter.MaasHesapla();
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış tuşlama");
            //} 
            #endregion

            #region Hayvan çeşitleri
            //Etcil aslan = new Etcil();
            //aslan.Adi = "Aslan";
            //aslan.BeslenmeSekli = "Etçil";
            //aslan.Turu = "Memeli";
            //aslan.AyakSayisi = 4;
            //aslan.HayatSuresi = 10;
            //aslan.Info();
            //Otcul zebra = new Otcul();
            //zebra.Adi = "Zebra";
            //zebra.BeslenmeSekli = "Otcul";
            //zebra.Info(); 
            #endregion

       



        }
    }

    #region Abstract classta müzik aletleri yapalım
    //abstract class MuzikAletleri
    //{
    //    public abstract void Cal(); //bu metot kesin dolsun istiyorum
    //    public abstract void Sarki();  //bu metot kesin dolsun istiyorum

    //}
    //class Gitar : MuzikAletleri
    //{
    //    public override void Cal()
    //    {
    //        Console.WriteLine("dın dın dın");
    //    }

    //    public override void Sarki()
    //    {
    //        Console.WriteLine("despaado");
    //    }
    //}
    //class Keman : MuzikAletleri
    //{
    //    public override void Cal()
    //    {
    //        Console.WriteLine("gıy gıy gıy");
    //    }

    //    public override void Sarki()
    //    {
    //        Console.WriteLine("hungarian");
    //    }
    //}
    //class Flut : MuzikAletleri
    //{
    //    public override void Cal()
    //    {
    //        Console.WriteLine("düt düt düt");
    //    }

    //    public override void Sarki()
    //    {
    //        Console.WriteLine("bak postacı");
    //    }
    //} 
    #endregion

    #region Abstact classta hayvanları yapalım
    //abstract class Hayvan
    //{
    //    public abstract void SesVer();
    //    public abstract int AyakSayisi { get; set; }

    //}
    //class Kopek : Hayvan
    //{
    //    public override int AyakSayisi { get; set; }

    //    public override void SesVer()
    //    {
    //        Console.WriteLine("hav hav");
    //    }
    //}
    //class Kedi : Hayvan
    //{
    //    public override int AyakSayisi { get; set; }

    //    public override void SesVer()
    //    {
    //        Console.WriteLine("miyav miyav");
    //    }
    //}
    //class Kus : Hayvan
    //{
    //    public override int AyakSayisi { get; set; }

    //    public override void SesVer()
    //    {
    //        Console.WriteLine("cik cik");
    //    }
    //}
    #endregion

    #region Abstract classta ayakkabı çeşitleri yapalım
    //abstract class AyakkabiFabrikasi
    //{
    //    public int AyakkabiNum { get; set; }
    //    public string AyakkabiRenk { get; set; }
    //    public int Fiyat { get; set; }
    //    public Boolean Bagcik { get; set; }
    //    public string AyakkabiTuru { get; set; }
    //    abstract public void Ozellikler();

    //}
    //class Bot : AyakkabiFabrikasi
    //{
    //    public override void Ozellikler()
    //    {
    //        string bagcik = (Bagcik == true) ? "var" : "yok";
    //        Console.Write("Ayakkabı türü: {0}\nAyakkabi Numarası: {1}\nAyakkabı Rengi: {2}\nAyakkabının Fiyatı: {3}TL\nBağcık: {4}", AyakkabiTuru, AyakkabiNum, AyakkabiRenk, Fiyat, bagcik);
    //    }

    //}
    //class Sandalet : AyakkabiFabrikasi
    //{
    //    public override void Ozellikler()
    //    {
    //        string bagcik = (Bagcik == true) ? "var" : "yok";
    //        Console.Write("Ayakkabı türü: {0}\nSandalet Numarası: {1}\nSandalet Rengi: {2}\nSandalet Fiyatı: {3}TL\nBağcık: {4} \n", AyakkabiTuru, AyakkabiNum, AyakkabiRenk, Fiyat, bagcik);
    //    }
    //}
    //class SporAyakkabi : AyakkabiFabrikasi
    //{
    //    public override void Ozellikler()
    //    {
    //    }
    //}
    //class Kosu : SporAyakkabi
    //{
    //    public override void Ozellikler()
    //    {
    //        string bagcik = (Bagcik == true) ? "var" : "yok";
    //        Console.Write("Ayakkabı türü: {0}\nAyakkabi Numarası: {1}\nAyakkabı Rengi: {2}\nAyakkabının Fiyatı: {3}TL\n Bağcık: {4}", AyakkabiTuru, AyakkabiNum, AyakkabiRenk, Fiyat, bagcik);
    //    }
    //}
    //class Futbol : SporAyakkabi
    //{
    //    public override void Ozellikler()
    //    {
    //        string bagcik = (Bagcik == true) ? "var" : "yok";
    //        Console.Write("Ayakkabı türü: {0}\nAyakkabi Numarası: {1}\nAyakkabı Rengi: {2}\nAyakkabının Fiyatı: {3}TL\n Bağcık: {4}", AyakkabiTuru, AyakkabiNum, AyakkabiRenk, Fiyat, bagcik);
    //    }
    //} 
    #endregion

    #region Abstract classta maaş hesaplayalım
    //abstract class Kisi
    //{
    //    abstract public void MaasHesapla();
    //}

    //class Mudur : Kisi
    //{
    //    public override void MaasHesapla()
    //    {
    //        Console.Write("Maaşınızı giriniz: ");
    //        double maas = Convert.ToInt32(Console.ReadLine());
    //        double mesai = maas / 30;
    //        Console.Write("Kaç gün mesaiye kaldığınızı giriniz: ");
    //        double gun = Convert.ToInt32(Console.ReadLine());
    //        double toplamMaas = maas + mesai * 2 * gun;
    //        Console.WriteLine("Maaşınız: " + toplamMaas + " TL");
    //    }
    //}
    //class Memur : Kisi
    //{
    //    public override void MaasHesapla()
    //    {
    //        Console.Write("Maaşınızı giriniz: ");
    //        double maas = Convert.ToInt32(Console.ReadLine());
    //        double mesai = maas / 30;
    //        Console.Write("Kaç gün mesaiye kaldığınızı giriniz: ");
    //        double gun = Convert.ToInt32(Console.ReadLine());
    //        double toplamMaas = maas + mesai * 1.5 * gun;
    //        Console.WriteLine("Maaşınız: " + toplamMaas + " TL");
    //    }
    //}
    //class Sekreter : Kisi
    //{
    //    public override void MaasHesapla()
    //    {
    //        Console.Write("Maaşınızı giriniz: ");
    //        double maas = Convert.ToInt32(Console.ReadLine());
    //        double mesai = maas / 30;
    //        Console.Write("Kaç gün mesaiye kaldığınızı giriniz: ");
    //        double gun = Convert.ToInt32(Console.ReadLine());
    //        double toplamMaas = maas + mesai * gun;
    //        Console.WriteLine("Maaşınız: " + toplamMaas + " TL");
    //    }
    //} 
    #endregion

    #region Abstract classta hayvan oluşturalım. Etçil otçul olarak alt sınıflar yapalım
    //public abstract class Hayvan
    //{
    //    public abstract string Adi { get; set; }
    //    public abstract string BeslenmeSekli { get; set; }
    //    public short HayatSuresi { get; set; }
    //    public string Turu { get; set; }
    //    public short AyakSayisi { get; set; }
    //    public abstract void Info();


    //}
    //class Etcil : Hayvan
    //{
    //    public override string Adi { get; set; }
    //    public override string BeslenmeSekli { get; set; }

    //    public override void Info()
    //    {
    //        Console.WriteLine($"{this.Adi} {this.BeslenmeSekli} bir hayvandır");
    //        if (this.Turu != null)
    //            Console.WriteLine("Türü: " + Turu);
    //        if (this.AyakSayisi > -1)
    //            Console.WriteLine("Ayak Sayısı: " + AyakSayisi);
    //        if (this.HayatSuresi > -1)
    //            Console.WriteLine("Hayat Suresi: " + HayatSuresi + " yıl");
    //    }
    //    public Etcil()
    //    {
    //        AyakSayisi = -1;
    //        HayatSuresi = -1;
    //    }


    //}
    //class Otcul : Hayvan
    //{
    //    public override string Adi { get; set; }
    //    public override string BeslenmeSekli { get; set; }

    //    public override void Info()
    //    {
    //        Console.WriteLine($"{this.Adi} {this.BeslenmeSekli} bir hayvandır");
    //        if (this.Turu != null)
    //            Console.WriteLine("Türü: " + Turu);
    //        if (this.AyakSayisi > -1)
    //            Console.WriteLine("Ayak Sayısı: " + AyakSayisi);
    //        if (this.HayatSuresi > -1)
    //            Console.WriteLine("Hayat Suresi: " + HayatSuresi + " yıl");
    //    }
    //    public Otcul()
    //    {
    //        AyakSayisi = -1;
    //        HayatSuresi = -1;
    //    }


    //} 
    #endregion

   





}
