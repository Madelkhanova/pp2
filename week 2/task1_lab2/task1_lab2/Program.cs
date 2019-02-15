using System;
using System.IO;

namespace task1_lab2
{
    class MainClass
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("/Users/aruzhan/Desktop/pp2/week1/task1.css/task1.css/bin/Debug/1.rtf");//для того чтобы считать с файла
            string s = sr.ReadLine();//считываем одну стоку так как мы имеем  только одно слово
            bool isPalin = true;//создаем переменную bool которая равна true
            for (int i = 0; i < s.Length / 2; i++)//пробегаемся по длине слова
            {
                if (s[i] != s[s.Length - i - 1])//если буквы с двух разных концов не совпадают 
                {
                    isPalin = false;//то мы считаем что наше слово не является палиндромом
                }
            }
            if (isPalin)//если наше слово все таки является палиндромом
            {
                Console.WriteLine("YES");// мы выводим на экран YES
            }
            else
            {
                Console.WriteLine("NO");//иначе мы выводим на экран NO
            }
            sr.Close();
            Console.ReadKey();
        }
    }
}eghmn