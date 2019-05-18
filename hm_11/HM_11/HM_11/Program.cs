using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace HM_11
{
    class Program
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            log4net.Config.DOMConfigurator.Configure();

            log.Info("Starts Application.");

            IRepository repository = new MotocycleRepository();

            Motorcycle Moto1 = new Motorcycle(1, "Honda", "Varadero", 2007, 41500);

            Motorcycle Moto2 = new Motorcycle(2, "Minsk", "D4", 2018, 0);

            Motorcycle Moto3 = new Motorcycle(3, "Yamaha", "V-Max", 2000, 52500);

            Motorcycle Moto4 = new Motorcycle(4, "Kawasaki", "ZZR", 1995, 24000);

            repository.CreateMotorcycle(Moto1);

            repository.CreateMotorcycle(Moto2);

            repository.CreateMotorcycle(Moto3);

            repository.CreateMotorcycle(Moto4);

            log.Info("Get all motorcycles:");

            List<Motorcycle> allMotorcycles = repository.GetMotorcycles();

            foreach (var motorcycle in allMotorcycles)
            {
                log.Info(motorcycle);
            }

            ColorMessagePrint("Print GetMotorcycles info:");

            repository.GetMotorcycles().ForEach(Console.WriteLine);

            ColorMessagePrint("Update Moto1 - Name: BMW");

            Moto1.Name = "BMW";

            repository.UpdateMotorcycle(Moto1);

            log.Info($"Cnahge name {Moto1}");

            repository.GetMotorcycles().ForEach(Console.WriteLine);

            ColorMessagePrint("GetMotorcycleByID = 3");

            Console.WriteLine(repository.GetMotorcycleByID(3));

            log.Info($"GetMotorcycleByID = 3 : {Moto3}");

            ColorMessagePrint("Deleted Moto3");

            repository.DeleteMotorcycle(Moto3);

            log.Info($"Delete moto3: {Moto3}");

            repository.GetMotorcycles().ForEach(Console.WriteLine);

            Console.ReadLine();
        }

        static void ColorMessagePrint(string str)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n{0,50}", str);
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
