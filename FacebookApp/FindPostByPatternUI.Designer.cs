namespace FacebookApp
{
    partial class FindPostByPatternUI
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
            this.patternTextBox = new System.Windows.Forms.TextBox();
            this.OnePostOrAllPostsLabel = new System.Windows.Forms.Label();
            this.firstPostRadio = new System.Windows.Forms.RadioButton();
            this.allPostsRadio = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.patternLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // patternTextBox
            // 
            this.patternTextBox.Location = new System.Drawing.Point(11, 24);
            this.patternTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patternTextBox.Name = "patternTextBox";
            this.patternTextBox.Size = new System.Drawing.Size(313, 20);
            this.patternTextBox.TabIndex = 1;
            // 
            // OnePostOrAllPostsLabel
            // 
            this.OnePostOrAllPostsLabel.AutoSize = true;
            this.OnePostOrAllPostsLabel.Location = new System.Drawing.Point(8, 49);
            this.OnePostOrAllPostsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OnePostOrAllPostsLabel.Name = "OnePostOrAllPostsLabel";
            this.OnePostOrAllPostsLabel.Size = new System.Drawing.Size(315, 13);
            this.OnePostOrAllPostsLabel.TabIndex = 2;
            this.OnePostOrAllPostsLabel.Text = "Do you want the first post only or all posts that match the pattern?";
            // 
            // firstPostRadio
            // 
            this.firstPostRadio.AutoSize = true;
            this.firstPostRadio.Checked = true;
            this.firstPostRadio.Location = new System.Drawing.Point(115, 73);
            this.firstPostRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstPostRadio.Name = "firstPostRadio";
            this.firstPostRadio.Size = new System.Drawing.Size(108, 17);
            this.firstPostRadio.TabIndex = 3;
            this.firstPostRadio.TabStop = true;
            this.firstPostRadio.Text = "The first post only";
            this.firstPostRadio.UseVisualStyleBackColor = true;
            // 
            // allPostsRadio
            // 
            this.allPostsRadio.AutoSize = true;
            this.allPostsRadio.Location = new System.Drawing.Point(115, 94);
            this.allPostsRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.allPostsRadio.Name = "allPostsRadio";
            this.allPostsRadio.Size = new System.Drawing.Size(64, 17);
            this.allPostsRadio.TabIndex = 4;
            this.allPostsRadio.Text = "All posts";
            this.allPostsRadio.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(90, 131);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(147, 38);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search!";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // patternLabel
            // 
            this.patternLabel.AutoSize = true;
            this.patternLabel.Location = new System.Drawing.Point(11, 7);
            this.patternLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patternLabel.Name = "patternLabel";
            this.patternLabel.Size = new System.Drawing.Size(161, 13);
            this.patternLabel.TabIndex = 6;
            this.patternLabel.Text = "Please enter a pattern to search:";
            // 
            // FindPostByWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 183);
            this.Controls.Add(this.patternLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.allPostsRadio);
            this.Controls.Add(this.firstPostRadio);
            this.Controls.Add(this.OnePostOrAllPostsLabel);
            this.Controls.Add(this.patternTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FindPostByWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search posts";
            this.Load += new System.EventHandler(this.FindPostByWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox patternTextBox;
        private System.Windows.Forms.Label OnePostOrAllPostsLabel;
        private System.Windows.Forms.RadioButton firstPostRadio;
        private System.Windows.Forms.RadioButton allPostsRadio;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label patternLabel;
    }
}