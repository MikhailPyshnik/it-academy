using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_alphabet_
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Вывод  букв английского алфавита в обратном порядке");
            Console.WriteLine("Убедитесь что включена !!!АНГЛИЙСКАЯ РАСКЛАДКА НА КЛАВИАТУРЕ!!!");
            Console.Write("Введите первую букву английского языка a-z:  ");
            char firstletter = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите вторую букву английского языка a-z:  ");
            char secondletter = Convert.ToChar(Console.ReadLine());
            int firstInt = (int)firstletter;
            int secondInt = (int)secondletter;
            if (97 <= firstInt & firstInt <= 122 & 97 <= secondInt & secondInt <= 122)
            {
                if (firstInt < secondInt)
                {
                    char letter;
                    int numberletter = secondInt - firstInt + 1;
                    int countletter = numberletter;
                    for (int i = secondInt; i >= firstInt; i--)
                    {
                        letter = System.Convert.ToChar(i);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Выбрано " + countletter + " букв(ы). Буквой № " + numberletter + "  является " + letter);
                        numberletter--;
                    }
                }
                else if (firstInt == secondInt)
                   { 
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Ввели  две одинаковые буквы: первую букву- " + firstletter + " и вторую букву- " + secondletter + "!");
                   }
            else
              {
                char letter;
                int numberletter = firstInt - secondInt + 1;
                int countletter = numberletter;
                for (int i = firstInt; i >= secondInt; i--)
                {
                    letter = System.Convert.ToChar(i);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Выбрано " + countletter + " букв(ы). Буквой № " + numberletter + "  является " + letter);
                    numberletter--;
                }
              }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ввели неправильную букву(ы) из вариантов a-z !!!!");
            }
            Console.ReadLine();
        }
    }
}
