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
            Console.WriteLine("Вывод английского алфавита в обратном порядке");
            char letter;
            int n = 26;
            for (int i = 122; i >= 97; i--)
            {
                letter = System.Convert.ToChar(i);
                Console.WriteLine("Всего 26 букв. Буквой № " +n + "  является " + letter);
                //mass[n] = ch;
                n--; 
            }
            Console.ReadLine();
            //Console.WriteLine("Всего 26 букв. Буквой № " + n  "является " + letter);
        }
    }
}
