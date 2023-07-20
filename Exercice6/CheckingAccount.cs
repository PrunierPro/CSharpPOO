using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    internal class CheckingAccount : BankAccount
    {
        public CheckingAccount(Client client) : base(client)
        {
            
        }
        public override string ToString()
        {
            return "Checking Account: " + base.ToString();
        }
    }
}
