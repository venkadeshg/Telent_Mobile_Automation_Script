using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.MarkupUtils;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;

namespace TestAutomation.Common
{
    [Binding]
    public sealed class Hooks : Base
    {
        static GeneralLibraries GL = new GeneralLibraries();
        static string featureStatus;
        static Dictionary<string, string> scenes = new Dictionary<string, string>();
        static int testCount = 1;
        static string lastScene = "";
        
        [BeforeTestRun]
        public static void InitializeReport()
        {
            //StartEmulator();
            Directory.CreateDirectory(rPath + "\\Screenshots\\");
            //Set stop execute property to NO if it was changed by manually or due to previos failures
            setProperty("StopExecute", "NO");
            
            xltbl.Columns.Add("Feature", typeof(string));
            xltbl.Columns.Add("Tests per scenario", typeof(string));
            xltbl.Columns.Add("Scenario", typeof(string));
            xltbl.Columns.Add("Status", typeof(string));
            xltbl.Columns.Add("Scenario Status", typeof(string));
        }

        [AfterTestRun]
        public static void AfterTest()
        {
            string sub = "MOBILE: CONSOLIDATED DAILY CHECK AUTOMATION REPORT ";
            //string htmlString = @"<html>
            //          <body>
            //          <p>Dear All,</p>
            //          <p>Please find the attached zip file, it contains the execution summary report (in excel and in html also), logs and screenshots.</p>
            //          <p>Thanks,<br>SOP Team</br></p>
            //          </body>
            //          </html>
            //            ";

            //Create extent report
            createExtentReport();
            
            //Create excel report
            //createExcelReport();
            //sendReportViaEmail(true, sub);//, htmlString);
            dr.Quit();

            //if (!exeProc.WaitForExit(5000))
            //{
            //    if (!exeProc.HasExited)
            //    {
            //        exeProc.Kill();
            //    }
            //}
            //exeProc.Kill();

            //sendEmail(rPath);

        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext fc)
        {
            FeatureName = Extent.CreateTest<Feature>(fc.FeatureInfo.Title + ": " + fc.FeatureInfo.Description);
            setProperty("StopFeature", "NO");
        }

        [AfterFeature]
        public static void AfterFeature(FeatureContext fc)
        {
            //Adds Feature status in excel report
            xltbl.Rows.Add(fc.FeatureInfo.Title, "", scenes.Count.ToString() + " Scenario/s", featureStatus, "");
            //Adds scenario status in excel report.
            /*foreach (var scene in scenes)
            {
                xltbl.Rows.Add("", Regex.Split(scene.Value, "#:#")[1], scene.Key, Regex.Split(scene.Value, "#:#")[0], ScenarioContext.Current.ScenarioExecutionStatus.ToString());
            }*/
            scenes.Clear();

        }


        [BeforeScenario]
        public static void BeforeScenario(ScenarioContext scenarioContext)
        {
            //Launch the browser
            testCount = lastScene.Equals(scenarioContext.ScenarioInfo.Title) ? testCount + 1 : 1;
            lastScene = scenarioContext.ScenarioInfo.Title; sceneStat = "PASS";
            scenarioName = FeatureName.CreateNode<Scenario>(lastScene);
            //Below code is to check whether to continue execution or current feature based on previous scenario status
            if (getProperty("StopExecute").Equals("YES")) LogIt("Test execution has been stopped", logTyp.Skip);
            if (getProperty("StopFeature").Equals("YES")) LogIt("Feature execution stopped due to previous fatal error", logTyp.Skip);
        }

        [AfterScenario]
        public static void AfterScenario(ScenarioContext scenarioContext)
        {
            //dr.Quit();
            //For excel report
            //scenes[scenarioContext.ScenarioInfo.Title] = sceneStat + "#:#" + testCount.ToString();
            //featureStatus = sceneStat.Equals("ERROR") ? "FAILED" : sceneStat.Equals("PASS") ? "PASSED" : sceneStat.Equals("WARN") ? "WARNING" : "SKIPPED";

            //if (featureStatus == "FAILED")
            //{
            //    string sub = scenarioContext.ScenarioInfo.Title;
            //    //string htmlString = @"<html>
            //    //      <body>
            //    //      <p>Dear All,</p>
            //    //      <p>The test execution got failed for the mentioned scenario.
            //    //         The screenshots and log files are attached in a zip file for your reference.</p>
            //    //      <p>Thanks,<br>SOP Team</br></p>
            //    //      </body>
            //    //      </html>
            //    //        ";

            //    //reportsAndEmails();
            //    sendReportViaEmail(false, sub);//, htmlString);
            //}
        }

