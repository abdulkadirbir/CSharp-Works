using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_abstract
{
    internal class NewAccent:Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Hyundai;
        }
    }
}
