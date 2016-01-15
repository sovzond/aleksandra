using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject3
{

    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;

        [TestMethod]
        public void LoginEror()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://192.168.11.150/sovzond_test/portal/login.aspx");
            driver.FindElement(By.Id("txtUser")).Click();
            driver.FindElement(By.Id("txtUser")).Clear();
            driver.FindElement(By.Id("txtUser")).SendKeys("guests");
            driver.FindElement(By.Id("txtPsw")).Clear();
            driver.FindElement(By.Id("txtPsw")).SendKeys("adew");
            driver.FindElement(By.Id("cmdLogin")).Click();
            if ("http://192.168.11.150/sovzond_test/portal/default.aspx")
        }
        public void LoginIR()
        
           {
            driver.FindElement(By.Id("txtUser")).Clear();
            driver.FindElement(By.Id("txtUser")).SendKeys("guest");
            driver.FindElement(By.Id("txtPsw")).Clear();
            driver.FindElement(By.Id("txtPsw")).SendKeys("guest");
            driver.FindElement(By.Id("cmdLogin")).Click();
            if (driver.Navigate().GoToUrl ("http://192.168.11.150/sovzond_test/portal/default.aspx")
        }
        
    



    }

}
