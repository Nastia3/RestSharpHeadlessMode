
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [TestFixture]
    public class Class1
    {
        IWebDriver driver;
        [SetUp]
        public void beforeTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            driver = new ChromeDriver(options);
            driver.Url = "https://www.sololearn.com/";


            //driver = new ChromeDriver("C:\\webDriver");
            //driver.Url = "https://www.sololearn.com/";
            //driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void afterTest()
        {
            driver.Quit();
        }

        [Test]
        public void test1()
        {
            IWebElement button = driver.FindElement(By.XPath("//*[@id='homeHeader-v2']/div/div[1]/div/div/a[1]"));
            button.Click();

            Assert.AreEqual("https://www.sololearn.com/onboarding/0", driver.Url);
        }
    }
}