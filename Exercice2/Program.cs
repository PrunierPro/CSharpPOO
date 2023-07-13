namespace Exercice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "Service", "Category", "Employee1", 10000);
            e1.resetEmployeeAmount();
            Employee e2 = new Employee(2, "Service", "Category", "Employee2", 15000);
            e2.resetTotalSalary();
            Employee e3 = new Employee(3, "Service", "Category", "Employee3", 20000);
            e1.showSalary();
            e2.showSalary();
            e3.showSalary();
            e1.showEmployeeAmount();
            e2.showTotalSalary();
            e1.updateSalary(55555);
            e3.showTotalSalary();
        }
    }
}