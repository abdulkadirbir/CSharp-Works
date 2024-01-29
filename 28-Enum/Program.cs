namespace _28_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazartesi);
            Console.WriteLine((int)Gunler.Salı);
            Console.WriteLine(Gunler.Cumartesi);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklık = 32;

            if(sicaklık <= (int)HavaDurumu.normal)
                Console.WriteLine("Hava durumu soğuk, dışarıya çıkmak için ısınması gerekiyor.");
            else if(sicaklık >= (int)HavaDurumu.sicak)
                Console.WriteLine("Hava durumu sıcak, dışarıya çıkmayalım.");
            
        }
    }
    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=10,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        soguk = 5,
        normal = 20,
        sicak = 25,
        cokSicak = 35

    }
}