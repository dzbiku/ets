using System;
using OnlyOne.Model;
using OnlyOne.Model.CSV;
using OnlyOne.Model.Weather;

namespace OnlyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FileModel _file = new FileModel(@"C:\Users\OnlyOne\source\repos\dev_test\DaneDoWypelnienia\moc_dostarczona.csv");
            Csv csv = Reader.Read(_file, ';', true);


            WeatherApi apiMain = new WeatherApi();
            string jsonFromWeb =apiMain.Call("Wroclaw");
            var Weather = WeatherNow.FromJson(jsonFromWeb);
            Console.ReadLine();
        }
    }
}
