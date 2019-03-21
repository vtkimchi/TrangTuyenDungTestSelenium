using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrangTuyenDung.UITests.Selenium
{
    enum PropertyType
    {
        Id,
        Name,
        XPath,
        LinkText,
        CssName,
        ClassName
    }

    class PropertiesCollection
    {
        // Auto-implement Property
        public static IWebDriver driver { get; set; }
    }
}
