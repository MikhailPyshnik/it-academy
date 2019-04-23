using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Задайте размер (Больше 3!!) для массива типа int: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            if (arraySize <= 3)
            {
                PrintErrorMessage();
            }
            else
            {
                Console.WriteLine("*******************************************************************");
                Console.Write("Задайте минимальное число для Random: ");
                int minRandom = Convert.ToInt32(Console.ReadLine());
                Console.Write("Задайте  максимальное число для Random: ");
                int maxRandom = Convert.ToInt32(Console.ReadLine());
                Random rand = new Random();
                Console.WriteLine("*******************************************************************");
                int[] array = new int[arraySize];
                for (int i = 0; i < arraySize - 1; i++)
                {
                    array[i] = rand.Next(minRandom, maxRandom);
                }
                for (int i = 0; i < arraySize; i++)
                {
                    PrintArrayMessage(i, array);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*******************************************************************");
                Console.Write("Введите позицию в массиве от [0] до [{0}]: ", arraySize - 1);
                int arrayPosition = Convert.ToInt32(Console.ReadLine());
                if (arrayPosition > (arraySize - 1) || arrayPosition < 0)
                {
                    PrintErrorMessage();
                }
                else
                {
                    Console.Write("Введите число : ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("*******************************************************************");

                    for (int i = arraySize - 1; i > arrayPosition; i--)
                    {
                        array[i] = array[i - 1];
                    }

                    array[arrayPosition] = number;

                    for (int i = 0; i < arraySize; i++)
                    {
                         PrintArrayMessage( i, array);
                    }
                }
            }
                Console.ReadLine();
        }

        public static void PrintErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ввели недопустимое значение!");           
        }

        public static void PrintArrayMessage( int i, int[] array)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Вывод  массива array  позиция [{0}]: {1} ", i, array[i]);
        }
    }
}
