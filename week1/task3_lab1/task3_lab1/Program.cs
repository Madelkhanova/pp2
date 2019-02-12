using System;
using System.IO;

namespace task3_lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] numbers = input.Split();
            int[] doubleArray = new int[2 * n];
            int cnt = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                cnt++;
                doubleArray[cnt] = int.Parse(numbers[i]);
                cnt++;
                doubleArray[cnt] = int.Parse(numbers[i]);
            }
            for (int i = 0; i < doubleArray.Length; i++)
            {
                Console.Write(doubleArray[i] + " ");
            }
            Console.ReadKey();

        }
    }
}
