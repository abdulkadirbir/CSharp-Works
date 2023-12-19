using System;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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


        // ***************************************** 5-try_catch ***************************************
        //try
        //{
        //    Console.Write("Lütfen Bir Sayi Giriniz : ");
        //    int sayi = Convert.ToInt32(Console.ReadLine()); // Doğrudan Console.ReadLine() ifadesi de kullanılabilirdi.
        //    Console.WriteLine("Girdiğiniz sayi : " + sayi);
        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine(e.Message);
        //}
        //finally
        //{
        //    Console.WriteLine("İşlem Başarıyla Gerçekleşmiştir.");
        //}

        //try // İlk gördüğü try bloğunun içindeki kod çalışacaktır. O yüzden diğerleri pass geçilecektir.
        //{
        //    //int a = int.Parse(null); // ArgumentNullException
        //    // int b = int.Parse("test"); // FormatException
        //    // int c = int.Parse("20000000000"); //OverflowException
        //    int d = int.Parse("15");
        //}
        //catch (ArgumentNullException ex) 
        //{ 
        //    Console.WriteLine(ex.Message);
        //    Console.WriteLine("Boş değer girildi.");
        //    Console.WriteLine(ex);
        //}
        //catch(FormatException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //    Console.WriteLine("Yanlış veri tipi girildi.");
        //    Console.WriteLine(ex);
        //}
        //catch (OverflowException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //    Console.WriteLine("Çok büyük ya da çok küçük değer girildi.");
        //    Console.WriteLine(ex);
        //}


        // *********************************************  6-If_Else_Ternary If  *********************************

        //int time = DateTime.Now.Hour;

        //if (time >= 6 && time <= 12)
        //    Console.WriteLine("Günaydınlaar!!");
        //else if (time > 12 && time <= 17)
        //    Console.WriteLine("İyi Günlerrrr!!");
        //else if (time > 17 && time <= 22)
        //    Console.WriteLine("İyi Akşamlar!!!");
        //else
        //    Console.WriteLine("İyi Gecelerrr!!");
        //// Ternary ifade için aşağıda örnek incelenebilir. Koşul ? sonuç : koşul sağlanmazsa sonuç
        //Console.WriteLine(time >= 6 && time <= 12 ? "Günaydın" : time > 12 && time <= 17 ? "İyi günler" : time > 17 && time <= 22 ? "İyi akşamlar" : "İyi geceler");
        //string sonuc = time >= 6 && time <= 12 ? "Günaydın" : time > 12 && time <= 17 ? "İyi günler" : time > 17 && time <= 22 ? "İyi akşamlar" : "İyi geceler";
        //Console.WriteLine(sonuc);

        // ************************************************ 7- Switch-Case ****************************************

        //int month = DateTime.Now.Month;

        //switch(month) // Case yapıları belli bir sıraya göre olmak zorunda değildir. default case 1 den önce gelebilir. Her zaman break olmalıdır.
        //{
        //    case 1:
        //        Console.WriteLine("Ocak ayındasınız.");
        //        break;
        //    case 2:
        //        Console.WriteLine("Şubat ayındasınız.");
        //        break;
        //    case 3:
        //        Console.WriteLine("Mart ayındasınız.");
        //        break;
        //    case 4:
        //        Console.WriteLine("Nisan ayındasınız.");
        //        break;
        //    case 5:
        //        Console.WriteLine("Mayıs ayındasınız.");
        //        break;
        //    case 6:
        //        Console.WriteLine("Haziran ayındasınız.");
        //        break;
        //    case 7:
        //        Console.WriteLine("Temmuz ayındasınız.");
        //        break;
        //    case 8:
        //        Console.WriteLine("Ağustos ayındasınız.");
        //        break;
        //    case 9:
        //        Console.WriteLine("Eylül ayındasınız.");
        //        break;
        //    case 10:
        //        Console.WriteLine("Ekim ayındasınız.");
        //        break;
        //    case 11:
        //        Console.WriteLine("Kasım ayındasınız.");
        //        break;
        //    case 12:
        //        Console.WriteLine("Aralık ayındasınız.");
        //        break;

        //    default: //Hiçbir koşul sağlanmazsa buraya girip sonlanacaktır. Zorunlu değildir.
        //        Console.WriteLine("Yanlış değer girildi.");
        //        break;

        //}


        //switch(month) // Birden fazla durumu sağlayan ifadelerde case yapıları alt alta gelebilir.
        //{
        //    case 12:
        //    case 1:
        //    case 2:
        //        Console.WriteLine("Kış mevsimindesiniz.");
        //        break;
        //    case 3:
        //    case 4:
        //    case 5:
        //        Console.WriteLine("İlkbahar mevsimindesiniz.");
        //        break;
        //    case 6:
        //    case 7:
        //    case 8:
        //        Console.WriteLine("Yaz mevsimindesiniz.");
        //        break;
        //    case 9:
        //    case 10:
        //    case 11:
        //        Console.WriteLine("Sonbahar mevsimindesiniz.");
        //        break;
        //    default :

        //        break;
        //}


        // ***************************************  8-for döngüsü *************************************************

        //int sayi;
        //Console.Write("Bir sayi giriniz : ");
        //sayi = int.Parse(Console.ReadLine());

        //for(int i = 0; i < sayi; i++) { // Çift sayıları yazdırır
        //    if (i % 2 == 0)
        //        Console.WriteLine(i);
        //}
        //Console.WriteLine("-----------");

        ////break kullanımı
        //for(int i = 0;i < sayi; i++)
        //{
        //    if (i == 5)
        //        break; // Bu koşul sağlanır sağlanmaz for döngüsünden çıkar.
        //    Console.WriteLine(i);
        //}
        //Console.WriteLine("-----------");
        ////continue kullanımı
        //for (int i = 0; i < sayi; i++)
        //{
        //    if (i == 5)
        //        continue; // Bu koşul sağlanır sağlanmaz for döngüsünden çıkar.
        //    Console.WriteLine(i);
        //}

        ////sonsuz döngü : for(;;) ifadesidir.

        // *************************************************** 9- while_foreach ***********************************************

        //int sayi = 10;
        //int sayac = 0;
        //int toplam = 0;
        //while (sayac <= sayi) // sayac sayi dan küçük eşittir oldugu sürece çalışacaktır.
        //{
        //    toplam = toplam + sayac;
        //    sayac++;
        //}
        //Console.WriteLine(toplam);

        //char ch = 'a';
        //char ch2 = 'z';
        //while (ch<=ch2)
        //{
        //    Console.Write(ch);
        //    ch++;
        //}
        //Console.WriteLine();

        //string[] arabalar = { "BMW", "Ford", "Mercedes", "Opel" };

        //foreach(var araba in arabalar) // var ifadesi genel olarak obje oluşturmak içindir.
        //    Console.WriteLine(araba);

        // ***************************************************** 10-Diziler ***************************************************

        //Dizi tanımlama
        //string[] renkler = new string[5]; // 5 elemanlı bir string dizisi oldu.

        //string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Aslan" }; // 4 elemanlı bir string dizisi oldu değerler atanınca boyut otomatik geldi.

        //int[] dizi;
        //dizi = new int[5];

        ////Dizilere değer atama ve erişim
        //renkler[0] = "Mavi";
        //dizi[3] = 10;

        //Console.WriteLine(renkler[0]);
        //Console.WriteLine(dizi[3]);
        //Console.WriteLine(hayvanlar[0]);

        //Döngülerle Dizi Kullanımı
        //Klavyeden girilen n tane sayının ortalamasını hesaplayan program

        //Console.Write("Kaç tane sayi olsun ? : ");
        //int diziuzunlugu = int.Parse(Console.ReadLine());
        //int[] sayidizisi = new int[diziuzunlugu];

        //for(int i = 0; i < diziuzunlugu; i++) // sayidizisi.Length de kullanılabilir
        //{
        //    Console.Write("Lütfen {0}.sayiyi giriniz : ", i + 1); //Bu şekilde bir kullanım 
        //    sayidizisi[i] = int.Parse(Console.ReadLine());

        //}

        //int toplam = 0;
        //foreach (var item in sayidizisi)
        //{
        //    toplam = toplam + item;
        //}
        //Console.WriteLine("Ortalama : " + toplam / diziuzunlugu);

        // *************************************************************** 11 - Dizi Array Methodları ******************************************

        ////Sort
        //int[] sayiDizisi = { 10, 56, 89, 74, 25, 10, 0, 12, 36, 2 };
        //Console.WriteLine("----------Sırasız Dizi----------");
        //foreach(int i in sayiDizisi) { Console.WriteLine(i); }
        //Console.WriteLine("----------Sıralı  Dizi----------");
        //Array.Sort(sayiDizisi);
        //foreach(var  say in sayiDizisi) Console.WriteLine(say);

        ////Clear 
        //Console.WriteLine("---------Clear Dizi-------------");
        //Array.Clear(sayiDizisi,2,2); // 2. index ten itibaren 2 tane elemanı 0 lar.
        //foreach(var sayi in sayiDizisi)
        //{
        //    Console.WriteLine(sayi);   
        //}

        ////Reverse
        //Console.WriteLine("---------Reverse Dizi---------");
        //Array.Reverse(sayiDizisi);
        //foreach( var say in sayiDizisi)Console.WriteLine(say);

        ////IndexOf
        //Console.WriteLine("---------IndexOf---------------");
        //Console.WriteLine(Array.IndexOf(sayiDizisi, 36));

        ////Resize - yeniden boyutlandırır ve 0 değerlerini atar.
        //Console.WriteLine("-----------Resize---------------");
        //Array.Resize<int>(ref sayiDizisi, 15);
        //foreach( int i in sayiDizisi) Console.WriteLine(i);

        // ************************************************************** 12-Metotlar ****************************************************

        //erişimbelirteci geridönüştipi metotadı(parametrelistesi/arguman)

        //int a = 2; int b = 3;
        //Console.WriteLine(a + b);

        //Console.WriteLine(Topla(a,b)); // Direkt metotun içindeki değer yazdırılıyor. Başka değere de atanabilirdi.
        //Metotlar obje = new Metotlar();
        //obje.EkranaYazdir(Convert.ToString(Topla(a,b)));


        //Console.WriteLine("---------Referansa göre -----");
        //Console.WriteLine(a+b);
        //int sonuc = obje.ArttirTopla(ref a, ref b);
        //Console.WriteLine(sonuc); // referans olarak geldiği için a ve b değeri de değişecek.
        //Console.WriteLine("Referanstan sonra : " + (a + b)); 



        //static int Topla(int deger1, int deger2) // static getirildi çünkü aynı class tan erişim sağlanıyor ve mevcut class da static
        //{
        //    return deger1 + deger2;
        //}

        // ****************************************************************  13-Metot Overloading *******************************************

        ////out parametreler
        //string sayi = "999";

        //bool sonuc = int.TryParse(sayi, out int outSayi); // true-false döner 
        //if(sonuc)
        //{
        //    Console.WriteLine("Parse işlemi başarılı");
        //    Console.WriteLine(outSayi);
        //}
        //else
        //{
        //    Console.WriteLine("Başarısız");
        //}
        //Metotlar obje = new Metotlar();
        //obje.Topla(10, 5,out int toplamSonucu); // out ifadeli metotta sonuc doğrudan yazdırılıyor.Normal şekilde olmaz. Out ile direkt.
        //Console.WriteLine(toplamSonucu);

        //// Metot Overloading
        //int ifade = 999;
        //obje.EkranaYazdir(ifade);
        //obje.EkranaYazdir("String ifade");
        //// Aynı isimli metotlar görüldüğü gibi tekrar kullanılabildi. Metotlar class ında birden fazla ekrana yazdır var.
        ////Metot imzası yöntemiyle gerçekleşiyor. => metotAdı + parametre sayısı + parametre Üçünden biri farklı olsa yetiyor.


        // *********************************** Recursive ve Extension Metotlar ***************************************

        //Recursive metotlar
        static int factor(int x) // Bu fonksiyon recursive olarak tasarlanmıştır. Böylece sürekli kendisini yeniler.
        {
            if (x == 1)
            {
                return x;
            }
            return factor(x - 1) * x;
        }
        Console.WriteLine(factor(10));

        //Extension metotlar
        int ifade = 10;
        Console.WriteLine(ifade.IsEvenNumber()); //Extension metotlar normal kütüphaneler gibi "." ile çağrılabilir. Bu metotlar özeldir.
        






    }
 

    class Metotlar
    {
        public void EkranaYazdir(string veri) // public oldu çünkü farklı class tan erişim olacak. Default u private tır
        {
            Console.WriteLine(veri);
        }
        public int ArttirTopla(ref int deger1, ref int deger2) // referans verildiği için değer kopyalanmadan direkt bellekteki yerine gider ve değiştirir.
        {
            deger1++;
            deger2++;
            return deger1 + deger2;
        }
        public void Topla(int a, int b,out int toplam)
        {
            toplam = a + b;
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
       
    }
}

public static class ExtensionMetotlar
{
    //Önemli olan static olmasıdır ve this ifadesinin kullanılmasıdır. Sonra da hazır kütüphane gibi istediğin yerde kullanılır.
    public static bool IsEvenNumber(this int param)
    {
        return param % 2 == 0;
    }
}