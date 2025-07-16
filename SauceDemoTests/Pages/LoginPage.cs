//using OpenQA.Selenium;
//using OpenQA.Selenium.BiDi.Modules.BrowsingContext;
//using static System.Net.Mime.MediaTypeNames;

//namespace SauceDemoTests.Pages
//{
//    public class LoginPage
//    {
//        private IWebDriver driver; //It is an interface to connect chrome driver

//        public LoginPage(IWebDriver driver) //It is class for login page
//        {
//            this.driver = driver; //defining constructor
//        }

//        public By UserNameLocator = By.Id("user-name");

//        //Below are defining the elements to access
//        private IWebElement Username => GetElement(UserNameLocator);
//        //Method used to find the element in browser as User name
//        private IWebElement Password => driver.FindElement(By.Id("password"));
//        //Method used to find the element in browser as Password
//        private IWebElement LoginButton => driver.FindElement(By.Id("login-button"));
//        //Below defining the values to enter the details as per the test steps
//        public void EnterUsername(string username) => EnterText(UserNameLocator,username);
//        //Method used to enter values to the above fields
//        public void EnterPassword(string password) => EnterText(Password,password);
//        //Method used to enter values to the above fields.
//        public void ClickLogin() => LoginButton.Click();
//        //Method used to click the login button.
//        public IWebElement GetElement(By locator)
//        {
//            return driver.FindElement(locator);
//        }

//        public void EnterText(By locator, string text)
//        {
//            Console.WriteLine($"Entering text '{text}' int to - {locator.Criteria}");
//            IWebElement element = GetElement(locator);
//            element.Clear();
//            element.SendKeys(text);
//        }

//        public void EnterText(IWebElement element,string text)
//        {
//            Console.WriteLine($"Entering text '{text}'");
//            element.Clear();
//            element.SendKeys(text);
//        }

//        public void LoginAs(string username, string password) //LoginAs is a class to enter the details
//        {
//            EnterUsername(username); //Parameters to be passed.
//            EnterPassword(password);
//            ClickLogin();
//        }
//    }
//}
