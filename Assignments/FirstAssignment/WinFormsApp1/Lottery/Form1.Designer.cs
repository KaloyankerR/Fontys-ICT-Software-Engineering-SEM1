namespace Lottery
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNrNums = new System.Windows.Forms.TextBox();
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.lstbxNumbers = new System.Windows.Forms.ListBox();
            this.btnCreateObj = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnDrawAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nr of wanted numbers:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNrNums);
            this.groupBox1.Controls.Add(this.txtMaxValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lottery settings";
            // 
            // txtNrNums
            // 
            this.txtNrNums.Location = new System.Drawing.Point(300, 94);
            this.txtNrNums.Name = "txtNrNums";
            this.txtNrNums.Size = new System.Drawing.Size(150, 31);
            this.txtNrNums.TabIndex = 3;
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(163, 46);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(150, 31);
            this.txtMaxValue.TabIndex = 2;
            this.txtMaxValue.TextChanged += new System.EventHandler(this.txtMaxValue_TextChanged);
            // 
            // lstbxNumbers
            // 
            this.lstbxNumbers.FormattingEnabled = true;
            this.lstbxNumbers.ItemHeight = 25;
            this.lstbxNumbers.Location = new System.Drawing.Point(538, 34);
            this.lstbxNumbers.Name = "lstbxNumbers";
            this.lstbxNumbers.Size = new System.Drawing.Size(235, 329);
            this.lstbxNumbers.TabIndex = 3;
            // 
            // btnCreateObj
            // 
            this.btnCreateObj.Location = new System.Drawing.Point(117, 213);
            this.btnCreateObj.Name = "btnCreateObj";
            this.btnCreateObj.Size = new System.Drawing.Size(293, 34);
            this.btnCreateObj.TabIndex = 4;
            this.btnCreateObj.Text = "Create an object";
            this.btnCreateObj.UseVisualStyleBackColor = true;
            this.btnCreateObj.Click += new System.EventHandler(this.btnCreateObj_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Enabled = false;
            this.btnDraw.Location = new System.Drawing.Point(117, 253);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(293, 34);
            this.btnDraw.TabIndex = 5;
            this.btnDraw.Text = " Draw next number";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnDrawAll
            // 
            this.btnDrawAll.Enabled = false;
            this.btnDrawAll.Location = new System.Drawing.Point(117, 293);
            this.btnDrawAll.Name = "btnDrawAll";
            this.btnDrawAll.Size = new System.Drawing.Size(293, 34);
            this.btnDrawAll.TabIndex = 6;
            this.btnDrawAll.Text = "Draw all numbers";
            this.btnDrawAll.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDrawAll);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnCreateObj);
            this.Controls.Add(this.lstbxNumbers);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtNrNums;
        private TextBox txtMaxValue;
        private ListBox lstbxNumbers;
        private Button btnCreateObj;
        private Button btnDraw;
        private Button btnDrawAll;
    }
}