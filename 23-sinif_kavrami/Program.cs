using System.Security.Cryptography.X509Certificates;

namespace _23_sinif_kavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            //class SinifAdi
            //{
            //    [Erişim Belirleyici] [Veri Tipi] ÖzellikAdi;
            //    [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi(Parametre Listesi) 
            //    {
            //        Metot Komutları
            //    }
            //}

            //Erişim Belirleyiciler : 
            //    * public = Her yerden erişilebilir.
            //    * private = Sadece tanımlı olduğu class içinden erişilebilir.
            //    * internal = Sadece tanımlı olduğu proje içinden erişilebilir.
            //    * protected = Sadece tanımlı olduğu class ta ve o class tan kalıtım alan class lardan erişilebilir.

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ahmet";
            calisan1.Soyad = "Çetin";
            calisan1.No = 2000;
            calisan1.Departman = "Bilgi İşlem";
            calisan1.CalisanBilgileri();
            Console.WriteLine( "-------------------------------------------------");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Abdulkadir";
            calisan2.Soyad = "Bir";
            calisan2.No = 2111;
            calisan2.Departman = "Bilgi İşlem";
            calisan2.CalisanBilgileri();

         }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı :{0}", Ad);
            Console.WriteLine("Çalışanın Soyadı :{0}", Soyad);
            Console.WriteLine("Çalışanın Numarası :{0}", No);
            Console.WriteLine("Çalışanın Departmanı :{0}", Departman);

        }
    }
}