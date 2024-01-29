using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_interface_2
{
    internal class Accent : IOtomobil
    {
        public int KacTekerlekli()
        {
            return 4;
        }

        public Marka MarkasiNe()
        {
            return Marka.Hyundai;
        }

        public Renk RenkNe()
        {
            return Renk.Siyah;
        }
    }
}
