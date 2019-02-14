using System;
using System.Collections.Generic;

namespace task1.css
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//считываем с консоля string и переволим ево в int с помощью int.Parse .
            string input = Console.ReadLine();//считываем с консоля string 
            List<int> primes = new List<int>();// создаем динамический массив

            string[] numbers = input.Split();//разделяем нашу строку 
            for (int i = 0; i < numbers.Length; i++)// пробегаемся по всей длине 
            {
                int current = int.Parse(numbers[i]);//разделенный числа переводим в int
                bool isTrue = true; // предпологаем что наш bool является true
                for(int j = 2; j <= Math.Sqrt(current); j++)// проверяем числа на prime 
                {
                    if (current % j == 0){
                        isTrue = false;
                        break;//  прерываем
                    
                    }   
                }
                if (isTrue && current!=1)// если после проверки на prime number наш bool все еще true (значит число prime) и число не равно единице , мы можем закинуть наши числа в динамический массив 
                {
                    primes.Add(current);// закидваем числа в наш дианмический массив
                }
            }
            Console.WriteLine(primes.Count);// выводим на экран количсетво простых числе в нашем динамическом массиве
            for(int i = 0; i < primes.Count; i++)
            {
                Console.Write(primes[i] + " ");//выводим сами числа в нашем динамеском массиве
            }
            Console.ReadKey();
        }
    }
}
