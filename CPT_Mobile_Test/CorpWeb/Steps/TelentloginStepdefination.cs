using TestAutomation.CorpWeb.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using System;
using System.Web.UI.WebControls;
using TechTalk.SpecFlow;
using TestAutomation.Common;
using AventStack.ExtentReports;
using System.Threading;

namespace TestAutomation.CorpWeb.Steps
{
    [Binding]
    public class TelentloginStepdefination : Base
    {
        LoginPage _loginPage = new LoginPage();

        [StepDefinition(@"Launched '([^']*)' app")]
        public void GivenLaunchedApp(string telentEmulator)
        {
            MobileApp(telentEmulator);
        }
 
        [StepDefinition(@"Allow all permission in BEE mobile app")]
        public void WhenAllowAllPermissionInBEEMobileApp()
        {
            try
            {
                Console.WriteLine("Location prompt shown");
            }
            catch
            {
                Console.WriteLine("Location prompt is not displayed.");
            }
        }

        [StepDefinition(@"Verify the Signin")]
        public void WhenVerifyTheSignin()
        {
            waitTill(_loginPage.verifysignin,10);
            isThisShown(_loginPage.verifysignin);
        }


        [StepDefinition(@"Enter the User name")]
        public void WhenEnterTheUserName()
        {
            ClickEl(_loginPage.Username);
            actionType(_loginPage.Username, getConfigVal("TELENT_STAGING_UN"));
            dr.HideKeyboard();
        }

        [StepDefinition(@"Enter the Password")]
        public void WhenEnterThePassword()
        {
            actionType(_loginPage.Password, getConfigVal("TELENT_STAGING_PW"));
            dr.HideKeyboard();
        }

        [StepDefinition(@"Click on the submit button in sign in page")]
        public void WhenClickOnTheSubmitButtonInSignInPage()
        {
            ClickEl(_loginPage.Submitbutton);
        }
        [StepDefinition(@"Click on I Agree button")]
        public void WhenClickOnIAgreeButton()
        {
            waitTill(_loginPage.IAgreebutton, 50);
            ClickEl(_loginPage.IAgreebutton);
            Console.WriteLine("Suceess");
        }
        [StepDefinition(@"Click on the Cancel button in Storage clean popup")]
        public void WhenClickOnTheCancelButtonInStorageCleanPopup()
        {
            try
            {
                ClickEl(_loginPage.Storagecleancancelbutton);
            }
            catch
            {
                Console.WriteLine("storage clean prompt is not displayed.");
            }
        }

        [When(@"Verify the Dashbord username")]
        public void WhenVerifyTheDashbordUsername()
        {

            isThisShown(_loginPage.verifyname);
        }


        [StepDefinition(@"Enable the Active taggle button")]
        public void WhenEnableTheActiveTaggleButton()
        {
           // waitTill(_loginPage.Activestatus, 10);
            ClickEl(_loginPage.Activestatus);
        }

        [StepDefinition(@"Click on the Check Now button on Gate check")]
        public void WhenClickOnTheCheckNowButtonOnGateCheck()
        {
            ClickEl(_loginPage.CheckNow);
            waitTill(_loginPage.Workstream, 10);
            ClickEl(_loginPage.Workstream);
            waitTill(_loginPage.Asset, 10);
            ClickEl(_loginPage.Asset);
        }

        [StepDefinition(@"Complete Gate Check")]
        public void ThenCompleteGateCheck()
        {
            _loginPage.SelectRadioButton(5);
            ScRolltopageend();
            _loginPage.SelectRadioButton(5);
            ClickEl(_loginPage.Camera);
            waitTill(_loginPage.Capture, 10);
            wait(2);
            ClickEl(_loginPage.Capture);
            waitTill(_loginPage.Backarrowgatecheck, 7);
            ClickEl(_loginPage.Backarrowgatecheck);

        }


    }
}