using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    internal class Employee
    {
        private int _id;
        private string _service;
        private string _category;
        private string _name;
        private double _salary;
        private static int _employeeAmount = 0;
        private static double _totalSalary = 0;

        public int Id { get => _id; set => _id = value; }
        public string Service { get => _service; set => _service = value; }
        public string Category { get => _category; set => _category = value; }
        public string Name { get => _name; set => _name = value; }
        public double Salary { get => _salary; private set => _salary = value; }
        public static int EmployeeAmount { get => _employeeAmount; private set => _employeeAmount = value; }
        public static double TotalSalary { get => _totalSalary; private set => _totalSalary = value; }

        public Employee(int id, string service, string category, string name, double salary)
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
            Id = default;
            Service = "Default service";
            Category = "Default category";
            Name = "Default name";
            Salary = default;
            EmployeeAmount++;
            TotalSalary += Salary;
        }

        public void showSalary()
        {
            Console.WriteLine(this);
        }

        public void updateSalary(double update) {
            TotalSalary -= Salary;
            Salary = update;
            TotalSalary += Salary;
            Console.WriteLine($"{Name}'s salary has been changed to {Salary} euros");
        }

        public void showTotalSalary()
        {
            Console.WriteLine($"The total amount of all salaries betzeen {EmployeeAmount} employees is {TotalSalary} euros");
        }

        public void showEmployeeAmount()
        {
            Console.WriteLine($"There are {EmployeeAmount} employees");
        }

        public void resetEmployeeAmount()
        {
            EmployeeAmount = 0;
        }

        public void resetTotalSalary()
        {
            TotalSalary = 0;
        }

        public override string ToString()
        {
            return $"{Name}'s salary is {Salary} euros";
        }

    }
}
