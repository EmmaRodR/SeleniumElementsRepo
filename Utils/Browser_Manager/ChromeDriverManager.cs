using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiDex.Utils.Browser_Manager
{
    public class ChromeDriverManager : DriverManager {


        protected override void createDriver() {

             _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
            _driver.Manage().Window.Maximize();
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--enable-javascript");
            options.AddArgument("javascript.enabled");





        }






    }
}
