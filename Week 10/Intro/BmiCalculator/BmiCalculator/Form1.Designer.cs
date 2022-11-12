namespace BmiCalculator
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
            this.rdbtnBG = new System.Windows.Forms.RadioButton();
            this.rdbtnNL = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbtnWomen = new System.Windows.Forms.RadioButton();
            this.rdbtnMan = new System.Windows.Forms.RadioButton();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbtnBG
            // 
            this.rdbtnBG.AutoSize = true;
            this.rdbtnBG.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbtnBG.Location = new System.Drawing.Point(6, 30);
            this.rdbtnBG.Name = "rdbtnBG";
            this.rdbtnBG.Size = new System.Drawing.Size(78, 40);
            this.rdbtnBG.TabIndex = 0;
            this.rdbtnBG.Text = "BG";
            this.rdbtnBG.UseVisualStyleBackColor = true;
            this.rdbtnBG.CheckedChanged += new System.EventHandler(this.rdbtnBG_CheckedChanged);
            // 
            // rdbtnNL
            // 
            this.rdbtnNL.AutoSize = true;
            this.rdbtnNL.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbtnNL.Location = new System.Drawing.Point(6, 76);
            this.rdbtnNL.Name = "rdbtnNL";
            this.rdbtnNL.Size = new System.Drawing.Size(78, 40);
            this.rdbtnNL.TabIndex = 1;
            this.rdbtnNL.Text = "NL";
            this.rdbtnNL.UseVisualStyleBackColor = true;
            this.rdbtnNL.CheckedChanged += new System.EventHandler(this.rdbtnNL_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnNL);
            this.groupBox1.Controls.Add(this.rdbtnBG);
            this.groupBox1.Location = new System.Drawing.Point(35, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbtnWomen);
            this.groupBox2.Controls.Add(this.rdbtnMan);
            this.groupBox2.Location = new System.Drawing.Point(476, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 150);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // rdbtnWomen
            // 
            this.rdbtnWomen.AutoSize = true;
            this.rdbtnWomen.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbtnWomen.Location = new System.Drawing.Point(6, 76);
            this.rdbtnWomen.Name = "rdbtnWomen";
            this.rdbtnWomen.Size = new System.Drawing.Size(135, 40);
            this.rdbtnWomen.TabIndex = 1;
            this.rdbtnWomen.Text = "Women";
            this.rdbtnWomen.UseVisualStyleBackColor = true;
            this.rdbtnWomen.CheckedChanged += new System.EventHandler(this.rdbtnWomen_CheckedChanged);
            // 
            // rdbtnMan
            // 
            this.rdbtnMan.AutoSize = true;
            this.rdbtnMan.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbtnMan.Location = new System.Drawing.Point(6, 30);
            this.rdbtnMan.Name = "rdbtnMan";
            this.rdbtnMan.Size = new System.Drawing.Size(97, 40);
            this.rdbtnMan.TabIndex = 0;
            this.rdbtnMan.Text = "Man";
            this.rdbtnMan.UseVisualStyleBackColor = true;
            this.rdbtnMan.CheckedChanged += new System.EventHandler(this.rdbtnMan_CheckedChanged);
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNationality.Location = new System.Drawing.Point(35, 284);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(0, 50);
            this.lblNationality.TabIndex = 4;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(476, 284);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(0, 50);
            this.lblGender.TabIndex = 5;
            this.lblGender.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rdbtnBG;
        private RadioButton rdbtnNL;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rdbtnWomen;
        private RadioButton rdbtnMan;
        private Label lblNationality;
        private Label lblGender;
    }
}