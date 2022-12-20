using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace CsvFileHandling
{
    public class CsvExecutor
    {
        private string FilePath { get; set; }

        public CsvExecutor(string filePath)
        {
            FilePath = filePath;
        }
        
        public void ChangeFilePath(string newPath)
        {
            FilePath = newPath;
        }

        public void WriteInFile()
        {
            var myCarObjs = new List<Car>()
            {
                new Car {Brand = "BMW", Model = "X1", Year = 2016, Price = 36000},
                new Car {Brand = "Vag", Model = "Golf", Year = 2013, Price = 20000},
                new Car {Brand = "Citroen", Model = "C4", Year = 2018, Price = 18000}
            };

            using (var writer = new StreamWriter(FilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(myCarObjs);
            }
        }

        public void AppendToFile()
        {
            var myCarObjs = new List<Car>()
            {
                new Car {Brand = "Lambo", Model = "Aventador", Year = 2022, Price = 1000000},
                new Car {Brand = "Toyota", Model = "Yaris", Year = 2011, Price = 10000},
                new Car {Brand = "Volvo", Model = "XC90", Year = 2021, Price = 56000}
            };

            var configPersons = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false
            };

            using (var stream = File.Open(FilePath, FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, configPersons))
            {
                csv.WriteRecords(myCarObjs);
            }
        }

        public void ReadValues()
        {
            // string path = "C:\\Users\\User\\Downloads\\MOCK_CAR_DATA1.csv";
            string[] lines = System.IO.File.ReadAllLines(FilePath);
            List<string[]> values = new List<string[]>();

            foreach (string line in lines)
            {
                string[] column = line.Split(',');
                values.Add(column);
            }

            foreach (var value in values)
            {
                Console.WriteLine($"{value[0]} - {value[1]} - {value[2]} - {value[3]}");
            }
        }

    }
}
