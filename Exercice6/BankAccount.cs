using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    internal abstract class BankAccount
    {
        protected decimal _money;
        protected Client _owner;
        protected List<Operation> _operations;

        protected BankAccount(Client client)
        {
            _money = 0;
            _owner = client;
            _operations = new List<Operation>();
        }
        public void AddMoney(decimal amount)
        {
            _money += amount;
            _operations.Add(new Operation(_operations.Count + 1, amount, Status.ADD));
        }

        public bool RetrieveMoney(decimal amount)
        {
            if(amount > _money)
            {
                return false;
            } else
            {
                _money -= amount;
                _operations.Add(new Operation(_operations.Count + 1, amount, Status.RETRIEVE));
                return true;
            }
        }

        public override string ToString()
        {
            return $"Money = {_money} Client = {_owner} {(_operations.Count != 0 ? "\n"+ShowOperations() : "")}";
        }

        public string ShowOperations()
        {
            string res = "";
            foreach(Operation o in _operations)
            {
                res += "\t- " + o + "\n";
            }
            return res.TrimEnd();
        }
    }
}
