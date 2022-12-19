using System;
using System.IO;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace CsvFileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\User\\Downloads\\MOCK_CAR_DATA1.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            List<string[]> values = new List<string[]>();

            foreach(string line in lines)
            {
                string[] column = line.Split(',');
                values.Add(column);
            }

            foreach (var value in values)
            {
                Console.WriteLine($"{value[0]} - {value[1]} - {value[2]} - {value[3]}");
            }

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
}
