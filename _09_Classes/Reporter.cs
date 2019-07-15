using System;
using System.Collections.Generic;
using System.Text;

namespace _09_Classes
{
    public class Reporter : Person
    {
        private string _hobby;

        public Reporter(string name, int age, char gender, string hobby) : base(name, age, gender)
        {
            this.Hobby = hobby;
        }

        public string Hobby
        {
            get { return _hobby; }
            set { _hobby = value; }
        }

        public void ReporterSayHello()
        {
            Console.WriteLine("我叫{0}，我是一名狗仔，我的爱好是{1}，我是{2}生，我今年{3}岁了", this.Name, this.Hobby, this.Gender, this.Age);
        }

        public new void SayHello()
        {
            Console.WriteLine("大家好，我是记者");
        }
    }
}
