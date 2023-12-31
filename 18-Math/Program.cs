namespace _18_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Math
            Console.WriteLine("****** Math *******");
            Console.WriteLine(Math.Abs(-5)); // Mutlak değer +5
            Console.WriteLine("{0:F2}", Math.Sin(1));
            Console.WriteLine("{0:F2}", Math.Cos(1));
            Console.WriteLine("{0:F2}", Math.Tan(1));

            Console.WriteLine(Math.Ceiling(10.8));
            Console.WriteLine(Math.Round(10.8));
            Console.WriteLine(Math.Round(10.3));
            Console.WriteLine(Math.Floor(10.8));

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));

            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Pow(2,5));
        }
    }
}