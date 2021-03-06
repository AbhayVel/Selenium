using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace First
{
    public class LoginPage
    {

        private string _userNameIdSelector = "txtUsername";
        private string _passwordIdSelector = "txtPassword";
        private string _loginButtonIdSelector = "btnLogin";
        private string _loginSpanMessageIdSelector = "spanMessage";


        public IWebElement UserName { get; set; }

        public IWebElement Password { get; set; }

        public IWebElement LoginButton { get; set; }

        public IWebElement Message { get; set; }


        public LoginPage(WebDriver driver)
        {
            this.UserName = driver.FindElement(By.Id(_userNameIdSelector));
            Password = driver.FindElement(By.Id(_passwordIdSelector));
            LoginButton = driver.FindElement(By.Id(_loginButtonIdSelector));           
        }


       public void SetUserName(string userName)
        {
            this.UserName.Clear();
            this.UserName.SendKeys(userName);
        }


        public void SetPassword(string password)
        {
            this.Password.Clear();
            this.Password.SendKeys(password);
        }

        public void Submit()
        {
            this.LoginButton.Click();
        }


        public string GetMessage(WebDriver driver)
        {
            Message = driver.FindElement(By.Id(_loginSpanMessageIdSelector));
            return Message.Text;
        }




    }
}