        [BeforeStep]
        public void BeforeStep()
        {
            var StepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            if (StepType == "Given")
                logg = scenarioName.CreateNode<Given>("₲ : " + ScenarioStepContext.Current.StepInfo.Text);
            else if (StepType == "When")
                logg = scenarioName.CreateNode<When>("₩ : " + ScenarioStepContext.Current.StepInfo.Text);
            else if (StepType == "Then")
                logg = scenarioName.CreateNode<Then>("₸ : " + ScenarioStepContext.Current.StepInfo.Text);
            else
                logg = scenarioName.CreateNode<And>("₳ : " + ScenarioStepContext.Current.StepInfo.Text);
        }

        [AfterStep]
        public void AfterStep()
        {
            //After step stuffs
        }

        public static void emptyFolder(string pth)
        {
            bool del = true;
            System.IO.DirectoryInfo di = new DirectoryInfo(pth);
            foreach (FileInfo file in di.GetFiles())
                try
                {
                    file.Delete();
                }
                catch (Exception e) { LogIt("Couldn't delete file: " + file.FullName, logTyp.Warn); del = false; }
            if (del == true) LogIt("Deleted all files inside screenshots ", logTyp.Console);
        }
        public static void createExtentReport()
        {
            //string Report = "TestReport_" + System.DateTime.Now.ToString("yyyy-MM-dd_") + System.DateTime.Now.ToString("HH") + "h" + System.DateTime.Now.ToString("mm") + "m";
            //rPath = Path.GetFullPath(Path.Combine(pth, "..\\..\\")) + "TestResults\\" + Report + ".html";
            //var HtmlReporter = new ExtentV3HtmlReporter(@rPath);
            //HtmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            //HtmlReporter.Config.ReportName = "Test Automation Report: " + appVer + " _________________________________________________________ Browser: " + brNm + " ( " + brVer + " ) _________________________________________________________ Reported by: " + Environment.UserName;
            //Extent.AttachReporter(HtmlReporter);

                var HtmlReporter = new ExtentHtmlReporter(rPath + "\\TestReport.html");
                HtmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
                HtmlReporter.Config.ReportName = "Test Automation Report: " + appVer + " _____________________________________________________________________________ Browser: " + brNm + " ( " + brVer + " ) ___________________________________________________________ Reported by: " + Environment.UserName;
                Extent.AttachReporter(HtmlReporter);
                Extent.Flush();
                if (File.Exists(rPath + "\\index.html")) File.Move(rPath + "\\index.html", rPath + "\\TestReport.html");

            }
            public static void createExcelReport()
        {
            //string xlR = Path.GetFullPath(Path.Combine(pth, "..\\..\\")) + "TestResults\\ExcelReports\\";
            //string xlReportNm = xlR + "TestReport_" + DateTime.Now.ToString("yyyy-MM-dd_") + DateTime.Now.ToString("HH") + "h" + DateTime.Now.ToString("mm") + "m" + ".xlsx";
            //File.Copy(@xlR + "Template.xlsx", @xlReportNm);
            //GL.ExportToExcel(xltbl, xlReportNm);

            File.Copy(@pth + "Misc\\Template.xlsx", @rPath + "\\TestReport.xlsx");
            GL.ExportToExcel(xltbl, @rPath + "\\TestReport.xlsx");

        }

