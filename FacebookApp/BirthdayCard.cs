namespace FacebookApp
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using FacebookWrapper.ObjectModel;

    public class BirthdayCard : GreetingCard
    {
        public BirthdayCard(User i_Receiver) : base(i_Receiver)
        {
            this.GreetingText = this.GenerateGreetingText();
            this.Background = Color.Aqua;
            this.GreetingCardImageUrl = "https://salemnet.vo.llnwd.net/media/cms/CROSSCARDS/36395-cc_happybirthday_floraldesign.1100w.tn.jpg";
        }

        public override string GenerateGreetingText()
        {
            return string.Format(
                @"On your special day, I wish you good luck. I hope this wonderful day will fill up your heart with joy and blessings. 
Have a fantastic birthday, celebrate the happiness on every day of your life. Congratulations to your {0}th birthday", 
                this.getAgeOfReceiver());
        }

        private int getAgeOfReceiver()
        {
            DateTime today = DateTime.Today;
            CultureInfo cultureDateTime = new CultureInfo("en-US");
            DateTime birthdayUser = Convert.ToDateTime(Receiver.Birthday, cultureDateTime);
            int age = today.Year - birthdayUser.Year;
            today.AddYears(-age);
            if (DateTime.Compare(birthdayUser, today) > 0)
            {
                age--;
            }

            return age;
        }
    }
}
