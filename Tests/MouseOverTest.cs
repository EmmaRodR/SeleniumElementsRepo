using MejorandoConceptos.Pages.BasePage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Tests.BaseTest
{
        public class MouseOverTest : BaseTest  {

        private IWebDriver _driver;


        [SetUp]
        public void Initialize ()
        {
            _driver = BaseTest.initialize(WikiDex.Utils.Browser_Manager.DriverType.CHROME);
            _driver = BaseTest.goToUrl("http://uitestingplayground.com/mouseover");

        }


        [Test]
        public void CheckMouseOver ()
        {
            MouseOverPage mop = new MouseOverPage(_driver);
            mop.DoubleClickLinkText();
            Assert.IsTrue(mop.GetClickCount().Equals("2"));

        }


        [TearDown]
        public void TearDown ()
        {

            BaseTest.tearDown();

        }







    }
}
