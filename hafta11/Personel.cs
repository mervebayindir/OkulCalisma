using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace hafta11
{
   public class Personel
    {
        public int PersonelId { get; set; }
        public string AdSoyad { get; set; }
        public string Birim { get; set; }
        public int GorevId { get; set; }
        public double Maas { get; set; }

        public static string baglantiYolu = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=Ders10; Integrated Security=true";
        public static string baglantiYolu2 = ConfigurationManager.ConnectionStrings["DersEntity"].ToString();

        SqlConnection baglanti = new SqlConnection(baglantiYolu2);
        public DataTable PersonelGetir()
        {
            var tablo = new DataTable();  //DataTable tablo=new DataTable();

            SqlCommand komut = new SqlCommand("Select *from Personel", baglanti);
            baglanti.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            adaptor.Fill(tablo); //fill doldur tabloyu.

            baglanti.Close();

            return tablo;
        }
        public bool PersonelEkle(Personel Personel)
        {
            int kontrol;
            SqlCommand komut = new SqlCommand("insert into Personel(AdSoyad,Birim,GorevId,Maas) values(@ad,@birim,@gorev,@maas))",baglanti);
            komut.Parameters.AddWithValue("@ad", Personel.AdSoyad);
            komut.Parameters.AddWithValue("@birim", Personel.Birim);
            komut.Parameters.AddWithValue("@gorev", Personel.GorevId);
            komut.Parameters.AddWithValue("@maas", Personel.Maas);
            baglanti.Open();
            kontrol =komut.ExecuteNonQuery();
            baglanti.Close();
            return (kontrol > 0) ? true : false;
        }
        public bool DeletePersonel(Personel p)
        {
            SqlCommand komut = new SqlCommand("delete from Personel where PersonelId=@id", baglanti);
            komut.Parameters.AddWithValue("@id", p.PersonelId);
            baglanti.Open();
            int kontrol = komut.ExecuteNonQuery();
            baglanti.Close();
            return (kontrol > 0) ? true : false;
        }
        public bool UpdatePersonel(Personel p)
        {
            SqlCommand komut = new SqlCommand("update Personel set AdSoyad=@Ad, Birim=@birim, GorevId=@gorevId, Maas=@maas where PersonelId=@id",baglanti);
            komut.Parameters.AddWithValue("@ad", p.AdSoyad);
            komut.Parameters.AddWithValue("@birim", p.Birim);
            komut.Parameters.AddWithValue("@gorevId", p.GorevId);
            komut.Parameters.AddWithValue("@maas", p.Maas);
            komut.Parameters.AddWithValue("@id", p.PersonelId);
            baglanti.Open();
            int kontrol = komut.ExecuteNonQuery();
            baglanti.Close();
            return (kontrol > 0) ? true : false;
        }
    }
}
