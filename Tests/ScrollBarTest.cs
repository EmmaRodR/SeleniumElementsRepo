using MejorandoConceptos.Pages.BasePage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Tests.BaseTest
{
    public class ScrollBarTest : BaseTest
    {
        private IWebDriver _driver;


        [SetUp]
        public void initialize()
        {
            _driver = BaseTest.initialize(WikiDex.Utils.Browser_Manager.DriverType.CHROME);
            _driver = BaseTest.goToUrl("http://uitestingplayground.com/scrollbars");

        }


        [Test]

        public void scrollToAndClickElement ()
        {
            ScrollBarPage sbp = new ScrollBarPage(_driver);
            sbp.scrollToElementAndClick();

        }


        [TearDown]

        public void TearDown ()
        {

            tearDown();
        }



    }
}
