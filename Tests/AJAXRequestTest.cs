using MejorandoConceptos.Pages.BasePage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Tests.BaseTest
{
    public class AJAXRequestTest : BaseTest
    {

        private IWebDriver _driver;

        [SetUp]
        public void initialize ()
        {
            _driver = BaseTest.initialize(WikiDex.Utils.Browser_Manager.DriverType.CHROME);
            _driver = BaseTest.goToUrl("http://www.uitestingplayground.com/ajax");

        }


        [Test]

        public void waitForAjaxRequest ()
        {
            AJAXRequest ar = new AJAXRequest(_driver);
            ar.clickAjaxRequestButton();
            ar.ElementIsDisplayed(ar.resultTextElement());
            Assert.IsTrue(ar.getResultText().Contains("AJAX"));

        }

        [TearDown]

        public void tearDown ()
        {
            BaseTest.tearDown();

        }



    }
}
