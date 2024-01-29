using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_inheritance_kalıtım_
{
    internal class Bitkiler:Canlılar
    {
        protected void Fotosentez()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }
        
    }
    class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler()
        {
            base.Fotosentez(); // Constructor ile de erişilebilir. İlk nesne oluşturulduğunda çağrılır.
        }
        public void TohumluBitkiler2()
        {
            base.Fotosentez(); // protected olduğu için sadece bu şekilde erişilebilir.Public bir method ile.
        }
        public void TohumluCogalma() {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
        }
        
        
       
    }
    class TohumsuzBitkiler:Bitkiler
    {
        public void TohumsuzCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
        }
    }
}
