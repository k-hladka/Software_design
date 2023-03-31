
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Console.Classes
{
    public class SingleGame
    {
       public bool Single()
        {
            Console.WriteLine("Choose game mode (s)single/(p)pair:");
            char singleGame = Console.ReadKey().KeyChar;
            if (singleGame == 's')
                return true;
            return false;
        }
        public char BotMove(char[] symbols, char symbolBot, char symbolPlayer)
        {
            if (symbols[4] == '5')
                return '5';

            char resSymbol = ' ';

            for (int i = 1; i < symbols.Length; i += 2) // 1 3 5 7
                if (symbols[i] == i + 49)
                {
                    if (i + 1 < symbols.Length && symbols[i + 1] != symbolPlayer)
                        resSymbol = (char)(i + 49);
                    if (i + 2 < symbols.Length && symbols[i + 2] != symbolPlayer)
                        resSymbol = (char)(i + 49);
                }

            for (int i=0; i<symbols.Length; i+=2) // 0 2 6 8
            {
                if (i == 4)
                    continue;
                if (symbols[i] == i + 49)
                    return (char)(i + 49);
            }

            
            return resSymbol;
        }
    }
}
