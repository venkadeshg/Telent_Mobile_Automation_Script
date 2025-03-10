using AventStack.ExtentReports;
using AventStack.ExtentReports.MarkupUtils;
using BrowserStack;
using CPT_Mobile_Test.CorpWeb.Pages;
using Google.Protobuf.WellKnownTypes;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading;

using TechTalk.SpecFlow;
using static Microsoft.AspNetCore.Razor.Language.TagHelperMetadata;
using EdgeOptions = Microsoft.Edge.SeleniumTools.EdgeOptions;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using Path = System.IO.Path;

namespace TestAutomation.Common
{
    public class Base
    {
        public static AndroidDriver<AppiumWebElement> dr = null;
        public static IOSDriver<AppiumWebElement> iOSdr = null;
        public static AppiumWebElement mobileElement;
        public static string br;
        public static string url;
        public static string brNm;
        public static string brVer;
        public static string appVer;
        public static WebDriverWait wt = null;
        public static IJavaScriptExecutor js = null;
        public static Actions ac = null;
        public static IAlert alert = null;
        public static Random rand = new Random();
        public static ITouchAction touchAction = null;
        public static Process exeProc;

        public static ExtentTest FeatureName;
        public static ExtentTest scenarioName;
        public static ScenarioContext scenarioContext;
        public static ExtentTest logg = null;
        public static ExtentReports Extent = new ExtentReports();

        public static DataTable xltbl = new DataTable();
        public static string sceneStat;

       

        public static int webdriverWaitTimeInSeconds = 5;
        //public static string pth = AppDomain.CurrentDomain.BaseDirectory;
        public static string dPath = "C:\\TestAutomation" + "\\" + DateTime.Now.ToString("dd-MM-yyyy");

        public static string pth = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\"));
        public static string rPath = pth + "TestResults\\" + DateTime.Now.ToString("yyyy-MM-dd_") + DateTime.Now.ToString("HH") + "h" + DateTime.Now.ToString("mm") + "m";

        static GeneralLibraries GL = new GeneralLibraries();

        public enum logTyp { Console, Info, Error, Fail, Fatal, Warn, Skip, Pass, PassRest, Stop, Ignore, Success, Logs, Err, WarnS }

        /*---Initializing webdriver object--*/
        //Objective: This method starts the MobileApp based on MobileOS value in Test.properties file, also initalizes javascript, action, webdriver wait objects at once.
        public static void MobileApp(string app)
        {
            try
            {           

            if (app.Equals("TelentEmulator"))
            {
                AppiumOptions cap = new AppiumOptions();

                cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Pixel 7");
                cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
                cap.AddAdditionalCapability(MobileCapabilityType.AutomationName, "uiautomator2");
                cap.AddAdditionalCapability(MobileCapabilityType.App, "C:\\Personal document\\Automation script\\BEEMobile.apk");                
                cap.AddAdditionalCapability("autoGrantPermissions", true);
                    cap.AddAdditionalCapability(MobileCapabilityType.NewCommandTimeout, 40000);
                    cap.AddAdditionalCapability(AndroidMobileCapabilityType.AndroidDeviceReadyTimeout, 40000);
                    cap.AddAdditionalCapability(AndroidMobileCapabilityType.AndroidInstallTimeout, 40000);
                    //cap.AddAdditionalCapability("autoGrantPermissions", "true");
                    cap.AddAdditionalCapability(AndroidMobileCapabilityType.AutoGrantPermissions, true);

                    cap.AcceptInsecureCertificates = true;
                Console.WriteLine("Initializing Appium driver");
                dr = new AndroidDriver<AppiumWebElement>(new Uri("http://localhost:4723/wd/hub"), cap);
                Console.WriteLine("App launched successfully.");

                    //_appiumLocalService = new AppiumServiceBuilder().UsingAnyFreePort().Build();
                    //_appiumLocalService.Start();
                    //var AppiumService = new AppiumServiceBuilder().WithIPAddress("127.0.0.1").UsingPort(4723).Build();
                    //if (!AppiumService.IsRunning)
                    //AppiumService.Start();

                    //startEmulator(); wait(5);
                    //killAllNodes();
                    //dr = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);

                //dr = new AndroidDriver<AppiumWebElement>(AppiumService, cap); wait(5);
                //assign driver object to javascript and action class
                js = (IJavaScriptExecutor)dr;
                ac = new Actions(dr);
                touchAction = new TouchAction(dr);
                //wt = new WebDriverWait(dr, TimeSpan.FromSeconds(60));
            }
            else if (app.Equals("Samsung_Galaxy_Tab_S5e"))
            {
                AppiumOptions caps = new AppiumOptions();

                // Set your BrowserStack access credentials
                caps.AddAdditionalCapability("browserstack.user", "natarajanr2");
                caps.AddAdditionalCapability("browserstack.key", "yjXx6XAQnxCHWa3ubvzY");

                // Set URL of the application under test
                caps.AddAdditionalCapability("app", "bs://8ee10c8b25c07dcb76a069471b68c053224d4535");

                // Specify device and os_version
                caps.AddAdditionalCapability("device", "Samsung Galaxy Tab S5e");
                caps.AddAdditionalCapability("os_version", "9.0");

                // Specify the platform name
                caps.PlatformName = "Android";

                caps.AddAdditionalCapability("autoGrantPermissions", "true");
                caps.AddAdditionalCapability(AndroidMobileCapabilityType.AutoGrantPermissions, true);


                // Set other BrowserStack capabilities
                caps.AddAdditionalCapability("project", "Telent Android Project");
                caps.AddAdditionalCapability("build", "Telent_Android_On_Samsung Galaxy");
                caps.AddAdditionalCapability("name", "Telent Scenarios");


                // Initialize the remote Webdriver using BrowserStack remote URL
                // and desired capabilities defined above
                dr = new AndroidDriver<AppiumWebElement>(new Uri("http://hub-cloud.browserstack.com/wd/hub"), caps);

                //dr = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);

                // Test case for the BrowserStack sample Android app. 
                // If you have uploaded your app, update the test case here.


                // Invoke driver.quit() after the test is done to indicate that the test is completed.
                //dr.Quit();
                //assign driver object to javascript and action class
                js = (IJavaScriptExecutor)dr;
                ac = new Actions(dr);
                touchAction = new TouchAction(dr);
                wt = new WebDriverWait(dr, TimeSpan.FromSeconds(60));
            }

            else if (app.Equals("EMULATOR"))
            {
                AppiumOptions cap = new AppiumOptions();

                //startServer(); wait(5);
                cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, "NatrajTestEmulator");
                cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
                cap.AddAdditionalCapability(MobileCapabilityType.AutomationName, "uiautomator2");
                //cap.AddAdditionalCapability(MobileCapabilityType.App, "C:\\Users\\natarajan.r.CTLEP\\Downloads\\UAT Bee v6.2.apk");
                //cap.AddAdditionalCapability(MobileCapabilityType.App, "D:\\Downloads\\UAT Bee.apk");
                cap.AddAdditionalCapability(MobileCapabilityType.App, "C:\\Users\\Natarajan R\\Downloads\\API Demos for Android.apk");
                cap.AddAdditionalCapability(MobileCapabilityType.NewCommandTimeout, 40000);
                cap.AddAdditionalCapability(AndroidMobileCapabilityType.AndroidDeviceReadyTimeout, 40000);
                cap.AddAdditionalCapability(AndroidMobileCapabilityType.AndroidInstallTimeout, 40000);
                cap.AddAdditionalCapability("autoGrantPermissions", "true");
                cap.AddAdditionalCapability(AndroidMobileCapabilityType.AutoGrantPermissions, true);

                //_appiumLocalService = new AppiumServiceBuilder().UsingAnyFreePort().Build();
                //_appiumLocalService.Start();
                //var AppiumService = new AppiumServiceBuilder().WithIPAddress("127.0.0.1").UsingPort(4723).Build();
                //if (!AppiumService.IsRunning)
                //AppiumService.Start();

                //startEmulator(); wait(5);
                //killAllNodes();
                dr = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
                //wait(10);
                //assign driver object to javascript and action class
                js = (IJavaScriptExecutor)dr;
                ac = new Actions(dr);
                touchAction = new TouchAction(dr);
                wt = new WebDriverWait(dr, TimeSpan.FromSeconds(60));
            }

                else if (app.Equals("GeneralStore"))
                {
                    AppiumOptions cap = new AppiumOptions();

                    //var driverPath = "D:\\Automation\\chromedriver.exe";
                    //Environment.SetEnvironmentVariable("webdriver.chrome.driver", driverPath);

                    //startServer(); wait(5);
                    cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, "NatrajTestEmulator");
                    cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
                    cap.AddAdditionalCapability(MobileCapabilityType.AutomationName, "uiautomator2");
                    //cap.AddAdditionalCapability(MobileCapabilityType.App, "C:\\Users\\natarajan.r.CTLEP\\Downloads\\UAT Bee v6.2.apk");
                    //cap.AddAdditionalCapability(MobileCapabilityType.App, "D:\\Downloads\\UAT Bee.apk");
                    cap.AddAdditionalCapability(MobileCapabilityType.App, "D:\\APK's\\General-Store.apk");
                    cap.AddAdditionalCapability(MobileCapabilityType.NewCommandTimeout, 40000);
                    cap.AddAdditionalCapability(AndroidMobileCapabilityType.AndroidDeviceReadyTimeout, 40000);
                    cap.AddAdditionalCapability(AndroidMobileCapabilityType.AndroidInstallTimeout, 40000);
                    cap.AddAdditionalCapability("autoGrantPermissions", "true");
                    cap.AddAdditionalCapability(AndroidMobileCapabilityType.AutoGrantPermissions, true);

                    //_appiumLocalService = new AppiumServiceBuilder().UsingAnyFreePort().Build();
                    //_appiumLocalService.Start();
                    //var AppiumService = new AppiumServiceBuilder().WithIPAddress("127.0.0.1").UsingPort(4723).Build();
                    //if (!AppiumService.IsRunning)
                    //AppiumService.Start();

                    //startEmulator(); wait(5);
                    //killAllNodes();
                    dr = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
                    //wait(10);
                    //assign driver object to javascript and action class
                    //js = (IJavaScriptExecutor)dr;
                    //ac = new Actions(dr);
                    //touchAction = new TouchAction(dr);
                    //wt = new WebDriverWait(dr, TimeSpan.FromSeconds(60));
                }

