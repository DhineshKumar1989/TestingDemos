using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumXpathDemo
{
    public class Tests
    {
        WebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://demoqa.com/";
            driver.Navigate();
            var ele = driver.FindElement(By.XPath("//card mt-4 top-card")).Text;
            Assert.AreEqual(ele, "Forms");


        }
    }
}