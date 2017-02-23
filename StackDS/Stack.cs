using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDS
{
    class Stack<T> : IStack<T>
    {
        private int elementNumber { get; set; }
        private List<T> stack;

        public Stack()
        {
            elementNumber = 0;
            stack = new List<T>();
        }

        public T Pop()
        {
            if (elementNumber > 0)
            {
                T popedItem = stack[elementNumber - 1];
                stack.RemoveAt(elementNumber - 1);
                elementNumber--;
                return popedItem;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public T Peek()
        {
            if (elementNumber > 0)
            {
                return stack[elementNumber - 1];
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public void Push(T item)
        {
            stack.Add(item);
            elementNumber++;
        }

        public int Count()
        {
            return elementNumber;
        }
    }
}
