using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrangTuyenDung.UITests.Selenium
{
    class SeleniumSetMethod
    {
        // Enter Text
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
            System.Threading.Thread.Sleep(100);

        }

        // Click into a button, Checkbox, option etc
        public static void Click(IWebElement element)
        {
            element.Click();

            System.Threading.Thread.Sleep(100);
        }

        // Selecting a drop down control
        public static void SelectDropDown(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);

            System.Threading.Thread.Sleep(100);

        }

        public static void Submit(IWebElement element)
        {
            element.Submit();

            System.Threading.Thread.Sleep(100);

        }
    }
}
