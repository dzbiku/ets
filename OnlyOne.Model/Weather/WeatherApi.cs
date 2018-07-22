using System.Net;

namespace OnlyOne.Model.Weather
{
    public class WeatherApi
    {
        public string CityName { get; set; }
        public string CountryCode { get; set; }
        private string ApiKey { get; } = "9817b68be1114bce73d71d5678d36925";
        private string HtmlAddress { get; } = "http://api.openweathermap.org/data/2.5/weather?q=";
        private string FullHtml { get; set; }
        private string FullJson { get; set; }
        public WeatherNow WeatherNow { get; set; }

        public void Call(string city, string countryCode = "PL")
        {
            CityName = city;
            CountryCode = countryCode;
            CreateFullHtml();

            using (WebClient client = new WebClient())
            {
                FullJson = client.DownloadString(FullHtml);
            }
            GetWeatherData(FullJson);
        }

        private void CreateFullHtml()
        {
            FullHtml = HtmlAddress + CityName + "," + CountryCode + "&APPID=" + ApiKey;
        }

        private void GetWeatherData(string jsonFromWeb)
        {
           WeatherNow = WeatherNow.FromJson(jsonFromWeb);
        }

    }
}
