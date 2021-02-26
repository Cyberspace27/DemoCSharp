using OpenQA.Selenium;
using System;

namespace DemoCSharp.generic
{

    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }

    class PropertiesCollection
    {

        public static IWebDriver driver { get; set; }

    }
}
