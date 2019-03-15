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


        public string LoginSuccessfull()
        {
            return getText.Text;
        }

        public string LoginError()
        {
            return getTextErr.Text;
        }

    }
}
