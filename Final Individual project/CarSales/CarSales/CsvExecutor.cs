using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarSales;
using CsvHelper;
using CsvHelper.Configuration;

namespace CsvFileHandling
{
    public class CsvExecutor
    {
        private string FilePath { get; set; }

        private int RecordCounter { get; set; }

        public CsvExecutor(string filePath)
        {
            FilePath = filePath;
        }

        //public void ChangeFilePath(string newPath)
        //{
        //    FilePath = newPath;
        //}

        public void OverrideRecords(List<Car> myObjs)
        {
            List<Car> objectsToAdd = myObjs;

            using (var writer = new StreamWriter(FilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(objectsToAdd);
            }
        }

        public void AppendRecord(Car newCar)
        {
            var configPersons = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false
            };

            using (var stream = File.Open(FilePath, FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, configPersons))
            {
                csv.WriteRecord(newCar);
            }
        }

        public void AppendMultipleRecords(List<Car> myObjs)
        {
            //var myCarObjs = new List<Car>()
            //{
            //    new Car {Brand = "Lambo", Model = "Aventador", Year = 2022, Price = 1000000},
            //    new Car {Brand = "Toyota", Model = "Yaris", Year = 2011, Price = 10000},
            //    new Car {Brand = "Volvo", Model = "XC90", Year = 2021, Price = 56000}
            //};

            var configPersons = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false
            };

            using (var stream = File.Open(FilePath, FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, configPersons))
            {
                csv.WriteRecords(myObjs);
            }
        }

        // Used in reading the cars
        public List<string[]> ReadRecords()
        {
            string[] lines = System.IO.File.ReadAllLines(FilePath);
            
            // Without headers
            lines = lines.Skip(1).ToArray();
            List<string[]> values = new List<string[]>();
            this.RecordCounter = values.Count;

            foreach (string line in lines)
            {
                string[] column = line.Split(',');
                values.Add(column);
            }

            return values;
        }

    }
}

