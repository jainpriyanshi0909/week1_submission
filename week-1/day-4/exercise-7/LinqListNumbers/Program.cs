namespace LinqListNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers
            List<int> numbers = new List<int> { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

            // Use LINQ to perform the following operations:
            // 1. Find all even numbers
            var EvenNo = numbers.Where(x => x%2==0).ToList();
            // 2. Find all numbers greater than a specific value (e.g., 20)
            var NumberGreaterThan20 = numbers.Where(x => x>20).ToList();
            // 3. Calculate the sum of all numbers
            int TotalSum = numbers.Sum(x => x);
            // 4. Calculate the average of all numbers
            double average = numbers.Average(x => x);
            // 5. Find the minimum and maximum values in the list
            int MinNo = numbers.Min(x => x);
            int MaxNo = numbers.Max(x => x);

        }
    }
}