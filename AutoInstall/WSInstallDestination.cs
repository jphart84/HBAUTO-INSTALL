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
    ///The WSInstallDestination recording.
    /// </summary>
    [TestModule("869e9047-90b5-4d65-a424-4d6c5251ae26", ModuleType.Recording, 1)]
    public partial class WSInstallDestination : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static WSInstallDestination instance = new WSInstallDestination();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WSInstallDestination()
        {
            WSInstallLocation = "C:\\HeavyBidWS\\";
            currentVersion = "2019";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static WSInstallDestination Instance
        {
            get { return instance; }
        }

#region Variables

        string _WSInstallLocation;

        /// <summary>
        /// Gets or sets the value of variable WSInstallLocation.
        /// </summary>
        [TestVariable("c27233f0-c749-43ba-8541-7f938e8a17ee")]
        public string WSInstallLocation
        {
            get { return _WSInstallLocation; }
            set { _WSInstallLocation = value; }
        }

        string _currentVersion;

        /// <summary>
        /// Gets or sets the value of variable currentVersion.
        /// </summary>
        [TestVariable("8f2bd2f5-36dd-454a-a27d-9978a3b4d8b0")]
        public string currentVersion
        {
            get { return _currentVersion; }
            set { _currentVersion = value; }
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
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegex (Text~'Workstation') on item 'HeavyBidServerSetup.TextContainersForValidation.Titlebar'.", repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, new RecordItemIndex(1));
                Validate.AttributeRegex(repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, "Text", new Regex("Workstation"), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegex (Text~$currentVersion) on item 'HeavyBidServerSetup.TextContainersForValidation.Titlebar'.", repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, new RecordItemIndex(2));
                Validate.AttributeRegex(repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, "Text", new Regex(currentVersion), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text=$WSInstallLocation) on item 'HeavyBidServerSetup.TextContainersForValidation.DestinationFolderScreen.FilepathTextbox'.", repo.HeavyBidServerSetup.TextContainersForValidation.DestinationFolderScreen.FilepathTextboxInfo, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.HeavyBidServerSetup.TextContainersForValidation.DestinationFolderScreen.FilepathTextboxInfo, "Text", WSInstallLocation, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 30s to exist. Associated repository item: 'HeavyBidServerSetup.Buttons.NextButton'", repo.HeavyBidServerSetup.Buttons.NextButtonInfo, new ActionTimeout(30000), new RecordItemIndex(4));
                repo.HeavyBidServerSetup.Buttons.NextButtonInfo.WaitForExists(30000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'HeavyBidServerSetup.Buttons.NextButton' at Center.", repo.HeavyBidServerSetup.Buttons.NextButtonInfo, new RecordItemIndex(5));
                repo.HeavyBidServerSetup.Buttons.NextButton.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
