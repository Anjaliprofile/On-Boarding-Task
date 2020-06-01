using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace ProjectMars.Utilities
{
    class GlobalDriver
    {
        // initialize webdriver globally
        public static IWebDriver driver { set; get; }

        
    }
}

