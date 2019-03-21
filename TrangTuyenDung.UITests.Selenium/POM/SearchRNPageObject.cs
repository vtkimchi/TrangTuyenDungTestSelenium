using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrangTuyenDung.UITests.Selenium.POM
{
    class SearchRNPageObject
    {
        public SearchRNPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        // find id of search all form
        [FindsBy(How = How.Id, Using = "all")]
        public IWebElement txtAll { get; set; }

        // find id of city form
        [FindsBy(How = How.Id, Using = "select2-city-container")]
        public IWebElement formCity { get; set; }

        // find Xpath for city form input
        [FindsBy(How = How.XPath, Using = "/html/body/span/span/span[1]/input")]
        public IWebElement txtCityInput { get; set; }

        // find Xpath for fac form input
        [FindsBy(How = How.XPath, Using = "/html/body/span/span/span[1]/input")]
        public IWebElement txtFacInput { get; set; }

        // find id of faculty form
        [FindsBy(How = How.Id, Using = "select2-fac-container")]
        public IWebElement formFac { get; set; }

        // find id of Tim button
        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement btnSubmit { get; set; }

        // find Xpath of result element
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/main/div/div[2]/div/div/div/div[2]/div/div/div[1]/div[3]/a/h3")]
        public IWebElement lblText { get; set; }

        // find Xpath of result element when search by City
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/main/div/div[2]/div/div/div/div[2]/div/div/div[1]/div[2]/ul[1]/li[1]/span")]
        public IWebElement lblTextCity { get; set; }

        // find Xpath of result element when result is null
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/main/div/div[2]/div/div/div/div[2]/div/div/div[1]")]
        public IWebElement lblTextError { get; set; }

        // return result
        public string getText()
        {
            return lblText.Text;
        }

        // return result when null
        public string getTextError()
        {
            return lblTextError.Text;
        }

        public string getTextCity()
        {
            return lblTextCity.Text;
        }

        public void SearchWithAll(string data)
        {
            // input data in All form
            txtAll.SendKeys(data);
            Thread.Sleep(2000);

            // click Tim button
            btnSubmit.Click();
        }

        public void SearchWithCity()
        {
            Thread.Sleep(2000);
            // click City form
            formCity.Click();
            Thread.Sleep(2000);

            //input data for City form
            txtCityInput.SendKeys("Hồ Chí Minh");
            txtCityInput.SendKeys(Keys.Enter);
            Thread.Sleep(2000);

            // click Tim button
            btnSubmit.Click();
        }

        public void SearchWithFac()
        {
            Thread.Sleep(2000);
            // click City form
            formFac.Click();
            Thread.Sleep(2000);

            //input data for City form
            txtFacInput.SendKeys("Công nghệ thông tin");
            txtFacInput.SendKeys(Keys.Enter);
            Thread.Sleep(2000);

            // click Tim button
            btnSubmit.Click();

        }

    }
}
