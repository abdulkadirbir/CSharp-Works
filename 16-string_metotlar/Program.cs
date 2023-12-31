namespace _16_string_metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string str = "Merhabalar Ben Abdulkadir";
            string str2 = "Hello";
            string str3 = "B";
            string str4 = "merhabalar ben abdulkadir";

            //Length
            Console.WriteLine(str.Length);
            Console.WriteLine(str2.Length);

            //ToUpper , ToLower
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToUpper());

            //Concat
            Console.WriteLine(String.Concat(str, " Bir")); //Bunun ifadesi biraz farklı

            //CompareTo
            //Çağrıldığı string ifade ile parametre olarak verilen string ifadeyi karşılaştırır
            //ve iki ifade de birbirine eşitse geriye int türünde sıfır (0) değerini döndürür.
            //Aksi takdirde metinleri ilk harflerinden itibaren tek tek karşılaştırır
            //ve farklılığın olduğu ilk harflerin alfabedeki sıralarına göre “-1” veya “1″ sayı değerlerini döndürür.
            Console.WriteLine(str3.CompareTo("B")); // 0 str3("B") sayı doğrusuna göre eşit oldukları yer
            Console.WriteLine(str3.CompareTo("A")); //1 str3("B") alfabetik olarak sonra oldugundan +1
            Console.WriteLine(str3.CompareTo("C")); //-1 str3("B") alfabetik olarak önce oldugundan -1

            //Compare 
            Console.WriteLine(String.Compare("B","b",true)); //0 gelir çünkü büyük küçük harfe bakmaz eşittirler.
            Console.WriteLine(String.Compare("Z","a",false)); // 1 gelir çünkü "B" asci de "b" den önce gelir.
            Console.WriteLine(String.Compare("b","B",false)); // -1 gelir çünkü "b" asci olarak sonra gelir.
            Console.WriteLine("B".CompareTo("B")); //0
            Console.WriteLine("B".CompareTo("A")); //1 
            Console.WriteLine("B".CompareTo("C")); //-1 Buranın 1 olması lazım bence B C den önce geliyor.
            Console.WriteLine("B".CompareTo("b")); //1
            // NOT : CompareTo harf hassasiyetine bakmaz. Doğrudan alfabeye bakar.
            // Eğer alfabede 1. string 2. stringten önce gelirse sonuç -1 olur
            // Compare ise 
            Console.WriteLine(String.Compare("A", "B", false)); //-1
            Console.WriteLine(String.Compare("A", "z", false)); //+1
            Console.WriteLine("B".CompareTo("C")); //-1 B C den önce
            Console.WriteLine("B".CompareTo("a")); //+1 B a dan sonra
            Console.WriteLine("B".CompareTo("b")); //+1 
            Console.WriteLine("B".CompareTo("c")); //-1 B c den önce
            Console.WriteLine("----");
            Console.WriteLine("B".CompareTo("a"));
            Console.WriteLine("B".CompareTo("b"));
            Console.WriteLine("B".CompareTo("c"));
            Console.WriteLine("B".CompareTo("A"));
            Console.WriteLine("B".CompareTo("B"));
            Console.WriteLine("B".CompareTo("C"));

            //Contains
            Console.WriteLine(str.Contains("Abdulkadir"));
            Console.WriteLine(str.EndsWith("Abdulkadir"));
            Console.WriteLine(str.StartsWith("Abdulkadir"));


            //IndexOf
            Console.WriteLine(str.IndexOf("Abdulkadir"));
            Console.WriteLine(str.LastIndexOf("r") );

            //Insert
            Console.WriteLine(str.Insert(0,"Günaydın "));

            //Padleft, Padright
            Console.WriteLine(str.PadLeft(30)); // string in soluna boşluk ekler ve toplam 30 karakter eder.
            Console.WriteLine(str.PadLeft(30,'*')); // string in soluna * ekler ve toplam 30 karakter eder.
            Console.WriteLine(str.PadRight(30, '*')); // string in sağına * ekler ve toplam 30 karakter eder.
            Console.WriteLine(str.PadRight(30)); // string in sağına boşluk ekler ve toplam 30 karakter eder.

            //Remove
            Console.WriteLine(str.Remove(10)); //10. indisten itibaren kaldırır siler 10. indis de dahildir
            Console.WriteLine(str.Remove(10,4)); // 10. indisten itibaren 4 karakter siler devamını yazar.

            //Replace
            Console.WriteLine(str.Replace("Abdulkadir", "Beyza"));
            Console.WriteLine(str.Replace(" ","*")); // boşluk gördüğü yerlere * koyar

            //Split
            Console.WriteLine(str.Split(' ')[0]); // boşluklara göre ayırdı ve her bir terimi indize atadı

            //Substring
            Console.WriteLine(str.Substring(10)); //10. indisten itibaren getirir
            Console.WriteLine(str.Substring(10,4)); //10. indisten itibaren 4 satır getirir.
        }
    }
}