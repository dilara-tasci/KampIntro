using System;

namespace DegerVeReferansTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 = ? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = ? 999

            /*
             * int, decimal, float, double, bool -> değer tip
             * array, class, interface -> referans tip
            */
            /*
             * stack        heap
             * sayi1=10
             * sayi2=30
             * 101 sayilar1     101[10,20,30]
             * 102 sayilar2     102[100,200,300]
             * değişiklik yapıldığında sayilar1 in başına 102 atanmış olur
             * pointer yapısı
             * garbage collector ise hiç kimsenin tutmadığı 101 adresini siler
            */
        }
    }
}
