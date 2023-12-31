namespace _09_While_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi = 10;
            int sayac = 0;
            int toplam = 0;
            while (sayac <= sayi) // sayac sayi dan küçük eşittir oldugu sürece çalışacaktır.
            {
                toplam = toplam + sayac;
                sayac++;
            }
            Console.WriteLine(toplam);

            char ch = 'a';
            char ch2 = 'z';
            while (ch <= ch2)
            {
                Console.Write(ch);
                ch++;
            }
            Console.WriteLine();

            string[] arabalar = { "BMW", "Ford", "Mercedes", "Opel" };

            foreach (var araba in arabalar) // var ifadesi genel olarak obje oluşturmak içindir.
                Console.WriteLine(araba);
        }
    }
}