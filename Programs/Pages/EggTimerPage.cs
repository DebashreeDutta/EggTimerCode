using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.Pages
{
    class EggTimerPage
    {
        IWebDriver driver;
        string PageUrl = "http://e.ggtimer.com/";

        //Identifiers
        #region

        By EggTimerInput => By.Id("EggTimer-start-time-input-text");
        By StartButton => By.XPath("//button[text()='Start']");
        By WelcomeNote => By.XPath("//div[@class='EggTimer-start-welcome']");
        By TimerValues_5min => By.XPath("//div[@class='EggTimer-start-quick-time']/a[1]");
        By TimerValues_10min => By.XPath("//div[@class='EggTimer-start-quick-time']/a[2]");
        By TimerValues_15min => By.XPath("//div[@class='EggTimer-start-quick-time']/a[3]");

        By Countdown => By.XPath("//div/p[@class='ClassicTimer-time']//span ");
        #endregion

        public void eggtimerUrlLaunch()
        {
            driver = new ChromeDriver();
            driver.Url = PageUrl;
            driver.Manage().Window.Maximize();
        }
        public void eggtimerPageTitle()
        {

            Assert.That(driver.Url, Is.EqualTo(PageUrl));

        }


        public void verifyTimerTextBox(string time)
        {

            driver.FindElement(EggTimerInput).SendKeys(time);
            driver.FindElement(StartButton).Click();

        }
        public void verifyCountdownStarted()
        {

            int count = driver.FindElements(Countdown).Count();
            Console.WriteLine(count);
        }

        public void verifyCountdownPeriod(string period1, string period2, string period3)
        {
            Assert.That(driver.FindElement(TimerValues_5min).Text, Is.EqualTo(period1));
            Assert.That(driver.FindElement(TimerValues_10min).Text, Is.EqualTo(period2));
            Assert.That(driver.FindElement(TimerValues_15min).Text, Is.EqualTo(period3));
        }

        public void verifyTimerDecrement()

        {
            int count1 = driver.FindElements(Countdown).Count();
            int count2 = driver.FindElements(Countdown).Count();
            if ((count1 - count2) == 1)
            {
                Console.WriteLine("Conunter decremented by 1 sec");
            }


        }
    }
}
