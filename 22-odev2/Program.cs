using System.Collections;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace _22_odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////************************************************** SORU 1 ******************************************************
            ////Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
            ////(ArrayList sınıfını kullanara yazınız.)
            ////Negatif ve numeric olmayan girişleri engelleyin.
            ////Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            ////Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            //static bool asalmi(int sayi)
            //{
            //    bool sonuc = false;
            //    if (sayi == 1)
            //    {
            //        sonuc = false;
            //        return sonuc;
            //    }
            //    else if(sayi == 2)
            //    {
            //        sonuc = true;
            //        return sonuc;
            //    }
            //    else
            //    {
            //        for (int i = 2; i < sayi; i++)
            //        {

            //            if (sayi % i == 0 && sayi > 2)
            //            {
            //                sonuc = false;
            //                break;
            //            }
            //            else
            //                sonuc = true;
            //        }
            //    }
            //    return sonuc;

            //}

            //ArrayList asallar = new ArrayList();
            //ArrayList asalOlmayanlar = new ArrayList();
            //int sayi = 0;
            //Console.WriteLine("20 adet sayı gireceksiniz.");
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.Write("Lütfen {0}. sayıyı giriniz :" , i+1);
            //    try
            //    {
            //        sayi = Convert.ToInt32(Console.ReadLine());
            //        if (sayi <= 0)
            //        {
            //            Console.WriteLine("Sayı 0 dan büyük olmalıdır.");
            //            i--;
            //        }
            //        else if (asalmi(sayi))
            //            asallar.Add(sayi);
            //        else
            //            asalOlmayanlar.Add(sayi);

            //    }
            //    catch(Exception e) {
            //    Console.WriteLine (e.Message);
            //        i--;
            //    }

            //}
            //asallar.Sort();
            //asallar.Reverse();
            //asalOlmayanlar.Sort();
            //asalOlmayanlar.Reverse();
            //int toplamAsallar = 0;
            //int toplamAsalOlmayanlar = 0;
            //Console.WriteLine("Asal Olmayan Sayılar :");
            //foreach (int item in asalOlmayanlar)
            //{
            //    toplamAsalOlmayanlar = toplamAsalOlmayanlar + item;
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine("\nAsal Olan Sayılar :");
            //foreach (int item in asallar)
            //{
            //    toplamAsallar = toplamAsallar + item;
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine("\nAsal Olmayanların Sayısı ve Ortalaması : "+asalOlmayanlar.Count + " " + toplamAsalOlmayanlar / asalOlmayanlar.Count);
            //Console.WriteLine("\nAsal Olmayanların Sayısı ve Ortalaması : " + asallar.Count + " " + toplamAsallar / asallar.Count);










            // // **************************************************** SORU 2 ***************************************
            // // Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
            // // her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve
            // // ortalama toplamlarını console'a yazdıran programı yazınız.
            // // (Array sınıfını kullanarak yazınız.)

            // ArrayList arrayList = new ArrayList();
            // ArrayList enbuyukler = new ArrayList();
            // ArrayList enkucukler = new ArrayList();
            // int sayi = 0;
            // int enbuyuklerToplam = 0;
            // int enkucuklerToplam = 0;
            // for (int i=0; i<20; i++)
            // {
            //     Console.WriteLine("Lütfen {0}. sayıyı giriniz :", i + 1);
            //     sayi = Convert.ToInt32(Console.ReadLine()); 
            //     arrayList.Add(sayi);
            // }
            //arrayList.Sort();
            // foreach (int item in arrayList)
            // {
            //     if (enkucukler.Count < 3)
            //     {
            //         enkucukler.Add(item);
            //         enkucuklerToplam += item;
            //     }
            //     else
            //         break;

            // }
            // arrayList.Reverse();
            // foreach (int item in arrayList)
            // {
            //     if (enbuyukler.Count < 3)
            //     {
            //         enbuyukler.Add(item);
            //         enbuyuklerToplam += item;
            //     }
            //     else
            //         break;

            // }
            // Console.WriteLine("En büyük 3 sayının toplamı = {0} dır ve ortalaması = {1} dir.", enbuyuklerToplam, enbuyuklerToplam / enbuyukler.Count);
            // Console.WriteLine("En küçük 3 sayının toplamı = {0} dır ve ortalaması = {1} dir.", enkucuklerToplam, enkucuklerToplam / enkucukler.Count);













            //********************************************* SORU 3 *************************************************
            //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve
            //dizinin elemanlarını sıralayan programı yazınız.

            Console.WriteLine("Lütfen bir cümle giriniz : ");
            string cumle = Console.ReadLine();
            string sesliHarfler = "aeıioöuüAEIİOÖUÜ";
            ArrayList sesliler =  new ArrayList();

            for(int i = 0; i < cumle.Length; i++)
            {
                for(int j=0; j< sesliHarfler.Length; j++)
                {
                    if (cumle[i].Equals(sesliHarfler[j]) )
                    {
                        sesliler.Add(cumle[i]);
                    }
                }
                
            }
            foreach (var item in sesliler)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            sesliler.Sort();
            foreach (var item in sesliler)
            {
                Console.Write(item + " ");
            }
            

        }
    }
}