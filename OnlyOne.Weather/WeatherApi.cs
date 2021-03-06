﻿using System.Net;

namespace OnlyOne.Weather
{
    public class WeatherApi
    {
        public string CityName { get; set; }
        public string CountryCode { get; set; }
        private string ApiKey { get; set; }
        private string HtmlAddress { get; } = "http://api.openweathermap.org/data/2.5/weather?q=";
        private string FullHtml { get; set; }
        private string FullJson { get; set; }
        public WeatherNow WeatherNow { get; set; }


        public void SetApiKey(string apiKey)
        {
            ApiKey = apiKey;
        }

        /// <summary>
        /// Call api- but remember, first you must set yout api key using SetApiKey() method
        /// </summary>
        /// <param name="city">City</param>
        /// <param name="countryCode">e.g PL, DE, US, etc.</param>
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
