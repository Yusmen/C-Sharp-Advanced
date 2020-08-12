using System;
using System.Linq;
using System.Collections.Generic;

namespace FilterByAge
{
    public class Person
    {


        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var currentPerson = Console.ReadLine()
                    .Split(", ");

                var person = new Person
                {
                    Name = currentPerson[0],
                    Age = int.Parse(currentPerson[1])


                };
                people.Add(person);
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Func<Person, bool> filter;

            if(condition=="older")
            {
                filter = p => p.Age >= age;
            }
            else
            {
                filter = p => p.Age < age;
            }
            string format = Console.ReadLine();

            Func<Person,string> select;

            if(format=="name age")
            {
                select = p => $"{p.Name} - {p.Age}";
            }
            else
            {
                select = p => $"{p.Name}";

            }

            people
                .Where(filter)
                .Select(select)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
