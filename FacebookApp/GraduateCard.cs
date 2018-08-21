namespace FacebookApp
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using FacebookWrapper.ObjectModel;

    public class GraduateCard : GreetingCard
    {
        public GraduateCard(User i_Receiver) : base(i_Receiver)
        {
            GreetingText = GenerateGreetingText();
            Background = Color.Bisque;
            GreetingCardImageUrl = "http://www.theclancygroup.co.uk/wp-content/uploads/2015/09/Entrepreneur-After-Graduation--e1443105786115.jpg";
        }

        public override string GenerateGreetingText()
        {
            return string.Format(
                @"Congratulations on graduating… Wishing that brighter opportunities come your way and you achieve success in all of them!
 hope your dreams take you to the corners of your smiles, to the highest of your hopes, to the windows of your opportunities, and to the most special places your heart has ever known.");
        }
    }
}
