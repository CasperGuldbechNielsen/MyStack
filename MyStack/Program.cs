using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack MyStack = new MyStack(5);

            try
            {
                MyStack.Push(1);
                MyStack.Push(2);
                MyStack.Push(3);
                MyStack.Push(4);
                MyStack.Push(5);
                MyStack.Push(6);
            }
            catch (MyStackIsFullException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine(MyStack.Pop());
                Console.WriteLine(MyStack.Pop());
                Console.WriteLine(MyStack.Pop());
                Console.WriteLine(MyStack.Pop());
                Console.WriteLine(MyStack.Pop());
                Console.WriteLine(MyStack.Pop());
            }
            catch (MyStackIsEmptyException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();

        }
    }
}
