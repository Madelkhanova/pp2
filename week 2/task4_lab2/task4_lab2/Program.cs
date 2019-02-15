using System;
using System.IO;

namespace task4_lab2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //string path = @"/Users/aruzhan/Desktop/path";// создаем первый путь папки
            string nameFile = @"/Users/aruzhan/Desktop/path/rt.rtf";//создаем имя файлу 
            FileInfo file = new FileInfo(nameFile);
            string path1 = @"/Users/aruzhan/Desktop/path1/rt.rtf";//создаем второй путь папки
            StreamWriter sw = new StreamWriter(nameFile);// вписываем в путь и мя файла
            sw.WriteLine("I love pp2");// вписываем в наш файл какое либо слово
            sw.Close();// закрываем поток
            file.CopyTo(path1);// копируем с одного пути в другой разеляя путь и имя файла "\\"
            file.Delete();//удаляем на первый путь с именем файла
            //Console.ReadKey();
        }
    }
}
