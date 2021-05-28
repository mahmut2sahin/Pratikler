using System;
using System.Collections;
using System.Collections.Generic;

namespace soru_1
{
    class Program
    {
        static void Main()
        {
            //Take 20 numeric and non-negative input from user
            List<uint> numbers = InputFromUser.GetInput();

            ArrayList PrimeNumbers = new ArrayList();
            ArrayList NonPrimeNumbers = new ArrayList();
            
            // Dividing numbers to corresponding lists
            foreach (var number in numbers)
            {
                if (Functions.IsPrime((int)number))
                {
                    PrimeNumbers.Add(number);
                }
                else
                    NonPrimeNumbers.Add(number);
            }

            // Sorting lists in ascending order
            PrimeNumbers.Sort();
            PrimeNumbers.Reverse();
            NonPrimeNumbers.Sort();
            NonPrimeNumbers.Reverse();


            // Printing the results
            Console.WriteLine("||RESULTS||");
            Console.Write("Prime numbers are: ");
            string PrimeResult = "";
            foreach (var item in PrimeNumbers)
            {
                PrimeResult += item.ToString() + " - ";
            }
            Console.WriteLine(PrimeResult.Trim(' ', '-', ' '));

            Console.Write("Non prime numbers are: ");
            string NonPrimeResult = "";
            foreach (var item in NonPrimeNumbers)
            {
                NonPrimeResult += item.ToString() + " - ";
            }
            Console.WriteLine(NonPrimeResult.Trim(' ', '-', ' '));

            Console.WriteLine("Prime numbers' element count is: {0}", PrimeNumbers.Count);
            Console.WriteLine("Prime numbers' average is: {0}", Functions.GetAverage(PrimeNumbers));

            Console.WriteLine("Non prime numbers' element count is: {0}", NonPrimeNumbers.Count);
            Console.WriteLine("Non prime numbers' average is: {0}", Functions.GetAverage(NonPrimeNumbers));

            Console.ReadLine();
        }
    }
}
