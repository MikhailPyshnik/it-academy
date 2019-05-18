using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_manual
{
    public sealed class StackGeneric<T> : IStackDeneric<T>
    {
        public static int maxLength = 10;

        private T[] stackManual = new T[10];

        private int count=0;

        private int index = 0;

        public bool Empty
        {
            get { return index == 0; }
        }

        public int GetCount
        {
            get { return count; }
        }

        public int GetIndex
        {
            get { return index; }
        }

        public int Lenght
        {
            get { return maxLength; }
        }     

        public void Push(T value) // Add elemet type T in array
        {
            if (maxLength > count)
            {
                stackManual[index] = value;
                count++;
                index++;
                if (count == 10)
                {
                    index = 9;
                }
            }
            else
            {
                throw new InvalidOperationException("StackGeneric is full!");
            }
            
        }

        public T Pop()
        {
            if (Empty)
            {
                throw new InvalidOperationException("StackGeneric is empty!");
            }
            else
            {
                T item = stackManual[index];
                stackManual[index] = default(T);
                --index;
                return item;
            }
        }

        public T Peek()
        {
            return stackManual[index];
        }

        public void ShowArray()
        {
            for (int i = 0; i <= index; i++)
            {
                Console.WriteLine($"Value {i}: {stackManual[i]}");
            }
        }
    }
}
