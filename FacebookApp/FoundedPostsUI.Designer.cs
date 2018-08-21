namespace FacebookApp
{
    partial class FoundedPostsUI
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
            this.foundedPostText = new System.Windows.Forms.TextBox();
            this.resultsLabels = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // foundedPostText
            // 
            this.foundedPostText.Location = new System.Drawing.Point(9, 32);
            this.foundedPostText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.foundedPostText.Multiline = true;
            this.foundedPostText.Name = "foundedPostText";
            this.foundedPostText.ReadOnly = true;
            this.foundedPostText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.foundedPostText.Size = new System.Drawing.Size(297, 183);
            this.foundedPostText.TabIndex = 0;
            // 
            // resultsLabels
            // 
            this.resultsLabels.AutoSize = true;
            this.resultsLabels.Location = new System.Drawing.Point(8, 6);
            this.resultsLabels.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultsLabels.Name = "resultsLabels";
            this.resultsLabels.Size = new System.Drawing.Size(80, 13);
            this.resultsLabels.TabIndex = 1;
            this.resultsLabels.Text = "The results are:";
            // 
            // FoundedPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 222);
            this.Controls.Add(this.resultsLabels);
            this.Controls.Add(this.foundedPostText);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FoundedPosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.Load += new System.EventHandler(this.FoundedPosts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox foundedPostText;
        private System.Windows.Forms.Label resultsLabels;
    }
}