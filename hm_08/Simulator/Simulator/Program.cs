using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string timeNow = DateTime.Now.ToString("HH");
            int time = Convert.ToInt32(timeNow);

            ConfigConsoleStartMessage();
        
            Console.Write("\nВаше Имя: ");
            string firstName = Console.ReadLine();

            Console.Write("Ваше фамилия: ");
            string secondName = Console.ReadLine();

            Console.Write($"У вас {firstName } {secondName } электронная регистрация (Y/N)?: ");
            char elRegistration = Convert.ToChar(Console.ReadLine());

            bool belRegistration;
            if (elRegistration == 'Y' | elRegistration == 'y')
            { belRegistration = true; }
            else
            { belRegistration = false;}
            
            Console.Write($"Пройдите пожалуйста {firstName } {secondName } к стойке регистрация. Предъявите паспорт (Y/N): ");
            char availabilityPassport = Convert.ToChar(Console.ReadLine());

            bool bAvailabilityPassport;
            if (availabilityPassport == 'Y' | availabilityPassport == 'y')
            {

                bAvailabilityPassport = true;

                Console.Write("Час вылета рейчас (0-24): ");
                int hourAviaTimedeparture = Convert.ToInt32(Console.ReadLine());

                if (elRegistration == 'Y' | elRegistration == 'y')
                {
                    Console.Write($"У вас {firstName } {secondName } электронная билет (Y/N)?: ");
                    char elRegistrationTicket = Convert.ToChar(Console.ReadLine());

                    bool belRegistrationTicket;
                    if (elRegistrationTicket == 'Y' | elRegistrationTicket == 'y')
                    { belRegistrationTicket = true; }
                    else
                    { belRegistrationTicket = false; }

                    CheckIn checkIn1 = new CheckIn(hourAviaTimedeparture, belRegistration, bAvailabilityPassport, belRegistrationTicket);
                    checkIn1.Registration(hourAviaTimedeparture, belRegistration, bAvailabilityPassport, belRegistrationTicket);
                }
                else
                {
                    CheckIn checkIn2 = new CheckIn(hourAviaTimedeparture, bAvailabilityPassport);
                    checkIn2.Registration(hourAviaTimedeparture, bAvailabilityPassport);
                }
                CheckIn checkIn = new CheckIn(hourAviaTimedeparture, bAvailabilityPassport);

                if (checkIn.Registration(hourAviaTimedeparture, bAvailabilityPassport, firstName, secondName) == true)
                {

                    Console.Write("Рейс Low Coast (Y/N): ");
                    char lowCoast = Convert.ToChar(Console.ReadLine());

                    bool blowCoast;
                    if (lowCoast == 'Y'| lowCoast == 'y')
                    { blowCoast = true; }
                    else
                    { blowCoast = false; }

                    Console.Write("Вес вашего багажа (в кг) (если нет - 0): ");
                    int baggagerShow = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Объем жидкости в ручной глади (в миллилитрах) (если нет - 0): ");
                    int waterShow = Convert.ToInt32(Console.ReadLine());
                    if (waterShow > 0)
                    {
                        SecurityCheck securityCheck = new SecurityCheck(baggagerShow, blowCoast, waterShow);
                        securityCheck.SecurityResult(baggagerShow, waterShow, blowCoast);
                    }
                    else
                    {
                        SecurityCheck securityCheck = new SecurityCheck(baggagerShow, blowCoast);
                        securityCheck.SecurityResult(baggagerShow);
                    }

                    Console.Write($"У вас {firstName } {secondName } есть запрещенные к провозу вещи в ручной клади (ножницы, спички,зажишалка и т.д.) (Y/N): ");
                    char dangerous = Convert.ToChar(Console.ReadLine());

                    bool bdangerous;
                    if (dangerous == 'Y'| dangerous == 'y')
                    { bdangerous = true; }
                    else
                    { bdangerous = false; }
                    SecurityCheck securityCheck1 = new SecurityCheck(bdangerous);


                    if (securityCheck1.SecurityResult(bdangerous) == true)
                    {
                        Console.Write("Регион назначения: СНГ(1), Европа(2), Америка(3), Африка(4), Азия(5): ");
                        int сountryofСonsignment = Convert.ToInt32(Console.ReadLine());
                        if (сountryofСonsignment < 6 && сountryofСonsignment > 0)
                        {
                            if (сountryofСonsignment == 2 | сountryofСonsignment == 3 | сountryofСonsignment == 4 | сountryofСonsignment == 5)
                            {
                                Console.Write("Наличие визы (Y/N): ");
                                char visa = Convert.ToChar(Console.ReadLine());

                                bool bvisa;
                                if (visa == 'Y'| visa == 'y')
                                { bvisa = true; }
                                else
                                { bvisa = false; }

                                Console.Write("Год действия паспорта: ");
                                int yaerAddPasport = Convert.ToInt32(Console.ReadLine());

                                PassportControll passportControll = new PassportControll(bvisa, yaerAddPasport);
                                passportControll.ControllPassport(yaerAddPasport, bvisa);

                                if (passportControll.ControllPassportTrue(yaerAddPasport, bvisa) == true)
                                {
                                    Console.Write("Есть товар подлежащий декларации (Y/N): ");
                                    char declaration = Convert.ToChar(Console.ReadLine());

                                    bool bdeclaration;
                                    if (declaration == 'Y'| declaration == 'y')
                                    { bdeclaration = true;

                                        Console.Write("Задекларировали товар (Y/N): ");
                                        char declarationAll = Convert.ToChar(Console.ReadLine());

                                        bool bdeclarationAll;
                                        if (declarationAll == 'Y'| declarationAll == 'y')
                                        { bdeclarationAll = false;

                                            Console.WriteLine($"{firstName } {secondName } все в порядке. Счастливого пути!");
                                            Console.ReadLine();
                                        }                                     
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine($"Вы {firstName } {secondName } не задекларировали багаж.Повторите регистрацию снова.");
                                            Console.ReadLine();
                                        }
                                    }
                                    else
                                        Console.WriteLine($"{firstName } {secondName } все в порядке. Счастливого пути!");
                                        Console.ReadLine();
                                }
                                else
                                    Console.ReadLine();
                            }

                            else if (сountryofСonsignment == 1)
                            {
                                Console.Write("Год выдачи паспорта: ");
                                int yaerAddPasport = Convert.ToInt32(Console.ReadLine());
                                PassportControll passportControll = new PassportControll(yaerAddPasport);

                                if (passportControll.ControllPassportTrue(yaerAddPasport) == true)
                                {
                                    Console.Write("Есть товар подлежащий декларации (Y/N): ");
                                    char declaration = Convert.ToChar(Console.ReadLine());

                                    bool bdeclaration;
                                    if (declaration == 'Y'| declaration == 'y')
                                    { bdeclaration = true;
                                        Console.Write("Задекларировали товар (Y/N): ");
                                        char declarationAll = Convert.ToChar(Console.ReadLine());

                                        bool bdeclarationAll;
                                        if (declarationAll == 'Y'| declarationAll == 'y')
                                        { bdeclarationAll = false;

                                            Console.WriteLine($"{firstName } {secondName } все в порядке. Счастливого пути!");
                                            Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine($"Вы {firstName } {secondName } не задекларировали багаж.Повторите регистрацию снова.");
                                            Console.ReadLine();
                                        }
                                    }
                                    else
                                        Console.WriteLine($"{firstName } {secondName } все в порядке. Счастливого пути!");
                                        Console.ReadLine();
                                }
                                else
                                    Console.ReadLine();
                            }
                           
                        }
                          else
                          {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{firstName } {secondName } ввели неверный регион назначения.Пройдите регистрацию снова.");
                            Console.ReadLine();
                          }
                    }
                       else
                       {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"У вас {firstName } {secondName } имеются запрещенные вещи. Избавьтесь от вещей и повторите регистрацию снова.");
                        Console.ReadLine();
                       }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{firstName } {secondName } приезжайте в следующий раз в аэропорт заранее!!");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Без паспорта {firstName } {secondName }  лететь нельзя!!");
                Console.ReadLine();
            }
        }

        static void ConfigConsoleStartMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            string helloString = "Вас приветсвтует аэропорт Минск-2. Добро пожаловать!!!";
            int indent = (Console.WindowWidth - helloString.Length) / 2; //длина отступа
  
            helloString = helloString.PadLeft(helloString.Length + indent, '\0'); //центр выравнивание

            Console.WriteLine(helloString);

            string Day = ($"Текущая дата:  { DateTime.Now.ToString("D")}");
            string Time = ($"Текущий час:  { DateTime.Now.ToString("HH:m")}");

            Day = Day.PadLeft(Day.Length + (Console.WindowWidth - Day.Length) / 2, '\0'); //центр выравнивание
            Time = Time.PadLeft(Time.Length + (Console.WindowWidth - Time.Length) / 2, '\0'); //центр выравнивание

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Day);
            Console.WriteLine(Time);
            Console.ForegroundColor = ConsoleColor.Green;
            string start = "Представьтесь пожалуйста!";
            start = start.PadLeft(start.Length + (Console.WindowWidth - start.Length) / 2, '\0'); //центр выравнивание
            Console.WriteLine();
            Console.WriteLine(start);
        }
    }
}
