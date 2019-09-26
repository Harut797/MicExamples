using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] student = new Student[51];
            Teacher[] teacher = new Teacher[5];
            Group[] group = new Group[5];
            for (int i = 0; i < student.Length; i++)
            {
                student[i] = new Student();
                student[i].name = randomNames();
                student[i].surname = randomSurNames();
                student[i].email = randomEmails();
                student[i].setAge(randomAges());
                Thread.Sleep(40);
            }
            int test = 1;
            for (int i = 0; i < teacher.Length; i++)
            {
                teacher[i] = new Teacher();
                teacher[i].name = randomNames();
                teacher[i].surname = randomSurNames();
                teacher[i].number =  randomNumbers();
                teacher[i].specialty = randomSpecs();
                Thread.Sleep(20);
                
                for (int k = 0; k < 10; k++)
                {
                    teacher[i].students[k] = new Student();
                    teacher[i].students[k].name = student[test].name;
                    teacher[i].students[k].surname = student[test].surname;
                    teacher[i].students[k].email = student[test].email;
                    test++;
                }
            }
            for (int i = 0; i < group.Length; i++)
            {
                group[i] = new Group();
                group[i].name = "Group N` " + i;
                group[i].teachers = teacher[i];
                for (int j = 0; j < 10; j++)
                {
                    group[i].students[j] = teacher[i].students[j];
                }
                
            }
            int index = 0;
            for (int i = 0; i < group.Length; i++)
            {
                Console.WriteLine($"----------------- Group N {i+1}-----------------");
                Console.WriteLine($"-------- Teacher  --------");
                Console.WriteLine(teacher[i].name +"\t"+ teacher[i].surname + "\t" + teacher[i].number + "\t" + teacher[i].specialty);
                Console.WriteLine("--------- Students ---------");
                for (int j = 0; j < teacher[i].students.Length; j++)
                {
                    Console.WriteLine(student[index].name + "\t" + student[index].surname + "\t" + student[index].email + "\t");
                    index++;
                }
              

            }
        }
        static string randomNames()
        {
            Random rnd = new Random();

            int randNamesNumber;
            randNamesNumber = rnd.Next(10000, 99999);
            string randNames = $"Name{randNamesNumber}";
            return randNames;
        }
        static string randomSurNames()
        {
            Random rnd = new Random();

            int randSurNamesNumber;
            randSurNamesNumber = rnd.Next(10000, 99999);
            string randSurNames = $"Surname{randSurNamesNumber}";
            return randSurNames;
        }
        static string randomEmails()
        {
            Random rnd = new Random();

            int randEmailNumber;
            randEmailNumber = rnd.Next(10000000, 99999999);
            string randEmails = $"{randEmailNumber}@gmail.com";
            return randEmails;
        }
        static int randomAges()
        {
            Random rnd = new Random();
            int randAge = rnd.Next(10, 99);
            return randAge;
        }
        static int randomNumbers()
        {
            Random rnd = new Random();
            int randNumber = rnd.Next(10000000, 99999999);
            return randNumber;
        }
        static int randomNumber()
        {
            Random rnd = new Random();
            int randNumber = rnd.Next(0, 4);
            return randNumber;
        }
        static string randomSpecs()
        {
            int rand = randomNumber();
            string[] specs = new string[4];
            specs[0] = "C#";
            specs[1] = "C++";
            specs[2] = "JavaScript";
            specs[3] = "PHP";
            return specs[rand];
        }
    }
}
