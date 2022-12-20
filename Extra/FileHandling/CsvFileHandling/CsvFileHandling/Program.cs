using System;
using System.Globalization;
using System.IO;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using CsvHelper;
using CsvHelper.Configuration;

namespace CsvFileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            CsvExecutor csvEx = new CsvExecutor("cars.csv");
            csvEx.WriteInFile();
        }

        public void Test1()
        {
            //var values = String[];
            List<Array> readings = new List<Array>();

            using (var reader = new StreamReader("C:\\Users\\User\\Downloads\\MOCK_CAR_DATA1.csv"))
            {
                List<string> brand = new List<string>();
                List<string> model = new List<string>();
                List<int> year = new List<int>();
                List<double> price = new List<double>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',').ToArray();
                    readings.Add(values);

                    // brand.Add(values[0]);
                    // model.Add(values[1]);
                    //year.Add(yearCell);
                    //price.Add(Double.Parse(values[3]));
                }

                foreach (var value in readings)
                {
                    Console.WriteLine($"{value}");
                }


            }
        }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
    }

}
