using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauseDemoProject.Pages
{
    public class LoginPage
    {
        //IWebDriver driver = new ChromeDriver();
        //string BaseURL = "https://www.saucedemo.com/v1/index.html";
        private IWebDriver driver;
       
        public LoginPage(IWebDriver _driver)
        {         
            driver = _driver;
        }
            
          // driver.Navigate().GoToUrl(BaseURL);
        
   
        private IWebElement Username => driver.FindElement(By.Id("user-name"));  
        private IWebElement Password => driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => driver.FindElement(By.Id("login-button"));
        public void EnterUsername(string username) => EnterText(Username, username);
        public void EnterPassword(string password) => EnterText(Password, password);

        public void ClickLoginButton() => LoginButton.Click();

        //This Class is to access the locators in the loginpage
        public IWebElement GetElement (By locator)
        {
            return driver.FindElement(locator);
        }

        public void EnterText (IWebElement element, string text)
        {
            Console.WriteLine($"The Element which need to be added: {text}");
            element.Clear();
            element.SendKeys(text);
        }

        public void LoginDetails(string username, string password)
        {
            Console.WriteLine($"The Login Credentials entered are Username is {username} and Password is {password}");
            EnterUsername(username);
            EnterPassword(password);
            ClickLoginButton();
        }


        

        
    }
}
