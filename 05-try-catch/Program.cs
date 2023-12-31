namespace _5_try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Lütfen Bir Sayi Giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine()); // Doğrudan Console.ReadLine() ifadesi de kullanılabilirdi.
                Console.WriteLine("Girdiğiniz sayi : " + sayi);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("İşlem Başarıyla Gerçekleşmiştir.");
            }

            try // İlk gördüğü try bloğunun içindeki kod çalışacaktır. O yüzden diğerleri pass geçilecektir.
            {
                //int a = int.Parse(null); // ArgumentNullException
                // int b = int.Parse("test"); // FormatException
                // int c = int.Parse("20000000000"); //OverflowException
                int d = int.Parse("15");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Boş değer girildi.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Yanlış veri tipi girildi.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Çok büyük ya da çok küçük değer girildi.");
                Console.WriteLine(ex);
            }
        }
    }
}