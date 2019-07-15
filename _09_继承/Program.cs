using System;
using _09_Classes;

namespace _09_继承
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *   记者：我是记者 我的爱好是偷拍 我的年龄是34岁 我是一个男狗仔
             *   司机：我是舒马赫 我的年龄是43 我是男人 我的驾龄是23年
             *   程序员：我叫孙权 我的年龄是23 我是男生 我的工作年限是3年
             */

            Reporter reporter = new Reporter("记者", 34, '男', "偷拍");
            reporter.ReporterSayHello();
            reporter.SayHello();
            Console.ReadKey();

            Programmer programmer = new Programmer("程序猿", 23, '男', 3);
            programmer.ProgramerSayHello();
            programmer.SayHello();
            Console.ReadKey();
        }


    }
}
