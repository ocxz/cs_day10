using System;
using System.Collections.Generic;
using System.Text;

namespace _09_Classes
{
    public class Person
    {
        private string _name;
        private int _age;
        private char _gender;

        public Person() { }
        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public void SayHello()
        {
            Console.WriteLine("大家好，我是人类");
        }
    }

}
