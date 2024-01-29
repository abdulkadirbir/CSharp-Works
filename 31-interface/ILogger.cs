using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_interface
{
    internal interface ILogger
    {
        void WriteLog()
        {
            Console.WriteLine("ILogger içindeki writelogger methodudur.");
        }
    }
}
