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
    ///The ValidateCustomBidProposalReportOutput recording.
    /// </summary>
    [TestModule("c72ff7a6-47fa-4473-8ec4-5be94722d871", ModuleType.Recording, 1)]
    public partial class ValidateCustomBidProposalReportOutput : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static ValidateCustomBidProposalReportOutput instance = new ValidateCustomBidProposalReportOutput();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateCustomBidProposalReportOutput()
        {
            ScriptLocation = "W:\\HBDaily\\InstallAutomation\\Script";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateCustomBidProposalReportOutput Instance
        {
            get { return instance; }
        }

#region Variables

        string _ScriptLocation;

        /// <summary>
        /// Gets or sets the value of variable ScriptLocation.
        /// </summary>
        [TestVariable("8c8517c6-993f-499f-ac71-0f60e0ad7a2a")]
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

            Report.Log(ReportLevel.Info, "Application", "Run application 'runCustomizedBidProposal.bat' with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("runCustomizedBidProposal.bat", "", ScriptLocation, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(1));
            Delay.Duration(5000, false);
            
            CustomizedBidProposalExists();
            Delay.Milliseconds(0);
            
            ValidateContentCustomizedBidProposal();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Escape}'.", new RecordItemIndex(4));
            Keyboard.Press("{Escape}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
