namespace Exercice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Game options ===\n");
            Console.Write("Do you want to pick the amount of tries ? (10 by default) Y/N ");
            Hangman game;
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
            while (true)
            {
                if (game.TestWin())
                {
                    Console.WriteLine($"Congratulations! The word was {game.Word}. Thanks for playing.");
                    break;
                } else if(game.TryAmount <= 0)
                {
                    Console.WriteLine($"Unfortunately, you lost. The word was {game.Word}. Thanks for playing.");
                    break;
                }
                Console.WriteLine($"Word : {string.Join("", game.Mask)}");
                Console.WriteLine($"You have {game.TryAmount} left.");
                Console.Write("Please enter a letter : ");
                char attempt;
                while (!char.TryParse(Console.ReadLine(), out attempt) || !char.IsLetter(attempt))
                {
                    Console.Write("Error! Please enter a letter : ");
                }
                game.TestChar(attempt);
            }
        }
    }
}