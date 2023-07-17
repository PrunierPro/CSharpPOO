using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    internal class IHM
    {
        private Hangman game;

        public void InitialPrint()
        {
            Console.WriteLine("=== Game options ===\n");
            Console.Write("Do you want to pick the amount of tries ? (10 by default) Y/N ");
            if (Console.ReadLine().ToUpper().Equals("Y"))
            {
                Console.Write("How many tries would you like ? ");
                int amount;
                while (!int.TryParse(Console.ReadLine(), out amount))
                {
                    Console.Write("Error! Please enter a number : ");
                }
                game = new Hangman(amount);
            }
            else game = new Hangman();
            Console.WriteLine($"Game generated! Amount of tries : {game.TryAmount}");
        }

        public bool GameTurn()
        {
            if (CheckWin())
            {
                return false;
            }
            else if (CheckLoss())
            {
                return false;
            }
            game.ShowHangman();
            Console.WriteLine($"Word : {string.Join("", game.Mask)}");
            Console.WriteLine($"You have {game.MaxTryAmount - game.TryAmount} left.");
            Console.Write("Please enter a letter : ");
            char attempt;
            while (!char.TryParse(Console.ReadLine(), out attempt) || !char.IsLetter(attempt))
            {
                Console.Write("Error! Please enter a letter : ");
            }
            game.TestChar(attempt);
            return true;
        }

        private bool CheckWin()
        {
            if (game.TestWin())
            {
                Console.WriteLine($"Congratulations! The word was {game.Word}. Thanks for playing.");
                return true;
            }
            else return false;
        }

        private bool CheckLoss()
        {
            if (game.TryAmount == game.MaxTryAmount)
            {
                game.ShowHangman();
                Console.WriteLine($"Unfortunately, you lost. The word was {game.Word}. Thanks for playing.");
                return true;
            }
            else return false;
        }
    }
}
