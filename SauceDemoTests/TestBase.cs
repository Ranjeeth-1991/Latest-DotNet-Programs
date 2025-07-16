//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using SauceDemoTests.Pages;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SauceDemoTests
//{
//    public class TestBase
//    {
//       public IWebDriver driver;
//        [SetUp]
//        public void Setup()
//        {
//            Console.WriteLine("Initilizing Driver");
//            driver = new ChromeDriver();
//            driver.Manage().Window.Maximize();
//            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
//        }

//        [TearDown]
//        public void TearDown()
//        {
//            Console.WriteLine("Disposing Driver");
//            driver.Quit();
//            driver.Dispose();
//        }
//    }
//}
