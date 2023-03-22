using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Console.Classes
{
    public class Warehouse 
    {
        //This class implements:
        //(S): Single Responsibility
        //and
        //(D): Dependency Inversion
        public string Name { get; set;}
        public string UnitOfMeasurement { get; set;}
        public IMoney Price { get; set;}
        public int Count { get; set;}
        public string Date { get; set; }

        public Warehouse(string Name, string UnitOfMeasurement, IMoney Price, int Count, string Date)
        {
            this.Name = Name;
            this.UnitOfMeasurement = UnitOfMeasurement;
            this.Price = Price;
            this.Count = Count;
            this.Date = Date;
        }
    }
}
