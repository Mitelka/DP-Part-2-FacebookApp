namespace FacebookApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class GreetingCardForm : Form
    {
        public GreetingCardForm(string i_RecieverGreetingName, string i_GrertingText, string i_GreetingCardImage, Color i_Background)
        {
            InitializeComponent();
            dearLabel.Text = "Dear " + i_RecieverGreetingName + ",";
            dearLabel.Font = new Font("Ariel", 10.5f, FontStyle.Bold);
            greetingText.Font = new Font("Ariel", 9f);
            greetingText.Text = i_GrertingText;
            this.BackColor = i_Background;
            this.greetingText.BackColor = i_Background;
            greetingPic.ImageLocation = i_GreetingCardImage;
            greetingPic.Load();
        }
     
        private void GreetingCardForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = dearLabel;
        }
    }
}
