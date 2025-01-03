using CPT_Mobile_Test.CorpWeb.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestAutomation.Common;

namespace CPT_Mobile_Test
{
    [Binding]
    public class MWFformsStepDefinitions:Base
    {
        MWFforms _MWF = new MWFforms();

        [Given(@"Click on the List of Task")]
        public void GivenClickOnTheListOfTask()
        {
            ClickEl(_MWF.Listoftask);
        }

        [When(@"click on the Order Number")]
        public void WhenClickOnTheOrderNumber()
        {
            ClickEl(_MWF.Orderno);
        }

        [When(@"Click on the site visits")]
        public void WhenClickOnTheSiteVisits()
        {
            ClickEl(_MWF.Sitevisits);
        }

        [When(@"Click on the Add visits")]
        public void WhenClickOnTheAddVisits()
        {
            ClickEl(_MWF.Addvisit);
        }

        [When(@"Click on the POWRA")]
        public void WhenClickOnThePOWRA()
        {
            ClickEl(_MWF.POWRA);
        }

        [When(@"Click on the Incomplete")]
        public void WhenClickOnTheIncomplete()
        {
            ClickEl(_MWF.incomplete);
        }

        [When(@"Click on the View button")]
        public void WhenClickOnTheViewButton()
        {
            ClickEl(_MWF.view);
        }

        [When(@"Click on the Weather conditions")]
        public void WhenClickOnTheWeatherConditions()
        {
            ClickEl(_MWF.weathercondition);
        }

        [When(@"Select the Weather Conditions")]
        public void WhenSelectTheWeatherConditions()
        {
            ClickEl(_MWF.selectweather);
            //WaitForJqueryAjax();
            
            Actiondownandenter();
        }

        [When(@"select the Workstream")]
        public void WhenSelectTheWorkstream()
        {
            ScRolltopageend();
            ClickEl(_MWF.selectworkstream);
            wait(2);
            ClickEl(_MWF.worksteamtypeinternal);
            // dr.FindElement(By.Id("dropdown_id")).Click();

        }
        [When(@"Click on the Yes button in job pack")]
        public void WhenClickOnTheYesButtonInJobPack()
        {
            ScRolltopageend();
            ClickEl(_MWF.Jobpack);
        }

        [When(@"Click on the Yes button in Access to the Job")]
        public void WhenClickOnTheNoButtonInAccessToTheJob()
        {
            ScRolltopageend();
            ClickEl(_MWF.Accesstojob);
        }
        [When(@"Click on the Yes button in Adequate site survey")]
        public void WhenClickOnTheYesButtonInTaskRAMs()
        {
            ScRolltopageend();
            ClickEl(_MWF.Adequatesite);
        }

        [When(@"Click on the Yes button in during site survey")]
        public void WhenClickOnTheYesButtonInManualAndSafetySite()
        {
            ClickEl(_MWF.duringsite);
        }

