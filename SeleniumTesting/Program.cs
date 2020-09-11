using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://test.lovi.pl/");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.FindElement(By.XPath("//li[@class='search']")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            driver.FindElement(By.Name("search_engine")).SendKeys("butelka");

            driver.FindElement(By.XPath("//button[@class='btn-primary']")).Click();
        }
    }
}
