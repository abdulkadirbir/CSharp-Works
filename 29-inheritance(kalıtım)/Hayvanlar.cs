using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_inheritance_kalıtım_
{
    internal class Hayvanlar:Canlılar
    {
        public void Adaptasyon()
        {
            Console.WriteLine("Hayvanların adaptasyon yeteneği vardır.");
        }
    }
    class Surungunler:Hayvanlar
    {
        public void Surunmek()
        {
            Console.WriteLine("Sürüngen hayvanlar sürünür.");
        }
    }
    class Kuslar:Hayvanlar
    {
        public void Ucmak() 
        { 
            Console.WriteLine("Kuşlar uçar.");
        }
    }
}
