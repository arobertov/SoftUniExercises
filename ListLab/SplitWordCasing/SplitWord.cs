﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitWordCasing
{
    class SplitWord
    {
        static void Main()
        {
            char[] separator = {',', ';', ':', '.', '!', ' ','(',')','"','\'','/','\\','[',']'}; 
            var words = Console.ReadLine()
                .Split(separator, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var lowerCaseWords = new List<string>();
            var mixedCaseWords = new List<string>();
            var upperCaseWords = new List<string>();

            foreach (var word in words)
            {
                var lowerCaseChars = 0;
                var upperCaseChars = 0;

                foreach (char letter in word)
                    if (char.IsLower(letter)) lowerCaseChars++;
                    else if (char.IsUpper(letter)) upperCaseChars++;

                if (lowerCaseChars == word.Length)
                    lowerCaseWords.Add(word);
                else if (upperCaseChars == word.Length)
                    upperCaseWords.Add(word);
                else mixedCaseWords.Add(word);
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseWords));
        }
    }
}
