using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks_day5
{
    class MyDynamicStack
    {
        int[] arr;
        int size;
        int top;
        public MyDynamicStack()
        {
            size = 5;
            top = 0;
            arr = new int[size];
        }
        public MyDynamicStack(int _size)
        {
            size = _size;
            top = 0;
            arr = new int[size];
        }

        public void Push(int num)
        {
            if (!IsFull())
            {
                arr[top] = num;
                top++;
            }
            else
            {
                Console.WriteLine("stack is FULL");
            }

        }
        public int Pop()
        {
            int val = -1;
            if (!IsEmpty())
            {
                top--;
                val = arr[top];

            }
            else
            {
                Console.WriteLine("Stack is Empty");
            }
            return val;
        }
        public bool IsFull()
        {
            return top == size;
        }
        public bool IsEmpty()
        {
            return top == 0;
        }
    }
}
