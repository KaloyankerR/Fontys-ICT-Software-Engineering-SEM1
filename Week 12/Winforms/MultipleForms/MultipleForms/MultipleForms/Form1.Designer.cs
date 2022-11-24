namespace MultipleForms
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
            this.flwLytPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flwLytPnl
            // 
            this.flwLytPnl.Location = new System.Drawing.Point(12, 12);
            this.flwLytPnl.Name = "flwLytPnl";
            this.flwLytPnl.Size = new System.Drawing.Size(776, 150);
            this.flwLytPnl.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(350, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.flwLytPnl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flwLytPnl;
        private Button btnAdd;
    }
}