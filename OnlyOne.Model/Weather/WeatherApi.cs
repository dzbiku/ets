using System;
using System.Collections.Generic;
using System.Text;

namespace OnlyOne.Model.Weather
{
    public class WeatherApi
    {
        public string ApiKey { get; set; }
        public string CityName { get; set; }
        public string CountryCode { get; set; }
        public string HtmlAddress { get; set; }

        public WeatherApi(string apiKey,string city,string countryCode, string htmlAddress)
        {
            ApiKey = apiKey;
            CityName = city;
            CountryCode = countryCode;
            HtmlAddress = htmlAddress;
        }
    }
}