        [When(@"Click on the No button in work distrub the asbsetos")]
        public void WhenClickOnTheNoButtonInWorkDistrubTheAsbsetos()
        {
            ScRolltopageend();
            ClickEl(_MWF.asbestos);
        }
        [Given(@"Click on the yes button in Asbestos register site")]
        public void GivenClickOnTheYesButtonInAsbestosRegisterSite()
        {
            ScRolltopageend();
            ClickEl(_MWF.Registeravailablesite);
        }
        [Given(@"Click on the Yes button in Asbestos Management plan")]
        public void GivenClickOnTheYesButtonInAsbestosManagementPlan()
        {
            ClickEl(_MWF.Managementplan);
        }
        [Given(@"Click on the No button in Building fire risk Assessment")]
        public void GivenClickOnTheNoButtonInBuildingFireRiskAssessment()
        {
            ClickEl(_MWF.Fireriskassesment);
        }
        [Given(@"Click on the Yes button in cable routes identified")]
        public void GivenClickOnTheYesButtonInCableRoutesIdentified()
        {
            ScRolltopageend();
            ClickEl(_MWF.cablerouteidentified);
        }
        [Given(@"Click on the Yes button in cable Entries and route identified")]
        public void GivenClickOnTheYesButtonInCableEntriesAndRouteIdentified()
        {
            ClickEl(_MWF.cableentries);
        }
        [Given(@"Click on the Yes button in Safe access to cable")]
        public void GivenClickOnTheYesButtonInSafeAccessToCable()
        {
            ClickEl(_MWF.Safeaccess);
        }
        [Given(@"Click on the No button in Any existing cable")]
        public void GivenClickOnTheNoButtonInAnyExistingCable()
        {
            ClickEl(_MWF.Anyexistingcable);
        }
        [Given(@"Click on the No button in will existing fire stopping")]
        public void GivenClickOnTheNoButtonInWillExistingFireStopping()
        {
            ClickEl(_MWF.Exsitingfirestopping);
        }
        [Given(@"Click on the Yes button in Task RA & Ms")]
        public void GivenClickOnTheYesButtonInTaskRAMs()
        {
            ScRolltopageend();
            ClickEl(_MWF.TaskRAandms);
        }
        [Given(@"Click on the Yes button in Work areas guarded")]
        public void GivenClickOnTheYesButtonInWorkAreasGuarded()
        {
            ScRolltopageend();
            ClickEl(_MWF.Workareaguarded);
        }
        [Given(@"Click on the Yes button in Clear of obstruction")]
        public void GivenClickOnTheYesButtonInClearOfObstruction()
        {
            ClickEl(_MWF.Clearofobstruction);
        }
        [Given(@"Click on the Yes button in public access routes")]
        public void GivenClickOnTheYesButtonInPublicAccessRoutes()
        {
            ClickEl(_MWF.Publicaccess);
        }
        [Given(@"Click on the Yes button in Safe access underground cable ducting")]
        public void GivenClickOnTheYesButtonInSafeAccessUndergroundCableDucting()
        {
            ClickEl(_MWF.Safeaccessunderground);
        }
        [Given(@"Click on the Yes button in Risk for general public")]
        public void GivenClickOnTheYesButtonInRiskForGeneralPublic()
        {
            ScRolltopageend();
            ClickEl(_MWF.generalpublic);
        }
        [Given(@"Click on the Yes button in Operatives on site")]
        public void GivenClickOnTheYesButtonInOperativesOnSite()
        {
            ScRolltopageend();
            ClickEl(_MWF.Operativeonsite);
        }
        [Given(@"Click on the Yes button in Required level DBS security")]
        public void GivenClickOnTheYesButtonInRequiredLevelDBSSecurity()
        {
            ClickEl(_MWF.RequiredlevelDBS);
        }
        [Given(@"Click on the Yes button in Daily pre use checks")]
        public void GivenClickOnTheYesButtonInDailyPreUseChecks()
        {
            ScRolltopageend();
            ClickEl(_MWF.Dailypreusechecks);
        }
        [Given(@"Click on the No button in Existing cable or plant impacts")]
        public void GivenClickOnTheNoButtonInExistingCableOrPlantImpacts()
        {
            ClickEl(_MWF.Plantimpacts);
        }
        [Given(@"Click on the Yes button in Adequate safety zone in places")]
        public void GivenClickOnTheYesButtonInAdequateSafetyZoneInPlaces()
        {
            ClickEl(_MWF.Adequatesaftey);
        }
        [Given(@"Click on the Yes button in plant being used excavating")]
        public void GivenClickOnTheYesButtonInPlantBeingUsedExcavating()
        {
            ClickEl(_MWF.plantbeingusedexcavating);
        }
        [Given(@"Click on the No button in Plant present")]
        public void GivenClickOnTheNoButtonInPlantPresent()
        {
            ScRolltopageend();
            ClickEl(_MWF.Plantpresent);
        }

        [Given(@"Click on the No button in heating pipe present")]
        public void GivenClickOnTheNoButtonInHeatingPipePresent()
        {
            ClickEl(_MWF.heatingpipepresent);
        }

        [Given(@"Click on the No button in network cable present")]
        public void GivenClickOnTheNoButtonInNetworkCablePresent()
        {
            ClickEl(_MWF.networkcablepresent);
        }

        [Given(@"Click on the No button in Gas pipe present")]
        public void GivenClickOnTheNoButtonInGasPipePresent()
        {
            ClickEl(_MWF.Gaspipepresent);
        }

        [Given(@"Click on the No button in service required")]
        public void GivenClickOnTheNoButtonInServiceRequired()
        {
            ClickEl(_MWF.servicerequired);
        }

        [Given(@"Click on the yes button in relevant PPE")]
        public void GivenClickOnTheYesButtonInRelevantPPE()
        {
            ScRolltopageend();
            ScRolltopageend();
            ClickEl(_MWF.relevantPPE);
        }

