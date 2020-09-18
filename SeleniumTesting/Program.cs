using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            Start(driver);
        }

        public static void Start(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://test.lovi.pl/");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.FindElement(By.XPath("//li[@class='search']")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            driver.FindElement(By.Name("search_engine")).SendKeys("butelka");

            driver.FindElement(By.XPath("//button[@class='btn-primary']")).Click();
        }

        public static void End(IWebDriver driver)
        {
            driver.Close();
        }

    }
}
