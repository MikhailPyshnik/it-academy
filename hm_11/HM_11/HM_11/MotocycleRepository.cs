using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using log4net.Config;


namespace HM_11
{
     class MotocycleRepository : IRepository 
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(MotocycleRepository));

        static List<Motorcycle> motorcycles = new List<Motorcycle>();

        public void CreateMotorcycle(Motorcycle moto)
        {
            motorcycles.Add(moto);
        }

        public void DeleteMotorcycle(Motorcycle moto)
        {
            motorcycles.Remove(moto);
        }

        public Motorcycle GetMotorcycleByID(int Id)
        {
            Motorcycle result = null;

            foreach (var moto in motorcycles)
            {
                if (Id == moto.Id) 
                {
                    result = moto;
                }
            }
            if (result == null)
            {
                log.Error("Alarm!!!Parameter Id is not valid");
            }
            return result;
        }

        public List<Motorcycle> GetMotorcycles()
        {
            return motorcycles; 
        }

        public void UpdateMotorcycle(Motorcycle moto)
        {
            int index = 0;

            for (int i = 0; i < motorcycles.Capacity; i++)
            {
                Motorcycle motorcycle = motorcycles.ElementAt(i);

                if (moto == motorcycle)
                {
                    index = i;
                    break;
                }
            }
            motorcycles.ElementAt(index).Id = moto.Id;
            motorcycles.ElementAt(index).Name = moto.Name;
            motorcycles.ElementAt(index).Model = moto.Model;
            motorcycles.ElementAt(index).Year = moto.Year;
            motorcycles.ElementAt(index).Odometer = moto.Odometer;
        }
     }
}
