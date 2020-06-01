using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectMars.Utilities
{
    class Sync
    {
        // Custome method to wait for visiblity of webelement
        public static void WaitForVisiblitity(IWebDriver driver, string locator, string locatorValue, int second)
        {
            try
            {
                if (locator == "Id")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, second));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));
                }
                if (locator == "XPath")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, second));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
                }
                if (locator == "CSSSelector")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, second));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(locatorValue)));
                }
            }
            catch
            {
                Assert.Fail();
            }


        }

        // Custome method to wait for Buttone/Click Action
        public static void WaitForClickAction(IWebDriver driver, string locator, string locatorValue, int second)
        {
            try
            {
                if (locator == "Id")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, second));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
                }
                if (locator == "XPath")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, second));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
                }
                if (locator == "CSSSelector")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, second));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
                }
            }
            catch
            {
                Assert.Fail();
            }
            


        }
    }
}
