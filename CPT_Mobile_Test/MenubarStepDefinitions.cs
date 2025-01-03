using CPT_Mobile_Test.CorpWeb.Pages;
using System;
using TechTalk.SpecFlow;
using TestAutomation.Common;

namespace CPT_Mobile_Test
{
    [Binding]
    public class MenubarStepDefinitions:Base
    {
        Menulist _Menu = new Menulist();

        [Given(@"Click on the Menu icon")]
        public void GivenClickOnTheMenuIcon()
        {
            ClickEl(_Menu.Menuicon);
        }

        [When(@"Click on the Help button")]
        public void WhenClickOnTheHelpButton()
        {
            ClickEl(_Menu.Help);
        }
        [When(@"Verify the Report a problem")]
        public void WhenVerifyTheReportAProblem()
        {
            waitTill(_Menu.verifyreport, 10);
            isThisShown(_Menu.verifyreport);
        }

        [When(@"Enter the Comments in Report a problem")]
        public void WhenEnterTheCommentsInReportAProblem()
        {
            actionType(_Menu.Comments, getConfigVal("Comment"));
        }

        [When(@"Click on the Send report")]
        public void WhenClickOnTheSendReport()
        {
            ClickEl(_Menu.Sendreport);
        }

        [When(@"Verify the Problem Report popup")]
        public void WhenVerifyTheProblemReportPopup()
        {
            waitTill(_Menu.verifyproblemreported, 20);
            isThisShown(_Menu.verifyproblemreported);
        }

        [StepDefinition(@"Click on the Ok button in Problem Report popup")]
        public void WhenClickOnTheOkButtonInProblemReportPopup()
        {
            ClickEl(_Menu.okbutton);
        }

        [Given(@"Click on the List of Task in menu bar")]
        public void GivenClickOnTheListOfTaskInMenuBar()
        {
            ClickEl(_Menu.listoftask);
        }

        [StepDefinition(@"Verfy the Active Task")]
        public void ThenVerfyTheActiveTask()
        {
            waitTill(_Menu.verifyActivetask, 10);
            isThisShown(_Menu.verifyActivetask);
        }

        [StepDefinition(@"Click on the back press icon in List of Task Screen")]
        public void ThenClickOnTheBackPressIconInListOfTaskScreen()
        {
           ClickEl(_Menu.backpressicon);
        }


        [Given(@"Click on the Two hour Response")]
        public void GivenClickOnTheTwoHourResponse()
        {
            ClickEl(_Menu.twohourresponse);
        }

        [When(@"Verify the Order number label")]
        public void WhenVerifyTheOrderNumberLabel()
        {
            waitTill(_Menu.verifyordernolabel, 10);
            isThisShown(_Menu.verifyordernolabel);
        }

        [When(@"Enter the Order No")]
        public void WhenEnterTheOrderNo()
        {
            ClickEl(_Menu.orderno);
            actionType(_Menu.orderno, getConfigVal("OrderNo"));
        }

        [When(@"Click on the Add visits in Menu bar screen")]
        public void WhenClickOnTheAddVisitsInMenuBarScreen()
        {
            ClickEl(_Menu.Addvisit);
        }

        [Then(@"Click on the back button in Two hour response Screen")]
        public void ThenClickOnTheBackButtonInTwoHourResponseScreen()
        {
            ClickEl(_Menu.backbutton);
        }
        [Given(@"Click on the Create new Job manually")]
        public void GivenClickOnTheCreateNewJobManually()
        {
            ClickEl(_Menu.Createnewjob);
        }

        [When(@"Verify site Visit in Create new job Screen")]
        public void WhenVerifySiteVisitInCreateNewJobScreen()
        {
            waitTill(_Menu.Verfysitevisit, 10);
            isThisShown(_Menu.Verfysitevisit);
        }

        [When(@"Click Reason for job creating manually")]
        public void WhenClickReasonForJobCreatingManually()
        {
            ClickEl(_Menu.Reasonforjobmanually);
        }

        [When(@"Click on the Urgent visit")]
        public void WhenClickOnTheUrgentVisit()
        {
            ClickEl(_Menu.Urgentvisit);
        }
        [Given(@"Click on the Create new Audit")]
        public void GivenClickOnTheCreateNewAudit()
        {
            ClickEl(_Menu.Createnewaudit);
        }

        [When(@"Verify the Create New Audit Form Screen")]
        public void WhenVerifyTheCreateNewAuditFormScreen()
        {
            waitTill(_Menu.Verifycreatenewauditform, 10);  
            isThisShown(_Menu.Verifycreatenewauditform);
        }
        [Given(@"Click on the sync status")]
        public void GivenClickOnTheSyncStatus()
        {
            ClickEl(_Menu.Syncstatus);
        }

