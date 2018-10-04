using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemoPro
{


    enum PropertyType
    {
        Id,
        Name,
        TagName,
        XPath,
        CssSelector,
        LinkText,
        PartialLinkText,
        ClassName
    }
    class PropertiesCollection
    {

        public static IWebDriver driver { get; set; }

        
    }
}
