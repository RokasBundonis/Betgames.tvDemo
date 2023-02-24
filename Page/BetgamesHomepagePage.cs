using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Page
{
    public class BetgamesHomepagePage : BasePage
    {
        private const string pageUrl = "https://demo.betgames.tv/";
        private IWebElement buttonClassicWheel => Driver.FindElement(By.XPath("/html/body/div/nav[2]/div/div/div/div/button[9]"));
        private IWebElement buttonContactUs => Driver.FindElement(By.Id("contact"));
        private IWebElement inputYourEmail => Driver.FindElement(By.Id("email"));
        private IWebElement inputYourMessage => Driver.FindElement(By.Id("message"));
        private IWebElement buttonSendMessage => Driver.FindElement(By.ClassName("send btn btn-primary pull-left"));

        public BetgamesHomepagePage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToPage()
        {
            if (Driver.Url != pageUrl)
            {
                Driver.Url = pageUrl;
            }
        }

        public void ClickOnContactUsButton()
        {
            buttonContactUs.Click();
        }
        public void ClickOnSendMessageButton()
        {
            buttonSendMessage.Click();
        }
        public void ClickOnClassicWheelButton()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.
                ElementExists(By.XPath("/html/body/div/nav[2]/div/div/div/div/button[9]")));
            buttonClassicWheel.Click();
        }
        public void WriteToInputYourMessage(string yourMessage)
        {
            inputYourMessage.Clear();
            inputYourMessage.SendKeys(yourMessage);
        }
        public void WriteToInputYourEmail(string yourEmail)
        {
            inputYourEmail.Clear();
            inputYourEmail.SendKeys(yourEmail);
        }

    }
}
