using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Group
    {
        public string name;
        public Teacher teachers = new Teacher();
        public Student[] students = new Student[10];
    }
}
