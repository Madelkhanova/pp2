using System;
using System.IO;


namespace lab3
{
    class MainClass
    {
        public static void showDirectory(DirectoryInfo d, int pos)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            FileSystemInfo[] files = d.GetFileSystemInfos();

            for (int i = 0; i < files.Length; i++)
            {
                if (pos == i)//если курсор наведен на эту строку 
                {
                    Console.BackgroundColor = ConsoleColor.Red;// закрашиваем снаружи наше слово красным
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;// иначе закрашиваем строку в черный
                }
                if (files[i].GetType() == typeof(DirectoryInfo))// если возвращаемый тип данного файла совпадат с типом директория
                {
                    Console.ForegroundColor = ConsoleColor.White;//само слово будет белым
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;// иначе оно будет желтым
                }
                Console.WriteLine(i + 1 + ". " + files[i].Name);

            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo main = new DirectoryInfo("/Users/aruzhan/Desktop/pp2");
            int pos = 0;
            showDirectory(main, pos);
            int length = main.GetFileSystemInfos().Length;

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    if (pos == length)
                    {
                        pos = 0;
                    }
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if (pos == -1)
                    {
                        pos = length - 1;
                    }
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    if (main.GetFileSystemInfos()[pos].GetType() == typeof(DirectoryInfo))
                    {
                        main = new DirectoryInfo(main.GetFileSystemInfos()[pos].FullName);
                        pos = 0;
                        length = main.GetFileSystemInfos().Length;
                    }
                    else
                    {
                        StreamReader sr = new StreamReader(main.GetFileSystemInfos()[pos].FullName);
                        string output = sr.ReadToEnd();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.WriteLine(output);
                        sr.Close();
                        Console.ReadKey();
                    }
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    main = new DirectoryInfo(main.Parent.FullName);
                    length = main.GetFileSystemInfos().Length;
                    pos = 0;
                }
                if (key.Key == ConsoleKey.Delete)
                {
                    if (main.GetFileSystemInfos()[pos].GetType() == typeof(DirectoryInfo))
                    {
                        Directory.Delete(main.GetFileSystemInfos()[pos].FullName, false);
                    }
                    else
                    {
                        File.Delete(main.GetFileSystemInfos()[pos].FullName);
                    }
                }
                if (key.Key == ConsoleKey.R)
                {
                    string initPath = main.GetFileSystemInfos()[pos].FullName;

                    Console.WriteLine("Enter new name of the folder or file.");
                    string newName = Console.ReadLine();
                    string[] parts = initPath.Split('\\');
                    string destName = "";
                    for (int i = 0; i<parts.Length - 1; i++)
                    {
                        destName += parts[i];
                        destName += "\\";

                    }
                    destName += newName;

                    if (main.GetFileSystemInfos()[pos].GetType() == typeof(DirectoryInfo))
                    {
                        // Console.WriteLine(firstPartOfTheNewName);
                        Directory.Move(initPath, destName);


                    }
                    else
                    {
                        // Console.WriteLine(firstPartOfTheNewName);
                        File.Move(initPath, destName);
                    }
                }

                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                showDirectory(main, pos);
            }
            //Console.ReadKey();

        }
    }
}
