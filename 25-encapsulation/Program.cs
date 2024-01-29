using System.ComponentModel;
using System.Text.Json;

namespace _25_encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci("Ahmet","Coşkun",2000,2);
            ogrenci1.OgrenciBilgileriniGetir();
            ogrenci1.SinifArttir();
            ogrenci1.OgrenciBilgileriniGetir();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();



        }
    }
    class Ogrenci
    {
        private string Ad;
        private string Soyad;
        private int OgrenciNo;
        private int Sinif;

        public string Ad1
        { //Bu şekilde kullanım da uygundur.
            get { return Ad; }
            set { Ad = value; }
        }

        public string Soyad1 { get => Soyad; set => Soyad = value; }
        public int OgrenciNo1 { get => OgrenciNo; set => OgrenciNo = value; }
        public int Sinif1 // Bu şekilde buraya if koşulu koyabiliriz.
        { get => Sinif; 
            set
            {
                if(value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olmalıdır.");
                    Sinif = 1;
                }
                else
                    Sinif = value;
            } 
        }

        public Ogrenci(string Ad1, string Soyad1, int OgrenciNo1, int Sinif1)
        {
            this.Ad1 = Ad1;
            this.Soyad1 = Soyad1;
            this.OgrenciNo1 = OgrenciNo1;
            this.Sinif1 = Sinif1;
        }
        public Ogrenci() { }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("************ Öğrenci Bilgileri **********");
            Console.WriteLine("Ogrencinin Adı :{0}", this.Ad1); // Bu kullanım da olur. Aşağıdaki kullanım da olur.
            Console.WriteLine("Ogrencinin Soyadı :{0}", Soyad1);// this ifadesi okunabilirliği daha da arttırır.
            Console.WriteLine("Ogrencinin Numarası :{0}", OgrenciNo1);
            Console.WriteLine("Ogrencinin Sınıfı :{0}", Sinif1);

        }
        public void SinifArttir()
        {
            this.Sinif1 += 1;
        }
        public void SinifDusur()
        {
            this.Sinif1 -= 1;
        }

    }
}