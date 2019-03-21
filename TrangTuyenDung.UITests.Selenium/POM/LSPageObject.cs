using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrangTuyenDung.UITests.Selenium
{
    class LSPageObject
    {
        public LSPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[3]/div/div/div/div/div[1]/div/h2")]
        public IWebElement getText { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div[2]")]
        public IWebElement getTextErr { get; set; }

        // Element of Admin page
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/nav/div[2]/div[1]/div/nav/ul/li/a")]
        public IWebElement TaiKhoanClick { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/nav/div[2]/div[1]/div/nav/ul/li/ul/li[2]/a")]
        public IWebElement ThemTKClick { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[3]/div/form/div/div/div/div/div/div/div/div[4]/input")]
        public IWebElement CreateClick { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[3]/div/h2")]
        public IWebElement getTexCreateSuccessful { get; set; }


        public string LoginSuccessfull()
        {
            return getText.Text;
        }

        public string LoginError()
        {
            return getTextErr.Text;
        }

        // return result for create account
        public string CreateSuccessful()
        {
            return getTexCreateSuccessful.Text;
        }

        public void LoginSuccessWithAdminAccount(string email, string pass)
        {
            TaiKhoanClick.Click();

            ThemTKClick.Click();

            Email.SendKeys(email);

            Password.SendKeys(pass);

            CreateClick.Click();

        }

    }
}
