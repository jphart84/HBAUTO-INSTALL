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
    ///The SelectInstallType recording.
    /// </summary>
    [TestModule("b91e1761-7016-4fc5-98f3-58e57f71eb46", ModuleType.Recording, 1)]
    public partial class SelectInstallType : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static SelectInstallType instance = new SelectInstallType();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectInstallType()
        {
            currentVersion = "2020";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectInstallType Instance
        {
            get { return instance; }
        }

#region Variables

        string _currentVersion;

        /// <summary>
        /// Gets or sets the value of variable currentVersion.
        /// </summary>
        [TestVariable("1d235b6c-2fd7-4980-9ab9-58499544f2f3")]
        public string currentVersion
        {
            get { return _currentVersion; }
            set { _currentVersion = value; }
        }

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
            
            // B.5
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.5\r\nValidating AttributeRegex (Enabled~'') on item 'HeavyBidServerSetup.InstallTypes.StandaloneInstallType'.", repo.HeavyBidServerSetup.InstallTypes.StandaloneInstallTypeInfo, new RecordItemIndex(3));
                Validate.AttributeRegex(repo.HeavyBidServerSetup.InstallTypes.StandaloneInstallTypeInfo, "Enabled", new Regex(""), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            // B.5
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.5\r\nValidating AttributeRegex (Enabled~'') on item 'HeavyBidServerSetup.InstallTypes.MultiUserInstallType'.", repo.HeavyBidServerSetup.InstallTypes.MultiUserInstallTypeInfo, new RecordItemIndex(4));
                Validate.AttributeRegex(repo.HeavyBidServerSetup.InstallTypes.MultiUserInstallTypeInfo, "Enabled", new Regex(""), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            // B.5
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.5\r\nValidating AttributeRegex (Enabled~'') on item 'HeavyBidServerSetup.InstallTypes.TrainingInstallType'.", repo.HeavyBidServerSetup.InstallTypes.TrainingInstallTypeInfo, new RecordItemIndex(5));
                Validate.AttributeRegex(repo.HeavyBidServerSetup.InstallTypes.TrainingInstallTypeInfo, "Enabled", new Regex(""), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidServerSetup.InstallTypes.MultiUserInstallType' at Center.", repo.HeavyBidServerSetup.InstallTypes.MultiUserInstallTypeInfo, new RecordItemIndex(6));
            repo.HeavyBidServerSetup.InstallTypes.MultiUserInstallType.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'HeavyBidServerSetup.Buttons.NextButton'", repo.HeavyBidServerSetup.Buttons.NextButtonInfo, new ActionTimeout(60000), new RecordItemIndex(7));
            repo.HeavyBidServerSetup.Buttons.NextButtonInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidServerSetup.Buttons.NextButton' at Center.", repo.HeavyBidServerSetup.Buttons.NextButtonInfo, new RecordItemIndex(8));
            repo.HeavyBidServerSetup.Buttons.NextButton.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
