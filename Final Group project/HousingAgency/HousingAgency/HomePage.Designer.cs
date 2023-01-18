namespace HousingAgency
{
    partial class HomePage
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
            this.lbHouseRulesTitle = new System.Windows.Forms.Label();
            this.linkToLandLord = new System.Windows.Forms.LinkLabel();
            this.tabControlHomePage = new System.Windows.Forms.TabControl();
            this.tabHouseRulesFront = new System.Windows.Forms.TabPage();
            this.listRules = new System.Windows.Forms.ListBox();
            this.tabHouseRulesBackend = new System.Windows.Forms.TabPage();
            this.numIDRule = new System.Windows.Forms.NumericUpDown();
            this.lblID = new System.Windows.Forms.Label();
            this.numRuleIndex = new System.Windows.Forms.NumericUpDown();
            this.lblSelectRule = new System.Windows.Forms.Label();
            this.btnEditRule = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.richRules = new System.Windows.Forms.RichTextBox();
            this.btnCreateRule = new System.Windows.Forms.Button();
            this.lblDescriptionHouseRules = new System.Windows.Forms.Label();
            this.tabControlHomePage.SuspendLayout();
            this.tabHouseRulesFront.SuspendLayout();
            this.tabHouseRulesBackend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIDRule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRuleIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHouseRulesTitle
            // 
            this.lbHouseRulesTitle.AutoSize = true;
            this.lbHouseRulesTitle.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHouseRulesTitle.Location = new System.Drawing.Point(312, 26);
            this.lbHouseRulesTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHouseRulesTitle.Name = "lbHouseRulesTitle";
            this.lbHouseRulesTitle.Size = new System.Drawing.Size(167, 30);
            this.lbHouseRulesTitle.TabIndex = 0;
            this.lbHouseRulesTitle.Text = "House rules";
            // 
            // linkToLandLord
            // 
            this.linkToLandLord.AutoSize = true;
            this.linkToLandLord.Location = new System.Drawing.Point(296, 345);
            this.linkToLandLord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkToLandLord.Name = "linkToLandLord";
            this.linkToLandLord.Size = new System.Drawing.Size(174, 25);
            this.linkToLandLord.TabIndex = 8;
            this.linkToLandLord.TabStop = true;
            this.linkToLandLord.Text = "Contact my landlord";
            this.linkToLandLord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToLandLord_LinkClicked);
            // 
            // tabControlHomePage
            // 
            this.tabControlHomePage.Controls.Add(this.tabHouseRulesFront);
            this.tabControlHomePage.Controls.Add(this.tabHouseRulesBackend);
            this.tabControlHomePage.Location = new System.Drawing.Point(2, 2);
            this.tabControlHomePage.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlHomePage.Name = "tabControlHomePage";
            this.tabControlHomePage.SelectedIndex = 0;
            this.tabControlHomePage.Size = new System.Drawing.Size(798, 445);
            this.tabControlHomePage.TabIndex = 10;
            // 
            // tabHouseRulesFront
            // 
            this.tabHouseRulesFront.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tabHouseRulesFront.Controls.Add(this.listRules);
            this.tabHouseRulesFront.Controls.Add(this.linkToLandLord);
            this.tabHouseRulesFront.Controls.Add(this.lbHouseRulesTitle);
            this.tabHouseRulesFront.Location = new System.Drawing.Point(4, 34);
            this.tabHouseRulesFront.Margin = new System.Windows.Forms.Padding(2);
            this.tabHouseRulesFront.Name = "tabHouseRulesFront";
            this.tabHouseRulesFront.Padding = new System.Windows.Forms.Padding(2);
            this.tabHouseRulesFront.Size = new System.Drawing.Size(790, 407);
            this.tabHouseRulesFront.TabIndex = 0;
            this.tabHouseRulesFront.Text = "House Rules";
            // 
            // listRules
            // 
            this.listRules.FormattingEnabled = true;
            this.listRules.ItemHeight = 25;
            this.listRules.Location = new System.Drawing.Point(78, 82);
            this.listRules.Margin = new System.Windows.Forms.Padding(2);
            this.listRules.Name = "listRules";
            this.listRules.Size = new System.Drawing.Size(634, 229);
            this.listRules.TabIndex = 9;
            // 
            // tabHouseRulesBackend
            // 
            this.tabHouseRulesBackend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tabHouseRulesBackend.Controls.Add(this.numIDRule);
            this.tabHouseRulesBackend.Controls.Add(this.lblID);
            this.tabHouseRulesBackend.Controls.Add(this.numRuleIndex);
            this.tabHouseRulesBackend.Controls.Add(this.lblSelectRule);
            this.tabHouseRulesBackend.Controls.Add(this.btnEditRule);
            this.tabHouseRulesBackend.Controls.Add(this.btnDelete);
            this.tabHouseRulesBackend.Controls.Add(this.richRules);
            this.tabHouseRulesBackend.Controls.Add(this.btnCreateRule);
            this.tabHouseRulesBackend.Controls.Add(this.lblDescriptionHouseRules);
            this.tabHouseRulesBackend.Location = new System.Drawing.Point(4, 34);
            this.tabHouseRulesBackend.Margin = new System.Windows.Forms.Padding(2);
            this.tabHouseRulesBackend.Name = "tabHouseRulesBackend";
            this.tabHouseRulesBackend.Padding = new System.Windows.Forms.Padding(2);
            this.tabHouseRulesBackend.Size = new System.Drawing.Size(790, 407);
            this.tabHouseRulesBackend.TabIndex = 1;
            this.tabHouseRulesBackend.Text = "Create Rules";
            // 
            // numIDRule
            // 
            this.numIDRule.Location = new System.Drawing.Point(145, 40);
            this.numIDRule.Margin = new System.Windows.Forms.Padding(2);
            this.numIDRule.Name = "numIDRule";
            this.numIDRule.Size = new System.Drawing.Size(150, 31);
            this.numIDRule.TabIndex = 9;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(108, 42);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(39, 25);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID :";
            // 
            // numRuleIndex
            // 
            this.numRuleIndex.Location = new System.Drawing.Point(404, 268);
            this.numRuleIndex.Margin = new System.Windows.Forms.Padding(2);
            this.numRuleIndex.Name = "numRuleIndex";
            this.numRuleIndex.Size = new System.Drawing.Size(150, 31);
            this.numRuleIndex.TabIndex = 7;
            // 
            // lblSelectRule
            // 
            this.lblSelectRule.AutoSize = true;
            this.lblSelectRule.Location = new System.Drawing.Point(212, 270);
            this.lblSelectRule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectRule.Name = "lblSelectRule";
            this.lblSelectRule.Size = new System.Drawing.Size(176, 25);
            this.lblSelectRule.TabIndex = 6;
            this.lblSelectRule.Text = "Select rule to delete :";
            // 
            // btnEditRule
            // 
            this.btnEditRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.btnEditRule.Location = new System.Drawing.Point(338, 315);
            this.btnEditRule.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditRule.Name = "btnEditRule";
            this.btnEditRule.Size = new System.Drawing.Size(129, 70);
            this.btnEditRule.TabIndex = 5;
            this.btnEditRule.Text = "Delete index rule";
            this.btnEditRule.UseVisualStyleBackColor = false;
            this.btnEditRule.Click += new System.EventHandler(this.btnDeleteRule_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.btnDelete.Location = new System.Drawing.Point(280, 192);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(458, 41);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete All Rules";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // richRules
            // 
            this.richRules.Location = new System.Drawing.Point(145, 82);
            this.richRules.Margin = new System.Windows.Forms.Padding(2);
            this.richRules.Name = "richRules";
            this.richRules.Size = new System.Drawing.Size(593, 82);
            this.richRules.TabIndex = 3;
            this.richRules.Text = "";
            // 
            // btnCreateRule
            // 
            this.btnCreateRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.btnCreateRule.Location = new System.Drawing.Point(158, 192);
            this.btnCreateRule.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateRule.Name = "btnCreateRule";
            this.btnCreateRule.Size = new System.Drawing.Size(94, 41);
            this.btnCreateRule.TabIndex = 2;
            this.btnCreateRule.Text = "Create";
            this.btnCreateRule.UseVisualStyleBackColor = false;
            this.btnCreateRule.Click += new System.EventHandler(this.btnCreateRule_Click);
            // 
            // lblDescriptionHouseRules
            // 
            this.lblDescriptionHouseRules.AutoSize = true;
            this.lblDescriptionHouseRules.Location = new System.Drawing.Point(25, 116);
            this.lblDescriptionHouseRules.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescriptionHouseRules.Name = "lblDescriptionHouseRules";
            this.lblDescriptionHouseRules.Size = new System.Drawing.Size(111, 25);
            this.lblDescriptionHouseRules.TabIndex = 0;
            this.lblDescriptionHouseRules.Text = "Description :";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlHomePage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(817, 495);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.tabControlHomePage.ResumeLayout(false);
            this.tabHouseRulesFront.ResumeLayout(false);
            this.tabHouseRulesFront.PerformLayout();
            this.tabHouseRulesBackend.ResumeLayout(false);
            this.tabHouseRulesBackend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIDRule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRuleIndex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbHouseRulesTitle;
        private LinkLabel linkToLandLord;
        private TabControl tabControlHomePage;
        private TabPage tabHouseRulesFront;
        private TabPage tabHouseRulesBackend;
        private Label lblDescriptionHouseRules;
        private Button btnCreateRule;
        private ListBox listRules;
        private RichTextBox richRules;
        private Button btnDelete;
        private Button btnEditRule;
        private NumericUpDown numRuleIndex;
        private Label lblSelectRule;
        private NumericUpDown numIDRule;
        private Label lblID;
    }
}