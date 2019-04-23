using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_05_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Задайте размер для массива типа int: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*******************************************************************");
            Console.Write("Задайте минимальное число для Random: ");
            int minRandom = Convert.ToInt32(Console.ReadLine());
            Console.Write("Задайте  максимальное число для Random: ");
            int maxRandom = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("Заполните массив из {0} элементов типа int:", arraySize);
            Console.WriteLine("*******************************************************************");
            int[] arrayInput = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Введите значение для {0} элемента массива из {1} типа int : ", i, arraySize);
                arrayInput[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] arrayRandom = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                arrayRandom[i] = rand.Next(minRandom, maxRandom);
            }
            Console.WriteLine("*******************************************************************");
            int[] arrayOutput = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                arrayOutput[i] = arrayRandom[i]+ arrayInput[i];
            }
            for (int i = 0; i < arraySize; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Вывод cуммы элемента {0} массивов arrayInput и arrayRandom: ", i);
                Console.WriteLine(arrayOutput[i]);
            }
            Console.ReadLine();
        }
    }
}


