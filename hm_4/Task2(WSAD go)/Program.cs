using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_WSAD_go_
{
    class Program
    {
        static void Main(string[] args)
        {   Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Убедитесь что включена !!!АНГЛИЙСКАЯ РАСКЛАДКА НА КЛАВИАТУРЕ!!!");
            Console.Write("Введите символ для перемещения (W-вверх /S-вниз/А-влево/D-вправо): ");
            char letter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine( "Вы ввели символ: " +letter);
           if (  letter == 'w' || letter== 'W')
                {
                 Console.WriteLine("Двигаемся вверх.");
                 }
           else if (  letter == 's' || letter== 'S')
                {
                 Console.WriteLine("Двигаемся вниз.");
                 }
            else if (  letter == 'a' || letter== 'A')
                {
                 Console.WriteLine("Двигаемся влево.");
                 }

            else if (  letter == 'd' || letter== 'D')
                {
                 Console.WriteLine("Двигаемся  вправо.");
                 }
            else
                 Console.WriteLine("Ввели что-то другое.");
           Console.ReadLine();
        }
    }
}
