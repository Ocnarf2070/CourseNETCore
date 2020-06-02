using School;
using System;

namespace CSharpPropieties
{
    class Program
    {
        static void Main(string[] args)
        {

            var s1 = new Studients()
            {
                Name = "Jose",
                Age = 25,
                Score = 55.6
            };

            var s2 = new Studients()
            {
                Name = "Rosa",
                Age = 24,
                Score = 70.5
            };

            var s3 = new Studients()
            {
                Name = "Alex",
                Age = 25,
                Score = 70
            };

            var s4 = new Studients()
            {
                Name = "Ana",
                Age = 26,
                Score = 50
            };

            var school = new School_();
            school.addStudient(s1);
            school.addStudient(s2);
            school.addStudient(s3);
            school.addStudient(s4);
            bool value = false;
            do
            {
                Console.Write("Introduce the name of the studient: ");
                String name = Console.ReadLine();
                value = school.searchStudient(name);
            } while (value);

        }
    }
}
