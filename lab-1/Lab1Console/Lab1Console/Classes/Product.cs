using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Console.Classes
{
    public class Product
    {
        public static void ReductionPrice(Money money, int countWholeMoney, int countCoins)
        {
            if(money.Coins<countCoins && money.WholeMoney - 1 >= countWholeMoney)
            {
                money.WholeMoney -= 1;
                money.Coins = money.Coins + 100 - countCoins;
                money.WholeMoney -= countWholeMoney;
            }
            else if(money.WholeMoney < countWholeMoney)
            {
                throw new Exception("Помилка! Перевірте корректність написання даних");
            }
            else
            {
                money.WholeMoney -= countWholeMoney;
                money.Coins -= countCoins;
            }
        }
    }
}
