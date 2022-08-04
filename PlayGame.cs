using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class PlayGame
    {
        char[] arrSign = {'X','O'};
        char playerSign;
        public char[] numField ={'1','2','3','4','5','6' ,'7','8','9'};
        public void enterXO(int input, int player)
        {
            if (player == 1) { playerSign = 'X'; }
            if (player == 2) { playerSign = 'O'; }      
                switch (input)
                {
                    case 1:
                        numField[0] = playerSign;
                        break;
                    case 2:
                        numField[1] = playerSign;
                        break;
                    case 3:
                        numField[2] = playerSign;
                        break;
                    case 4:
                        numField[3] = playerSign;
                        break;
                    case 5:
                        numField[4] = playerSign;
                        break;
                    case 6:
                        numField[5] = playerSign;
                        break;
                    case 7:
                        numField[6] = playerSign;
                        break;
                    case 8:
                        numField[7] = playerSign;
                        break;
                    case 9:
                        numField[8] = playerSign;
                        break;
                }               
        }
        public int isOver()
        {
           
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                foreach (char item in arrSign)
                {
                    if (numField[i] == item && numField[i+1] == item && numField[i+2] == item)
                    {
                        return item;
                    }
                    else if(numField[j] == item && numField[j+3] == item && numField[j+6] == item)
                    {
                        return item;
                    }
                    else if (numField[0] == item && numField[4] == item && numField[8] == item)
                    {
                        return item;
                    }
                    else if (numField[2] == item && numField[4] == item && numField[6] == item)
                    {
                        return item;
                    }
                }
            }
            return 3;
        }
        public void createField()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", numField[0], numField[1], numField[2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", numField[3], numField[4], numField[5]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", numField[6], numField[7], numField[8]);
        }
    }  
}
