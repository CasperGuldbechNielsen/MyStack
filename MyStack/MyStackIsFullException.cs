using System;

namespace MyStack
{
    public class MyStackIsFullException : Exception
    {
        public MyStackIsFullException(string message) : base(message)
        {
            
        }
    }
}