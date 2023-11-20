using MejorandoConceptos.Tests.BaseTest;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Pages.BasePage
{
    public class VisibilityPage : BasePage
    {

        private IWebDriver _driver;


        [FindsBy(How = How.Id, Using = ("hideButton"))]
        private IWebElement hideButton;

        [FindsBy(How = How.Id, Using = ("removedButton"))]
        private IWebElement removedButton;


        [FindsBy(How = How.Id, Using = ("zeroWidthButton"))]
        private IWebElement zeroWidthButton;

        [FindsBy(How = How.Id, Using = ("overlappedButton"))]
        private IWebElement overlappedButton;


        [FindsBy(How = How.Id, Using = ("transparentButton"))]
        private IWebElement transparentButton;

        [FindsBy(How = How.Id, Using = ("invisibleButton"))]
        private IWebElement invisibleButton;

        [FindsBy(How = How.Id, Using = ("notdisplayedButton"))]
        private IWebElement notdisplayedButton;

        [FindsBy(How = How.Id, Using = ("offscreenButton"))]
        private IWebElement offscreenButton
;


        public VisibilityPage(IWebDriver driver) : base(driver)
        {

            this._driver = driver;

        }


        public void ClickHideButton ()
        {

            BasePage.clickElement(hideButton);

        }


        public bool RemovedIsVisible ()
        {

            return BasePage.elementIsVisible(removedButton);

        }

        public bool ZeroWidthButtonIsVisible ()
        {
            return BasePage.elementIsVisible(zeroWidthButton);
        }

        public bool OverlappedIsVisible ()
        {

            return BasePage.elementIsVisible(overlappedButton);
        }

        public bool ZeroOpacityIsVisible ()
        {
            return BasePage.elementIsVisible(transparentButton);

        }

        public bool InvisibleButtonIsVisible ()
        {
            return BasePage.elementIsVisible (invisibleButton);

        }

        public bool NotDisplatedButtonIsVisible ()
        {

            return BasePage.elementIsVisible(notdisplayedButton);
        }

        public bool OffscreenButtonIsVisible ()
        {

            return BasePage.elementIsVisible(offscreenButton);
        }





    }
}
