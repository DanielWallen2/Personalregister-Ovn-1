using System;

namespace Personalregister_Övn_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Staff employeeList = new Staff();
            string choise;

            do
            {
                DisplayMenu();

                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        {
                            AddEmployee(employeeList);
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Payroll: ");
                            Console.WriteLine("Name\tWage");
                            employeeList.PrintPayRoll();
                            break;
                        }
                    case "q":
                        {
                            Console.WriteLine("Quiting...");
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Input!");
                            break;
                        }
                }

            }while (true);

            void DisplayMenu()
            {
                Console.WriteLine("Choose:");
                Console.WriteLine(" 1 to add new employee");
                Console.WriteLine(" 2 to list payroll");
                Console.WriteLine(" q to quit");
            }
        }

        private static void AddEmployee(Staff employeeList)
        {
            string name = "";
            uint wage = 0;
            bool successName = false;
            bool successWage = false;

            do
            {
                Console.Write("Input Name: ");
                name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name)) { successName = true; }
                else { Console.WriteLine("You must enter a valid name."); }
            } while (!successName);

            do
            {
                Console.Write("Input wage: ");
                string sWage = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(sWage))
                {
                    if(uint.TryParse(sWage, out uint result))
                    {
                        wage = result;
                        successWage = true;
                    }
                    else { Console.WriteLine("You must enter a valid wage."); }

                }
                else { Console.WriteLine("You must enter a valid wage."); }

            } while (!successWage);

            Employee employee = new Employee(name, wage);
            employeeList.AddEmployee(employee);

        }
    }
}
