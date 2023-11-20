using MejorandoConceptos.Pages.BasePage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Tests.BaseTest
{
    public class DynamicIDTest : BaseTest
    {

        private IWebDriver _driver;


        [SetUp]
        public void SetUp ()
        {

           _driver = BaseTest.initialize(WikiDex.Utils.Browser_Manager.DriverType.CHROME);
           _driver = BaseTest.goToUrl("http://uitestingplayground.com/dynamicid");

        }


        [Test]

        public void clickDynamicBtn()
        {

            DynamicIDPage dp = new DynamicIDPage(_driver);
            dp.clickOnDynamicBtn();
            _driver.Navigate().Refresh();
            dp.clickOnDynamicBtn();
        }


        [TearDown]
        public void tearDown()
        {
            BaseTest.tearDown();
        }




    }
}
