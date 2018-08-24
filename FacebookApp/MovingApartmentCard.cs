namespace FacebookApp
{
    using System.Drawing;
    using FacebookWrapper.ObjectModel;

    public class MovingApartmentCard : GreetingCard
    {
        public MovingApartmentCard(User i_Receiver) : base(i_Receiver)
        {
            GreetingText = GenerateGreetingText();
            Background = Color.Bisque;
            GreetingCardImageUrl = "https://newdentistblog.ada.org/wp-content/uploads/2016/08/moving-expenses.jpg";
        }

        public override string GenerateGreetingText()
        {
            City location = Receiver.Location;
            string resultGreeting = string.Empty;
            if (location != null)
            {
                resultGreeting = string.Format("in {0}", location.ToString());
            }

            return string.Format(
                @"Congratulations for your new home{0}! Hope it becomes a very special place where all your dreams grow.", resultGreeting);
        }
    }
}
