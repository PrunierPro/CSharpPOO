using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercice5
{
    internal static class IHM
    {
        private static List<Employee> _employees = new List<Employee>();

        public static void Start()
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            Console.WriteLine("===== Employee management =====\n");
            Console.WriteLine("1-- Add an employee");
            Console.WriteLine("2-- Show the salary of all employees");
            Console.WriteLine("3-- Search for an employee");
            Console.WriteLine("0-- Quit\n");
            Console.Write("Make your choice : ");
            string choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                case "1":
                    AddEmployeeMenu();
                    break;
                case "2":
                    ShowAllSalaries();
                    break;
                case "3":
                    EmployeeSearchMenu();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Not a valid choice!");
                    MainMenu();
                    break;
            }
        }

        private static void AddEmployeeMenu()
        {
            Console.WriteLine("=== Add an Employee ===");
            Console.WriteLine("1-- Employee");
            Console.WriteLine("2-- Commercial");
            Console.WriteLine("0-- Back\n");
            Console.Write("Make your choice : ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                case "2":
                    Console.Write("Please enter a name: ");
                    string name = Console.ReadLine();
                    Console.Write("Please enter an ID: ");
                    string id = Console.ReadLine();
                    Console.Write("Please enter a category: ");
                    string category = Console.ReadLine();
                    Console.Write("Please enter a service: ");
                    string service = Console.ReadLine();
                    Console.Write("Please enter a salary: ");
                    double salary = InputControlDouble();
                    if (choice.Equals("2"))
                    {
                        Console.Write("Please enter an earning number: ");
                        double earnings = InputControlDouble();
                        Console.Write("Please enter the commission percentage: ");
                        double percent = InputControlDouble();
                        _employees.Add(new Commercial(id, service, category, name, salary, earnings, percent));
                    }
                    else _employees.Add(new Employee(id, service, category, name, salary));
                    MainMenu();
                    break;
                case "0":
                    Console.Clear();
                    MainMenu();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Not a valid choice!");
                    AddEmployeeMenu();
                    break;
            }
        }

        private static void ShowAllSalaries()
        {
            Console.WriteLine("==== Salaries of employees ====");
            foreach (Employee e in _employees)
            {
                Console.WriteLine("----------");
                Console.WriteLine(e);
                Console.WriteLine("----------");
            }
            Console.WriteLine($"The total salary among {Employee.EmployeeAmount} employees is {Employee.TotalSalary} euros");
            MainMenu();
        }

        private static void EmployeeSearchMenu()
        {
            Console.WriteLine("==== Employee search by name ====");
            Console.Write("Please enter the name of an employee: ");
            Employee employee = EmployeeSearch(Console.ReadLine());
            Console.WriteLine(employee is not null ? employee : "We could not find anyone matching that name, sorry.");
            MainMenu();
        }

        private static Employee EmployeeSearch(string prompt)
        {
            Regex rgx = new Regex($"({prompt})");
            Employee res = null;
            foreach(Employee e in _employees)
            {
                if (rgx.IsMatch(e.Name)) res = e;
            }
            return res;
        }

        private static double InputControlDouble()
        {
            double res;
            while(!double.TryParse(Console.ReadLine(), out res) || res < 0)
            {
                Console.Write("You must enter a positive number: ");
            }
            return res;
        }
    }
}
