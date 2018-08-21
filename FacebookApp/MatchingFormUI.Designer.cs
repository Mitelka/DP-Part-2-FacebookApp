namespace FacebookApp
{
    partial class MatchingFormUI
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
            this.interstingLabel = new System.Windows.Forms.Label();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.ageRangeLabel = new System.Windows.Forms.Label();
            this.fromTrack = new System.Windows.Forms.TrackBar();
            this.ToTrackBar = new System.Windows.Forms.TrackBar();
            this.fromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.fromRangeChosen = new System.Windows.Forms.Label();
            this.maxRangeChosen = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.profilePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fromTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // interstingLabel
            // 
            this.interstingLabel.AutoSize = true;
            this.interstingLabel.Location = new System.Drawing.Point(22, 144);
            this.interstingLabel.Name = "interstingLabel";
            this.interstingLabel.Size = new System.Drawing.Size(70, 13);
            this.interstingLabel.TabIndex = 1;
            this.interstingLabel.Text = "Intersting in...";
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(136, 145);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.maleRadioButton.TabIndex = 2;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            this.maleRadioButton.CheckedChanged += new System.EventHandler(this.maleRadioButton_CheckedChanged);
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(203, 145);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioButton.TabIndex = 3;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            this.femaleRadioButton.CheckedChanged += new System.EventHandler(this.femaleChecked);
            // 
            // ageRangeLabel
            // 
            this.ageRangeLabel.AutoSize = true;
            this.ageRangeLabel.Location = new System.Drawing.Point(133, 180);
            this.ageRangeLabel.Name = "ageRangeLabel";
            this.ageRangeLabel.Size = new System.Drawing.Size(56, 13);
            this.ageRangeLabel.TabIndex = 4;
            this.ageRangeLabel.Text = "Age range";
            // 
            // fromTrack
            // 
            this.fromTrack.Location = new System.Drawing.Point(12, 219);
            this.fromTrack.Name = "fromTrack";
            this.fromTrack.Size = new System.Drawing.Size(145, 45);
            this.fromTrack.TabIndex = 5;
            this.fromTrack.Scroll += new System.EventHandler(this.fromTrackScroll);
            // 
            // ToTrackBar
            // 
            this.ToTrackBar.Location = new System.Drawing.Point(180, 219);
            this.ToTrackBar.Name = "ToTrackBar";
            this.ToTrackBar.Size = new System.Drawing.Size(145, 45);
            this.ToTrackBar.TabIndex = 6;
            this.ToTrackBar.Scroll += new System.EventHandler(this.ToTrackBar_Scroll);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(57, 203);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(30, 13);
            this.fromLabel.TabIndex = 7;
            this.fromLabel.Text = "From";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(237, 203);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(20, 13);
            this.ToLabel.TabIndex = 8;
            this.ToLabel.Text = "To";
            // 
            // fromRangeChosen
            // 
            this.fromRangeChosen.AutoSize = true;
            this.fromRangeChosen.Location = new System.Drawing.Point(68, 267);
            this.fromRangeChosen.Name = "fromRangeChosen";
            this.fromRangeChosen.Size = new System.Drawing.Size(19, 13);
            this.fromRangeChosen.TabIndex = 9;
            this.fromRangeChosen.Text = "18";
            // 
            // maxRangeChosen
            // 
            this.maxRangeChosen.AutoSize = true;
            this.maxRangeChosen.Location = new System.Drawing.Point(238, 267);
            this.maxRangeChosen.Name = "maxRangeChosen";
            this.maxRangeChosen.Size = new System.Drawing.Size(19, 13);
            this.maxRangeChosen.TabIndex = 10;
            this.maxRangeChosen.Text = "18";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(127, 300);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search!";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // profilePic
            // 
            this.profilePic.Location = new System.Drawing.Point(94, 21);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(141, 100);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 12;
            this.profilePic.TabStop = false;
            // 
            // MatchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 397);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.maxRangeChosen);
            this.Controls.Add(this.fromRangeChosen);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.ToTrackBar);
            this.Controls.Add(this.fromTrack);
            this.Controls.Add(this.ageRangeLabel);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.interstingLabel);
            this.Name = "MatchingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find your love";
            this.Load += new System.EventHandler(this.MatchingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fromTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label interstingLabel;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.Label ageRangeLabel;
        private System.Windows.Forms.TrackBar fromTrack;
        private System.Windows.Forms.TrackBar ToTrackBar;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label fromRangeChosen;
        private System.Windows.Forms.Label maxRangeChosen;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.PictureBox profilePic;
    }
}