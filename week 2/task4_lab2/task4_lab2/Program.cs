using System;
using System.IO;

namespace task4_lab2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string path = "/Users/aruzhan/Desktop/path";// создаем первый путь папки
            string nameFile = "rt.rtf";//создаем имя файлу 
            string path1 = "/Users/aruzhan/Desktop/path1";//создаем второй путь папки
            StreamWriter sw = new StreamWriter(path+nameFile);// вписываем в путь и мя файла
            sw.WriteLine("I love pp2");// вписываем в наш файл какое либо слово
            sw.Close();// закрываем поток
            File.Copy(path + nameFile, path1 + "\\" + nameFile);// копируем с одного пути в другой разеляя путь и имя файла "\\"
            File.Delete(path + nameFile);//удаляем на первый путь с именем файла
            Console.ReadKey();//
        }
    }
}
