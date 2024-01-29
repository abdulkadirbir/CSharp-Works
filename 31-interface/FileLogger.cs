using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_interface
{
    internal class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Dosyaya log yazar.");
        }
        public FileLogger() {
            Console.WriteLine("FileLogger parametresiz constructor çalıştı.");
        }
    }
}
