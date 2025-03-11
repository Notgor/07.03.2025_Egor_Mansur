using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._2025
{

    internal class Class12
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string City { get; set; }

            public Person(string name, int age, string city)
            {
                Name = name;
                Age = age;
                City = city;
            }

            public override string ToString()
            {
                return $"Name: {Name}, Age: {Age}, City: {City}";
            }
        }
        public static void Execute()
        {
            Person person = new Person("Иван", 25, "Москва");
            Console.WriteLine(person.ToString());
        }
    }
}
