using System;
using System.Data;
using System.Data.SqlClient;

namespace _29.AdoNetGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            //ORM: Object to Relational Mapping 
            //Veri tabanı ile programımız arasında bağlantı kurmaya yarar. çeşitleri şöyle: Adonet, Entity Framework, Dapper, NHibernate..

            //SqlConnection baglanti = new SqlConnection(@"server=LAPTOP-RGH49P0Q; initial catalog=Northwind; integrated security=false; user id=sa; password=Password1");
            //baglanti.Open();
            //SqlCommand cmd = new SqlCommand("select * from Urunler", baglanti);
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine(reader["UrunAdi"].ToString());
            //}
            //baglanti.Close();

            Product product = new Product();
            SqlConnection baglanti2 = product.BaglantiKur();
            //product.UrunListele(baglanti2);
            //product.TabloyaGoreListele("Kategoriler", baglanti2);
            //product.TabloOlustur(baglanti2);
            product.KayitEkleme(baglanti2);
            product.KayitSil(baglanti2);



        }


    }

    public class Product
    {
        public SqlConnection BaglantiKur()
        {
            SqlConnection baglanti = new SqlConnection(@"server=LAPTOP-RGH49P0Q; initial catalog=Northwind; integrated security=false; user id=sa; password=Password1");

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            return baglanti;
        }


        public void TabloyaGoreListele(string tabload, SqlConnection conn) //parametre göndereceğim
        {
            conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from " + tabload, conn);
            SqlDataReader liste = cmd.ExecuteReader();
            while (liste.Read())
            {
                Console.WriteLine("{0}-{1}",liste[0].ToString(),liste[1].ToString());
            }
            conn.Close();
        }

        public void UrunListele(SqlConnection conn)
        {
            conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Urunler", conn);
            SqlDataReader liste = cmd.ExecuteReader();
            while (liste.Read())
            {
                Console.WriteLine(liste[1].ToString());
            }
            conn.Close();
        }
        public void TabloOlustur(SqlConnection conn)
        {
            conn.Open();
            try
            {
                Console.WriteLine("bir tablo ismi yazın");
                string tabload = Console.ReadLine();
                SqlCommand sql = new SqlCommand("create table " + tabload + "(id int identity (1,1) not null, ogrenciAd nvarchar(50), ogrenciNo smallint)", conn);
                sql.ExecuteNonQuery();  // sorgunun sonucunu sorguluyor
                Console.WriteLine(tabload + " isminde bir tablo oluşturuldu");  //gerçektende ssms programından baktığımızda bir tablo oluştuğunu göreceğiz
                conn.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("bir hata oluştu");
            }
        }
        public void KayitEkleme(SqlConnection connection)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand cmd = new SqlCommand("insert into deneme (ogrenciAd, ogrenciNo) values ('Can' , 5)", connection);
     
            cmd.ExecuteNonQuery();  
            Console.WriteLine("listeye bir kayıt eklendi");
            connection.Close();
        }

        public void KayitSil(SqlConnection bglnt)
        {
            TabloyaGoreListele("deneme", bglnt);

            if (bglnt.State == ConnectionState.Closed)
            {
                bglnt.Open();
            }

            Console.WriteLine("kaç nolu kaydı silmek istersiniz");
            int deger = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("delete from deneme where id=" + deger , bglnt);
            cmd.ExecuteNonQuery();
            Console.WriteLine("kayıt silindi");
        }



    }
}
