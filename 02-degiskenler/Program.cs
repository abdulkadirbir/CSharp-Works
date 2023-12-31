using System;
namespace _2_degiskenler;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        byte sayi1 = 5;     // byte lar sadece 0-256 arasında değer alabilir. 1 byte yer kaplar
        sbyte sayi2 = 5  ;   // sbyte lar ise -127 ile 128 arası değerler alabilmektedir. 1 byte yer kaplar
        string sayi3= " ";  // normal string değerler -- null olabilir
        int sayi4 = 0;      // 4 byte yer kaplar normal int değerler
        Int16 sayi5 = 0;    // 2 byte yer kaplar normal int değerler
        Int32 sayi6 = 0;    // 4 byte yer kaplar normal int değerler 
        Int32 sayi7 = 0;    // 8 byte yer kaplar normal int değerler 
        short sayi8 = 5;    // 2 byte yer kaplar -32768 ile +32768 arası değer alır.
        ushort sayi9 = 5;   // 2 byte yer kaplar. 0-65365 arası değer alır.
        uint sayi10 = 5;    // 4 byte yer kaplar
        long sayi11 = 5;    // 8 byte yer kaplar
        ulong sayi12 = 5;   //8 byte yer kaplar

        //Reel Sayılar
        float sayi13 = 5;    // 4 byte yer kaplar
        double sayi14 = 5;   // 8 byte yer kaplar
        decimal sayi15 = 5;  // 16 byte yer kaplar
        char char1 = 'a';    //2 byte yer kaplar
        string st = "kadir"; // sınırsız yer kaplar

        DateTime dt = DateTime.Now; // şimdiki zamanı verir.

        object o1="x";
        object o2=2;
        object o3=2.1;
        object o4='a';

        string str = string.Empty; // =""; ve = null; ile aynı değer.

        // Değişken Dönüşümleri
        string str20 = "20";
        int int20 = 20;
        string yeniDeger = str20+int20.ToString();
        Console.WriteLine(yeniDeger); // 2020

        int int21= int20 + Convert.ToInt32(str20);
        Console.WriteLine(int21); // 40
        int int22 = int20+ int.Parse(str20); // 40 // bu parse işlemleri stringten dönüşüm için kullanılır. yoksa format exception hatası alınır.
        Console.WriteLine("yeni" + int22);

        string datetime = DateTime.Now.ToString("dd.MM.yyyy"); // Tarih formatı için bu şekilde dönüşüm sağlanabilir.
        Console.WriteLine(datetime);

        Console.WriteLine(sayi1+sayi2+sayi3+sayi4+sayi5+sayi6+sayi7+sayi8+sayi9+sayi10+sayi11+sayi12+sayi13+sayi14+sayi15+dt);
    }
}
