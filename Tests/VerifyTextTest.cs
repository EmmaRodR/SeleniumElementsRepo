using MejorandoConceptos.Pages.BasePage;
using MejorandoConceptos.Tests.BaseTest;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Tests.BaseTest
{
    public class VerifyTextTest : BaseTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void initialize()
        {
            _driver = BaseTest.initialize(WikiDex.Utils.Browser_Manager.DriverType.CHROME);
            _driver = BaseTest.goToUrl("http://uitestingplayground.com/verifytext");

        }

        [Test]

        public void verifyText ()
        {
            VerifyTextPage vft = new VerifyTextPage(_driver);
            vft.getText();
            Assert.IsTrue(vft.getText().Equals("Welcome UserName!"));
        }



        [TearDown]

        public void TearDown ()
        {

            BaseTest.tearDown();
        }



    }
}
