using System;
using System.Collections.Generic;

namespace soru_2
{
    public static class InputFromUser
    {
        public static int[] GetInput()
        {
            int[] numbers = new int[20];

            Console.WriteLine("Please enter 20 numbers...");
            for (int i = 0; i < 20; i++)
            {
                while (true)
                {
                    Console.Write("{0}. integer: ", i + 1);
                    string input = Console.ReadLine();
                    try
                    {
                        int ConvInput = Convert.ToInt32(input);
                        numbers[i] = ConvInput;
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Use an integer!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Limit for an integer is passed!");
                    }
                }
            }
            return numbers;
        }
    }
}