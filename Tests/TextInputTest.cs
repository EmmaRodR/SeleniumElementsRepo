using MejorandoConceptos.Pages.BasePage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejorandoConceptos.Tests.BaseTest
{
    public class TextInputTest: BaseTest
    {

        private IWebDriver _driver;



        [SetUp]

        public void initialize()
        {

            _driver = BaseTest.initialize(WikiDex.Utils.Browser_Manager.DriverType.CHROME);
            _driver = BaseTest.goToUrl("http://uitestingplayground.com/textinput");


        }


        [Test]

        public void typeText ()
        {
            TextInputPage tip = new TextInputPage(_driver);

            String typeText = ("Emmanuel");

            tip.typeTextField(typeText);
            tip.clickButton();
            Assert.IsTrue(tip.getButtonText().Equals(typeText));
        
        }
        
        
        [TearDown]
        
        public void tearDown ()
        {
            BaseTest.tearDown();

        }

        


    }
}
