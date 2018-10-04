using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemoPro
{
    class Program
    {
       // public static IWebDriver driver;
        static void Main(string[] args)
        {
        
        }
        [SetUp]
        public void Initialize()
        {
            /*ExcelUtil util = new ExcelUtil();
            util.ExcelToDataTable(@"C:\Users\binsahoo\Desktop\specFlow"); */

            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://leaftaps.com/opentaps/");
           
        }

           /* SeleniumSetMethod.EnterText("username", "DemoSalesManager",PropertyType.Id);
            Console.Write("The value of the username: " +SeleniumGetMethods.GetText("username","Id"));
           // driver.FindElement(By.Id("username")).SendKeys("DemoSalesManager");
           // driver.FindElement(By.Id("password")).SendKeys("crmsfa");
            SeleniumSetMethod.EnterText("password", "crmsfa",PropertyType.Id);
            Console.Write("\n The value of the password: " + SeleniumGetMethods.GetText("password", "Id"));
            PropertiesCollection.driver.FindElement(By.ClassName("decorativeSubmit")).Click();
            //SeleniumSetMethod.Click(driver, "decorativeSubmit", "ClassSubmit");
        }
       /* [Test]
        public void Logintest() {
            
        }*/

        [Test]
        public void ExecuteTest() {
            ExcelLib.PopulateInCollection(@"C:\DataProvider\Authentication.xlsx");
            EAPageObject page = new EAPageObject();
            CreateLeadObject clO= page.login(ExcelLib.ReadData(1, "UserName"), ExcelLib.ReadData(1,"Password"));
            EditLead EditLeadPage = clO.CreateLead(ExcelLib.ReadData(1,"cName"),ExcelLib.ReadData(1,"fName"),ExcelLib.ReadData(1,"lName"));
       EditLeadPage.EditLeadObject("Binukunu enterprizes","Kunmun","sahoo");

            //CreateLeadObject clO = new CreateLeadObject();
            //page.userName.SendKeys("DemoSalesManager");
            //page.passWord.SendKeys("crmsfa");
            // page.decorativeSubmit.Click();
            // page.ClickLink.Click();
            //return new CreateLeadObject();
            //SeleniumSetMethod.Click("#label > a", PropertyType.CssSelector);
            // driver.FindElement(By.CssSelector("#label > a")).Click();
        }


       [TearDown]
         public void CloseBrowser() {
             PropertiesCollection.driver.Close();
         }
    }
}
