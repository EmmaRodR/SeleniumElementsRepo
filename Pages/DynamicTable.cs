using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V114.Debugger;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MejorandoConceptos.Pages.BasePage
{
    public class DynamicTable : BasePage
    {

        private IWebDriver _driver;


        [FindsBy(How = How.XPath, Using =("/html/body/section/div/div/div[3]/div"))]
        private IList<IWebElement> dataRows;

        [FindsBy(How = How.XPath, Using = ("/html/body/section/div/p[2]"))]
        private IWebElement resultText;
       



        public DynamicTable(IWebDriver driver) : base(driver) { 
        
            this._driver = driver;
        
        }
        public String GetDataRows ()
        {

            String resultText = "";

            foreach (IWebElement element in dataRows)
            {
                if (element.Text.Contains("Chrome"))
                {
                    String text = element.Text;
                    string[] words = text.Split(' ');

                    String sistOp = "";
                    String cpu = "";


                    foreach (string word in words)
                    {
                        if (word.Contains("Chrome"))
                        {
                            sistOp = word;
                        }
                        else if (word.Contains("%"))
                        {
                            cpu = word;
                        }

                    }  

                    resultText = $"{sistOp} CPU: {cpu}";

                }
                
            }

            return resultText;

        }


        public String getSearchedData ()
        {
          return resultText.Text;


        }




    }
}
