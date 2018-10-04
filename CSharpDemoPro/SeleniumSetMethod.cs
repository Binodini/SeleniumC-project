using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace CSharpDemoPro
{
    public static class SeleniumSetMethod
    {

        public static void EnterText(this IWebElement element, string value)
        {

            element.SendKeys(value);
        }

        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }

        public static void SelectDropDown(this IWebElement element, string value)
        {
                          new SelectElement(element).SelectByText(value);
        }

        
    }
}
        /*public static void EnterText(string element, string value, PropertyType elementType ) {
           
            if (elementType ==PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if(elementType == PropertyType.XPath)
                PropertiesCollection.driver.FindElement(By.XPath(element)).SendKeys(value);
            if(elementType == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
            if (elementType == PropertyType.CssSelector)
                PropertiesCollection.driver.FindElement(By.CssSelector(element)).SendKeys(value);
            if (elementType == PropertyType.LinkText)
                PropertiesCollection.driver.FindElement(By.LinkText(element)).SendKeys(value);
            if (elementType == PropertyType.PartialLinkText)
                PropertiesCollection.driver.FindElement(By.PartialLinkText(element)).SendKeys(value);
            if (elementType ==PropertyType.ClassName)
                PropertiesCollection.driver.FindElement(By.ClassName(element)).SendKeys(value);
            if (elementType == PropertyType.TagName)
                PropertiesCollection.driver.FindElement(By.TagName(element)).SendKeys(value);

        }

        internal static void Click(object driver, string v1, string v2)
        {
            throw new NotImplementedException();
        }

        internal static void Click(IWebDriver driver, object element, object elementType)
        {
            throw new NotImplementedException();
        }

        public static void Click(string element, PropertyType elementType) {

            if (elementType == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            if (elementType == PropertyType.XPath)
                PropertiesCollection.driver.FindElement(By.XPath(element)).Click();
            if (elementType == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
            if (elementType == PropertyType.CssSelector)
                PropertiesCollection.driver.FindElement(By.CssSelector(element)).Click();
            if (elementType == PropertyType.LinkText)
                PropertiesCollection.driver.FindElement(By.LinkText(element)).Click();
            if (elementType == PropertyType.PartialLinkText)
                PropertiesCollection.driver.FindElement(By.PartialLinkText(element)).Click();
            if (elementType == PropertyType.ClassName)
                PropertiesCollection.driver.FindElement(By.ClassName(element)).Click();
            if (elementType == PropertyType.TagName)
                PropertiesCollection.driver.FindElement(By.TagName(element)).Click();
        }
        //selecting a drop down control
        public static void SelectDropDown(string element, string value, PropertyType elementType) {

            if (elementType == PropertyType.Id)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementType == PropertyType.XPath)
                new SelectElement(PropertiesCollection.driver.FindElement(By.XPath(element))).SelectByText(value);
            if (elementType == PropertyType.Name)
            new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
            if (elementType == PropertyType.CssSelector)
                 new SelectElement(PropertiesCollection.driver.FindElement(By.CssSelector(element))).SelectByText(value);
            if (elementType ==PropertyType.LinkText )
                  new SelectElement(PropertiesCollection.driver.FindElement(By.LinkText(element))).SelectByText(value);
            if (elementType == PropertyType.PartialLinkText)
                new SelectElement(PropertiesCollection.driver.FindElement(By.PartialLinkText(element))).SelectByText(value);
            if (elementType == PropertyType.ClassName)
                new SelectElement(PropertiesCollection.driver.FindElement(By.ClassName(element))).SelectByText(value);
            if (elementType == PropertyType.TagName)
                  new SelectElement(PropertiesCollection.driver.FindElement(By.TagName(element))).SelectByText(value);


        }




    }*/

