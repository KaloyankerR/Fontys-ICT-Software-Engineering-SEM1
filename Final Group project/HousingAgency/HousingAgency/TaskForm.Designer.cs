namespace HousingAgency
{
    partial class TaskForm
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
            this.lbDisplayTasks = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tasks = new System.Windows.Forms.TabPage();
            this.btnRemoveFromTask = new System.Windows.Forms.Button();
            this.AddTask = new System.Windows.Forms.TabPage();
            this.btnAssignTaskMemebr = new System.Windows.Forms.Button();
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.lblAssignedUser = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.Tasks.SuspendLayout();
            this.AddTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDisplayTasks
            // 
            this.lbDisplayTasks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDisplayTasks.FormattingEnabled = true;
            this.lbDisplayTasks.ItemHeight = 32;
            this.lbDisplayTasks.Location = new System.Drawing.Point(250, 26);
            this.lbDisplayTasks.Margin = new System.Windows.Forms.Padding(2);
            this.lbDisplayTasks.Name = "lbDisplayTasks";
            this.lbDisplayTasks.Size = new System.Drawing.Size(448, 260);
            this.lbDisplayTasks.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tasks);
            this.tabControl1.Controls.Add(this.AddTask);
            this.tabControl1.Location = new System.Drawing.Point(12, 29);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 409);
            this.tabControl1.TabIndex = 1;
            // 
            // Tasks
            // 
            this.Tasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.Tasks.Controls.Add(this.btnRemoveFromTask);
            this.Tasks.Controls.Add(this.lbDisplayTasks);
            this.Tasks.Location = new System.Drawing.Point(4, 34);
            this.Tasks.Margin = new System.Windows.Forms.Padding(2);
            this.Tasks.Name = "Tasks";
            this.Tasks.Padding = new System.Windows.Forms.Padding(2);
            this.Tasks.Size = new System.Drawing.Size(754, 371);
            this.Tasks.TabIndex = 0;
            this.Tasks.Text = "Tasks";
            // 
            // btnRemoveFromTask
            // 
            this.btnRemoveFromTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.btnRemoveFromTask.Location = new System.Drawing.Point(18, 276);
            this.btnRemoveFromTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveFromTask.Name = "btnRemoveFromTask";
            this.btnRemoveFromTask.Size = new System.Drawing.Size(208, 52);
            this.btnRemoveFromTask.TabIndex = 1;
            this.btnRemoveFromTask.Text = "Remove task";
            this.btnRemoveFromTask.UseVisualStyleBackColor = false;
            this.btnRemoveFromTask.Click += new System.EventHandler(this.btnRemoveFromTask_Click);
            // 
            // AddTask
            // 
            this.AddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.AddTask.Controls.Add(this.btnAssignTaskMemebr);
            this.AddTask.Controls.Add(this.lblTaskDescription);
            this.AddTask.Controls.Add(this.lblAssignedUser);
            this.AddTask.Controls.Add(this.txbDescription);
            this.AddTask.Controls.Add(this.cmbUsers);
            this.AddTask.Location = new System.Drawing.Point(4, 34);
            this.AddTask.Margin = new System.Windows.Forms.Padding(2);
            this.AddTask.Name = "AddTask";
            this.AddTask.Padding = new System.Windows.Forms.Padding(2);
            this.AddTask.Size = new System.Drawing.Size(754, 371);
            this.AddTask.TabIndex = 1;
            this.AddTask.Text = "Add Task";
            // 
            // btnAssignTaskMemebr
            // 
            this.btnAssignTaskMemebr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.btnAssignTaskMemebr.Location = new System.Drawing.Point(292, 225);
            this.btnAssignTaskMemebr.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssignTaskMemebr.Name = "btnAssignTaskMemebr";
            this.btnAssignTaskMemebr.Size = new System.Drawing.Size(112, 34);
            this.btnAssignTaskMemebr.TabIndex = 4;
            this.btnAssignTaskMemebr.Text = "Submit";
            this.btnAssignTaskMemebr.UseVisualStyleBackColor = false;
            this.btnAssignTaskMemebr.Click += new System.EventHandler(this.btnAssignTaskMemebr_Click);
            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.AutoSize = true;
            this.lblTaskDescription.Location = new System.Drawing.Point(2, 138);
            this.lblTaskDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(144, 25);
            this.lblTaskDescription.TabIndex = 3;
            this.lblTaskDescription.Text = "Task Description:";
            // 
            // lblAssignedUser
            // 
            this.lblAssignedUser.AutoSize = true;
            this.lblAssignedUser.Location = new System.Drawing.Point(96, 75);
            this.lblAssignedUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAssignedUser.Name = "lblAssignedUser";
            this.lblAssignedUser.Size = new System.Drawing.Size(51, 25);
            this.lblAssignedUser.TabIndex = 2;
            this.lblAssignedUser.Text = "User:";
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(152, 138);
            this.txbDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(529, 31);
            this.txbDescription.TabIndex = 1;
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Items.AddRange(new object[] {
            "Danko",
            "Kaloyan",
            "Todor",
            "Timothy"});
            this.cmbUsers.Location = new System.Drawing.Point(152, 72);
            this.cmbUsers.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(159, 33);
            this.cmbUsers.TabIndex = 0;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.tabControl1.ResumeLayout(false);
            this.Tasks.ResumeLayout(false);
            this.AddTask.ResumeLayout(false);
            this.AddTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lbDisplayTasks;
        private TabControl tabControl1;
        private TabPage Tasks;
        private TabPage AddTask;
        private TextBox txbDescription;
        private ComboBox cmbUsers;
        private Label lblTaskDescription;
        private Label lblAssignedUser;
        private Button btnAssignTaskMemebr;
        private Button btnRemoveFromTask;
    }
}