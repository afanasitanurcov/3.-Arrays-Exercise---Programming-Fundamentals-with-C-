using System;

namespace _1.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numbersOfWagons = int.Parse(Console.ReadLine());

            int[] numberOfPassengers = new int[numbersOfWagons];

            for (int i = 0; i < numberOfPassengers.Length; i++)
            {
                int input = int.Parse(Console.ReadLine());
                numberOfPassengers[i] = input;                                
            }
            int sum = 0;
            for (int i = 0;i < numberOfPassengers.Length;i++)
            {
                Console.Write(numberOfPassengers[i] + " ");
                sum += numberOfPassengers[i];
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
