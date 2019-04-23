using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
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
                Console.WriteLine("Исходный массив:");
                int[] array = new int[arraySize];
                for (int i = 0; i < arraySize; i++)
                {
                    array[i] = rand.Next(minRandom, maxRandom);
                    PrintArrayMessage(i, array);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*******************************************************************");
                Console.WriteLine("Реверс массива:");

                int[] arrayRevers = new int[arraySize];// Создаем массив для создания реверса массива. 

                for (int i = 0; i < arraySize; i++)
                    {
                     arrayRevers[i] = array[arraySize-1-i];
                     }
                array =  arrayRevers; // Присваиваем исходному массиву реверсивный массив. И выводи измененный массив.
                Console.WriteLine("*******************************************************************");
                for (int i = 0; i < arraySize; i++)
                {
                    PrintArrayMessage(i, arrayRevers);
                }
            }
            Console.ReadLine();
        }

        public static void PrintErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ввели недопустимое значение!");
        }

        public static void PrintArrayMessage(int i, int[] array)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Вывод  массива array  позиция [{0}]: {1} ", i, array[i]);
        }

    }
}
