using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrangTuyenDung.UITests.Selenium
{
    class PB05_Login
    {

        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new FirefoxDriver();
            
            //PropertiesCollection.driver.Navigate().GoToUrl("http://localhost:49925/Account/Login");
            PropertiesCollection.driver.Navigate().GoToUrl("http://cntttest.vanlanguni.edu.vn:18080/EJob/");

            // Read file test data
            ExcelLib.PopulateInCollection("D:/K21T2-CAP/Project/Source code/TrangTuyenDung.UITests.Selenium/TestData.xlsx", "PB05_Login");
        }

        [Test]
        public void Login_WithLoginRigh()
        {
            Thread.Sleep(4000);

            // Create Login page object
            LoginPageObject loginPage = new LoginPageObject();

            // Login to application
            loginPage.FileLoginForm(ExcelLib.ReadData(1, "Email"), ExcelLib.ReadData(1, "Password"));

            Thread.Sleep(4000);

            // go to the next page
            LSPageObject successPage = new LSPageObject();

            // expected result
            var expectedResult = "Danh sách tin tuyển dụng";

            Assert.AreEqual(expectedResult.ToLower(), successPage.LoginSuccessfull().ToLower());
        }

        [Test]
        public void Login_WithEmailWrong()
        {
            LoginPageObject page = new LoginPageObject();

            // Sleep 4s when load page Login
            Thread.Sleep(4000);

            // Create Login page object
            LoginPageObject loginPage = new LoginPageObject();

            // Login to application
            loginPage.FileLoginForm(ExcelLib.ReadData(2, "Email"), ExcelLib.ReadData(2, "Password"));
            Thread.Sleep(4000);

            // go to the next page
            LSPageObject successPage = new LSPageObject();

            var expectedResult = "Đăng nhập lỗi!";

            Assert.AreEqual(expectedResult.ToLower(), successPage.LoginError().ToLower());
        }

        [Test]
        public void Login_WithPasswordWrong()
        {
            LoginPageObject page = new LoginPageObject();

            // Sleep 4s when load page Login
            Thread.Sleep(4000);

            // Create Login page object
            LoginPageObject loginPage = new LoginPageObject();

            // Login to application
            loginPage.FileLoginForm(ExcelLib.ReadData(3, "Email"), ExcelLib.ReadData(3, "Password"));
            Thread.Sleep(4000);

            // go to the next page
            LSPageObject successPage = new LSPageObject();

            var expectedResult = "Đăng nhập lỗi!";

            Assert.AreEqual(expectedResult.ToLower(), successPage.LoginError().ToLower());
        }


        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
        }
    }
}
