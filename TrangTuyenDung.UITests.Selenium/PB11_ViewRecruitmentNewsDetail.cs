using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TrangTuyenDung.UITests.Selenium.POM;

namespace TrangTuyenDung.UITests.Selenium
{
    class PB11_ViewRecruitmentNewsDetail
    {
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new FirefoxDriver();

            //PropertiesCollection.driver.Navigate().GoToUrl("http://localhost:49925/Account/Login");
            PropertiesCollection.driver.Navigate().GoToUrl("http://cntttest.vanlanguni.edu.vn:18080/EJob/");
        }

        [Test]
        public void ViewRecruitmentDetail_WithViewSuccessful()
        {
            IJavaScriptExecutor je = (IJavaScriptExecutor)PropertiesCollection.driver;
            je.ExecuteScript("window.scrollBy(0,700)");

            Thread.Sleep(4000);

            ViewDetailPageObject vdpo = new ViewDetailPageObject();

            vdpo.clickTitle();
            // expected result
            var expectedResult = "Ứng tuyển";

            Assert.AreEqual(expectedResult.ToLower(), vdpo.viewSuccessful().ToLower());

        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
        }

    }
}
