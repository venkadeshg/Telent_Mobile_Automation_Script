using CPT_Mobile_Test.CorpWeb.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;
using TestAutomation.Common;
using TestAutomation.CorpWeb.Pages;

namespace CPT_Mobile_Test
{
    [Binding]
    public class AuditFormStepDefinitions:Base
    {
        AuditAgentgatechecktform _Audit = new AuditAgentgatechecktform();

        [StepDefinition(@"Click on the Create Audit forms")]
        public void WhenClickOnTheCreateAuditForms()
        {
            waitTill(_Audit.Createaudit, 70);
            ClickEl(_Audit.Createaudit);
        }

        [StepDefinition(@"Select Audit Type")]
        public void WhenSelectAuditType()
        {
            ClickEl(_Audit.Audittype);
            waitTill(_Audit.SelectAudittype, 5);
            ClickEl(_Audit.SelectAudittype);
        }

        [StepDefinition(@"Enter the Order Number")]
        public void WhenEnterTheOrderNumber()
        {
            typeText(_Audit.ordernumber, getConfigVal("OrderNo"));
        }

        [StepDefinition(@"Click on the Create button")]
        public void WhenClickOnTheCreateButton()
        {
            ClickEl(_Audit.Createbutton);
        }

        [StepDefinition(@"click on the Gang information")]
        public void WhenClickOnTheGangInformation()
        {
            
            ClickEl(_Audit.Ganginformation);
        }

        [StepDefinition(@"Enter the Gang ID")]
        public void WhenEnterTheGangID()
        {
            ClickEl(_Audit.Gangid);
            typeText(_Audit.Gangid, getConfigVal("selectGangid"));
            wait(2);
            Actiondownandenter();
        }        

        [StepDefinition(@"Enter vechcle Registeration Number")]
        public void WhenEnterVechcleRegisterationNumber()
        {
            waitTill(_Audit.RegisterationNo,7);
            typeText(_Audit.RegisterationNo, getConfigVal("RegistervechileNo"));
            waitTill(_Audit.supplier, 4);
            ClickEl(_Audit.supplier);
        }

        [StepDefinition(@"Select the Region")]
        public void WhenSelectTheRegion()
        {  
            ClickEl(_Audit.Region);
            _Audit.Actiondownandenter();
        }          

        [StepDefinition(@"Enter the Location")]
        public void WhenEnterTheLocation()
        {
            typeText(_Audit.Location, getConfigVal("Location"));
            dr.HideKeyboard();
        }


        [StepDefinition(@"Enter BT ID Card Number")]
        public void WhenEnterBTIDCardNumber()
        {
            ScRolltopageend();
            ClickEl(_Audit.BIDNumber);
            typeText(_Audit.BIDNumber, getConfigVal("CTNumber"));
            wait(2);
            Actiondownandenter();
            Console.WriteLine("Successfully selected the dropdown value");

        }
        [StepDefinition(@"Enter the NRSWA card Number")]
        public void WhenEnterTheNRSWACardNumber()
        {
            ScRolltopageend();
            typeText(_Audit.NRSWAcardNumber, getConfigVal("NRSWANO"));
        }

        [StepDefinition(@"Click on the back button on gang information")]
        public void WhenClickOnTheBackButtonOnGangInformation()
        {
            ClickEl(_Audit.backtoaudit);
        }

        [StepDefinition(@"Click Agent gate check")]
        public void WhenClickAgentGateCheck()
        {
            ClickEl(_Audit.Agentgatecheck);
        }

        [StepDefinition(@"click vechile and trailer checklist")]
        public void WhenClickVechileAndTrailerChecklist()
        {
            ClickEl(_Audit.vechileandtrailerchecklist);
        }

        [StepDefinition(@"Click yes radio buttton preuse inspector")]
        public void WhenClickYesRadioButttonPreuseInspector()
        {
            ClickEl(_Audit.preuseinspectionradiobutton);
        }

        [StepDefinition(@"Click on the back button on vechile and trailer checklist screen")]
        public void WhenClickOnTheBackButtonOnVechileAndTrailerChecklistScreen()
        {
            ClickEl(_Audit.backbuttononauditform);
        }

        [StepDefinition(@"Click on the back button on Agent Gate Check")]
        public void WhenClickOnTheBackButtonOnAgentGateCheck()
        {
            ClickEl(_Audit.backtoaudit);
        }

        [StepDefinition(@"Click on the Summary")]
        public void WhenClickOnTheSummary()
        {
            ClickEl(_Audit.Summary);
            wait(3);
        }

        [StepDefinition(@"Enter the Gate check summary")]
        public void WhenEnterTheGateCheckSummary()
        {
            typeText(_Audit.Gatechecksummary, getConfigVal("gatechecksummary"));
        }

        [StepDefinition(@"Enter the Name")]
        public void WhenEnterTheName()
        {
            ClickEl(_Audit.Name);
            typeText(_Audit.Name,getConfigVal("name"));
        }

