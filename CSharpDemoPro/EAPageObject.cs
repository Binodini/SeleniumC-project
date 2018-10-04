using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemoPro
{

    
    class EAPageObject
    {

        public EAPageObject() {

            PageFactory.InitElements(PropertiesCollection.driver,this);
        }

        [FindsBy(How=How.Id,Using ="username")]
        public IWebElement userName { get; set; }


        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement passWord { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#login > p:nth-child(3) > input")]
        public IWebElement decorativeSubmit { get; set; }

        [FindsBy(How = How.CssSelector,Using= "#label > a")]
        public IWebElement ClickLink{ get; set; }

        public CreateLeadObject login(string username, string password) {

            userName.EnterText(username);
            passWord.EnterText(password);
            decorativeSubmit.Clicks();
            ClickLink.Clicks();
            return new CreateLeadObject();

            /*SeleniumSetMethod.EnterText(userName,username);
           SeleniumSetMethod.EnterText(passWord,password);
           SeleniumSetMethod.Clicks(decorativeSubmit);
           SeleniumSetMethod.Clicks(ClickLink);
           return new CreateLeadObject();
          userName.SendKeys(username);
           passWord.SendKeys(password);
           decorativeSubmit.Click();
           ClickLink.Click();
           return new CreateLeadObject();*/
        }

    }
}
