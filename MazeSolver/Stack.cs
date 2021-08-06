using System;
namespace MazeSolver
{
    class MyStack<T>
    {
        private T[] objects;
        private int top;
        private int depth;
        public MyStack(int depth)
        {
            objects = new T[depth];
            top = 0;
            this.depth = depth;
        }

        public void Push(T s)
        {

            if (top == depth)
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                objects[top] = s;
                top++;
            }


        }

        public T Pop()
        {

            if (top == 0)
            {
                Console.WriteLine("Invalid");
                return default;
            }
            else
            {
                top--;
                return objects[top];
            }

        }

        public int getDepth()
        {
            return depth;
        }

        public int getTop()
        {
            return top;
        }
    }
}
