using System;

namespace LinqFilterAndSort
{
     public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            // Create a list of Person objects
            List<Person> people = new List<Person>
            {
            new Person { FirstName = "John", LastName = "Doe", Age = 30 },
            new Person { FirstName = "Alice", LastName = "Smith", Age = 25 },
            new Person { FirstName = "Bob", LastName = "Johnson", Age = 11 },
            };
            // Use LINQ to filter and sort the list
            var PeopleAbove18 = people.Where(person => person.Age > 18).OrderBy(person => person.LastName).ToList();

            // Print the filtered and sorted list of people to the console
            foreach(var person in PeopleAbove18)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} has age {person.Age}");
            }
        }

    }
}