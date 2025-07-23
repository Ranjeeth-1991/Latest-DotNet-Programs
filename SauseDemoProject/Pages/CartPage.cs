using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauseDemoProject.Pages
{
    public class CartPage
    {
        private IWebDriver driver;
        public CartPage(IWebDriver _driver)
        {
            driver = _driver;
        }
        public string IsinCartPage() => driver.FindElement(By.XPath("//div[@class='subheader']")).Text;

        public IWebElement CheckOutButton() => driver.FindElement(By.XPath("//a[@class='btn_action checkout_button']"));
    }
}
