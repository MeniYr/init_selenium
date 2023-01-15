using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebay_Test.Source.pages
{

    class EbayStore
    {
     //  private Tests initDriver;
       public Home home;
       private IWebDriver driver;
        public EbayStore(IWebDriver driver)
        {
            this.driver = driver;
            home = new Home(this.driver);
        }
    }
}
