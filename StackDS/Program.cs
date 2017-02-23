using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            var count = stack.Count();
            stack.Pop();
            var peek = stack.Peek();
            count = stack.Count();
            stack.Push("d");


        }
    }
}
