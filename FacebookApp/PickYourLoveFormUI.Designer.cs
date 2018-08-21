namespace FacebookApp
{
    partial class PickYourLoveFormUI
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
            this.matchesLabel = new System.Windows.Forms.Label();
            this.matchesListbox = new System.Windows.Forms.ListBox();
            this.profilePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // matchesLabel
            // 
            this.matchesLabel.AutoSize = true;
            this.matchesLabel.Location = new System.Drawing.Point(20, 20);
            this.matchesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.matchesLabel.Name = "matchesLabel";
            this.matchesLabel.Size = new System.Drawing.Size(112, 20);
            this.matchesLabel.TabIndex = 0;
            this.matchesLabel.Text = "Your matches:";
            // 
            // matchesListbox
            // 
            this.matchesListbox.FormattingEnabled = true;
            this.matchesListbox.ItemHeight = 20;
            this.matchesListbox.Location = new System.Drawing.Point(24, 61);
            this.matchesListbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.matchesListbox.Name = "matchesListbox";
            this.matchesListbox.Size = new System.Drawing.Size(187, 304);
            this.matchesListbox.TabIndex = 1;
            this.matchesListbox.SelectedIndexChanged += new System.EventHandler(this.matchesListbox_SelectedIndexChanged);
            // 
            // profilePic
            // 
            this.profilePic.Location = new System.Drawing.Point(256, 138);
            this.profilePic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(134, 129);
            this.profilePic.TabIndex = 2;
            this.profilePic.TabStop = false;
            // 
            // PickYourLoveFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.matchesListbox);
            this.Controls.Add(this.matchesLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PickYourLoveFormUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matches";
            this.Load += new System.EventHandler(this.PickYourLoveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label matchesLabel;
        private System.Windows.Forms.ListBox matchesListbox;
        private System.Windows.Forms.PictureBox profilePic;
    }
}