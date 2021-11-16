using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GoogleTest
{
    [TestFixture]
    public class TestGmail
    {
        WebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestBrowser()
        {
            driver.Url = "http://google.com";
            //driver.Navigate();
            //Assert.Pass();
            driver.Close();
        }

        public void testGmail(string unaem, string passwod)
        {

        }
    }
}