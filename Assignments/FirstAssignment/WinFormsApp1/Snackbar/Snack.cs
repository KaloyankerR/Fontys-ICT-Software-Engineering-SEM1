using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackbar
{
    internal class Snack
    {
        private string name;
        private double price;
        private int quantity;
        private bool amountInStock;

        public Snack(string name, double price, int quantity, bool amountInStock)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.amountInStock = amountInStock;
        }
        public Snack(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.amountInStock = this.quantity > 0 ? true : false;
        }

        public bool DecreaseStock(int amount)
        {
            if (this.quantity - amount >= 0)
            {
                this.quantity -= amount;
                this.amountInStock = this.quantity > 0 ? true : false;
                return true;
            }
            return false;

        }

        public string GetName()
        {
            return this.name;
        }

        public string GetPrice()
        {
            return Convert.ToString(this.price);
        }

        public string GetQuantity()
        {
            return this.quantity.ToString();
        }

        public string GetInfo()
        {
            return $"{this.name} - {this.price}$";
        }

        public string GetAmountInStock()
        {
            return Convert.ToString(this.quantity);
        }

        public bool CanDecrease(int amount)
        {
            if (this.quantity - amount >= 0)
            {
                return true;
            }
            return false;
        }

        public void SetPrice(double newPrice)
        {
            this.price = newPrice;
        }
        public void SetQuantity(int newQuantity)
        {
            this.quantity = newQuantity;
        }
    }
}
