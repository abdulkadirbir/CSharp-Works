namespace _08_For_dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Bir sayi giriniz : ");
            sayi = int.Parse(Console.ReadLine());

            for (int i = 0; i < sayi; i++)
            { // Çift sayıları yazdırır
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
            Console.WriteLine("-----------");

            //break kullanımı
            for (int i = 0; i < sayi; i++)
            {
                if (i == 5)
                    break; // Bu koşul sağlanır sağlanmaz for döngüsünden çıkar.
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------");
            //continue kullanımı
            for (int i = 0; i < sayi; i++)
            {
                if (i == 5)
                    continue; // Bu koşul sağlanır sağlanmaz for döngüsünden çıkar.
                Console.WriteLine(i);
            }

            //sonsuz döngü : for(;;) ifadesidir.
        }
    }
}