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
            PrintStartMessage();                                  
            string str1 = Console.ReadLine();                       //Чтение введенной строки.
            string[] breakLine = str1.Split(new Char[] {' '});      //Разбиваем  строку с консоли  на массив  строк  по символу - пробел.
            if (str1.Length <= 1 || breakLine.Length <= 1)
            {
                PrintErrorMessage();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;

                RemoveLongWord(breakLine);

                ChangeArrayLongAndShotrWord(breakLine);

                CountLettersAndPunktuation(str1); 
    
                ChangeArraySort(breakLine);

                Console.ReadLine();
            }
        }

        static void PrintStartMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nВведите строку символов: ");
        }                           // Выводим на экран начальные сообщение.

        static void PrintErrorMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ввели один символ или одно слово!!! ");
            Console.ReadLine();
        }                           // Выводим на экран сообщение, если ввели 1 слово или 1 символ.

        static int MaxLenghtWord(string[] array)
        {
            string[] resultArray = new string[array.Length];
            int maxLengs = array[0].Length;
            for (int i = 1; i < array.Length; i++) // т.к. мы присваевыем по умолчанию 0 значение в начале праметр.
            {
                if (array[i].Length >= maxLengs)
                {
                    maxLengs = array[i].Length;
                }
            }
            return maxLengs;
        }                  // Находим длинну самого длинного слова.

        static int MinLenghtWord(string[] array)
        {
            string[] resultArray = new string[array.Length];
            int minLengs = array[0].Length;
            for (int i = 1; i < array.Length; i++) // т.к. мы присваевыем по умолчанию 0 значение в начале праметр.
            {
                if (array[i].Length <= minLengs)
                {
                    minLengs = array[i].Length;
                }
            }
            return minLengs;
        }                  // Находим длинну самого короткого слова.

        static void RemoveLongWord(string[] array)
        {
            int minLengs =  MinLenghtWord (array);
            int maxLengs =  MaxLenghtWord (array);

            string[] resultArray = new string [array.Length];

            int indexMaxLenght = 0;
            for (int i = 0;  i < array.Length; i++)
            {
                if (array[i].Length != maxLengs)
                {
                    resultArray[indexMaxLenght] = array[i];
                    indexMaxLenght++;
                }
            }
             Console.WriteLine( $"\nНовая строка без длинного(ых) слова : {String.Join(" ", resultArray)}");
        }                // Удаляем самые длинные (длинное) слова в строке.

        static void ChangeArrayLongAndShotrWord(string[] array)
        {
            int minLengs = MinLenghtWord(array);
            int maxLengs = MaxLenghtWord(array);

            string[] resultArray = array;

            for (int i = 0; i < array.Length; i++) // проходим по массиву с первого слова до последнего
            {
                if (array[i].Length == maxLengs) // если длинна слова равна максимальной
                {
                    for (int j = i + 1; j < array.Length; j++)// если длинна слова максимальная, ищим слово с минимальной длинной
                    {
                        if (array[j].Length == minLengs)
                        {
                            string strMin = array[j];
                            string strMax = array[i];
                            resultArray[i] = strMin;
                            resultArray[j] = strMax;
                            i = j;
                            j = array.Length;  // чтобы выйти из массива for (j)
                        }
                        else if (array[j].Length == maxLengs)// если еще есть слово с длинной максимальной то выходим из цикла
                        {
                            j = array.Length;  // чтобы выйти из массива for (j)
                        }
                    }
                }
                else if (array[i].Length == minLengs)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j].Length == maxLengs)
                        {
                            string strMin = array[i];
                            string strMax = array[j];
                            resultArray[j] = strMin;
                            resultArray[i] = strMax;
                            i = j;
                            j = array.Length;  // чтобы выйти из массива for (j)
                        }
                        else if (array[j].Length == minLengs)
                        {
                            j = array.Length;  // чтобы выйти из массива for (j)
                        }

                    }
                }
            }
            Console.WriteLine($"\nИзмененный массив, замена коротких слов длинными : {String.Join(" ", resultArray)} ");
        }   // Меняем местами длинные и короткие слова парами.

        static void CountLettersAndPunktuation(string str) 
        {
            int Punktuation = 0;
            int Letter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                //Letter = str.Count(Char.IsLetter);
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= 'а' && str[i] <= 'я') || (str[i] >= 'А' && str[i] <= 'Я'))
                Letter++;

                Punktuation = str.Count(Char.IsPunctuation);
            }
            Console.WriteLine("\nКол-во букв в введенной  стоке : " + Letter);
            Console.WriteLine("\nКол-во знаков припинания в введенной  стоке : " + Punktuation );
        }       // Подсчет кол-ва букв в строке и кол-ва знаков препинания.

        static void ChangeArraySort(string[] array)
        {
            int minLengs = MinLenghtWord(array);
            int maxLengs = MaxLenghtWord(array);

            string[] resultArray = new string[array.Length];

            int indexChangeArray = 0;

            for (int i = maxLengs; i >= minLengs; i--)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j].Length == i)
                    {
                        resultArray[indexChangeArray] = array[j];
                        indexChangeArray++;
                    }
                }
            }
            Console.WriteLine($"\nИзмененный массив, отсортирован по убыванию: {String.Join(" ", resultArray)} \n");
        }               // Сортитируем массив строк по убыванию и выводим измененный массив строкой.

    }
}