using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebay_Test.Source.pages
{
    class Home
    {
        public SearchInput searchOnInput;
        public Home(IWebDriver driver)
        {
          searchOnInput = new SearchInput(driver);
        }
    }
}
