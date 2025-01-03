using CPT_Mobile_Test.CorpWeb.Pages;
using System;
using TechTalk.SpecFlow;
using TestAutomation.Common;

namespace CPT_Mobile_Test
{
    [Binding]
    public class AuditInprogressformStepDefinitions:Base
    {
        AuditInprogressform _Inprogress = new AuditInprogressform();

        [StepDefinition(@"Select Audit type in Inprogress")]
        public void WhenSelectAuditTypeInInprogress()
        {
            ClickEl(_Inprogress.Audittype);
            ClickEl(_Inprogress.Inprogressform);
        }
        [When(@"select the Cable in primary Type")]
        public void WhenSelectTheCableInPrimaryType()
        {
           ClickEl(_Inprogress.Cable);
        }
        [Given(@"Click on the Cable Jointing Performance")]
        public void GivenClickOnTheCableJointingPerformance()
        {
            ClickEl(_Inprogress.cablejointing)
;        }


    }



}
