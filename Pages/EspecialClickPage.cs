using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Pages.BasePage
{
    public class EspecialClickPage : BasePage
    {
        private IWebDriver _driver;


        [FindsBy(How = How.Id, Using = ("badButton"))]
        private IWebElement button;


        public EspecialClickPage (IWebDriver driver):base(driver)
        {
            _driver = driver;

        }


        public void clickEspecialButton ()
        {
            BasePage.clickElement(button);

        }
        



    }
}
