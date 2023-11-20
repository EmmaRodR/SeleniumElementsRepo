using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiDex.Utils.Browser_Manager
{
    public abstract class DriverManager {


        protected IWebDriver _driver;

        protected abstract void createDriver();
        


        public void quitDriver ()
        {

            if( _driver != null )
            {
                _driver.Quit();
                _driver = null;

            }
        }


        public IWebDriver getDriver()
        {
            if(_driver == null)
            {

                createDriver();

            }

            return _driver;
        }


     









    }
}
