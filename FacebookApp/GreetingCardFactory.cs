namespace FacebookApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FacebookWrapper.ObjectModel;

    public static class GreetingCardFactory
    {
        public static GreetingCard Create(User i_Receiver, eGreetingCardType i_CardType)
        {
            GreetingCard greetingCard = null;
            switch (i_CardType)
            {
                case eGreetingCardType.Birthday:
                    {
                        greetingCard = new BirthdayCard(i_Receiver);
                        break;
                    }

                case eGreetingCardType.Graduate:
                    {
                        greetingCard = new GraduateCard(i_Receiver);
                        break;
                    }

                case eGreetingCardType.Moving:
                    {
                        greetingCard = new MovingApartmentCard(i_Receiver);
                        break;
                    }
            }

            return greetingCard;
        }
    }
}
