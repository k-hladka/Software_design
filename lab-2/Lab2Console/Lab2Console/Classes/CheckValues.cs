using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Console.Classes
{
    public class CheckValues
    {
        public string[] Check(int intKey, char charKey, char[] symbols, char gameChar)
        {
            string[] res = new string[2];
            res[0] = "0";

            if (intKey == 0 && charKey == '0')
                res[1] = $"\nThere is no cell \"{intKey}\" on the field.";

            else if (intKey == 0 && charKey != '0')
                res[1] = "\nPlease enter a valid number between 1 and 9.";

            else
            {
                if (symbols[intKey - 1] != charKey)
                    res[1] = $"\nCell \"{intKey}\" is already set.";

                else
                {
                    res[0] = "1";
                    symbols[intKey - 1] = gameChar;
                    res[1] = Field.GetField(symbols).ToString();
                }
            }

            return res;
        }
    }
}
