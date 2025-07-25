using System;
using Reqnroll;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ReqnrollProjectApplicationTesting.StepDefinitions
{
    [Binding]
    public class LoginSauseDemoStepDefinitions
    {
        ChromeDriver driver = new ChromeDriver();
        [Given("I navigate to Sause Demo application website")]
        public void GivenINavigateToSauseDemoApplicationWebsite()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
            driver.Manage().Window.Maximize();
            //var Swaglabs = driver.FindElement(By.XPath("//div[@class='login_logo']"));
            //Assert.Contains

        }
        //[Given("I Click on Login Option in the Home Page")]
        //public void GivenIClickOnLoginOptionInTheHomePage()
        //{

        //}
        [When("User enter the valid Username and Password")]
        public void WhenUserEnterTheValidUsernameAndPassword()
        {
            driver.FindElement(By.XPath("//input[@id='user-name']")).SendKeys("standard_user");
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("secret_sauce");
        }
        [When("User enter the Invalid Username and Password")]
        public void WhenUserEnterTheInvalidUsernameAndPassword()
        {
            driver.FindElement(By.XPath("//input[@id='user-name']")).SendKeys("user");
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("secret_sauce");
        }



        [When("User click on Login Button")]
        public void WhenUserClickOnLoginButton()
        {
            driver.FindElement(By.XPath("//input[@class='btn_action']")).Click();
        }

        [Then("User must Login successfully")]
        public void ThenUserMustLoginSuccessfully()
        {
            string actualHeader = driver.FindElement(By.XPath("//div[@class='product_label']")).Text;
            Console.WriteLine("The Title is "+ actualHeader);
            string expectedHeader = "Products";
            Assert.AreEqual(expectedHeader, actualHeader, "Login is successful.");
        }
        [Then("User must Stay in Sause Demo Login successfully")]
        public void ThenUserMustStayInSauseDemoLoginSuccessfully()
        {
            var LoginError = driver.FindElement(By.XPath("//h3[@data-test='error']"));
            Assert.True(LoginError.Displayed);
            Console.WriteLine("The User stays in Login Page due to Invalid Credentials");
        }


        [Then("User close the window")]
        public void ThenUserCloseTheWindow()
        {
            driver.Close();
            driver.Quit();
        }

        //[When("User enter the <Username> and <Password>")]
        //public void WhenUserEnterTheStandard_UserAndSecret_Sauce(string Username, string Password)
        //{
        //    throw new PendingStepException();
        //}


        //[When("User enter the standard_user and secret_sauce")]
        //public void WhenUserEnterTheStandard_UserAndSecret_Sauce()
        //{
        //    throw new PendingStepException();
        //}
        //[When("User enter the locked_out_user and secret_sauce")]
        //public void WhenUserEnterTheLocked_Out_UserAndSecret_Sauce()
        //{
        //    throw new PendingStepException();
        //}
        //[When("User enter the problem_user and secret_sauce")]
        //public void WhenUserEnterTheProblem_UserAndSecret_Sauce()
        //{
        //    throw new PendingStepException();
        //}
        //[When("User enter the performance_glitch_user and secret_sauce")]
        //public void WhenUserEnterThePerformance_Glitch_UserAndSecret_Sauce()
        //{
        //    throw new PendingStepException();
        //}

    }
}
