namespace HousingAgency
{
    partial class GroceriesCalculator
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
            this.dtgrdGroceries = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numupdwnCost = new System.Windows.Forms.NumericUpDown();
            this.btnAddGrocery = new System.Windows.Forms.Button();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.lblTenantName = new System.Windows.Forms.Label();
            this.txtTenantName = new System.Windows.Forms.TextBox();
            this.btnDeleteEdit = new System.Windows.Forms.Button();
            this.btnChangeEdit = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdGroceries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdwnCost)).BeginInit();
            this.tabPage.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrdGroceries
            // 
            this.dtgrdGroceries.AllowUserToAddRows = false;
            this.dtgrdGroceries.AllowUserToDeleteRows = false;
            this.dtgrdGroceries.AllowUserToResizeColumns = false;
            this.dtgrdGroceries.AllowUserToResizeRows = false;
            this.dtgrdGroceries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdGroceries.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgrdGroceries.Location = new System.Drawing.Point(0, 0);
            this.dtgrdGroceries.Margin = new System.Windows.Forms.Padding(2);
            this.dtgrdGroceries.Name = "dtgrdGroceries";
            this.dtgrdGroceries.ReadOnly = true;
            this.dtgrdGroceries.RowHeadersVisible = false;
            this.dtgrdGroceries.RowHeadersWidth = 62;
            this.dtgrdGroceries.RowTemplate.Height = 33;
            this.dtgrdGroceries.Size = new System.Drawing.Size(800, 240);
            this.dtgrdGroceries.TabIndex = 0;
            this.dtgrdGroceries.DoubleClick += new System.EventHandler(this.cellDoubleClicked);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 69);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(136, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name product :";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(92, 118);
            this.lblCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(57, 25);
            this.lblCost.TabIndex = 2;
            this.lblCost.Text = "Cost :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(162, 65);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 31);
            this.txtName.TabIndex = 3;
            // 
            // numupdwnCost
            // 
            this.numupdwnCost.DecimalPlaces = 2;
            this.numupdwnCost.Location = new System.Drawing.Point(162, 115);
            this.numupdwnCost.Margin = new System.Windows.Forms.Padding(2);
            this.numupdwnCost.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numupdwnCost.Name = "numupdwnCost";
            this.numupdwnCost.Size = new System.Drawing.Size(150, 31);
            this.numupdwnCost.TabIndex = 4;
            // 
            // btnAddGrocery
            // 
            this.btnAddGrocery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.btnAddGrocery.Location = new System.Drawing.Point(388, 19);
            this.btnAddGrocery.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddGrocery.Name = "btnAddGrocery";
            this.btnAddGrocery.Size = new System.Drawing.Size(112, 34);
            this.btnAddGrocery.TabIndex = 5;
            this.btnAddGrocery.Text = "Add";
            this.btnAddGrocery.UseVisualStyleBackColor = false;
            this.btnAddGrocery.Click += new System.EventHandler(this.btnAddGrocery_Click);
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabPageAdd);
            this.tabPage.Location = new System.Drawing.Point(0, 245);
            this.tabPage.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(800, 208);
            this.tabPage.TabIndex = 6;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tabPageAdd.Controls.Add(this.lblTenantName);
            this.tabPageAdd.Controls.Add(this.txtTenantName);
            this.tabPageAdd.Controls.Add(this.btnDeleteEdit);
            this.tabPageAdd.Controls.Add(this.btnChangeEdit);
            this.tabPageAdd.Controls.Add(this.lblTotal);
            this.tabPageAdd.Controls.Add(this.numupdwnCost);
            this.tabPageAdd.Controls.Add(this.btnAddGrocery);
            this.tabPageAdd.Controls.Add(this.lblName);
            this.tabPageAdd.Controls.Add(this.lblCost);
            this.tabPageAdd.Controls.Add(this.txtName);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 34);
            this.tabPageAdd.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageAdd.Size = new System.Drawing.Size(792, 170);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "Add";
            // 
            // lblTenantName
            // 
            this.lblTenantName.AutoSize = true;
            this.lblTenantName.Location = new System.Drawing.Point(21, 22);
            this.lblTenantName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenantName.Name = "lblTenantName";
            this.lblTenantName.Size = new System.Drawing.Size(123, 25);
            this.lblTenantName.TabIndex = 8;
            this.lblTenantName.Text = "Name tenant :";
            // 
            // txtTenantName
            // 
            this.txtTenantName.Location = new System.Drawing.Point(164, 19);
            this.txtTenantName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenantName.Name = "txtTenantName";
            this.txtTenantName.Size = new System.Drawing.Size(149, 31);
            this.txtTenantName.TabIndex = 7;
            // 
            // btnDeleteEdit
            // 
            this.btnDeleteEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.btnDeleteEdit.Location = new System.Drawing.Point(658, 19);
            this.btnDeleteEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteEdit.Name = "btnDeleteEdit";
            this.btnDeleteEdit.Size = new System.Drawing.Size(112, 34);
            this.btnDeleteEdit.TabIndex = 9;
            this.btnDeleteEdit.Text = "Delete";
            this.btnDeleteEdit.UseVisualStyleBackColor = false;
            this.btnDeleteEdit.Click += new System.EventHandler(this.btnDeleteEdit_Click);
            // 
            // btnChangeEdit
            // 
            this.btnChangeEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.btnChangeEdit.Location = new System.Drawing.Point(526, 19);
            this.btnChangeEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeEdit.Name = "btnChangeEdit";
            this.btnChangeEdit.Size = new System.Drawing.Size(112, 34);
            this.btnChangeEdit.TabIndex = 10;
            this.btnChangeEdit.Text = "Change";
            this.btnChangeEdit.UseVisualStyleBackColor = false;
            this.btnChangeEdit.Click += new System.EventHandler(this.btnChangeEdit_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(429, 82);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(80, 32);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total: ";
            // 
            // GroceriesCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPage);
            this.Controls.Add(this.dtgrdGroceries);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GroceriesCalculator";
            this.Text = "GroceriesCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdGroceries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdwnCost)).EndInit();
            this.tabPage.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtgrdGroceries;
        private Label lblName;
        private Label lblCost;
        private TextBox txtName;
        private NumericUpDown numupdwnCost;
        private Button btnAddGrocery;
        private TabControl tabPage;
        private TabPage tabPageAdd;
        private Button btnDeleteEdit;
        private Button btnChangeEdit;
        private Label lblTotal;
        private Label lblTenantName;
        private TextBox txtTenantName;
    }
}