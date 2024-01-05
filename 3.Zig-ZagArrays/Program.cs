using System;
using System.Linq;

namespace _3.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] first = new int[n];
            int[] second = new int[n];
            int count = 1;
            for (int i = 0; i < n; i++)
            {
                if (count % 2 == 1)
                {
                    int[] numbers = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();
                    first[i] = numbers[0];
                    second[i] = numbers[1];
                    
                }
                else
                {
                    int[] numbers = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();
                    first[i] = numbers[1];
                    second[i] = numbers[0];
                }
                count++;

            }
           for (int i = 0;i < first.Length; i++)
            {
                Console.Write(first[i] + " ");
            }
           Console.WriteLine();
           for(int i = 0; i < second.Length; i++)
            {
                Console.Write(second[i] + " ");
            }
        }
    }
}
