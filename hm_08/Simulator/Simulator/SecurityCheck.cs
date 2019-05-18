using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    class SecurityCheck
    {
        public int Weight { get; set; }
        public bool LowCoast { get; set; }
        public bool Dangerous { get; set; }
        public readonly int WeightBaggage = 23;
        public readonly int WeightBaggageLowCost = 10;
        const int WaterMax = 100;
        public int Water { get; set; }


        public SecurityCheck()
        {
        }

        public SecurityCheck( bool dangerous)
        {
            Dangerous = dangerous;
        } 

        public SecurityCheck(int aWeight, bool aLowCoast)
        {
            Weight = aWeight;
            LowCoast = aLowCoast;
        }

        public SecurityCheck(int aWeight, bool aLowCoast, int aWater)
        {
            Weight = aWeight;
            LowCoast = aLowCoast;
            Water = aWater;
        }

        public SecurityCheck(int aWeight, int aWater)
        {
            Weight = aWeight;
            Water = aWater;
        }

        public void SecurityResult (int weight, bool lowCoast)
        {
            int weighLowCost = WeightBaggageLowCost- weight;
            if (lowCoast = true && weighLowCost > 8 )
            { Console.WriteLine("Маленький вес. Пожалуйста, возьмите в ручную кладь."); }

            else if (weight > WeightBaggageLowCost)
            {
                Console.WriteLine($"Ваш багаж {weight} весит свыше {WeightBaggageLowCost}. Необходимо доплатить.Деньги спишем с вашей карточки.");
            }
            else if (weight==0)
            {
                Console.WriteLine(" Совсем на легкe)).");
            }
            else 
            {
                Console.WriteLine("Вес вашего багажа в норме.Поставьте чемодан на ленту транспортера.");
            }
        }

        public void SecurityResult(int weight, int water, bool lowCoast)
        {
            int weighLowCost = WeightBaggageLowCost - weight;
            if (lowCoast = true && weighLowCost > 8)
            { Console.WriteLine("Маленький вес. Пожалуйста возьмите в ручную кладь."); }

            else if (weight > WeightBaggageLowCost)
            {
                Console.WriteLine($"Ваш багаж {weight} весит свыше {WeightBaggageLowCost}. Необходимо доплатить.Деньги спишем с вашей карточки.");
            }
            else if (weight == 0)
            {
                Console.WriteLine(" Совсем на легкe)).");
            }
             else
            {
                Console.WriteLine("Вес вашего багажа в норме.Поставьте чемодан на ленту транспортера.");
            }

            if (water > WaterMax)
            {
                Console.WriteLine($"Лишнюю жидкость конфискуем. Пожалуйста выбросьте. Купите себе в Dute Free.");
            }
            else
                Console.WriteLine("Кол-во жидкости  не превышает норму.");
        }

        public void SecurityResult(int weight)
        {
            if (weight > WeightBaggage)
            {
                Console.WriteLine($"Ваш багаж {weight} весит свыше {WeightBaggage}. Необходимо доплатить.Деньги спишем с вашей карточки.");
            }
            else if (weight == 0)
            {
                Console.WriteLine(" Совсем на легкe)).");
            }

            else
                Console.WriteLine("Вес вашего багажа в норме.Поставьте чемодан на ленту транспортера.");
        }

        public bool SecurityResult (bool dangerous)
        {
            if (dangerous==false)
            {
                Console.WriteLine("Все в порядке. Пожалуйста, проходите на паспортный контроль.");
                return true;
            }
            else
                return false;
        }
    }
}
