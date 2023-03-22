using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Console.Classes
{
    public class Product
    {
        public static int[] ReductionPrice(int oldWholeMoney, int oldCoins, int countWholeMoney, int countCoins)
        {
            if(oldCoins < countCoins && oldWholeMoney - 1 >= countWholeMoney)
            {
                oldWholeMoney -= 1;
                oldCoins = oldCoins + 100 - countCoins;
                oldWholeMoney -= countWholeMoney;
            }
            else if(oldWholeMoney < countWholeMoney)
            {
                throw new Exception("Помилка! Перевірте корректність написання даних");
            }
            else
            {
                oldWholeMoney -= countWholeMoney;
                oldCoins -= countCoins;
            }
            int[] arr = new int[2] { oldWholeMoney, oldCoins };
            return arr;
        }
    }
}
