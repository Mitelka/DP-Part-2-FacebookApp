using System;

namespace FacebookApp
{
    partial class MainMenuUI
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
            this.components = new System.ComponentModel.Container();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helloButton = new System.Windows.Forms.Label();
            this.openFileDialogToPickPicture = new System.Windows.Forms.OpenFileDialog();
            this.userName = new System.Windows.Forms.Label();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonFindMyLove = new System.Windows.Forms.Button();
            this.postsFilterbtn = new System.Windows.Forms.Button();
            this.genereateGreetingCardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // helloButton
            // 
            this.helloButton.AutoSize = true;
            this.helloButton.Location = new System.Drawing.Point(138, 36);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(0, 13);
            this.helloButton.TabIndex = 14;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.SystemColors.Control;
            this.userName.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.Maroon;
            this.userName.Location = new System.Drawing.Point(30, 18);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(54, 19);
            this.userName.TabIndex = 17;
            this.userName.Text = "label1";
            this.userName.Visible = false;
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(83, 52);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(109, 26);
            this.buttonlogin.TabIndex = 18;
            this.buttonlogin.Text = "Login";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // userPictureBox
            // 
            this.userPictureBox.Location = new System.Drawing.Point(68, 103);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(124, 94);
            this.userPictureBox.TabIndex = 19;
            this.userPictureBox.TabStop = false;
            this.userPictureBox.Click += new System.EventHandler(this.userPictureBox_Click);
            // 
            // buttonFindMyLove
            // 
            this.buttonFindMyLove.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonFindMyLove.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindMyLove.ForeColor = System.Drawing.Color.Red;
            this.buttonFindMyLove.Location = new System.Drawing.Point(34, 231);
            this.buttonFindMyLove.Name = "buttonFindMyLove";
            this.buttonFindMyLove.Size = new System.Drawing.Size(207, 47);
            this.buttonFindMyLove.TabIndex = 20;
            this.buttonFindMyLove.Text = "FindMyLove!";
            this.buttonFindMyLove.UseVisualStyleBackColor = false;
            this.buttonFindMyLove.Click += new System.EventHandler(this.buttonFindMyLove_Click);
            // 
            // postsFilterbtn
            // 
            this.postsFilterbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.postsFilterbtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postsFilterbtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.postsFilterbtn.Location = new System.Drawing.Point(34, 303);
            this.postsFilterbtn.Name = "postsFilterbtn";
            this.postsFilterbtn.Size = new System.Drawing.Size(207, 47);
            this.postsFilterbtn.TabIndex = 21;
            this.postsFilterbtn.Text = "Posts Filter";
            this.postsFilterbtn.UseVisualStyleBackColor = false;
            this.postsFilterbtn.Click += new System.EventHandler(this.postsFilterbtn_Click);
            // 
            // genereateGreetingCardButton
            // 
            this.genereateGreetingCardButton.Font = new System.Drawing.Font("Miriam", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.genereateGreetingCardButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.genereateGreetingCardButton.Location = new System.Drawing.Point(34, 375);
            this.genereateGreetingCardButton.Margin = new System.Windows.Forms.Padding(2);
            this.genereateGreetingCardButton.Name = "genereateGreetingCardButton";
            this.genereateGreetingCardButton.Size = new System.Drawing.Size(207, 44);
            this.genereateGreetingCardButton.TabIndex = 23;
            this.genereateGreetingCardButton.Text = "Generate a greeting card";
            this.genereateGreetingCardButton.UseVisualStyleBackColor = true;
            this.genereateGreetingCardButton.Click += new System.EventHandler(this.genereateGreetingCardButton_Click_1);
            // 
            // MainMenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(276, 442);
            this.Controls.Add(this.genereateGreetingCardButton);
            this.Controls.Add(this.postsFilterbtn);
            this.Controls.Add(this.buttonFindMyLove);
            this.Controls.Add(this.userPictureBox);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.helloButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenuUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label helloButton;
        private System.Windows.Forms.OpenFileDialog openFileDialogToPickPicture;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Button buttonFindMyLove;
        private System.Windows.Forms.Button postsFilterbtn;
        private System.Windows.Forms.Button genereateGreetingCardButton;
    }
}