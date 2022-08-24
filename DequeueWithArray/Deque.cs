using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DequeueWithArray
{
    public class Deque
    {
        public int[] queue;
        public int size;
        public int startFront;
        public int startRear;
        public int endFront;
        public int endRear;

        public Deque(int sizeOfQueue)
        {
            size = sizeOfQueue;
            queue = new int[sizeOfQueue];
            startFront = -1;
            startRear = -1;
            endFront = sizeOfQueue;
            endRear = sizeOfQueue;
        }

        public void StartEnqueue(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("The queue is full!");

            }
            else
            {
                startRear++;
                queue[startRear] = item;
            }
        }

        public void EndEnqueue(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("The queue is full!");
            }
            else
            {
                endRear--;
                queue[endRear] = item;
            }
        }

        public void StartDequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty!");
            }
            else
            {
                startFront++;
                Console.WriteLine(queue[startFront]);
            }
        }

        public void EndDequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty!");

            }
            else
            {
                endFront--;
                Console.WriteLine(queue[endFront]);
            }
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty!");
            }
            else
            {
                for (int i = startFront + 1; i <= startRear; i++)
                {
                    Console.WriteLine(queue[i]);
                }

                for (int i = endFront - 1; i >= endRear; i--)
                {
                    Console.WriteLine(queue[i]);
                }
            }
        }

        public bool IsEmpty()
        {
            if (startFront == startRear && endFront == endRear)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFull()
        {
            if (startRear + 1 == endRear)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
