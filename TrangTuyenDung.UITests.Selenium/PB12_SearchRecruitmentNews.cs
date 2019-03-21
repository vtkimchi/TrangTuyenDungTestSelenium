using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrangTuyenDung.UITests.Selenium.POM;

namespace TrangTuyenDung.UITests.Selenium
{
    class PB12_SearchRecruitmentNews
    {
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new FirefoxDriver();

            //PropertiesCollection.driver.Navigate().GoToUrl("http://localhost:49925/Account/Login");
            PropertiesCollection.driver.Navigate().GoToUrl("http://cntttest.vanlanguni.edu.vn:18080/EJob/");

            // read file test data
            ExcelLib.PopulateInCollection("D:/K21T2-CAP/Project/Source code/TrangTuyenDung.UITests.Selenium/TestData.xlsx", "PB12_SearchRN");
        }

        [Test]
        public void SearchRecruitmentNews_WithInputFreeData()
        {
            // create Search recruitment news page object
            SearchRNPageObject searchPage = new SearchRNPageObject();

            // search reacruitment news to application
            searchPage.SearchWithAll(ExcelLib.ReadData(1, "Test Data"));

            try
            {
                // expected result
                var expectedResult = "lập trình";

                Assert.IsTrue(searchPage.getText().ToLower().Contains(expectedResult));
            }
            catch
            {
                // expected result
                var expectedResult = "không tìm thấy dữ liệu";

                Assert.AreEqual(expectedResult, searchPage.getTextError().ToLower());

            }

        }

        [Test]
        public void SearchRecruitmentNews_WithInputCityForm()
        {
            // create Search recruitment news page object
            SearchRNPageObject searchPage = new SearchRNPageObject();

            // search reacruitment news to application
            searchPage.SearchWithCity();

            try
            {
                // expected result
                var expectedResult = "hồ chí minh";

                Assert.IsTrue(searchPage.getTextCity().ToLower().Contains(expectedResult));
            }
            catch
            {
                // expected result
                var expectedResult = "không tìm thấy dữ liệu";

                Assert.AreEqual(expectedResult, searchPage.getTextError().ToLower());

            }

        }

        [Test]
        public void SearchRecruitmentNews_WithInputFacForm()
        {
            // create Search recruitment news page object
            SearchRNPageObject searchPage = new SearchRNPageObject();

            // search reacruitment news to application
            searchPage.SearchWithFac();

            try
            {
                // expected result
                var expectedResult = "hồ chí minh";

                Assert.IsTrue(searchPage.getTextCity().ToLower().Contains(expectedResult));
            }
            catch
            {
                // expected result
                var expectedResult = "không tìm thấy dữ liệu";

                Assert.AreEqual(expectedResult, searchPage.getTextError().ToLower());

            }

        }



        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
        }

    }
}
