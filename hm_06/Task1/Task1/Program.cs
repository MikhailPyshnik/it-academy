using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                PrintStartMessage();

                string str1 = Console.ReadLine();
                string str2 = str1.Replace("а", "о").Replace("А", "О").Replace("a", "o").Replace("A", "O");//Заменяем русские и английские буквы (учитываем 2 раскладки). Стихотворение может быть русским и английским. 
                string[] breakLine = str2.Split(new Char[] { ';' });// Разбиваем  строку с консоли  на массив  строк  по символу ; . 
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < breakLine.Length; i++)
                {    
                    Console.WriteLine("\n{0,70}", breakLine[i]);// Выводи строку и выравниваем по правому краю. 
                }

                Console.ReadLine();
 
                PrintDoMessage();
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        static void PrintDoMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"Выберите действия: 
             - Нажмите ESC для выхода; 
             - Нажмите любую другую клавишу чтоб продолжить");
        } // Выводим экран действия

        static void PrintStartMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Ввод стихотворений с клавиатуры \n");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Введите текст стихотворения (Русский  и Английский язык), \nиспользуя для разделения cимвол -;\nа конец стихотворения обозначьте точкой.\n");
            Console.Write("Ваше стихотворение: ");
        } // Выводим начальное сообщение
    }
}