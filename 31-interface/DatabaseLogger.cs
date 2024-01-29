using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_interface
{
    internal class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Database' e log yazar.");
        }
        public DatabaseLogger(string a)
        {
            a = "DatabaseLogger parametreli constructor çalıştı.";
            Console.WriteLine(a);
        }

    }
}
