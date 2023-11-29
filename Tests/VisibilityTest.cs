using MejorandoConceptos.Pages.BasePage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Tests.BaseTest
{
    public class VisibilityTest : BaseTest
    {
        private IWebDriver _driver;




        [SetUp]
        public void Initialize ()
        {
            _driver = BaseTest.initialize(WikiDex.Utils.Browser_Manager.DriverType.CHROME);
            _driver = BaseTest.goToUrl("http://uitestingplayground.com/visibility");

        }

        [Test]

        public void ElementsAreVisible ()
        {
            VisibilityPage vp = new VisibilityPage(_driver);
            vp.RemovedIsVisible();
            vp.OverlappedIsVisible();
            vp.ZeroOpacityIsVisible();
            vp.ZeroWidthButtonIsVisible();
            vp.NotDisplatedButtonIsVisible();
            vp.OffscreenButtonIsVisible ();
            vp.InvisibleButtonIsVisible ();
            
        }


            [TearDown]
            
            public void TearDown () {

            BaseTest.tearDown();
        }


    }
}
