namespace FacebookApp
{
    public partial class GreetingCardForm
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
            this.greetingPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.greetingText = new System.Windows.Forms.TextBox();
            this.dearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.greetingPic)).BeginInit();
            this.SuspendLayout();
            // 
            // greetingPic
            // 
            this.greetingPic.Location = new System.Drawing.Point(328, 302);
            this.greetingPic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.greetingPic.Name = "greetingPic";
            this.greetingPic.Size = new System.Drawing.Size(460, 368);
            this.greetingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greetingPic.TabIndex = 0;
            this.greetingPic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // greetingText
            // 
            this.greetingText.BackColor = System.Drawing.SystemColors.Menu;
            this.greetingText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.greetingText.Location = new System.Drawing.Point(72, 103);
            this.greetingText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.greetingText.Multiline = true;
            this.greetingText.Name = "greetingText";
            this.greetingText.ReadOnly = true;
            this.greetingText.Size = new System.Drawing.Size(493, 189);
            this.greetingText.TabIndex = 2;
            // 
            // dearLabel
            // 
            this.dearLabel.AutoSize = true;
            this.dearLabel.Location = new System.Drawing.Point(68, 54);
            this.dearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dearLabel.Name = "dearLabel";
            this.dearLabel.Size = new System.Drawing.Size(51, 20);
            this.dearLabel.TabIndex = 3;
            this.dearLabel.Text = "label2";
            // 
            // GreetingCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 725);
            this.Controls.Add(this.dearLabel);
            this.Controls.Add(this.greetingText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.greetingPic);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GreetingCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Greeting Card";
            this.Load += new System.EventHandler(this.GreetingCardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.greetingPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox greetingPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox greetingText;
        private System.Windows.Forms.Label dearLabel;
    }
}