using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5
{
    internal class Commercial : Employee
    {
        public double Earnings { get; private set; }
        public double CommissionPercent { get; private set; }

        public Commercial(string id, string service, string category, string name, double salary, double earnings, double percent) : base(id, service, category, name, salary)
        {
            Earnings = earnings;
            CommissionPercent = percent;
        }
        public Commercial()
        {
            new Commercial("0000", "Default service", "Default category", "Default name", default, default, default);
        }

        public override string ShowSalary()
        {

            return base.ShowSalary() + $"\n{Name}'s salary with commission is {Salary + (CommissionPercent / 100 * Salary)} euros";
        }

        public override string ToString()
        {
            return $"{Name} is a commercial\n" + ShowSalary();
        }
    }
}
