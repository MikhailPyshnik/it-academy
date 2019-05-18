using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_11
{
    class Motorcycle
    {
        public  int Id { get; set; }
        public string  Name { get; set; }
        public string Model  { get; set; }
        public int  Year    { get; set; }
        public int  Odometer { get; set; }

        public Motorcycle()
        {
        }

        public Motorcycle(int Id, string Name, string Model, int Year, int Odometer)
        {
            this.Id = Id;
            this.Name = Name;
            this.Model = Model;
            this.Year = Year;
            this.Odometer = Odometer;
        }

        public override string ToString()
        {
            return $"ID: {Id}; Name {Name}; Model {Model}; Year {Year}; Odometer {Odometer}.";
        }
    }
}
