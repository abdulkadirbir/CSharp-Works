namespace _13_Metot_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi); // true-false döner 
            if (sonuc)
            {
                Console.WriteLine("Parse işlemi başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }
            Metotlar obje = new Metotlar();
            obje.Topla(10, 5, out int toplamSonucu); // out ifadeli metotta sonuc doğrudan yazdırılıyor.Normal şekilde olmaz. Out ile direkt.
            Console.WriteLine(toplamSonucu);

            // Metot Overloading
            int ifade = 999;
            obje.EkranaYazdir(ifade);
            obje.EkranaYazdir("String ifade");
            // Aynı isimli metotlar görüldüğü gibi tekrar kullanılabildi. Metotlar class ında birden fazla ekrana yazdır var.
            //Metot imzası yöntemiyle gerçekleşiyor. => metotAdı + parametre sayısı + parametre Üçünden biri farklı olsa yetiyor.

        }
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
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

    }
}