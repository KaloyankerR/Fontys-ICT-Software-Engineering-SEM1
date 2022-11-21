using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckManagement
{
    internal class Truck
    {
        private string name;
        private int maxNumPallets;
        private int maxNumBoxes;
        private double costFullPallet;
        private double costBox;

        public Truck(string name, int maxNumPallets, int maxNumBoxes, double costFullPallet, double costBox)
        {
            this.name = name;
            this.maxNumPallets = maxNumPallets;
            this.maxNumBoxes = maxNumBoxes;
            this.costFullPallet = costFullPallet;
            this.costBox = costBox;
        }
        public double CalculateCost(int boxesToShip)
        {
            double result = 0;

            int palletsCost = (boxesToShip / maxNumBoxes);
            int extraBoxes = (boxesToShip % maxNumBoxes);

            // double result = ();

            return result;
        }
    }
}
