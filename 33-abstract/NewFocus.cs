using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_abstract
{
    internal class NewFocus:Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Ford;
        }
        public override Renk StandartRengiNe()
        {
            return Renk.Lacivert;
        }
    }
}
