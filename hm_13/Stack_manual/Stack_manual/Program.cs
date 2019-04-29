using Stack_manual.Extention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_manual
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StackManual st = new StackManual();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Stack capacity : {st.GetCount}");
                Console.WriteLine($"Is empty stack - {st.Empty}");

                //Заполняем стек 
                st.Push(1);
                st.Push(2);
                st.Push("sdsdsd");
                st.Push('g');
                st.Push("Vbif1");
                st.Push(5);
                st.Push("15");
                st.Push("Vbif2");
                st.Push("Vbif3");
                st.Push("Vbi22f");
                //Перезаполнение стека
                //st.Push("Vbi32f");
                //st.Push("sdsedserd");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Status after pushing stack: ");

                Console.WriteLine($"Stack capacity : {st.GetCount}");
                Console.WriteLine($"Is empty stack -{st.Empty}");
                Console.ResetColor();
                Console.WriteLine("Show the stack: ");

                st.ShowArray();
                Console.ForegroundColor = ConsoleColor.Green;
                var peek = st.Peek();
                Console.WriteLine($"Peek method execution: {peek}");
                Console.ResetColor();
                Console.WriteLine();

                var pop = st.Pop();
                //pop = st.Pop();
                //pop = st.Pop();
                //pop = st.Pop();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Pop method execution: {pop}");
                Console.ResetColor();
                Console.WriteLine();

                Console.WriteLine("Show the stack: ");
                st.ShowArray();

                st.CapacityString();

                Console.ForegroundColor = ConsoleColor.Green;
                StackGeneric<int> stackGeneric = new StackGeneric<int>();
                //Заполняем стек 
                stackGeneric.Push(1);
                stackGeneric.Push(2);
                stackGeneric.Push(3);
                stackGeneric.Push(4);
                stackGeneric.Push(5);
                stackGeneric.Push(6);
                stackGeneric.Push(7);
                stackGeneric.Push(8);
                stackGeneric.Push(9);
                stackGeneric.Push(10);
                //Перезаполнение стека
                //stackGeneric.Push(11);
                //stackGeneric.Push(12);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Status after pushing stackGeneric: ");

                Console.WriteLine($"StackGeneric capacity : {st.GetCount}");
                Console.WriteLine($"Is empty stackGeneric -{st.Empty}");
                Console.ResetColor();
                Console.WriteLine("Show the stackGeneric: ");

                Console.WriteLine();

                stackGeneric.ShowArray();
                Console.ForegroundColor = ConsoleColor.Green;
                var stackPeek = stackGeneric.Peek();
                Console.WriteLine($"Peek method execution: {stackPeek}.");
                Console.WriteLine();

                var stackPop = stackGeneric.Pop();
                //stackPop = stackGeneric.Pop();
                //stackPop = stackGeneric.Pop();

                Console.WriteLine($"Pop method execution: {stackPop}.");


                Console.WriteLine("Show the stack: ");
                stackGeneric.ShowArray();

                stackGeneric.CapacityString();
            }
            catch (InvalidOperationException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
