using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemoPro
{
    class EditLead
    {


        public EditLead() {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='frameSectionExtra']/a[3]")]
        public IWebElement EditBtnClick { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='updateLeadForm_companyName']")]
        public IWebElement TypeUpdatecName { get; set; }
        ////input[@id='updateLeadForm_companyName']
        [FindsBy(How = How.XPath, Using = "//input[@id='updateLeadForm_firstName']")]
        public IWebElement TypeUpdateFName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='updateLeadForm_lastName']")]
        public IWebElement TypeupdateFormLastName { get; set; }

        [FindsBy(How =How.XPath,Using = "//input[@value='Update']")]
        public IWebElement updatebtnClick { get; set; }

        public void EditLeadObject(string cname, string fname, string lname) {
            EditBtnClick.Clicks();
            TypeUpdatecName.EnterText(cname);
            TypeUpdateFName.EnterText(fname);
            TypeupdateFormLastName.EnterText(lname);
            updatebtnClick.Clicks();
            /*
           SeleniumSetMethod.Clicks(EditBtnClick);
           SeleniumSetMethod.EnterText(TypeUpdatecName,cname);
           SeleniumSetMethod.EnterText(TypeUpdateFName,fname);
           SeleniumSetMethod.EnterText(TypeupdateFormLastName,lname);
           SeleniumSetMethod.Clicks(updatebtnClick);

          EditBtnClick.Click();
           TypeUpdatecName.Clear();
           TypeUpdatecName.SendKeys(cname);

           TypeUpdateFName.Clear();
           TypeUpdateFName.SendKeys(fname);

           TypeupdateFormLastName.Clear();
           TypeupdateFormLastName.SendKeys(lname);
           updatebtnClick.Click();*/

        }





    }
}
