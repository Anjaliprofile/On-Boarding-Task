using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMars.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjectMars.Pages
{
    class SignIn
    {
        public void SignInStep(IWebDriver driver)
        {
            // Enter the Url
            driver.Navigate().GoToUrl("http://192.168.99.100:5000/");

            // Maximize the window
            driver.Manage().Window.Maximize();

            // Identify Sign-In button and click
            driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();

            // Populate Login page test data collection
            ExcelLibHelpers.PopulateInCollection(@"A:\Docker\ProjectMars\TestData\TestData.xls", "Login");

            // Identify UserName and enter valid username
            driver.FindElement(By.XPath("//input[@name='email']")).SendKeys(ExcelLibHelpers.ReadData(2, "UserName"));

            // Identify Password and enter valdi password
            driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys(ExcelLibHelpers.ReadData(2, "Password"));

            // Identify Login button and click
            driver.FindElement(By.XPath("//BUTTON[text()='Login']")).Click();

            // wait for UserName to display
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

        }
    }
}
