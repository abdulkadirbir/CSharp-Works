using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_interface_2
{
    internal class Focus : IOtomobil
    {
        public int KacTekerlekli()
        {
            return 4;
        }

        public Marka MarkasiNe()
        {
            return Marka.Ford;
        }

        public Renk RenkNe()
        {
            return Renk.Lacivert;
        }
    }
}
