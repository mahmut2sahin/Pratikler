using System;
using System.Collections.Generic;

namespace soru_1
{
    public static class InputFromUser
    {
        public static List<uint> GetInput()
        {
            List<uint> numbers = new List<uint>();

            Console.WriteLine("Please enter 20 positive integers...");
            for (int i = 0; i < 20; i++)
            {
                while (true)
                {
                    Console.Write("{0}. integer: ", i + 1);
                    string input = Console.ReadLine();
                    try
                    {
                        uint ConvInput = Convert.ToUInt32(input);
                        numbers.Add(ConvInput);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Use an integer!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Use a positive integer!");
                    }
                }
            }
            return numbers;
        }
    }
}