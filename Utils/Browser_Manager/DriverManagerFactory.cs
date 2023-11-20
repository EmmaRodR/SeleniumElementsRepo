using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V114.Debugger;
using OpenQA.Selenium.DevTools.V114.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;

namespace WikiDex.Utils.Browser_Manager
{
    public class DriverManagerFactory {


        public static DriverManager getManager(DriverType type)
        {

            DriverManager driverManager = null;


            switch (type)
            {

                case DriverType.CHROME:

                    driverManager = new ChromeDriverManager();
                    break;

                case DriverType.FIREFOX:
                    driverManager = new FirefoxDriverManager();
                    break;

                case DriverType.EDGE:
                     driverManager = new EdgeDriverManager();
                     break;
                default:
                    Console.WriteLine("Invalid browser selected");
                    break;
             }


            


            return driverManager;

        }










    }
}
