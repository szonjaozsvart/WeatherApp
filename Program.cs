// See https://aka.ms/new-console-template for more information

namespace WeatherApp;
class Program
{
    static async Task Main(string[] args)
    {
        var client = new HttpClient();
        var response = await client.GetAsync("http://api.openweathermap.org/data/2.5/weather?q=Budapest&appid=my_api");
        var content = await response.Content.ReadAsStringAsync();
        Console.WriteLine(content);
    }
}