using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Common;

namespace CPT_Mobile_Test.CorpWeb.Pages
{
    public class AuditCombinationipcheckform:Base
    {
        public string Audittype = "com.mobile.telent.staging:id/aduit_type_spinner";
        public string CombinationIpcheck = "//*[@text=\"Combination IP Check\"]";
        public string primaryaudittype = "com.mobile.telent.staging:id/primary_form_spinner";
        public string civil = "//*[@text=\"Form 701 - CIVIL\"]";

        public string Basicinformation = "//*[@text=\"Basic Information\"]";
        public string Generalinformation = "//*[@text=\"General Information\"]";
        public string Exchangearea = "//*[@text=\"Exchange Area *\"]/following-sibling::android.widget.EditText";
        public string jobdesc = "//*[@text=\"Job Description *\"]/following-sibling::android.widget.EditText";
        public string jobaddress = "//*[@text=\"Job Address *\"]/following-sibling::android.widget.EditText";
        public string ContactNo = "//android.widget.TextView[@text='Contract Number *']/following-sibling::android.widget.EditText";
        public string Estimateno = "//android.widget.TextView[@text='Estimate Number *']/following-sibling::android.widget.EditText\r\n";
        public string location = "//android.widget.TextView[@text='Location *']/following-sibling::android.widget.EditText\r\n";
        public string Qcheckdate = "com.mobile.telent.staging:id/etDate";
        public string Date = "//*[@text=\"28\"]";
        public string Okbutton = "//*[@text=\"OK\"]";
        public string Operative1 = "//*[@text=\"Operative 1 I/D *\"]/following-sibling::android.widget.AutoCompleteTextView";
        public string Comments = "//*[@text=\"Comments *\"]/following-sibling::android.widget.EditText";
        public string Jobtype = "//*[@text=\"Job Type *\"]/following-sibling::android.widget.EditText";
        public string Reinstatementtype = "//*[@text=\"Reinstatement Type *\"]/following-sibling::android.widget.EditText";
        public string supplier = "com.mobile.telent.staging:id/supplierSpinner";

        public string Onarrival = "//*[@text=\"On Arrival\"]";
        public string Camera = "//*[@text=\"Camera\"]";
        public string Captureimage = "com.mobile.telent.staging:id/iv_capture_image";
        public string closecameracapture = "com.mobile.telent.staging:id/iv_close";


        public string Genericperformance = "//*[@text=\"Generic Performance\"]";
        public string Workinformation = "//*[@text=\"Work Information\"]";
        public string Workaddress = "com.mobile.telent.staging:id/etInfo";
        public string backbuttonsymbol = "//android.widget.ImageButton[@content-desc=\"Navigate up\"]";

        public string General = "//*[@text=\"General\"]";
        public string Ganglocationsheet = "(//*[@resource-id=\"com.mobile.telent.staging:id/item_status_btn\"])[1]";
        public string Checkok = "//*[@text=\"Checked OK\"]";


        public string Addchildform = "com.mobile.telent.staging:id/add_form_btn";
        public string ugcabling = "//*[@text=\"Form 101 - UG CABLING\"]";
        public string Formugcabling = "//*[@text=\"Form 101 UG CABLING\"]";
        public string Ugabling = "//*[@text=\"UG CABLING\"]";
        public string ugcablingnotchecked = "(//*[@resource-id=\"com.mobile.telent.staging:id/item_status_btn\"])[1]";
        public string backpressbutton = "com.mobile.telent.staging:id/Rl_backpress";
    }
}
