using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrangTuyenDung.UITests.Selenium
{
    class PB01_CreatStaffAccount
    {
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new FirefoxDriver();

            //PropertiesCollection.driver.Navigate().GoToUrl("http://localhost:49925/Account/Login");
            PropertiesCollection.driver.Navigate().GoToUrl("http://cntttest.vanlanguni.edu.vn:18080/EJob/Account/Login");
        }

        [Test]
        public void CreateStaffAccount_WithCreateSuccessful()
        {
            Thread.Sleep(4000);

            // Create Login page object
            LoginPageObject loginPage = new LoginPageObject();
            Thread.Sleep(4000);

            // Read file test data for login
            ExcelLib.PopulateInCollection("D:/K21T2-CAP/Project/Source code/TrangTuyenDung.UITests.Selenium/TestData.xlsx", "PB05_Login");

            // Login to application
            loginPage.FileLoginForm(ExcelLib.ReadData(4, "Email"), ExcelLib.ReadData(4, "Password"));

            Thread.Sleep(4000);

            // create LS page object
            LSPageObject successPage = new LSPageObject();

            Thread.Sleep(4000);

            // Read file test data
            ExcelLib.PopulateInCollection("D:/K21T2-CAP/Project/Source code/TrangTuyenDung.UITests.Selenium/TestData.xlsx", "PB01_CreateStaffAccount");

            // create staff account to application
            successPage.LoginSuccessWithAdminAccount(ExcelLib.ReadData(1, "Email Created"), ExcelLib.ReadData(1, "Password Created"));
            Thread.Sleep(4000);

            // expected result
            var expectedResult = "Index";

            Assert.AreEqual(expectedResult.ToLower(), successPage.CreateSuccessful().ToLower());



        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
        }

    }
}
