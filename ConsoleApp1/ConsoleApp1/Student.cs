using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Student
    {
        public string name;
        public string surname;
        public string email;
        private string age;

        public int setAge(int count)
        {
            if (count > 18 && count < 100)
            {
                age = count.ToString();
            }
            return count;
        }
        public string getAge()
        {
            return age;
        }

    }
}
