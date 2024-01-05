using System;
using System.Threading;

namespace _2.Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();

            string[] secondArray = Console.ReadLine().Split();

            int count = 0;         
                        
            {
                for (int i = 0; i < secondArray.Length; i++)
                {
                    string current = secondArray[i];
                    for(int j = 0; j < firstArray.Length; j++)
                    {
                        if (current == firstArray[j])
                        {
                            Console.Write($"{current} ");
                        }
                    }
                }
            }
            
        }
    }
}
