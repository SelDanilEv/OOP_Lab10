using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Student
    {
        private int _age;
        private int _course;
        private string _name;

        public Student(int age,int course,string name)
        {
            _age = age;
            _course = course;
            _name = name;
        }

        public override string ToString()
        {
            return "Name: " + _name + "\tCourse: " + _course+"\tAge"+_age;
        }
    }
}
