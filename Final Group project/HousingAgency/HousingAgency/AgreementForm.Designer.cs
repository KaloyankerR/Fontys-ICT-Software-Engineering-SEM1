namespace HousingAgency
{
    partial class AgreementForm
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
            this.lbAgreements = new System.Windows.Forms.ListBox();
            this.btnAddAgreement = new System.Windows.Forms.Button();
            this.txtAgreement = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupbxAgreementsAdmin = new System.Windows.Forms.GroupBox();
            this.btnAgreementsDelete = new System.Windows.Forms.Button();
            this.btnAgreementsDisapprove = new System.Windows.Forms.Button();
            this.btnAgreementsApprove = new System.Windows.Forms.Button();
            this.groupbxAgreementsAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAgreements
            // 
            this.lbAgreements.FormattingEnabled = true;
            this.lbAgreements.ItemHeight = 25;
            this.lbAgreements.Location = new System.Drawing.Point(21, 59);
            this.lbAgreements.Margin = new System.Windows.Forms.Padding(2);
            this.lbAgreements.Name = "lbAgreements";
            this.lbAgreements.Size = new System.Drawing.Size(466, 379);
            this.lbAgreements.TabIndex = 0;
            // 
            // btnAddAgreement
            // 
            this.btnAddAgreement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.btnAddAgreement.Location = new System.Drawing.Point(511, 162);
            this.btnAddAgreement.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAgreement.Name = "btnAddAgreement";
            this.btnAddAgreement.Size = new System.Drawing.Size(265, 49);
            this.btnAddAgreement.TabIndex = 1;
            this.btnAddAgreement.Text = "Add Agreement";
            this.btnAddAgreement.UseVisualStyleBackColor = false;
            this.btnAddAgreement.Click += new System.EventHandler(this.btnAddAgreement_Click);
            // 
            // txtAgreement
            // 
            this.txtAgreement.Location = new System.Drawing.Point(511, 59);
            this.txtAgreement.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgreement.Name = "txtAgreement";
            this.txtAgreement.Size = new System.Drawing.Size(265, 99);
            this.txtAgreement.TabIndex = 2;
            this.txtAgreement.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add a new Agreement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Agreements:";
            // 
            // groupbxAgreementsAdmin
            // 
            this.groupbxAgreementsAdmin.Controls.Add(this.btnAgreementsDelete);
            this.groupbxAgreementsAdmin.Controls.Add(this.btnAgreementsDisapprove);
            this.groupbxAgreementsAdmin.Controls.Add(this.btnAgreementsApprove);
            this.groupbxAgreementsAdmin.Location = new System.Drawing.Point(511, 288);
            this.groupbxAgreementsAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.groupbxAgreementsAdmin.Name = "groupbxAgreementsAdmin";
            this.groupbxAgreementsAdmin.Padding = new System.Windows.Forms.Padding(2);
            this.groupbxAgreementsAdmin.Size = new System.Drawing.Size(265, 150);
            this.groupbxAgreementsAdmin.TabIndex = 6;
            this.groupbxAgreementsAdmin.TabStop = false;
            this.groupbxAgreementsAdmin.Text = "Admin";
            // 
            // btnAgreementsDelete
            // 
            this.btnAgreementsDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.btnAgreementsDelete.Location = new System.Drawing.Point(41, 110);
            this.btnAgreementsDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgreementsDelete.Name = "btnAgreementsDelete";
            this.btnAgreementsDelete.Size = new System.Drawing.Size(190, 34);
            this.btnAgreementsDelete.TabIndex = 2;
            this.btnAgreementsDelete.Text = "Delete";
            this.btnAgreementsDelete.UseVisualStyleBackColor = false;
            this.btnAgreementsDelete.Click += new System.EventHandler(this.btnAgreementsDelete_Click_1);
            // 
            // btnAgreementsDisapprove
            // 
            this.btnAgreementsDisapprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.btnAgreementsDisapprove.Location = new System.Drawing.Point(41, 70);
            this.btnAgreementsDisapprove.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgreementsDisapprove.Name = "btnAgreementsDisapprove";
            this.btnAgreementsDisapprove.Size = new System.Drawing.Size(190, 34);
            this.btnAgreementsDisapprove.TabIndex = 1;
            this.btnAgreementsDisapprove.Text = "Disapprove";
            this.btnAgreementsDisapprove.UseVisualStyleBackColor = false;
            this.btnAgreementsDisapprove.Click += new System.EventHandler(this.btnAgreementsDisapprove_Click_1);
            // 
            // btnAgreementsApprove
            // 
            this.btnAgreementsApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.btnAgreementsApprove.Location = new System.Drawing.Point(41, 30);
            this.btnAgreementsApprove.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgreementsApprove.Name = "btnAgreementsApprove";
            this.btnAgreementsApprove.Size = new System.Drawing.Size(190, 34);
            this.btnAgreementsApprove.TabIndex = 0;
            this.btnAgreementsApprove.Text = "Approve";
            this.btnAgreementsApprove.UseVisualStyleBackColor = false;
            this.btnAgreementsApprove.Click += new System.EventHandler(this.btnAgreementsApprove_Click_1);
            // 
            // AgreementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupbxAgreementsAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAgreement);
            this.Controls.Add(this.btnAddAgreement);
            this.Controls.Add(this.lbAgreements);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgreementForm";
            this.Text = "AgreementForm";
            this.groupbxAgreementsAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox lbAgreements;
        private Button btnAddAgreement;
        private RichTextBox txtAgreement;
        private Label label1;
        private Label label2;
        private GroupBox groupbxAgreementsAdmin;
        private Button btnAgreementsApprove;
        private Button btnAgreementsDisapprove;
        private Button btnAgreementsDelete;
    }
}