using static System.Windows.Forms.Design.AxImporter;

namespace PizzaToppings
{
    public partial class Form1 : Form
    {
        private double totalPrice = 5.00;
        List<int> toppingsList = new List<int>();
        enum Toppings
        {
            CHEESE, 
            TOMATOES, 
            MUSHROOMS, 
            EGG, 
            ONIONS,
            ANCHOVIES, 
            HAM, 
            PEPPERS
        }

        public Form1()
        {
            InitializeComponent();
            this.AddToComboBox();
        }

        private void AddToComboBox()
        {
            foreach(string topping in Enum.GetNames(typeof(Toppings)))
            {
                cmbboxToppings.Items.Add(topping);
            }
        }

        private void GetLabels()
        {
            lblToppings.Text = $"Pizza with: {this.GetToppings()}";
            lblPrice.Text = $"Price: {this.totalPrice:N2}";
        }
        
        private int GetToppingIndex(string name)
        {
            switch (name)
            {
                case "CHEESE":
                    return (int)Toppings.CHEESE;
                case "TOMATOES":
                    return (int)Toppings.TOMATOES;
                case "MUSHROOMS":
                    return (int)Toppings.MUSHROOMS;
                case "EGG":
                    return (int)Toppings.EGG;
                case "ONIONS":
                    return (int)Toppings.ONIONS;
                case "ANCHOVIES":
                    return (int)Toppings.ANCHOVIES;
                case "HAM":
                    return (int)Toppings.HAM;
                case "PEPPERS":
                    return (int)Toppings.PEPPERS;
                default:
                    return 0;
                //case default:
                //    return 0;

            }
        }

        private string GetToppings()
        {
            string result = "";

            foreach(int topping in toppingsList)
            {
                Toppings toppingInd = (Toppings)topping;
                result += $"{toppingInd.ToString()}, ";
            }

            return result;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = cmbboxToppings.Text;

            this.toppingsList.Add(this.GetToppingIndex(name));
            this.totalPrice += 0.50;

            this.GetLabels();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.totalPrice = 5.00;
            toppingsList.Clear();
            this.GetLabels();
        }
    }
}