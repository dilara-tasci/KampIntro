using System;
using System.Linq;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref keyword kullanımı başlangıç
            int number1 = 20;
            int number2 = 100;
            var result = Add(ref number1, number2);
            Console.WriteLine("number1"+number1);
            Console.WriteLine(result);
            //ref keyword kullanımı bitiş
            //out keyword kullnımı başlangıç
            int number3;
            int number4 = 100;
            var result2 = Add2(out number3, number4);
            Console.WriteLine("number1" + number1);
            Console.WriteLine(result);
            //out keyword kullanımı bitiş
            //params kullanımı başlangıç
            //params ile aynı türde istediğimiz kadar parametre gönderebilmemizi sağlar
            //paramstan önce parametre alabilir ama params fonksiyonun son parametresi olmalı diğer türlü hata verir. çünkü params ile değişken almada sınır yoktur
            Console.WriteLine(Add3(2,3,5));
            Console.WriteLine(Add3(9,6,7,68,5882));
            //params kullanımı bitiş
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("-------------- Metotlar ----------------");

            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);
        }
        //ref keyword kullanımı fonksiyonu
        static int Add(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        //out keyword kullanımı fonksiyonu
        static int Add2(out int number3, int number4)
        {
            number3 = 30;
            return number3 + number4;
        }
        //params keyword kullanımı fonksiyonu
        static int Add3(params int[] numbers)
        {
            return numbers.Sum() ;
        }
    }
   
}

//type-safe -- tip güvenli
//Don't repeat yourself - DRY
//Clean Code
//Best Practice


