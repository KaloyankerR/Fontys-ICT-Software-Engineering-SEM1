namespace ComplexStuff
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.chbxAge = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.gbxChoices = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbDrink = new System.Windows.Forms.ComboBox();
            this.lbxDrinks = new System.Windows.Forms.ListBox();
            this.gbxChoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(351, 48);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the bar";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(369, 28);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(249, 25);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "What would you like to drink?";
            // 
            // chbxAge
            // 
            this.chbxAge.AutoSize = true;
            this.chbxAge.Location = new System.Drawing.Point(50, 95);
            this.chbxAge.Name = "chbxAge";
            this.chbxAge.Size = new System.Drawing.Size(179, 36);
            this.chbxAge.TabIndex = 4;
            this.chbxAge.Text = "I\'m over 18";
            this.chbxAge.UseVisualStyleBackColor = true;
            this.chbxAge.CheckedChanged += new System.EventHandler(this.chbxAge_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(88, 137);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(112, 34);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(100, 338);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 38);
            this.lblResult.TabIndex = 6;
            // 
            // gbxChoices
            // 
            this.gbxChoices.Controls.Add(this.btnClear);
            this.gbxChoices.Controls.Add(this.cmbDrink);
            this.gbxChoices.Controls.Add(this.btnOrder);
            this.gbxChoices.Controls.Add(this.chbxAge);
            this.gbxChoices.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbxChoices.Location = new System.Drawing.Point(12, 60);
            this.gbxChoices.Name = "gbxChoices";
            this.gbxChoices.Size = new System.Drawing.Size(300, 230);
            this.gbxChoices.TabIndex = 7;
            this.gbxChoices.TabStop = false;
            this.gbxChoices.Text = "Choose your drink";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(88, 177);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 34);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbDrink
            // 
            this.cmbDrink.FormattingEnabled = true;
            this.cmbDrink.Items.AddRange(new object[] {
            "Coke",
            "Lemonade",
            "Tonik",
            "Sparkling water",
            "Normal water",
            "Wiskey",
            "Vodka",
            "Rakia"});
            this.cmbDrink.Location = new System.Drawing.Point(50, 49);
            this.cmbDrink.Name = "cmbDrink";
            this.cmbDrink.Size = new System.Drawing.Size(182, 40);
            this.cmbDrink.TabIndex = 0;
            // 
            // lbxDrinks
            // 
            this.lbxDrinks.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxDrinks.FormattingEnabled = true;
            this.lbxDrinks.ItemHeight = 29;
            this.lbxDrinks.Location = new System.Drawing.Point(318, 71);
            this.lbxDrinks.Name = "lbxDrinks";
            this.lbxDrinks.Size = new System.Drawing.Size(209, 207);
            this.lbxDrinks.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxDrinks);
            this.Controls.Add(this.gbxChoices);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxChoices.ResumeLayout(false);
            this.gbxChoices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblWelcome;
        private Label lblQuestion;
        private CheckBox chbxAge;
        private Button btnOrder;
        private Label lblResult;
        private GroupBox gbxChoices;
        private ComboBox cmbDrink;
        private ListBox lbxDrinks;
        private Button btnClear;
    }
}