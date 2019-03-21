using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrangTuyenDung.UITests.Selenium.POM
{
    class ViewDetailPageObject
    {
        public ViewDetailPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        // find Xpath of Title of recruitment news
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/section[2]/div/div/div[1]/div[2]/div/div[1]/div/div[2]/a[1]/h3")]
        public IWebElement lblTitle { get; set; }

        // find Xpath of Ung tuyen button when view detail success
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div[1]/div/div/div[2]/a/button")]
        public IWebElement lblResult { get; set; }

        // result
        public string viewSuccessful()
        {
            return lblResult.Text;
        }

        public void clickTitle()
        {
            lblTitle.Click();
        }

    }
}
