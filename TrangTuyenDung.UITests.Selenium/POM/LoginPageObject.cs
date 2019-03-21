using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrangTuyenDung.UITests.Selenium
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        // find Xpath of Dang Nhap button in home page
        [FindsBy(How = How.XPath, Using = "/html/body/header/div[1]/div/div[2]/div/nav/ul/li[4]/a/button")]
        public IWebElement btnLogin { get; set; }

        // find Xpath of Dang Nhap Ngay button
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div/div[2]/form/div[4]/a/button")]
        public IWebElement btnInput { get; set; }

        // find id of Email form
        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement txtUsername { get; set; }

        // find id of Password form
        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        // find id of Dang Nhap button
        [FindsBy(How = How.Id, Using = "button-1")]
        public IWebElement btnSubmit { get; set; }

        
        public void FileLoginForm(string email, string password)
        {
            //SeleniumSetMethod.Click(btnInput);
            //SeleniumSetMethod.EnterText(txtUsername, email);
            //SeleniumSetMethod.EnterText(txtPassword, password);
            //SeleniumSetMethod.Click(btnLogin);

            // click Dang Nhap button in home page
            btnLogin.Click();
            Thread.Sleep(2000);

            // click Dang Nhap Ngay button
            btnInput.Click();
            Thread.Sleep(2000);

            // input data in Email form
            txtUsername.SendKeys(email);
            Thread.Sleep(2000);

            // input data in Password form
            txtPassword.SendKeys(password);
            Thread.Sleep(2000);

            // click Dang Nhap button
            btnSubmit.Click();

            //return new LSPageObject();
        }
    }
}
