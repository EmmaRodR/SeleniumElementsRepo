using MejorandoConceptos.Pages.BasePage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Tests.BaseTest
{
    public class SimpleLoginTest : BaseTest
    {

        private IWebDriver _driver;


        [SetUp]
        public void Initialize ()
        {
            _driver = BaseTest.initialize(WikiDex.Utils.Browser_Manager.DriverType.CHROME);
            _driver = BaseTest.goToUrl("http://uitestingplayground.com/sampleapp");
        }


        [Test]

        public void SimpleLogin ()
        {
            String user = "Emmanuel";
            String password ="pwd";

            SimpleLoginPage slp = new SimpleLoginPage(_driver);
            slp.SimpleLoginType(user, password);
            slp.ClickLoginButton();
            Assert.IsTrue(slp.GetLoginStatus().Contains(user));
        }


        [TearDown] 
        public void TearDown ()
        {
            BaseTest.tearDown();
        }


    }
}
