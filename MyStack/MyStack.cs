namespace MyStack
{
    public class MyStack
    {
        private int _top = 0;
        private int[] _stack;

        public MyStack(int size)
        {
            _stack = new int[size];
        }

        public int Pop()
        {
            if (_top <= 0)
            {
                throw new MyStackIsEmptyException("The stack is empty!");
            }
            
            // decrement 1 from top and return _stack[_top]
            return _stack[--_top];
        }

        public void Push(int element)
        {
            if (_top >= _stack.Length)
            {
                throw new MyStackIsFullException("The stack is full!");
            }


            // Add element to the array and then increment _top
            _stack[_top++] = element;            
        }
    }
}