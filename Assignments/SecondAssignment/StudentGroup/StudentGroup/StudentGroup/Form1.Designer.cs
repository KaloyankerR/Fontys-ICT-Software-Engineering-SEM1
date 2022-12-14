namespace StudentGroup
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
            this.btnShow = new System.Windows.Forms.Button();
            this.listbxMembers = new System.Windows.Forms.ListBox();
            this.combobxProjectGroups = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAddGroupName = new System.Windows.Forms.TextBox();
            this.btnAddGroupAdd = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combobxProjectGroups2 = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(47, 137);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(182, 34);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // listbxMembers
            // 
            this.listbxMembers.FormattingEnabled = true;
            this.listbxMembers.ItemHeight = 25;
            this.listbxMembers.Location = new System.Drawing.Point(431, 46);
            this.listbxMembers.Name = "listbxMembers";
            this.listbxMembers.Size = new System.Drawing.Size(357, 379);
            this.listbxMembers.TabIndex = 4;
            // 
            // combobxProjectGroups
            // 
            this.combobxProjectGroups.FormattingEnabled = true;
            this.combobxProjectGroups.Location = new System.Drawing.Point(47, 98);
            this.combobxProjectGroups.Name = "combobxProjectGroups";
            this.combobxProjectGroups.Size = new System.Drawing.Size(182, 33);
            this.combobxProjectGroups.TabIndex = 5;
            this.combobxProjectGroups.SelectedIndexChanged += new System.EventHandler(this.combobxProjectGroups_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(400, 426);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(392, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combobxProjectGroups);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Location = new System.Drawing.Point(68, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 248);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Panel";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(392, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Group";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAddGroupName);
            this.groupBox3.Controls.Add(this.btnAddGroupAdd);
            this.groupBox3.Location = new System.Drawing.Point(48, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 201);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control Panel";
            // 
            // txtAddGroupName
            // 
            this.txtAddGroupName.Location = new System.Drawing.Point(72, 76);
            this.txtAddGroupName.Name = "txtAddGroupName";
            this.txtAddGroupName.Size = new System.Drawing.Size(150, 31);
            this.txtAddGroupName.TabIndex = 0;
            // 
            // btnAddGroupAdd
            // 
            this.btnAddGroupAdd.Location = new System.Drawing.Point(72, 113);
            this.btnAddGroupAdd.Name = "btnAddGroupAdd";
            this.btnAddGroupAdd.Size = new System.Drawing.Size(150, 34);
            this.btnAddGroupAdd.TabIndex = 1;
            this.btnAddGroupAdd.Text = "Add";
            this.btnAddGroupAdd.UseVisualStyleBackColor = true;
            this.btnAddGroupAdd.Click += new System.EventHandler(this.btnAddGroupAdd_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(392, 388);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add Member";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combobxProjectGroups2);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.btnAddMember);
            this.groupBox2.Location = new System.Drawing.Point(47, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 236);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Panel";
            // 
            // combobxProjectGroups2
            // 
            this.combobxProjectGroups2.FormattingEnabled = true;
            this.combobxProjectGroups2.Location = new System.Drawing.Point(51, 70);
            this.combobxProjectGroups2.Name = "combobxProjectGroups2";
            this.combobxProjectGroups2.Size = new System.Drawing.Size(182, 33);
            this.combobxProjectGroups2.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(51, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 31);
            this.txtName.TabIndex = 4;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(51, 146);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(182, 34);
            this.btnAddMember.TabIndex = 5;
            this.btnAddMember.Text = "Add";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listbxMembers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnShow;
        private ListBox listbxMembers;
        private ComboBox combobxProjectGroups;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private TabPage tabPage2;
        private Button btnAddGroupAdd;
        private TextBox txtAddGroupName;
        private TabPage tabPage3;
        private Button btnAddMember;
        private TextBox txtName;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private ComboBox combobxProjectGroups2;
    }
}