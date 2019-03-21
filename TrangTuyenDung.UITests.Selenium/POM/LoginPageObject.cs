using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrangTuyenDung.UITests.Selenium
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div/div[2]/form/div[4]/a/button")]
        public IWebElement btnInput { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement txtUsername { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "button-1")]
        public IWebElement btnLogin { get; set; }

        public void FileLoginForm(string email, string password)
        {
            //SeleniumSetMethod.Click(btnInput);
            //SeleniumSetMethod.EnterText(txtUsername, email);
            //SeleniumSetMethod.EnterText(txtPassword, password);
            //SeleniumSetMethod.Click(btnLogin);

            btnInput.Click();
            txtUsername.SendKeys(email);
            txtPassword.SendKeys(password);
            btnLogin.Click();

            //return new LSPageObject();
        }
    }
}
