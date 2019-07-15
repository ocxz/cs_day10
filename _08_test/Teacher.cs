using System;
using System.Collections.Generic;
using System.Text;

namespace _08_test
{
    public class Teacher : Person
    {
        private int _grade;
        private string[] GradeStr = { "一", "二", "三", "四", "五", "六", "七", "八", "九" };
        public int Grade
        {
            get
            {
                return _grade <= 0 ? 1 : _grade;
            }
            set
            {
                _grade = value <= 0 ? 1 : value;
            }
        }

        public Teacher() { }
        public Teacher(string name) : base(name)
        { }

        public void Teach()
        {
            Console.WriteLine("{0}是一个老师，现在在正在小学{1}年级上课", this.Name, this.GradeStr[Grade - 1]);
        }
    }
}
