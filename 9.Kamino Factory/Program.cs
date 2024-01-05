using System;
using System.Drawing;
using System.Linq;
using System.Threading;

namespace _9.Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int dnaLength = int.Parse(Console.ReadLine());
            int[] currentLongestSequence = new int[dnaLength];
            int currentSequanceLength = 0;
            int currentStartingIndex = 0;
            int currentSum = 0;
            int dnaNumber = 0;

            int counter = 0;

            while (true)
            {
                counter++;
                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }
                int[] array = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int length = 0;


                foreach (int i in array)

                {
                    if (i == 1)
                    {
                    length++;

                    }
                    else if (i == 0 && length > 0)
                    {
                        break;
                    }

                }




                int startingIndex = Array.IndexOf(array, 1);
                int sum = array.Sum();
                if (length > currentSequanceLength
                    || length == currentSequanceLength && currentStartingIndex > startingIndex
                    || length == currentStartingIndex && currentStartingIndex == startingIndex && sum > currentSum)
                {
                    currentLongestSequence = array;
                    currentSequanceLength = length;
                    currentStartingIndex = startingIndex;
                    currentSum = sum;
                    dnaNumber = counter;
                }


            }

            Console.WriteLine($"Best DNA sample {dnaNumber} with sum: {currentSum}.");

            Console.WriteLine(string.Join(' ', currentLongestSequence));

        }
        
    }
}
