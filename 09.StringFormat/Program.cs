using System;

namespace _09.StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("-------------------------------------------------------");
            //Console.WriteLine("Sıra No | Adınız | Soyadınız");
            //Console.WriteLine("-------------------------------------------------------");
            //Console.WriteLine(string.Format("{0,7}|{1,-8}|{2,10}", 1, "Ömer", "ERTÜRK"));
            //Console.WriteLine(string.Format("{0,7}|{1,-8}|{2,10}", 2, "Tevfik", "ULUÇ"));
            //Console.WriteLine(string.Format("{0,7}|{1,-8}|{2,10}", 3, "Yücel", "CAN"));
            //Console.WriteLine("-------------------------------------------------------");

            //Console.WriteLine(string.Format("{0:00000}", 15));
            //Console.WriteLine(string.Format("{0:00000}", -15));
            //Console.WriteLine(string.Format("{0,5}", 15));
            //Console.WriteLine(string.Format("{0,-5}", 15));

            //*******************************************************************************

            String.Format("{0:00000}", 15); // "00015"
            /*ifadesiyle 15 sayısı ekrana başına 3 adet 0 eklenerek toplamda 5 karakter olarak yazılır.*/

            String.Format("{0:00000}", -15); // "-00015"
            /*ifadesiyle -15 sayısı ekrana başına 3 adet 0 eklenerek toplamda 5 karakter olarak yazılır.*/

            String.Format("{0,5}", 15); // " 15"
            /*ifadesiyle 15 sayısı ekrana başına 3 adet boşluk eklenerek toplamda 5 karakterlik bir alana sağa hizalı olarak yazılır.*/

            String.Format("{0,-5}", 15); // "15 "
            /*ifadesiyle 15 sayısı ekrana başına 3 adet boşluk eklenerek toplamda 5 karakterlik bir alana sola hizalı olarak yazılır.*/

            String.Format("{0,5:000}", 15); // " 015"
            /*ifadesiyle 15 sayısı ekrana başına bir adet 0 ve iki adet boşluk eklenerek toplamda 5 karakterlik bir alana sağa hizalı olarak yazılır.*/

            String.Format("{0,-5:000}", 15); // "015 "
            /*ifadesiyle 15 sayısı ekrana başına bir adet 0 ve iki adet boşluk eklenerek toplamda 5 karakterlik bir alana sola hizalı olarak yazılır.*/

            Console.WriteLine(String.Format("{0:### ## ##}", 1234567)); ; // 123 45 67
            Console.WriteLine(String.Format("{0:(#) ###-##-##}", 12345678)); ; //(1) 234-56-78
            /* Sayıları isteğe bağlı biçimlendirmek istersek (örneğin bir telefon numarasını  alan kodu ve telefon numarası ayrı ayrı yazılsın istiyorsak), biçimlendirme işleminde diyez (#) işareti ile formatımızı belirleriz;*/

            /* Ondalıklı sayılarda virgülden (programlamada nokta) sonra kaç basamak görünsün istiyorsak köşeli parantezler ({ }) içerisindeki biçimleme kısmında noktadan sonra o kadar sıfır (0) koymamız gerekir;*/
            String.Format("{0:0.00}", 123.4567); // "123.46"
            String.Format("{0:0.00}", 123.4); // "123.40"
            String.Format("{0:0.00}", 123); // "123.00"

            /*Eğer ondalıklı sayının en fazla kaç basamağının ekranda çıkmasını istiyorsak, bu sefer sıfır yerine o kadar sayıda diyez (#) işareti kullanmamız gerekir;*/
            String.Format("{0:0.##}", 123.4567); // "123.46"
            String.Format("{0:0.##}", 123.4); // "123.4"
            String.Format("{0:0.##}", 123); // "123"

            /*Ondalıklı sayılarda virgülden önce kaç basamak görüntülemek istiyorsak biçimlendirme yaparken, noktadan önce kaç basamak istiyorsak o kadar sıfır (0) kullanmamız gerekir;*/
            String.Format("{0:000.0}", 123.4567); // "123.5"
            String.Format("{0:000.0}", 23.4567); // "023.5"
            String.Format("{0:00.00}", 3.4567); // "03.46"
            String.Format("{0:00.00}", -3.4567); // "-03.46"

            //Eğer sayıların görüntülenmesinde bin ayracı kullanılmak isteniyorsa;
            String.Format("{0:0,0.0}", 12345.678); // "12,345.7"
            String.Format("{0:0,0.00}", 12345.678); // "12,345.68"
            String.Format("{0:0,0}", 12345.678); // "12,346"

            /*0 ile 1 arasındaki ondalıklı sayıların gösterimi iki şekilde olur. Birincisinde sayının tam kısmı 0 ve noktadan sonra ondalıklı kısmı gelir (Örn: 0.123 şeklinde), bir diğer gösterim şeklinde ise sayının tam kısmı yazılmaz sadece nokta ve sonrasındaki ondalıklı kısım yazılır (Örn: .123 şeklinde).İşte bu durumlardaki sayıların gösterimi ise şu şekilde gerçekleştirilir;*/
            String.Format("{0:0.0}", 0.0); // "0.0"
            String.Format("{0:0.#}", 0.0); // "0"
            String.Format("{0:#.0}", 0.0); // ".0"
            String.Format("{0:#.#}", 0.0); // ""

            /*Bütün bu formların dışında sayılarımızı aşağıdaki gibi istediğimiz metinler ile birlikte yazmamız da mümkündür;*/
            String.Format("{0:sonuç 0.0}", 12.3); // "sonuç 12.3"
            String.Format("{0:x0x.yy0yy}", 12.3); // "x12x.yy3yy"


            //*******************************************************************************

            //DateTime zaman = DateTime.Now;
            //DateTime tarih = zaman.Date;

            //int ay = zaman.Month;
            //int gün = zaman.Day;
            //int yıl = zaman.Year;
            //DayOfWeek haftanıngünü = zaman.DayOfWeek;
            //int yılınkaçıncıgünü = zaman.DayOfYear;
            //TimeSpan süre = zaman.TimeOfDay;
            //int saat = zaman.Hour;
            //int dakika = zaman.Minute;
            //int saniye = zaman.Second;
            //int salise = zaman.Millisecond;
            //Console.WriteLine("Şu andaki zaman : {0}", zaman);
            //Console.WriteLine("Tarih bilgisi : {0}", tarih);
            //Console.WriteLine("Ay bilgisi : {0}", ay);
            //Console.WriteLine("Gün bilgisi : {0}", gün);
            //Console.WriteLine("Yıl bilgisi : {0}", yıl);
            //Console.WriteLine("Haftanın günü : {0}", gün);
            //Console.WriteLine("Yılın kaçıncı günü : {0}", yılınkaçıncıgünü);
            //Console.WriteLine("Süre : {0}", süre);
            //Console.WriteLine("Saat : {0}", saat);
            //Console.WriteLine("Dakika : {0}", dakika);
            //Console.WriteLine("Saniye : {0}", saniye);
            //Console.WriteLine("Salise : {0}", salise);

            //*******************************************************************************

            //DateTime bugün; TimeSpan süre;
            //bugün = DateTime.Now;
            //Console.WriteLine("Doğum tarihinizi girin: ");
            //DateTime doğumtarihiniz = DateTime.Parse(Console.ReadLine());
            //süre = bugün.Subtract(doğumtarihiniz);
            //Console.WriteLine("Dünya üzerine geleli {0} gün olmuş.", süre.TotalDays);
            //Console.WriteLine("Dünya üzerine geleli {0} saat olmuş.", süre.TotalHours);
            //Console.WriteLine("Dünya üzerine geleli {0} dakika olmuş.", süre.TotalMinutes);
            //Console.WriteLine("Dünya üzerine geleli {0} saniye olmuş.", süre.TotalSeconds);
            //Console.WriteLine("Dünya üzerine geleli {0} salise olmuş.", süre.TotalMilliseconds);

            //*******************************************************************************

            //SORU: 12/07/2008  20:12:23:33 (saat:dakika:saniye:salise) tarihinden 5 yıl, 6 ay, 28 gün, 23 saat, 29 dakika, 33 saniye ve 43 salise sonrasının tarihini ekrana yazan program.

            //DateTime ilkTarih = new DateTime(2008, 07, 12, 20, 12, 23, 33);
            //DateTime bitişTarihi = ilkTarih.AddYears(5);
            //bitişTarihi = bitişTarihi.AddMonths(6);
            //bitişTarihi = bitişTarihi.AddDays(28);
            //bitişTarihi = bitişTarihi.AddHours(23);
            //bitişTarihi = bitişTarihi.AddMinutes(29);
            //bitişTarihi = bitişTarihi.AddSeconds(33);
            //bitişTarihi = bitişTarihi.AddMilliseconds(43);
            //Console.WriteLine("İlk tarih: " + ilkTarih);
            //Console.WriteLine("Son tarih: " + bitişTarihi);
        }
    }
}
