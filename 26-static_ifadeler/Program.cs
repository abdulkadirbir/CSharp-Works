namespace _26_static_ifadeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calisan.CalisanSayisi); // calisanSayisi static olduğu için nesne oluşturulmaz.
                                                      //Bir kere çağrıldığında ilk olarak boş olan constructor çalışır.
            Calisan calisan1 = new Calisan("Ahmet", "Yılmaz", "Bilgi İşlem"); //static constructor dan nesne oluşturulmaz.
            Console.WriteLine(Calisan.CalisanSayisi);
            calisan1.CalisanBilgileri();

            Console.WriteLine(Islemler.topla(100,150)); //Static olanlar nesne oluşturmadan doğrudan çağrılır.
            Console.WriteLine(Islemler.cikar(150,100));
            Console.WriteLine(Islemler.carpimCagir(3, 5));

        }
    }
    class Calisan
    {
        private static int calisanSayisi; //static property lerin değerleri sabit kalır. Yani dinamik dğeildir.
        public static int CalisanSayisi { get => calisanSayisi;}

        private string isim;
        private string soyisim;
        private string departman;

        static Calisan() { 
            calisanSayisi = 0;
        }

        public Calisan(string isim,string soyisim, string departman) {
            this.isim = isim;
            this.soyisim = soyisim;
            this.departman = departman;
            calisanSayisi++;
        }
        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisanin adı :{0}", this.isim);
            Console.WriteLine("Calisanin soyadı :{0}", this.soyisim);
            Console.WriteLine("Calisanin departmanı :{0}", this.departman);
        }

    }
    static class Islemler
    {
        public static int topla(int x, int y) {
            return x + y;
        }
        public static int cikar(int x, int y)
        {
            return x - y;
        }
        private static int carp(int x, int y) //bu methoda dışarıdan erişilemez. Refleksiyon yaparak erişilebilir. Veya yardımcı methodla
        {
            return x * y;
        }
        public static int carpimCagir(int x, int y) // bu dışarıdan private olan methoda erişimi sağlar.
        {
            return carp(x, y);
        }
    }
}