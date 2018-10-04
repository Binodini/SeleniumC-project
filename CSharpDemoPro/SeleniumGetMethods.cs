using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemoPro
{
    public static class SeleniumGetMethods
    {

        public static string GetText(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string GetTextFromDDL(this IWebElement element)
        {


            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }


    }
}



    /* public static string GetText(string element,string elementType) {
         if (elementType == "Id")
            return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
         if (elementType == "XPath")
             return PropertiesCollection.driver.FindElement(By.XPath(element)).GetAttribute("value");
         if (elementType == "Name")
             return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
         if (elementType == "CssSelector")
             return PropertiesCollection.driver.FindElement(By.CssSelector(element)).GetAttribute("value");
         if (elementType == "LinkText")
             return PropertiesCollection.driver.FindElement(By.LinkText(element)).GetAttribute("value");
         if (elementType == "PartialLinkText")
             return PropertiesCollection.driver.FindElement(By.PartialLinkText(element)).GetAttribute("value");
         if (elementType == "ClassName")
             return PropertiesCollection.driver.FindElement(By.ClassName(element)).GetAttribute("value");
         if (elementType == "TagName")
             return PropertiesCollection.driver.FindElement(By.TagName(element)).GetAttribute("value");
         else return string.Empty;


     }

     internal static string GetText(IWebDriver driver, string v1, string v2)
     {
         throw new NotImplementedException();
     }

     public static string GetTextFromDDL(string element, string elementType) {

         if (elementType == "Id")
             return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
         if (elementType == "XPath")
             return new SelectElement(PropertiesCollection.driver.FindElement(By.XPath(element))).AllSelectedOptions.SingleOrDefault().Text;
         if (elementType == "Name")
             return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
         if (elementType == "CssSelector")
             return new SelectElement(PropertiesCollection.driver.FindElement(By.CssSelector(element))).AllSelectedOptions.SingleOrDefault().Text; ;
         if (elementType == "LinkText")
             return new SelectElement(PropertiesCollection.driver.FindElement(By.LinkText(element))).AllSelectedOptions.SingleOrDefault().Text;
         if (elementType == "PartialLinkText")
             return new SelectElement(PropertiesCollection.driver.FindElement(By.PartialLinkText(element))).AllSelectedOptions.SingleOrDefault().Text;
         if (elementType == "ClassName")
             return new SelectElement(PropertiesCollection.driver.FindElement(By.ClassName(element))).AllSelectedOptions.SingleOrDefault().Text;
         if (elementType == "TagName")
             return new SelectElement(PropertiesCollection.driver.FindElement(By.TagName(element))).AllSelectedOptions.SingleOrDefault().Text;

         else return string.Empty;

     } 

}
} */
