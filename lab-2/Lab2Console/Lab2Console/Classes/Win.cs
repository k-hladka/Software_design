using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Console.Classes
{
    public class Win
    {
        public string[] CheckWin(char[] arr, char symbolPlayer1, char symbolPlayer2)
        {
            int X_horisontal = 0;
            int X_vertikal = 0;
            int X_diagonal_left = 0;
            int X_diagonal_right = 0;

            int O_horisontal = 0;
            int O_vertical = 0;
            int O_diagonal_left = 0;
            int O_diagonal_right = 0;

            int countMove = 0;
            int countNumberInField = 0;
            

            for (int h=0; h<arr.Length; h++)  //horisontal  0 1 2   3 4 5   6 7 8
            {
                if (arr[h] == symbolPlayer1)
                    X_horisontal++;

                if (arr[h] == symbolPlayer2)
                    O_horisontal++;
                
                if (arr[h] != symbolPlayer1 && arr[h]!= symbolPlayer2)
                    countNumberInField++;

                countMove++;
                if (countMove == 3)
                {
                    if (X_horisontal == 3)
                        return textWin(1);
                        
                    if (O_horisontal == 3)
                        return textWin(2);

                    X_horisontal = 0; O_horisontal = 0; countMove = 0;
                }
                    
            }

            countMove = 0;
            for (int v = 0; v<arr.Length; v += 3) //vertical    0 3 6   1 4 7   2 5 8
            {
                if (arr[v] == symbolPlayer1)
                    X_vertikal++;

                if (arr[v] == symbolPlayer2)
                    O_vertical++;

                countMove++;
                if (countMove == 3)
                {
                    if (X_vertikal == 3)
                        return textWin(1);

                    if (O_vertical == 3)
                        return textWin(2);

                    X_vertikal = 0; O_vertical = 0; countMove = 0;

                    v = v - 5 - 3;
                }
            }

            countMove = 0;
            for (int dl = 0, dr = 2; ; dl += 4, dr += 2) //diagonals    0 4 8   2 4 6
            {
                if (arr[dl] == symbolPlayer1)
                    X_diagonal_left++;
                if (arr[dr] == symbolPlayer1)
                    X_diagonal_right++;

                if (arr[dl] == symbolPlayer2)
                    O_diagonal_left++;
                if (arr[dr] == symbolPlayer2)
                    O_diagonal_right++;

                countMove++;
                if (countMove == 3)
                {
                    if (X_diagonal_left == 3 || X_diagonal_right == 3)
                        return textWin(1);

                    if (O_diagonal_left == 3 || O_diagonal_right == 3)
                        return textWin(2);

                    break;
                }
            }

            string[] textWin(int numberPlayer = 1)
            {
                string[] text = new string[2];

                switch (numberPlayer)
                {
                    case 0:
                        text[0] = "0";
                        text[1] = "";
                        break;
                    case 1:
                        text[0] = "1";
                        text[1] = "Player 1 wins";
                        break;
                    case 2:
                        text[0] = "2";
                        text[1] = "Player 2 wins";
                        break;
                    case 12:
                        text[0] = "12";
                        text[1] = "It's a draw";
                        break;
                }
                return text;
            }

            if (countNumberInField == 0)
                return textWin(12);
            else
                return textWin(0);
        }
    }
}
