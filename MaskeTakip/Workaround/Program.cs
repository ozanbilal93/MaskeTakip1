using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Workaround
{
     class Program
    {
        static void Main(string[] args)
        {
           // Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            SelamVer(isim:"Ozan");
            SelamVer(isim: "Ozy");
            SelamVer(isim: "Ozi");
            SelamVer();

            int sonuc = Topla(48,22);

            //Diziler / Arrays

            string ogrenci1 = "Ozan";
            string ogrenci2 = "Engin";
            string ogrenci3 = "Hasan";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Ozan";
            ogrenciler[1] = "Engin";
            ogrenciler[2] = "Hasan";

            ogrenciler = new string[4];
            ogrenciler[3] = "Osman";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Çorum", "Muğla", "Diyatbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            


           

            List<string> yeniSehirler1= new List<string> { "İzmir1", "Muğla1", "Çorum1" };
            yeniSehirler1.Add("Adana1");

            foreach (string sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

             
            


            Console.ReadLine();

        }
        //resharper
        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba "+ isim);
        }
        static int Topla(int sayi1=15, int sayi2=25)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : "+sonuc);
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000; //db den gelir
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Engin";
            string soyad = "Demiroğ";
            int dogumYili = 1985;
            long tcNo = 12345678910;

            Console.WriteLine(tutar * 1.18);

            Console.WriteLine(tutar * 1.18);
        }
    }
    //pascal casing
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

    }
}
