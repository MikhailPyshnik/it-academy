using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        public static int CountheResult(int a, int b, string operation)
        {
            if (operation == "+")
            { return a + b; }
            else
            { return a - b; }
        }

        public static void ValidateSum(int a, int b, int expectedSum, string operation)
        {
            int actualSum = CountheResult(a, b, operation);
            if (expectedSum != actualSum)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильный ответ!!!");
                Console.WriteLine("Результат операции: {0}", actualSum);
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
                Console.WriteLine("Правильный ответ!");
                Console.WriteLine("Результат операции: {0}", actualSum);
            }
        }

        public static void Main(string[] args)
        {
            int firstInt, secondInt, answer;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Ввведите первое число:  ");
            firstInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите оператор + / - : ");
            string selectionoperation = Convert.ToString(Console.ReadLine());
            Console.Write("Ввведите второе число:  ");
            secondInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ожидаемый результат:  ");
            answer = Convert.ToInt32(Console.ReadLine());
            ValidateSum(firstInt, secondInt, answer, selectionoperation);
            Console.ReadKey();
        }
    }
}
