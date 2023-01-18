namespace HousingAgency
{
    partial class Complaints
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
            this.tabControlComplaints = new System.Windows.Forms.TabControl();
            this.tabComplaintBackend = new System.Windows.Forms.TabPage();
            this.dtgViewComplaints = new System.Windows.Forms.DataGridView();
            this.tabControlForComplaints = new System.Windows.Forms.TabControl();
            this.tabPageAddComplaint = new System.Windows.Forms.TabPage();
            this.btnEditComplain = new System.Windows.Forms.Button();
            this.lblLevelComplaint = new System.Windows.Forms.Label();
            this.btnDeleteComplaint = new System.Windows.Forms.Button();
            this.comBComplaintLevel = new System.Windows.Forms.ComboBox();
            this.richTxtDescriptionComplaint = new System.Windows.Forms.RichTextBox();
            this.lblDescriptionComplaint = new System.Windows.Forms.Label();
            this.btnSubmitComplaint = new System.Windows.Forms.Button();
            this.lblTitleComplaint = new System.Windows.Forms.Label();
            this.richtxtTitleComplaint = new System.Windows.Forms.RichTextBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.tabControlComplaints.SuspendLayout();
            this.tabComplaintBackend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewComplaints)).BeginInit();
            this.tabControlForComplaints.SuspendLayout();
            this.tabPageAddComplaint.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlComplaints
            // 
            this.tabControlComplaints.Controls.Add(this.tabComplaintBackend);
            this.tabControlComplaints.Location = new System.Drawing.Point(15, 15);
            this.tabControlComplaints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlComplaints.Name = "tabControlComplaints";
            this.tabControlComplaints.SelectedIndex = 0;
            this.tabControlComplaints.Size = new System.Drawing.Size(1024, 582);
            this.tabControlComplaints.TabIndex = 12;
            // 
            // tabComplaintBackend
            // 
            this.tabComplaintBackend.Controls.Add(this.dtgViewComplaints);
            this.tabComplaintBackend.Controls.Add(this.tabControlForComplaints);
            this.tabComplaintBackend.Controls.Add(this.lblWarning);
            this.tabComplaintBackend.Location = new System.Drawing.Point(4, 34);
            this.tabComplaintBackend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabComplaintBackend.Name = "tabComplaintBackend";
            this.tabComplaintBackend.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabComplaintBackend.Size = new System.Drawing.Size(1016, 544);
            this.tabComplaintBackend.TabIndex = 1;
            this.tabComplaintBackend.Text = "Write Complaint";
            this.tabComplaintBackend.UseVisualStyleBackColor = true;
            // 
            // dtgViewComplaints
            // 
            this.dtgViewComplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViewComplaints.Location = new System.Drawing.Point(4, 0);
            this.dtgViewComplaints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgViewComplaints.Name = "dtgViewComplaints";
            this.dtgViewComplaints.RowHeadersWidth = 51;
            this.dtgViewComplaints.RowTemplate.Height = 29;
            this.dtgViewComplaints.Size = new System.Drawing.Size(1006, 259);
            this.dtgViewComplaints.TabIndex = 15;
            this.dtgViewComplaints.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgViewComplaints_CellContentClick);
            // 
            // tabControlForComplaints
            // 
            this.tabControlForComplaints.Controls.Add(this.tabPageAddComplaint);
            this.tabControlForComplaints.Location = new System.Drawing.Point(6, 261);
            this.tabControlForComplaints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlForComplaints.Name = "tabControlForComplaints";
            this.tabControlForComplaints.SelectedIndex = 0;
            this.tabControlForComplaints.Size = new System.Drawing.Size(1004, 280);
            this.tabControlForComplaints.TabIndex = 14;
            // 
            // tabPageAddComplaint
            // 
            this.tabPageAddComplaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tabPageAddComplaint.Controls.Add(this.btnEditComplain);
            this.tabPageAddComplaint.Controls.Add(this.lblLevelComplaint);
            this.tabPageAddComplaint.Controls.Add(this.btnDeleteComplaint);
            this.tabPageAddComplaint.Controls.Add(this.comBComplaintLevel);
            this.tabPageAddComplaint.Controls.Add(this.richTxtDescriptionComplaint);
            this.tabPageAddComplaint.Controls.Add(this.lblDescriptionComplaint);
            this.tabPageAddComplaint.Controls.Add(this.btnSubmitComplaint);
            this.tabPageAddComplaint.Controls.Add(this.lblTitleComplaint);
            this.tabPageAddComplaint.Controls.Add(this.richtxtTitleComplaint);
            this.tabPageAddComplaint.Location = new System.Drawing.Point(4, 34);
            this.tabPageAddComplaint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageAddComplaint.Name = "tabPageAddComplaint";
            this.tabPageAddComplaint.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageAddComplaint.Size = new System.Drawing.Size(996, 242);
            this.tabPageAddComplaint.TabIndex = 0;
            this.tabPageAddComplaint.Text = "Add Complaint";
            // 
            // btnEditComplain
            // 
            this.btnEditComplain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.btnEditComplain.Location = new System.Drawing.Point(700, 140);
            this.btnEditComplain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditComplain.Name = "btnEditComplain";
            this.btnEditComplain.Size = new System.Drawing.Size(118, 61);
            this.btnEditComplain.TabIndex = 13;
            this.btnEditComplain.Text = "Edit";
            this.btnEditComplain.UseVisualStyleBackColor = false;
            this.btnEditComplain.Click += new System.EventHandler(this.btnEditComplain_Click);
            // 
            // lblLevelComplaint
            // 
            this.lblLevelComplaint.AutoSize = true;
            this.lblLevelComplaint.Location = new System.Drawing.Point(20, 66);
            this.lblLevelComplaint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevelComplaint.Name = "lblLevelComplaint";
            this.lblLevelComplaint.Size = new System.Drawing.Size(148, 25);
            this.lblLevelComplaint.TabIndex = 0;
            this.lblLevelComplaint.Text = "Complaint level : ";
            // 
            // btnDeleteComplaint
            // 
            this.btnDeleteComplaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.btnDeleteComplaint.Location = new System.Drawing.Point(846, 140);
            this.btnDeleteComplaint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteComplaint.Name = "btnDeleteComplaint";
            this.btnDeleteComplaint.Size = new System.Drawing.Size(118, 61);
            this.btnDeleteComplaint.TabIndex = 3;
            this.btnDeleteComplaint.Text = "Delete";
            this.btnDeleteComplaint.UseVisualStyleBackColor = false;
            this.btnDeleteComplaint.Click += new System.EventHandler(this.btnDeleteComplaint_Click);
            // 
            // comBComplaintLevel
            // 
            this.comBComplaintLevel.FormattingEnabled = true;
            this.comBComplaintLevel.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.comBComplaintLevel.Location = new System.Drawing.Point(182, 62);
            this.comBComplaintLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comBComplaintLevel.Name = "comBComplaintLevel";
            this.comBComplaintLevel.Size = new System.Drawing.Size(232, 33);
            this.comBComplaintLevel.TabIndex = 12;
            // 
            // richTxtDescriptionComplaint
            // 
            this.richTxtDescriptionComplaint.Location = new System.Drawing.Point(624, 50);
            this.richTxtDescriptionComplaint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTxtDescriptionComplaint.Name = "richTxtDescriptionComplaint";
            this.richTxtDescriptionComplaint.Size = new System.Drawing.Size(274, 59);
            this.richTxtDescriptionComplaint.TabIndex = 11;
            this.richTxtDescriptionComplaint.Text = "";
            // 
            // lblDescriptionComplaint
            // 
            this.lblDescriptionComplaint.AutoSize = true;
            this.lblDescriptionComplaint.Location = new System.Drawing.Point(501, 66);
            this.lblDescriptionComplaint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescriptionComplaint.Name = "lblDescriptionComplaint";
            this.lblDescriptionComplaint.Size = new System.Drawing.Size(111, 25);
            this.lblDescriptionComplaint.TabIndex = 6;
            this.lblDescriptionComplaint.Text = "Description :";
            // 
            // btnSubmitComplaint
            // 
            this.btnSubmitComplaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.btnSubmitComplaint.Location = new System.Drawing.Point(555, 140);
            this.btnSubmitComplaint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmitComplaint.Name = "btnSubmitComplaint";
            this.btnSubmitComplaint.Size = new System.Drawing.Size(118, 61);
            this.btnSubmitComplaint.TabIndex = 2;
            this.btnSubmitComplaint.Text = "Submit";
            this.btnSubmitComplaint.UseVisualStyleBackColor = false;
            this.btnSubmitComplaint.Click += new System.EventHandler(this.btnSubmitComplaint_Click);
            // 
            // lblTitleComplaint
            // 
            this.lblTitleComplaint.AutoSize = true;
            this.lblTitleComplaint.Location = new System.Drawing.Point(8, 140);
            this.lblTitleComplaint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleComplaint.Name = "lblTitleComplaint";
            this.lblTitleComplaint.Size = new System.Drawing.Size(159, 25);
            this.lblTitleComplaint.TabIndex = 5;
            this.lblTitleComplaint.Text = "Title of complaint :";
            // 
            // richtxtTitleComplaint
            // 
            this.richtxtTitleComplaint.Location = new System.Drawing.Point(182, 136);
            this.richtxtTitleComplaint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richtxtTitleComplaint.Name = "richtxtTitleComplaint";
            this.richtxtTitleComplaint.Size = new System.Drawing.Size(232, 38);
            this.richtxtTitleComplaint.TabIndex = 10;
            this.richtxtTitleComplaint.Text = "";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(512, 16);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 25);
            this.lblWarning.TabIndex = 9;
            // 
            // Complaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1041, 600);
            this.Controls.Add(this.tabControlComplaints);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1016, 605);
            this.Name = "Complaints";
            this.Text = "Complaints";
            this.tabControlComplaints.ResumeLayout(false);
            this.tabComplaintBackend.ResumeLayout(false);
            this.tabComplaintBackend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewComplaints)).EndInit();
            this.tabControlForComplaints.ResumeLayout(false);
            this.tabPageAddComplaint.ResumeLayout(false);
            this.tabPageAddComplaint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl tabControlComplaints;
        private TabPage tabComplaintBackend;
        private Label lblDescriptionComplaint;
        private Label lblTitleComplaint;
        private Button btnDeleteComplaint;
        private Button btnSubmitComplaint;
        private Label lblLevelComplaint;
        private Label lblWarning;
        private RichTextBox richtxtTitleComplaint;
        private RichTextBox richTxtDescriptionComplaint;
        private ComboBox comBComplaintLevel;
        private Button btnEditComplain;
        private TabControl tabControlForComplaints;
        private TabPage tabPageAddComplaint;
        private DataGridView dtgViewComplaints;
    }
}