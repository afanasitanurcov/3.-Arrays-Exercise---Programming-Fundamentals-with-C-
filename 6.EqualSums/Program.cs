using System;
using System.Linq;

namespace _SimpleCod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (numbers.Length == 0)
            {
                Console.WriteLine("0");
                return;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < i; j++)//left sum
                {
                    leftSum += numbers[j];
                }

                for (int k = i + 1; k < numbers.Length; k++)// right sum
                {
                    rightSum += numbers[k];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }

            }
            Console.WriteLine("no");

        }
    }
}
