using System;

namespace Day_7_task
{
    internal class Stack
    {
        private  int[] Stack_arr = new int[0];
        public void Push(int x)
        {
            int count = Stack_arr.Length;
            int[] newArray = new int[count + 1];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = Stack_arr[i];
            }
            newArray[count] = x;
            Stack_arr = newArray;
        }
        public int Pop()
        {
            int count = Stack_arr.Length;
            if (count == 0)
                throw new Exception("Stack is Empty");

            int x = Stack_arr[count - 1];
            int[] newArray = new int[count - 1];
            for (int i = 0; i < count - 1; i++)
            {
                newArray[i] = Stack_arr[i];
            }
            Stack_arr = newArray;
            return x;
        }
        public int Peek()
        {
            int count = Stack_arr.Length;
            if (count == 0)
                throw new Exception("Stack is Empty");

            return Stack_arr[count - 1];
        }
    }
}
