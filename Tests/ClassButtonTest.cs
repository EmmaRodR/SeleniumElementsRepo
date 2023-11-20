using MejorandoConceptos.Pages.BasePage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Tests.BaseTest
{
    public class ClassButtonTest : BaseTest
    {

        private IWebDriver _driver;

        [SetUp]

        public void initialize ()
        {
            _driver = BaseTest.initialize(WikiDex.Utils.Browser_Manager.DriverType.CHROME);
            _driver = BaseTest.goToUrl("http://uitestingplayground.com/classattr");

        }

        [Test]

        public void clickClassAttButton ()
        {
            ClassAttributePage cbtnp = new ClassAttributePage(_driver);
            cbtnp.clickClassButton();
            cbtnp.acceptPopUpAlert();
            BaseTest.refreshPage(_driver);
            cbtnp.clickClassButton();
            cbtnp.acceptPopUpAlert();


        }


        [TearDown]
        public void shutdown () {

            BaseTest.tearDown();
        }


    }
}
