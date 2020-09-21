using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTesting
{
    [TestFixture]
    [Parallelizable]
    //[Ignore("Skip this tests")]
    public class NUnitTests
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void SetUpTests()
        {
            driver.Manage().Window.Maximize();
            WaitThree(driver);
        }

        [Test]
        public void FirstTest()
        {
            driver.Navigate().GoToUrl("https://www.ivoclarvivadent.pl/pl/");
            WaitThree(driver);

            driver.FindElement(By.XPath("//b[@class='icon-lupe header-search-item-icon']")).Click();
            WaitThree(driver);

            driver.FindElement(By.Name("q")).SendKeys("zęby" + Keys.Enter);
        }

        [TearDown]
        public void EndsTests()
        {
            driver.Quit();
        }

        public static void WaitThree(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

    }
}
