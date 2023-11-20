using OpenQA.Selenium;
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
    public class AJAXRequest : BasePage
    {
        private IWebDriver _driver;


        [FindsBy(How = How.Id, Using =("ajaxButton"))]
        private IWebElement ajaxButton;

        [FindsBy(How = How.XPath, Using = ("//p[contains(text(),'Data loaded with AJAX get request.')]"))]
        private IWebElement resultText;



        public AJAXRequest (IWebDriver driver) : base(driver)
        {
            this._driver = driver;

        }


        public void clickAjaxRequestButton()
        {
            BasePage.clickElement(ajaxButton);

        }

        public String getResultText()
        {
            return resultText.Text;

        }

        public bool ElementIsDisplayed(By locator)
        {
            new WebDriverWait(_driver, TimeSpan.FromSeconds(20)).Until(condition: ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
            return _driver.FindElement(locator).Displayed;
        }

        public By resultTextElement ()
        {
            return By.XPath("//p[contains(text(),'Data loaded with AJAX get request.')]");

        }




    }
}
