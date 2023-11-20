using MejorandoConceptos.Pages.BasePage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Tests.BaseTest
{
    public class EspecialClickTest : BaseTest
    {

        private IWebDriver _driver;

        [SetUp] 
        public void initialize() {

            _driver = BaseTest.initialize(WikiDex.Utils.Browser_Manager.DriverType.CHROME);
            _driver = BaseTest.goToUrl("http://uitestingplayground.com/click");

        }


        [Test]

        public void clickEspecialButton()
        {
            EspecialClickPage ecp = new EspecialClickPage(_driver);
            ecp.clickEspecialButton();


        }

    }
}
