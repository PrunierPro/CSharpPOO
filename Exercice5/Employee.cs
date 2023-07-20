using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5
{
    internal class Employee
    {
        private string _id;
        private string _service;
        private string _category;
        private string _name;
        private double _salary;
        private static int _employeeAmount = 0;
        private static double _totalSalary = 0;

        public string Id { get => _id; set => _id = value; }
        public string Service { get => _service; set => _service = value; }
        public string Category { get => _category; set => _category = value; }
        public string Name { get => _name; set => _name = value; }
        public double Salary { get => _salary; private set => _salary = value; }
        public static int EmployeeAmount { get => _employeeAmount; private set => _employeeAmount = value; }
        public static double TotalSalary { get => _totalSalary; private set => _totalSalary = value; }

        public Employee(string id, string service, string category, string name, double salary)
        {
            Id = id;
            Service = service;
            Category = category;
            Name = name;
            Salary = salary;
            EmployeeAmount++;
            TotalSalary += Salary;
        }

        public Employee()
        {
            new Employee("0000", "Default service", "Default category", "Default name", default);
        }

        public virtual string ShowSalary()
        {
            return $"{Name}'s salary is {Salary} euros";
        }

        public void UpdateSalary(double update) {
            TotalSalary -= Salary;
            Salary = update;
            TotalSalary += Salary;
            Console.WriteLine($"{Name}'s salary has been changed to {Salary} euros");
        }

        public void ShowTotalSalary()
        {
            Console.WriteLine($"The total amount of all salaries betzeen {EmployeeAmount} employees is {TotalSalary} euros");
        }

        public void ShowEmployeeAmount()
        {
            Console.WriteLine($"There are {EmployeeAmount} employees");
        }

        public void ResetEmployeeAmount()
        {
            EmployeeAmount = 0;
        }

        public void ResetTotalSalary()
        {
            TotalSalary = 0;
        }

        public override string ToString()
        {
            return $"{Name} is an Employee\n" + ShowSalary();
        }

    }
}
