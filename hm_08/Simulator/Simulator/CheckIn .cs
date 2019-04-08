using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    class CheckIn
    {
        public int HourAviaTimeDeparture;
        public bool AvailabilityPassport;
        public bool elRegistration;
        public bool elRegistrationTicket;
        public CheckIn()
        {

        }

        public CheckIn( int aHourAviaTimeDeparture, bool aAvailabilityPassport)
        {
         HourAviaTimeDeparture = aHourAviaTimeDeparture;
         AvailabilityPassport= aAvailabilityPassport;
        }

        public CheckIn(int aHourAviaTimeDeparture, bool aelRegistration, bool aAvailabilityPassport, bool aelRegistrationTicket)
        {
            HourAviaTimeDeparture = aHourAviaTimeDeparture;
            AvailabilityPassport = aAvailabilityPassport;
            elRegistration = aelRegistration;
            elRegistrationTicket = aelRegistrationTicket;

        }

        public void Registration (int aHourAviaTimeDeparture,  bool aAvailabilityPassport)
        {
            string timeNow = DateTime.Now.ToString("HH");
            int time = Convert.ToInt32(timeNow);
            if (time > 20 && time <=24 && aHourAviaTimeDeparture> 0 && aHourAviaTimeDeparture < 4)
            {
                time = 0;
                aHourAviaTimeDeparture = 2;
            }
            int timeRes = aHourAviaTimeDeparture - time;

            if (timeRes > 1)
            {
                Console.WriteLine("Пожалуйста, регистрируйтесь.");
                if (aAvailabilityPassport == true)
                {
                    Console.WriteLine("Вот ваш посадочный талон.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Извините, регистрация на рейс закончилась. Вы не успели.");
            }
        }

        public bool Registration (int aHourAviaTimeDeparture, bool aAvailabilityPassport, string a, string b)
        {
            string timeNow = DateTime.Now.ToString("HH");
            int time = Convert.ToInt32(timeNow);
            if (time > 20 && time <= 24 && aHourAviaTimeDeparture > 0 && aHourAviaTimeDeparture < 4)
            {
                time = 0;
                aHourAviaTimeDeparture = 2;
            }
            int timeRes = aHourAviaTimeDeparture - time;
            if (timeRes > 1 && aAvailabilityPassport == true)
            {
                Console.WriteLine($"{a} {b} проходите дальше. Не задерживайтесь.");
            return true;
            }
            else
            return false;
        }

         public void Registration (int aHourAviaTimeDeparture, bool aelRegistration, bool aAvailabilityPassport, bool aelRegistrationTicket)
         {
            string timeNow = DateTime.Now.ToString("HH");
            int time = Convert.ToInt32(timeNow);
            if (time > 20 && time <= 24 && aHourAviaTimeDeparture > 0 && aHourAviaTimeDeparture < 4)
            {
                time = 0;
                aHourAviaTimeDeparture =2;
            }
            int timeRes = aHourAviaTimeDeparture - time;
            if (timeRes > 1)
            {
                if (aelRegistrationTicket == true && aAvailabilityPassport == true &&  timeRes > 1)
                {
                    Console.WriteLine("Все в порядке.");
                }
                else if (aelRegistrationTicket == false && aAvailabilityPassport == true)
                {
                    Console.WriteLine("Предоставьте паспорт.Посадочный талон сейчас вам распечатаем.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Извините, регистрация на рейс закончилась!");
            }
         }
    }
}
