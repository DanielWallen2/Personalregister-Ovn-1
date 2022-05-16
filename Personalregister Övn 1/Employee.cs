using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister_Övn_1
{
    internal class Employee
    {
        private string name;
        private uint wage;

        internal Employee(string Name, uint Wage) 
        {
            this.name = Name;
            this.wage = Wage;
        }

        public string Name
        {
            get { return name; }
        }

        public uint Wage
        {
            get { return wage; }
        }

    }
}
