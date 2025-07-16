using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace SeleniumElements
{
   class DriverCommands
    {
        [Test]
        public void EPAM()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://www.epam.com";
            driver.Manage().Window.Maximize();
            bool Tittle = driver.Title.Contains("EPAM");
            Console.WriteLine("The tittle of the website contains :" + Tittle);
            string Tittle2 = driver.Title.Trim();
            Console.WriteLine("The tittle is trimmed as:" + Tittle2);
            int TittleLength = driver.Title.Length;
            Console.WriteLine("The Length of the Tittle is: " + TittleLength);
            driver.Quit();
        }
    }
}
