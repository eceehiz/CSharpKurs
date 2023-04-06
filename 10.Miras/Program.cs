using System;
using System.Linq;

namespace _10.Miras
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Baba, Anne, KızÇocuk, ErkekÇocuk için özellikler girelim
            //Baba baba = new Baba();
            //baba.Adi = "Muzaffer";
            //baba.Soyadi = "Konak";
            //baba.Yas = 55;
            //baba.SacRengi = "Beyaz";
            //baba.GozRengi = "Siyah";
            //baba.Maas = 10000;
            //baba.Sakal = true;
            //baba.YetenekBelirt();

            //Anne anne = new Anne();
            //anne.Adi = "Hediye";
            //anne.Soyadi = "Konak";
            //anne.Yas = 52;
            //anne.SacRengi = "Siyah";
            //anne.GozRengi = "Yeşil";
            //anne.Orgu = true;
            //anne.Makyaj = false;
            //anne.Tesettur = true;

            //ErkekCocuk erkekcocuk = new ErkekCocuk();
            //erkekcocuk.Adi = "Ege";
            //erkekcocuk.Soyadi = "Konak";
            //erkekcocuk.Yas = 10;
            //erkekcocuk.SacRengi = "Kahverengi";
            //erkekcocuk.GozRengi = "Ela";
            //erkekcocuk.Sakal = false;
            //erkekcocuk.OkulNo = 989;

            //KizCocuk kizCocuk = new KizCocuk();
            //kizCocuk.Adi = "Sinem";
            //kizCocuk.Soyadi = "Konak";
            //kizCocuk.Yas = 15;
            //kizCocuk.SacRengi = "Sarı";
            //kizCocuk.GozRengi = "Mavi";
            //kizCocuk.Makyaj = true;
            //kizCocuk.Tesettur = false;
            //kizCocuk.OkulNo = 125;

            //Console.WriteLine("Konak ailesinin üyeleri" + "\nBabanın Adı: " + baba.Adi + "\nBabanın Yaşı: " + baba.Yas + "\nAnnenin Adı: " + anne.Adi + "\nBabanın Yeteneği: " + baba.Yetenek + "\nAnnenin Yaşı: " + anne.Yas + "\nErkek Çocuğun Adı: " + erkekcocuk.Adi + "\nErkek Çocuğun Yaşı: " + erkekcocuk.Yas + "\nKız Çocuğun Adı: " + kizCocuk.Adi + "\nKız Çocuğun Yaşı: " + kizCocuk.Yas); 
            #endregion

            #region Kamyon, Araba, Gemi için özellikler girelim
            //Kamyon kamyon = new Kamyon();
            //kamyon.Marka = "Volvo";
            //kamyon.ModelYılı = 2018;
            //kamyon.Fiyat = 600000;
            //kamyon.Rengi = "Kırmızı";
            //kamyon.Kilometresi = 20000;
            //kamyon.Vites = "Manuel";
            //kamyon.Navigasyon = false;
            //kamyon.YakıtTürü = "Benzin";
            //kamyon.Yuk = 500;

            //Araba araba = new Araba();
            //araba.Marka = "Mercedes";
            //araba.ModelYılı = 2020;
            //araba.Fiyat = 750000;
            //araba.Rengi = "Siyah";
            //araba.Kilometresi = 5000;
            //araba.Vites = "Otomatik";
            //araba.Navigasyon = true;
            //araba.YakıtTürü = "Dizel";
            //araba.AcıkTavan = true;

            //Gemi gemi = new Gemi();
            //gemi.YakıtTürü = "Benzin";
            //gemi.Boy = 20;

            //Console.WriteLine("Kamyonun markası: " + kamyon.Marka + "\nKamyonun rengi: " + kamyon.Rengi + "\nArabanın vitesi: " + araba.Vites + "\nArabanın acık tavanı mevcut mu : " + araba.AcıkTavan + "\nGeminin yakıt türü: " + gemi.YakıtTürü + "\nGeminin metre cinsinden uzunluğu: " + gemi.Boy); 
            #endregion

            #region Öğretmen, Öğrenci, Veli, Müdür için özellikler girelim
            //Ogretmen ogretmen = new Ogretmen();
            //ogretmen.Adi = "Meltem";
            //ogretmen.Soyadi = "Görgülü";
            //ogretmen.Yas = 32;
            //ogretmen.Adres = "Üsküdar";
            //ogretmen.Brans = "Matematik";

            //Ogrenci ogrenci = new Ogrenci();
            //ogrenci.Adi = "Sevinç";
            //ogrenci.Soyadi = "Kutlu";
            //ogrenci.Yas = 15;
            //ogrenci.Sınıf = 9;

            //Veli veli = new Veli();
            //veli.Adi = "Büşra";
            //veli.Soyadi = "Kutlu";
            //veli.Yas = 34;
            //veli.Meslek = "Hemşire";

            //Console.Write("Ödeme yaptıysanız true, yapmadıysanız false yazınız: ");
            //bool trueorfalse = Convert.ToBoolean(Console.ReadLine());

            //veli.Odeme = trueorfalse;
            //veli.OdemeYap(); 
            #endregion

            #region Öğretmen, öğrenci ilkerin çözümü

            ////Yönetici
            //Manager faruk = new Manager();
            //faruk.Name = "faruk";
            //faruk.SurName = "atik";
            ////Öğretmenler
            //Teacher ugur = new Teacher();
            //ugur.Name = "uğur";
            //ugur.SurName = "akbulut";
            //ugur.Salary = 50000;
            //Teacher ahmet = new Teacher();
            //ahmet.Name = "ahmet";
            //ahmet.SurName = "yayla";
            //ahmet.Salary = 10000;
            ////öğrenciler
            //Student beyza = new Student();
            //beyza.Name = "beyza";
            //beyza.SurName = "daldal";
            //Student fatih = new Student();
            //fatih.Name = "fatih";
            //fatih.SurName = "polat";
            //Student ilker = new Student();
            //ilker.Name = "ilker";
            //ilker.SurName = "şenel";


            //beyza.AddTeacher(ugur);//ekleyemez

            //ugur.AddStudent(beyza);
            //ugur.AddStudent(fatih);
            //faruk.AddStudentFromTeacher(ilker, ugur);

            //ahmet.AddStudent(beyza);
            //ahmet.AddStudent(fatih);
            //// ahmet.AddStudent(ilker);
            //faruk.AddStudentFromTeacher(ilker, ahmet);


            //fatih.AddTeacher(ugur);
            //ilker.AddTeacher(ugur);
            //beyza.AddTeacher(ugur);
            //fatih.AddTeacher(ahmet);
            //ilker.AddTeacher(ahmet);
            //beyza.AddTeacher(ahmet);

            //faruk.AddEducator(ugur);
            //faruk.AddEducator(ahmet);

            //beyza.ShowMyTeacher();

            //ugur.MyClassInfo();
            //ahmet.MyClassInfo();

            //faruk.ShowAllTeacher();

            //faruk.EditSalary(ahmet, 78000000m);

            //Console.WriteLine($"ahmet yayla yeni maaşı={ahmet.Salary}"); 
            #endregion


        }

    }

    #region Kişi, Kadın, Erkek, KızÇocuk, ErkekÇocuk classlarını oluşturalım
    //class Kisi
    //{
    //    public string Adi { get; set; }
    //    public string Soyadi { get; set; }
    //    public byte Yas { get; set; }
    //    public string SacRengi { get; set; }
    //    public string GozRengi { get; set; }
    //    public string Yetenek { get; set; }
    //    public void YetenekBelirt()
    //    {
    //        Console.WriteLine("Bir yetenek belirtin: ");
    //        Console.WriteLine("1-Spor , 2-Tamir , 3-Yemek yapabilir");
    //        int yeti = Convert.ToInt32(Console.ReadLine());

    //        if (yeti == 1)
    //        {
    //            this.Yetenek = "Sporcu";
    //        }
    //        else if (yeti == 2)
    //        {
    //            this.Yetenek = "Tamirci";
    //        }
    //        else
    //        {
    //            this.Yetenek = "Yemek yapabilir";
    //        }
    //    }
    //}
    //class Kadin : Kisi
    //{
    //    public bool Makyaj { get; set; }
    //    public bool Tesettur { get; set; }
    //}
    //class Erkek : Kisi
    //{
    //    public bool Sakal { get; set; }
    //}
    //class Baba : Erkek
    //{
    //    public decimal Maas { get; set; }
    //}
    //class Anne : Kadin
    //{
    //    public bool Orgu { get; set; }
    //}
    //class ErkekCocuk : Erkek
    //{
    //    public int OkulNo { get; set; }
    //}
    //class KizCocuk : Kadin
    //{
    //    public int OkulNo { get; set; }
    //}
    #endregion

    #region Arac, Kamyon, Araba, Gemi classlarını oluşturalım
    //class Arac
    //{
    //    public string Marka { get; set; }
    //    public int ModelYılı { get; set; }
    //    public decimal Fiyat { get; set; }
    //    public string Rengi { get; set; }
    //    public decimal Kilometresi { get; set; }
    //    public string Vites { get; set; }
    //    public bool Navigasyon { get; set; }
    //    public string YakıtTürü { get; set; }

    //}

    //class Kamyon : Arac
    //{
    //    public int Yuk { get; set; }
    //}
    //class Araba : Arac
    //{
    //    public bool AcıkTavan { get; set; }
    //}
    //class Gemi : Arac
    //{
    //    public decimal Boy { get; set; }
    //} 
    #endregion

    #region Kişi, Öğretmen, Öğrenci, Müdür classlarını oluşturalım
    //class Kisi
    //{
    //    public string Adi { get; set; }
    //    public string Soyadi { get; set; }
    //    public int Yas { get; set; }
    //    public string Adres { get; set; }
    //}

    //class Ogretmen : Kisi
    //{
    //    public string Brans { get; set; }
    //}

    //class Ogrenci : Kisi
    //{
    //    public int OgrenciNo { get; set; }
    //    public int Sınıf { get; set; }
    //}

    //class Veli : Kisi
    //{
    //    public string Meslek { get; set; }
    //    public bool Odeme { get; set; }
    //    public void OdemeYap()
    //    {
    //        Mudur mudur = new Mudur();

    //        if (Odeme == true)
    //        {
    //            Console.WriteLine("Ödeme yapıldı");
    //            mudur.UyarıYap(true);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Ödeme yapılmadı");
    //            mudur.UyarıYap(false);
    //        }

    //    }
    //}

    //class Mudur : Kisi
    //{
    //    public void UyarıYap(bool uyari)
    //    {
    //        if (uyari == true)
    //        {
    //            Console.WriteLine("Ödeme yaptığınız için tşk");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Lütfen ödeme yapınız");
    //        }
    //    }
    //} 
    #endregion

    #region Kişi, öğretmen, öğrenci, müdür classları ilkerin çözümü
    //class Person
    //{
    //    public string Name { get; set; }
    //    public string SurName { get; set; }
    //}

    //class Teacher : Person
    //{
    //    public decimal Salary { get; set; }

    //    public byte i = 0;
    //    public string[] MyStudentsName { get; set; } = new string[50];
    //    public string[] MyStudentsSurName { get; set; } = new string[50];
    //    public int[] MyStudentsId { get; set; } = new int[50];

    //    public void AddStudent(Student student)
    //    {
    //        if (i > 49)
    //            Console.WriteLine("sınıf mevcudu dolu");
    //        else
    //        {
    //            MyStudentsName[i] = student.Name;
    //            MyStudentsSurName[i] = student.SurName;
    //            MyStudentsId[i] = student.Id;
    //            this.i++;
    //        }
    //    }

    //    public void MyClassInfo()
    //    {
    //        Console.WriteLine($"{this.Name}'un öğrencileri");
    //        for (int z = 0; z < this.i; z++)
    //        {
    //            Console.WriteLine(MyStudentsName[z] + " " + MyStudentsSurName[z]);
    //        }

    //    }

    //}

    //class Student : Person
    //{
    //    public int Id { get; set; }
    //    public string[] MyTeacherName { get; set; } = new string[5];
    //    public string[] MyTeacherSurName { get; set; } = new string[5];
    //    public byte i = 0;

    //    public void AddTeacher(Teacher teacher)
    //    {
    //        if (teacher.MyStudentsName.Contains(this.Name) && teacher.MyStudentsSurName.Contains(this.SurName))
    //        {
    //            this.MyTeacherName[this.i] = teacher.Name;
    //            this.MyTeacherSurName[this.i] = teacher.SurName;
    //            //Console.WriteLine($"{this.Name}'nın öğretmeni {teacher.Name} {teacher.SurName} olmuştur");
    //            i++;

    //        }
    //        else
    //        {
    //            Console.WriteLine($"Sayın {this.SurName} {teacher.Name} {teacher.SurName} seni öğrenci olarak eklemediği için onu" +
    //                $" öğretmen olarak ekleyemezsin");
    //        }

    //    }

    //    public void ShowMyTeacher()
    //    {
    //        Console.WriteLine($"{this.Name}'nın öğretmenleri");
    //        for (int z = 0; z < i; z++)
    //        {
    //            Console.WriteLine(this.MyTeacherName[z] + " " + this.MyTeacherSurName[z]);
    //        }
    //    }

    //}

    //class Manager : Person
    //{
    //    public decimal[] TeacherSalary { get; set; } = new decimal[10];
    //    public string[] TeacherName { get; set; } = new string[10];
    //    public string[] TeacherSurName { get; set; } = new string[10];
    //    public byte[] StudentPiece { get; set; } = new byte[10];
    //    public int MyProperty { get; set; }
    //    private byte i = 0;

    //    public void AddEducator(Teacher teacher)
    //    {
    //        TeacherName[i] = teacher.Name;
    //        TeacherSurName[i] = teacher.SurName;
    //        TeacherSalary[i] = teacher.Salary;
    //        StudentPiece[i] = teacher.i;
    //        i++;
    //    }
    //    public void ShowAllTeacher()
    //    {
    //        Console.WriteLine("Öğretmenler");
    //        for (int z = 0; z < i; z++)
    //        {
    //            Console.WriteLine(TeacherName[z] + " " + TeacherSurName[z] + " maaşı:"
    //                + TeacherSalary[z] + "\nSınıfındaki öğrenci sayısı:" + StudentPiece[z]);
    //        }
    //    }

    //    public void AddStudentFromTeacher(Student student, Teacher teacher)
    //    {
    //        if (i > 49)
    //            Console.WriteLine("sınıf mevcudu dolu");
    //        else
    //        {
    //            teacher.MyStudentsName[teacher.i] = student.Name;
    //            teacher.MyStudentsSurName[teacher.i] = student.SurName;
    //            teacher.MyStudentsId[teacher.i] = student.Id;
    //            teacher.i++;
    //        }

    //    }

    //    public void EditSalary(Teacher teacher, decimal salary)
    //    {
    //        teacher.Salary = salary;
    //    }

    //} 
    #endregion




}

