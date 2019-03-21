using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrangTuyenDung.UITests.Selenium
{
    class SeleniumGetMethod
    {
        //Getting value out from Textbox
        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");

        }

        //Getting value from Dropdownlist
        public static string GetTextFromDDL(IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }
    }
}
