using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static int CountheResult(int a, int b)
        {
            return a + b;
        }

        public static void ValidateSum(int a, int b, int expectedSum)
        {
            int actualSum = CountheResult(a, b);
            if (expectedSum != actualSum)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильный ответ!!!");
                Console.ForegroundColor = ConsoleColor.White;
                if (expectedSum < actualSum)
                { 
                    Console.WriteLine("Должно быть больше.");
                }
                else
                {
                    Console.WriteLine("Должно быть меньше.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Правильный ответ! Результат операции: {0}", actualSum);
            }
        }

        public static void Main(string[] args)
        {
            int firstInt, secondInt, answer;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Ввведите первое число:  ");
            firstInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ввведите второе число:  ");
            secondInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ожидаемый результат:  ");
            answer = Convert.ToInt32(Console.ReadLine());
            ValidateSum(firstInt, secondInt, answer);
            Console.ReadKey();
        }
    }
}
