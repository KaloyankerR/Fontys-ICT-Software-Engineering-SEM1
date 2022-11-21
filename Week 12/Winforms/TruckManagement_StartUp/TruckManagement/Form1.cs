using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckManagement
{

    public partial class Form1 : Form
    {
        List<Truck> trucks = new List<Truck>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddTruck_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int maxPallets = Convert.ToInt32(tbxMaxPallets.Text);
            int maxBoxes = Convert.ToInt32(tbxMaxBoxesPerPallet.Text);
            double costPallet = Convert.ToDouble(tbxCostPallet.Text);
            double costBox = Convert.ToDouble(tbxCostBox.Text);

            Truck currentTruck = new Truck(name, maxPallets, 
                maxBoxes, costPallet, costBox);


        }
    }
}
