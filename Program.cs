using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayGame game = new PlayGame();
            int input,player=1,isWinner,i=0;
            game.createField();
            do {
                // Choose the place
                Console.Write("\n Player {0} please choose a place: ",player);
                input = Convert.ToInt32(Console.ReadLine());
                // fill the chosen place
                if (game.numField[input - 1] == 'X' || game.numField[input - 1] == 'O')
                {
                    Console.WriteLine("\n\n ************ ERROR! place already taken ************* \n\n");
                    game.createField();
                }
                else
                { 
                    game.enterXO(input, player);
                    //Check the field for sign matching
                    isWinner = game.isOver();
                    // reCreate the field after sign placement
                    game.createField();
                    // Check the Winner
                    if (isWinner == 'X')
                    {
                        Console.WriteLine("Player 1  wins the game");
                        i = 9;
                    }
                    else if (isWinner == 'O')
                    {
                        Console.WriteLine("Player 2  wins the game");
                        i = 9;
                    }
                    if (i == 8)
                    { Console.WriteLine("DRAW"); }
                    // Switch the player
                    if (player == 1)
                    { player = 2; }
                    else if (player == 2)
                    { player = 1; }
                    i++;
                }
            }
            while (i<9);          
            Console.ReadLine();  }
      static void createField()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ",1,2,3);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", 4, 5, 6);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", 7, 8, 9);
        }   }
}
