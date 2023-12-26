using System.Net.Http.Json;
using Newtonsoft.Json;

namespace AsynAwaitWeatherForcasting
{
    public class WeatherData
    {
        public MainData Main { get; set; }
    }

    public class MainData
    {
        public double Temp { get; set; }
    }

    internal class Program
    {
        static async Task Main(string[] args)
        {   string city = "vadodara";
            string api_key = "9a11a6aa7eaa61a100c03fecc049c6cf";
            string baseUrl = "https://api.openweathermap.org/data/2.5/weather";
            string apiUrl = $"{baseUrl}?q={city}&appid={api_key}&units=metric";
            WeatherData content =  await FetchWeatherDataAsync(apiUrl);
            Console.WriteLine($"{city} -{content.Main.Temp}");
           // Console.WriteLine(content);
        }

        // Call OpenWeatherMap API to fetch weather data h 
        // Create a C# object from the JSON response
        // Replace Task<string> with the C# object Task<WeatherData>
        static async Task<WeatherData> FetchWeatherDataAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Fetch web page content asynchronously using HttpClient
                    // Ensure a successful response before reading the content
                    // Read the content as a string
                    var response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string jsonContent = await response.Content.ReadAsStringAsync();

                    // Deserialize JSON content into WeatherData object
                    WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(jsonContent);

                    return weatherData;// Set the city property explicitly (assuming it's not part of the API response)
                    //  weatherData.City = "vadodara";
                    //  return weatherData;
                  //  return result;
                }
                catch (HttpRequestException ex)
                {
                    // Handle exception (e.g., network issues, HTTP errors)
                    Console.WriteLine($"Error: {ex.Message}");
                    WeatherData weatherData= new WeatherData();

                    // return string.Empty; // Return an empty string or handle the error accordingly
                    return weatherData;
                }
            }
            // Fetch web page content asynchronously using HttpClient
            throw new NotImplementedException();
        }
    }
}