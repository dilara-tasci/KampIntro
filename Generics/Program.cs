﻿using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            Console.WriteLine(sehirler.Count);
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>(); //Hangi tip verilirse T o olacağından Add fonksiyonu o türde parametre alır
            Console.WriteLine(sehirler2.Count);
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            Console.WriteLine(sehirler2.Count);

            //My dictionary yapısının test kısmı
            Console.WriteLine("My Dictionary part:");
            MyDictionary<int, string> sehirler3 = new MyDictionary<int, string>();
            Console.WriteLine(sehirler3.Count);
            sehirler3.Add(34, "İstanbul");
            sehirler3.Add(01, "Adana");
            Console.WriteLine(sehirler3.Count);
        }
    }

    class MyList<T> //Generic class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }
       
        public int Count
        {
            get { return _array.Length; }
        }

    }
}
