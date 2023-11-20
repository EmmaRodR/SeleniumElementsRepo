using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Pages.BasePage
{
    public class ClassAttributePage : BasePage

    {

        private IWebDriver _driver;


        //Locators

        [FindsBy(How = How.XPath, Using = ("//button[contains(concat(' ', normalize-space(@class), ' '), ' btn-primary ')]"))]
        private IWebElement classButton;


        //Constructor 

        public ClassAttributePage (IWebDriver driver) : base(driver)
        {

            this._driver = driver;
        }

        //Methods
          
        public void clickClassButton ()
        {
               BasePage.clickElement (classButton);

        }


        public void acceptPopUpAlert ()
        {

            IAlert alert = _driver.SwitchTo().Alert();
            alert.Accept();
        }

      /*  public void getAlertText()
        {
            IAlert alert = _driver.SwitchTo ().Alert();
            String text = alert.Text;
            alert.Accept();
            
        } Pendiente de resolucion */

       











    }
}
