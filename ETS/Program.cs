using System;
using System.Data;
using ETS.Model;
using ETS.Model.CSV;

namespace ETS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FileModel _file = new FileModel(@"");
            Csv dataTableAfterConver = Reader.ConvertToDataTable(_file, ';', true);
            
            Console.ReadLine();
        }
    }
}
