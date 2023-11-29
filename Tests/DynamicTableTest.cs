using MejorandoConceptos.Pages.BasePage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Tests.BaseTest
{
    public class DynamicTableTest : BaseTest
    {

        private IWebDriver _driver;

        [SetUp]
        public void setUp ()
        {

            _driver = BaseTest.initialize(WikiDex.Utils.Browser_Manager.DriverType.CHROME);
            _driver = BaseTest.goToUrl("http://uitestingplayground.com/dynamictable");
        }


        [Test]
        public void verifyDataRows() {

            DynamicTable dt = new DynamicTable(_driver);
            dt.GetDataRows();
            Assert.IsTrue(dt.GetDataRows().Contains(dt.getSearchedData()));
        }



        [TearDown]

        public void TearDown()
        {

            BaseTest.tearDown();
        }




    }
}
