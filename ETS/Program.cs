using System;
using OnlyOne.Model;
using OnlyOne.Model.CSV;

namespace OnlyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FileModel _file = new FileModel(@"");
            Csv csv = Reader.Read(_file, ';', true);
            
            Console.ReadLine();
        }
    }
}
