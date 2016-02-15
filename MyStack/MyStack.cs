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

            _top--;

            var myPoppedItem = _stack[_top];
            
            return myPoppedItem;
        }

        public void Push(int element)
        {
            if (_top >= _stack.Length)
            {
                throw new MyStackIsFullException("The stack is full!");
            }

            _stack[_top] = element;

            _top++;
            
        }
    }
}