﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Webdriver

{
    class ITesting
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void test()
        {
            driver.Url = "https://elp.duetbd.org/login/index.php";
            IWebElement element1 = driver.FindElement(By.XPath("//*[@id='username']"));
            element1.SendKeys("170042036");
            IWebElement element2 = driver.FindElement(By.XPath("//*[@id='password']"));
            element2.SendKeys("Abc.1234");
            IWebElement element3 = driver.FindElement(By.XPath("//*[@id='loginbtn']"));
            element3.Click();
        }
        
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}
