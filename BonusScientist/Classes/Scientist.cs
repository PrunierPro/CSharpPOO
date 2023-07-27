using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScientist.Classes
{
    enum Discipline
    {
        PHYSICS,
        CHEMISTRY,
        MATHEMATICS
    }

    enum Type
    {
        THEORIST,
        EXPERIMENTAL,
        COMPUTER_SCIENTIST
    }
    internal class Scientist : Worker
    {

        protected List<Discipline> _fields = new List<Discipline>();
        protected List<Type> _types = new List<Type>();

        public Scientist(string lastname, string firstname, string phonenumber, string email, string companyname, string address, string workphone, Discipline field, Type type) : base(lastname, firstname, phonenumber, email, companyname, address, workphone)
        {
            _fields.Add(field);
            _types.Add(type);
        }

        public override string ToString()
        {
            return "(Scientist) " + base.ToString() + $"Fields: {string.Join(",", _fields)} Types: {string.Join(",", _types)}";
        }
    }
}
