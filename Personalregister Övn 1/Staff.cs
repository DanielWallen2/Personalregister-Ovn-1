using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister_Övn_1
{
    internal class Staff
    {
        private List<Employee> employees;

        internal Staff()
        {
            employees = new List<Employee>();
        }

        internal void AddEmployee(Employee Employee)
        {
            employees.Add(Employee);
        }

        internal void PrintPayRoll()
        {
            foreach (Employee Employee in employees)
            {
                Console.WriteLine($"{Employee.Name}\t{Employee.Wage}");
            }
        }
    }
}
