//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
 

//namespace SeleniumElements
//{
//    public class Tests
//    {
//        IWebDriver driver;
//        [SetUp]
//        public void Setup()
//        {
//            driver = new ChromeDriver();
           
//        }

//        [Test]
//        public void Test1()
//        {
//            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
//            driver.Manage().Window.Maximize();
//            IWebElement username = driver.FindElement(By.XPath("//div[@class = 'login-box']//form//input[@type = 'text']"));
//            username.SendKeys("standard_user");
//            IWebElement password = driver.FindElement(By.XPath("//div[@class = 'login-box']//form//input[@type = 'password']"));
//            password.SendKeys("secret_sauce");
//            int milliseconds = 2000;
//            Thread.Sleep(milliseconds);
//            IWebElement clicksearchbutton = driver.FindElement(By.XPath("//div[@class = 'login-box']//form//input[@type = 'submit']"));
//            clicksearchbutton.Click();
            
//            Console.WriteLine("The Login is Successful");
//        }

//        [TearDown]
//        public void EndTest()
//        {
//            driver.Quit();
//            driver.Dispose();

//        }
//    }
//}