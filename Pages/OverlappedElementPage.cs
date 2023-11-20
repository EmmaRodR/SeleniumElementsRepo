using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Pages.BasePage
{
    public class OverlappedElementPage : BasePage
    {

        private IWebDriver _driver;


        [FindsBy(How = How.Id, Using = ("id"))]
        private IWebElement idInput;

        [FindsBy(How = How.Id, Using = ("name"))]
        private IWebElement nameInput;

        [FindsBy(How = How.XPath, Using = ("/html/body/section/div/div/div[1]"))]
        private IWebElement scrollBox;




        public OverlappedElementPage (IWebDriver driver) : base (driver)
        {
            this._driver = driver;

        }


        public void TypeInId (String id)
        {

            BasePage.typeText(idInput, id);

        }

        public void TypeInName (String name) {

            BasePage.typeText(nameInput, name); 
            
        }


        public void ScrollToNameInput ()
        {
            BasePage.ScrollDown(_driver, scrollBox);

        }










    }
}
