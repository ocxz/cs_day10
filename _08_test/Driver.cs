using System;
using System.Collections.Generic;
using System.Text;

namespace _08_test
{
    public class Driver : Person
    {
        private int _salary;
        public int Salary
        {
            set
            {
                _salary = value <= 0 ? 0 : value;
            }
            get
            {
                return _salary <= 0 ? 0 : _salary;
            }
        }

        public Driver() { }
        public Driver(string name, int age, string job) : base(name, age, job)
        { }

        public void Drive()
        {
            Console.WriteLine("{0}今年{1}了，是一个{2}，工资有{3}元一个月，现在正在开车", this.Name, this.Age, this.Job, this.Salary);
        }
    }
}
