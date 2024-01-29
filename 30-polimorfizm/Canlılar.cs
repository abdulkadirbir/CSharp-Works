using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_polimorfizm_
{
    internal sealed class Canlılar // Sealed ifadesi kalıtım veremediğini ifade eder.
    {
        public void Beslenme()
        {
            Console.WriteLine("Canlılar beslenme yapar.");
        }
        public void Solunum()
        {
            Console.WriteLine("Canlılar solunum yapar.");
        }
        public void Bosaltım()
        {
            Console.WriteLine("Canlılar boşaltım yapar.");
        }
        public virtual void UyaranlaraTepki() // Alt class larda da override edilebilir demek.
        { 
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }
    }
}
