using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Console.Classes
{
    public class Reporting:Warehouse
    {
        //This class implements the third prinsiple from SOLID. (L): Liskov Substitution 
        private static int numberRevenueInvoice = 0;
        public Reporting(Warehouse product)
            : base(product.Name, product.UnitOfMeasurement, product.Price, product.Count, product.Date) { }

        public string RevenueInvoice(string fullNameSender, string fullNameReceiver)
        {
            numberRevenueInvoice += 1;
            return $"{Date} №{numberRevenueInvoice}\n" +
                $"-------------------------------\n" +
                $"Ім'я товару: {Name} \nОдиниця виміру: {UnitOfMeasurement} \nЦіна за 1 {UnitOfMeasurement}: {Price.WholeMoney}" +
                $",{Price.Coins} \nКількість: {Count} \nДата останнього завозу: {Date} \n" +
                $"-------------------------------\n" +
                $"Відправник: {fullNameSender}" +
                $"\nОтримувач: {fullNameReceiver}\n" +
                $"Загальна сума: {Price.Sum(this)}";
        }

        public string SalesInvoice(string fullNameSender, string fullNameReceiver)
        {
            return RevenueInvoice(fullNameSender, fullNameReceiver);
        }

        public string LeftoversOnWarehouse()
        {
            return $"{Name} - {Count}{UnitOfMeasurement}";
        }
    }
}
