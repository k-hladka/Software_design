using Lab2Console.Classes.PrintData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Console.Classes
{
    public class GameMove
    {
        internal string Text { get; set; }
        public int Game(char symbolPlayer1, char symbolPlayer2, string countWinPlayer1, string countWinPlayer2, SingleGame SingleGame, bool single)
        {
            IPrint consolePrint = new ConsolePrint();
            IPrint consoleYellowPrint = new ConsoleYellowPrint();
            InputValues InputValues = new InputValues();
            CheckValues CheckValues = new CheckValues();
            Win Win = new Win();
            char[] symbols = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            

            char symbolForPlayer;
            int countMove = 0;
            int countSuccessfulMove = 0;
            int countUnsuccessfulMove = 0;

            object[] inputValues = new object[2];

            int ascii = 0;

            Console.Clear();
            while (true)
            {
                if (countUnsuccessfulMove == 0)
                {
                    this.Text = $"Let's play Tic Tac Toe!\n" +
                        $"Player 1: {symbolPlayer1}{countWinPlayer1}\n" +
                        $"Player 2: {symbolPlayer2}{countWinPlayer2}" +
                        $"\n\nPlayer 1's turn. Select from 1 to 9 from the game board.\n" +
                        $"{Field.GetField(symbols).ToString()}";
                    Print(consolePrint);
                }

                if (countSuccessfulMove > 4)
                {
                    var win = Win.CheckWin(symbols, symbolPlayer1, symbolPlayer2);
                    if (win[0] != "0")
                    {
                        this.Text = win[1];
                        Print(consoleYellowPrint);

                        switch (win[0])
                        {
                            case "1":
                                return 1;
                            case "2": return 2;
                        }
                        return 12;
                    }
                }

                symbolForPlayer = (countSuccessfulMove % 2 == 0) ? symbolPlayer1 : symbolPlayer2;

                if (((countSuccessfulMove % 2 == 0 && single) || (countUnsuccessfulMove != 0)) || (!single))
                {
                    ascii = 0;
                    inputValues = InputValues.Input();
                }

                else if(countUnsuccessfulMove == 0)
                {
                    ascii = 48;
                    inputValues[1] = inputValues[0] = SingleGame.BotMove(symbols, symbolPlayer2, symbolPlayer1);
                }
                    

                var check = CheckValues.Check(Convert.ToInt32(inputValues[0]) - ascii, Convert.ToChar(inputValues[1]), symbols, symbolForPlayer);
                this.Text = check[1];
                switch (check[0])
                {
                    case "0":
                        Print(consoleYellowPrint);
                        countUnsuccessfulMove = 1;
                        break;
                    case "1":
                        Console.Clear();
                        countUnsuccessfulMove = 0;
                        countSuccessfulMove++;
                        break;
                }
                countMove++;
            }
        }
        void Print(IPrint print)
        {
            print.Print(this.Text);
        }
    }
}
