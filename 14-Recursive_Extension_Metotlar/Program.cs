namespace _14_Recursive_Extension_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Recursive metotlar
            static int factor(int x) // Bu fonksiyon recursive olarak tasarlanmıştır. Böylece sürekli kendisini yeniler.
                // Fonksiyonların çalışma prensibine  
            {
                if (x == 1)
                {
                    return x;
                }
                return factor(x - 1) * x;
            }
            Console.WriteLine(factor(10));

            //Extension metotlar
            // Extension metotlar muhakkak static class static metot olmak zorunda
            //Parametre olarak muhakkak this ifadesi kullanılır.
            //Sonra da hazır kütüphane gibi istediğin yerde kullanılır.
            int ifade = 10;
            Console.WriteLine(ifade.isEvenNumber()); //Extension metotlar normal kütüphaneler gibi "." ile çağrılabilir. Bu metotlar özeldir.

            string isim = "Abdulkadir bir";
            Console.WriteLine(isim.CheckSpaces());

  
        }
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" "); 
        }
        public static bool isEvenNumber(this int num)
        {
            return num % 2 == 0;
        }



    }
}