        [StepDefinition(@"click on the No burron in Work Stop")]
        public void WhenClickOnTheNoBurronInWorkStop()
        {
            ClickEl(_Audit.workstop);
        }

        [StepDefinition(@"Click on the back button on Summary")]
        public void WhenClickOnTheBackButtonOnSummary()
        {
            ClickEl(_Audit.summarybackbutton);
        }

        [StepDefinition(@"Click on the Dont walk by")]
        public void GivenClickOnTheDontWalkBy()
        {
            ClickEl(_Audit.Dontwalkby);
        }

        [StepDefinition(@"Enter the Name Of person")]
        public void GivenEnterTheNameOfPerson()
        {
            typeText(_Audit.Nameofperson, getConfigVal("Dontwalybynameofperson"));
        }

        [StepDefinition(@"Enter the Mobile Number")]
        public void GivenEnterTheMobileNumber()
        {
            typeText(_Audit.Dontwalkbymobileno, getConfigVal("WalkbyMobileNo"));
        }

        [StepDefinition(@"Select the Parent company")]
        public void GivenSelectTheParentCompany()
        {
            ClickEl(_Audit.parentcompany);
            dr.HideKeyboard();
            typeText(_Audit.parentcompany, getConfigVal("parentcompanyvalue"));
           // wait(2);
            _Audit.Actiondownandenter();
            dr.HideKeyboard();
            //ClickEl(_Audit.parentcompany);
            //ClickEl(_Audit.clickoutside);
        }

        [StepDefinition(@"Select the Dont walk by region")]
        public void GivenSelectTheDontWalkByRegion()
        {
           
            ClickEl(_Audit.Dontwalkregion);
            
            ActionTab();
        }

        [Given(@"Enter the Location")]
        public void GivenEnterTheLocation()
        {
         
            //typeText(_Audit.Dontwalybylocation, getConfigVal("Location"));
        }

        [StepDefinition(@"Enter the what to you want to tell us\?")]
        public void GivenEnterTheWhatToYouWantToTellUs()
        {
            ScRolltopageend();
            actionType(_Audit.tellus, getConfigVal("Tellus"));
        }

        [StepDefinition(@"Enter the Describe the action you have taken")]
        public void GivenEnterTheDescribeTheActionYouHaveTaken()
        {
           // ClickEl(_Audit.describeaction);
            //dr.HideKeyboard();
            actionType(_Audit.describeaction, getConfigVal("Describeaction"));
        }

        [Given(@"Click on the No button in does this require further action")]
        public void GivenClickOnTheNoButtonInDoesThisRequireFurtherAction()
        {
            ClickEl(_Audit.furtheractionradiobutton);
        }
       

        [Given(@"Click on the Minor radio button in severity")]
        public void GivenClickOnTheMinorRadioButtonInSeverity()
        {
            ScRolltopageend();
            ClickEl(_Audit.severity);
        }

        [Given(@"Click on the Quality Radio button in Category")]
        public void GivenClickOnTheQualityRadioButtonInCategory()
        {
            ScRolltopageend();
            ClickEl(_Audit.category);
        }

        [Given(@"Selet the Type")]
        public void GivenSeletTheType()
        {
            ScRolltopageend();
            ClickEl(_Audit.Type);
            ActionTab();

        }
        [Then(@"click on the backbutton in Dont walk by screen")]
        public void ThenClickOnTheBackbuttonInDontWalkByScreen()
        {
            ClickEl(_Audit.backbuttononauditform);
        }

        [StepDefinition(@"click Audit submit button")]
        public void ThenClickAuditSubmitButton()
        {
            ClickEl(_Audit.submitbutton);
        }

        [StepDefinition(@"click yes button in Are you sure popup screen")]
        public void ThenClickYesButtonInAreYouSurePopupScreen()
        {
            ClickEl(_Audit.SureYesbutton);
        }

        [StepDefinition(@"Click on the signature")]
        public void ThenClickOnTheSignature()
        {
            ClickEl(_Audit.Signature);
        }

        [StepDefinition(@"Clcik Signature Submit button")]
        public void ThenClcikSignatureSubmitButton()
        {
            ClickEl(_Audit.submitbutton);
        }


        [StepDefinition(@"Click on the OK button in audit sucess popup message")]
        public void ThenClickOnTheOKButtonInAuditSucessPopupMessage()
        {
            ClickEl(_Audit.OKbuttonsucesspopup);
        }

        [StepDefinition(@"Click on the Submitted form module")]
        public void ThenClickOnTheSubmittedFormModule()
        {
            ClickEl(_Audit.Submittedform);
        }

        [StepDefinition(@"click on the sync icon in Submitted form")]
        public void ThenClickOnTheSyncIconInSubmittedForm()
        {
            ClickEl(_Audit.syncbutton);
        }



    }
}
