using System;

namespace Ders12
{
    class Program
    {
        static void Main(string[] args)
        {
            //try - catch -finally : Hata yönetimi

            try
            {
                int sayi1 = 5, sayi2 = 1;
                int sonuc = sayi1 / sayi2;
                string metin = "12";
                int a = Convert.ToInt16(metin);
                string tc = "236";
                int b = Convert.ToInt16(tc);
                if (b<500)
                {
                    throw new Exception("Sayı 500'den küçük");
                }
                Console.WriteLine("Sonuc=" + sonuc);
                //Console.WriteLine("Sonuc=" + a);
            }
            catch (DivideByZeroException dx)
            {
                Console.WriteLine("Sıfıra bölme hatası " + dx.Source);
            }
            catch (FormatException fx)
            {
                Console.WriteLine("Format hatası. Hatalı Convert işlemi " + fx.ToString());  //Console.WriteLine("Format hatası. Hatalı Convert işlemi " + fx.Message);

            }
            catch (Exception e)
            {
                Console.WriteLine("Genel Hata"); //Hata olursa çalışır
                Console.WriteLine("Hatamız : " + e.ToString());
            } 
            finally
            {
                Console.WriteLine("Her durumda çalışan kod");// Hata oluşsada oluşmasada çalışır.
            }

            Console.ReadKey();
        }
    }
}
