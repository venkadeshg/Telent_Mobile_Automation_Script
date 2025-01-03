using CPT_Mobile_Test.CorpWeb.Pages;
using System;
using TechTalk.SpecFlow;
using TestAutomation.Common;

namespace CPT_Mobile_Test
{
    [Binding]
    public class AuditRetrospectiveformStepDefinitions:Base
    {
        AuditRetrospectiveform _retro = new AuditRetrospectiveform();

        [When(@"Select the Retrospective in Audit forms")]
        public void WhenSelectTheRetrospectiveInAuditForms()
        {
            ClickEl(_retro.Retrospecive);
        }
        [Given(@"Click on the Job validation")]
        public void GivenClickOnTheJobValidation()
        {
            ClickEl(_retro.jobvalidation);
        }
        [Given(@"Click on the A five five in job validation")]
        public void GivenClickOnTheAFiveFiveInJobValidation()
        {
            ClickEl(_retro.A55);
        }
        [Given(@"click on the UG CABLING")]
        public void GivenClickOnTheUGCABLING()
        {
            ClickEl(_retro.ugcabeling);
        }
        [Given(@"click on the Form UG CABLING")]
        public void GivenClickOnTheFormUGCABLING()
        {
            ClickEl(_retro.formugcabeling);
        }


    }
}
