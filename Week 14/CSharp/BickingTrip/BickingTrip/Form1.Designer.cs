
namespace BickingTrip
{
    partial class Form1
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
            this.lbxMyTrips = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDistance = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbxActions = new System.Windows.Forms.GroupBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpgTrips = new System.Windows.Forms.TabPage();
            this.tbpgAdd = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbxActions.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpgTrips.SuspendLayout();
            this.tbpgAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxMyTrips
            // 
            this.lbxMyTrips.FormattingEnabled = true;
            this.lbxMyTrips.ItemHeight = 25;
            this.lbxMyTrips.Location = new System.Drawing.Point(16, 33);
            this.lbxMyTrips.Margin = new System.Windows.Forms.Padding(5);
            this.lbxMyTrips.Name = "lbxMyTrips";
            this.lbxMyTrips.Size = new System.Drawing.Size(463, 229);
            this.lbxMyTrips.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudRating);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudDistance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxTo);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(306, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(382, 218);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add trip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(18, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 48;
            this.label5.Text = "Rating:";
            // 
            // nudRating
            // 
            this.nudRating.DecimalPlaces = 1;
            this.nudRating.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudRating.Location = new System.Drawing.Point(138, 130);
            this.nudRating.Margin = new System.Windows.Forms.Padding(2);
            this.nudRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(165, 31);
            this.nudRating.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(309, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "KM";
            // 
            // nudDistance
            // 
            this.nudDistance.DecimalPlaces = 3;
            this.nudDistance.Location = new System.Drawing.Point(138, 91);
            this.nudDistance.Margin = new System.Windows.Forms.Padding(2);
            this.nudDistance.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDistance.Name = "nudDistance";
            this.nudDistance.Size = new System.Drawing.Size(165, 31);
            this.nudDistance.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Distance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "To:";
            // 
            // tbxTo
            // 
            this.tbxTo.Location = new System.Drawing.Point(138, 45);
            this.tbxTo.Margin = new System.Windows.Forms.Padding(5);
            this.tbxTo.Name = "tbxTo";
            this.tbxTo.Size = new System.Drawing.Size(212, 31);
            this.tbxTo.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 168);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(332, 34);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteAll);
            this.groupBox2.Controls.Add(this.btnShowAll);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbxSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.lbxMyTrips);
            this.groupBox2.Location = new System.Drawing.Point(14, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(499, 411);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "My trips";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(17, 316);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(462, 34);
            this.btnDeleteAll.TabIndex = 24;
            this.btnDeleteAll.Text = "Delete";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(16, 272);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(5);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(462, 34);
            this.btnShowAll.TabIndex = 23;
            this.btnShowAll.Text = "Show all";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 369);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "To:";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(63, 364);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(5);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(259, 31);
            this.tbxSearch.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(330, 362);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(148, 34);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbxActions
            // 
            this.gbxActions.Controls.Add(this.btnInfo);
            this.gbxActions.Controls.Add(this.btnDelete);
            this.gbxActions.Location = new System.Drawing.Point(564, 8);
            this.gbxActions.Margin = new System.Windows.Forms.Padding(2);
            this.gbxActions.Name = "gbxActions";
            this.gbxActions.Padding = new System.Windows.Forms.Padding(2);
            this.gbxActions.Size = new System.Drawing.Size(382, 148);
            this.gbxActions.TabIndex = 43;
            this.gbxActions.TabStop = false;
            this.gbxActions.Text = "Selected trip";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(18, 39);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(5);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(332, 34);
            this.btnInfo.TabIndex = 45;
            this.btnInfo.Text = "Show info of selected trip";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(18, 84);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(332, 34);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete selected trip";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpgTrips);
            this.tabControl1.Controls.Add(this.tbpgAdd);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1003, 480);
            this.tabControl1.TabIndex = 44;
            // 
            // tbpgTrips
            // 
            this.tbpgTrips.Controls.Add(this.groupBox2);
            this.tbpgTrips.Controls.Add(this.gbxActions);
            this.tbpgTrips.Location = new System.Drawing.Point(4, 34);
            this.tbpgTrips.Name = "tbpgTrips";
            this.tbpgTrips.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgTrips.Size = new System.Drawing.Size(995, 442);
            this.tbpgTrips.TabIndex = 0;
            this.tbpgTrips.Text = "Trips";
            this.tbpgTrips.UseVisualStyleBackColor = true;
            // 
            // tbpgAdd
            // 
            this.tbpgAdd.Controls.Add(this.groupBox1);
            this.tbpgAdd.Location = new System.Drawing.Point(4, 34);
            this.tbpgAdd.Name = "tbpgAdd";
            this.tbpgAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgAdd.Size = new System.Drawing.Size(995, 442);
            this.tbpgAdd.TabIndex = 1;
            this.tbpgAdd.Text = "Add";
            this.tbpgAdd.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(319, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 25);
            this.label6.TabIndex = 49;
            this.label6.Text = "/5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1027, 504);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "The bike app";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxActions.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbpgTrips.ResumeLayout(false);
            this.tbpgAdd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbxMyTrips;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbxActions;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudDistance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpgTrips;
        private System.Windows.Forms.TabPage tbpgAdd;
        private System.Windows.Forms.Label label6;
    }
}

