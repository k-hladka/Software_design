using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Console.Classes
{
    public class Money
    {   
        private int wholeUSD;
        private int wholeEUR;
        private int wholeUAN;

        private int coinsUSD;
        private int coinsEUR;
        private int coinsUAN;

        public int WholeMoney { get; set;}
        public int Coins { get; set;}
        public Money(string currencyName, int wholeMoney, int coins)
        {
            this.WholeMoney = wholeMoney;
            this.Coins = coins;
            switch (currencyName)
            {
                case "USD":
                    this.wholeUSD = wholeMoney;
                    this.coinsUSD = coins;
                    break;
                case "EUR":
                    this.wholeEUR = wholeMoney;
                    this.coinsEUR = coins;
                    break;
                case "UAN":
                    this.wholeUAN = wholeMoney;
                    this.coinsUAN = coins;
                    break;
            }
        }

        public decimal Sum(Warehouse product) //This method implements the first prinsiple from SOLID. (S): Single Responsibility
        {
            decimal coinsInDecimal = product.Price.Coins / (decimal)Math.Pow(10, CountDigits(product.Price.Coins));
            decimal resultWholeMoney = (product.Price.WholeMoney + coinsInDecimal) * product.Count;

            int CountDigits(int number)
            {
                int count = 1;
                for (int i = 0; ; i++)
                {
                    if (number / 10 != 0)
                    {
                        number /= 10;
                        count++;
                    }
                    else
                        break;

                }
                return count;
            }

            return resultWholeMoney;
        }
    }
}
