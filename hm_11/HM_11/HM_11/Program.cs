using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_11
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository repository = new MotocycleRepository();

            Motorcycle Moto1 = new Motorcycle(1, "Honda", "Varadero", 2007, 41500);

            Motorcycle Moto2 = new Motorcycle(2, "Minsk", "D4", 2018, 0);

            Motorcycle Moto3 = new Motorcycle(3, "Yamaha", "V-Max", 2000, 52500);

            Motorcycle Moto4 = new Motorcycle(4, "Kawasaki", "ZZR", 1995, 24000);

            repository.CreateMotorcycle(Moto1);

            repository.CreateMotorcycle(Moto2);

            repository.CreateMotorcycle(Moto3);

            repository.CreateMotorcycle(Moto4);

            Console.WriteLine("Print GetMotorcycles info:");

            repository.GetMotorcycles().ForEach(Console.WriteLine);

            Console.WriteLine("Update Moto1 - Name: BMW");

            Moto1.Name = "BMW";

            repository.UpdateMotorcycle(Moto1);

            repository.GetMotorcycles().ForEach(Console.WriteLine);

            Console.WriteLine("GetMotorcycleByID = 2");

            Console.WriteLine(repository.GetMotorcycleByID(2));

            Console.WriteLine("Deleted Moto3");

            repository.DeleteMotorcycle(Moto3);

            repository.GetMotorcycles().ForEach(Console.WriteLine);

            Console.ReadLine();

        }
    }
}
