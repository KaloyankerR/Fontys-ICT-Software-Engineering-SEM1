namespace CarSales
{
    partial class CarApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowCars = new System.Windows.Forms.Button();
            this.listbxCars = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpgSales = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listbxResult = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateSalesSale = new System.Windows.Forms.DateTimePicker();
            this.btnSalesSale = new System.Windows.Forms.Button();
            this.txtSalesCustomer = new System.Windows.Forms.TextBox();
            this.lblSalesCar = new System.Windows.Forms.Label();
            this.txtSalesCar = new System.Windows.Forms.TextBox();
            this.lblSalesCustomer = new System.Windows.Forms.Label();
            this.tbpgCars = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnCarsAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCarsSearch = new System.Windows.Forms.Button();
            this.txtCarsSearchedCar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpgCustomers = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCustomersRefresh = new System.Windows.Forms.Button();
            this.btnCustomersDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCustomersSearch = new System.Windows.Forms.Button();
            this.txtCustomersSearchedCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listbxCustomers = new System.Windows.Forms.ListBox();
            this.tbpgOptions = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioBtnOptionsCannotSell = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radioBtnOptionsCanSell = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCarsReset = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbpgSales.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbpgCars.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tbpgCustomers.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tbpgOptions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowCars
            // 
            this.btnShowCars.Location = new System.Drawing.Point(80, 68);
            this.btnShowCars.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnShowCars.Name = "btnShowCars";
            this.btnShowCars.Size = new System.Drawing.Size(157, 37);
            this.btnShowCars.TabIndex = 0;
            this.btnShowCars.Text = "Refresh";
            this.btnShowCars.UseVisualStyleBackColor = true;
            this.btnShowCars.Click += new System.EventHandler(this.btnShowCars_Click);
            // 
            // listbxCars
            // 
            this.listbxCars.FormattingEnabled = true;
            this.listbxCars.ItemHeight = 27;
            this.listbxCars.Location = new System.Drawing.Point(46, 41);
            this.listbxCars.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listbxCars.Name = "listbxCars";
            this.listbxCars.Size = new System.Drawing.Size(1061, 247);
            this.listbxCars.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpgSales);
            this.tabControl1.Controls.Add(this.tbpgCars);
            this.tabControl1.Controls.Add(this.tbpgCustomers);
            this.tabControl1.Controls.Add(this.tbpgOptions);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(17, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1151, 522);
            this.tabControl1.TabIndex = 2;
            // 
            // tbpgSales
            // 
            this.tbpgSales.Controls.Add(this.groupBox1);
            this.tbpgSales.Location = new System.Drawing.Point(4, 36);
            this.tbpgSales.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbpgSales.Name = "tbpgSales";
            this.tbpgSales.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbpgSales.Size = new System.Drawing.Size(1143, 482);
            this.tbpgSales.TabIndex = 2;
            this.tbpgSales.Text = "Sales";
            this.tbpgSales.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.listbxResult);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateSalesSale);
            this.groupBox1.Controls.Add(this.btnSalesSale);
            this.groupBox1.Controls.Add(this.txtSalesCustomer);
            this.groupBox1.Controls.Add(this.lblSalesCar);
            this.groupBox1.Controls.Add(this.txtSalesCar);
            this.groupBox1.Controls.Add(this.lblSalesCustomer);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1123, 463);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales panel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(567, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 27);
            this.label7.TabIndex = 7;
            this.label7.Text = "History:";
            // 
            // listbxResult
            // 
            this.listbxResult.FormattingEnabled = true;
            this.listbxResult.ItemHeight = 27;
            this.listbxResult.Location = new System.Drawing.Point(568, 48);
            this.listbxResult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listbxResult.Name = "listbxResult";
            this.listbxResult.Size = new System.Drawing.Size(545, 409);
            this.listbxResult.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(57, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // dateSalesSale
            // 
            this.dateSalesSale.Location = new System.Drawing.Point(57, 84);
            this.dateSalesSale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateSalesSale.Name = "dateSalesSale";
            this.dateSalesSale.Size = new System.Drawing.Size(455, 35);
            this.dateSalesSale.TabIndex = 5;
            // 
            // btnSalesSale
            // 
            this.btnSalesSale.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalesSale.Location = new System.Drawing.Point(147, 349);
            this.btnSalesSale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalesSale.Name = "btnSalesSale";
            this.btnSalesSale.Size = new System.Drawing.Size(234, 68);
            this.btnSalesSale.TabIndex = 4;
            this.btnSalesSale.Text = "Make a sell";
            this.btnSalesSale.UseVisualStyleBackColor = true;
            this.btnSalesSale.Click += new System.EventHandler(this.btnSalesSale_Click);
            // 
            // txtSalesCustomer
            // 
            this.txtSalesCustomer.Location = new System.Drawing.Point(57, 260);
            this.txtSalesCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSalesCustomer.Name = "txtSalesCustomer";
            this.txtSalesCustomer.Size = new System.Drawing.Size(455, 35);
            this.txtSalesCustomer.TabIndex = 3;
            // 
            // lblSalesCar
            // 
            this.lblSalesCar.AutoSize = true;
            this.lblSalesCar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalesCar.Location = new System.Drawing.Point(57, 132);
            this.lblSalesCar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesCar.Name = "lblSalesCar";
            this.lblSalesCar.Size = new System.Drawing.Size(51, 32);
            this.lblSalesCar.TabIndex = 0;
            this.lblSalesCar.Text = "Car";
            // 
            // txtSalesCar
            // 
            this.txtSalesCar.Location = new System.Drawing.Point(57, 170);
            this.txtSalesCar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSalesCar.Name = "txtSalesCar";
            this.txtSalesCar.Size = new System.Drawing.Size(455, 35);
            this.txtSalesCar.TabIndex = 2;
            // 
            // lblSalesCustomer
            // 
            this.lblSalesCustomer.AutoSize = true;
            this.lblSalesCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalesCustomer.Location = new System.Drawing.Point(57, 222);
            this.lblSalesCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesCustomer.Name = "lblSalesCustomer";
            this.lblSalesCustomer.Size = new System.Drawing.Size(119, 32);
            this.lblSalesCustomer.TabIndex = 1;
            this.lblSalesCustomer.Text = "Customer";
            // 
            // tbpgCars
            // 
            this.tbpgCars.Controls.Add(this.groupBox4);
            this.tbpgCars.Controls.Add(this.label2);
            this.tbpgCars.Controls.Add(this.listbxCars);
            this.tbpgCars.Location = new System.Drawing.Point(4, 36);
            this.tbpgCars.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbpgCars.Name = "tbpgCars";
            this.tbpgCars.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbpgCars.Size = new System.Drawing.Size(1143, 482);
            this.tbpgCars.TabIndex = 0;
            this.tbpgCars.Text = "Cars";
            this.tbpgCars.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnCarsSearch);
            this.groupBox4.Controls.Add(this.txtCarsSearchedCar);
            this.groupBox4.Location = new System.Drawing.Point(46, 302);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(1063, 160);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cars panel";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnShowCars);
            this.groupBox7.Controls.Add(this.btnCarsAdd);
            this.groupBox7.Location = new System.Drawing.Point(537, 34);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(501, 120);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Addtional controls";
            // 
            // btnCarsAdd
            // 
            this.btnCarsAdd.Location = new System.Drawing.Point(245, 68);
            this.btnCarsAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCarsAdd.Name = "btnCarsAdd";
            this.btnCarsAdd.Size = new System.Drawing.Size(157, 37);
            this.btnCarsAdd.TabIndex = 5;
            this.btnCarsAdd.Text = "Add";
            this.btnCarsAdd.UseVisualStyleBackColor = true;
            this.btnCarsAdd.Click += new System.EventHandler(this.btnCarsAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Search for a car:";
            // 
            // btnCarsSearch
            // 
            this.btnCarsSearch.Location = new System.Drawing.Point(351, 78);
            this.btnCarsSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCarsSearch.Name = "btnCarsSearch";
            this.btnCarsSearch.Size = new System.Drawing.Size(157, 37);
            this.btnCarsSearch.TabIndex = 7;
            this.btnCarsSearch.Text = "Search";
            this.btnCarsSearch.UseVisualStyleBackColor = true;
            this.btnCarsSearch.Click += new System.EventHandler(this.btnCarsSearch_Click);
            // 
            // txtCarsSearchedCar
            // 
            this.txtCarsSearchedCar.Location = new System.Drawing.Point(59, 80);
            this.txtCarsSearchedCar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCarsSearchedCar.Name = "txtCarsSearchedCar";
            this.txtCarsSearchedCar.Size = new System.Drawing.Size(283, 35);
            this.txtCarsSearchedCar.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cars";
            // 
            // tbpgCustomers
            // 
            this.tbpgCustomers.Controls.Add(this.groupBox5);
            this.tbpgCustomers.Controls.Add(this.label1);
            this.tbpgCustomers.Controls.Add(this.listbxCustomers);
            this.tbpgCustomers.Location = new System.Drawing.Point(4, 36);
            this.tbpgCustomers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbpgCustomers.Name = "tbpgCustomers";
            this.tbpgCustomers.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbpgCustomers.Size = new System.Drawing.Size(1143, 482);
            this.tbpgCustomers.TabIndex = 1;
            this.tbpgCustomers.Text = "Customers";
            this.tbpgCustomers.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.btnCustomersSearch);
            this.groupBox5.Controls.Add(this.txtCustomersSearchedCustomer);
            this.groupBox5.Location = new System.Drawing.Point(49, 312);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(1061, 134);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Customers panel";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnRegister);
            this.groupBox6.Controls.Add(this.btnCustomersRefresh);
            this.groupBox6.Controls.Add(this.btnCustomersDelete);
            this.groupBox6.Location = new System.Drawing.Point(494, 34);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(531, 94);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Additional controls";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(191, 51);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(157, 37);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCustomersRefresh
            // 
            this.btnCustomersRefresh.Location = new System.Drawing.Point(26, 51);
            this.btnCustomersRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCustomersRefresh.Name = "btnCustomersRefresh";
            this.btnCustomersRefresh.Size = new System.Drawing.Size(157, 37);
            this.btnCustomersRefresh.TabIndex = 0;
            this.btnCustomersRefresh.Text = "Refresh";
            this.btnCustomersRefresh.UseVisualStyleBackColor = true;
            this.btnCustomersRefresh.Click += new System.EventHandler(this.btnCustomersRefresh_Click);
            // 
            // btnCustomersDelete
            // 
            this.btnCustomersDelete.Location = new System.Drawing.Point(356, 51);
            this.btnCustomersDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCustomersDelete.Name = "btnCustomersDelete";
            this.btnCustomersDelete.Size = new System.Drawing.Size(157, 37);
            this.btnCustomersDelete.TabIndex = 4;
            this.btnCustomersDelete.Text = "Delete";
            this.btnCustomersDelete.UseVisualStyleBackColor = true;
            this.btnCustomersDelete.Click += new System.EventHandler(this.btnCustomersDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Search for a customer:";
            // 
            // btnCustomersSearch
            // 
            this.btnCustomersSearch.Location = new System.Drawing.Point(284, 76);
            this.btnCustomersSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCustomersSearch.Name = "btnCustomersSearch";
            this.btnCustomersSearch.Size = new System.Drawing.Size(157, 37);
            this.btnCustomersSearch.TabIndex = 6;
            this.btnCustomersSearch.Text = "Search";
            this.btnCustomersSearch.UseVisualStyleBackColor = true;
            this.btnCustomersSearch.Click += new System.EventHandler(this.btnCustomersSearch_Click);
            // 
            // txtCustomersSearchedCustomer
            // 
            this.txtCustomersSearchedCustomer.Location = new System.Drawing.Point(35, 76);
            this.txtCustomersSearchedCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCustomersSearchedCustomer.Name = "txtCustomersSearchedCustomer";
            this.txtCustomersSearchedCustomer.Size = new System.Drawing.Size(241, 35);
            this.txtCustomersSearchedCustomer.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customers";
            // 
            // listbxCustomers
            // 
            this.listbxCustomers.FormattingEnabled = true;
            this.listbxCustomers.ItemHeight = 27;
            this.listbxCustomers.Location = new System.Drawing.Point(49, 41);
            this.listbxCustomers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listbxCustomers.Name = "listbxCustomers";
            this.listbxCustomers.Size = new System.Drawing.Size(1061, 247);
            this.listbxCustomers.TabIndex = 1;
            // 
            // tbpgOptions
            // 
            this.tbpgOptions.Controls.Add(this.groupBox3);
            this.tbpgOptions.Controls.Add(this.groupBox2);
            this.tbpgOptions.Location = new System.Drawing.Point(4, 36);
            this.tbpgOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbpgOptions.Name = "tbpgOptions";
            this.tbpgOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbpgOptions.Size = new System.Drawing.Size(1143, 482);
            this.tbpgOptions.TabIndex = 3;
            this.tbpgOptions.Text = "Options";
            this.tbpgOptions.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioBtnOptionsCannotSell);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.radioBtnOptionsCanSell);
            this.groupBox3.Location = new System.Drawing.Point(32, 246);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(417, 195);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cars";
            // 
            // radioBtnOptionsCannotSell
            // 
            this.radioBtnOptionsCannotSell.AutoSize = true;
            this.radioBtnOptionsCannotSell.Checked = true;
            this.radioBtnOptionsCannotSell.Location = new System.Drawing.Point(41, 116);
            this.radioBtnOptionsCannotSell.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBtnOptionsCannotSell.Name = "radioBtnOptionsCannotSell";
            this.radioBtnOptionsCannotSell.Size = new System.Drawing.Size(67, 31);
            this.radioBtnOptionsCannotSell.TabIndex = 3;
            this.radioBtnOptionsCannotSell.TabStop = true;
            this.radioBtnOptionsCannotSell.Text = "No";
            this.radioBtnOptionsCannotSell.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Can add cars:";
            // 
            // radioBtnOptionsCanSell
            // 
            this.radioBtnOptionsCanSell.AutoSize = true;
            this.radioBtnOptionsCanSell.Location = new System.Drawing.Point(41, 69);
            this.radioBtnOptionsCanSell.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBtnOptionsCanSell.Name = "radioBtnOptionsCanSell";
            this.radioBtnOptionsCanSell.Size = new System.Drawing.Size(76, 31);
            this.radioBtnOptionsCanSell.TabIndex = 1;
            this.radioBtnOptionsCanSell.Text = "Yes";
            this.radioBtnOptionsCanSell.UseVisualStyleBackColor = true;
            this.radioBtnOptionsCanSell.CheckedChanged += new System.EventHandler(this.radioBtnOptionsCanSell_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCarsReset);
            this.groupBox2.Location = new System.Drawing.Point(32, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(417, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options panel";
            // 
            // btnCarsReset
            // 
            this.btnCarsReset.Location = new System.Drawing.Point(100, 103);
            this.btnCarsReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCarsReset.Name = "btnCarsReset";
            this.btnCarsReset.Size = new System.Drawing.Size(190, 37);
            this.btnCarsReset.TabIndex = 0;
            this.btnCarsReset.Text = "Reset Cars";
            this.btnCarsReset.UseVisualStyleBackColor = true;
            this.btnCarsReset.Click += new System.EventHandler(this.btnCarsReset_Click);
            // 
            // CarApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1180, 544);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CarApp";
            this.Text = "CarApp";
            this.tabControl1.ResumeLayout(false);
            this.tbpgSales.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpgCars.ResumeLayout(false);
            this.tbpgCars.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tbpgCustomers.ResumeLayout(false);
            this.tbpgCustomers.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.tbpgOptions.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnShowCars;
        private ListBox listbxCars;
        private TabControl tabControl1;
        private TabPage tbpgCars;
        private TabPage tbpgCustomers;
        private Button btnCustomersRefresh;
        private ListBox listbxCustomers;
        private Button btnRegister;
        private TabPage tbpgSales;
        private Label label1;
        private Label label2;
        private TextBox txtSalesCar;
        private Label lblSalesCustomer;
        private Label lblSalesCar;
        private GroupBox groupBox1;
        private TextBox txtSalesCustomer;
        private Button btnCarsAdd;
        private ListBox listbxResult;
        private Button btnSalesSale;
        private DateTimePicker dateSalesSale;
        private Label label3;
        private Button btnCustomersDelete;
        private TabPage tbpgOptions;
        private Button btnCarsReset;
        private GroupBox groupBox2;
        private Button btnCarsSearch;
        private TextBox txtCarsSearchedCar;
        private GroupBox groupBox3;
        private Label label4;
        private RadioButton radioBtnOptionsCanSell;
        private GroupBox groupBox4;
        private Label label5;
        private GroupBox groupBox5;
        private Button btnCustomersSearch;
        private TextBox txtCustomersSearchedCustomer;
        private Label label6;
        private Label label7;
        private GroupBox groupBox6;
        private RadioButton radioBtnOptionsCannotSell;
        private GroupBox groupBox7;
    }
}