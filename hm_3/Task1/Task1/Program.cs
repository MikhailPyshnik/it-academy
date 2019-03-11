using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {

        public static int CountheResult(int a, int b)
        {
             return a + b;
        }

        static void Main(string[] args)
        {
            int firstInt, secondInt;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Ввведите первое число:  ");
            firstInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ввведите второе число:  ");
            secondInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат операции: {0}", CountheResult(firstInt, secondInt));
            Console.ReadKey();
        }
    }
}
