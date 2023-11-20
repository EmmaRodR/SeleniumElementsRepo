using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WikiDex.Utils.Browser_Manager;

namespace MejorandoConceptos.Tests.BaseTest
{
    public abstract class BaseTest
    {

        private static IWebDriver _driver;
        private static DriverManager _driverManager;


        protected static IWebDriver initialize(DriverType type)
        {

            _driverManager = DriverManagerFactory.getManager(type);
            _driver = _driverManager.getDriver();
            return _driver;
        }

        public static IWebDriver goToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
            return _driver;
        }


        public static void tearDown()
        {
            _driverManager.quitDriver();

        }

        public static void refreshPage (IWebDriver driver)
        {

            driver.Navigate().Refresh();
        } 



    }
}
