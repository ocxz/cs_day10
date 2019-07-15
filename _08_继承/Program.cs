using System;
using _08_test;

namespace _08_继承
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("张三", 18, "无业游民");
            Student s1 = new Student("李四");
            Teacher t1 = new Teacher("王五");
            Driver d1 = new Driver("赵六", 36, "专职司机");
            p1.Introduce();
            Console.WriteLine("*****************************");
            s1.Introduce();
            s1.Study();
            Console.WriteLine("*****************************");
            t1.Introduce();
            t1.Teach();
            Console.WriteLine("*****************************");
            d1.Introduce();
            d1.Drive();

            Console.ReadKey();
        }
    }
}
