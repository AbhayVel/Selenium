using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.IO;

namespace FirstKeywordDrivenFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDriver aDriver = new MyDriver();
            aDriver.Driver.Manage().Window.Maximize();
            aDriver.Driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");

            LoginPage loginPage = new LoginPage(aDriver.Driver);

            loginPage.SetUserName("Admin");
            loginPage.SetPassword("admin123");
            loginPage.Submit();
        }
    }
}
