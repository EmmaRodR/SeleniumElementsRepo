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
    public class HomePageTests : BaseTest
    {

        private IWebDriver _driver;

        [SetUp]
        public void initialize()
        {
            _driver = BaseTest.initialize(WikiDex.Utils.Browser_Manager.DriverType.CHROME);
            _driver = BaseTest.goToUrl("http://uitestingplayground.com/");

        }

        [Test]

        public void clickOneOption () {

            PlayGroundHomePage hp = new PlayGroundHomePage(_driver);

            String searchText = "Dynamic ID";
            hp.selectLinkOption(searchText);
            Assert.IsTrue(hp.getTitle().Contains(searchText));
        }



        [TearDown] 
        public void tearDown ()
        {
            BaseTest.tearDown();
        }



    }
}
