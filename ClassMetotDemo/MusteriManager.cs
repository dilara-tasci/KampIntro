using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> musteriler = new List<Musteri> { };
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler! Müşteri eklendi: " + musteri.Ad+" "+musteri.Soyad);
            musteriler.Add(musteri);
        }
        public void Listele()
        {
            Console.WriteLine("Güncel Müşteri Listesi:");
            foreach (var m in musteriler)
            {
                Console.WriteLine(m.Ad+" "+m.Soyad);
            }
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi: " + musteri.Ad + " " + musteri.Soyad);
            musteriler.RemoveAt(musteri.Id-1);
        }
    }
}
