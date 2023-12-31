using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
namespace _4_tip_donusumleri;
class Program
{
    static void Main(string[] args)
    {
        ////Implicit Conversion ( Bilinçsiz Dönüşümler )
        //Console.WriteLine(" ************ Implicit Conversion ************");

        //byte a=5;
        //sbyte b = 30;
        //short c = 10;

        //int d= a+b+c;
        //Console.WriteLine("d:" + d);

        //long e = d;
        //Console.WriteLine("e:" + e);

        //float f = e;
        //Console.WriteLine("f:" + f);


        //string s = "text";
        //char ch = 'z';
        //object o = s+ch+d;
        //Console.WriteLine("o:" + o);


        //// Explicit Conversion ( Bilinçli Dönüşümler )
        //Console.WriteLine(" ************ Explicit Conversion ************");

        //int x= 4;
        //byte y=(byte)x;
        //Console.WriteLine("y:" + y);

        //int z = 100;
        //byte z2=(byte)z;
        //Console.WriteLine("z2:" + z2);

        //float w=10.8f;
        //byte w2=(byte)w;
        //int w3=(int)w;
        //float w4= (float)w3;
        //Console.WriteLine("w: " + w);
        //Console.WriteLine("w2: " + w2);
        //Console.WriteLine("w3: " + w3);
        //Console.WriteLine("w4: " + w4);

        //// Tostring Methodu
        //Console.WriteLine(" ************ ToString Methodu ************");

        //int xx=5;
        //string yy=xx.ToString();
        //Console.WriteLine("yy :" + yy);

        //string zz = 12.5f.ToString();
        //Console.WriteLine("zz: " + zz);

        //// System.Convert Methodu
        //Console.WriteLine(" ************ System.Convert Methodu ************");

        //string s1="10", s2="20";
        //int sayi1,sayi2,toplam;
        //sayi1=Convert.ToInt32(s1);
        //sayi2=Convert.ToInt32(s2);
        //toplam = sayi1 + sayi2;

        //Console.WriteLine("toplam = "   + toplam);

        ////Parse 
        //Console.WriteLine(" ************ Parse Methodu ************");
        //ParseMethod(); // Parse methodu string ifadeleri dönüştürmek için kullanılır ve her zaman string alır.

        //static void ParseMethod()
        //{
        //    string metin1 = "10";
        //    string metin2= "10.25";
        //    int rakam1;
        //    double double1;

        //      rakam1 = int.Parse(metin1, CultureInfo.InvariantCulture);
        //double1 = double.Parse(metin2, CultureInfo.InvariantCulture);
        //    Console.WriteLine("rakam1 : " + rakam1);
        //    Console.WriteLine("double1 : " + double1);

        //}

        // *********************************** 5 - try_catch *******************************************************


        try
        {
            Console.WriteLine("Lütfen bir sayi giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz sayi : " + sayi);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally // Bu alan zorunlu değildir ve her durumda çalışmasını istediğiniz koddur.
        {
            Console.WriteLine("İşlem tamamlanmıştır.");
        }


    }
}
