using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebay_Test.Source.pages
{
    class SearchInput
    {
        public Results results;
        private IWebDriver driver;
        private WebDriverWait wait;
        private IWebElement input;
        public SearchInput(IWebDriver driver)
        {
            this.driver = driver;
            results = new Results(driver);

        }
        public void Click()
        {
        
            wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(20));
            input = driver.FindElement(By.Id("gh-ac"));
            input.Click();
        }
        public void Search(string value)
        {
            input.SendKeys(value);
            
        }

        public void ApplySearch()
        {
            wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(5));
            input = wait.Until(e => e.FindElement(By.Id("gh-btn")));
            input.Click();
        }


    }
}
