using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QdnSeleniumDriver;

namespace First
{
   public class AutomationStart
    {

        public static void Main2(string[] args)
        {
            QDNDriver qDNDriver = new QDNDriver();

            qDNDriver.WebDriver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");

            qDNDriver.WebDriver.Manage().Window.Maximize();

            LoginPage loginPage = new LoginPage(qDNDriver.WebDriver);

            loginPage.SetUserName("Admin");
            loginPage.SetPassword("admin123");
            loginPage.Submit();

          var title = qDNDriver.WebDriver.Title;

           // if(title.e)


            //  //  IWebElement we= qDNDriver.WebDriver.FindElement(By.Name("q"));

            //  // IWebElement we = qDNDriver.WebDriver.FindElement(By.CssSelector("input[name=q]"));
            //  //     IWebElement we = qDNDriver.WebDriver.FindElement(By.XPath("//input[@name='q']"));

            //  // IWebElement we = qDNDriver.WebDriver.FindElement(By.LinkText("Images"));

            // // IWebElement we = qDNDriver.WebDriver.FindElement(By.PartialLinkText("Imag"));

            //// IWebElement we = qDNDriver.WebDriver.FindElement(By.Id("Language"));


            ////  Console.WriteLine(we.Text);

            //  qDNDriver.WebDriver.Navigate().GoToUrl("https://dotnetfiddle.net/");

            //  IWebElement we = qDNDriver.WebDriver.FindElement(By.Id("Language"));

            //  SelectElement se =   new SelectElement(we);

            //  se.SelectByValue("CSharp");



            //  //
            //  Console.WriteLine("I am on title "+ qDNDriver.WebDriver.Title);



            Console.Read();
           // qDNDriver.WebDriver.Navigate().Back();
            Console.Read();
           // qDNDriver.WebDriver.Navigate().Forward();
            Console.Read();
            // weBtn.SendKeys("Quickitdotnet");

            qDNDriver.WebDriver.Close();
            qDNDriver.WebDriver.Quit();
            
            



        }
    }
}
