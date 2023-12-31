namespace _11_Dizi_Array_Methodları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = { 10, 56, 89, 74, 25, 10, 0, 12, 36, 2 };
            Console.WriteLine("----------Sırasız Dizi----------");
            foreach (int i in sayiDizisi) { Console.WriteLine(i); }
            Console.WriteLine("----------Sıralı  Dizi----------");
            Array.Sort(sayiDizisi);
            foreach (var say in sayiDizisi) Console.WriteLine(say);

            //Clear 
            Console.WriteLine("---------Clear Dizi-------------");
            Array.Clear(sayiDizisi, 2, 2); // 2. index ten itibaren 2 tane elemanı 0 lar.
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Reverse
            Console.WriteLine("---------Reverse Dizi---------");
            Array.Reverse(sayiDizisi);
            foreach (var say in sayiDizisi) Console.WriteLine(say);

            //IndexOf
            Console.WriteLine("---------IndexOf---------------");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 36));

            //Resize - yeniden boyutlandırır ve 0 değerlerini atar.
            Console.WriteLine("-----------Resize---------------");
            Array.Resize<int>(ref sayiDizisi, 15);
            foreach (int i in sayiDizisi) Console.WriteLine(i);
        }
    }
}