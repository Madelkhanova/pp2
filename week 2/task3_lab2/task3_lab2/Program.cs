using System;
using System.IO;

namespace task3_lab2
{
    class Program

    {  
        public static void printSpaces(int level)// создаем level для создания количества пробелов который должны стоять перед папкой или файлом  
        {
            for (int i = 0; i < level*4; i++)
            {
                Console.Write(" ");
            }
        }
        public static void showDirectory(DirectoryInfo d,int level)
        {
            FileInfo[] arrayofFiles = d.GetFiles();
            DirectoryInfo[] arrayofDirectories = d.GetDirectories();
            foreach(FileInfo f in arrayofFiles)
            {
                printSpaces(level);
                Console.WriteLine(f.Name);
            }
            foreach(DirectoryInfo di in arrayofDirectories)
            {
                printSpaces(level);
                Console.WriteLine(di.Name);
                showDirectory(di, level + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("/Users/aruzhan/Desktop/pp2");
            showDirectory(di, 0);
            Console.ReadKey();

        }
    }
}
