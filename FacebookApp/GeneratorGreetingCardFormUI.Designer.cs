namespace FacebookApp
{
    partial class GeneratorGreetingCardFormUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.showGreetingCardButton = new System.Windows.Forms.Button();
            this.postTheGreetingCardButton = new System.Windows.Forms.Button();
            this.chooseFriendLabel = new System.Windows.Forms.Label();
            this.listBoxGreetingCardOptions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Which greeting card would you like to generate?";
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 20;
            this.friendsListBox.Location = new System.Drawing.Point(267, 232);
            this.friendsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(288, 144);
            this.friendsListBox.TabIndex = 5;
            this.friendsListBox.SelectedIndexChanged += new System.EventHandler(this.friendsListBox_SelectedIndexChanged);
            // 
            // showGreetingCardButton
            // 
            this.showGreetingCardButton.Location = new System.Drawing.Point(18, 440);
            this.showGreetingCardButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showGreetingCardButton.Name = "showGreetingCardButton";
            this.showGreetingCardButton.Size = new System.Drawing.Size(538, 35);
            this.showGreetingCardButton.TabIndex = 6;
            this.showGreetingCardButton.Text = "Show Greeting Card";
            this.showGreetingCardButton.UseVisualStyleBackColor = true;
            this.showGreetingCardButton.Click += new System.EventHandler(this.showGreetingCardPhoto);
            // 
            // postTheGreetingCardButton
            // 
            this.postTheGreetingCardButton.Location = new System.Drawing.Point(18, 534);
            this.postTheGreetingCardButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.postTheGreetingCardButton.Name = "postTheGreetingCardButton";
            this.postTheGreetingCardButton.Size = new System.Drawing.Size(538, 35);
            this.postTheGreetingCardButton.TabIndex = 7;
            this.postTheGreetingCardButton.Text = "Post the greeting card";
            this.postTheGreetingCardButton.UseVisualStyleBackColor = true;
            this.postTheGreetingCardButton.Click += new System.EventHandler(this.postTheGreetingCardButton_Click);
            // 
            // chooseFriendLabel
            // 
            this.chooseFriendLabel.AutoSize = true;
            this.chooseFriendLabel.Location = new System.Drawing.Point(18, 232);
            this.chooseFriendLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chooseFriendLabel.Name = "chooseFriendLabel";
            this.chooseFriendLabel.Size = new System.Drawing.Size(235, 20);
            this.chooseFriendLabel.TabIndex = 8;
            this.chooseFriendLabel.Text = "Pick the friend you want to bless";
            // 
            // listBoxGreetingCardOptions
            // 
            this.listBoxGreetingCardOptions.FormattingEnabled = true;
            this.listBoxGreetingCardOptions.ItemHeight = 20;
            this.listBoxGreetingCardOptions.Location = new System.Drawing.Point(174, 94);
            this.listBoxGreetingCardOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxGreetingCardOptions.Name = "listBoxGreetingCardOptions";
            this.listBoxGreetingCardOptions.Size = new System.Drawing.Size(178, 124);
            this.listBoxGreetingCardOptions.TabIndex = 9;
            this.listBoxGreetingCardOptions.SelectedIndexChanged += new System.EventHandler(this.listBoxGreetingCardOptions_SelectedIndexChanged);
            // 
            // GeneratorGreetingCardFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 597);
            this.Controls.Add(this.listBoxGreetingCardOptions);
            this.Controls.Add(this.chooseFriendLabel);
            this.Controls.Add(this.postTheGreetingCardButton);
            this.Controls.Add(this.showGreetingCardButton);
            this.Controls.Add(this.friendsListBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GeneratorGreetingCardFormUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Greeting Card Generator";
            this.Load += new System.EventHandler(this.GeneratorGreetingCardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.Button showGreetingCardButton;
        private System.Windows.Forms.Button postTheGreetingCardButton;
        private System.Windows.Forms.Label chooseFriendLabel;
        private System.Windows.Forms.ListBox listBoxGreetingCardOptions;
    }
}