namespace FacebookApp
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using FacebookWrapper.ObjectModel;

    public abstract class GreetingCard
    {
        public User Receiver { get; }

        public string GreetingText { get; set; }

        public Color Background { get; set; }

        public string GreetingCardImageUrl { get; set; }

        public GreetingCardForm GreetingCardForm { get; set; }

        public GreetingCard(User i_Receiver)
        {
            Receiver = i_Receiver;
        }

        public void ShowGreetingCard()
        {
            GreetingCardForm = new GreetingCardForm(Receiver.Name, GreetingText, GreetingCardImageUrl, Background);
            GreetingCardForm.Show();
        }

        public abstract string GenerateGreetingText();
    }
}