                else if (app.Equals("MobileChromeBrowser"))
                {
                    AppiumOptions cap = new AppiumOptions();

                    //var driverPath = "D:\\Changepond Mobile Automation\\CPT_Mobile_Test\\CPT_Mobile_Test\bin\\Debug\\chromedriver.exe";
                    //Environment.SetEnvironmentVariable("webdriver.chrome.driver", driverPath);

                    //startServer(); wait(5);
                    cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, "NatrajTestEmulator");
                    cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
                    cap.AddAdditionalCapability(MobileCapabilityType.AutomationName, "uiautomator2");
                    //cap.AddAdditionalCapability(MobileCapabilityType.App, "C:\\Users\\natarajan.r.CTLEP\\Downloads\\UAT Bee v6.2.apk");
                    //cap.AddAdditionalCapability(MobileCapabilityType.App, "D:\\Downloads\\UAT Bee.apk");
                    //cap.AddAdditionalCapability(MobileCapabilityType.App, "D:\\APK's\\General-Store.apk");
                    cap.AddAdditionalCapability(MobileCapabilityType.BrowserName, "Chrome");
                    cap.AddAdditionalCapability(MobileCapabilityType.NewCommandTimeout, 40000);
                    cap.AddAdditionalCapability(AndroidMobileCapabilityType.AndroidDeviceReadyTimeout, 40000);
                    cap.AddAdditionalCapability(AndroidMobileCapabilityType.AndroidInstallTimeout, 40000);
                    cap.AddAdditionalCapability("autoGrantPermissions", "true");
                    cap.AddAdditionalCapability(AndroidMobileCapabilityType.AutoGrantPermissions, true);
                    wait(10);
                    dr = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
                    //_appiumLocalService = new AppiumServiceBuilder().UsingAnyFreePort().Build();
                    //_appiumLocalService.Start();
                    //var AppiumService = new AppiumServiceBuilder().WithIPAddress("127.0.0.1").UsingPort(4723).Build();
                    //if (!AppiumService.IsRunning)
                    //AppiumService.Start();

                    //startEmulator(); wait(5);
                    //killAllNodes();

                    //wait(10);
                    //assign driver object to javascript and action class
                    //js = (IJavaScriptExecutor)dr;
                    //ac = new Actions(dr);
                    //touchAction = new TouchAction(dr);
                    //wt = new WebDriverWait(dr, TimeSpan.FromSeconds(60));
                }

                else if (app.Equals("GOOGLE_PIXEL_3"))
            {
                AppiumOptions caps = new AppiumOptions();

                // Set your BrowserStack access credentials
                caps.AddAdditionalCapability("browserstack.user", "natarajanr2");
                caps.AddAdditionalCapability("browserstack.key", "yjXx6XAQnxCHWa3ubvzY");

                // Set URL of the application under test
                caps.AddAdditionalCapability("app", "bs://8ee10c8b25c07dcb76a069471b68c053224d4535");

                // Specify device and os_version
                caps.AddAdditionalCapability("device", "Google Pixel 3");
                caps.AddAdditionalCapability("os_version", "9.0");

                // Specify the platform name
                caps.PlatformName = "Android";

                caps.AddAdditionalCapability("autoGrantPermissions", "true");
                caps.AddAdditionalCapability(AndroidMobileCapabilityType.AutoGrantPermissions, true);


                // Set other BrowserStack capabilities
                caps.AddAdditionalCapability("project", "Telent Android Project");
                caps.AddAdditionalCapability("build", "Telent_Android_On_Google_Pixel");
                caps.AddAdditionalCapability("name", "Telent Scenarios");


                // Initialize the remote Webdriver using BrowserStack remote URL
                // and desired capabilities defined above
                dr = new AndroidDriver<AppiumWebElement>(new Uri("http://hub-cloud.browserstack.com/wd/hub"), caps);

                //dr = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);

                // Test case for the BrowserStack sample Android app. 
                // If you have uploaded your app, update the test case here.


                // Invoke driver.quit() after the test is done to indicate that the test is completed.
                //dr.Quit();
                //assign driver object to javascript and action class
                js = (IJavaScriptExecutor)dr;
                ac = new Actions(dr);
                touchAction = new TouchAction(dr);
                wt = new WebDriverWait(dr, TimeSpan.FromSeconds(60));
            }

            else if (app.Equals("One_Plus_7"))
            {
                AppiumOptions caps = new AppiumOptions();

                // Set your BrowserStack access credentials
                caps.AddAdditionalCapability("browserstack.user", "natarajanr2");
                caps.AddAdditionalCapability("browserstack.key", "yjXx6XAQnxCHWa3ubvzY");

                // Set URL of the application under test
                caps.AddAdditionalCapability("app", "bs://8ee10c8b25c07dcb76a069471b68c053224d4535");

                // Specify device and os_version
                caps.AddAdditionalCapability("device", "OnePlus 7");
                caps.AddAdditionalCapability("os_version", "9.0");

                // Specify the platform name
                caps.PlatformName = "Android";

                caps.AddAdditionalCapability("autoGrantPermissions", "true");
                caps.AddAdditionalCapability("autoAcceptAlerts", "true");
                caps.AddAdditionalCapability("locationServicesAuthorized", "true");
                caps.AddAdditionalCapability("locationContextEnabled", "true");
                caps.AddAdditionalCapability(AndroidMobileCapabilityType.AutoGrantPermissions, true);

                // Set other BrowserStack capabilities
                caps.AddAdditionalCapability("project", "Telent Android Project");
                caps.AddAdditionalCapability("build", "Telent_Android_On_OnePlus");
                caps.AddAdditionalCapability("name", "Telent Scenarios");


                // Initialize the remote Webdriver using BrowserStack remote URL
                // and desired capabilities defined above
                dr = new AndroidDriver<AppiumWebElement>(new Uri("http://hub-cloud.browserstack.com/wd/hub"), caps);

                //dr = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);

                // Test case for the BrowserStack sample Android app. 
                // If you have uploaded your app, update the test case here.


                // Invoke driver.quit() after the test is done to indicate that the test is completed.
                //dr.Quit();
                //assign driver object to javascript and action class
                js = (IJavaScriptExecutor)dr;
                ac = new Actions(dr);
                touchAction = new TouchAction(dr);
                wt = new WebDriverWait(dr, TimeSpan.FromSeconds(60));
            }

            else if (app.Equals("iPhone_11_Pro"))
            {
                AppiumOptions caps = new AppiumOptions();

                // Set your BrowserStack access credentials
                caps.AddAdditionalCapability("browserstack.user", "natarajanr2");
                caps.AddAdditionalCapability("browserstack.key", "yjXx6XAQnxCHWa3ubvzY");

                // Set URL of the application under test
                caps.AddAdditionalCapability("app", "bs://1b67cd1356a8fb3fb133751a28cd4d954a4ec4e5");

                // Specify device and os_version
                caps.AddAdditionalCapability("device", "iPhone 11 Pro");
                caps.AddAdditionalCapability("os_version", "13");

                // Specify the platform name
                caps.PlatformName = "iOS";

                caps.AddAdditionalCapability("autoGrantPermissions", "true");
                caps.AddAdditionalCapability("autoAcceptAlerts", "true");
                caps.AddAdditionalCapability("locationServicesAuthorized", "true");
                caps.AddAdditionalCapability("locationContextEnabled", "true");
                caps.AddAdditionalCapability(IOSMobileCapabilityType.AutoAcceptAlerts, true);

                // Set other BrowserStack capabilities
                caps.AddAdditionalCapability("project", "Telent iOS Project");
                caps.AddAdditionalCapability("build", "Telent_iOS_On_IPhone 11");
                caps.AddAdditionalCapability("name", "Telent Scenarios");


                // Initialize the remote Webdriver using BrowserStack remote URL
                // and desired capabilities defined above
                iOSdr = new IOSDriver<AppiumWebElement>(new Uri("http://hub-cloud.browserstack.com/wd/hub"), caps);
                //assign driver object to javascript and action class
                js = (IJavaScriptExecutor)iOSdr;
                ac = new Actions(iOSdr);
                touchAction = new TouchAction(iOSdr);
                wt = new WebDriverWait(iOSdr, TimeSpan.FromSeconds(60));

            }


