using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauseDemoProject.Pages
{
    public class InventoryPage
    {
        private IWebDriver driver;
        public InventoryPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        //null ref exception.. thats a learning..
        public string GetPageHeader() => driver.FindElement(By.XPath("//div[@class='product_label']")).Text;
        
        public string OriginalURL() => driver.Url;
        public string ExpectedURL() => "https://www.saucedemo.com/v1/inventory.html";
        public string OriginalTitle() => driver.Title;

        public string ExpectedTitle() => "Swag Labs";

        public IWebElement BoltTShirtImage() => driver.FindElement(By.XPath("//img[@src='./img/bolt-shirt-1200x1500.jpg']"));

        public IWebElement Pricing() => driver.FindElement(By.XPath("//div[@class='inventory_details_price']"));

        public IWebElement AddToCart() => driver.FindElement(By.XPath("//button[@class='btn_primary btn_inventory']"));

        public IWebElement CartOption() => driver.FindElement(By.XPath("//a[@href='./cart.html']"));

        public IWebElement ItemExists() => driver.FindElement(By.XPath("//div[@class='inventory_item_name']"));



    }
}
