using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice11
{
    internal interface IStackable<T>
    {
        public void Stack(T element);

        public T Unstack();

        public T UnstackAt(int index);
    }
}
