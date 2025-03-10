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
        public string verifyactivetask = "//*[@text='Active Task']";
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

        public string Jobpack = "//*[contains(@text, 'is it ok to proceed?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRdoBtn']";
        public string Accesstojob = "//*[contains(@text, 'obstruction or hindrance?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRdoBtn']";
        //site survey
        public string Adequatesite = "//*[contains(@text, 'survey been completed?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRdoBtn']";
        public string duringsite = "//*[contains(@text, 'during the site survey?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRdoBtn']";
        public string asbestos = "//*[contains(@text, 'disturb the asbestos?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/noRdoBtn']";
        //Site documentation
        public string Registeravailablesite = "//*[contains(@text, 'available on site?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRdoBtn']";
        public string Managementplan = "//*[contains(@text, 'management plan in place?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRdoBtn']";
        public string Fireriskassesment = "//*[contains(@text, 'Fire Risk Assessment')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/noRdoBtn']";
        //Cable Routes
        public string cablerouteidentified = "//*[contains(@text, 'routes been identified?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRdoBtn']";
        public string cableentries = "//*[contains(@text, 'survey accessible Safely?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRdoBtn']";
        public string Safeaccess = "//*[contains(@text, 'cable route been identified?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRdoBtn']";
        public string Anyexistingcable = "//*[contains(@text, 'identified cable routes?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/noRdoBtn']";
        public string Exsitingfirestopping = "//*[contains(@text, 'affected by our works?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/noRdoBtn']";
        //Documentation
        public string TaskRAandms = "//*[contains(@text, 'Task RA & MS')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRdoBtn']";
        //Work guarding & Access
        public string Workareaguarded = "//*[contains(@text, 'including materials?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRdoBtn']";
        public string Clearofobstruction = "//*[contains(@text, 'clear of obstruction?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRdoBtn']";
        public string Publicaccess = "//*[contains(@text, 'maintained Safely?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRdoBtn']";
        public string Safeaccessunderground = "//*[contains(@text, 'plant rooms?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRdoBtn']";
        //street works
        public string generalpublic = "//*[contains(@text, 'general public?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRdoBtn']";
        //competency
        public string Operativeonsite = "//*[contains(@text, 'relevant accreditations?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRdoBtn']";
        public string RequiredlevelDBS = "//*[contains(@text, 'required level DBS/security')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRdoBtn']";
        //plant
        public string Dailypreusechecks = "//*[contains(@text, 'Have daily pre use checks')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRdoBtn']";
        public string Plantimpacts = "//*[contains(@text, 'plant & equipment?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/noRdoBtn']";
        public string Adequatesaftey = "//*[contains(@text, 'adequate safety zone')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRdoBtn']";
        public string plantbeingusedexcavating = "//*[contains(@text, 'manufacturer’s instructions?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRdoBtn']";
        //Building services
        public string Plantpresent = "//*[contains(@text, 'plant Present?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/noRdoBtn']";
        public string heatingpipepresent = "//*[contains(@text, 'heating pipe present?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/noRdoBtn']";
        public string networkcablepresent = "//*[contains(@text, 'network cables present?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/noRdoBtn']";
        public string Gaspipepresent = "//*[contains(@text, 'Gas Pipe present?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/noRdoBtn']";
        public string servicerequired = "//*[contains(@text, 'service required?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/noRdoBtn']";
        //Equipment and PPE
        public string relevantPPE = "//*[contains(@text, 'relevant PPE / Equipment available')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRdoBtn']";
        public string specialitypperequired = "//*[contains(@text, 'Is specialist PPE required?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/noRdoBtn']";
        public string insulatedtools = "//*[contains(@text, 'Insulated tools')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/NARdoBtn']";
        public string watersuppression = "//*[contains(@text, 'Water suppression equipment')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/NARdoBtn']";
        public string headgducalibration = "//*[contains(@text, '4 head GDU Calibration')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/NARdoBtn']";
        //working in lofts or ceiling voids welfare
        public string Scrolllight = "//*[@text=\"Is there sufficient Lighting? *\"]";
        public string egressloft = "//*[contains(@text, 'Egress to the loft?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/NARdoBtn']";
        public string loftfull = "//*[contains(@text, 'Is the loft full')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/NARdoBtn']";
        public string Sufficientlighting = "//*[contains(@text, 'sufficient Lighting?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/NARdoBtn']";
        public string evidenceofvermin = "//*[contains(@text, 'evidence of Vermin?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/NARdoBtn']";
        public string waspnests = "//*[contains(@text, 'wasp nests?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/NARdoBtn']";
        public string buildupdust = "//*[contains(@text, 'dust in the work area?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/NARdoBtn']";
        public string safetymanplace = "//*[contains(@text, 'Safety man in place?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/NARdoBtn']";
        //Enviroment
        public string productspeciesbats = "//*[contains(@text, 'protect species such as Bats?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/NARdoBtn']";
        public string Spillkitsinstrument = "//*[contains(@text, 'Are spill kits')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/NARdoBtn']";
        public string Enviromentalissues = "//*[contains(@text, 'environmental issues?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/NARdoBtn']";
        //other risk in comments
        public string Coveredadditionalrisk = "//*[contains(@text, 'risks in the comments?')]/parent::*/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/noRdoBtn']";
        public string Complete = "//*[@text=\"Complete\"]";
        public string backbutton = "com.mobile.telent.staging:id/duringWorkCommonBackButton";

        // Site Setup
        public string Sitesetup = "//*[@text=\"Site Set-up\"]";
        public string Signslightsandguarding = "//*[@text=\"Signs, Lighting and Guarding\"]";
        public string verifySignslights = "(//*[@text='Signs, Lighting and Guarding'])[2]";
        //SL and G
        public string Speedlimit = "//*[@text=\"20\"]";
        public string thirdparty = "//*[contains(@text, 'At least 1 photo required for \"Has site set-up')]/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/noRadio']";
        public string Diversionsignsplace = "//*[contains(@text, 'road closure with Diversion signs in place?\"?')]/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/noRadio']";
        public string rollingroadworks = "//*[contains(@text, 'At least 1 photo required for \"Is this a rolling')]/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/noRadio']";
        public string Sitebeingworkedtoday = "//*[@text=\"1\"]";
        public string SLGapproach = "//*[@text=\"SLG Approach 1\"]";
        public string advanceapproch = "//*[contains(@text, 'At least 1 photo required for \"Are advance warning')]/following-sibling::*/descendant::*[@resource-id='com.mobile.telent.staging:id/yesRadio']";
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
        public string Verifychooseworkitems = "//*[@text='Choose Work Items']";
        public string Add = "com.mobile.telent.staging:id/add_items";
        public string Workitemtextfield = "com.mobile.telent.staging:id/auto_txt";
        public string Additem = "//*[@text='Add Item']";
        public string plusicon = "(//*[@text='+'])[2]";
        public string Arrowbutton = "com.mobile.telent.staging:id/poiFormbtn";
        public string capturecamera = "com.mobile.telent.staging:id/cameraCaptureButton";
        public string comment = "(//android.widget.EditText)[1]";
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
        public string finshonsiteyesbutton = "com.mobile.telent.staging:id/yesRdoBtn";
        public string DropdownonSiteAction = "com.mobile.telent.staging:id/text_input_end_icon";


    }
}