namespace _10_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Dizi tanımlama
            string[] renkler = new string[5]; // 5 elemanlı bir string dizisi oldu.

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Aslan" }; // 4 elemanlı bir string dizisi oldu değerler atanınca boyut otomatik geldi.

            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim
            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(renkler[0]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(hayvanlar[0]);

            //Döngülerle Dizi Kullanımı
            //Klavyeden girilen n tane sayının ortalamasını hesaplayan program

            Console.Write("Kaç tane sayi olsun ? : ");
            int diziuzunlugu = int.Parse(Console.ReadLine());
            int[] sayidizisi = new int[diziuzunlugu];

            for (int i = 0; i < diziuzunlugu; i++) // sayidizisi.Length de kullanılabilir
            {
                Console.Write("Lütfen {0}.sayiyi giriniz : ", i + 1); //Bu şekilde bir kullanım 
                sayidizisi[i] = int.Parse(Console.ReadLine());


            }

            int toplam = 0;
            foreach (var item in sayidizisi)
            {
                toplam = toplam + item;
            }
            Console.WriteLine("Ortalama : " + toplam / diziuzunlugu);
        }
    }
}