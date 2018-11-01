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
    ///The ConfirmHBInstallFinish recording.
    /// </summary>
    [TestModule("43bbaf7d-2b67-498d-9ab4-5e9794b98f8f", ModuleType.Recording, 1)]
    public partial class ConfirmHBInstallFinish : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static ConfirmHBInstallFinish instance = new ConfirmHBInstallFinish();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ConfirmHBInstallFinish()
        {
            HBInstallLocation = "C:\\HeavyBid\\";
            currentVersion = "2019";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ConfirmHBInstallFinish Instance
        {
            get { return instance; }
        }

#region Variables

        string _currentVersion;

        /// <summary>
        /// Gets or sets the value of variable currentVersion.
        /// </summary>
        [TestVariable("6f040a5d-39be-430a-85e8-482002743329")]
        public string currentVersion
        {
            get { return _currentVersion; }
            set { _currentVersion = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable HBInstallLocation.
        /// </summary>
        [TestVariable("c3a112bd-b56e-42d3-ba27-0d1d1cc78000")]
        public string HBInstallLocation
        {
            get { return repo.HBInstallLocation; }
            set { repo.HBInstallLocation = value; }
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

            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegex (Text~'HeavyBid') on item 'HeavyBidServerSetup.TextContainersForValidation.Titlebar'.", repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, new RecordItemIndex(0));
                Validate.AttributeRegex(repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, "Text", new Regex("HeavyBid"), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegex (Text~'Setup') on item 'HeavyBidServerSetup.TextContainersForValidation.Titlebar'.", repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, new RecordItemIndex(1));
                Validate.AttributeRegex(repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, "Text", new Regex("Setup"), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegex (Text~$currentVersion) on item 'HeavyBidServerSetup.TextContainersForValidation.Titlebar'.", repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, new RecordItemIndex(2));
                Validate.AttributeRegex(repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, "Text", new Regex(currentVersion), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$HBInstallLocation) on item 'HeavyBidServerSetup.TextContainersForValidation.ReadyToInstallScreen.ConfirmFilepathTextbox'.", repo.HeavyBidServerSetup.TextContainersForValidation.ReadyToInstallScreen.ConfirmFilepathTextboxInfo, new RecordItemIndex(3));
                Validate.AttributeContains(repo.HeavyBidServerSetup.TextContainersForValidation.ReadyToInstallScreen.ConfirmFilepathTextboxInfo, "Text", HBInstallLocation, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'HeavyBidServerSetup.Buttons.InstallButton'", repo.HeavyBidServerSetup.Buttons.InstallButtonInfo, new ActionTimeout(60000), new RecordItemIndex(4));
            repo.HeavyBidServerSetup.Buttons.InstallButtonInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidServerSetup.Buttons.InstallButton' at Center.", repo.HeavyBidServerSetup.Buttons.InstallButtonInfo, new RecordItemIndex(5));
            repo.HeavyBidServerSetup.Buttons.InstallButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15m to exist. Associated repository item: 'HeavyBidServerSetup.Buttons.FinishButton'", repo.HeavyBidServerSetup.Buttons.FinishButtonInfo, new ActionTimeout(900000), new RecordItemIndex(6));
            repo.HeavyBidServerSetup.Buttons.FinishButtonInfo.WaitForExists(900000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidServerSetup.Buttons.FinishButton' at Center.", repo.HeavyBidServerSetup.Buttons.FinishButtonInfo, new RecordItemIndex(7));
            repo.HeavyBidServerSetup.Buttons.FinishButton.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
