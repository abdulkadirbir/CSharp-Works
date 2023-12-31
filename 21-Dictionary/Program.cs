using System.Runtime.CompilerServices;

namespace _21_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Collection.Generic  namespace
            Dictionary<int, string> ornek = new Dictionary<int, string>();

            ornek.Add(1, "İstanbul");
            ornek.Add(2, "Ankara");
            ornek.Add(3, "İzmir");
            ornek.Add(4, "Bursa");

            //Dizinin Elemanlarına Erişim
            Console.WriteLine("********* Erişim ***********");
            Console.WriteLine(ornek[1]);  //Sadece dictionary de belirtilen integer ı getirir. index şeklinde değildir.  
            foreach (var item in ornek)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine("********* Count ***********");
            Console.WriteLine(ornek.Count);

            //Contains - Burada key ve value olarak ikiye ayrılmaktadır. 
            Console.WriteLine("********* Contains ***********");
            Console.WriteLine(ornek.ContainsKey(2));
            Console.WriteLine(ornek.ContainsValue("İstanbul"));
            Console.WriteLine(ornek.ContainsValue("Balıkesir"));

            //Remove - key alır sadece
            Console.WriteLine("********* Remove ***********");
            ornek.Remove(4);
            foreach (var item in ornek)
            {
                Console.WriteLine(item);
            }

            //Keys
            foreach (var item in ornek.Keys)
            {
                Console.WriteLine(item);
            }
            //Values
            foreach (var item in ornek.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}