using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDrivers
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver driver;
        [AssemblyInitialize]
        public static void SetUpWeb(TestContext context)
        {
            driver = new ChromeDriver(@"D:\Files\University\4_Year\Software_testing\Laboratory_works\Lab2\WebDrivers\WebDrivers\bin\Debug\");
            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("http://github.com");
            driver.FindElement(By.LinkText("Sign in")).Click();
            driver.FindElement(By.Id("login_field")).SendKeys("hillo");
            driver.FindElement(By.Id("password")).SendKeys("sometime");
            driver.FindElement(By.Name("commit")).Click();
        }
    }
}
