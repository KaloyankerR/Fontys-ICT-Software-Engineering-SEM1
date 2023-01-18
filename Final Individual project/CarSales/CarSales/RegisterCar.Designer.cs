namespace CarSales
{
    partial class RegisterCar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYearProduced = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBasePrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtYearProduced);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.txtBrand);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(191, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adding a car";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(137, 244);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(157, 37);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(151, 49);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(231, 31);
            this.txtBrand.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Brand";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(151, 86);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(231, 31);
            this.txtModel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model";
            // 
            // txtYearProduced
            // 
            this.txtYearProduced.Location = new System.Drawing.Point(151, 123);
            this.txtYearProduced.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtYearProduced.Name = "txtYearProduced";
            this.txtYearProduced.Size = new System.Drawing.Size(231, 31);
            this.txtYearProduced.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Year produced";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(151, 160);
            this.txtBasePrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(231, 31);
            this.txtBasePrice.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Base price";
            // 
            // RegisterCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisterCar";
            this.Text = "RegisterCar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtBrand;
        private Label label1;
        private Button btnRegister;
        private TextBox txtModel;
        private Label label2;
        private TextBox txtYearProduced;
        private Label label3;
        private TextBox txtBasePrice;
        private Label label4;
    }
}