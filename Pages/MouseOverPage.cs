using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Pages.BasePage
{
    public class MouseOverPage : BasePage
    {

        private IWebDriver _driver;

        [FindsBy(How = How.LinkText,Using =("Click me"))]
        private IWebElement linkText;

        [FindsBy(How = How.Id, Using = ("clickCount"))]
        private IWebElement clickCount;

        


        public MouseOverPage(IWebDriver driver) : base(driver)
        {
            this._driver = driver;

        }


        public void DoubleClickLinkText ()
        {
            BasePage.clickElement(linkText);
            BasePage.clickElement(linkText);

        }

        public String GetClickCount ()
        {

            return clickCount.Text;

        }





    }
}
