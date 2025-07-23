using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Reqnroll;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Emit;
using SauseDemoProject.Pages;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Imaging;
using SauseDemoProject.Drivers;

namespace SauseDemoProject.StepDefinitions
{
   
    [Binding]
    public class LoginToOrderPlacementStepDefinitions
    {
               
        IWebDriver driver;
        string BaseURL = "https://www.saucedemo.com/v1/index.html";
        LoginPage login;
        InventoryPage inventory;
        CartPage cart;
        CheckOutPage checkOut;
         
        public  LoginToOrderPlacementStepDefinitions()
        {
            driver = DriverFactory.GetDriver();
            login = new LoginPage(driver);
            inventory = new InventoryPage(driver);
            cart = new CartPage(driver);
            checkOut = new CheckOutPage(driver);
            
        }
        //Login Page
        [Given("User Login to Sauce Demo Login Page.")]
        public void GivenUserLoginToSauceDemoLoginPage_()
        {            
            GotoHomePage(BaseURL);
            MaximizethePage(BaseURL);
            Console.WriteLine($"The Login URL is: {BaseURL}");

        }

        [When("User Enter the User Name in Login Page.")]
        public void WhenUserEnterTheUserNameInLoginPage_()
        {
            
            login.EnterUsername("standard_user");
        }

        [When("User Enter the Password in Login Page.")]
        public void WhenUserEnterThePasswordInLoginPage_()
        {
            
            login.EnterPassword("secret_sauce");
        }

        [When("User Click on the Login Button.")]
        public void WhenUserClickOnTheLoginButton_()
        {
            
            login.ClickLoginButton();
         // Take screenshot after clicking the login button    
        }
        //Inventory Page
        [Then("User Should Login to Sauce Demo Application.")]
        public void ThenUserShouldLoginToSauceDemoApplication_()
        {
            string expectedHeader = "Products";
            var actualHeader = inventory.GetPageHeader();
            Assert.AreEqual(expectedHeader, actualHeader,$"Actual Header : {actualHeader}, Expected Header : {expectedHeader}");
            //Assert.That(driver.Url, Does.Contain("inventory"));
            Console.WriteLine("The Application Logged in and opened Inventory Page");
        }
        [When("User is in Inventory Page.")]
        public void GivenUserIsInInventoryPage_()
        {
            var OriginalURL = inventory.OriginalURL();
            var ExpectedURL = inventory.ExpectedURL();
            var OriginalTitle = inventory.OriginalTitle();
            var ExpectedTitle = inventory.ExpectedTitle();
            if (OriginalURL == ExpectedURL && OriginalTitle == ExpectedTitle)
            {
                Console.WriteLine($"The Browser is in correct page {ExpectedURL}");
                Console.WriteLine($"The Tittle is showing correct page {ExpectedTitle}");
            }
            else
            {
                Console.WriteLine($"The Broser is in Incorrect Page");
            }

        }

        [When("User Click on Add to Cart for Sauce Labs Bolt T-Shirt.")]
        public void WhenUserClickOnAddToCartForSauceLabsBoltT_Shirt_()
        {
            var BoltTShirtImage = inventory.BoltTShirtImage();
            BoltTShirtImage.Click();

            var Pricing = inventory.Pricing();

            if (Pricing != null)
            {
                Console.WriteLine("The Pricing is mentioned");
            }
            else
            {
                Console.WriteLine("This Shirt has no Price");
            }
            var AddToCart = inventory.AddToCart();
            if (AddToCart != null)
            {
                Console.WriteLine("The Add to Cart Button is Available");
            }
            else
            {
                Console.WriteLine("The Add to Cart Button is Missing");
            }
           
            AddToCart.Click();
            
        }

        [When("User Click on Cart Option.")]
        public void WhenUserClickOnCartOption_()
        {
            var CartOption = inventory.CartOption();
            CartOption.Click();
            var ItemExists = inventory.ItemExists();
            if (ItemExists != null)
            {
                Console.WriteLine("Item Exists in the Cart");
            }
            else
            {
                Console.WriteLine("No item Available in the Cart");
            }
        }
        //Cart Page
        [When("User Click on Checkout Button.")]
        public void WhenUserClickOnCheckoutButton_()
        {
            string CurrentPageSubheader = "Your Cart";
            string IsinCartPage = cart.IsinCartPage();
            Assert.AreEqual(CurrentPageSubheader, IsinCartPage, $"Current Page is : {IsinCartPage}");
            Console.WriteLine("We are in Cart Page only and can place order.");
            var CheckOutButton = cart.CheckOutButton();
            CheckOutButton.Click();            
        }
        //CheckOut Page
        [When("User enter First Name Last Name and Zip Code.")]
        public void WhenUserEnterFirstNameLastNameAndZipCode_()
        {
            
            var FirstNameEntered = checkOut.FirstName();
            FirstNameEntered.SendKeys("First User");
                     
            var LastNameEntered = checkOut.LastName();
            LastNameEntered.SendKeys("Last User");
            
            var ZipCodeEntered = checkOut.ZipCode();
            ZipCodeEntered.SendKeys("500036");
            
            if (FirstNameEntered != null && LastNameEntered != null && ZipCodeEntered != null)
            {
                string firstNameValue = FirstNameEntered.GetAttribute("value");
                string lastNameValue = LastNameEntered.GetAttribute("value");
                string zipCodeValue = ZipCodeEntered.GetAttribute("value");
                Console.WriteLine($"The First Name Entered is {firstNameValue}");
                Console.WriteLine($"The Last Name Entered is {lastNameValue}");
                Console.WriteLine($"The Zip Code Enterd is {zipCodeValue}");
            }
            else
            {
                Console.WriteLine("The Customer Details are not given");
            }

        }

        [When("User Click on Continue Button.")]
        public void WhenUserClickOnContinueButton_()
        {
            var ContinueButton = checkOut.ContinueButton();
            
            if (ContinueButton != null)
            {
                ContinueButton.Click();
            }
            else
            {
                Console.WriteLine("The Continue Button is missing");
            }
        }

        [When("User Click on Finish Button.")]
        public void WhenUserClickOnFinishButton_()
        {
            string CheckoutPageSubheader = "Checkout: Overview";
            string CheckOutPageActualHeader = checkOut.CheckOutPageActualHeader();
            Assert.AreEqual(CheckoutPageSubheader, CheckOutPageActualHeader, $"Current Page is : {CheckOutPageActualHeader}");

            var FinishButton = checkOut.FinishButton();

            if (FinishButton != null)
            {
                FinishButton.Click();
            }
            else
            {
                Console.WriteLine("The Finish Button is missing");
            }
        }

        [Then("the Order is placed successfully.")]
        public void ThenTheOrderIsPlacedSuccessfully_()
        {
            string OriginalURL = driver.Url;
            string ExpectedURL = "https://www.saucedemo.com/v1/checkout-complete.html";
            if (OriginalURL == ExpectedURL)
            {
                Console.WriteLine("The Order is finished successfully");
            }
            else
            {
                Console.WriteLine("There is an issue in placing the Order");
            }
        }

       public void GotoHomePage(string url) => driver.Navigate().GoToUrl(url);
        public void MaximizethePage(string BaseURl) => driver.Manage().Window.Maximize();
        

    }

}
