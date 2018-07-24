using System;
using OnlyOne.Model;
using OnlyOne.Model.CSV;
using OnlyOne.RPI;
using OnlyOne.Weather;

namespace OnlyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //FileModel _file = new FileModel(@"C:\Users\OnlyOne\source\repos\dev_test\DaneDoWypelnienia\moc_dostarczona.csv");
            //Csv csv = Reader.Read(_file, ';', true);


            //WeatherApi apiMain = new WeatherApi();
            //apiMain.SetApiKey("9817b68be1114bce73d71d5678d36925");
            //apiMain.Call("Wroclaw");

            Console.WriteLine("Test capture....");
            //Test tst = new Test();
            //tst.TestCaptureImage();

            Video.Video vd = new Video.Video();
            //vd.Capture();
            vd.testedtest();


            Console.ReadLine();
        }
    }
}
