using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Pages.BasePage
{
    public class LoadDelayPage : BasePage
    {

        private IWebDriver _driver;


        [FindsBy(How = How.XPath, Using=("//button[contains(text(),'Button Appearing After Delay')]"))]
        private IWebElement btnAfterLoad;



  

        public LoadDelayPage(IWebDriver driver) : base(driver) { 
        
            this._driver = driver;
        }


        
        public String getTitle ()
        {
            return _driver.Title;

        }




    }
}
