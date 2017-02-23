using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackDS
{
    interface IStack<T>
    {
        T Pop();

        T Peek();

        int Count();

        void Push(T item);
    }
}
