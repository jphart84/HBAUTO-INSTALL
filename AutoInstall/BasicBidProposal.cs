﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace AutoInstall
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BasicBidProposal recording.
    /// </summary>
    [TestModule("83914a44-0934-4d9a-806a-a1979e78e015", ModuleType.Recording, 1)]
    public partial class BasicBidProposal : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static BasicBidProposal instance = new BasicBidProposal();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BasicBidProposal()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BasicBidProposal Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Tabs.ReportTab' at Center.", repo.HeavyBidApp.Tabs.ReportTabInfo, new RecordItemIndex(0));
            repo.HeavyBidApp.Tabs.ReportTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Buttons.Report.SummaryReportsButton' at Center.", repo.HeavyBidApp.Buttons.Report.SummaryReportsButtonInfo, new RecordItemIndex(1));
            repo.HeavyBidApp.Buttons.Report.SummaryReportsButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.DocumentInterface.Reports.SummaryReports.ConciseBidProposal' at Center.", repo.HeavyBidApp.DocumentInterface.Reports.SummaryReports.ConciseBidProposalInfo, new RecordItemIndex(2));
            repo.HeavyBidApp.DocumentInterface.Reports.SummaryReports.ConciseBidProposal.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.DocumentInterface.TextRadioButtonExport' at Center.", repo.HeavyBidApp.DocumentInterface.TextRadioButtonExportInfo, new RecordItemIndex(3));
            repo.HeavyBidApp.DocumentInterface.TextRadioButtonExport.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'HeavyBidApp.DocumentInterface.Reports.SummaryReports.ConciseBidProposal' at Center.", repo.HeavyBidApp.DocumentInterface.Reports.SummaryReports.ConciseBidProposalInfo, new RecordItemIndex(4));
            repo.HeavyBidApp.DocumentInterface.Reports.SummaryReports.ConciseBidProposal.DoubleClick();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBReportViewers.SaveAsExport.FilePathURL' at CenterRight.", repo.HBReportViewers.SaveAsExport.FilePathURLInfo, new RecordItemIndex(5));
            repo.HBReportViewers.SaveAsExport.FilePathURL.Click(Location.CenterRight);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'W:\\HBDaily\\InstallAutomation\\HBReportsExportFiles{Return}'.", new RecordItemIndex(6));
            Keyboard.Press("W:\\HBDaily\\InstallAutomation\\HBReportsExportFiles{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBReportViewers.SaveAsExport.FileName' at Center.", repo.HBReportViewers.SaveAsExport.FileNameInfo, new RecordItemIndex(7));
            repo.HBReportViewers.SaveAsExport.FileName.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ConciseBidProposal.txt'.", new RecordItemIndex(8));
            Keyboard.Press("ConciseBidProposal.txt");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBReportViewers.SaveAsExport.SaveButton' at Center.", repo.HBReportViewers.SaveAsExport.SaveButtonInfo, new RecordItemIndex(9));
            repo.HBReportViewers.SaveAsExport.SaveButton.Click();
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'HBReportViewers.ConfirmSaveAs.YesButton' at Center.", repo.HBReportViewers.ConfirmSaveAs.YesButtonInfo, new RecordItemIndex(10));
                repo.HBReportViewers.ConfirmSaveAs.YesButton.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBReportViewers.PrintToFile.NoButton' at Center.", repo.HBReportViewers.PrintToFile.NoButtonInfo, new RecordItemIndex(11));
            repo.HBReportViewers.PrintToFile.NoButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(12));
            Delay.Duration(10000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
