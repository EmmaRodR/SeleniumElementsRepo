using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Pages.BasePage
{
    public class TextInputPage : BasePage
    {

        private IWebDriver _driver;


        [FindsBy(How = How.XPath, Using = ("//*[@id=\"newButtonName\"]"))]
        private IWebElement _inputField;


        [FindsBy(How = How.Id, Using = ("updatingButton"))]
        private IWebElement _button;



        public TextInputPage(IWebDriver driver) : base(driver)
        {
            this._driver = driver;

        }



        public void typeTextField (String text)
        {

            BasePage.typeText(_inputField, text);

        }

        public void clickButton( )
        {

            BasePage.clickElement(_button);

        }

        public String getButtonText()
        {

           return _button.Text;


        }




    }
}
