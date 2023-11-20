using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MejorandoConceptos.Pages.BasePage
{public class HiddenLayerPage : BasePage
    {

        private IWebDriver _driver;

        //Locators

        [FindsBy(How = How.Id, Using = ("greenButton"))]
        private IWebElement greenButton;



        //Constructor

        public HiddenLayerPage(IWebDriver driver) : base(driver)
        {
            this._driver = driver;

        } 


        //Methods

        public void clickGreenButton ()
        {
            BasePage.clickElement(greenButton);
        }


        public bool ElementNotDisplayed(By locator)
        {
            new WebDriverWait(_driver, TimeSpan.FromSeconds(5)).Until(condition: ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
            return !_driver.FindElement(locator).Displayed;
        }

        public By getGreenButtonElement()
        {
            return By.Id("greenButton");

        }


    }
}
