namespace _17_datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Datetime.Now
            Console.WriteLine("********* Datetime Now ************");
            Console.WriteLine(DateTime.DaysInMonth(2023,12));
            Console.WriteLine(DateTime.Now); // Bugünün tarihini getirir.
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(5));
            Console.WriteLine(DateTime.Now.AddHours(5));
            Console.WriteLine(DateTime.Now.AddMicroseconds(50));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));
            Console.WriteLine(DateTime.Now.AddMinutes(15));
            Console.WriteLine(DateTime.Now.AddMonths(1));
            Console.WriteLine(DateTime.Now.AddYears(10));

            //Datetime Format
            Console.WriteLine("*********** Datetime Format ***********");
            Console.WriteLine(DateTime.Now.ToString("dd")); //24
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Paz
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Pazar

            Console.WriteLine(DateTime.Now.ToString("MM"));//12
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Ara
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//Aralık

            Console.WriteLine(DateTime.Now.ToString("yy")); //23
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2023

            




        }
    }
}