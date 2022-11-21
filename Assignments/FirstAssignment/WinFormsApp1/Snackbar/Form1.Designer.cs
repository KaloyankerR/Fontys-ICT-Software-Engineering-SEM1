namespace Snackbar
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.numupdwnThirdSnack = new System.Windows.Forms.NumericUpDown();
            this.numupdwnSecondSnack = new System.Windows.Forms.NumericUpDown();
            this.numupdwnFirstSnack = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.cbxSnack = new System.Windows.Forms.ComboBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdwnThirdSnack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdwnSecondSnack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdwnFirstSnack)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnOrder);
            this.tabPage1.Controls.Add(this.numupdwnThirdSnack);
            this.tabPage1.Controls.Add(this.numupdwnSecondSnack);
            this.tabPage1.Controls.Add(this.numupdwnFirstSnack);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Client page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Quantity";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(247, 242);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(208, 34);
            this.btnOrder.TabIndex = 16;
            this.btnOrder.Text = "Place an order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // numupdwnThirdSnack
            // 
            this.numupdwnThirdSnack.Location = new System.Drawing.Point(376, 161);
            this.numupdwnThirdSnack.Name = "numupdwnThirdSnack";
            this.numupdwnThirdSnack.Size = new System.Drawing.Size(79, 31);
            this.numupdwnThirdSnack.TabIndex = 15;
            // 
            // numupdwnSecondSnack
            // 
            this.numupdwnSecondSnack.Location = new System.Drawing.Point(376, 124);
            this.numupdwnSecondSnack.Name = "numupdwnSecondSnack";
            this.numupdwnSecondSnack.Size = new System.Drawing.Size(79, 31);
            this.numupdwnSecondSnack.TabIndex = 14;
            // 
            // numupdwnFirstSnack
            // 
            this.numupdwnFirstSnack.Location = new System.Drawing.Point(376, 87);
            this.numupdwnFirstSnack.Name = "numupdwnFirstSnack";
            this.numupdwnFirstSnack.Size = new System.Drawing.Size(79, 31);
            this.numupdwnFirstSnack.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Snack #3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Snack #2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Snack #1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.lblPrice);
            this.tabPage2.Controls.Add(this.tbQuantity);
            this.tabPage2.Controls.Add(this.tbPrice);
            this.tabPage2.Controls.Add(this.cbxSnack);
            this.tabPage2.Controls.Add(this.btnChange);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Admin page";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quantity";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(247, 150);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 25);
            this.lblPrice.TabIndex = 20;
            this.lblPrice.Text = "Price";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(302, 193);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(150, 31);
            this.tbQuantity.TabIndex = 19;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(302, 147);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(150, 31);
            this.tbPrice.TabIndex = 18;
            // 
            // cbxSnack
            // 
            this.cbxSnack.FormattingEnabled = true;
            this.cbxSnack.Location = new System.Drawing.Point(328, 61);
            this.cbxSnack.Name = "cbxSnack";
            this.cbxSnack.Size = new System.Drawing.Size(182, 33);
            this.cbxSnack.TabIndex = 17;
            this.cbxSnack.SelectedIndexChanged += new System.EventHandler(this.cbxSnack_SelectedIndexChanged);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(244, 259);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(208, 34);
            this.btnChange.TabIndex = 16;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Choose a snack: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "MacSnack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdwnThirdSnack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdwnSecondSnack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdwnFirstSnack)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnOrder;
        private NumericUpDown numupdwnThirdSnack;
        private NumericUpDown numupdwnSecondSnack;
        private NumericUpDown numupdwnFirstSnack;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private Label label4;
        private Label lblPrice;
        private TextBox tbQuantity;
        private TextBox tbPrice;
        private ComboBox cbxSnack;
        private Button btnChange;
        private Label label6;
        private Label label5;
    }
}