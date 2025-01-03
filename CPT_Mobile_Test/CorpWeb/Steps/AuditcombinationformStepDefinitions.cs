using CPT_Mobile_Test.CorpWeb.Pages;
using System;
using TechTalk.SpecFlow;
using TestAutomation.Common;

namespace CPT_Mobile_Test
{
    [Binding]
    public class AuditcombinationformStepDefinitions:Base
    {
        AuditCombinationipcheckform _Ipcheck = new AuditCombinationipcheckform();

        [When(@"Click on the audit type")]
        public void WhenClickOnTheAuditType()
        {
            ClickEl(_Ipcheck.Audittype);
        }

        [When(@"select the Combination Ip Check")]
        public void WhenSelectTheCombinationIpCheck()
        {
            ClickEl(_Ipcheck.CombinationIpcheck);
        }

        [When(@"Click on the Primary audit type")]
        public void WhenClickOnThePrimaryAuditType()
        {
            ClickEl(_Ipcheck.primaryaudittype);
        }

        [When(@"select the Civil")]
        public void WhenSelectTheCivil()
        {
            ClickEl(_Ipcheck.civil);
        }

        [StepDefinition("click on the General information")]
        public void GivenClickOnTheGeneralInformation()
        {
            ClickEl(_Ipcheck.Generalinformation);  
        }

        [Given(@"Enter the Exchange Area")]
        public void GivenEnterTheExchangeArea()
        {
            clearText(_Ipcheck.Exchangearea);
            ClickEl(_Ipcheck.Exchangearea);
            typeText(_Ipcheck.Exchangearea, getConfigVal("ExchegeArea"));
        }

        [Given(@"Enter the Job Description")]
        public void GivenEnterTheJobDescription()
        {
            clearText(_Ipcheck.jobdesc);
            ClickEl (_Ipcheck.jobdesc);
            typeText(_Ipcheck.jobdesc, getConfigVal("Jobdescription"));
        }

        [Given(@"Enter the job address")]
        public void GivenEnterTheJobAddress()
        {
            clearText(_Ipcheck.jobaddress);
            ClickEl(_Ipcheck.jobaddress);
            actionType(_Ipcheck.jobaddress, getConfigVal("JobAddress"));
        }

        [Given(@"Enter the Contact Number")]
        public void GivenEnterTheContactNumber()
        {
            
            IsElepresent(_Ipcheck.ContactNo);
            clearText(_Ipcheck.ContactNo);
            ClickEl(_Ipcheck.ContactNo);
            actionType(_Ipcheck.ContactNo, getConfigVal("Contactnumber"));
        }

        [Given(@"Enter the estimate number")]
        public void GivenEnterTheEstimateNumber()
        {
            clearText(_Ipcheck.Estimateno);
            ClickEl(_Ipcheck.Estimateno);
            typeText(_Ipcheck.Estimateno, getConfigVal("EstimateNo"));
        }

        [Given(@"Enter the location")]
        public void GivenEnterTheLocation()
        {
            dr.HideKeyboard();
            MobileScrollTotext("Location *");
            clearText(_Ipcheck.location);
            ClickEl(_Ipcheck.location);
            typeText(_Ipcheck.location, getConfigVal("Location"));
        }


        [Given(@"Click on the Q Check date")]
        public void GivenClickOnTheQCheckDate()
        {
            MobileScrollTotext("Q Check Date and Time *");
            ClickEl(_Ipcheck.Qcheckdate);
        }

        [Given(@"Select the date")]
        public void GivenSelectTheDate()
        {
            ClickEl(_Ipcheck.Date);
        }

        [Given(@"Click on the OK button")]
        public void GivenClickOnTheOKButton()
        {
            ClickEl(_Ipcheck.Okbutton);
        }

        [Given(@"click on the Time Ok button")]
        public void GivenClickOnTheTimeOkButton()
        {
            ClickEl(_Ipcheck.Okbutton);
        }

        [Given(@"Click on the Operative one")]
        public void GivenClickOnTheOperativeOne()
        {
            MobileScrollTotext("Operative 1 I/D *");
            ClickEl(_Ipcheck.Operative1);
        }

        [Given(@"select the Operative one Values")]
        public void GivenSelectTheOperativeOneValues()
        {
            typeText(_Ipcheck.Operative1, getConfigVal("parentcompanyvalue"));
            wait(2);
            Actiondownandenter();
        }

