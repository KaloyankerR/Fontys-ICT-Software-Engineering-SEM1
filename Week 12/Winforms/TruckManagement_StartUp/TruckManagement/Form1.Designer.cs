
namespace TruckManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tclTrucks = new System.Windows.Forms.TabControl();
            this.tabTrucks = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddTruck = new System.Windows.Forms.Button();
            this.tbxCostPallet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCostBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMaxBoxesPerPallet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMaxPallets = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxTrucks = new System.Windows.Forms.ListBox();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.cbbTruck = new System.Windows.Forms.ComboBox();
            this.tbxNoBoxes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tclTrucks.SuspendLayout();
            this.tabTrucks.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tclTrucks
            // 
            this.tclTrucks.Controls.Add(this.tabTrucks);
            this.tclTrucks.Controls.Add(this.tabOrder);
            this.tclTrucks.Location = new System.Drawing.Point(22, 19);
            this.tclTrucks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tclTrucks.Name = "tclTrucks";
            this.tclTrucks.SelectedIndex = 0;
            this.tclTrucks.Size = new System.Drawing.Size(839, 410);
            this.tclTrucks.TabIndex = 17;
            // 
            // tabTrucks
            // 
            this.tabTrucks.Controls.Add(this.groupBox1);
            this.tabTrucks.Controls.Add(this.lbxTrucks);
            this.tabTrucks.Location = new System.Drawing.Point(4, 34);
            this.tabTrucks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabTrucks.Name = "tabTrucks";
            this.tabTrucks.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabTrucks.Size = new System.Drawing.Size(831, 372);
            this.tabTrucks.TabIndex = 0;
            this.tabTrucks.Text = "Manage trucks";
            this.tabTrucks.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAddTruck);
            this.groupBox1.Controls.Add(this.tbxCostPallet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxCostBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxMaxBoxesPerPallet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxMaxPallets);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(778, 214);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new truck";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 30);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(626, 31);
            this.txtName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Truck name:*";
            // 
            // btnAddTruck
            // 
            this.btnAddTruck.Location = new System.Drawing.Point(18, 163);
            this.btnAddTruck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddTruck.Name = "btnAddTruck";
            this.btnAddTruck.Size = new System.Drawing.Size(735, 36);
            this.btnAddTruck.TabIndex = 10;
            this.btnAddTruck.Text = "Add truck";
            this.btnAddTruck.UseVisualStyleBackColor = true;
            this.btnAddTruck.Click += new System.EventHandler(this.btnAddTruck_Click);
            // 
            // tbxCostPallet
            // 
            this.tbxCostPallet.Location = new System.Drawing.Point(655, 70);
            this.tbxCostPallet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxCostPallet.Name = "tbxCostPallet";
            this.tbxCostPallet.Size = new System.Drawing.Size(100, 31);
            this.tbxCostPallet.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cost per full pallet:* €";
            // 
            // tbxCostBox
            // 
            this.tbxCostBox.Location = new System.Drawing.Point(655, 116);
            this.tbxCostBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxCostBox.Name = "tbxCostBox";
            this.tbxCostBox.Size = new System.Drawing.Size(100, 31);
            this.tbxCostBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cost per remaining box: €";
            // 
            // tbxMaxBoxesPerPallet
            // 
            this.tbxMaxBoxesPerPallet.Location = new System.Drawing.Point(305, 112);
            this.tbxMaxBoxesPerPallet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxMaxBoxesPerPallet.Name = "tbxMaxBoxesPerPallet";
            this.tbxMaxBoxesPerPallet.Size = new System.Drawing.Size(59, 31);
            this.tbxMaxBoxesPerPallet.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Max. number of boxes per pallet:*";
            // 
            // tbxMaxPallets
            // 
            this.tbxMaxPallets.Location = new System.Drawing.Point(305, 72);
            this.tbxMaxPallets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxMaxPallets.Name = "tbxMaxPallets";
            this.tbxMaxPallets.Size = new System.Drawing.Size(59, 31);
            this.tbxMaxPallets.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max. number of pallets per truck:*";
            // 
            // lbxTrucks
            // 
            this.lbxTrucks.FormattingEnabled = true;
            this.lbxTrucks.ItemHeight = 25;
            this.lbxTrucks.Location = new System.Drawing.Point(26, 243);
            this.lbxTrucks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxTrucks.Name = "lbxTrucks";
            this.lbxTrucks.Size = new System.Drawing.Size(779, 104);
            this.lbxTrucks.TabIndex = 0;
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.btnCalculate);
            this.tabOrder.Controls.Add(this.cbbTruck);
            this.tabOrder.Controls.Add(this.tbxNoBoxes);
            this.tabOrder.Controls.Add(this.label8);
            this.tabOrder.Controls.Add(this.label7);
            this.tabOrder.Location = new System.Drawing.Point(4, 34);
            this.tabOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabOrder.Size = new System.Drawing.Size(831, 372);
            this.tabOrder.TabIndex = 1;
            this.tabOrder.Text = "Place order";
            this.tabOrder.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(285, 109);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(512, 36);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate costs";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // cbbTruck
            // 
            this.cbbTruck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTruck.FormattingEnabled = true;
            this.cbbTruck.Location = new System.Drawing.Point(285, 62);
            this.cbbTruck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbTruck.Name = "cbbTruck";
            this.cbbTruck.Size = new System.Drawing.Size(512, 33);
            this.cbbTruck.TabIndex = 17;
            // 
            // tbxNoBoxes
            // 
            this.tbxNoBoxes.Location = new System.Drawing.Point(285, 25);
            this.tbxNoBoxes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxNoBoxes.Name = "tbxNoBoxes";
            this.tbxNoBoxes.Size = new System.Drawing.Size(112, 31);
            this.tbxNoBoxes.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Truck type to be used:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "No. of boxes to be shipped: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.tclTrucks);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Fontys | Truck Management";
            this.tclTrucks.ResumeLayout(false);
            this.tabTrucks.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabOrder.ResumeLayout(false);
            this.tabOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tclTrucks;
        private System.Windows.Forms.TabPage tabTrucks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddTruck;
        private System.Windows.Forms.TextBox tbxCostPallet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCostBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMaxBoxesPerPallet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMaxPallets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxTrucks;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ComboBox cbbTruck;
        private System.Windows.Forms.TextBox tbxNoBoxes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
    }
}

