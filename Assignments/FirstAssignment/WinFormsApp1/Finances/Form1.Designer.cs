namespace Finances
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddExpenses = new System.Windows.Forms.Button();
            this.numupdwnAmount = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnShowExpenses = new System.Windows.Forms.Button();
            this.numuodwnSameExpenses = new System.Windows.Forms.NumericUpDown();
            this.lblAmount2 = new System.Windows.Forms.Label();
            this.btnShowSameExpenses = new System.Windows.Forms.Button();
            this.lsbxExpenses = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdwnAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuodwnSameExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddExpenses);
            this.groupBox1.Controls.Add(this.numupdwnAmount);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expenses form";
            // 
            // btnAddExpenses
            // 
            this.btnAddExpenses.Location = new System.Drawing.Point(17, 161);
            this.btnAddExpenses.Name = "btnAddExpenses";
            this.btnAddExpenses.Size = new System.Drawing.Size(273, 61);
            this.btnAddExpenses.TabIndex = 4;
            this.btnAddExpenses.Text = "Add expenses";
            this.btnAddExpenses.UseVisualStyleBackColor = true;
            this.btnAddExpenses.Click += new System.EventHandler(this.btnAddExpenses_Click);
            // 
            // numupdwnAmount
            // 
            this.numupdwnAmount.DecimalPlaces = 2;
            this.numupdwnAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numupdwnAmount.Location = new System.Drawing.Point(143, 87);
            this.numupdwnAmount.Name = "numupdwnAmount";
            this.numupdwnAmount.Size = new System.Drawing.Size(147, 31);
            this.numupdwnAmount.TabIndex = 3;
            this.numupdwnAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 31);
            this.txtName.TabIndex = 2;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(17, 93);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(77, 25);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Amount";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // btnShowExpenses
            // 
            this.btnShowExpenses.Location = new System.Drawing.Point(29, 271);
            this.btnShowExpenses.Name = "btnShowExpenses";
            this.btnShowExpenses.Size = new System.Drawing.Size(273, 34);
            this.btnShowExpenses.TabIndex = 5;
            this.btnShowExpenses.Text = "Show all expenses";
            this.btnShowExpenses.UseVisualStyleBackColor = true;
            // 
            // numuodwnSameExpenses
            // 
            this.numuodwnSameExpenses.DecimalPlaces = 2;
            this.numuodwnSameExpenses.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numuodwnSameExpenses.Location = new System.Drawing.Point(178, 338);
            this.numuodwnSameExpenses.Name = "numuodwnSameExpenses";
            this.numuodwnSameExpenses.Size = new System.Drawing.Size(147, 31);
            this.numuodwnSameExpenses.TabIndex = 7;
            this.numuodwnSameExpenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAmount2
            // 
            this.lblAmount2.AutoSize = true;
            this.lblAmount2.Location = new System.Drawing.Point(29, 344);
            this.lblAmount2.Name = "lblAmount2";
            this.lblAmount2.Size = new System.Drawing.Size(77, 25);
            this.lblAmount2.TabIndex = 6;
            this.lblAmount2.Text = "Amount";
            // 
            // btnShowSameExpenses
            // 
            this.btnShowSameExpenses.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowSameExpenses.Location = new System.Drawing.Point(12, 375);
            this.btnShowSameExpenses.Name = "btnShowSameExpenses";
            this.btnShowSameExpenses.Size = new System.Drawing.Size(313, 34);
            this.btnShowSameExpenses.TabIndex = 8;
            this.btnShowSameExpenses.Text = "Show expenses with the same amount";
            this.btnShowSameExpenses.UseVisualStyleBackColor = true;
            // 
            // lsbxExpenses
            // 
            this.lsbxExpenses.FormattingEnabled = true;
            this.lsbxExpenses.ItemHeight = 25;
            this.lsbxExpenses.Location = new System.Drawing.Point(476, 99);
            this.lsbxExpenses.Name = "lsbxExpenses";
            this.lsbxExpenses.Size = new System.Drawing.Size(265, 254);
            this.lsbxExpenses.TabIndex = 9;
            this.lsbxExpenses.SelectedIndexChanged += new System.EventHandler(this.lsbxExpenses_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbxExpenses);
            this.Controls.Add(this.btnShowSameExpenses);
            this.Controls.Add(this.numuodwnSameExpenses);
            this.Controls.Add(this.lblAmount2);
            this.Controls.Add(this.btnShowExpenses);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdwnAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numuodwnSameExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown numupdwnAmount;
        private TextBox txtName;
        private Label lblAmount;
        private Label lblName;
        private Button btnAddExpenses;
        private Button btnShowExpenses;
        private NumericUpDown numuodwnSameExpenses;
        private Label lblAmount2;
        private Button btnShowSameExpenses;
        private ListBox lsbxExpenses;
    }
}