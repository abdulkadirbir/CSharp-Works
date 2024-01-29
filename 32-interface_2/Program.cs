namespace _32_interface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.KacTekerlekli());
            Console.WriteLine(focus.MarkasiNe().ToString());
            Console.WriteLine(focus.RenkNe().ToString());

            Accent aksi = new Accent();
            Console.WriteLine(aksi.KacTekerlekli());
            Console.WriteLine(aksi.MarkasiNe().ToString());
            Console.WriteLine(aksi.RenkNe().ToString());
        }
    }
}