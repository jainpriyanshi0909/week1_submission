namespace LinqGroupAggregate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Product objects
            List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Category = "Electronics", Price = 1200.00M },
            new Product { Name = "Smartphone", Category = "Electronics", Price = 800.00M },
            new Product { Name = "Headphones", Category = "Electronics", Price = 200.00M },
            new Product { Name = "Shirt", Category = "Clothing", Price = 30.00M },
            new Product { Name = "Jeans", Category = "Clothing", Price = 60.00M },
            new Product { Name = "Sneakers", Category = "Footwear", Price = 100.00M }
        };

            // Use LINQ to perform the following operations:
            // 1. Group products by category
            var grouped = products.GroupBy(p => p.Category);
            foreach (var group in grouped)
            {
                var groups = group.Select(product => product);
                foreach (var x in groups)
                { Console.WriteLine(x.Name); }
            }
            // 2. Count the number of products in each category
            foreach (var group in grouped)
            { Console.WriteLine($"{group.Key} {group.Count()}");
            }
            // 3. Calculate the total price of products in each category
            foreach (var group in grouped) {
                var SumOfGroup = group.Sum(product => product.Price);
                Console.WriteLine($"{group.Key} {SumOfGroup}");
            }
            // 4. Find the most expensive product in each category
            foreach (var group in grouped)
            {
                var MaxOfGroup = group.Max(product => product.Price);
                Console.WriteLine($"{group.Key} {MaxOfGroup}");
            }
        }
    }
}