namespace kurucu_metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* calisan1 bilgileri ***************");
            Calisan calisan1 = new Calisan("Ayşe","Kaplan",2500,"Bilgi İşlem");
            calisan1.calisanBilgileriGetir();

            Console.WriteLine("************* calisan2 bilgileri ***************");
            Calisan calisan2 = new Calisan("Umut", "Kaya", 2600, "Bilgi İşlem");
            calisan2.calisanBilgileriGetir();

            Console.WriteLine("************* calisan3 bilgileri ***************");
            Calisan calisan3 = new Calisan("Serdar", "Yonca");
            calisan3.calisanBilgileriGetir();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan() { }
        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
  
        }
        public void calisanBilgileriGetir()
        {
            Console.WriteLine("Adı :{0}", Ad);
            Console.WriteLine("Soyadı :{0}", Soyad);
            Console.WriteLine("Numarası :{0}", No);
            Console.WriteLine("Departmanı :{0}", Departman);

        }
    }
}