using System;
using System.Collections.Generic;
using System.Text;

namespace _09_Classes
{
    public class Programmer : Person
    {
        private int _workYear;

        public Programmer() { }
        public Programmer(string name, int age, char gender, int workYear) : base(name, age, gender)
        {
            this.WorkYear = workYear;
        }

        public int WorkYear
        {
            get { return _workYear; }
            set { _workYear = value; }
        }

        public void ProgramerSayHello()
        {
            Console.WriteLine("我叫{0}，我是一名程序猿，我是{1}生，我今年{2}岁了，我的工作年限是{3}年", this.Name, this.Gender, this.Age, this.WorkYear);
        }

        public new void SayHello()
        {
            Console.WriteLine("大家好，我是程序猿");
        }

    }
}
