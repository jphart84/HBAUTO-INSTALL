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
    ///The crystalTESTING recording.
    /// </summary>
    [TestModule("0e9be4f1-8439-46f8-b4f5-a0adbdb1810a", ModuleType.Recording, 1)]
    public partial class crystalTESTING : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static crystalTESTING instance = new crystalTESTING();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public crystalTESTING()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static crystalTESTING Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'CrystalInstallation.CrystalInstaller.NextButton' at Center.", repo.CrystalInstallation.CrystalInstaller.NextButtonInfo, new RecordItemIndex(0));
            repo.CrystalInstallation.CrystalInstaller.NextButton.DoubleClick();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'CrystalInstallation.CrystalInstaller.NextButton'.", repo.CrystalInstallation.CrystalInstaller.NextButtonInfo, new RecordItemIndex(1));
            repo.CrystalInstallation.CrystalInstaller.NextButton.Press();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'CrystalInstallation.CrystalInstaller.NextButton' at Center.", repo.CrystalInstallation.CrystalInstaller.NextButtonInfo, new RecordItemIndex(2));
                repo.CrystalInstallation.CrystalInstaller.NextButton.Click();
                Delay.Milliseconds(4700);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'WindowsMenuBar.HCSSCrystalXIIntegrationInstallS'.", repo.WindowsMenuBar.HCSSCrystalXIIntegrationInstallSInfo, new RecordItemIndex(3));
            repo.WindowsMenuBar.HCSSCrystalXIIntegrationInstallS.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'CrystalInstallation.CrystalInstaller'.", repo.CrystalInstallation.CrystalInstaller.SelfInfo, new RecordItemIndex(4));
            repo.CrystalInstallation.CrystalInstaller.Self.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'CrystalInstallation.CrystalInstaller.NextButton' at Center", repo.CrystalInstallation.CrystalInstaller.NextButtonInfo, new RecordItemIndex(5));
                repo.CrystalInstallation.CrystalInstaller.NextButton.Touch();
                Delay.Milliseconds(500);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Invoke action", "(Optional Action)\r\nInvoking Press() on item 'CrystalInstallation.CrystalInstaller.NextButton'.", repo.CrystalInstallation.CrystalInstaller.NextButtonInfo, new RecordItemIndex(6));
                repo.CrystalInstallation.CrystalInstaller.NextButton.Press();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
