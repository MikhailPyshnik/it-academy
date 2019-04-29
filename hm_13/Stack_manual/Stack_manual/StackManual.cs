using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_manual
{
    public sealed class  StackManual : IStack
    {
        public static int maxLength = 10;

        private object[] stackManual = new object[maxLength];

        private int count = 0;

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

        public void Push(object value)
        {
            if (maxLength > count)
            {
                stackManual[index] = value;       
                count++;
                index++;
                if (count == 10)
                { index = 9; }
            }
            else
            {
                throw new InvalidOperationException("Stack is full!");
            }
        }

        public object Pop()
        {
            if (Empty)
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            else
            {
                object item = stackManual[index];
                stackManual[index] = null;
                --index;
                return item;
            }
        }

        public object Peek()
        {
             return stackManual[index];
        }

        public void ShowArray() // Print array 
        {
            for (int i = 0; i <= index; i++)
            {
                Console.WriteLine($"Value {i}: {stackManual[i]}");
            }
        }
    }
}
