using Newtonsoft.Json;

namespace BITS24_C21
{
    public partial class RainVine : Form
    {
        public RainVine()
        {
            InitializeComponent();
        }
        private async void SubmitBtn_Click(object sender, EventArgs e)
        {
            string city = CityNameTxt.Text.Trim();
            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Please enter a city name.");
                return;
            }
            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid=9d860ed2402b7b7c2710e2d9c073ffc4&units=metric";
            using var client = new HttpClient();
            try
            {
                var response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(responseBody);

                DisplayWeatherData(weatherData);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error fetching weather data: {ex.Message}");
            }
        }
        private void DisplayWeatherData(WeatherData weatherData)
        {
            DateTime sunriseTimeUtc = DateTimeOffset.FromUnixTimeSeconds(weatherData.Sys.Sunrise).DateTime;
            DateTime sunsetTimeUtc = DateTimeOffset.FromUnixTimeSeconds(weatherData.Sys.Sunset).DateTime;
            TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
            TimeSpan offset = localTimeZone.GetUtcOffset(sunriseTimeUtc);
            DateTime sunriseLocalTime = sunriseTimeUtc + offset;
            DateTime sunsetLocalTime = sunsetTimeUtc + offset;

            if (weatherData.Weather.Length > 0)
            {
                WeatherLbl.Text = $"It is currently {weatherData.Weather[0].Description} in {weatherData.Name}.";
            }
            else
            {
                WeatherLbl.Text = $"Weather information is not available in {weatherData.Name}.";
            }
            CityNameLbl.Text = $"{weatherData.Name}";
            TempLbl.Text = $"{weatherData.Main.Temp}°C";
            FeelsLikeLbl.Text = $"{weatherData.Main.Feels_Like}°C";
            HumidLbl.Text = $"{weatherData.Main.Humidity}%";
            WindSpLbl.Text = $"{weatherData.Wind.Speed} m/s";
            SunriseLbl.Text = $"{sunriseLocalTime.ToString("HH:mm:ss")}";
            SunsetLbl.Text = $"{sunsetLocalTime.ToString("HH:mm:ss")}";
        }
    }
    public class WeatherData
    {
        public string Name { get; set; }
        public MainData Main { get; set; }
        public WindData Wind { get; set; }
        public WeatherInfo[] Weather { get; set; }
        public SysData Sys { get; set; }
    }
    public class SysData
    {
        public long Sunrise { get; set; }
        public long Sunset { get; set; }
    }
    public class MainData
    {
        public float Temp { get; set; }
        public int Humidity { get; set; }
        public float Feels_Like { get; set; }
    }

    public class WindData
    {
        public float Speed { get; set; }
    }

    public class WeatherInfo
    {
        public string Description { get; set; }
    }
}
