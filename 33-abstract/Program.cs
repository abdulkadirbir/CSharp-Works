namespace _33_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewFocus focus = new NewFocus();
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.HangiMarkaninAraci());
            Console.WriteLine(focus.StandartRengiNe());

            NewAccent accent = new NewAccent();
            Console.WriteLine(accent.KacTekerlektenOlusur());
            Console.WriteLine(accent.HangiMarkaninAraci());
            Console.WriteLine(accent.StandartRengiNe());
        }
    }
}