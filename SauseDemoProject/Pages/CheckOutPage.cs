using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauseDemoProject.Pages
{
    public class CheckOutPage
    {
        private IWebDriver driver;
        public CheckOutPage(IWebDriver _driver)
        {
            driver = _driver;
        }


        public IWebElement FirstName() => driver.FindElement(By.XPath("//input[@id='first-name']"));

        public IWebElement LastName() => driver.FindElement(By.XPath("//input[@id='last-name']"));

        public IWebElement ZipCode() => driver.FindElement(By.XPath("//input[@id='postal-code']"));

        public IWebElement ContinueButton() => driver.FindElement(By.XPath("//input[@value='CONTINUE']"));

        public string CheckOutPageActualHeader() => driver.FindElement(By.XPath("//div[@class='subheader']")).Text;

        public IWebElement FinishButton() => driver.FindElement(By.XPath("//a[@class ='btn_action cart_button']"));

    }
}
