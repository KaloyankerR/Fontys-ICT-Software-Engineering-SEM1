namespace WinFormsApp1
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
            this.lblSigmaMale = new System.Windows.Forms.Label();
            this.btnAccelerate = new System.Windows.Forms.Button();
            this.btnBreak = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSigmaMale
            // 
            this.lblSigmaMale.AutoSize = true;
            this.lblSigmaMale.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSigmaMale.Location = new System.Drawing.Point(12, 9);
            this.lblSigmaMale.Name = "lblSigmaMale";
            this.lblSigmaMale.Size = new System.Drawing.Size(545, 41);
            this.lblSigmaMale.TabIndex = 0;
            this.lblSigmaMale.Text = "What colour is your Bugatti?";
            // 
            // btnAccelerate
            // 
            this.btnAccelerate.Location = new System.Drawing.Point(219, 185);
            this.btnAccelerate.Name = "btnAccelerate";
            this.btnAccelerate.Size = new System.Drawing.Size(112, 34);
            this.btnAccelerate.TabIndex = 1;
            this.btnAccelerate.Text = "Accelerate";
            this.btnAccelerate.UseVisualStyleBackColor = true;
            this.btnAccelerate.Click += new System.EventHandler(this.btnAccelerate_Click);
            // 
            // btnBreak
            // 
            this.btnBreak.Location = new System.Drawing.Point(374, 185);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(112, 34);
            this.btnBreak.TabIndex = 2;
            this.btnBreak.Text = "Break";
            this.btnBreak.UseVisualStyleBackColor = true;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(33, 96);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 32);
            this.lblResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.btnAccelerate);
            this.Controls.Add(this.lblSigmaMale);
            this.Name = "Form1";
            this.Text = "Car application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSigmaMale;
        private Button btnAccelerate;
        private Button btnBreak;
        private Label lblResult;
    }
}