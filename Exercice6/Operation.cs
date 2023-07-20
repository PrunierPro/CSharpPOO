using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    internal enum Status { ADD, RETRIEVE };
    internal class Operation
    {

        public Status Status { get; }
        public int Number { get; }
        public decimal Amount { get; }

        public Operation(int number, decimal amount, Status status)
        {
            Number = number;
            Amount = amount;
            Status = status;
        }

        public override string ToString()
        {
            return $"Number = {Number} Amount = {Amount} Status = {Status}";
        }
    }
}
