using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Common;

namespace CPT_Mobile_Test.CorpWeb.Pages
{
    public class Menulist: Base
    {
        //Help
        public string Menuicon = "com.mobile.telent.staging:id/home_menu_new";
        public string Help = "//*[@text=\"Help\"]";
        public string verifyreport = "//*[@text=\'Report a Problem\']";
        public string Comments = "com.mobile.telent.staging:id/feedBackET";
        public string Sendreport = "//*[@text=\"Send Report\"]";
        public string verifyproblemreported = "//*[@text=\'Problem Reported\']";
        public string okbutton = "//*[@text=\"OK\"]";

        //List of Task
        public string listoftask = "//*[@text=\"List of Tasks\"]";
        public string verifyActivetask = "//*[@text=\'Active Task\']";
        public string backpressicon = "com.mobile.telent.staging:id/Rl_backpress";

        //Two hour Response
        public string twohourresponse = "//*[@text=\"Two Hours Response (Make Safe)\"]";
        public string verifyordernolabel = "com.mobile.telent.staging:id/textView6";
        public string orderno = "//*[@text=\"Order Number\"]/following-sibling::android.widget.AutoCompleteTextView";
        public string Addvisit = "//*[@text=\"Add Visit\"]";
        public string backbutton = "(//android.widget.ImageButton)[1]";

        //Create New Job manually
        public string Createnewjob = "//*[@text=\"Create New Job Manually\"]";
        public string Verfysitevisit = "//*[@text=\'New Site Visit\']";
        public string Reasonforjobmanually = "com.mobile.telent.staging:id/awesomeSpinner_hintButton";
        public string Urgentvisit = "//*[@text=\"Urgent Visit\"]";

        //Create New Audit
        public string Createnewaudit = "//*[@text=\"Create New Audit\"]";
        public string Verifycreatenewauditform = "//*[@text=\'Create New Audit Form\']";

        //Sync Status
        public string Syncstatus = "//*[@text=\"Sync Status\"]";
        public string VerifySyncstatus = "//*[@text=\'Sync Status\']";
        public string Clearalldata = "//*[@text=\"Clear all data\"]";
        public string verifydeletepopup = "//*[@text=\'Delete\']";
        public string Yesbutton = "//*[@text=\"Yes\"]";
        public string syncbackicon = "com.mobile.telent.staging:id/duringWorkCommonBackButton";

        //Message
        public string Message = "//*[@text=\"Messages\"]";
        public string verifymessage = "//*[@text='Messages']";
        public string Verifyinfocontainer = "com.mobile.telent.staging:id/bg_container";
        public string infocontainer = "com.mobile.telent.staging:id/bg_container";
        public string Verifymessagedetails = "//*[@text='Message Details']";
        public string comment = "(//android.widget.EditText)[1]";
        public string plusicon = "com.mobile.telent.staging:id/plus_btn";
        public string verifymember = "//*[@text=\'Member 1\']";
        public string Edit = "//*[@text=\"Edit\"]";
        public string verifyAcknowledge = "//*[@text='Acknowledge']";
        public string CSSID = "com.mobile.telent.staging:id/cssid_msg_actxtView";
        public string signature = "com.mobile.telent.staging:id/msgSignature_img";
        public string Acknowledgment = "//*[@text=\"Acknowledgment\"]";
        public string Acknowledge = "//*[@text=\"Acknowledge\"]";
        public string backbuttonmessage = "com.mobile.telent.staging:id/messageBackButton";

        //HSEQ hub
        public string HSEQhub = "//*[@text=\"HSEQ Hub\"]";
        public string verifyHSEQ = "//*[@text='HSEQ']";
        public string Searchfield = "com.mobile.telent.staging:id/appCompatAutoCompleteTextView";
        public string itemtitle = "com.mobile.telent.staging:id/itemTitle";
        public string VerifyPdfview = "com.mobile.telent.staging:id/pdfView";
        public string backiconHSEQ = "com.mobile.telent.staging:id/duringWorkCommonBackButton";



    }
}
