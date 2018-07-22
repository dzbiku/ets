using System.Net;

namespace OnlyOne.Model.Weather
{
    public class WeatherApi
    {
        public string CityName { get; set; }
        public string CountryCode { get; set; }
        private string ApiKey { get; } = "9817b68be1114bce73d71d5678d36925";
        private string HtmlAddress { get; } = "http://api.openweathermap.org/data/2.5/weather?q=";


        public string Call(string city, string countryCode = "")
        {
            CityName = city;
            CountryCode = countryCode;
            var url = HtmlAddress + CityName + "," + CountryCode + "&APPID=" + ApiKey;
            using (WebClient client = new WebClient())
            {
                return client.DownloadString(url);
            }
        }

    }
}
