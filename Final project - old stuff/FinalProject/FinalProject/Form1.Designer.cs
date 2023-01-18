namespace FinalProject
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
            this.tbcntrlMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgrdComplaints = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcntrlMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdComplaints)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcntrlMenu
            // 
            this.tbcntrlMenu.Controls.Add(this.tabPage1);
            this.tbcntrlMenu.Controls.Add(this.tabPage2);
            this.tbcntrlMenu.Location = new System.Drawing.Point(-3, 0);
            this.tbcntrlMenu.Name = "tbcntrlMenu";
            this.tbcntrlMenu.SelectedIndex = 0;
            this.tbcntrlMenu.Size = new System.Drawing.Size(1004, 612);
            this.tbcntrlMenu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgrdComplaints);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(996, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Complaints";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgrdComplaints
            // 
            this.dtgrdComplaints.AllowUserToAddRows = false;
            this.dtgrdComplaints.AllowUserToDeleteRows = false;
            this.dtgrdComplaints.AllowUserToOrderColumns = true;
            this.dtgrdComplaints.AllowUserToResizeColumns = false;
            this.dtgrdComplaints.AllowUserToResizeRows = false;
            this.dtgrdComplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdComplaints.Location = new System.Drawing.Point(15, 104);
            this.dtgrdComplaints.Name = "dtgrdComplaints";
            this.dtgrdComplaints.ReadOnly = true;
            this.dtgrdComplaints.RowHeadersVisible = false;
            this.dtgrdComplaints.RowHeadersWidth = 62;
            this.dtgrdComplaints.RowTemplate.Height = 33;
            this.dtgrdComplaints.Size = new System.Drawing.Size(950, 280);
            this.dtgrdComplaints.TabIndex = 3;
            this.dtgrdComplaints.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(199, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Some complaints";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(996, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agreements";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Some agreements";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.tbcntrlMenu);
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcntrlMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdComplaints)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbcntrlMenu;
        private TabPage tabPage1;
        private Label label1;
        private TabPage tabPage2;
        private Label label2;
        private Button btnAdd;
        private DataGridView dtgrdComplaints;
    }
}