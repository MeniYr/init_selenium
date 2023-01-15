using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebay_Test.Source.pages
{
    class Results
    {
        private IWebDriver driver;
        List<string> results;
        public Filter filter;
        public Results(IWebDriver driver)
        {
            this.driver = driver;
            filter = new Filter(driver);
        }
    }
}
