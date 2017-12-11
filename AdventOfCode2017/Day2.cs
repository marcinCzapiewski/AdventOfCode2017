using System;

namespace advent
{
    class Day2
    {
        static void Main(string[] args)
        {
            int sum = 0;

            while (true)
            {
                string row = Console.ReadLine();
                if (row == "")
                {
                    break;
                }

                int lowest = int.MaxValue, highest = int.MinValue;

                string[] s = row.Split();
                foreach (string number in s)
                {
                    int actualDigit = Convert.ToInt32(number);
                    if (actualDigit > highest)
                    {
                        highest = actualDigit;
                    }

                    if (actualDigit < lowest)
                    {
                        lowest = actualDigit;
                    }
                }
                sum += (highest - lowest);
            }

            System.Console.WriteLine($"{sum}");
        }
    }
}