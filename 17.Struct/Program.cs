using _18.Interfaceler;
using System;

namespace _17.Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Struct, classın bir küçüğüdür. Ramda daha az yer kaplar.
            //Miras aldırmayacağın, küçük bilgiler tutman gereken yerlerde class yerine struct kullanabilirsin.

            Ders ders1 = new Ders();
            ders1.Adi = "Matematik";
            ders1.Saat = 7;

            Ders ders2 = new Ders();
            ders2.Adi = "Kimya";
            ders2.Saat = 5;

            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Dersi = ders1;

            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.Dersi = ders2;

            Console.WriteLine(ogrenci2.Dersi.Adi);

            Ogrenci ogrenci3 = new Ogrenci();

            int result = Ogrenci.OgrenciSayisi;
            Console.WriteLine("Öğrenci sayısı: " + result);

            
            Silah
        }
    }

    #region Struct kullanalım. Static kullanalım, öğrenci sayısını bulalım
    class Ogrenci
    {
        public Ogrenci()
        {
            OgrenciSayisi++;
        }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int OkulNo { get; set; }
        public int Sinif { get; set; }
        public Ders Dersi { get; set; }
        public Ogretmen Ogretmeni { get; set; }
        public static int OgrenciSayisi { get; set; } //Static: sınıftan instance almadan sınıfın sonuna . koyarak static elemana ulaşmamızı sağlar.
        public static void Ekle() //metoduda da static yapabiliriz
        {
            //static metotların içerisinde static olan propertylere erişilebilir. Yani burada OgrenciSayisina ulaşabiliriz ama OkulNoya ulaşamayız.

            Console.WriteLine("Ekleme işlemi tamamlandı");
        }

    }
    struct Ders
    {
        public string Adi { get; set; }
        public int Kredi { get; set; }
        public string Kitap { get; set; }
        public int Saat { get; set; }
    }
    struct Ogretmen
    {
        public string Bransi { get; set; }
        public int Maas { get; set; }
    } 
    #endregion

    static class Mudur //müdürü newlemeden içerisindeki propertylere doğrudan ulaşabiliriz. Static classta static olmayan eleman bulunamaz
    {

    }









}
