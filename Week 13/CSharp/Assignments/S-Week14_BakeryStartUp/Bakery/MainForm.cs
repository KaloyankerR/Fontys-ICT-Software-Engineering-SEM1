using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using Microsoft.VisualBasic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.NetworkInformation;

namespace Bakery
{
    [Serializable]
    public class Serializable
    {
        public string name;
        public double price;

        public Serializable(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }

    public partial class MainForm : Form
    {
        int counter = 0;

        public MainForm()
        {
            InitializeComponent();

            // Init GUI
            lblSandwichInfo.Text = String.Empty;
        }

        private void btnAddSandwich_Click(object sender, EventArgs e)
        {
            SerializeObj();
            DeserializeObj();

            /*
            var sandwiches = new List<Demo>();
            var demo = new Demo();
            demo.Name = $"kur {this.counter}";
            demo.Price = 1.50;
            demo.Bread = "kur2";
            sandwiches.Add(demo);
            
            string? sandwichesJson = JsonSerializer.Serialize(sandwiches);
            File.WriteAllText("sandwiches.json", sandwichesJson);

            var sandwichesJson2 = File.ReadAllText("sandwiches.json");
            List<Demo>? sandwiches2 = JsonSerializer.Deserialize<List<Demo>>(sandwichesJson2);

            listBox1.Items.Clear();
            WriteSandwiches(sandwiches2);
             */

            //SerializeObj();
            //DeserializeObj();

            counter++;
        }

        private void SerializeObj()
        {
            FileStream stream = new FileStream("example.json", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Serializable s = new Serializable($"kur{counter}", 1.50);
            formatter.Serialize(stream, s);

            stream.Close();
        }

        private void DeserializeObj()
        {
            FileStream stream = new FileStream("example.json", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Serializable s = (Serializable)formatter.Deserialize(stream);
            string name = "Name: " + s.name;
            string price = "Price: " + s.price;

            listBox1.Items.Add(name);
            listBox1.Items.Add(price);

            stream.Close();
        }

        //private void SerializeObj()
        //{
        //    //Serializable serObj = new Serializable();
        //    //serObj.name = $"kur{counter}";
        //    //serObj.price = 1.50;

        //    var sandwiches = new List<Demo>();
        //    var demo = new Demo();
        //    demo.Name = $"kur {this.counter}";
        //    demo.Price = 1.50;
        //    demo.Bread = "kur2";
        //    sandwiches.Add(demo);

        //    IFormatter formatter = new BinaryFormatter();
        //    Stream stream = new FileStream("example.json", FileMode.Create, FileAccess.Write);

        //    formatter.Serialize(stream, sandwiches);
        //    stream.Close();
        //}

        //private void DeserializeObj()
        //{
        //    Stream stream = new FileStream("example.txt", FileMode.Create, FileAccess.Write);
        //    stream = new FileStream("example.txt", FileMode.Open, FileAccess.Read);

        //    IFormatter formatter = new BinaryFormatter();
        //    Serializable objNew = (Serializable)formatter.Deserialize(stream);

        //    listBox1.Items.Clear();
        //    listBox1.Items.Add(objNew);

        //}

        //public void WriteSandwiches(List<Demo> sandwiches)
        //{
        //    foreach (Demo sandwich in sandwiches)
        //    {
        //        listBox1.Items.Add(sandwich.GetInfo());
        //    }
        //}

    }
}
