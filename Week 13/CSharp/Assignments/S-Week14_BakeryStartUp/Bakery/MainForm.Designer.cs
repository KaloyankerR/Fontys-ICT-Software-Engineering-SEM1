
namespace Bakery
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbBreadFilter = new System.Windows.Forms.ComboBox();
            this.btnAddSandwich = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbxMenu = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.lblSandwichInfo = new System.Windows.Forms.Label();
            this.btnShowOfferedSandwiches = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowOfferedSandwiches);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbBreadFilter);
            this.groupBox1.Controls.Add(this.btnAddSandwich);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lbxMenu);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 455);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bread filter:";
            // 
            // cbbBreadFilter
            // 
            this.cbbBreadFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBreadFilter.FormattingEnabled = true;
            this.cbbBreadFilter.Items.AddRange(new object[] {
            "",
            "Ciabatta",
            "Focaccia",
            "Sour Dough",
            "Rye",
            "Whole Wheat"});
            this.cbbBreadFilter.Location = new System.Drawing.Point(140, 38);
            this.cbbBreadFilter.Name = "cbbBreadFilter";
            this.cbbBreadFilter.Size = new System.Drawing.Size(414, 40);
            this.cbbBreadFilter.TabIndex = 4;
            // 
            // btnAddSandwich
            // 
            this.btnAddSandwich.Location = new System.Drawing.Point(6, 350);
            this.btnAddSandwich.Name = "btnAddSandwich";
            this.btnAddSandwich.Size = new System.Drawing.Size(548, 46);
            this.btnAddSandwich.TabIndex = 3;
            this.btnAddSandwich.Text = "Add new Sandwich";
            this.btnAddSandwich.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(282, 400);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(272, 46);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load data";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(270, 46);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save data";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lbxMenu
            // 
            this.lbxMenu.FormattingEnabled = true;
            this.lbxMenu.ItemHeight = 32;
            this.lbxMenu.Location = new System.Drawing.Point(6, 136);
            this.lbxMenu.Name = "lbxMenu";
            this.lbxMenu.Size = new System.Drawing.Size(548, 196);
            this.lbxMenu.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRevenue);
            this.groupBox2.Controls.Add(this.btnSell);
            this.groupBox2.Controls.Add(this.lblSandwichInfo);
            this.groupBox2.Location = new System.Drawing.Point(589, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 455);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cart";
            // 
            // btnRevenue
            // 
            this.btnRevenue.Location = new System.Drawing.Point(6, 400);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(475, 46);
            this.btnRevenue.TabIndex = 2;
            this.btnRevenue.Text = "Show total revenue";
            this.btnRevenue.UseVisualStyleBackColor = true;
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(6, 348);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(475, 46);
            this.btnSell.TabIndex = 1;
            this.btnSell.Text = "Sell selected sandwhich";
            this.btnSell.UseVisualStyleBackColor = true;
            // 
            // lblSandwichInfo
            // 
            this.lblSandwichInfo.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSandwichInfo.Location = new System.Drawing.Point(6, 38);
            this.lblSandwichInfo.Name = "lblSandwichInfo";
            this.lblSandwichInfo.Size = new System.Drawing.Size(475, 307);
            this.lblSandwichInfo.TabIndex = 0;
            this.lblSandwichInfo.Text = "[Sandwich Data]";
            this.lblSandwichInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowOfferedSandwiches
            // 
            this.btnShowOfferedSandwiches.Location = new System.Drawing.Point(6, 84);
            this.btnShowOfferedSandwiches.Name = "btnShowOfferedSandwiches";
            this.btnShowOfferedSandwiches.Size = new System.Drawing.Size(548, 46);
            this.btnShowOfferedSandwiches.TabIndex = 6;
            this.btnShowOfferedSandwiches.Text = "Show offered sandwiches";
            this.btnShowOfferedSandwiches.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 470);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lbxMenu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label lblSandwichInfo;
        private System.Windows.Forms.Button btnAddSandwich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbBreadFilter;
        private System.Windows.Forms.Button btnShowOfferedSandwiches;
    }
}