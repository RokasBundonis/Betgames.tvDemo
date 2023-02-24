using FinalProject.Page;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinalProject.Test
{
    public class MainTests : BaseTest
    {
        
        [Test]
        public static void CLassicWheelBet()
        {
            BetgamesHomepagePage.NavigateToPage();
            BetgamesHomepagePage.ClickOnClassicWheelButton();
        }
        [Test]
        public static void ContactUsMessage()
        {
            BetgamesHomepagePage.NavigateToPage();
            BetgamesHomepagePage.ClickOnContactUsButton();
            BetgamesHomepagePage.WriteToInputYourMessage("Test");
            BetgamesHomepagePage.WriteToInputYourEmail("Test@gmail.com");
            BetgamesHomepagePage.ClickOnContactUsButton();
        }

    }
}
