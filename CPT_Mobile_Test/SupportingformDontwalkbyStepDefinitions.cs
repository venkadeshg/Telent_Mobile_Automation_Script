using CPT_Mobile_Test.CorpWeb.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using TechTalk.SpecFlow;
using TestAutomation.Common;

namespace CPT_Mobile_Test
{
    [Binding]
    public class SupportingformDontwalkbyStepDefinitions:Base
    {
        SupportingformDontwalkby _Support = new SupportingformDontwalkby();

        [Given(@"Click on the Create new supporting forms")]
        public void GivenClickOnTheCreateNewSupportingForms()
        {
            ClickEl(_Support.Createnewsupportingform);
            
        }

        [When(@"Click on the Form Type Dropdown")]
        public void WhenClickOnTheFormTypeDropdown()
        {
            //ClickEl(_Support.dropdown);
            //wait(2);
            //ScrollToOption(_Support.dropdown, "Don't Walk By");

            var dropdown = dr.FindElement(By.Id("com.mobile.telent.staging:id/SFormType_spinner"));
            dropdown.Click(); // Open dropdown

            // Use UiAutomator to find the option
            var option = dr.FindElement(MobileBy.AndroidUIAutomator("new UiSelector().text(\"Don't Walk By\")"));
            option.Click(); // Select the option
        }
    }
}
