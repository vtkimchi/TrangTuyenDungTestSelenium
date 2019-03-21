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
    class LSPageObject
    {
        public LSPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        // ---Element of Staff page---//

        // find Xpath of title when login by staff account successful
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[3]/div/div/div/div/div[1]/div/h2")]
        public IWebElement getText { get; set; }

        // find Xpath of message when login error
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div[2]")]
        public IWebElement getTextErr { get; set; }


        // ---Element of Admin page---//

        // find Xpath of Tai khoan text
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/nav/div[2]/div[1]/div/nav/ul/li/a")]
        public IWebElement TaiKhoanClick { get; set; }

        // find Xpath of Them tai khoan text
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/nav/div[2]/div[1]/div/nav/ul/li/ul/li[2]/a")]
        public IWebElement ThemTKClick { get; set; }

        // find id of Email form
        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement Email { get; set; }

        // find id of Password form
        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }

        // find Xpath of Creat button
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[3]/div/form/div/div/div/div/div/div/div/div[4]/input")]
        public IWebElement CreateClick { get; set; }

        // find Xpath of text when create successful account 
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[3]/div/h2")]
        public IWebElement getTexCreateSuccessful { get; set; }

        // get message when login success
        public string LoginSuccessfull()
        {
            return getText.Text;
        }

        // get message when create error
        public string LoginError()
        {
            return getTextErr.Text;
        }

        // return result for create account success
        public string CreateSuccessful()
        {
            return getTexCreateSuccessful.Text;
        }

        public void LoginSuccessWithAdminAccount(string email, string pass)
        {
            // click Tai khoan text
            TaiKhoanClick.Click();
            Thread.Sleep(2000);

            // click Them tai khoan text
            ThemTKClick.Click();
            Thread.Sleep(2000);

            // input Email
            Email.SendKeys(email);
            Thread.Sleep(2000);

            // input Password
            Password.SendKeys(pass);
            Thread.Sleep(2000);

            // cleck Create
            CreateClick.Click();

        }

    }
}
