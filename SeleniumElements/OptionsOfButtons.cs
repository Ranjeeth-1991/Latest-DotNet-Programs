using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SeleniumElements
{
    public class OptionsOfButtons
    {
        IWebDriver driver;
        string baseURL = "https://qa-automation-practice.netlify.app";
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Maximize();
        }

        #region commented
        //[Test]
        //public void Login()
        //{
        //    driver.Navigate().GoToUrl("https://qa-automation-practice.netlify.app/");
        //    driver.Manage().Window.Maximize();
        //    IWebElement forms = driver.FindElement(By.XPath("//a[@id='forms']"));
        //    forms.Click();
        //    IWebElement login = driver.FindElement(By.XPath("//ul[@id='homeSubmenu']//li/a[@id='login']"));
        //    login.Click();
        //    int milliseconds = 2000;
        //    Thread.Sleep(milliseconds);
        //    IWebElement EmailAddress = driver.FindElement(By.XPath("//div[@class='form-group']//input[@type='email']"));
        //    EmailAddress.SendKeys("admin@admin.com");
        //    int milliseconds1 = 1000;
        //    Thread.Sleep(milliseconds1);
        //    IWebElement Password = driver.FindElement(By.XPath("//div[@class='form-group']//input[@type='password']"));
        //    Password.SendKeys("admin123");
        //    IWebElement Submit = driver.FindElement(By.XPath("//div//button[@id='submitLoginBtn']"));
        //    Submit.Click();
        //    IWebElement successlogin = driver.FindElement(By.XPath("//div[@class='alert alert-success']"));
        //    Console.WriteLine("The Login is successful");
        //}
        //[Test]
        //public void Buttons()
        //{
        //    driver.Navigate().GoToUrl("https://qa-automation-practice.netlify.app/");
        //    driver.Manage().Window.Maximize();

        //    var select = new SelectElement(driver.FindElement(By.XPath("//a[@href='/dropdowns']")));
        //    // By value attribute
        //    select.SelectByValue("India");
        //    //IWebElement Action = driver.FindElement(By.XPath("//a[@href='/dropdowns']"));
        //    //Action.Click();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);      // Element timeout
        //    //driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(20); // JavaScript timeout
        //    //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);         // Page load timeout
        //    IWebElement dropdown = driver.FindElement(By.Id("dropdown-menu"));
        //    ReadOnlyCollection<IWebElement> listItems = driver.FindElements(By.XPath("//option"));
        //    IWebElement CountryName = listItems.FirstOrDefault(x => x.Text == "India");
        //    CountryName.Click();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    //SelectElement Element = new SelectElement(dropdown);
        //    //IWebElement NewBrowser = driver.FindElement(By.XPath("//a[@href='/tab']"));
        //    //NewBrowser.Click();

        //    //IWebElement ShowHideButton = driver.FindElement(By.XPath("//button[@id='showHideBtn']"));
        //    //ShowHideButton.Click();
        //    //Console.WriteLine("The Text is Hidded");
        //    ////Actions actions = new Actions(driver);
        //    ////actions.MoveToElement(MouseHovering).Perform();
        //    ////IWebElement NewTabFinal = driver.FindElement(By.XPath("//a[@id='tables']"));
        //    ////NewTabFinal.Click();
        //    //int milliseconds21 = 2000;
        //    //Thread.Sleep(milliseconds21);
        //    //driver.Navigate().Back();
        //    //int milliseconds23 = 2000;
        //    //Thread.Sleep(milliseconds23);
        //    //driver.Navigate().Forward();
        //    //ShowHideButton.Click();
        //    //int milliseconds22 = 2000;
        //    //Thread.Sleep(milliseconds22);
        //    //Console.WriteLine("The Text is shown");
        //}
        #endregion


        //[Test]
        //public void VerifyCountryDropdownOptionWorksFine()
        //{
        //    //Arrange
        //    var dropDownlocator = $"//button[@id='multi-level-dropdown-btn']";
        //    var SubDropdown = $"//ul[@id='multi-level-menu-ul']";
        //    var SomeAction = $"//a[@href='#some-action']";
        //    var Valuevisible = $"//a[@href =contains(text(), 'Some action')]";
        //    //Act
        //    SelectMenuItem("dropdowns");
        //    SelectFromDropdown(driver, By.XPath(dropDownlocator),By.XPath(SubDropdown), By.XPath(SomeAction));
        //    var selectedText = driver.FindElement(By.XPath(SubDropdown)).GetAttribute("value")?.ToString();
        //    var className = driver.FindElement(By.XPath(dropDownlocator)).GetAttribute("className")?.ToString();
        //    Console.WriteLine(className);

        //    Console.WriteLine(selectedText);
        //    //Assert
        //    //Assert.AreEqual("Some action", Valuevisible.Text, "'Some action' dropdown option text should match.");
        //}

        //private void SelectFromDropdown(IWebDriver driver, By dropdownLocator, By SubDropdown, By SomeAction)
        //{
        //    var dropdownElement = driver.FindElement(dropdownLocator);
        //    dropdownElement.Click();
        //    var SubDropdownScreen = driver.FindElement(SubDropdown);
        //    var SomeActionOption = driver.FindElement(SomeAction);
        //    SomeActionOption.Click();

        //    //var select = new SelectElement(dropdownElement);
        //    //select.SelectByText(Value);
        //}

        //private void SelectMenuItem(string menuText)
        //{
        //    driver.FindElement(By.XPath($"//a[contains(@href,'{menuText}')]")).Click();
        //}

        [Test]
        public void VerifyAlerts()
        {
            //Alert
            var AlertButton = driver.FindElement(By.XPath("//a[@href ='/alerts']"));
            AlertButton.Click();
            var InternalAlertButton = driver.FindElement(By.XPath("//button[@id ='confirm-btn']"));
            InternalAlertButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IAlert SimpleAlert = driver.SwitchTo().Alert();
            string AlertText = SimpleAlert.Text;
            Console.WriteLine("The Alert is seen here is:" + AlertText);
            SimpleAlert.Dismiss();
            Actions act = new Actions(driver);
            act.


        }

        

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }

    }
}
