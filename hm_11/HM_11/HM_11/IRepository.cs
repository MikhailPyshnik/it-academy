using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_11
{
    interface IRepository
    {
        Motorcycle GetMotorcycleByID(int Id);
        List<Motorcycle> GetMotorcycles();
        void CreateMotorcycle(Motorcycle moto);
        void UpdateMotorcycle(Motorcycle moto);
        void DeleteMotorcycle(Motorcycle moto);
    }
}
