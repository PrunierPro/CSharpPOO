using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercice11
{

    internal class ArrayStack<T> : IStackable<T>
    {
        public T[] _elements;
        public int Count => _elements.Length;

        public ArrayStack()
        {
            _elements = new T[0];
        }

        public void Stack(T element)
        {
            Array.Resize<T>(ref _elements, Count + 1);
            _elements[Count - 1] = element;
        }

        public T Unstack()
        {
            if(Count <= 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }
            T res = _elements[Count - 1];
            Array.Resize<T>(ref _elements, Count - 1);
            return res;
        }

        public T UnstackAt(int index)
        {
            if(index <= 0 || index >= Count - 1)
            {
                throw new IndexOutOfRangeException("Index is out of the stack range.");
            }
            T res = _elements[index];
            T[] newElements = new T[Count - 1];
            Array.ConstrainedCopy(_elements, 0, newElements, 0, index);
            Array.ConstrainedCopy(_elements, index + 1, newElements, index, Count - index - 1);
            _elements = newElements;
            return res;
        }

        public override string ToString()
        {
            string res = "ArrayStack: ";
            foreach (T element in _elements)
            {
                res += $"\t- {element}\n";
            }
            return res.TrimEnd();
        }
    }
}
