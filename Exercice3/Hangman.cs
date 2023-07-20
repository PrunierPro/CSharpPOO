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
        public List<char> UsedLetters { get; private set; }

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
                return;
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
            UsedLetters.Sort();
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

        
    }
}
