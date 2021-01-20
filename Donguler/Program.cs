using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("static yapı");
            String kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            String kurs2 = "Programlamaya başlangıç için temel kurs";
            String kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            Console.WriteLine("dinamik yapı");
            //array - dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya başlangıç için temel kurs", "Java", "python" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("farklı bir döngü");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
