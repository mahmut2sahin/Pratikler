using System;

namespace soru_2
{
    class Program
    {
        static void Main()
        {
            // Getting input from user
            int[] numbers = InputFromUser.GetInput();
            
            // Sorting input
            Array.Sort(numbers);

            // Copying smallest and largest 3 numbers
            int[] SmallNumbers = new int[3];
            int[] LargeNumbers = new int[3];
            Array.Copy(numbers, SmallNumbers, 3);
            Array.Copy(numbers, 5, LargeNumbers, 0, 3);

            // Print numbers
            Console.Write("Smallest numbers are:");
            Array.ForEach(SmallNumbers, i => Console.Write("  " + i));
            Console.WriteLine();
            Console.Write("Largest numbers are:");
            Array.ForEach(LargeNumbers, i => Console.Write("  " + i));
            Console.WriteLine();

            // Taking averages
            double SmallAvg = 0.0;
            foreach (var item in SmallNumbers)
            {
                SmallAvg += item;
            }
            SmallAvg /= 3.0;

            double LargeAvg = 0.0;
            foreach (var item in LargeNumbers)
            {
                LargeAvg += item;
            }
            LargeAvg /= 3.0;

            // Printing final results
            Console.WriteLine("Average of 3 smallest numbers = " + SmallAvg);
            Console.WriteLine("Average of 3 largest numbers = " + LargeAvg);
            Console.WriteLine("Sum of these averages = " + (SmallAvg + LargeAvg));

            Console.ReadLine();
        }
    }
}
