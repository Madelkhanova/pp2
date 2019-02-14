using System;
using System.IO;

namespace task4_lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string pattern = "[*]";//создаем переменную которая равняется [*]
            int n = int.Parse(Console.ReadLine());//конвентируем string в int
            string[,] elka = new string[n, n];//создаем двумерный массив n x n
            for (int i = 0; i < n; i++)
            {//с помощью for мы создаем место в нашем двумерном массиве 
                for (int j = 0; j <= i; j++)
                {
                    elka[i, j] = pattern;//заполняем эти места pattren-ами([*])
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(elka[i,j]);//выводим наш двумерный массив 
                }
                Console.WriteLine();// дейсвует как кнопка ввод
            }
            Console.ReadKey();
        }
    }
}

    
