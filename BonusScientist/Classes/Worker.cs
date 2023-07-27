using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScientist.Classes
{
    internal class Worker : Person
    {
        protected string _companyname;
        protected string _companyaddress;
        protected string _workphone;

        public Worker(string lastname, string firstname, string phonenumber, string email, string companyname = "Company Corp", string address = "Default", string workphone = "0000000") : base(lastname, firstname,phonenumber, email)
        {
            _companyname = companyname;
            _companyaddress = address;
            _workphone = workphone;
        }

        public override string ToString()
        {
            return "(Worker) " + base.ToString() + $"Company : {_companyname} Address : {_companyaddress} Work phone: {_workphone} ";
        }
    }
}
