using System;
using System.Collections.Generic;

namespace task1.css
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            List<int> primes = new List<int>();

            string[] numbers = input.Split();
            for (int i = 0; i < numbers.Length; i++)
            {
                int current = int.Parse(numbers[i]);
                bool isTrue = true;
                for(int j = 2; j <= Math.Sqrt(current); j++)
                {
                    if (current % j == 0){
                        isTrue = false;
                        break;
                    
                    }   
                }
                if (isTrue && current!=1)
                {
                    primes.Add(current);
                }
            }
            Console.WriteLine(primes.Count);
            for(int i = 0; i < primes.Count; i++)
            {
                Console.Write(primes[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
