using MejorandoConceptos.Pages.BasePage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Tests.BaseTest
{
    public class HiddenLayerTest : BaseTest
    {

        private IWebDriver _driver;

        [SetUp] 

        public void initialize ()
        {

            _driver = BaseTest.initialize(WikiDex.Utils.Browser_Manager.DriverType.CHROME);
            _driver = BaseTest.goToUrl("http://www.uitestingplayground.com/hiddenlayers");
        }


        [Test]

        public void notClickHiddenElement()
        {
            HiddenLayerPage hiddenlpage = new HiddenLayerPage(_driver);
            hiddenlpage.clickGreenButton();
            hiddenlpage.ElementNotDisplayed(hiddenlpage.getGreenButtonElement());
        }


        [TearDown]
        public void tearDown()
        {
            BaseTest.tearDown();
        }


    }
}
