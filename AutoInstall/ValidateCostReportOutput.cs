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
    ///The ValidateCostReportOutput recording.
    /// </summary>
    [TestModule("90fff12e-39e9-48c1-b93a-3043239bad50", ModuleType.Recording, 1)]
    public partial class ValidateCostReportOutput : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static ValidateCostReportOutput instance = new ValidateCostReportOutput();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateCostReportOutput()
        {
            ScriptLocation = "\\\\hbtestserv\\HeavyBidShare\\HBDaily\\InstallAutomation\\Script";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateCostReportOutput Instance
        {
            get { return instance; }
        }

#region Variables

        string _ScriptLocation;

        /// <summary>
        /// Gets or sets the value of variable ScriptLocation.
        /// </summary>
        [TestVariable("8c04682d-bb06-468f-bf91-b671991e3ae0")]
        public string ScriptLocation
        {
            get { return _ScriptLocation; }
            set { _ScriptLocation = value; }
        }

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

            Report.Log(ReportLevel.Info, "Application", "Run application 'runCostReport.bat' with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("runCostReport.bat", "", ScriptLocation, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(1));
            Delay.Duration(5000, false);
            
            CostReportExists();
            Delay.Milliseconds(0);
            
            ValidateContentCostReport();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
