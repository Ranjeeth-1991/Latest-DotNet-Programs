using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauseDemoProject.Drivers
{
    public static class DriverFactory
    {
        private static IWebDriver driver;

        public static void InitDriver()
        {
            
            var options = new ChromeOptions();
            options.AddArgument("--disable-notifications"); // Disable browser notifications
            options.AddArgument("--disable-popup-blocking"); // Suppress popups
            options.AddArgument("--disable-password-manager-reauthentication");
            //return new ChromeDriver(options);
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver(options);  // Make sure chromedriver is in PATH or NuGet package
            driver.Manage().Window.Maximize();
            //return driver;
        }

        public static IWebDriver GetDriver() => driver;

        public static void QuitDriver()
        {
            driver.Quit();
            driver = null;
        }
    }

}
