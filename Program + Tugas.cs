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
            Person person = new Person("John", 20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Drake", 66, "11115555", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("Miss", 45, "160800", "Misssalah@gmail.com");
            student.GetNameAndAge();

            Console.ReadKey();

        }
    }
}
