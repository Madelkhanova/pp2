using System;
using System.IO;


namespace lab3
{
    class MainClass
    {
        public static void showDirectory(DirectoryInfo d, int pos)
        {

            Console.BackgroundColor = ConsoleColor.Black;// изанчально красим все в черный цвет 
            Console.Clear();//и все очищаем

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
            DirectoryInfo main = new DirectoryInfo("/Users/aruzhan/Desktop/pp2");// записываем путь к папке
            int pos = 0;
            showDirectory(main, pos);
            int length = main.GetFileSystemInfos().Length;

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow)// если наш key совпадает с нижним нажатием клавиши
                {
                    pos++;// мы должны увеличить позичию
                    if (pos == length)//если наша позиция равна длине , то есть равна последнему элементу 
                    {
                        pos = 0;//ты мы обратно переключаемся на начало 
                    }
                }
                if (key.Key == ConsoleKey.UpArrow)//если наш key совпадает с вернеи нажатием клавиши
                {
                    {
                    pos--;//мы уменьшаем нашу позицию так как идем к верху
                    if (pos == -1)//если наша позиция равна -1 , то есть находится на самом первом элементе
                    {
                        pos = length - 1;//мы переключаемся на конец и убираем -1 так как оно выходит за рамки
                    }
                }
                if (key.Key == ConsoleKey.Enter)// если наш кей совпадает с нажатием клавишы  Enter
                {
                    if (main.GetFileSystemInfos()[pos].GetType() == typeof(DirectoryInfo))//если тип совпадает с папкой то я захожу в нее и обнуляю позицию и новую длину
                    {
                        main = new DirectoryInfo(main.GetFileSystemInfos()[pos].FullName);
                        pos = 0;
                        length = main.GetFileSystemInfos().Length;
                    }
                    else
                    {
                        StreamReader sr = new StreamReader(main.GetFileSystemInfos()[pos].FullName);//создаю поток streamreader к этому файлу и с помощью read to end все содержимое записываю в string output
                        string output = sr.ReadToEnd();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.WriteLine(output);
                        sr.Close();
                        Console.ReadKey();
                    }
                }
                if (key.Key == ConsoleKey.Escape)// если наш кей совпадает с нашатием клавиши escape
                {
                    main = new DirectoryInfo(main.Parent.FullName);
                    length = main.GetFileSystemInfos().Length;
                    pos = 0;
                }
                if (key.Key == ConsoleKey.Delete)// если наш кей совпадает с кнопкой удаления
                {
                    if (main.GetFileSystemInfos()[pos].GetType() == typeof(DirectoryInfo))// если возвращаемый тип совпадает с типом директория
                    {
                        Directory.Delete(main.GetFileSystemInfos()[pos].FullName, false);// мы его удаляем 
                    }// но если в нем что-то есть он запрашивает разрешение 
                    else
                    {
                        File.Delete(main.GetFileSystemInfos()[pos].FullName);// если же это файл мы его удаляем
                    }
                }
                if (key.Key == ConsoleKey.R)
                {
                    string initPath = main.GetFileSystemInfos()[pos].FullName;

                    Console.WriteLine("Enter new name of the folder or file.");// для понятия что происходит 
                    string newName = Console.ReadLine();
                    string[] parts = initPath.Split('\\');//c помошью part я записываю в переменную dest Name путь к папке где содержится файл или папка которую я хочу переименовать 
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
