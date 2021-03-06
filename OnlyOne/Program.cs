﻿using System;
using OnlyOne.Camera;
using OnlyOne.Model;
using OnlyOne.Model.CSV;
using OnlyOne.Weather;

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
            apiMain.SetApiKey("9817b68be1114bce73d71d5678d36925");
            apiMain.Call("Wroclaw");

            VideoTools vdtools = new VideoTools();
            vdtools.Capture();
            //vdtools.Save();

            Console.ReadLine();
        }
    }
}