        [When(@"Verify the Sync Status")]
        public void WhenVerifyTheSyncStatus()
        {
            waitTill(_Menu.VerifySyncstatus,10);
            isThisShown(_Menu.VerifySyncstatus);
        }
        
        [When(@"Click on the back icon in sync")]
        public void WhenClickOnTheBackIconInSync()
        {
            ClickEl(_Menu.syncbackicon);
        }

        [Given(@"Click on the message")]
        public void GivenClickOnTheMessage()
        {
            ScRolltopageend();
            ClickEl(_Menu.Message);
        }

        [When(@"Verify the message screen")]
        public void WhenVerifyTheMessageScreen()
        {
            waitTill(_Menu.verifymessage,10);
            ClickEl(_Menu.verifymessage);
        }

        [When(@"Verify the Info Container")]
        public void WhenVerifyTheInfoContainer()
        {
            waitTill(_Menu.Verifyinfocontainer,10);
            isThisShown(_Menu.Verifyinfocontainer);

        }

        [When(@"Click on the Info Container")]
        public void WhenClickOnTheInfoContainer()
        {
            ClickEl(_Menu.infocontainer);
        }

        [When(@"Verify the Message details")]
        public void WhenVerifyTheMessageDetails()
        {
            waitTill(_Menu.Verifymessagedetails,10);
            isThisShown (_Menu.Verifymessagedetails);
        }


        [When(@"Enter the Comments in message")]
        public void WhenEnterTheCommentsInMessage()
        {
            actionType(_Menu.comment, getConfigVal("Comment"));
        }

        [When(@"Click on the Plus icon")]
        public void WhenClickOnThePlusIcon()
        {
            ClickEl(_Menu.plusicon);
        }

        [When(@"Verift the Member one text")]
        public void WhenVeriftTheMemberOneText()
        {
            waitTill(_Menu.verifymember,10);
            isThisShown(_Menu.verifymember);
        }

        [When(@"Click on the Edit button")]
        public void WhenClickOnTheEditButton()
        {
            ClickEl(_Menu.Edit);
        }

        [When(@"Verify Acknowledge")]
        public void WhenVerifyAcknowledge()
        {
            waitTill(_Menu.verifyAcknowledge, 10);
            isThisShown(_Menu.verifyAcknowledge);
        }

        [When(@"Enter the CSSID in Acknowledge Screen")]
        public void WhenEnterTheCSSIDInAcknowledgeScreen()
        {
            ClickEl(_Menu.CSSID);
            Actiondownandenter();
        }

        [When(@"Click on the signature in Acknowledge")]
        public void WhenClickOnTheSignatureInAcknowledge()
        {
            ClickEl(_Menu.signature);
        }

        [When(@"Click on the Acknowledgment button")]
        public void WhenClickOnTheAcknowledgmentButton()
        {
            ClickEl(_Menu.Acknowledgment);
        }

        [When(@"Click on the Acknowledge button in message")]
        public void WhenClickOnTheAcknowledgeButtonInMessage()
        {
            ScRolltopageend();
            ClickEl(_Menu.Acknowledge);
        }

        [Then(@"Click on the back button in message screen")]
        public void ThenClickOnTheBackButtonInMessageScreen()
        {
            ClickEl(_Menu.backbuttonmessage);
        }




        [Given(@"Click on the HSEQ HUb")]
        public void GivenClickOnTheHSEQHUb()
        {
            ScRolltopageend();
            ClickEl(_Menu.HSEQhub);
        }

        [When(@"Verify HSEQ Screen")]
        public void WhenVerifyHSEQScreen()
        {
            waitTill(_Menu.verifyHSEQ,10);
            isThisShown(_Menu.verifyHSEQ);
        }

        [When(@"Enter text field in HSEQ")]
        public void WhenEnterTextFieldInHSEQ()
        {
            ClickEl(_Menu.Searchfield);
            actionType(_Menu.Searchfield, getConfigVal("HSEQTEST"));
        }

        [When(@"Click on the item")]
        public void WhenClickOnTheItem()
        {
            ClickEl(_Menu.itemtitle);
        }

        [When(@"Verify the PDF view")]
        public void WhenVerifyThePDFView()
        {
            //waitTill(_Menu.VerifyPdfview,10);
            //isThisShown(_Menu.VerifyPdfview);
        }

        [Then(@"Click on the back icon in HSEQ screen")]
        public void ThenClickOnTheBackIconInHSEQScreen()
        {
            ClickEl(_Menu.backiconHSEQ);
        }


    }
}
