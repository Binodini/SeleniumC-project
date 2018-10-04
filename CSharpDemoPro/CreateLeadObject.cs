using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemoPro
{
    class CreateLeadObject
    {
        public  CreateLeadObject() {
            PageFactory.InitElements(PropertiesCollection.driver, this);

        }

        [FindsBy(How = How.XPath, Using = "//a[text()='Create Lead']")]
        public IWebElement elementCreateLead { get; set;}

        [FindsBy(How = How.Id, Using = "createLeadForm_companyName")]
        public IWebElement TypeTextCName { get; set; }

        [FindsBy(How = How.Id, Using = "createLeadForm_firstName")]
        public IWebElement TypeTextFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "createLeadForm_lastName")]
        public IWebElement TypeTextLastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='submitButton']")]
        public IWebElement ClickSubmitBtn { get; set; }

        public EditLead CreateLead(string cName, string FName, string LName) {
            TimeSpan.FromSeconds(1);
            elementCreateLead.Clicks();
            TypeTextCName.EnterText(cName);
            TypeTextFirstName.EnterText(FName);
            TypeTextLastName.EnterText(LName);
            ClickSubmitBtn.Clicks();
            return new EditLead();

            /*SeleniumSetMethod.Clicks(elementCreateLead);
           SeleniumSetMethod.EnterText(TypeTextCName,cName);
           SeleniumSetMethod.EnterText(TypeTextFirstName,FName);
           SeleniumSetMethod.EnterText(TypeTextLastName,LName);
           SeleniumSetMethod.Clicks(ClickSubmitBtn);




          ClickLead.Click();
           TypeTextCName.SendKeys(cName);
           TypeTextFirstName.SendKeys(FName);
           TypeTextLastName.SendKeys(LName);
           ClickSubmitBtn.Click();*/

        }
    }
}
