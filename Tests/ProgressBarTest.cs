using MejorandoConceptos.Pages.BasePage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Tests.BaseTest
{
    public class ProgressBarTest : BaseTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void Initialize ()
        {
            _driver = BaseTest.initialize(WikiDex.Utils.Browser_Manager.DriverType.CHROME);
            _driver = BaseTest.goToUrl("http://uitestingplayground.com/progressbar");


        }

        [Test]
        public void StopProgressBar ()
        {
            ProgressBarPage pbp = new ProgressBarPage(_driver);

            String stopNumber ="75";

            pbp.ClickStart();
            pbp.StopProgressBarAt(stopNumber);


        }

        [TearDown]
        public void TearDown ()
        {

            BaseTest.tearDown();

        }
        



    }
}
