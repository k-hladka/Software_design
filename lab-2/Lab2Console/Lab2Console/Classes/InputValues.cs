using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Console.Classes
{
    public class InputValues
    {
        public object[] Input()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            char charKey = keyInfo.KeyChar;
            int.TryParse(charKey.ToString(), out int intKey);

            object[] arr = new object[2] { intKey, charKey };
            return arr;
        }
    }
}