        [Given(@"Click on the No button in specialist PPE required")]
        public void GivenClickOnTheNoButtonInSpecialistPPERequired()
        {
            ClickEl(_MWF.specialitypperequired);
        }

        [Given(@"Click on the N/A button in Insulated tools")]
        public void GivenClickOnTheNAButtonInInsulatedTools()
        {
            ClickEl(_MWF.insulatedtools);
        }

        [Given(@"Click on the N/A button in Water suppression equipment")]
        public void GivenClickOnTheNAButtonInWaterSuppressionEquipment()
        {
            ClickEl(_MWF.watersuppression);
        }

        [Given(@"Click on the N/A button in head GDU calibration")]
        public void GivenClickOnTheNAButtonInHeadGDUCalibration()
        {
            ScRolltopageend();
            ClickEl(_MWF.headgducalibration);
        }

        [Given(@"Click on the N/A button in egress to the loft")]
        public void GivenClickOnTheNAButtonInEgressToTheLoft()
        {
            ScRolltopageend();
            ClickEl(_MWF.egressloft);
        }

        [Given(@"Click on the N/A button in Is the loft full")]
        public void GivenClickOnTheNAButtonInIsTheLoftFull()
        {
            ClickEl(_MWF.loftfull);
        }

        [Given(@"Click on the N/A button in Sufficient lighting")]
        public void GivenClickOnTheNAButtonInSufficientLighting()
        {
            ClickEl(_MWF.Sufficientlighting);
        }

        [Given(@"Click on the N/A button in evidence of vermin")]
        public void GivenClickOnTheNAButtonInEvidenceOfVermin()
        {
            ClickEl(_MWF.evidenceofvermin);
        }

        [Given(@"Click on the N/A button in wasp nests")]
        public void GivenClickOnTheNAButtonInWaspNests()
        {
            ClickEl(_MWF.waspnests);
        }

        [Given(@"Click on the N/A button in build up of dust work area")]
        public void GivenClickOnTheNAButtonInBuildUpOfDustWorkArea()
        {
            ScRolltopageend();
            ClickEl(_MWF.buildupdust);
        }

        [Given(@"Click on the N/A button in safety man place")]
        public void GivenClickOnTheNAButtonInSafetyManPlace()
        {
            ClickEl(_MWF.safetymanplace);
        }

        [Given(@"Click on the N/A button in product species bats")]
        public void GivenClickOnTheNAButtonInProductSpeciesBats()
        {
            ScRolltopageend();
            ClickEl(_MWF.productspeciesbats);
        }

        [Given(@"Click on the N/A button in Spill kits instrument")]
        public void GivenClickOnTheNAButtonInSpillKitsInstrument()
        {
            ClickEl(_MWF.Spillkitsinstrument);
        }

        [Given(@"Click on the N/A button in Enviromental issues")]
        public void GivenClickOnTheNAButtonInEnviromentalIssues()
        {
            ClickEl(_MWF.Enviromentalissues);
        }
        [Given(@"Click on the No button in Covereda dditional risk")]
        public void GivenClickOnTheNoButtonInCoveredaDditionalRisk()
        {
            ScRolltopageend();
            ClickEl(_MWF.Coveredadditionalrisk);
        }
        [StepDefinition(@"Click on the Complete button")]
        public void GivenClickOnTheCompleteButton()
        {
            ClickEl(_MWF.Complete);
        }

        [StepDefinition(@"Click on the back button icon")]
        public void ThenClickIonTheBackButtonInPOWRAForm()
        {
            ClickEl(_MWF.backbutton);
        }

        [Given(@"Click on the Site setup")]
        public void GivenClickOnTheSiteSetup()
        {
            ClickEl(_MWF.Sitesetup);
        } 

        [When(@"Click on the Signs Lights and guarding")]
        public void WhenClickOnTheSignsLightsAndGuarding()
        {
            ClickEl(_MWF.Signslightsandguarding);
        }

        [When(@"Click on the twenty in Speed limit")]
        public void WhenClickOnTheTwentyInSpeedLimit()
        {
            ClickEl(_MWF.Speedlimit);
        }
        [When(@"Click on the No button in site setup third party")]
        public void WhenClickOnTheNoButtonInSiteSetupThirdParty()
        {
            ClickEl(_MWF.thirdparty);
        }

        [When(@"Click on the No button in Closure diversion signs in place")]
        public void WhenClickOnTheNoButtonInClosureDiversionSignsInPlace()
        {
            ClickEl(_MWF.Diversionsignsplace);                
        }

