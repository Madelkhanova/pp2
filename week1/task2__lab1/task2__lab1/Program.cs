using System;
using System.IO;

namespace task2__lab1
{
    class Student
    {
        private int id=0;//создаю интовую пепеменную id
        public string name = "";//создаю имя студенту
        public int yearofstudy = 0;// создаю интовую переменную года обучения

        //public Student() { }
        public Student(string n, int id)// создаем констурктор состоящий из string и int
        {
            name = n;//name мы присваиваем n
            this.id = id;//id присваиваем id
        }
        public Student(string s, int id, int age) {
            name = s;
            this.id = id;
            yearofstudy = age;
        }
        public int getId()//в связи с тем что id является private
        {
            return this.id;//мы вызываем его для работы с id
        }
        public void incrementYearOfStudy()// вызываем функцию yearofstudy (в связи стем что год увеличивается пишем increment)
        {
            this.yearofstudy++;//увеличиваем год обучения 
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Student s = new Student("a", 1);
            Student s2 = new Student("B", 10, 1);
            Console.WriteLine(s.getId());
            //s.getId();
            s.incrementYearOfStudy();
            Console.WriteLine(s.yearofstudy);

        }
    }
}
