namespace _12_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //erişimbelirteci geridönüştipi metotadı(parametrelistesi / arguman)

            int a = 2; int b = 3;
            Console.WriteLine(a + b);

            Console.WriteLine(Topla(a, b)); // Direkt metotun içindeki değer yazdırılıyor. Başka değere de atanabilirdi.
            Metotlar obje = new Metotlar();
            obje.EkranaYazdir(Convert.ToString(Topla(a, b)));


            Console.WriteLine("---------Referansa göre -----");
            Console.WriteLine(a + b);
            int sonuc = obje.ArttirTopla(ref a, ref b);
            Console.WriteLine(sonuc); // referans olarak geldiği için a ve b değeri de değişecek.
            Console.WriteLine("Referanstan sonra : " + (a + b));



            static int Topla(int deger1, int deger2) // static getirildi çünkü aynı class tan erişim sağlanıyor ve mevcut class da static
            {
                return deger1 + deger2;
            }

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