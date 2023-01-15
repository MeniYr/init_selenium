using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebay_Test.Source.pages
{
    class Filter
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        IWebElement input;
        public Filter(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void min(string val)
        {
           
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            input = wait.Until(e => e.FindElement(By.XPath("/html/body/div[8]/div[3]/ul/li[1]/ul/li[4]/div[2]/ul/li[4]/div[1]/div/div[1]/div/span/span/input")));
            input.Click();
            input.SendKeys(val);

            IWebElement apply = wait.Until(e => e.FindElement(By.XPath("/html/body/div[8]/div[3]/ul/li[1]/ul/li[4]/div[2]/ul/li[4]/div[1]/div/div[3]/button")));
            apply.Click();

        }

        public void save()
        {
            IReadOnlyList<IWebElement> listProducts = driver.FindElements(By.ClassName("s-item__price"));

            Console.WriteLine("Products how upper 5 NIS");
            foreach (IWebElement product in listProducts)
            {
                Console.WriteLine(product.Text);
            }
        }
    }
}
