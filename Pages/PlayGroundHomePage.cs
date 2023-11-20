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
    public class PlayGroundHomePage : BasePage
    {


        private IWebDriver _driver;
        


        public PlayGroundHomePage(IWebDriver driver) : base(driver)
        {
           this._driver = driver;
        }

       


        public void selectLinkOption( String option) {

            IList<IWebElement> listElements = _driver.FindElements(By.TagName("a"));

                foreach (IWebElement element in listElements) {


                    if (element.Text.Contains(option)) {

                        element.Click();
                        break;

                } 
                

            }

        }



        public String getTitle ()
        {
            return _driver.Title;

        }

      

    }
}
