using System;
using System.Linq;

namespace _SimpleCod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();

            n = n.Reverse().ToArray();


            int count = 0;

            int currentNumber = 0;
            for (int i = 0; i < n.Length; i++)
            {
                int liveCount = 1;

                for (int j = i + 1; j < n.Length; j++)
                {
                    if (n[i] != n[j])
                    {
                        break;
                    }
                    liveCount++;
                }

                if (liveCount >= count)
                {
                    count = liveCount;
                    currentNumber = n[i];
                }

            }
            int[] array2 = Enumerable.Repeat(currentNumber, count).ToArray();

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }



        }
    }
}
