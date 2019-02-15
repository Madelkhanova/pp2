using System;
using System.IO;
namespace task2_lab2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("/Users/aruzhan/Desktop/pp2/week1/task1.css/task1.css/bin/Debug/1.rtf");// создаю StreamReader для того чтобы считать с файла
            string s = sr.ReadToEnd();// считываю всю строку
            bool isPrime = true;// создаю переменную bool которая равняется true
            StreamWriter sw = new StreamWriter("/Users/aruzhan/Library/Mobile Documents/com~apple~TextEdit/Documents/2.rtf");//создаю StreamWriter для того чтобы записать данный в файл
            string[] arr = s.Split();//разделяем нашу строку
            for (int i = 0; i < arr.Length; i++)//пробегаемся по длине 
            {
                isPrime = true;
                int current = int.Parse(arr[i]);// создаем перемнную current и вписываем в нее нашу разделенную строку одновременно переводя все в int
                for (int j = 2; j <= Math.Sqrt(current); j++)
                {
                    if (current % j == 0)//проверка числа на prime
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)// если наше число все  таки prime 
                {
                    sw.Write(current + " ");//записываеи его черз пробел
                }
            }
            sw.Close();//закрываем потоки
            sr.Close();
            Console.ReadKey();
        }
    }
}