        [When(@"Click on the No button in rolling road works")]
        public void WhenClickOnTheNoButtonInRollingRoadWorks()
        {
            ClickEl(_MWF.rollingroadworks);
        }

        [When(@"Click on the one Radio button in confirm number of approaches")]
        public void WhenClickOnTheOneRadioButtonInConfirmNumberOfApproaches()
        {
            ScRolltopageend();
            ClickEl(_MWF.Sitebeingworkedtoday);
        }
        [When(@"Click on the SLG approach")]
        public void WhenClickOnTheSLGApproach()
        {
            ClickEl(_MWF.SLGapproach);
        }

        [When(@"Click on the Yes Radio button in Advace warning")]
        public void WhenClickOnTheYesRadioButtonInAdvaceWarning()
        {
            ClickEl(_MWF.advanceapproch);
        }
        [StepDefinition(@"Click on the Camera fields")]
        public void WhenClickOnTheCameraFields()
        {
            ClickEl(_MWF.camerafield);
        }

        [When(@"Click on the NO Radio button in Closed the footpath")]
        public void WhenClickOnTheNORadioButtonInClosedTheFootpath()
        {
            ClickEl(_MWF.Closedfoodway);
        }
        [When(@"Click on the No Radio button in vachile parked on site")]
        public void WhenClickOnTheNoRadioButtonInVachileParkedOnSite()
        {
            ScRolltopageend();
            ClickEl(_MWF.vechilparkedonsite);
        }
        [When(@"Click on the Camera fields in parkingbays and cycle ways")]
        public void WhenClickOnTheCameraFieldsInParkingbaysAndCycleWays()
        {
            ScRolltopageend();
            ClickEl(_MWF.cycleways);
        }
        [Given(@"Click on the Before starting woek")]
        public void GivenClickOnTheBeforeStartingWoek()
        {
            ClickEl(_MWF.Beforestatingwork);
        }

        [When(@"Click on the No button in installation")]
        public void WhenClickOnTheNoButtonInInstallation()
        {
            ClickEl(_MWF.inatallation);
        }
        [Given(@"Click on the Permission to proceed")]
        public void GivenClickOnThePermissionToProceed()
        {
            ClickEl(_MWF.Permissionproceed);
        }
        [Given(@"Click on the signature in Site setup")]
        public void GivenClickOnTheSignatureInSiteSetup()
        {
            ClickEl(_MWF.sitesetupsignature);
        }

        [When(@"Click on the Sign image")]
        public void WhenClickOnTheSignImage()
        {
            ClickEl(_MWF.Signimage);
        }

        [When(@"Click on the Done button on signature")]
        public void WhenClickOnTheDoneButtonOnSignature()
        {
            ClickEl(_MWF.Donebutton);
        }

        [Given(@"Click on the During work")]
        public void GivenClickOnTheDuringWork()
        {
            ClickEl(_MWF.Duringwork);
        }

        [When(@"Click on the No Radio button in Todays work completed job")]
        public void WhenClickOnTheNoRadioButtonInTodaysWorkCompletedJob()
        {
            ClickEl(_MWF.Todaysworkcompletedjob);
        }

        [When(@"Click on the No Radio button in Additional work been completed")]
        public void WhenClickOnTheNoRadioButtonInAdditionalWorkBeenCompleted()
        {
            ClickEl(_MWF.Additionalworkbeencompleted);
        }

        [When(@"Click on the Camera button")]
        public void WhenClickOnTheCameraButton()
        {
            ScRolltopageend();
            ClickEl(_MWF.Camera);
        }

        [When(@"Click on the Capture the photo")]
        public void WhenClickOnTheCaptureThePhoto()
        {
            ClickEl(_MWF.Capture);
        }
        [When(@"Enter the Comments")]
        public void WhenEnterTheComments()
        {
            ClickEl(_MWF.Comments);
            typeText(_MWF.Comments, getConfigVal("Comment"));
            dr.HideKeyboard();
        }
        [Given(@"Click on the TDFS")]
        public void GivenClickOnTheTDFS()
        {
            ClickEl(_MWF.TDFS);
        }

        [When(@"Click on the Supporting photos")]
        public void WhenClickOnTheSupportingPhotos()
        {
            ClickEl(_MWF.Supportingphotos);
        }
        [Given(@"Click on the Finish on site")]
        public void GivenClickOnTheFinishOnSite()
        {
            ClickEl(_MWF.finishonsite);
        }


    }
}
