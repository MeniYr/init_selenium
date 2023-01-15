/*using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebay_Test
{
    public class Tests
    { 
        IWebDriver driver;

       // [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = ("https://www.ebay.com/");
        }

     //   [Test]
        public void Test()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement input = wait.Until(e => e.FindElement(By.Id("gh-ac")));
            input.Click();
            input.SendKeys("mouse");

            IWebElement search = wait.Until(e => e.FindElement(By.Id("gh-btn")));
            search.Click();

            IReadOnlyList<IWebElement> listProducts = driver.FindElements(By.TagName("li"));

            Assert.IsTrue(listProducts.Count() > 0);
            //*[@id="srp-river-results"]/ul/li[3]/div/div[2]/a

            foreach (IWebElement product in listProducts)
                Console.WriteLine(product);
        }

    //    [TearDown]
        public void closeBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
*/