using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    internal class WordGenerator
    {
        private static List<string> _wordOptions = new List<string> { "apple", "pear", "banana", "blue", "red", "yellow"};

        public static void UpdateOptions(params string[] words)
        {
            _wordOptions.AddRange(words);
        }

        public static string GenerateWord()
        {
            Random rand = new Random();
            return _wordOptions[rand.Next(0, _wordOptions.Count)];
        }
    }
}
