namespace _06_If_Else_Ternary_If
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int time = DateTime.Now.Hour;

            if (time >= 6 && time <= 12)
                Console.WriteLine("Günaydınlaar!!");
            else if (time > 12 && time <= 17)
                Console.WriteLine("İyi Günlerrrr!!");
            else if (time > 17 && time <= 22)
                Console.WriteLine("İyi Akşamlar!!!");
            else
                Console.WriteLine("İyi Gecelerrr!!");
            // Ternary ifade için aşağıda örnek incelenebilir. Koşul ? sonuç : koşul sağlanmazsa sonuç
            Console.WriteLine(time >= 6 && time <= 12 ? "Günaydın" : time > 12 && time <= 17 ? "İyi günler" : time > 17 && time <= 22 ? "İyi akşamlar" : "İyi geceler");
            string sonuc = time >= 6 && time <= 12 ? "Günaydın" : time > 12 && time <= 17 ? "İyi günler" : time > 17 && time <= 22 ? "İyi akşamlar" : "İyi geceler";
            Console.WriteLine(sonuc);
        }
    }
}