using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Pages.BasePage
{
    public class VerifyTextPage : BasePage
    {
        private IWebDriver _driver;


        [FindsBy(How = How.XPath, Using = ("/html/body/section/div/div[4]"))]
        private IWebElement text;



        public VerifyTextPage (IWebDriver driver):base(driver)
        {

            this._driver = driver;
        }


        public String getText()
        {
            return text.Text;

        }








    }

}
