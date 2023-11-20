using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Pages.BasePage
{
    public class DynamicIDPage : BasePage
    {

        private IWebDriver _driver;


        //Locators

        [FindsBy(How = How.XPath, Using=("/html[1]/body[1]/section[1]/div[1]/button[1]"))]
        private IWebElement dynamicBtn;




        //Constructor

        public DynamicIDPage(IWebDriver driver) : base(driver)
        {
            this._driver = driver;

        }



        //Methods

        public void clickOnDynamicBtn ()
        {
                
            BasePage.clickElement(dynamicBtn);

        }








    }
}
