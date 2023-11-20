using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiDex.Utils.Browser_Manager
{
    public class FirefoxDriverManager : DriverManager 
    {

        protected override void createDriver()
        {

            _driver = new FirefoxDriver();


        }



    }
}
