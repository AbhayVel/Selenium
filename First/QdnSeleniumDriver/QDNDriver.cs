using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

using System;
using System.Collections.Generic;
using System.Text;

namespace QdnSeleniumDriver
{
    public class QDNDriver  
    {
      public  WebDriver WebDriver = new ChromeDriver();

        public QDNDriver()
        {
            //var options = new EdgeOptions();
            ////options.Use = true;
            //webDriver = new EdgeDriver(options);
        }
    }
}
