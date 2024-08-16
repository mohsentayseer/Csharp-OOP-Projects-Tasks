using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_circularQueue
{
    internal class CircularQueue
    {
        int[] queue;
        int front;
        int rear;
        int size;
        int count;
        public CircularQueue(int _size = 5)
        {
            size = _size;
            queue = new int[_size];
            front = 0;
            rear = -1;
            count = 0;
        }
        public void Enqueue(int _num)
        {
            if (IsFull())
            {
                Console.WriteLine("queue Full!");
                return;
            }
            rear = (rear + 1) % size;//(rear + 1) % size ensures that if rear is 4, it wraps around to index 0 (because (4 + 1) % 5 = 0).
            queue[rear] = _num;
            count++;
        }
        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("queue Empty!");
                return;
            }
            front = (front + 1) % size;
            count--;
        }
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            return queue[front];
        }
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("queue Empty");
                return;
            }
            int current = front;
            for (int i = 0; i < count; i++)
            {
                Console.Write(queue[current] + " ");
                current = (current + 1) % size;
            }
            Console.WriteLine();
        }
        public bool IsFull()
        {
            return count == size;
        }
        public bool IsEmpty()
        {
            return count == 0;
        }
    }
}
