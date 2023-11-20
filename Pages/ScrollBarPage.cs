using MejorandoConceptos.Tests.BaseTest;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Pages.BasePage
{
    public class ScrollBarPage : BasePage
    {

        private IWebDriver _driver;


        [FindsBy(How = How.Id, Using = ("hidingButton"))]
        private IWebElement hiddenButton;



        public ScrollBarPage(IWebDriver driver) : base(driver)
        {
            this._driver = driver;

        }


        public void scrollToElementAndClick ()
        {
            Actions action = new Actions(_driver);
            action.ScrollToElement(hiddenButton).Perform();
            action.MoveToElement(hiddenButton).Click();
        }

        public void clickElement()
        {

            BasePage.clickElement(hiddenButton);
        }


    }
}
