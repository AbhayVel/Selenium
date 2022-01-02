using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstKeywordDrivenFramework
{
    class MyDriver
    {
        public WebDriver Driver;

        public IWebElement GetWebElement(TestCases testCases)
        {
            if ("id".Equals(testCases.LocatorType, StringComparison.OrdinalIgnoreCase))
            {
                IWebElement webElement = Driver.FindElement(By.Id(testCases.LocatorTypeValue));
                return webElement;
            }

            if ("xpath".Equals(testCases.LocatorType, StringComparison.OrdinalIgnoreCase))
            {
                IWebElement webElement = Driver.FindElement(By.XPath(testCases.LocatorTypeValue));
                return webElement;
            }

            if ("name".Equals(testCases.LocatorType, StringComparison.OrdinalIgnoreCase))
            {
                IWebElement webElement = Driver.FindElement(By.Name(testCases.LocatorTypeValue));
                return webElement;
            }

            if ("ClassName".Equals(testCases.LocatorType, StringComparison.OrdinalIgnoreCase))
            {
                IWebElement webElement = Driver.FindElement(By.ClassName(testCases.LocatorTypeValue));
                return webElement;
            }

            if ("CssSelector".Equals(testCases.LocatorType, StringComparison.OrdinalIgnoreCase))
            {
                IWebElement webElement = Driver.FindElement(By.CssSelector(testCases.LocatorTypeValue));
                return webElement;
            }
            return null;
        }

        public void Exceute(TestCases testCases)
        {

            if ("openbrowser".Equals(testCases.Action, StringComparison.OrdinalIgnoreCase))
            {
                Driver = new ChromeDriver();
            } else if("enterurl".Equals(testCases.Action, StringComparison.OrdinalIgnoreCase))
            {
                Driver.Navigate().GoToUrl(testCases.Value);
            } else if ("sendkeys".Equals(testCases.Action, StringComparison.OrdinalIgnoreCase))
            {
             IWebElement webElement=   GetWebElement(testCases);
                if (webElement != null)
                {
                    webElement.Clear();
                    webElement.SendKeys(testCases.Value);
                }
            }
            else if ("click".Equals(testCases.Action, StringComparison.OrdinalIgnoreCase))
            {
                IWebElement webElement = GetWebElement(testCases);
                if (webElement != null)
                {

                    webElement.Click();
                }
            }
            else if ("selectdropdown".Equals(testCases.Action, StringComparison.OrdinalIgnoreCase))
            {
                IWebElement webElement = GetWebElement(testCases);
                if (webElement != null)
                {

                    webElement.Click();
                }
            }
        }
    }
}
