using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    internal class Client
    {
        string _firstname;
        string _lastname;
        string _id;
        List<BankAccount> _accounts;

        public List<BankAccount> Accounts { get => _accounts; }

        public Client(string firstName, string lastName, string ID)
        {
            _firstname = firstName;
            _lastname = lastName;
            _id = ID;
            _accounts = new List<BankAccount>();
        }

        public void AddAccount(BankAccount account)
        {
            _accounts.Add(account);
        }

        public override string ToString()
        {
            return $"Client: Name = {_firstname} {_lastname} Id = {_id}";
        }
    }
}
