using System;
using System.IO;

namespace task4_lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string pattern = "[*]";
            int n = int.Parse(Console.ReadLine());
            string[,] elka = new string[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    elka[i, j] = pattern;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(elka[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

    
