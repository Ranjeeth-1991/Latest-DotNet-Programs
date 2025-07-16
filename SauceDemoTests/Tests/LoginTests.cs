//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using SauceDemoTests.Pages;

//namespace SauceDemoTests
//{
//    public class LoginTests : TestBase
//    {
//        private LoginPage loginPage;

//        public LoginTests()
//        {
//        }

//        [SetUp]
//        public void LocalSetup()
//        {
//            Console.WriteLine("Inside Local Setup");
//            loginPage = new LoginPage(driver);
//        }

//        [Test(Description ="Its my login test for sauce lab demo")]
//        public void ValidLoginTest()
//        {
//            Console.WriteLine("Inside Test - ValidLoginTest");
//            loginPage.LoginAs("standard_user", "secret_sauce");
//            Assert.That(driver.Url, Does.Contain("inventory.html"));
//        }

//        [Test]
//        public void ValidLoginTes1t()
//        {
//            Console.WriteLine("Inside Test - ValidLoginTest1");
//            loginPage.LoginAs("standard_user", "secret_sauce");
//            Assert.That(driver.Url, Does.Contain("inventory.html"));
//        }

//        public void Greet()
//        {
//            Console.WriteLine("Its good evening");
//        }
//    }
//    public class InvalidLoginTests
//    {
//        private IWebDriver driver;
//        private LoginPage loginPage;

//        [SetUp]
//        public void Setup()
//        {
//            driver = new ChromeDriver();
//            driver.Manage().Window.Maximize();
//            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
//            loginPage = new LoginPage(driver);
//        }

//        [Test]
//        public void InvalidLoginTest()
//        {
//            loginPage.LoginAs("Testing_user", "secret_sauce");
//            Assert.That(driver.Url, Does.Contain("inventory.html"));
//        }

//        [Test]
//        public void ValidLoginTest()
//        {
//            loginPage.LoginAs("standard_user", "secret_sauce");
//            Assert.That(driver.Url, Does.Contain("inventory.html"));
//        }

//        [TearDown]
//        public void TearDown()
//        {
//            driver.Quit();
//            driver.Dispose();
//        }
//    }
//}