            else
            {
                 brNm = "Unknown MobileApp";
                 LogIt("We don't support this MobileApp: " + br, logTyp.Stop);
            }

            }
            catch (Exception e)
                {
                    LogIt("Couldn't start " + br + " webdriver :exc: " + e, logTyp.Stop);
                }
            
                wt = new WebDriverWait(dr, TimeSpan.FromSeconds(60));
            
        }

        //Starting emulator
        public static void StartEmulator()
        {
            exeProc = Process.Start("C:\\Repo\\MDU_Daily_Service_Checks\\Dailycheck_MobileAutomation\\Dailycheck_MobileAutomation\\CorpWeb\\Resources\\StartEmulator.bat");
            Thread.Sleep(5000);

        }

        public static void startServer()
        {
            Process exeServer = Process.Start("C:\\TestAutomation\\TestAutomation\\CorpWeb\\Resources\\StartServer.bat");
            Thread.Sleep(5000);

        }
        public void mobileScrollToText(String text)
        {
            //driver.findElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView(text(\""+text+"\"))");
            try
            {
                dr.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView(text(\"" + text + "\"))"));
                LogIt("Scrolled to the text: " + text, logTyp.Info);
            }
            catch (Exception e)
            {
                LogIt("Could not scroll to the text: " + text + " :exc: " + e, logTyp.Fail);
            }

        }

        public void mobileScrollToTextandClick(String text)
        {
            //driver.findElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView(text(\""+text+"\"))");
            try
            {
                dr.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView(text(\"" + text + "\"))")).Click();
                LogIt("Scrolled to the text: " + text, logTyp.Info);
            }
            catch (Exception e)
            {
                LogIt("Could not scroll to the text: " + text + " :exc: " + e, logTyp.Fail);
            }


        }

        public static void killAllNodes()
        {
            Process exeNodes = Process.Start("taskkill /F /IM node.exe");
            wait(5000);
        }

        //public static void sendEmail(String Filepath)
        //{
        //    ZipFile.CreateFromDirectory(rPath, rPath + ".zip");
        //    try
        //    {
        //        MailMessage mail = new MailMessage();
        //        string fromEmail = "Natarajan.Rajendiran@themdu.com";
        //        string password = "WinterIsComingTammu@20";
        //        string toEmail = "Natarajan.Rajendiran@themdu.com";
        //        string subject = "Test Subject";
        //        string contentBody = "<h3> Test Email body </h3>";
        //        mail.Attachments.Add(new Attachment(Filepath));
        //        mail.From = new MailAddress(fromEmail);
        //        mail.To.Add(toEmail);
        //        mail.Subject = subject;
        //        mail.Body = contentBody;
        //        mail.IsBodyHtml = true;
        //        SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
        //        smtp.Credentials = new NetworkCredential(fromEmail, password);
        //        smtp.EnableSsl = true;
        //        smtp.Send(mail);
                

        //    }

        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //}

        public static void SwitchContext()
        {
            // get the available contexts
            List<string> contexts = dr.Contexts.ToList();

            foreach(string listofContexts in contexts)
            {
                Console.WriteLine(listofContexts);
            }

            // switch to the browser context
            dr.Context = contexts.Last();
        }

        public void LongpressEl(string eleXP)
        {
            LongpressElW(GetElement(eleXP), GetEleLbl(eleXP));
        }
        //Objective: Clicks given web element
        public void LongpressElW(AppiumWebElement el, string lbl)
        {
            try
            {
                TouchAction longpress = new TouchAction(dr);
                longpress.LongPress(el).Perform();
                LogIt("Long pressed element: " + lbl, logTyp.Info);
            }
            catch (Exception e)
            {
                LogIt("Could not longpress element: " + lbl + " :exc: " + e, logTyp.Fail);
            }
        }

        //Objective: Opens provided url and also logs notes url app version
        public static void openUrl(string browserUrl)
        {
            if (dr == null) LogIt("Appiumdriver not initialized", logTyp.Skip);
            try
            {
                dr.Navigate().GoToUrl(browserUrl); WaitForJqueryAjax(); wait(0.25);
                LogIt("Launching url:" + browserUrl, logTyp.Info); wait(0.25);
            }
            catch (Exception e)
            {
                LogIt("Couldn't load the url:exc: " + e, logTyp.Ignore);
            }
        }

        /*---Current Page Object model: Routines for getting webelement/s and it's labels--*/
        //Objective: Extracts ID, xpath or CSS value from page elements variables
        public static string GetEleVal(string ele)
        {
            return ele.Contains("##") ? Regex.Split(ele, "##")[0].Trim() : ele;
        }
        //Objective: Extracts labels from page elements variables
        public static string GetEleLbl(string ele)
        {
            return ele.Contains("##") ? Regex.Split(ele, "##")[1].Trim() : ele;
        }
        //Objective: Gets By object value based on ID, xpath or CSS value provided
        public static By getByLoc(string locVal)
        {
            By byLoc = null;
            if (locVal.Substring(0, 1).Equals("/"))
                byLoc = By.XPath(GetEleVal(locVal));
            else if (locVal.Substring(0, 5).Equals("<CSS>"))
                byLoc = By.CssSelector(GetEleVal(locVal).Replace("<CSS>", "").Trim());
            else if(locVal.Substring(0, 1).Equals("("))
                byLoc = By.XPath(GetEleVal(locVal));
            else
                byLoc = By.Id(GetEleVal(locVal));
            return byLoc;
        }
        //Objective: Gets Webelement object based on locator value
        public static AppiumWebElement GetElement(string LocatorValue)
        {
            AppiumWebElement ele = null;
           
            try
            {
                    wt.Until(ExpectedConditions.ElementIsVisible(getByLoc(LocatorValue)));
                    ele = dr.FindElement(getByLoc(LocatorValue));                                        
            }
            catch (Exception e)
            {
                LogIt(GetEleLbl(LocatorValue) + " not found :exc:" + e, logTyp.Fail);
            }
            return ele;
        }

        //Objective: Gets iOS Webelement object based on locator value
        public static AppiumWebElement GetiOSElement(string LocatorValue)
        {
            AppiumWebElement ele = null;

            try
            {
                //wt.Until(ExpectedConditions.ElementIsVisible(getByLoc(LocatorValue)));
                Thread.Sleep(4000);
                ele = iOSdr.FindElement(getByLoc(LocatorValue));
            }
            catch (Exception e)
            {
                LogIt(GetEleLbl(LocatorValue) + " not found :exc:" + e, logTyp.Fail);
            }
            return ele;
        }
        //Objective: Gets list of Webelements object based on locator value
        public static IList<AppiumWebElement> GetElements(string LocatorValue)
        {
            IList<AppiumWebElement> els = new List<AppiumWebElement>();

            try
            {
                els = dr.FindElements(getByLoc(LocatorValue));
                //els = wt.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(getByLoc(LocatorValue)));
                LogIt(els.Count + " count of lements found for " + GetEleLbl(LocatorValue), logTyp.Logs);
            }
            catch (Exception e)
            {
                LogIt(GetEleLbl(LocatorValue) + "  elements not found :exc:" + e, logTyp.Logs);
            }

            return els;
        }

        /*---Routines for alert--*/
        //Objective: Checks the presence of an alert
        public static bool IsAlert()
        {
            bool presentFlag = false;
            try
            {
                alert = dr.SwitchTo().Alert();
                presentFlag = true;
                LogIt("Checked for alert and alert shown as: " + getAlertText(), logTyp.Info);
            }
            catch (Exception e) { LogIt("Checked for alert and found none:exc:" + e, logTyp.Logs); }
            return presentFlag;
        }
        //Objective: Gets the alert text message
        public static string getAlertText()
        {
            string alrtMsg = null;
            if (IsAlert())
            {
                try
                {
                    alrtMsg = alert.Text;
                    LogIt("Got texts: " + alrtMsg, logTyp.Logs);
                }
                catch (Exception e)
                {
                    try
                    {
                        alrtMsg = js.ExecuteScript("returnwindow.alert.myAlertText;").ToString();
                        LogIt("Got texts: " + alrtMsg + " :using javascript :exc:" + e, logTyp.Logs);
                    }
                    catch (Exception ex)
                    {
                        LogIt("Could not get texts from alert :exc: " + ex, logTyp.Error);
                    }
                }
            }
            else { LogIt("No alert present to get the alert message", logTyp.Fail); }
            return alrtMsg;
        }
        //Objective: Cancels alert
        public static void dismissAlert()
        {
            string logMsg = "";
            if (IsAlert())
            {
                logMsg = getAlertText();
                try
                {
                    alert.Dismiss();
                    LogIt("Alert Cancelled with message: " + logMsg, logTyp.Info);
                }
                catch (Exception e)
                {
                    LogIt("Could not cancel alert " + logMsg + " :exc: " + e, logTyp.Error);
                }
            }
            else { LogIt("No alert present to cancel the alert", logTyp.Fail); }
        }
        //Objective: Accepts alert
        public static void acceptAlert()
        {
            string logMsg;
            if (IsAlert())
            {
                logMsg = getAlertText();
                try
                {
                    alert.Accept();
                    LogIt("Alert accepted with message: " + logMsg, logTyp.Info);
                }
                catch (Exception e)
                {
                    LogIt("Could not accept alert " + logMsg + " :exc: " + e, logTyp.Error);
                }
            }
            else { LogIt("No alert present to accept the alert", logTyp.Fail); }
        }

        /*---Routines for sending and clearing keys on webelement--*/
        //Objective: Entering texts on Xpath/ID/CSS
        public void actionType(string el, string keys)
        {            
            try
            {
                GetElement(el).Click();
                Actions ac2 = new Actions(dr);
                ac2.SendKeys(keys).SendKeys(Keys.Enter).Build().Perform();
                //ac2.SendKeys(keys).Build().Perform();
                dr.HideKeyboard();
                LogIt("Typed '" + keys + "' in element: " + GetEleLbl(el), logTyp.Info);
            }
            catch(Exception ex)
            {
                LogIt("Could not type '" + keys + "' in element: " + GetEleLbl(el) + " :exc: " + ex, logTyp.Fail);
            }
        }
        public static void typeText(string eleXP, string text)
        {
            typeTextW(GetElement(eleXP), GetEleLbl(eleXP), text);
        }
        //Objective: Entering texts on Web Element
        public static void typeTextW(AppiumWebElement el, string lbl, string text)
        {
            string lbltext = lbl.ToUpper().Contains("PASSWORD") ? "**********" : text;
            try
            {
                el.SendKeys(text);
                LogIt("Typed '" + lbltext + "' in element: " + lbl, logTyp.Info);
            }
            catch (Exception e)
            {
                try
                {
                    if (getAttributeW(el, lbl, "class").Contains("Datepicker")) { text = DateTime.ParseExact(text, "ddMMyyyy", CultureInfo.InvariantCulture).ToString("dd/MM/yyyy"); }
                    js.ExecuteScript("arguments[0].setAttribute('value','" + text + "')", el);
                    LogIt("Could type '" + lbltext + "' in element: " + lbl + " :using javascript:exc:" + e, logTyp.Info);
                }
                catch (Exception ex)
                {
                    LogIt("Could not type '" + lbltext + "' in element: " + lbl + " :exc: " + ex, logTyp.Fail);
                }
            }
        }
        //Objective: Getting texts from Xpath/ID/CSS
        public static string getText(string eleXP)
        {
            return getTextW(GetElement(eleXP), GetEleLbl(eleXP));
        }
        //Objective: Getting texts from Web Element
        public static string getTextW(AppiumWebElement el, string lbl)
        {
            string text = "";
            try
            {
                text = el.Text;
                if (text.Equals("") || text == null)
                {
                    js.ExecuteScript("arguments[0].scrollIntoView(true);", el);
                    text = (string)js.ExecuteScript("return arguments[0].innerText;", el);
                    LogIt("Got text:<" + text + "> using JS from element:exc:" + lbl, logTyp.Logs);
                }
                else
                {
                    LogIt("Got text:<" + text + "> from element: " + lbl, logTyp.Logs);
                }
            }
            catch (Exception e)
            {
                LogIt("Could not get text from element: " + lbl + " :exc: " + e, logTyp.Fail);
            }
            return text;
        }
        //Objective: Clearing texts from Xpath/ID/CSS
        public static void clearText(string eleXP)
        {
            clearTextW(GetElement(eleXP), GetEleLbl(eleXP));
        }
        //Objective: Clearing texts from Web Element
        public static void clearTextW(AppiumWebElement el, string lbl)
        {
            try
            {
                el.Clear();
                LogIt("Cleared texts from element: " + lbl, logTyp.Info);
            }
            catch (Exception e)
            {
                try
                {
                    js.ExecuteScript("arguments[0].value = '';", el);
                    LogIt("Cleared from element: " + lbl + " using js:exc:" + e, logTyp.Info);
                }
                catch (Exception ex)
                {
                    LogIt("Could not clear text from element: " + lbl + " :exc: " + ex, logTyp.Fail);
                }
            }
        }

        /*---Routines for web element attributes--*/
        //Objective: Gets provided attribute value from given Xpath/ID/CSS
        public static string getAttribute(string eleXP, string attr)
        {
            return getAttributeW(GetElement(eleXP), GetEleLbl(eleXP), attr);
        }
        //Objective: Gets provided attribute value from given Web Element
        public static string getAttributeW(AppiumWebElement ele, string lbl, string attr)
        {
            string attrVal = "";
            try
            {
                attrVal = ele.GetAttribute(attr);
                LogIt("Got value:[" + attrVal + "] from element: " + lbl + " for attribute: " + attr, logTyp.Logs);
            }
            catch (Exception e)
            {
                LogIt("Could not get attribute value for " + attr + " from element: " + lbl + " :exc: " + e, logTyp.Fail);
            }
            return attrVal;
        }
        //Objective: Checks provided attribute present in given Xpath/ID/CSS
        public bool isAttribute(string eleXP, string attr)
        {
            return isAttributeW(GetElement(eleXP), GetEleLbl(eleXP), attr);
        }
        //Objective: Checks provided attribute present in the given Web Element
        public bool isAttributeW(AppiumWebElement element, string lbl, string attribute)
        {
            bool flag;
            flag = element.GetAttribute(attribute) != null ? true : false;
            if (flag)
                LogIt(lbl + " has atrribute: " + attribute, logTyp.Logs);
            else
                LogIt(lbl + " doesn't have atrribute: " + attribute, logTyp.Error);

            return flag;
        }
        //Objective: Sets provided attribute value on given Xpath/ID/CSS
        public void setAttribute(string eleXP, string attr, string text)
        {
            setAttributeW(GetElement(eleXP), GetEleLbl(eleXP), attr, text);
        }
        //Objective: Sets provided attribute value to given Web Element
        public void setAttributeW(AppiumWebElement el, string lbl, string attr, string text)
        {
            try
            {
                js.ExecuteScript("arguments[0].setAttribute('" + attr + "', '" + text + "')", el);
                LogIt("Attribute '" + attr + "' set as '" + text + "' for element: " + lbl, logTyp.Info);
            }
            catch (Exception ex)
            {
                LogIt("Attribute '" + attr + "' could not be set as '" + text + "' for element: " + lbl + " :exc: " + ex, logTyp.Fail);
            }
        }

        /*---Routines for dropdown webelements--*/
        //Objective: Gets selected texts from given Xpath/ID/CSS of a dropdown
        public string GetSelectedText(string locval)
        {
            return GetSelectedTextW(GetElement(GetEleVal(locval)), GetEleLbl(locval));
        }
        //Objective: Gets selected texts from given dropdown web element
        public string GetSelectedTextW(AppiumWebElement el, string lbl)
        {
            SelectElement Slct = new SelectElement(el);
            string rtrnVal = null;
            try
            {
                rtrnVal = Slct.SelectedOption.Text;
                LogIt("Got value: " + rtrnVal + " from dropdown: " + lbl, logTyp.Logs);
            }
            catch (Exception e)
            {
                LogIt("Could not get selected text from dropdown: " + lbl + " :exc: " + e, logTyp.Fail);
            }

            return rtrnVal;
        }
        //Objective: Selects random texts from given Xpath/ID/CSS of a dropdown
        public string selectRandom(string locval)
        {
            return selectRandomW(GetElement(GetEleVal(locval)), GetEleLbl(locval));
        }
        //Objective: Selects random texts from given dropdown web element
        public string selectRandomW(AppiumWebElement ddele, string lbl)
        {
            SelectElement Select = new SelectElement(ddele);
            string retVal = null;
            try
            {
                Select.SelectByIndex(rand.Next(Select.Options.Count));
                if (GetSelectedTextW(ddele, lbl).Trim().Equals(""))
                {
                    Select.SelectByIndex(rand.Next(Select.Options.Count));
                    if (GetSelectedTextW(ddele, lbl).Trim().Equals(""))
                    {
                        Select.SelectByIndex(rand.Next(Select.Options.Count));
                        if (GetSelectedTextW(ddele, lbl).Trim().Equals(""))
                        {
                            LogIt("Cannot proceed as empty value got selected randomly everytime in dropdown" + lbl, logTyp.Fail);
                        }
                    }
                }
                retVal = GetSelectedTextW(ddele, lbl);
                LogIt("Selected: " + retVal + " randomly from element: " + lbl, logTyp.Info);
            }
            catch (Exception e)
            {
                LogIt("Couldn't select random value from element: " + lbl + " due to :exc: " + e, logTyp.Fail);
            }
            return retVal;
        }
        //Objective: Selects provided texts from given Xpath/ID/CSS of a dropdown
        public void SelectText(string eleXP, string txt)
        {
            SelectTextW(GetElement(eleXP), GetEleLbl(eleXP), txt);
        }
        //Objective: Selects provided texts from given dropdown web element
        public void SelectTextW(AppiumWebElement el, string lbl, string txt)
        {
            SelectElement Select = new SelectElement(el);
            string al;
            try { al = Select.SelectedOption.Text; } catch { al = "<<nothing>>"; }
            if (al.Equals("<<nothing>>") || !txt.Equals(al))
            {
                try
                {
                    Select.SelectByText(txt);
                    LogIt("Selected: " + txt + " from element: " + lbl, logTyp.Info);
                }
                catch (Exception e)
                {
                    LogIt("Could not select: " + txt + " from element: " + lbl + " :exc: " + e, logTyp.Fail);
                }
            }
            else
            {
                LogIt("Dropdown already has value: " + txt, logTyp.Info);
            }
        }
        //Objective: Checks whether given dropdown Xpath/ID/CSS with  has provided value
        public void dropdownDoesntHave(string eleXP, string txt)
        {
            dropdownDoesntHaveW(GetElement(eleXP), GetEleLbl(eleXP), txt);
        }
        //Objective: Checks whether given dropdown web element has provided value
        public bool dropdownDoesntHaveW(AppiumWebElement el, string lbl, string SelectText)
        {
            bool flag = false;
            SelectElement Select = new SelectElement(el);
            try
            {
                if (SelectText.Equals(Select.SelectedOption.Text))
                    flag = true;
            }
            catch
            {
                try
                {
                    Select.SelectByText(SelectText);
                    flag = true;
                    LogIt("Found: " + SelectText + " from element: " + lbl + " which is not expected", logTyp.Fail);
                }
                catch (Exception e)
                {
                    LogIt("Cound not find: " + SelectText + " from element: " + lbl + " as expected :exc:" + e, logTyp.Logs);
                }
            }
            return flag;
        }
        //Objective: Selects value from given Xpath/ID/CSS of a dropdown based on provided index
        public string SelectByIndex(string eleXP, int ind)
        {
            return SelectByIndexW(GetElement(eleXP), GetEleLbl(eleXP), ind);
        }
        //Objective: Selects value from given dropdown web element based on provided index
        public string SelectByIndexW(AppiumWebElement el, string lbl, int ind)
        {
            SelectElement Select = new SelectElement(el);
            try
            {
                Select.SelectByIndex(ind);
                LogIt("Selected: " + GL.getOrdinal(ind) + " value from dropdown: " + lbl, logTyp.Logs);
            }
            catch (Exception e)
            {
                LogIt("Could not select: " + GL.getOrdinal(ind) + " value from dropdown: " + lbl + " :exc: " + e, logTyp.Fail);
            }
            return GetSelectedTextW(el, lbl);
        }
        //Objective: Gets count of values from given Xpath/ID/CSS of a dropdown
        public int getDropdowncount(string eleXP)
        {
            return getDropdowncountW(GetElement(eleXP), GetEleLbl(eleXP));
        }
        //Objective: Gets count of values from given dropdown web element
        public int getDropdowncountW(AppiumWebElement el, string lbl)
        {
            SelectElement Select = new SelectElement(el);
            LogIt(lbl + " has " + Select.Options.Count + " values", logTyp.Logs);
            return Select.Options.Count;
        }

        /*--click routines--*/
        //Objective: Checks whether given Xpath/ID/CSS is clickable
        public bool isClick(string eleXP)
        {
            return isClickW(GetElement(eleXP), GetEleLbl(eleXP));
        }
        //Objective: Checks whether given Web element is clickable
        public bool isClickW(AppiumWebElement el, string lbl)
        {
            bool flag = false;
            try
            {
                el.Click();
                LogIt("Clicked element: " + lbl, logTyp.Logs);
                flag = true;
            }
            catch (Exception e)
            {
                LogIt("Element: " + lbl + " not clickable :exc:" + e, logTyp.Error);
            }
            return flag;
        }
        //Objective: Clicks given Xpath/ID/CSS
        public void ClickEl(string eleXP)
        {
            ClickElW(GetElement(eleXP), GetEleLbl(eleXP));
        }

        //Objective: Clicks given Xpath/ID/CSS
        public void ClickiOSEl(string eleXP)
        {
            ClickElW(GetiOSElement(eleXP), GetEleLbl(eleXP));
        }
        //Objective: Clicks given web element
        public void ClickElW(AppiumWebElement el, string lbl)
        {
            try
            {
                el.Click();
                LogIt("Clicked element: " + lbl, logTyp.Info);
            }
            catch(Exception e)
            {
                LogIt("Could not click element: " + lbl + " :exc: " + e, logTyp.Fail);
            }
        }

        public void MobileScrollDown()
        {
            Size size = dr.Manage().Window.Size;

            // Set the start and end coordinates for the swipe
            int startx = size.Width / 2;
            int endy = (int)(size.Height * 0.8);
            int starty = (int)(size.Height * 0.2);

            // Perform the swipe gesture using TouchActions class
            ITouchAction scroll = new TouchAction(dr);
            scroll.Press(startx, starty).Wait(5000).MoveTo(startx, endy).Release().Perform();
        }
        public void ScRolltopageend()
        {
            // Get the screen size for swipe coordinates
            Size size = dr.Manage().Window.Size;

            // Set the start and end coordinates for the swipe
            int startX = size.Width / 2;
            int startY = (int)(size.Height * 0.8); // Start lower on the screen
            int endY = (int)(size.Height * 0.2);   // End higher on the screen for a swipe up

            // Create a pointer input device for touch actions
            var touchInput = new OpenQA.Selenium.Interactions.PointerInputDevice(PointerKind.Touch);

            // Create the action sequence for the swipe gesture
            var swipe = new ActionSequence(touchInput, 0)
                .AddAction(touchInput.CreatePointerMove(CoordinateOrigin.Viewport, startX, startY, TimeSpan.Zero))  // Move to start point
                .AddAction(touchInput.CreatePointerDown(MouseButton.Left))                                          // Press down at start
                .AddAction(touchInput.CreatePointerMove(CoordinateOrigin.Viewport, startX, endY, TimeSpan.FromSeconds(1))) // Move to end point
                .AddAction(touchInput.CreatePointerUp(MouseButton.Left));                                           // Release

            // Perform the swipe action
            dr.PerformActions(new List<ActionSequence> { swipe });
        }

        public void MobileScrollUp()
        {
            Size size = dr.Manage().Window.Size;

            // Set the start and end coordinates for the swipe
            int startx = size.Width / 2;
            int starty = (int)(size.Height * 0.8);
            int endy = (int)(size.Height * 0.2);

            // Perform the swipe gesture using TouchActions class
            ITouchAction action = new TouchAction(dr);
            action.Press(startx, starty).Wait(5000).MoveTo(startx, endy).Release().Perform();
        }

        public void MobileScrollLeft()
        {
            Size size = dr.Manage().Window.Size;

            // Set the start and end coordinates for the swipe
            int starty = size.Height / 2;
            int endx = (int)(size.Width * 0.2);
            int startx = (int)(size.Width * 0.8);

            // Perform the swipe gesture using TouchActions class
            ITouchAction action = new TouchAction(dr);
            action.Press(startx, starty).Wait(5000).MoveTo(endx, starty).Release().Perform();
        }

        public void MobileScrollRight()
        {
            Size size = dr.Manage().Window.Size;

            // Set the start and end coordinates for the swipe
            int starty = size.Height / 2;
            int startx = (int)(size.Width * 0.2);
            int endx = (int)(size.Width * 0.8);

            // Perform the swipe gesture using TouchActions class
            ITouchAction action = new TouchAction(dr);
            action.Press(startx, starty).Wait(5000).MoveTo(endx, starty).Release().Perform();
        }

        //Objective: Clicks given Xpath/ID/CSS using javascript
        public void JSClick(string eleXP)
        {
            JSClickW(GetElement(eleXP), GetEleLbl(eleXP));
        }
        //Objective: Clicks given web element using javascript
        public void JSClickW(AppiumWebElement ele, string lbl)
        {
            try
            {
                js.ExecuteScript("arguments[0].click();", ele);
                LogIt("Clicked '" + lbl + "' using javascript", logTyp.Info);
            }
            catch (Exception e)
            {
                LogIt("Could not click element: " + lbl + " :exc: " + e, logTyp.Fail);
            }

        }

        /*---- element present, visible, etc -----*/
        //Objective: Checks given Xpath/ID/CSS is present
        public static bool IsElepresent(string LocatorValue)
        {
            bool flag = false;
            By byLoc = getByLoc(LocatorValue);

            try
            {
                dr.FindElement(byLoc);
                flag = true;
            }
            catch(Exception e)
            {
                //try
                //{
                //    ScrollToBottom();
                //    dr.FindElement(byLoc);
                //    flag = true;
                //}
                //catch
                //{
                //    try
                //    {
                //        ScrollToTop();
                //        dr.FindElement(byLoc);
                //        flag = true;
                //    }
                //    catch (Exception e)
                //    {
                //        LogIt(GetEleLbl(LocatorValue) + " not found :exc:" + e, logTyp.Logs);
                //    }
                //}
                LogIt(GetEleLbl(LocatorValue) + " not found :exc:" + e, logTyp.Logs);
            }
            return flag;
        }

        //iOS Element present

        public static bool IsiOSElepresent(string LocatorValue)
        {
            bool flag = false;
            By byLoc = getByLoc(LocatorValue);

            try
            {
                iOSdr.FindElement(byLoc);
                flag = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return flag;
        }

        //Objective: Checks given Xpath/ID/CSS is present
        public static bool isDisplayed(string LocatorValue)
        {
            bool flag = false;
            if (IsElepresent(LocatorValue))
            {
                flag = dr.FindElement(getByLoc(LocatorValue)).Displayed;
                if (!flag)
                {
                    ScrollToBottom();
                    flag = dr.FindElement(getByLoc(LocatorValue)).Displayed;
                }
                if (!flag)
                {
                    ScrollToTop();
                    flag = dr.FindElement(getByLoc(LocatorValue)).Displayed;
                }
                if(!flag)
                {
                    LogIt("Web element present but not displayed" + GetEleLbl(LocatorValue), logTyp.Logs);
                }
            }
            else
            {
                LogIt("Web element not present" + GetEleLbl(LocatorValue), logTyp.Logs);
            }
            return flag;
        }

        public static void isThisShown(string LocatorValue)
        {
            if (isDisplayed(LocatorValue))
                LogIt(GetEleLbl(LocatorValue) + " is shown as expected", logTyp.Pass);
            else
                LogIt(GetEleLbl(LocatorValue) + " is not shown in page", logTyp.Error);
        }
        /*--------Window handles--------*/
        //Objective: Switches to window based on window title
        public static void switchToWin(string titl)
        {
            string[] handles = dr.WindowHandles.ToArray();
            for (int i = 0; i < handles.Length; i++)
            {
                if (handles[i].Equals(titl))
                {
                    dr.SwitchTo().Window(handles[i]);
                    break;
                }
            }
            if (dr.Title.Equals(titl))
            {
                LogIt("Switched to Window: " + titl + " successfully", logTyp.Info);
            }
            else
            {
                LogIt("Could not switch to Window: " + titl, logTyp.Fail);
            }
        }
        //Objective: Closes window based on window title
        public static void closeWin(string titl)
        {
            bool flag = false;
            string[] handles = dr.WindowHandles.ToArray();
            for (int i = 0; i < handles.Length; i++)
            {
                if (handles[i].Equals(titl))
                {
                    dr.SwitchTo().Window(handles[i]).Close();
                    LogIt("Closed Window: " + titl + " successfully", logTyp.Info);
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                LogIt("Could not find or close Window: " + titl, logTyp.Fail);
            }
        }
        

        /*------ Page scrolling ------*/
        //Objective: scrolls to top of page
        public static void ScrollToTop()
        {
            try
            {
                js.ExecuteScript("window.scrollTo(document.body.scrollHeight, 0)");
                LogIt("scrolled to top of the page.", logTyp.Logs);
            }
            catch (Exception e)
            {
                LogIt("Couldn't scroll to top of page :exc: " + e, logTyp.Logs);
            }
        }
        //Objective: scrolls to bottom of page
        public static void ScrollToBottom()
        {
            long scrollHeight = 0;
            do
            {
                var newScrollHeight = (long)js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight); return document.body.scrollHeight;");
                if (newScrollHeight == scrollHeight)
                {
                    break;
                }
                else
                {
                    scrollHeight = newScrollHeight;
                    wait(0.4);
                }
            } while (true);
        }

        /*------- Action classes -------*/
        //Objective: drags one Xpath/ID/CSS to another Xpath/ID/CSS
        public void drag(string eleXP1, string eleXP2)
        {
            dragW(GetElement(GetEleVal(eleXP1)), GetEleLbl(eleXP1), GetElement(GetEleVal(eleXP2)), GetEleLbl(eleXP2));
        }
        //Objective: drags one web element to another web element using action class
        public void dragW(AppiumWebElement srcW, string src, AppiumWebElement targetW, string target)
        {
            try
            {
                js.ExecuteScript("arguments[0].click()", srcW);
                ac.DragAndDrop(srcW, targetW).Build().Perform();
                LogIt("Dragged " + src + " to " + target, logTyp.Info);
            }
            catch (Exception e)
            {
                LogIt("Couldn't drag " + src + " to " + target + ":exc:" + e, logTyp.Fail);
            }
        }
        //Objective: hovers on given Xpath/ID/CSS using action class
        public void hoverOn(string hovrEl)
        {
            hoverOnW(GetElement(hovrEl), GetEleLbl(hovrEl));
        }
        //Objective: hovers on given web element using action class
        public void hoverOnW(AppiumWebElement el, string lbl)
        {
            try
            {
                ac.MoveToElement(el).Perform();
                LogIt("Hovered on :" + lbl, logTyp.Info);
            }
            catch (Exception e)
            {
                LogIt("Could not hover on " + lbl + " :exc: " + e, logTyp.Fail);
            }
        }

        /*------ Match routines for all data types -----*/
        //Objective: Matches boolean expected and actual values
        public void Match(bool act, bool exp, string msg)
        {
            if (act == exp)
            {
                LogIt("PASS >> " + msg + " >> Actual: " + act + " :: Expected: " + exp, logTyp.Info);
            }
            else
            {
                LogIt("ERROR >>" + msg + " >> Actual: " + act + " :: Expected: " + exp, logTyp.Error);
            }
        }
        //Objective: Matches integer expected and actual values
        public void Match(int act, int exp, string msg)
        {
            if (act == exp)
            {
                LogIt("PASS >> " + msg + " >> Actual: " + act + " :: Expected: " + exp, logTyp.Info);
            }
            else
            {
                LogIt("ERROR >>" + msg + " >> Actual: " + act + " :: Expected: " + exp, logTyp.Error);
            }
        }
        //Objective: Matches double expected and actual values
        public void Match(double act, double exp, string msg)
        {
            if (Math.Abs(act - exp) < 0.01)
            {
                LogIt("PASS >> " + msg + " >> Actual: " + act + " :: Expected: " + exp, logTyp.Info);
            }
            else
            {
                LogIt("ERROR >>" + msg + " >> Actual: " + act + " :: Expected: " + exp, logTyp.Error);
            }
        }
        //Objective: Matches string expected and actual values, Gives warning when case is different and also when either of them contains each other but <contains> keyword will pass them
        public void Match(string act, string exp, string msg)
        {
            if (act.Trim().Equals(exp.Trim()))
            {
                msg = msg.Replace("<contains>", "");
                LogIt("PASS >> " + msg + " >> Actual: " + act + " :: Expected: " + exp, logTyp.Info);
            }
            else if (act.ToUpper().Trim().Equals(exp.ToUpper().Trim()))
            {
                msg = msg.Replace("<contains>", "");
                LogIt("WARNING matched ignoring  case >> " + msg + " >> Actual: " + act + " :: Expected: " + exp, logTyp.Warn);
            }
            else if (msg.Contains("<contains>"))
            {
                msg = msg.Replace("<contains>", "");
                if (act.Contains(exp.Trim()))
                {
                    LogIt("Matched as Actual contains Expected >> " + msg + " >> Actual: " + act + " :: Expected: " + exp, logTyp.Info);
                }
                else if (exp.Contains(act.Trim()))
                {
                    LogIt("Matched as Expected contains Actual >> " + msg + " >> Actual: " + act + " :: Expected: " + exp, logTyp.Info);
                }
                else
                {
                    LogIt("ERROR >>" + msg + " >> Actual: " + act + " :: Expected: " + exp, logTyp.Error);
                }
            }
            else
            {
                if (act.Contains(exp.Trim()))
                {
                    LogIt("Not matched but Actual contains Expected >> " + msg + " >> Actual: " + act + " :: Expected: " + exp, logTyp.Warn);
                }
                else if (exp.Contains(act.Trim()))
                {
                    LogIt("Not matched but Expected contains Actual >> " + msg + " >> Actual: " + act + " :: Expected: " + exp, logTyp.Warn);
                }
                else
                {
                    LogIt("ERROR >>" + msg + " >> Actual: " + act + " :: Expected: " + exp, logTyp.Error);
                }
            }
        }

        /*----- Wait methods------*/
        //Objective: Halts code till provided seconds of time
        public static void wait(double x)
        {
            LogIt("Waiting for " + x + " second/s", logTyp.Logs);
            Thread.Sleep(Convert.ToInt32(x * 1000));
        }
        //Objective: Waits for given Xpath/ID/CSS untill provided seconds of time
        public static void waitTill(string eleXP, int k)
        {
            double t = 0;
            while (t < k)
            {
                if (IsElepresent(eleXP)) break;
                wait(0.1); t = t + 0.1;
            }
            if (t > 1) LogIt("Waited till " + t + " second/s for " + GetEleLbl(eleXP), logTyp.Info);
        }

        //iOS wait
        //Objective: Waits for given Xpath/ID/CSS untill provided seconds of time
        public static void waitTilliOS(string eleXP, int k)
        {
            double t = 0;
            while (t < k)
            {
                if (IsiOSElepresent(eleXP)) break;
                wait(0.1); t = t + 0.1;
            }
            if (t > 1) LogIt("Waited till " + t + " second/s for " + GetEleLbl(eleXP), logTyp.Info);
        }
        //Objective: Waits for web element untill provided seconds of time
        public static void waitTillW(AppiumWebElement el, int k, string lbl)
        {
            double t = 0;
            while (t < k)
            {
                if (el.Displayed) break;
                wait(0.1); t = t + 0.1;
            }
            if (t > 1) LogIt("Waited till " + t + " second/s for element: " + lbl, logTyp.Info);
        }

        //Objective: Waits for ajax to complete
        public static void WaitForJqueryAjax()
        {
            int delay = 10;
            while (delay > 0)
            {
                Thread.Sleep(1000);
                var jquery = (bool)js.ExecuteScript("return window.jQuery == undefined");
                if (jquery)
                    break;
                var ajaxIsComplete = (bool)js.ExecuteScript("return window.jQuery.active == 0");
                if (ajaxIsComplete)
                    break;
                delay--;
            }
        }

        //Objective: Takes snapshot immediately and stores in Debug\screenshots folder
        public static string getSnapShot()
        {
            string scenNme = TestContext.CurrentContext.Test.Name;
            //string scenName = ScenarioContext.Current.ScenarioInfo.Title;
            string filNm = scenNme + ".png";
            try
            {
                Screenshot screenshot = ((ITakesScreenshot)dr).GetScreenshot();
                screenshot.SaveAsFile(rPath + "\\Screenshots\\" + filNm, ScreenshotImageFormat.Png);
            }
            catch
            {
                filNm = "noScreenshot.png";
                File.Copy(pth + "Misc\\noScreenshot.png", rPath + "\\Screenshots\\noScreenshot.png", false);
            }
            return "Screenshots/" + filNm;
        }

        //Objective: Logs messages, screenshots in report and console and also controls execution
        public static void LogIt(string logMsg, logTyp lt)
        {
            string rMsg = "→ " + Regex.Split(logMsg, ":exc:")[0];

            switch (lt)
            {
                case logTyp.Console: //Logs message on only console for debugging purpose
                    Console.WriteLine(logMsg);
                    break;
                case logTyp.Logs: //Logs message on only log file
                    LogWrite(logMsg);
                    break;
                case logTyp.Info: //Logs message on both report & console
                    if (logg != null) logg.Info(rMsg); LogWrite(logMsg);
                    break;
                case logTyp.Err: //Logs error on both report & console with screenshot on report but continues executing scenario steps
                    if (logg != null) sceneStat = "ERROR"; logg.Error(MarkupHelper.CreateLabel(rMsg, ExtentColor.Pink)); failStep(logMsg);
                    break;
                case logTyp.Error: //Logs error on both report & console with screenshot on report but continues executing scenario steps
                    if (logg != null) sceneStat = "ERROR"; logg.Error(MarkupHelper.CreateLabel(rMsg, ExtentColor.Pink)).AddScreenCaptureFromPath(getSnapShot()); failStep(logMsg);
                    break;
                case logTyp.Fail: //Fails the scenario, skips rest scenarios steps and logs Failure on both report & console with screenshot on report
                    if (logg != null) sceneStat = "ERROR"; logg.Fail(MarkupHelper.CreateLabel("TEST FAILED: " + rMsg, ExtentColor.Red)).AddScreenCaptureFromPath(getSnapShot()); LogWrite("FAIL: " + logMsg); Assert.Fail(logMsg);
                    break;
                case logTyp.Fatal: //Fails the scenario, skips all the scenarios of current feature and logs Failure on both report & console with screenshot on report
                    if (logg != null) sceneStat = "ERROR"; logg.Fatal(MarkupHelper.CreateLabel("FEATURE BLOCKED: " + rMsg, ExtentColor.Orange)).AddScreenCaptureFromPath(getSnapShot()); setProperty("StopFeature", "YES"); LogWrite("FATAL: " + logMsg); Assert.Fail(logMsg);
                    break;
                case logTyp.PassRest: //Passes the scenario, skips next steps of scenario and logs message on both report and logs
                    if (logg != null) logg.Pass(MarkupHelper.CreateLabel(rMsg, ExtentColor.Green)); LogWrite("PASS: " + logMsg + "\nRest steps have been passed based on this."); Assert.Pass();
                    break;
                case logTyp.Pass: //Passes the scenario, skips next steps of scenario and logs message on both report and console
                    if (logg != null) logg.Pass(MarkupHelper.CreateLabel(rMsg, ExtentColor.Green)); LogWrite("PASS: " + logMsg);
                    break;
                case logTyp.Warn: //Logs warning on both report and console with screenshot on report but continues executing scenario steps
                    if (logg != null) sceneStat = "WARN"; logg.Warning(MarkupHelper.CreateLabel(rMsg, ExtentColor.Amber)); LogWrite("WARN: " + logMsg); Assert.Warn(logMsg);
                    break;
                case logTyp.WarnS: //Logs warning on both report and console with screenshot on report but continues executing scenario steps
                    if (logg != null) sceneStat = "WARN"; logg.Warning(MarkupHelper.CreateLabel(rMsg, ExtentColor.Amber)).AddScreenCaptureFromPath(getSnapShot()); LogWrite("WARN: " + logMsg); Assert.Warn(logMsg);
                    break;
                case logTyp.Skip: //Skips current scenario and logs message on both report & console goes to next scenario 
                    if (logg != null) sceneStat = "SKIP"; logg.Skip(MarkupHelper.CreateLabel("TEST SKIPPED: " + rMsg, ExtentColor.Grey)); LogWrite("SKIPPED: " + logMsg); Assert.Inconclusive();
                    break;
                case logTyp.Ignore: //Logs warning on both report and console with screenshot on report but skips executing remaining scenario steps
                    if (logg != null) sceneStat = "WARN"; logg.Warning(MarkupHelper.CreateLabel("TEST IGNORED: " + rMsg, ExtentColor.Cyan)).AddScreenCaptureFromPath(getSnapShot()); LogWrite("IGNORED: " + logMsg); Assert.Ignore(logMsg);
                    break;
                case logTyp.Success: //Logs message on both report & console along with screenshot on report
                    if (logg != null) logg.Info(MarkupHelper.CreateLabel(rMsg, ExtentColor.Green)).AddScreenCaptureFromPath(getSnapShot()); LogWrite("SUCCESS: " + logMsg);
                    break;
                case logTyp.Stop: //Stops execution and skips all remaining tests after this is logged
                    if (logg != null) sceneStat = "STOP"; logg.Skip(MarkupHelper.CreateLabel("TEST EXECUTION STOPPED: " + rMsg, ExtentColor.Grey)); setProperty("StopExecute", "YES"); LogWrite("STOPPED: " + logMsg); Assert.Inconclusive();
                    break;
                default: // just logs warning and continues
                    if (logg != null) sceneStat = "WARN"; logg.Warning(rMsg); LogWrite("UNKNOWN LOGTYPE: " + logMsg); Assert.Warn("Undefined log type" + logMsg);
                    break;
            }
        }

        public static void LogWrite(string logMessage)
        {
            string logPath = rPath + "\\logs.txt";
            try
            {
                using (StreamWriter w = File.AppendText(logPath))
                {
                    try
                    {
                        w.WriteLine("\n{0} :: {1}", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt"), logMessage);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Unable to log: " + ex);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to log: " + ex);
            }
        }



        public static void failStep(string msg)
        {
            try { Assert.Fail(""); }
            catch { LogWrite(msg); Console.WriteLine("ERROR: " + msg); }
        }

        public static void killdriver(string browsr)
        {
            if (browsr.Equals("IE"))
            { foreach (var proc in Process.GetProcessesByName("IEDriverServer")) { proc.Kill(); } }
            else if (browsr.Equals("CR"))
            { foreach (var proc in Process.GetProcessesByName("chromedriver")) { proc.Kill(); } }
            else if (browsr.Equals("FF"))
            { foreach (var proc in Process.GetProcessesByName("geckodriver")) { proc.Kill(); } }
            else if (browsr.Equals("EEL"))
            { foreach (var proc in Process.GetProcessesByName("MicrosoftWebDriver")) { proc.Kill(); } }
            else if (browsr.Equals("EEL"))
            { foreach (var proc in Process.GetProcessesByName("msedgedriver")) { proc.Kill(); } }
            else { }
        }


        /*-----Getting and setting config values and also property values------*/
        //Objective: Gets provided config value from appsettings
        public static string getConfigVal(string key)
        {
            string configVal = null;
            try
            {
                configVal = ConfigurationManager.AppSettings[key];
                if (configVal == null)
                    LogIt("Couldn't get '" + key + "' value from TestAutomation configuration.", logTyp.Error);
                else
                    LogIt("Got '" + key + "' value from TestAutomation configuration as: " + configVal, logTyp.Logs);
            }
            catch (Exception e) { LogIt("Couldn't get '" + key + "' value from TestAutomation configuration.:exc:" + e, logTyp.Error); }

            return configVal;
        }
        //Objective: Sets provided config value in appsettings
        public static void SetConfigVal(string key, string value)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove(key);
                config.AppSettings.Settings.Add(key, value);
                config.Save(ConfigurationSaveMode.Full, true);
                ConfigurationManager.RefreshSection("appSettings");
                LogIt("Added key: '" + key + "' with value: " + value + " in TestAutomation configuration", logTyp.Logs);
            }
            catch (Exception e)
            {
                LogIt("Could not add key: '" + key + "' with value: " + value + " in TestAutomation configuration:exc:" + e, logTyp.Error);
            }
        }
        //Objective: Gets provided property value from TestAutomation properties
        public static string getProperty(string prop)
        {
            string pth = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\"));
            string FileName = pth + "Properties\\Test.properties";
            string key = "NoKey"; string val = "NoValue";
            foreach (string row in File.ReadAllLines(FileName))
            {
                key = row.Split('=')[0].Trim();
                if (key.Equals(prop, StringComparison.OrdinalIgnoreCase))
                {
                    val = row.Replace(key + " = ", "").Trim();
                    break;
                }
            }
            LogIt("Got value" + val + " for Key: " + key + " from Test.properties", logTyp.Logs);
            return val.Contains('#') ? val.Split('#')[0].Trim() : val;
        }
        //Objective: Sets provided property value in TestAutomation properties
        public static void setProperty(string prop, string value)
        {
            string pth = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\"));
            string FileName = pth + "Properties\\Test.properties";
            string key = "NoKey"; string val = "NoValue";
            foreach (string row in File.ReadAllLines(FileName))
            {
                key = row.Split('=')[0].Trim();
                if (key.Equals(prop, StringComparison.OrdinalIgnoreCase))
                {
                    val = row;
                    break;
                }
            }
            if (val.Equals("NoValue"))
                File.AppendAllText(FileName, Environment.NewLine + prop + " = " + value);
            else
                File.WriteAllText(FileName, File.ReadAllText(FileName).Replace(val, prop + " = " + value));

            LogIt("Updated " + prop + " = " + value + " in Test.properties", logTyp.Console);
        }

        //Objective: Get map values using key
        public string getMapVal(Dictionary<string, string> dict, string key)
        {
            if (dict != null && dict.ContainsKey(key))
                return dict[key];
            else return null;
        }

        //public static AppiumLocalService service;

        //public AppiumLocalService StartAppiumServer()
        //{​​​​
        //bool flag = checkServerIsRunning(4723);
        //    if (!flag)
        //    {​​​​
        //service = AppiumLocalService.BuildDefaultService();
        //        service.Start();
        //    }​​​​
        //return service;
        //}​​​​
       
        /*-------if required to get xpath of an identified webelement------*/
        public static string getAbsoluteXPath(AppiumWebElement element)
        {
            return (string)js.ExecuteScript(
                    "function absoluteXPath(element) {" +
                            "var comp, comps = [];" +
                            "var parent = null;" +
                            "var xpath = '';" +
                            "var getPos = function(element) {" +
                            "var position = 1, curNode;" +
                            "if (element.nodeType == Node.ATTRIBUTE_NODE) {" +
                            "return null;" +
                            "}" +
                            "for (curNode = element.previousSibling; curNode; curNode = curNode.previousSibling) {" +
                            "if (curNode.nodeName == element.nodeName) {" +
                            "++position;" +
                            "}" +
                            "}" +
                            "return position;" +
                            "};" +

                            "if (element instanceof Document) {" +
                            "return '/';" +
                            "}" +

                            "for (; element && !(element instanceof Document); element = element.nodeType == Node.ATTRIBUTE_NODE ? element.ownerElement : element.parentNode) {" +
                            "comp = comps[comps.length] = {};" +
                            "switch (element.nodeType) {" +
                            "case Node.TEXT_NODE:" +
                            "comp.name = 'text()';" +
                            "break;" +
                            "case Node.ATTRIBUTE_NODE:" +
                            "comp.name = '@' + element.nodeName;" +
                            "break;" +
                            "case Node.PROCESSING_INSTRUCTION_NODE:" +
                            "comp.name = 'processing-instruction()';" +
                            "break;" +
                            "case Node.COMMENT_NODE:" +
                            "comp.name = 'comment()';" +
                            "break;" +
                            "case Node.ELEMENT_NODE:" +
                            "comp.name = element.nodeName;" +
                            "break;" +
                            "}" +
                            "comp.position = getPos(element);" +
                            "}" +

                            "for (var i = comps.length - 1; i >= 0; i--) {" +
                            "comp = comps[i];" +
                            "xpath += '/' + comp.name.toLowerCase();" +
                            "if (comp.position !== null) {" +
                            "xpath += '[' + comp.position + ']';" +
                            "}" +
                            "}" +

                            "return xpath;" +

                            "} return absoluteXPath(arguments[0]);", element);
        }
       public void Actiondownandenter()
        {
            Actions actions = new Actions(dr);
            actions.SendKeys(Keys.ArrowDown).Perform();
            actions.SendKeys(Keys.ArrowDown).Perform();

            actions.SendKeys(Keys.Enter).Perform();

            Console.WriteLine("Successfully selected the dropdown value");
        }
        public void ActionTab()
        {
            Actions actions = new Actions(dr);

            actions.SendKeys(Keys.Tab).Perform();
            actions.SendKeys(Keys.Tab).Perform();

          
            Console.WriteLine("Successfully selected the dropdown value");
        }
        public void MobileScrollTotext(string value)
        {
            try
            {
                bool isElementFound = false;
                int maxScrollAttempts = 10; // Limit to avoid infinite loops
                int currentAttempt = 0;

                while (!isElementFound && currentAttempt < maxScrollAttempts)
                {
                    try
                    {
                        // Try to locate the element with the specified value
                        var element = dr.FindElement(MobileBy.AndroidUIAutomator(
                            "new UiScrollable(new UiSelector().scrollable(true).instance(0))" +
                            $".scrollIntoView(new UiSelector().text(\"{value}\"))"
                        ));
                    
                        if (element != null)
                        {
                            isElementFound = true;
                            LogIt($"Successfully scrolled to the value: {value}", logTyp.Info);
                        }
                    }
                    catch (NoSuchElementException)
                    {
                        // Element not found yet, continue scrolling
                        currentAttempt++;
                        var scrollableElement = "new UiScrollable(new UiSelector().scrollable(true).instance(0))" +
                                                ".scrollForward()";
                        dr.FindElement(MobileBy.AndroidUIAutomator(scrollableElement));
                    }
                }

                if (!isElementFound)
                {
                    LogIt($"Could not find the value: {value} after {maxScrollAttempts} attempts.", logTyp.Fail);
                }
            }
            catch (Exception e)
            {
                LogIt($"An error occurred while scrolling to the value: {value}. Exception: {e.Message}", logTyp.Fail);
            }
        }

        public void SelectDropdownValueWithJavaScript(string dropdownScript)
        {
            try
            {
                dr.ExecuteScript(dropdownScript);
                LogIt("Dropdown value selected via JavaScript.", logTyp.Info);
            }
            catch (Exception e)
            {
                LogIt($"Error executing JavaScript for dropdown selection. Exception: {e.Message}", logTyp.Fail);
            }
        }
        public void Implicit(int seconds)
        {
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }

        public void ScrollToOption(string eleXP, string txt)
        {
            SelectByVisibleText(GetElement(eleXP), GetEleLbl(eleXP), txt);
        }

        public void SelectByVisibleText(AppiumWebElement element, string label, string visibleText)
        {
            try
            {
                // Initialize SelectElement for the dropdown
                SelectElement selectElement = new SelectElement(element);

                // Get the currently selected option
                string currentSelection;
                try
                {
                    currentSelection = selectElement.SelectedOption.Text;
                }
                catch
                {
                    currentSelection = "<<nothing>>";
                }

                // Check if the desired text is already selected
                if (currentSelection.Equals("<<nothing>>") || !currentSelection.Equals(visibleText))
                {
                    // Select the option by visible text
                    selectElement.SelectByText(visibleText);
                    LogIt($"Selected: {visibleText} from element: {label}", logTyp.Info);
                }
                else
                {
                    LogIt($"Dropdown already has value: {visibleText}", logTyp.Info);
                }
            }
            catch (Exception ex)
            {
                LogIt($"Could not select: {visibleText} from element: {label}. Exception: {ex.Message}", logTyp.Fail);
            }
        }
        public void ScrollToOption(AppiumDriver<AndroidElement> driver, string spinnerId, string optionText)
        {
            try
            {
                // Locate and click the spinner
                var spinner = driver.FindElementById(spinnerId);
                spinner.Click();

                // Perform swipe until the desired option is visible
                bool isOptionVisible = false;
                while (!isOptionVisible)
                {
                    try
                    {
                        var option = driver.FindElement(By.XPath($"//android.widget.TextView[@text='{optionText}']"));
                        option.Click();
                        isOptionVisible = true;

                        Console.WriteLine($"Successfully selected option: {optionText}");
                    }
                    catch
                    {
                        // Perform swipe
                        var size = driver.Manage().Window.Size;
                        int startX = size.Width / 2;
                        int startY = (int)(size.Height * 0.8);
                        int endY = (int)(size.Height * 0.2);

                        new TouchAction(driver)
                            .Press(startX, startY)
                            .Wait(500)
                            .MoveTo(startX, endY)
                            .Release()
                            .Perform();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while selecting spinner option: {ex.Message}");
            }
        }

        public bool IsTextDisplayed(string locatorValue)
        {
            try
            {
                // Find the element using the provided locator
                var element = dr.FindElement(getByLoc(locatorValue));

                // Assert if the element is displayed
                Assert.IsTrue(element.Displayed, $"The element located by '{locatorValue}' is not displayed.");
                return true; 
            }
            catch (NoSuchElementException)
            {
                // Assert failure if the element is not found
                Assert.Fail($"Element not found using locator: '{locatorValue}'");
                return false; 
            }
            catch (Exception ex)
            {
                // Handle any unexpected errors
                Assert.Fail($"An unexpected error occurred: {ex.Message}");
                return false; 
            }
        }


    }
}
