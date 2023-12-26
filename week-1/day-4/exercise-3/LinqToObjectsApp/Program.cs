namespace LinqToObjectsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "John", Age = 25, Country = "USA" },
                new Person { Name = "Jane", Age = 30, Country = "Canada" },
                new Person { Name = "Mark", Age = 28, Country = "USA" },
                new Person { Name = "Emily", Age = 22, Country = "Australia" }
            };


            //Write queries using LINQ for following operations
            //1. Get all people from USA
            var PersonFromUSA = people.Where(person => person.Country== "USA");
           
            foreach (var p in PersonFromUSA)
            {
                Console.WriteLine(p.Name);
            }
            //2. Get all people above 30
            var PersonAbove30 = people.Where(person => person.Age >= 30);
            foreach (var p in PersonAbove30)
            {
                Console.WriteLine($"{p.Name} - {p.Age}");
            }
            //3. Sort people by name
            var PesonInSortedManner = people.OrderBy(person => person.Name);
            foreach(var p in PesonInSortedManner)
            {
                Console.WriteLine(p.Name);
            }

            //4. Project/Select only Name and Country of all people
            var OnlyNameAndCountry = people.Select(person => (person.Name,person.Country));
            foreach(var p in OnlyNameAndCountry)
            {
                Console.WriteLine(p.Country);
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
    }
}