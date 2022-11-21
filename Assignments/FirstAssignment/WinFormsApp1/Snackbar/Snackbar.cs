using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackbar
{
    internal class Snackbar
    {
        //List<Snack> snacksPre = new List<Snack>()
        //{
        //    new Snack("Chips", 2.50, 10),
        //    new Snack("Kitkat", 3.00, 15),
        //    new Snack("Hrupanki", 0.60, 20)
        //};

        List<Snack> snack = new List<Snack>();

        public Snackbar()
        {
            // List<Snack> snacks = snacksPre;
            this.AddSnacks("Chips", 2.50, 10);
            this.AddSnacks("Kitkat", 3.00, 15);
            this.AddSnacks("Hrupanki", 0.60, 20);
        }

        private void AddSnacks(string name, double price, int quantity)
        {
            Snack snack = new Snack(name, price, quantity);
            this.snack.Add(snack);
        }

        public double ProcessOrder(int snack1, int snack2, int snack3)
        {
            double orderPrice = 0;

            if (snack[0].CanDecrease(snack1) && snack[1].CanDecrease(snack2) &&
                snack[2].CanDecrease(snack3)){

                snack[0].DecreaseStock(snack1);
                orderPrice += Convert.ToDouble(snack[0].GetPrice()) * snack1;

                snack[1].DecreaseStock(snack2);
                orderPrice += Convert.ToDouble(snack[1].GetPrice()) * snack2;

                snack[2].DecreaseStock(snack3);
                orderPrice += Convert.ToDouble(snack[2].GetPrice()) * snack3;
                return orderPrice;
            }
            return 0;
            
            //if (snack[0].DecreaseStock(snack1))
            //{
            //    orderPrice += Convert.ToDouble(snack[0].GetPrice()) * snack1;
            //}
            
            //if (snack[1].DecreaseStock(snack2))
            //{
            //    orderPrice += Convert.ToDouble(snack[1].GetPrice()) * snack2;
            //} 
            
            //if (snack[2].DecreaseStock(snack3))
            //{
            //    orderPrice += Convert.ToDouble(snack[2].GetPrice()) * snack3;
            //}

            
        }

        public string GetInfo(int index)
        {
            return snack[index].GetInfo();
        }

        public string GetSnackName(int index)
        {
            return snack[index].GetName();
        }
            
        public Snack GetSnack(string name)
        {
            for (int i = 0; i < this.snack.Count; i++)
            {
                if (snack[i].GetName() == name)
                {
                    return snack[i];
                }
            }
            return null;
            
        }
    }
};