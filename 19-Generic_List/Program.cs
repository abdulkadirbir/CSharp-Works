using System.Diagnostics.Contracts;

namespace _19_Generic_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collection.Generic
            // T:object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(10);
            sayiListesi.Add(12);
            sayiListesi.Add(3);
            sayiListesi.Add(4);
            sayiListesi.Add(15);
            sayiListesi.Add(9);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("sarı");
            renkListesi.Add("mavi");
            renkListesi.Add("turuncu");
            renkListesi.Add("yeşil");

            //Count
            Console.WriteLine("**** Count ****");
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach ve List.Foreach
            Console.WriteLine("***** foreach *****");
            foreach (int i in sayiListesi) { Console.WriteLine(i); }
            foreach (string i in renkListesi) { Console.WriteLine(i); }

            renkListesi.ForEach(i => Console.WriteLine(i));
            sayiListesi.ForEach(i => Console.WriteLine(i));

            //Remove ve RemoveAt Listeden eleman çıkarma
            Console.WriteLine("******* Remove ve RemoveAt ***********");
            sayiListesi.Remove(10);
            renkListesi.Remove("sarı");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(0);



            renkListesi.ForEach(i => Console.WriteLine(i));
            sayiListesi.ForEach(i => Console.WriteLine(i));

            //Contains Liste içinde arama
            Console.WriteLine("********* Contains ********");
            if(sayiListesi.Contains(15))
            { Console.WriteLine("15 sayısı vardır"); }

            //Binarysearch Eleman ile index bulma
            Console.WriteLine("********* Binarysearch *********");
            sayiListesi.Sort(); // Önce sıralama yapmak gerekiyor
            renkListesi.Sort();
            sayiListesi.Reverse();
            
            

            Console.WriteLine(sayiListesi.BinarySearch(15));
            Console.WriteLine(renkListesi.BinarySearch("turuncu"));

            //Diziyi List'e çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            //Clear - Liste temizleme
            hayvanlarListesi.Clear();

            //List içinde nesne tutmak
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Ayşe";
            kullanıcı1.Soyisim = "Durmaz";
            kullanıcı1.Yas = 28;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Fatma";
            kullanıcı2.Soyisim = "Ekim";
            kullanıcı2.Yas = 30;

            Kullanıcılar kullanıcı3 = new Kullanıcılar();
            kullanıcı3.Isim = "Fatma";
            kullanıcı3.Soyisim = "Ekim";
            kullanıcı3.Yas = 30;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı1);


        }
    }

    public class Kullanıcılar
    {
        private string isim;

        private string soyisim;

        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}