using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Pages.BasePage
{
    public class SimpleLoginPage : BasePage
    {

        private IWebDriver _driver;

        [FindsBy(How = How.Name, Using =("UserName"))]
        private IWebElement userField;


        [FindsBy(How = How.Name, Using =("Password"))]
        private IWebElement passwordField;

        [FindsBy(How = How.Id, Using = ("login"))]
        private IWebElement loginButton;

        [FindsBy(How = How.Id, Using = ("loginstatus"))]
        private IWebElement loginStatus;






        public SimpleLoginPage(IWebDriver driver) : base(driver)
        {
            this._driver = driver;

        }

         
        public void SimpleLoginType (String user, String password)
        {

            BasePage.typeText(userField,user);
            BasePage.typeText(passwordField,password);
         
        }

        public void ClickLoginButton ()
        {

            BasePage.clickElement(loginButton); 
        }


        public String GetLoginStatus ()
        {
            return loginStatus.Text;

        }





    }
}
