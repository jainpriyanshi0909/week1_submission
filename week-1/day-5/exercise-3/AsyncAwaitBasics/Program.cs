using System.Diagnostics;
using System.Threading.Tasks;

namespace AsyncAwaitBasics
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Call PerformCalculations and measure time taken using Stopwatch
            int numberOfTasks = 5;
            Stopwatch stopwatch = Stopwatch.StartNew();
            await PerformCalculations(numberOfTasks);
            stopwatch.Stop();
            Console.WriteLine($"{stopwatch.Elapsed.TotalSeconds}");
        }

        static async Task SimulateLongRunningTask(int delayInSeconds)
        {
            await Task.Delay(TimeSpan.FromSeconds(delayInSeconds));
            // Implement long-running task simulation
        }

        static async Task PerformCalculations(int numberOfTasks)
        {
            // Start long-running tasks concurrently and wait for them to complete
            Task[] result = new Task[numberOfTasks];
            for (int i = 0; i < numberOfTasks; i++)
            { int delayInSeconds = 6;
                result[i] = SimulateLongRunningTask(delayInSeconds);
            }
              await Task.WhenAll(result);


        }
    }
}