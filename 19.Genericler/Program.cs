using System;
using System.Collections;
using System.Collections.Generic;

namespace _19.Genericler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic: Dışarıdan bir tip alarak çalışmayı sağlayan yapı

            #region Generice bakalım
            //Musteri mst = new Musteri();
            //mst.Ad = "Mesut";

            //ArrayList array = new ArrayList();
            //array.Add("Hayat");
            //array.Add(1);
            //array.Add(2222);
            //array.Add(true);
            //array.Add('g');
            //array.Add(mst);
            //Console.WriteLine(array[0]);
            //Console.WriteLine(array[3]);

            //int e = (int)array[2];

            //string t = array[1].ToString();

            //List<string> list = new List<string>();
            //list.Add("jale");
            //list.Add(t);

            //List<int> sayi = new List<int>();
            //sayi.Add(e);
            //sayi.Add(5);

            //List<Musteri> musteriler = new List<Musteri>();

            //musteriler.Add(mst);

            //string aa = array[1].ToString();
            //int da = (int)array[2];
            //Console.WriteLine(da);
            //string sm = (string)array[0]; 
            #endregion

            #region Kişiler listine değerler gönderelim. Hem for hem foreach ile ekrana yazdıralım
            //List<Kisi> kisiler = new List<Kisi>()
            //{
            //    new Kisi()
            //    {
            //    Ad = "Feyza",
            //    Soyad = "Bayrak",
            //    Adres = "Maltepe",
            //    TelNo = "538 984 45 65"
            //    },

            //    new Kisi()
            //    {
            //    Ad = "Mehmet",
            //    Soyad = "Bal",
            //    Adres = "Üsküdar",
            //    TelNo = "534 505 87 41"
            //    }

            //};

            //foreach (var kisi in kisiler)
            //{
            //    Console.WriteLine(kisi.Ad+ " " + kisi.Soyad + " " + kisi.Adres+  " " + kisi.TelNo);
            //}

            //for (int i = 0; i < kisiler.Count; i++)
            //{
            //    Console.WriteLine(kisiler[i].Ad +  " " +  kisiler[i].Soyad); 
            //} 
            #endregion

            //Ogrenci<int, string, char> ogrenci1 = new Ogrenci<int, string, char>();
            //ogrenci1.Tip = 0;
            //ogrenci1.Sinif = 'A';
            //ogrenci1.OkulNo = "12345";

            //-------------------

            MetotGeneric metotGeneric = new MetotGeneric();
            metotGeneric.Add<string>("Badem");




        }
    }

    #region Generice bakalım
    //class Musteri
    //{
    //    public string Ad { get; set; }
    //} 
    #endregion

    #region Kişiler listesi için kişi classını oluşturalım
    //class Kisi
    //{
    //    public string Ad { get; set; }
    //    public string Soyad { get; set; }
    //    public string Adres { get; set; }
    //    public string TelNo { get; set; }
    //} 
    #endregion

    //class Ogrenci<T, H, Y> //where T: class diye kısıtlama koyabiliriz
    //{
    //    public string Ad { get; set; }
    //    public string Soyad { get; set; }
    //    public Y Sinif { get; set; }
    //    public H OkulNo { get; set; }
    //    public T Tip { get; set; }
    //}
    //class Ders
    //{
    //    public int DersId { get; set; }
    //    public string DersAdi { get; set; }
    //}

    class MetotGeneric
    {
        public void Add<T>(T prm)
        {

        }
    }














}
