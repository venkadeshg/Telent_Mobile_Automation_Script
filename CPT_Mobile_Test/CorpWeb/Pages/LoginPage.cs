using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Common;

namespace TestAutomation.CorpWeb.Pages
{
    public class LoginPage:Base
    {
        //Top sectio
        public string Turnonlocation = "//android.widget.Button[@text='TURN ON'] ## Location on button";
        public string verifysignin = "//*[@text=\'SIGN IN\']";
        public string Username = "com.mobile.telent.staging:id/editTextTextPersonName ## Enter the username";
        public string Password = "com.mobile.telent.staging:id/editTextTextPersonName2 ## Enter the password";
        public string Submitbutton = "com.mobile.telent.staging:id/login_btn ## Submit button in sign in page";
        public string IAgreebutton = "com.mobile.telent.staging:id/agreeBtn ## Country Continue";
        public string Storagecleancancelbutton = "//android.widget.TextView[@text='Cancel'] ## Login Home";
        public string verifyname = "//*[@text=\'Hi Ram Prasad,\']";
        public string Activestatus = "com.mobile.telent.staging:id/activeTextView ## UserName";
        public string CheckNow = "//android.widget.TextView[@text='Check Now'] ## Password";
        public string Workstream = "//android.widget.Button[@text='Workstream'] ## Login";
        public string Asset = "//*[@text='Asset'] ## Skip";
        public string Camera = "//android.widget.TextView[@text='Camera'] ## Skip Latest";
        public string Capture = "com.mobile.telent.staging:id/iv_capture_image ## installPopup";
        public string Submitagentgatecheck = "//android.widget.Button[@text='Submit'] ## firstSplash";
        public string Backarrowgatecheck = "com.mobile.telent.staging:id/Rl_backpress";




        public void SelectRadioButton(int Count)
        {
            var radioButtons = dr.FindElements(By.Id("com.mobile.telent.staging:id/noBtnList"));

            // Validate the count to ensure it doesn't exceed available radio buttons
            if (Count > radioButtons.Count)
            {
                throw new ArgumentOutOfRangeException($"Requested count {Count} exceeds the total radio buttons {radioButtons.Count}");
            }

            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine($"Clicking Radio Button {i}: {radioButtons[i].GetAttribute("text")}");
                radioButtons[i].Click();
            }
        }

       

    }
}
