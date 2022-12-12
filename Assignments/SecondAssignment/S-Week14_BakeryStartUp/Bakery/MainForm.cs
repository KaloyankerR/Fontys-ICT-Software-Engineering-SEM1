using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bakery
{
    public partial class MainForm : Form
    {
        Bakery bakery;

        public MainForm()
        {
            InitializeComponent();
            bakery = new Bakery("Dutch");

            // Init GUI
            lblSandwichInfo.Text = String.Empty;
        }

        private void btnAddSandwich_Click(object sender, EventArgs e)
        {
            AddForm addFrm = new AddForm();
            var result = addFrm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Sandwich newSandwich = new Sandwich(addFrm.GetName(), 1.50, addFrm.GetBread());   
                SerializeObj(newSandwich);
                DeserializeObj();

            } else if (result == DialogResult.No)
            {
                MessageBox.Show("Didnt fill!");
            } else
            {
                MessageBox.Show("An error occured!");
            }
        }

        private void SerializeObj(Sandwich newSandwich)
        {
            FileStream stream = new FileStream("example.json", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            // Sandwich = new Sandwich ($"kur{counter}", 1.50);
            formatter.Serialize(stream, newSandwich);
            stream.Close();
        }

        private void DeserializeObj()
        {
            FileStream stream = new FileStream("example.json", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Sandwich s = (Sandwich)formatter.Deserialize(stream);
            string name = "Name: " + s.Name;
            string price = "Price: " + s.BasePrice;
            string bread = "Bread: " + s.Bread;

            listBox1.Items.Add(name);
            listBox1.Items.Add(price);
            listBox1.Items.Add(bread);

            stream.Close();
        }

        public void AddSandwich(string sandwich)
        {
            bakery.AddSandwich(sandwich);
        }

        public void WriteInListBox()
        {
            listBox1.Items.Clear();

            foreach (string sandwich in bakery.GetSandwiches())
            {
                listBox1.Items.Add(sandwich);
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("example.json", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, "");

            stream.Close();
            DeserializeObj();
        }
    }
}
