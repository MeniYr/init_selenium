using Ebay_Test.Source.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebay_Test.Tests
{
    class GetListPrud
    {
        private IWebDriver driver;
        [SetUp]
        public void init()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void sreachPruds()
        {
            driver.Url = ("https://www.ebay.com/");
            EbayStore ebay = new EbayStore(driver);

            SearchInput search = ebay.home.searchOnInput;
            Assert.IsNotNull(search);
            search.Click();
            search.Search("mouse");
            search.ApplySearch();
            
            Filter filter = search.results.filter;
            filter.min("50");
            filter.save();
           
        }

        [TearDown]
        public void cleanUp()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
