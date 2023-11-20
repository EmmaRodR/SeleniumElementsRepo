using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Pages.BasePage
{
    public class BasePage 
    {

        private IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);


        }


        public static void clickElement(IWebElement element) {      

                element.Click();

        }

        public static void typeText (IWebElement element, String text)
        {

            element.Clear();
            element.SendKeys(text);

        }


        public static bool elementIsVisible (IWebElement element)
        {
                return element.Displayed.Equals(true);  
        }


        public static void scrollToElementAndClick(IWebDriver driver,IWebElement element)
        {
            Actions action = new Actions(driver);
            action.ScrollToElement(element).Perform();
            action.MoveToElement(element).Click();
        }


        public static void ScrollDown(IWebDriver driver, IWebElement element)
        {
            // Create a JavaScript executor
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            // Execute JavaScript to scroll down within the specified element
            js.ExecuteScript("arguments[0].scrollTop += 50;", element); // Adjust the pixel value as needed
        }




    }
}
