using System;
using System.Collections.Generic;

namespace soru_3
{
    class Program
    {
        static void Main()
        {
            // Input from user
            Console.WriteLine("Please enter a sentence: ");
            string sentenceStr = Console.ReadLine();

            // Conversion from string to List<>
            List<char> sentenceList = new List<char>(sentenceStr);

            // Getting vowels in order and printing the result
            List<char> vowels = VowelsFunc.GetVowelsAndSort(sentenceList);
            Console.Write("Vowels in your sentence:  ");
            vowels.ForEach(i => Console.Write(i + "  "));

            Console.ReadLine();
        }
    }
}
