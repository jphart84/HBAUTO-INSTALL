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
    ///The UninstallCrystal recording.
    /// </summary>
    [TestModule("f2e4f309-0bd7-44ab-8af9-c73c38a506fd", ModuleType.Recording, 1)]
    public partial class UninstallCrystal : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static UninstallCrystal instance = new UninstallCrystal();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UninstallCrystal()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UninstallCrystal Instance
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

            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 5s to exist. Associated repository item: 'ProgramsAndFeatures.SearchEditBox'", repo.ProgramsAndFeatures.SearchEditBoxInfo, new ActionTimeout(5000), new RecordItemIndex(0));
                repo.ProgramsAndFeatures.SearchEditBoxInfo.WaitForExists(5000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ProgramsAndFeatures.SearchEditBox' at Center.", repo.ProgramsAndFeatures.SearchEditBoxInfo, new RecordItemIndex(1));
                repo.ProgramsAndFeatures.SearchEditBox.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey sequence 'hcss{Space}integration' with focus on 'ProgramsAndFeatures.SearchEditBox'.", repo.ProgramsAndFeatures.SearchEditBoxInfo, new RecordItemIndex(2));
                repo.ProgramsAndFeatures.SearchEditBox.PressKeys("hcss{Space}integration");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 30s to exist. Associated repository item: 'ProgramsAndFeatures.UninstallProgramTable.HCSSCrystalXIIntegration'", repo.ProgramsAndFeatures.UninstallProgramTable.HCSSCrystalXIIntegrationInfo, new ActionTimeout(30000), new RecordItemIndex(3));
                repo.ProgramsAndFeatures.UninstallProgramTable.HCSSCrystalXIIntegrationInfo.WaitForExists(30000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ProgramsAndFeatures.UninstallProgramTable.HCSSCrystalXIIntegration' at Center.", repo.ProgramsAndFeatures.UninstallProgramTable.HCSSCrystalXIIntegrationInfo, new RecordItemIndex(4));
                repo.ProgramsAndFeatures.UninstallProgramTable.HCSSCrystalXIIntegration.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 10s to exist. Associated repository item: 'ProgramsAndFeatures.Buttons.UninstallButton'", repo.ProgramsAndFeatures.Buttons.UninstallButtonInfo, new ActionTimeout(10000), new RecordItemIndex(5));
                repo.ProgramsAndFeatures.Buttons.UninstallButtonInfo.WaitForExists(10000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ProgramsAndFeatures.Buttons.UninstallButton' at Center.", repo.ProgramsAndFeatures.Buttons.UninstallButtonInfo, new RecordItemIndex(6));
                repo.ProgramsAndFeatures.Buttons.UninstallButton.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 10s to exist. Associated repository item: 'ProgramsAndFeatures.Buttons.YesButton'", repo.ProgramsAndFeatures.Buttons.YesButtonInfo, new ActionTimeout(10000), new RecordItemIndex(7));
                repo.ProgramsAndFeatures.Buttons.YesButtonInfo.WaitForExists(10000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ProgramsAndFeatures.Buttons.YesButton' at Center.", repo.ProgramsAndFeatures.Buttons.YesButtonInfo, new RecordItemIndex(8));
                repo.ProgramsAndFeatures.Buttons.YesButton.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
