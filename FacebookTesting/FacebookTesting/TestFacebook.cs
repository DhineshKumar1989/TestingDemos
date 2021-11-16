using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FacebookTesting
{
    [TestFixture]
    class TestFacebook
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void OpenFB()
        {
            WebDriver driver = new ChromeDriver();
            driver.Url = "http://www.facebook.com";
            driver.Navigate();
            var att = driver.FindElement(By.Id("ssrb_left_rail_end")).GetAttribute("Style");
            Assert.AreEqual(att,"display:none");
        }

    }
}
