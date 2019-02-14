using System;
using System.IO;

namespace task3_lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());// считываем с консоли string и переводим его int
            string input = Console.ReadLine();// cчитываем с консоля string
            string[] numbers = input.Split();// разделяем нашу строку 
            int[] doubleArray = new int[2 * n];// создаем массив который по тразмеру в двара раза больше первого
            int cnt = -1;// создаем счетчик равный -1
            for (int i = 0; i < numbers.Length; i++)//пробегаемся по длинне первого массива
            {
                cnt++;// увеличиваем счетчик ,тем самым создавая 0 элемент нашего массива
                doubleArray[cnt] = int.Parse(numbers[i]);// нулевой эелемпент певого массива равен нулевому элементу в торого массива(переводи в int)
                cnt++;//увеличиваем счетчик ,тем самым создавая 1 элемент нашего массива
                doubleArray[cnt] = int.Parse(numbers[i]);//нулевой элемент первого масиива равен первому эллементу второго массива(переводим в int)
                // дальше идет повторение цикла
            }
            for (int i = 0; i < doubleArray.Length; i++)// пробегаемся по длине второго массива
            {
                Console.Write(doubleArray[i] + " ");//выводим на экран все элементы втрого массива через пробел
            }
            Console.ReadKey();

        }
    }
}
