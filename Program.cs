using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "John";
            person.Age = 20;
            person.GetNameAndAge();

            Teacher teacher = new Teacher();
            teacher.Name = "Drake";
            teacher.Age = 66;
            teacher.TeacherId = "11115555";
            teacher.Subject = "Math";
            teacher.GetNameAndAge();

            Student student = new Student();
            student.Name = "Miss";
            student.Age = 45;
            student.StudentId = "160800";
            student.Email = "Misssalah@gmail.com";
            student.GetNameAndAge();

            Console.ReadKey();

        }
    }
}
