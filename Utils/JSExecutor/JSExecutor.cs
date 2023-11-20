using AngleSharp.Dom;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Utils.JSExecutor
{
    public static class JSExecutor
    {

        static IWebDriver _driver;

        public static void logInWithJS(IWebDriver _driver)
        {

            IJavaScriptExecutor executor =  (IJavaScriptExecutor) _driver;

            IWebElement loginButton = _driver.FindElement(By.Name("login-button"));
            IWebElement userInput = _driver.FindElement(By.Name("user-name"));
            IWebElement passwordInput = _driver.FindElement(By.Name("password"));


            string sendUserKeys ="arguments[0].value='standard_user';";
            string sendPasswordKeys = "arguments[0].value='secret_sauce';";
            string clickButton = "arguments[0].click()";


            executor.ExecuteScript(sendUserKeys, userInput);
            executor.ExecuteScript(sendPasswordKeys, passwordInput);
            executor.ExecuteScript(clickButton, loginButton);

        }




    }
}
