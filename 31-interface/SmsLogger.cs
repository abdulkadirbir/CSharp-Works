using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_interface
{
    internal class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Sms e log yazar.");
        }
    }
}
