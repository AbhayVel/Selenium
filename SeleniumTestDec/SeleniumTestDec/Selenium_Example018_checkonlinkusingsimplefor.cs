using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;

namespace com.refer
{


    public class Selenium_Example018_checkonlinkusingsimplefor_TextCheck
    {

        WebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }


        [Test]
        [Order(1)]
        public void launchBrowser()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
            login();
        }


        


        [Test]
        [Order(2)]
        public void getAllLinks()
        {

            IWebElement e = driver.FindElement(By.XPath("//*[@id='resultTable']"));
            IList<IWebElement> rows = e.FindElements(By.TagName("tr"));
            for (int i = 0; i < rows.Count; i++)
            {


                IList<IWebElement> columns = rows[i].FindElements(By.TagName("td"));



                for (int j = 0; j < columns.Count; j++)
                {
                    IWebElement cell = columns[j];
                    try
                    {
                        IWebElement link = cell.FindElement(By.TagName("a"));
                        if ("Aravind".Contains(link.Text, StringComparison.OrdinalIgnoreCase))
                        {

                            link.Click();

                            i = rows.Count;
                            break;

                        }
                    }catch(Exception ex)
                    {

                    }
                   





                }

                Console.WriteLine("  ");
            }
        }






        public void login()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/index.php/admin/viewSystemUsers");

            IWebElement e = driver.FindElement(By.Id("txtUsername"));
            e.SendKeys("Admin");
            e = driver.FindElement(By.Id("txtPassword"));
            e.SendKeys("admin123");
            e = driver.FindElement(By.Name("Submit"));
            e.Click();


        }
    }



}