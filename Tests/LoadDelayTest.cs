using MejorandoConceptos.Pages.BasePage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Tests.BaseTest
{
    public class LoadDelayTest : BaseTest
    {

        private IWebDriver _driver;

        [SetUp]
        public void initialize()
        {
            _driver = BaseTest.initialize(WikiDex.Utils.Browser_Manager.DriverType.CHROME);
            _driver = BaseTest.goToUrl("http://www.uitestingplayground.com/");

        }

        [Test]

        public void manageDelayPage()
        {
            PlayGroundHomePage hp = new PlayGroundHomePage(_driver);
            LoadDelayPage lp = new LoadDelayPage(_driver);

            string option = "Load Delay";

            hp.selectLinkOption(option);
            Assert.IsTrue(lp.getTitle().Contains(option));


        }

        [TearDown]
        
        public void tearDown ()
        {

            BaseTest.tearDown();
        }
          



    }
}
