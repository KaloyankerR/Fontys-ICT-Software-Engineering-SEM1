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
        Trips trips;

        public Form1()
        {
            InitializeComponent();
            trips = new Trips();  
            
            btnShowAll_Click(this, EventArgs.Empty);
        }

        public void ShowAllTrips()
        {
            lbxMyTrips.Items.Clear();

            foreach (Trip trip in trips.GetTrips())
            {
                lbxMyTrips.Items.Add(trip.GetInfo());
            }
        }

        public void DeleteTrip(int ind)
        {
            trips.DeleteTrip(ind);
            ShowAllTrips();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Trip trip = new Trip(tbxTo.Text, Convert.ToDouble(nudDistance.Text), nudRating.Text);
            trips.AddTrip(trip);
            
            tbxTo.Text = "";
            nudDistance.Text = "";
            nudRating.Text = "";
            ShowAllTrips();
            tbpgTrips.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ind = lbxMyTrips.SelectedIndex;
            DeleteTrip(ind);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            int ind = lbxMyTrips.SelectedIndex;
            MessageBox.Show(trips.GetTripInfo(ind),"Trip information");
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowAllTrips();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // List<Trip> searchedTrips = trips.GetTrips().Where(trip.Destination == tbxSearch.Text).ToList();
            List<Trip> searchedTrips = new List<Trip>();

            foreach(Trip trip in trips.GetTrips())
            {
                if (trip.Destination == tbxSearch.Text)
                {
                    searchedTrips.Add(trip);
                }
            }

            lbxMyTrips.Items.Clear();

            foreach(Trip trip in searchedTrips)
            {
                lbxMyTrips.Items.Add(trip.Destination);
            }

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            lbxMyTrips.Items.Clear();
        }
        
    }
}
