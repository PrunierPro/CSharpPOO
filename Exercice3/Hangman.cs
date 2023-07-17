using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    internal class Hangman
    {

        public char[] Mask { get; private set; }
        public string Word { get; private set; }
        public int TryAmount { get; private set; }
        public int MaxTryAmount { get; private set; }
        private List<char> UsedLetters { get; set; }

        public Hangman()
        {
            Word = WordGenerator.GenerateWord().ToUpper();
            Mask = GenerateMask();
            TryAmount = 0;
            MaxTryAmount = 10;
            UsedLetters = new List<char>();
        }

        public Hangman(int tryAmount)
        {
            Word = WordGenerator.GenerateWord().ToUpper();
            Mask = GenerateMask();
            TryAmount = 0;
            MaxTryAmount = tryAmount;
            UsedLetters = new List<char>();
        }

        public void TestChar(char c)
        {
            c = Char.ToUpper(c);
            if (UsedLetters.Contains(c)) 
            {
                Console.WriteLine("You already entered that letter!");
            } else if (Word.Contains(c))
            {
                List<int> indexes = new List<int>();
                for(int i = 0; i < Word.Length; i++)
                {
                    if (Word[i] == c) indexes.Add(i);
                }
                foreach(int index in indexes)
                {
                    Mask[index] = c;
                }
            } else
            {
                TryAmount++;
            }
            UsedLetters.Add(c);
        }

        public bool TestWin()
        {
            return !Mask.Contains('*');
        }

        private char[] GenerateMask()
        {
            char[] res = new char[Word.Length];
            for(int i = 0; i < res.Length; i++)
            {
                res[i] = '*';
            }
            return res;
        }

        public void ShowHangman()
        {
            string[,] penduAscii = {
                {"           ",
                "            ",
                "            ",
                "            ",
                "            ",
                "            ",
                "            "},
                {"           ",
                "            ",
                "            ",
                "            ",
                "            ",
                "            ",
                "--------    "},
                {"           ",
                "            ",
                "            ",
                " |          ",
                " |          ",
                " |          ",
                "--------    "},
                {"           ",
                " |          ",
                " |          ",
                " |          ",
                " |          ",
                " |          ",
                "--------    "},
                {"           ",
                " |/         ",
                " |          ",
                " |          ",
                " |          ",
                " |          ",
                "--------    "},
                {"_____      ",
                " |/         ",
                " |          ",
                " |          ",
                " |          ",
                " |          ",
                "--------    "},
                {"___________",
                " |/         ",
                " |          ",
                " |          ",
                " |          ",
                " |          ",
                "--------    "},
                {"___________ ",
                " |/       | ",
                " |          ",
                " |          ",
                " |          ",
                " |          ",
                "--------    "},
                {"___________ ",
                " |/       | ",
                " |        O ",
                " |       /|\\",
                " |       / \\",
                " |          ",
                "--------    "},
            };
            Console.WriteLine($"Debug: {TryAmount * 8 / MaxTryAmount}");
            int noPendu = TryAmount == 0 ? 0 : (TryAmount * 8 / MaxTryAmount);
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(penduAscii[noPendu, i]);
            }
        }
    }
}
