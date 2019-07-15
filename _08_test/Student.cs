using System;
using System.Collections.Generic;
using System.Text;

namespace _08_test
{
    public class Student : Person
    {
        private int _grade;    // 学生的成绩
        private string[] GradeStr = { "一", "二", "三", "四", "五", "六", "七", "八", "九" };

        public int Grade
        {
            get
            {
                return _grade <= 0 || _grade >= 10 ? 1 : _grade;
            }
            set
            {
                _grade = _grade <= 0 || _grade >= 10 ? 0 : _grade;
            }
        }

        public Student() { }
        public Student(string name) : base(name)
        {

        }

        public void Study()
        {
            Console.WriteLine("{0}是{1}年级，正在努力学习！", this.Name, this.GradeStr[this.Grade - 1]);
        }
    }
}
