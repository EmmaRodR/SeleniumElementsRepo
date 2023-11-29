using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V114.Debugger;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Pages.BasePage
{
     public class ProgressBarPage : BasePage
    {

        private IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = ("//*[@id=\"progressBar\"]"))]
        private IWebElement progressBar;

        [FindsBy(How = How.Id, Using = ("stopButton"))]
        private IWebElement stopButton;


        [FindsBy(How = How.XPath, Using = ("//*[@id=\"startButton\"]"))]
        private IWebElement startButton;


        public ProgressBarPage (IWebDriver driver) : base (driver)
        {
            this._driver = driver;

        }


        public void ClickStart ()
        {

            BasePage.clickElement(startButton);
        }

        public void ClickStop()
        {

            BasePage.clickElement(stopButton);
        }


        public void StopProgressBarAt(String stopNumber)
        {

            WebDriverWait wait = new WebDriverWait(_driver,TimeSpan.FromSeconds(60));

            bool progressStatus = wait.Until(ExpectedConditions.TextToBePresentInElement(progressBar,stopNumber));

            if (progressStatus == true)
            {
                ClickStop();

            }
        }







    }
}
