using System;
using System.Collections;

namespace _20_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace
            //En büyük özelliği içine her tipten değer alır ve belirtmeye gerek yoktur.
            ArrayList liste = new ArrayList(); 
            //liste.Add("Ayşe");
            //liste.Add(25); 
            //liste.Add(true);
            //liste.Add('B');

            ////Verilere Erişim : 
            //Console.WriteLine(liste[0]); //Ayşe
            //foreach(var i in liste)
            //{
            //    Console.WriteLine(i);
            //}

            //AddRange
            Console.WriteLine("********** AddRange **********");
            //string[] renkler = { "kırmızı", "sarı", "mavi", "yeşil" };
            List<int> sayılar = new List<int> { 1, 2, 3, 4 };
            //liste.AddRange(renkler);
            liste.AddRange(sayılar);
            

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("********** Sort *************");
            liste.Sort(); // Aynı tipte olmaları gerektiği için sayılar hariç diğerleri yorum yapıldı

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            //Binary Search
            Console.WriteLine("********** Binary Search *************");
            Console.WriteLine(liste.BinarySearch(3));

            //Reverse
            Console.WriteLine("********** Reverse *************");
            liste.Reverse();
            Console.WriteLine(liste);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Clear //Komlpe siler
            Console.WriteLine("********** Clear *************");
            liste.Clear();
            foreach (var item in liste)
            {
                Console.WriteLine();

            }
        }
    }
}