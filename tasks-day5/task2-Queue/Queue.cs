using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_Queue
{
    class Queue
    {
        int[] queue;
        int front;
        int rear;
        int size;
        public Queue(int _size =5)
        {
            size = _size;
            queue = new int[_size];
            front = 0;
            rear = -1;
        }
        public void Enqueue(int _num)
        {
            if(IsFull())
            {
                Console.WriteLine("queue Full!");
                return;
            }
            rear++;
            queue[rear] = _num;
            front++;
           
        }
        public void Dequeue()
        {
            if(IsEmpty())
            {
                Console.WriteLine("queue Empty!");
                return;
            }
            for (int i = 0; i < rear; i++)
            {
                queue[i] = queue[i + 1];
            }
            rear--;
            front--;


        }
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            return queue[0];
        }
        public void Display()
        {
            if(IsEmpty())
            {
                Console.WriteLine("queue Empty");
                return ;
            }
            for (int i = 0; i < front; i++)
            {
                Console.Write(queue[i] + " ");
            }
            Console.WriteLine();
        }
        public bool IsFull()
        {
            return front == size;
        }
        public bool IsEmpty()
        {
            return front == 0;
        }
    }
}


