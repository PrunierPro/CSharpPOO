using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice11
{
    internal class Pile<T>
    {
        public List<T> Elements { get; }
        public int Count => Elements.Count;

        public Pile()
        {
            Elements = new List<T>();
        }

        public void Add(T element)
        {
            Elements.Add(element);
        }

        public T Remove()
        {
            return RemoveAt(Elements.Count - 1);
        }

        public T RemoveAt(int index)
        {
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
