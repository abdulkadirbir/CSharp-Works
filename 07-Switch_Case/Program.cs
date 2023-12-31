namespace _07_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int month = DateTime.Now.Month;

            switch (month) // Case yapıları belli bir sıraya göre olmak zorunda değildir. default case 1 den önce gelebilir. Her zaman break olmalıdır.
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız.");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındasınız.");
                    break;
                case 3:
                    Console.WriteLine("Mart ayındasınız.");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayındasınız.");
                    break;
                case 5:
                    Console.WriteLine("Mayıs ayındasınız.");
                    break;
                case 6:
                    Console.WriteLine("Haziran ayındasınız.");
                    break;
                case 7:
                    Console.WriteLine("Temmuz ayındasınız.");
                    break;
                case 8:
                    Console.WriteLine("Ağustos ayındasınız.");
                    break;
                case 9:
                    Console.WriteLine("Eylül ayındasınız.");
                    break;
                case 10:
                    Console.WriteLine("Ekim ayındasınız.");
                    break;
                case 11:
                    Console.WriteLine("Kasım ayındasınız.");
                    break;
                case 12:
                    Console.WriteLine("Aralık ayındasınız.");
                    break;

                default: //Hiçbir koşul sağlanmazsa buraya girip sonlanacaktır. Zorunlu değildir.
                    Console.WriteLine("Yanlış değer girildi.");
                    break;

            }


            switch (month) // Birden fazla durumu sağlayan ifadelerde case yapıları alt alta gelebilir.
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış mevsimindesiniz.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimindesiniz.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimindesiniz.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevsimindesiniz.");
                    break;
                default:

                    break;
            }

        }
    }
}