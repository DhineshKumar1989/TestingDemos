using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace OrangeHRM_Specflow.Steps
{
    [Binding]
    public class OrangeHRMSteps
    {
        public IWebDriver driver = new ChromeDriver();
        [Given(@"navigate to login page")]
        public void GivenNavigateToLoginPage()
        {
            driver.Url = "https://opensource-demo.orangehrmlive.com/";
            driver.Navigate();
        }
        
        [Given(@"enter (.*) as username and (.*) as password")]
        public void GivenEnterAdminAsUsernameAndAdminAsPassword(string username, string password)
        {
            driver.FindElement(By.Id("txtUsername")).SendKeys(username);
            driver.FindElement(By.Id("txtPassword")).SendKeys(password);
        }

        [When(@"i click login")]
        public void WhenIClickLogin()
        {
            driver.FindElement(By.Id("btnLogin")).Click();
        }

        [Then(@"after successfull login the page should be dashboard")]
        public void ThenAfterSuccessfullLoginThePageShouldBeDashboard()
        {
            driver.Url.Should().Equals("https://opensource-demo.orangehrmlive.com/index.php/dashboard");
            driver.Quit();
        }

        [Then(@"the login page will show message invalid credentials")]
        public void ThenTheLoginPageWillShowMessageInvalidCredentials()
        {
            driver.FindElement(By.Id("spanMessage")).Text.Should().Equals("Invalid credentials");
            driver.Quit();
        }

        [Then(@"after successfull login")]
        public void ThenAfterSuccessfullLogin()
        {
            driver.Url.Should().Equals("https://opensource-demo.orangehrmlive.com/index.php/dashboard");
        }


        [When(@"i click on Buzz")]
        public void WhenIClickOnBuzz()
        {
            driver.FindElement(By.Id("menu_buzz_viewBuzz")).Click();
        }

        [Then(@"the page should be Buzz")]
        public void ThenThePageShouldBeBuzz()
        {
            driver.Url.Should().Equals("https://opensource-demo.orangehrmlive.com/index.php/buzz/viewBuzz");
            driver.Quit();
        }



        [When(@"i click on Leave")]
        public void WhenIClickOnLeave()
        {
            driver.FindElement(By.Id("menu_leave_viewLeaveModule")).Click();
        }

        [Then(@"the page should be Leave")]
        public void ThenThePageShouldBeLeave()
        {
            driver.Url.Should().Equals("https://opensource-demo.orangehrmlive.com/index.php/leave/viewLeaveList");
            driver.Quit();
        }


    }
}
