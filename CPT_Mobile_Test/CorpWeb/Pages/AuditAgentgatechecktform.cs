using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Common;

namespace CPT_Mobile_Test.CorpWeb.Pages
{
    public class AuditAgentgatechecktform:Base
    {
        public string Createaudit = "//android.widget.TextView[@text='Create New Audit'] ## secondSplash";
        public string Audittype = "com.mobile.telent.staging:id/aduit_type_spinner ## thirdSplash";
        public string SelectAudittype = "//*[@text='Agent Gate Check'] ## thirdSplash";
        //public string Primaryaudittype = "com.mobile.telent.staging:id/primary_form_spinner ## fourthSplash";
        //public string SelectPrimaryaudittype = "com.mobile.telent.staging:id/primary_form_spinner ## fourthSplash";
        public string ordernumber = "com.mobile.telent.staging:id/autoTextView";
        public string Createbutton = "com.mobile.telent.staging:id/createformbutton ## Homepage";

        //Gang Information
        public string Ganginformation = "//*[@text='Gang Information']";
        public string Gangid = "com.mobile.telent.staging:id/gangAutoTextView";
        public string RegisterationNo = "com.mobile.telent.staging:id/item_vehicle_registration_number_edit";
        public string supplier = "com.mobile.telent.staging:id/suppilerAutoTextView";
        public string Region = "com.mobile.telent.staging:id/text1";
        public string Northeast = "//*[@text='NE-North East']";
        public string Location = "com.mobile.telent.staging:id/location_editxt";
        public string BIDNumber = "com.mobile.telent.staging:id/item_agent_dt_card_number";
        public string NRSWAcardNumber = "com.mobile.telent.staging:id/item_agent_nrswa_number";
        public string backtoaudit = "//android.widget.ImageButton[@content-desc=\"Navigate up\"]";
        //Agent Gate Check
        public string Agentgatecheck = "//*[@text='Agent Gate Check']";
        public string vechileandtrailerchecklist = "//*[@text='Vehicle and trailer checklist']";
        public string preuseinspectionradiobutton = "com.mobile.telent.staging:id/yesradioBtn";
        public string backbuttononauditform = "com.mobile.telent.staging:id/duringWorkCommonBackButton";

        //Summary
        public string Summary = "//*[@text='Summary']";
        public string Gatechecksummary = "(//android.widget.EditText)[2]";
        public string Name = "(//android.widget.EditText)[3]";
        public string workstop = "com.mobile.telent.staging:id/noradioBtn2";
        public string summarybackbutton = "//android.widget.ImageButton[@content-desc=\"Navigate up\"]";

        //Dont Walk By

        public string Dontwalkby = "//*[@text=\"Don't Walk By\"]";
        public string Nameofperson = "(//*[@resource-id='com.mobile.telent.staging:id/et_ipt'])[1] ## Name" ;
        public string Dontwalkbymobileno = "(//*[@resource-id='com.mobile.telent.staging:id/et_ipt'])[2]";
        public string parentcompany = "com.mobile.telent.staging:id/name_actxtView";
        public string clickoutside = "//*[@text=\"Parent Company *\"]";
        public string Dontwalkregion = "com.mobile.telent.staging:id/text_input_end_icon";
        public string Dontwalybylocation = "com.mobile.telent.staging:id/txt_comm_ipt_label";
        public string tellus = "(//*[@resource-id='com.mobile.telent.staging:id/txt_comm_ipt_label'])[2]  ##what do you want to tell us?";
        public string describeaction = "(//android.widget.EditText)[4]";
        public string furtheractionradiobutton = "//*[@text=\"Yes\"]  ##Does this require further action";
        public string severity = "//*[@text=\"Minor\"]";
        public string category = "//*[@text=\"HSE\"]";
        public string Type = "com.mobile.telent.staging:id/text_input_end_icon";

        public string submitbutton = "//*[@text=\"Submit\"]";
        public string SureYesbutton = "//*[@text=\"Yes\"]";
        public string Signature = "(//android.view.View)[1]";
        public string OKbuttonsucesspopup = "//*[@text=\"OK\"]";

        public string Submittedform = "//*[@text=\"Submitted Forms\"]";
        public string syncbutton = "com.mobile.telent.staging:id/fabSync";













    }
}
