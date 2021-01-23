using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Dilara";
            musteri1.Soyad = "Taşcı";
            musteri1.Id = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Engin";
            musteri2.Soyad = "Demiroğ";
            musteri2.Id = 10;

            MusteriManager musteriManager = new MusteriManager();

            string secim;
            bool dongu = true;
            while (dongu)
            {
                Console.WriteLine("Hoşgeldiniz! Yapmak istediğiniz işlemi seçin");
                Console.WriteLine("Müşteri Ekle (1)");
                Console.WriteLine("Müşterileri Görüntüle (2)");
                Console.WriteLine("Müşteri Sil (3)");
                Console.WriteLine("Çıkmak için (Başka bir sayı)");
                Console.WriteLine("----------------------------------------");
                secim = Console.ReadLine();
                if (secim == "1")
                {
                    Console.WriteLine("eklenecek müsteri (1 veya 2)");
                    secim = Console.ReadLine();
                    if(secim == "1")
                    {
                        musteriManager.Ekle(musteri1);
                    }
                    else if(secim == "2")
                    {
                        musteriManager.Ekle(musteri2);
                    }
                    
                }
                else if (secim == "2")
                {
                    Console.WriteLine("2");
                    musteriManager.Listele();
                }
                else if (secim == "3")
                {
                    Console.WriteLine("3");
                    Console.WriteLine("silinecek müsteri (1 veya 2)");
                    secim = Console.ReadLine();
                    if (secim == "1")
                    {
                        musteriManager.Sil(musteri1);
                    }
                    else if (secim == "2")
                    {
                        musteriManager.Sil(musteri2);
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim yaptınız");
                    dongu = false;
                }
                Console.WriteLine("----------------------------------------");
            }
        }
    }
}
