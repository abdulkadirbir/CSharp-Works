using System;
namespace odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*********************** 1. Ödev **********************\n");
            //  1. Ödev
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            Console.Write("Lütfen pozitif bir tam sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int[] dizi = new int[sayi];
            Console.WriteLine("Lütfen {0} adet pozitif tam sayı giriniz...", sayi);
            for(int i = 0; i < sayi; i++)
            {
                Console.Write("{0}. sayıyı giriniz : ",i+1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Girdiğiniz sayılardan çift sayı olanlar : ");
            foreach(int i in dizi)
            {
                if (i % 2 == 0) Console.Write(i + " ");
            }






            Console.WriteLine("\n*********************** 2. Ödev **********************\n");  

            //  2. Ödev
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            Console.Write("Lütfen pozitif 1. tam sayıyı giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen pozitif 2. tam sayıyı giriniz : ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            int[] dizi2 = new int[sayi2];
            Console.WriteLine("Lütfen {0} adet pozitif tam sayı giriniz...", sayi2);
            for (int i = 0; i < sayi2; i++)
            {
                Console.Write("{0}. sayıyı giriniz : ", i + 1);
                dizi2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Girdiğiniz sayılardan {0}'e eşit olanlar veya tam bölünen sayılar : ",sayi3);
            foreach (int i in dizi2)
            {
                if (i%sayi3==0 || i==sayi3) Console.Write(i + " ");
            }






            Console.WriteLine("\n*********************** 3. Ödev **********************\n");

            //  3. Ödev
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            Console.Write("Lütfen pozitif bir tam sayı giriniz : ");
            int sayi4 = Convert.ToInt32(Console.ReadLine());
            

            string[] str = new string[sayi4];
            Console.WriteLine("Lütfen {0} adet kelime giriniz...", sayi4);
            for (int i = 0; i < sayi4; i++)
            {
                Console.Write("{0}. kelimeyi giriniz : ", i + 1);
                str[i] = Console.ReadLine();
            }
            Array.Reverse(str);
            Console.WriteLine("Girdiğiniz kelimelerin tersten sıralanışı: ");
            foreach (string i in str)
            {
               Console.Write(i + " ");
            }






            Console.WriteLine("\n*********************** 4. Ödev **********************\n");

            //  4. Ödev
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.Write("Lütfen bir cümle giriniz :");
            string cumle = Console.ReadLine();
            int sayacKelime = 1;
            int sayacHarf = 0;
            foreach(char i in cumle)
            {
                if(i.Equals(" ") || i==32)
                { sayacKelime++; }
                sayacHarf++;
            }
            Console.WriteLine("Cümledeki toplam kelime sayısı :" +  sayacKelime);
            Console.WriteLine("Cümledeki toplam harf sayısı   :" + (sayacHarf - sayacKelime + 1));


        }
    }
}