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
    public class OverlappedElementTest : BaseTest
    {

        private IWebDriver _driver;


        [SetUp]
        public void Initialize ()
        {
            _driver = BaseTest.initialize(WikiDex.Utils.Browser_Manager.DriverType.CHROME);
            _driver = BaseTest.goToUrl("http://www.uitestingplayground.com/overlapped");

        }


        [Test]

        public void TypeInOverlappedElement()
        {
            OverlappedElementPage oep = new OverlappedElementPage(_driver);

            oep.TypeInId("25");
            oep.ScrollToNameInput();
            oep.TypeInName("Emmanuel");
        
        }

    }
}
