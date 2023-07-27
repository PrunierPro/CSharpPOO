using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice11
{
    internal class Pile<T> : IStackable<T>
    {
        public List<T> Elements { get; }
        public int Count => Elements.Count;

        public Pile()
        {
            Elements = new List<T>();
        }

        public void Stack(T element)
        {
            Elements.Add(element);
        }

        public T Unstack()
        {
            if (Count <= 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }
            return UnstackAt(Elements.Count - 1);
        }

        public T UnstackAt(int index)
        {
            if (index <= 0 || index >= Count - 1)
            {
                throw new IndexOutOfRangeException("Index is out of the stack range.");
            }
            T res = Elements.ElementAt(index);
            Elements.RemoveAt(index);
            return res;
        }

        public override string ToString()
        {
            string res = "Pile: ";
            foreach(T element in Elements)
            {
                res += $"\t- {element}\n";
            }
            return res.TrimEnd();
        }
    }
}
