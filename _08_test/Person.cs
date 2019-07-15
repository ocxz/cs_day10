using System;
using System.Collections.Generic;
using System.Text;

namespace _08_test
{
    /// <summary>
    /// 一个普通的人类 _name、_age、_gender、_job、Introduce()
    /// </summary>
    public class Person
    {
        private string _name;     // 人的姓名
        private int _age;          // 人的年龄
        private char _gender;     // 人的性别
        private string _job;      // 人的工作   

        public Person()
        {

        }
        public Person(string name, int age, char gender, string job)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Job = job;
        }
        public Person(string name, int age) : this(name, age, '男', "fa")
        {
            this.Name = name;
            this.Age = age;
        }
        public Person(string name, int age, string job) : this(name, age)
        {
            this.Job = job;
        }
        public Person(string name) : this(name, 18, '女', "fasd")
        {
            this.Name = name;
        }

        public string Name
        {
            set
            {
                _name = string.IsNullOrEmpty(value) ? "路人甲" : value;
            }
            get
            {
                return string.IsNullOrEmpty(_name) ? "路人甲" : _name;
            }
        }

        public int Age
        {
            get
            {
                return _age == 0 || _age > 100 ? 0 : _age;
            }
            set
            {
                _age = value < 0 || value > 100 ? 0 : value;
            }
        }

        public char Gender
        {
            get
            {
                return _gender == '男' || _gender == '女' ? _gender : '男';
            }
            set
            {
                _gender = value == '男' || value == '女' ? value : '男';
            }
        }

        public string Job
        {
            set
            {
                _job = string.IsNullOrEmpty(_job) ? "暂无描述" : value;
            }
            get
            {
                return string.IsNullOrEmpty(_job) ? "暂无描述" : _job;
            }
        }

        public void Introduce()
        {
            Console.WriteLine("{0}有{1}大了，是个{2}生，职位是{3}，正在吃喝拉撒睡", this.Name, this.Age, this.Gender, this.Job);
        }

    }
}
