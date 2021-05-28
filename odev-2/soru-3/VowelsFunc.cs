using System;
using System.Collections.Generic;

namespace soru_3
{
    public static class VowelsFunc
    {
        public static List<char> GetVowelsAndSort(List<char> sentence)
        {
            // In English, vowels are: A, E, I, O, U
            List<char> vowels = new List<char>();
            sentence.AddRange(sentence.ConvertAll<char>(i => char.ToLower(i)));

            foreach (var i in sentence)
            {
                if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
                {
                    vowels.Add(i);
                }
            }
            vowels.Sort();
            
            return vowels;
        }
    }
}