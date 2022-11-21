namespace Snackbar
{
    public partial class Form1 : Form
    {
        Snackbar snackBar;
        public Form1()
        {
            InitializeComponent();
            snackBar = new Snackbar();

            label1.Text = $"{snackBar.GetInfo(0)}";
            label2.Text = $"{snackBar.GetInfo(1)}";
            label3.Text = $"{snackBar.GetInfo(2)}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            cbxSnack.Items.Add(snackBar.GetSnackName(0));
            cbxSnack.Items.Add(snackBar.GetSnackName(1));
            cbxSnack.Items.Add(snackBar.GetSnackName(2));

            //string num1 = numupdwnFirstSnack.Text;
            //string num2 = numupdwnSecondSnack.Text;
            //string num3 = numupdwnThirdSnack.Text;

            //if (num1 == "0" && num2 == "0" && num3 == "0")
            //{
            //    btnOrder.Enabled = false;
            //}
            //else
            //{
            //    btnOrder.Enabled = true;
            //}
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int firstQuantity = Convert.ToInt32(numupdwnFirstSnack.Text);
            int secondQuantity = Convert.ToInt32(numupdwnSecondSnack.Text);
            int thirdQuantity = Convert.ToInt32(numupdwnThirdSnack.Text);

            double finalPrice = this.snackBar.ProcessOrder(firstQuantity, secondQuantity, thirdQuantity);

            if (firstQuantity == 0 && secondQuantity == 0 && thirdQuantity == 0)
            {
                MessageBox.Show($"More than in stock.", "Error");
            } else
            {
                MessageBox.Show($"Your order costed: {finalPrice}$", "Order");
            }

            ClearOrder();
            Refresh();
        }

        private void ClearOrder()
        {
            numupdwnFirstSnack.Text = "0";
            numupdwnSecondSnack.Text = "0";
            numupdwnThirdSnack.Text = "0";
        }

        private void cbxSnack_SelectedIndexChanged(object sender, EventArgs e)
        {
            Snack snack = snackBar.GetSnack(cbxSnack.Text);
            tbPrice.Text = snack.GetPrice();
            tbQuantity.Text = snack.GetQuantity();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Snack snack = snackBar.GetSnack(cbxSnack.Text);

            double newPrice = Convert.ToDouble(tbPrice.Text);
            int newQuantity = Convert.ToInt16(tbQuantity.Text);

            snack.SetPrice(newPrice);
            snack.SetQuantity(newQuantity);

            MessageBox.Show("You changed the value", "Changed successfull");
            Refresh();
        }

        public void Refresh()
        {
            Form1 form = new Form1();
            form.Refresh();
        }
    }
}