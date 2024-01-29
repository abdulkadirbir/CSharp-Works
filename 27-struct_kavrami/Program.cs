namespace _27_struct_kavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgenClass = new Dikdortgen();
            Console.WriteLine(dikdortgenClass.AlanHesapla());
            dikdortgenClass.KisaKenar = 5;
            dikdortgenClass.UzunKenar = 10;
            Console.WriteLine(dikdortgenClass.AlanHesapla());
            Dikdortgen2 dikdortgenStruct0 = new Dikdortgen2();
            Console.WriteLine(dikdortgenStruct0.AlanHesapla());
            Dikdortgen2 dikdortgenStruct; // new demeden de oluşturabilirsin.
            dikdortgenStruct.KisaKenar = 3;
            dikdortgenStruct.UzunKenar = 4;
            Console.WriteLine(dikdortgenStruct.AlanHesapla()); // Değerler class ta olduğu gibi default 0 atanmaz.
            Dikdortgen2 dikdortgenStruct2 = new Dikdortgen2(2,10);
            Console.WriteLine(dikdortgenStruct2.AlanHesapla());
            // 16bayt a kadar struct kullanıp, 16bayt tan yüksek değerler için class iyidir.
        }
    }
    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;
        public Dikdortgen()
        {
            this.KisaKenar=1;
            this.UzunKenar = 2;
        }
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
    struct Dikdortgen2
    {
        public int KisaKenar;
        public int UzunKenar;

       
        public Dikdortgen2() // .Net 7 ile gelen özellik sayesinde struct içindeki constructor değer alabilir. yoksa alamazdı.
                             // Parametreli constructor alabilirdi veya düz constructor.
        {
            this.UzunKenar = 10;
            this.KisaKenar = 8;
        }
        public Dikdortgen2(int uzunkenar, int kisakenar)
        {
            this.UzunKenar = uzunkenar;
            this.KisaKenar = kisakenar;
        }
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }

}