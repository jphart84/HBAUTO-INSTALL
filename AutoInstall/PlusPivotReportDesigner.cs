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
    ///The PlusPivotReportDesigner recording.
    /// </summary>
    [TestModule("93bcf539-70b4-4c3d-ae01-ed7828f6ed04", ModuleType.Recording, 1)]
    public partial class PlusPivotReportDesigner : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static PlusPivotReportDesigner instance = new PlusPivotReportDesigner();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PlusPivotReportDesigner()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PlusPivotReportDesigner Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Tabs.QueryTab' at Center.", repo.HeavyBidApp.Tabs.QueryTabInfo, new RecordItemIndex(0));
            repo.HeavyBidApp.Tabs.QueryTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Buttons.Query.PivotReportsButton' at Center.", repo.HeavyBidApp.Buttons.Query.PivotReportsButtonInfo, new RecordItemIndex(1));
            repo.HeavyBidApp.Buttons.Query.PivotReportsButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'HeavyBidApp.DocumentInterface.Reports.ReportsPlusPivot.ReportDesigner' at Center.", repo.HeavyBidApp.DocumentInterface.Reports.ReportsPlusPivot.ReportDesignerInfo, new RecordItemIndex(2));
            repo.HeavyBidApp.DocumentInterface.Reports.ReportsPlusPivot.ReportDesigner.DoubleClick();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(3));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'HBReportViewers.HeavyBidPivotReports.CloseButton'.", repo.HBReportViewers.HeavyBidPivotReports.CloseButtonInfo, new RecordItemIndex(4));
            Host.Current.CloseApplication(repo.HBReportViewers.HeavyBidPivotReports.CloseButton, new Duration(0));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
