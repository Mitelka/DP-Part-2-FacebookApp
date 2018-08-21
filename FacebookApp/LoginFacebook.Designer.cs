namespace FacebookApp
{
    partial class LoginFacebook
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
            this.Login = new System.Windows.Forms.Button();
            this.appIdComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AccessibleName = "";
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(104, 82);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(171, 51);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login to Facebook";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.loginFacebook_Click);
            // 
            // appIdComboBox
            // 
            this.appIdComboBox.FormattingEnabled = true;
            this.appIdComboBox.Location = new System.Drawing.Point(104, 26);
            this.appIdComboBox.Name = "appIdComboBox";
            this.appIdComboBox.Size = new System.Drawing.Size(171, 28);
            this.appIdComboBox.TabIndex = 3;
            this.appIdComboBox.Text = "Choose an app id:";
            // 
            // LoginFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 159);
            this.Controls.Add(this.appIdComboBox);
            this.Controls.Add(this.Login);
            this.Name = "LoginFacebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginFacebook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.ComboBox appIdComboBox;
    }
}

