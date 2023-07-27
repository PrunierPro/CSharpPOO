using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScientist.Classes
{
    internal abstract class Person
    {
        protected string _lastname;
        protected string _firstname;
        protected string _phonenumber;
        protected string _email;

        public Person(string lastname = "Default", string firstname = "Default", string phonenumber = "0000000000", string email = "default@email.com")
        {
            _lastname = lastname;
            _firstname = firstname;
            _phonenumber = phonenumber;
            _email = email;
        }

        public override string ToString()
        {
            return $"Person: Name: {_firstname} {_lastname} Phone: {_phonenumber} Email: {_email} ";
        }
    }
}