        [Given(@"Enter the Comments")]
        public void GivenEnterTheComments()
        {
            MobileScrollTotext("Comments *");
            clearText(_Ipcheck.Comments);
            ClickEl(_Ipcheck.Comments);
            typeText(_Ipcheck.Comments, getConfigVal("Comment"));
            dr.HideKeyboard();
        }

        [Given(@"Enter the Jobtype")]
        public void GivenEnterTheJobtype()
        {
            ScRolltopageend();
           // MobileScrollTotext("Job Type *");
            clearText(_Ipcheck.Jobtype);
            ClickEl(_Ipcheck.Jobtype);
            typeText(_Ipcheck.Jobtype, getConfigVal("JobType"));
            dr.HideKeyboard();
        }

        [Given(@"Enter the Reinstatementtype")]
        public void GivenEnterTheReinstatementtype()
        {
            ScRolltopageend();
           // MobileScrollTotext("Reinstatement Type *");
            clearText(_Ipcheck.Reinstatementtype); 
            ClickEl(_Ipcheck.Reinstatementtype);
            typeText(_Ipcheck.Reinstatementtype, getConfigVal("ReinstatementType"));
            dr.HideKeyboard();
        }

        [Given(@"select the supplier")]
        public void GivenSelectTheSupplier()
        {
            ScRolltopageend();
           // MobileScrollTotext("Supplier *");
            clearText(_Ipcheck.supplier);
            ClickEl(_Ipcheck.supplier);
            Actiondownandenter();
        }


        [Given(@"click on the On arrival")]
        public void GivenClickOnTheOnArrival()
        {
            ClickEl(_Ipcheck.Onarrival);
        }

        [Given(@"click on the Camera button")]
        public void GivenClickOnTheCameraButton()
        {
            ClickEl(_Ipcheck.Camera);
        }

        [StepDefinition(@"Click on the Capture button in inside camera")]
        public void GivenClickOnTheCaptureButtonInInsideCamera()
        {
            ClickEl(_Ipcheck.Captureimage);
        }

        [StepDefinition(@"Click on the close camera icon")]
        public void GivenClickOnTheCloseCameraIcon()
        {
            ClickEl(_Ipcheck.closecameracapture);
        }

        [Given(@"Click onn the gereric performance")]
        public void GivenClickOnnTheGerericPerformance()
        {
            ClickEl(_Ipcheck.Genericperformance);
        }

        [Given(@"Click on the work information")]
        public void GivenClickOnTheWorkInformation()
        {
            ClickEl(_Ipcheck.Workinformation);
        }

        [Given(@"Enter the Work address")]
        public void GivenEnterTheWorkAddress()
        {
            actionType(_Ipcheck.Workaddress, getConfigVal("workAddress"));
        }

        [Given(@"Click on the Back button arrow")]
        public void GivenClickOnTheBackButtonArrow()
        {
            ClickEl(_Ipcheck.backbuttonsymbol);
        }

        [Given(@"Click on the General")]
        public void GivenClickOnTheGeneral()
        {
            ClickEl(_Ipcheck.General);
        }

        [Given(@"Click on the Gang location sheet")]
        public void GivenClickOnTheGangLocationSheet()
        {
            ClickEl(_Ipcheck.Ganglocationsheet);
        }

        [Given(@"Click on the Check ok button")]
        public void GivenClickOnTheCheckOkButton()
        {
            ClickEl(_Ipcheck.Checkok);
        }

        [Given(@"Click on the Add button in Child forms")]
        public void GivenClickOnTheAddButtonInChildForms()
        {
            ClickEl(_Ipcheck.Addchildform);
        }

        [Given(@"click Ug cabling")]
        public void GivenClickUgCabling()
        {
            ClickEl(_Ipcheck.ugcabling);
        }

        [Given(@"click on the Form Ug Cabling")]
        public void GivenClickOnTheFormUgCabling()
        {
            ClickEl(_Ipcheck.Formugcabling);
        }

        [Given(@"Click on the UG Cabling")]
        public void GivenClickOnTheUGCabling()
        {
            ClickEl(_Ipcheck.Ugabling);
        }

        [Given(@"Clik on ugcabling not checked")]
        public void GivenClikOnUgcablingNotChecked()
        {
            ClickEl(_Ipcheck.ugcablingnotchecked);
        }

        [StepDefinition(@"Click on the Back press button arrow")]
        public void GivenClickOnTheBackPressButtonArrow()
        {
            ClickEl(_Ipcheck.backpressbutton);
        }

    }
}
