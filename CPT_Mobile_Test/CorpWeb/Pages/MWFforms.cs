using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPT_Mobile_Test.CorpWeb.Pages
{
    public class MWFforms
    {
        public string Listoftask = "//*[@text=\"List of Tasks\"]";
        public string Orderno = "//*[@text=\"Order No\"]";
        public string Sitevisits = "//*[@text=\"Site Visits\"]";
        public string Addvisit = "//*[@text=\"Add Visit\"]";
        public string POWRA = "//*[@text=\"POWRA\"]";
        public string incomplete = "//*[@text=\"Incomplete\"]";
        public string view = "//*[@text=\"View\"]";
        public string weathercondition = "//*[@text=\"Weather Conditions\"]";
        public string selectweather = "(//*[@resource-id=\"com.mobile.telent.staging:id/text_input_end_icon\"])[1]";
        public string selectworkstream = "(//*[@resource-id=\"com.mobile.telent.staging:id/text_input_end_icon\"])[2]";
        public string worksteamtypeinternal = "//*[@text=\"Hot\"]";

        public string Jobpack = "com.mobile.telent.staging:id/yesRdoBtn";
        public string Accesstojob = "(//*[@resource-id=\"com.mobile.telent.staging:id/yesRdoBtn\"])[2]";
        //site survey
        public string Adequatesite = "(//*[@resource-id=\"com.mobile.telent.staging:id/yesRdoBtn\"])[3]";
        public string duringsite = "(//*[@resource-id=\"com.mobile.telent.staging:id/yesRdoBtn\"])[4]";
        public string asbestos = "(//*[@resource-id=\"com.mobile.telent.staging:id/noRdoBtn\"])[5]";
        //Site documentation
        public string Registeravailablesite = "(//*[@resource-id=\"com.mobile.telent.staging:id/yesRdoBtn\"])[4]";
        public string Managementplan = "(//*[@resource-id=\"com.mobile.telent.staging:id/yesRdoBtn\"])[5]";
        public string Fireriskassesment = "(//*[@resource-id=\"com.mobile.telent.staging:id/noRdoBtn\"])[6]";
        //Cable Routes
        public string cablerouteidentified = "(//*[@resource-id=\"com.mobile.telent.staging:id/yesRdoBtn\"])[2]";
        public string cableentries = "(//*[@resource-id=\"com.mobile.telent.staging:id/yesRdoBtn\"])[3]";
        public string Safeaccess = "(//*[@resource-id=\"com.mobile.telent.staging:id/yesRdoBtn\"])[4]";
        public string Anyexistingcable = "(//*[@resource-id=\"com.mobile.telent.staging:id/noRdoBtn\"])[5]";
        public string Exsitingfirestopping = "(//*[@resource-id=\"com.mobile.telent.staging:id/noRdoBtn\"])[6]";
        //Documentation
        public string TaskRAandms = "(//*[@resource-id=\"com.mobile.telent.staging:id/yesRdoBtn\"])[5]";
        //Work guarding & Access
        public string Workareaguarded = "(//*[@resource-id=\"com.mobile.telent.staging:id/yesRdoBtn\"])[2]";
        public string Clearofobstruction = "(//*[@resource-id=\"com.mobile.telent.staging:id/yesRdoBtn\"])[3]";
        public string Publicaccess = "(//*[@resource-id=\"com.mobile.telent.staging:id/yesRdoBtn\"])[4]";
        public string Safeaccessunderground = "(//*[@resource-id=\"com.mobile.telent.staging:id/yesRdoBtn\"])[5]";
        //street works
        public string generalpublic = "(//*[@resource-id=\"com.mobile.telent.staging:id/yesRdoBtn\"])[5]";
        //competency
        public string Operativeonsite = "(//*[@resource-id=\"com.mobile.telent.staging:id/yesRdoBtn\"])[4]";
        public string RequiredlevelDBS = "(//*[@resource-id=\"com.mobile.telent.staging:id/yesRdoBtn\"])[5]";
        //plant
        public string Dailypreusechecks = "(//*[@resource-id=\"com.mobile.telent.staging:id/yesRdoBtn\"])[2]";
        public string Plantimpacts = "(//*[@resource-id=\"com.mobile.telent.staging:id/noRdoBtn\"])[3]";
        public string Adequatesaftey = "(//*[@resource-id=\"com.mobile.telent.staging:id/yesRdoBtn\"])[4]";
        public string plantbeingusedexcavating = "(//*[@resource-id=\"com.mobile.telent.staging:id/yesRdoBtn\"])[5]";
        //Building services
        public string Plantpresent = "(//*[@resource-id=\"com.mobile.telent.staging:id/noRdoBtn\"])[2]";
        public string heatingpipepresent = "(//*[@resource-id=\"com.mobile.telent.staging:id/noRdoBtn\"])[3]";
        public string networkcablepresent = "(//*[@resource-id=\"com.mobile.telent.staging:id/noRdoBtn\"])[4]";
        public string Gaspipepresent = "(//*[@resource-id=\"com.mobile.telent.staging:id/noRdoBtn\"])[5]";
        public string servicerequired = "(//*[@resource-id=\"com.mobile.telent.staging:id/noRdoBtn\"])[6]";
        //Equipment and PPE
        public string relevantPPE = "(//*[@resource-id=\"com.mobile.telent.staging:id/yesRdoBtn\"])[1]";
        public string specialitypperequired = "(//*[@resource-id=\"com.mobile.telent.staging:id/noRdoBtn\"])[2]";
        public string insulatedtools = "(//*[@resource-id=\"com.mobile.telent.staging:id/NARdoBtn\"])[2]";
        public string watersuppression = "(//*[@resource-id=\"com.mobile.telent.staging:id/NARdoBtn\"])[3]";
        public string headgducalibration = "(//*[@resource-id=\"com.mobile.telent.staging:id/NARdoBtn\"])[4]";
        //working in lofts or ceiling voids welfare
        public string Scrolllight = "//*[@text=\"Is there sufficient Lighting? *\"]";
        public string egressloft = "(//*[@resource-id=\"com.mobile.telent.staging:id/NARdoBtn\"])[2]";
        public string loftfull = "(//*[@resource-id=\"com.mobile.telent.staging:id/NARdoBtn\"])[3]";
        public string Sufficientlighting = "(//*[@resource-id=\"com.mobile.telent.staging:id/NARdoBtn\"])[4]";
        public string evidenceofvermin = "(//*[@resource-id=\"com.mobile.telent.staging:id/NARdoBtn\"])[5]";
        public string waspnests = "(//*[@resource-id=\"com.mobile.telent.staging:id/NARdoBtn\"])[6]";
        public string buildupdust = "(//*[@resource-id=\"com.mobile.telent.staging:id/NARdoBtn\"])[5]";
        public string safetymanplace = "(//*[@resource-id=\"com.mobile.telent.staging:id/NARdoBtn\"])[6]";
        //Enviroment
        public string productspeciesbats = "(//*[@resource-id=\"com.mobile.telent.staging:id/NARdoBtn\"])[4]";
        public string Spillkitsinstrument = "(//*[@resource-id=\"com.mobile.telent.staging:id/NARdoBtn\"])[5]";
        public string Enviromentalissues = "(//*[@resource-id=\"com.mobile.telent.staging:id/NARdoBtn\"])[6]";
        //other risk in comments
        public string Coveredadditionalrisk = "(//*[@resource-id=\"com.mobile.telent.staging:id/noRdoBtn\"])[5]";
        public string Complete = "//*[@text=\"Complete\"]";
        public string backbutton = "com.mobile.telent.staging:id/duringWorkCommonBackButton";

        // Site Setup
        public string Sitesetup = "//*[@text=\"Site Set-up\"]";
        public string Signslightsandguarding = "//*[@text=\"Signs, Lighting and Guarding\"]";
        //SL and G
        public string Speedlimit = "//*[@text=\"20\"]";
        public string thirdparty = "(//*[@resource-id=\"com.mobile.telent.staging:id/noRadio\"])[1]";
        public string Diversionsignsplace = "(//*[@resource-id=\"com.mobile.telent.staging:id/noRadio\"])[2]";
        public string rollingroadworks = "(//*[@resource-id=\"com.mobile.telent.staging:id/noRadio\"])[3]";
        public string Sitebeingworkedtoday = "//*[@text=\"1\"]";
        public string SLGapproach = "//*[@text=\"SLG Approach 1\"]";
        public string advanceapproch = "(//*[@resource-id=\"com.mobile.telent.staging:id/yesRadio\"])[1]";
        public string camerafield = "com.mobile.telent.staging:id/imageChooseIV";
        public string Closedfoodway = "(//*[@resource-id=\"com.mobile.telent.staging:id/noRadio\"])[2]";
        public string vechilparkedonsite = "(//*[@resource-id=\"com.mobile.telent.staging:id/noRadio\"])[1]";
        public string cycleways = "(//*[@resource-id=\"com.mobile.telent.staging:id/imageChooseIV\"])[2]";

        // Before starting work
        public string Beforestatingwork = "//*[@text=\"Before Starting Work\"]";
        public string inatallation = "com.mobile.telent.staging:id/noRadio";

        // permission to proceed
        public string Permissionproceed = "//*[@text=\"Permission To Proceed \"]";
        //Signature
        public string sitesetupsignature = "//*[@text=\"Signature\"]";
        public string Signimage = "com.mobile.telent.staging:id/signImage";
        public string Donebutton = "//*[@text=\"Done\"]";

        //During work
        public string Duringwork = "//*[@text=\"During Work\"]";
        public string Todaysworkcompletedjob = "(//*[@resource-id=\"com.mobile.telent.staging:id/noRdoBtn\"])[1]";
        public string Additionalworkbeencompleted = "(//*[@resource-id=\"com.mobile.telent.staging:id/noRdoBtn\"])[2]";
        public string Camera = "//android.widget.TextView[@text='Camera']";
        public string Capture = "com.mobile.telent.staging:id/iv_capture_image";
        public string Comments = "com.mobile.telent.staging:id/comments";

        //TDFS
        public string TDFS = "//*[@text=\"TDFS\"]";
        public string Supportingphotos = "com.mobile.telent.staging:id/r_reshell_camera_btn_finish";

        //Finish on site
        public string finishonsite = "//*[@text=\"Finish On Site\"]";

    }
}
