using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Console.Classes
{
    public class RepeatGame
    {
        public void Repeat()
        {
            GameMove gameMove = new GameMove();
            SingleGame SingleGame = new SingleGame();
            bool single = SingleGame.Single();

            int countGame = 0;
            char charPlay1 = 'X', charPlay2 = 'O';

            string countWinPlayer1 = "", countWinPlayer2 = "";
            int intCountWinPlayer1 = 0, intCountWinPlayer2 = 0;
            
            while (true)
            {
                if (countGame > 0)
                {
                    Console.WriteLine("Do you want to play again? y/n");
                    countWinPlayer1 = $"[{intCountWinPlayer1}]";
                    countWinPlayer2 = $"[{intCountWinPlayer2}]";
                    char value = Console.ReadKey().KeyChar;

                    if (value == 'n' || value != 'y')
                    {
                        return;
                    }
                    else if (value == 'y' && countGame % 2 != 0)
                    {
                        charPlay1 = 'O';
                        charPlay2 = 'X';
                    }
                    else
                    {
                        charPlay1 = 'X';
                        charPlay2 = 'O';
                    }
                }
                
                switch(gameMove.Game(charPlay1, charPlay2, countWinPlayer1, countWinPlayer2, SingleGame, single))
                {
                    case 1:
                        ++intCountWinPlayer1;
                        break;
                    case 2:
                        ++intCountWinPlayer2;
                        break;
                }
                
                countGame++;
            }
        }
    }
}
