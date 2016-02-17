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
            MyStack<int> myIntStack = new MyStack<int>(5);

            try
            {
                myIntStack.Push(1);
                myIntStack.Push(2);
                myIntStack.Push(3);
                myIntStack.Push(4);
                myIntStack.Push(5);
                myIntStack.Push(6);
            }
            catch (MyStackIsFullException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine(myIntStack.Pop());
                Console.WriteLine(myIntStack.Pop());
                Console.WriteLine(myIntStack.Pop());
                Console.WriteLine(myIntStack.Pop());
                Console.WriteLine(myIntStack.Pop());
                Console.WriteLine(myIntStack.Pop());
            }
            catch (MyStackIsEmptyException e)
            {
                Console.WriteLine(e.Message);
            }

            MyStack<Circle> myCircleStack = new MyStack<Circle>(5);


            try
            {
                myCircleStack.Push(new Circle(5));
                myCircleStack.Push(new Circle(3));
                myCircleStack.Push(new Circle(2));
            }
            catch (MyStackIsFullException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                var c = myCircleStack.Pop();
                Console.WriteLine(c);
                Console.WriteLine(myCircleStack.Pop());
                Console.WriteLine(myCircleStack.Pop());
            }
            catch (MyStackIsEmptyException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();

        }
    }
}
