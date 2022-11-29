namespace LoginPage
{
    partial class LoginForm
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
            this.btnRedirect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRedirect
            // 
            this.btnRedirect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRedirect.Location = new System.Drawing.Point(348, 194);
            this.btnRedirect.Name = "btnRedirect";
            this.btnRedirect.Size = new System.Drawing.Size(112, 34);
            this.btnRedirect.TabIndex = 0;
            this.btnRedirect.Text = "Redirect";
            this.btnRedirect.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRedirect);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRedirect;
    }
}