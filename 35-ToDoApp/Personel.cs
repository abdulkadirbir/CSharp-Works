using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_ToDoApp
{
    internal class Personel
    {
        private string name;
        private string surName;
        private int ID;

        public string Name { get => name; set => name = value; }
        public string SurName { get => surName; set => surName = value; }
        public int id { get => ID; set => ID = value; }

        public Personel() { }
        public Personel(string name, string surName, int id)
        {
            Name = name;
            SurName = surName;
            this.id = id;    
        }
        public Personel(string name,int id)
        {
            Name = name;
            this.id = id;
        }
    }
}
