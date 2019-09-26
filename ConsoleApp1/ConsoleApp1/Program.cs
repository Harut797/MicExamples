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
            Student[] student = new Student[50];
            Teacher[] teacher = new Teacher[5];
            for (int i = 0; i < teacher.Length; i++)
            {
                teacher[i] = new Teacher();
                teacher[i].name = randomNames();
                teacher[i].surname = randomSurNames();
                teacher[i].number = randomNumbers();
                teacher[i].specialty = randomSpecs();
            }
            for (int i = 0; i < student.Length; i++)
            {
                student[i] = new Student();
                student[i].name = randomNames();
                student[i].surname = randomSurNames();
                student[i].email = randomEmails();
                student[i].setAge(randomAges());
                Thread.Sleep(20);
            }
            Console.WriteLine("Name" + "\t" + "Surname" + "\t" + "\t" + "Email" + "\t" + "\t" + "\t" + "Age");
            for (int i = 0; i < 50; i++)
            {

                Console.WriteLine("Student N~" + i);
                Console.WriteLine(student[i].name + "\t" + student[i].surname + "\t" + student[i].email + "\t" + student[i].getAge());
            }
        }
        static string randomNames()
        {
            Random rnd = new Random();

            int randNamesNumber;
            randNamesNumber = rnd.Next(1, 100);
            string randNames = $"Name{randNamesNumber}";
            return randNames;
        }
        static string randomSurNames()
        {
            Random rnd = new Random();

            int randSurNamesNumber;
            randSurNamesNumber = rnd.Next(1, 100);
            string randSurNames = $"Surname{randSurNamesNumber}";
            return randSurNames;
        }
        static string randomEmails()
        {
            Random rnd = new Random();

            int randEmailNumber;
            randEmailNumber = rnd.Next(1, 10000000);
            string randEmails = $"{randEmailNumber}@gmail.com";
            return randEmails;
        }
        static int randomAges()
        {
            Random rnd = new Random();
            int randAge = rnd.Next(1, 100);
            return randAge;
        }
        static int randomNumbers()
        {
            Random rnd = new Random();
            int randNumber = rnd.Next(100000000, 999999999);
            return randNumber;
        }
        static int randomNumber()
        {
            Random rnd = new Random();
            int randNumber = rnd.Next(0, 4);
            return randNumber;
            //Test
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
            //Test
            Console.WriteLine("Hello);
        }
    }
}
