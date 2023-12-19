using System;

namespace console_programlama;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // System.Console.WriteLine("Hello, World!"); // System eğer yukarıda import edilmeseydi bu şekilde kullanılabilirdi.
        Console.WriteLine("İsim giriniz : ");
        string name = Console.ReadLine();
        Console.WriteLine("Soyisim giriniz : ");
        string surname = Console.ReadLine();
        Console.WriteLine("İsminiz : " + name + " " + surname);

    
    
    }
}
