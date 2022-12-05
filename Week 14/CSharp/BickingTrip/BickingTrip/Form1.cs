using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BickingTrip
{
    public partial class Form1 : Form
    {
        private List<string> desitinations;
        private List<double> distances;
        private List<double> ratings;

        public Form1()
        {
            InitializeComponent();

            this.desitinations = new List<string>();
            this.distances = new List<double>();
            this.ratings = new List<double>();
            // Add some dummy trips
            this.desitinations.Add("Amsterdam");
            this.distances.Add(121);
            this.ratings.Add(4);
            this.desitinations.Add("Rome");
            this.distances.Add(1532);
            this.ratings.Add(4);
            this.desitinations.Add("Paris");
            this.distances.Add(447);
            this.ratings.Add(3.5);
            this.desitinations.Add("Amsterdam");
            this.distances.Add(121);
            this.ratings.Add(4.5);
            this.desitinations.Add("Paris");
            this.distances.Add(447);
            this.ratings.Add(5);
            this.desitinations.Add("Amsterdam");
            this.distances.Add(121);
            this.ratings.Add(2);            
            btnShowAll_Click(this, EventArgs.Empty);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string destination = tbxTo.Text;
            double distance = Convert.ToDouble(nudDistance.Value); 
            double rating = Convert.ToDouble(nudRating.Value);


            if (!String.IsNullOrEmpty(destination) && distance > 0)
            {
                this.desitinations.Add(destination);
                this.distances.Add(distance);
                this.ratings.Add(rating);

                lbxMyTrips.Items.Add(destination);
                tbxTo.Clear();
                nudDistance.Value = 0m;
                nudRating.Value = 0m;
            }
            else
            {
                MessageBox.Show("Please supply a valid destination and/or distance");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbxMyTrips.SelectedIndex > -1)
            {
                int index = this.desitinations.IndexOf(lbxMyTrips.SelectedItem.ToString());
                if (index > -1)
                {
                    this.desitinations.RemoveAt(index);
                    this.distances.RemoveAt(index);
                    this.ratings.RemoveAt(index);

                    lbxMyTrips.SelectedIndex = -1;
                }
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (lbxMyTrips.SelectedIndex > -1)
            {
                int index = this.desitinations.IndexOf(lbxMyTrips.SelectedItem.ToString());
                if (index > -1)
                {
                    MessageBox.Show($"{this.desitinations[index]}: {this.distances[index]}KM | rating {this.ratings[index]}/4)");
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            lbxMyTrips.Items.Clear();
            foreach (string to in this.desitinations)
            {
                lbxMyTrips.Items.Add(to);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            lbxMyTrips.Items.Clear();

            string query = tbxSearch.Text;
            foreach (string to in this.desitinations)
            {
                if (to.Contains(query))
                {
                    lbxMyTrips.Items.Add(to);
                }
            }
        }
    }
}