        public static void sendReportViaEmail(bool zipp, string sub)// string htmlString)
        {
            //string attachment;
            string zipPath;
            string htmlString;


            //if (zipp == false)
            //{
            //    ////zipPath = rPath + "_FAILED.zip";
            //    ////ZipFile.CreateFromDirectory(rPath, zipPath);
            //    //attachment = rPath + "_FAILED.zip";

            //}
            //else
            //{
            //    //zipPath = rPath + ".zip";
            //    //ZipFile.CreateFromDirectory(rPath, zipPath);
            //}

            //SmtpClient smtp = new SmtpClient();
            //var basicCredential = new NetworkCredential(getConfigVal("EMAIL"), getConfigVal("EMAIL_PWD"));

            using (MailMessage message = new MailMessage())
            {
                //MailAddress fromAddress = new MailAddress("MembershipPortalAlerts@themdu.com");
                MailAddress fromAddress = new MailAddress("Natarajan.Rajendiran@DEV.MDU.local");

                //Live Box Host
                //smtp.Host = "mail.themdu.com";
                //Dev Box Host

                message.From = fromAddress;
                if (zipp == false)
                {
                    htmlString = @"<html>
                      <body>
                      <p>Dear All,</p>
                      <p>The test execution got failed for the mentioned scenario.
                         The screenshots and log files are attached in a zip file for your reference.</p>
                      <p>Thanks,<br>SOP Team</br></p>
                      </body>
                      </html>
                        ";
                    zipPath = rPath + "_FAILED.zip";
                    ZipFile.CreateFromDirectory(rPath, zipPath);
                    message.Subject = "MOBILE: TEST_FAILED_FOR_" + sub + "_" + DateTime.Now.ToString("dd-MM-yyyy");
                    message.IsBodyHtml = true;
                    message.Body = htmlString;
                    foreach (string eml in getConfigVal("FAILED_TO_EMAILS").Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
                        message.To.Add(eml);

                }
                else
                {
                    htmlString = @"<html>
                      <body>
                      <p>Dear All,</p>
                      <p>Please find the attached zip file, it contains the execution summary report (in excel and in html also), logs and screenshots.</p>
                      <p>Thanks,<br>SOP Team</br></p>
                      </body>
                      </html>
                        ";
                    zipPath = rPath + ".zip";
                    ZipFile.CreateFromDirectory(rPath, zipPath);
                    message.Subject = sub + DateTime.Now.ToString("dd-MM-yyyy");
                    message.IsBodyHtml = true;
                    message.Body = htmlString;
                    foreach (string eml in getConfigVal("PASSED_TO_EMAILS").Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
                        message.To.Add(eml);
                }
                //message.Subject = "Daily check automated report for " + DateTime.Now.ToString("dd-MM-yyyy");
                //message.IsBodyHtml = true;
                //string htmlString = @"<html>
                //      <body>
                //      <p>Dear All,</p>
                //      <p>Please find the attached zip file, it contains the execution summary report (in excel and in html also), logs and screenshots.</p>
                //      <p>Thanks,<br>SOP Team</br></p>
                //      </body>
                //      </html>
                //        ";

                //message.Body = " < h1>Test Report of Daily check</h1>";
                //message.Body = htmlString;
                //foreach (string eml in getConfigVal("TO_EMAILS").Split(','))
                //    //message.To.Add("Natarajan.Rajendiran@DEV.MDU.local");
                //    message.To.Add(eml);
                try
                {
                    message.Attachments.Add(new Attachment(zipPath));
                }
                catch (Exception exc) { LogIt("Couldn't find latest report :exc:" + exc, logTyp.Warn); }

                try
                {
                    SmtpClient smtp = new SmtpClient("mail.dev.mdu.local", 25)
                    //SmtpClient smtp = new SmtpClient("mail.themdu.com", 25)
                    {
                        //smtp.Host = "mail.dev.mdu.local";
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(getConfigVal("EMAIL"), getConfigVal("EMAIL_PWD")),
                        //Credentials = new NetworkCredential(getConfigVal("EMAIL"), "Al3rt$&N0t1fications++"),
                        //smtp.Port = 25;
                        EnableSsl = false
                    };

                    smtp.Send(message);
                }
                catch (Exception exc)
                {
                    //Error, could not send the message
                    LogIt("Couldn't email reports :exc:" + exc, logTyp.Warn);
                }
            }
        }

    }
}
