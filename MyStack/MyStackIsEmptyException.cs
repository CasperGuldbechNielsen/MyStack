using System;

namespace MyStack
{
    public class MyStackIsEmptyException : Exception
    {
        public MyStackIsEmptyException(string message) : base(message)
        {
            
        }
    }
}