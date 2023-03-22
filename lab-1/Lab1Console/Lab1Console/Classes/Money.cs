using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Console.Classes
{
    public class Money : IMoney
    {
        private int wholeUSD;
        private int wholeEUR;
        private int wholeUAN;

        private int coinsUSD;
        private int coinsEUR;
        private int coinsUAN;
        public int WholeMoney { get; set; }
        public int Coins { get; set; }
        public void AddUSD(int wholeUSD, int coinsUSD)
        {
            this.wholeUSD = wholeUSD;
            this.coinsUSD = coinsUSD;
            addValuesInProperties(wholeUSD, coinsUSD);
        }
        public void AddEUR(int wholeEUR, int coinsEUR)
        {
            this.wholeEUR = wholeEUR;
            this.coinsEUR = coinsEUR;
            addValuesInProperties(wholeEUR, coinsEUR);
        }
        public void AddUAN(int wholeUAN, int coinsUAN)
        {
            this.wholeUAN = wholeUAN;
            this.coinsUAN = coinsUAN;
            addValuesInProperties(wholeUAN, coinsUAN);
        }

        private void addValuesInProperties(int whole, int coins)
        {
            this.WholeMoney = whole;
            this.Coins = coins;
        }

        public decimal Sum(int count)
        {
            decimal coinsInDecimal = this.Coins / (decimal)Math.Pow(10, CountDigits(this.Coins));
            decimal resultWholeMoney = (this.WholeMoney + coinsInDecimal) * count;

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
