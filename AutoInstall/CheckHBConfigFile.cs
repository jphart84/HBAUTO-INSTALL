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
    ///The CheckHBConfigFile recording.
    /// </summary>
    [TestModule("49c14881-6b01-47a9-a300-59c912a2c2cf", ModuleType.Recording, 1)]
    public partial class CheckHBConfigFile : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static CheckHBConfigFile instance = new CheckHBConfigFile();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CheckHBConfigFile()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CheckHBConfigFile Instance
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
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            try {
                Report.Log(ReportLevel.Info, "Application", "(Optional Action)\r\nRun application 'Excel.EXE' with arguments 'C:\\HeavyBid\\BIN\\HeavyBid.exe.config' in normal mode.", new RecordItemIndex(0));
                Host.Local.RunApplication("Excel.EXE", "C:\\HeavyBid\\BIN\\HeavyBid.exe.config", "C:\\Program Files (x86)\\Microsoft Office", false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>'HB.2017.0') on item 'ExcelRelated.Excel.CellC11'.", repo.ExcelRelated.Excel.CellC11Info, new RecordItemIndex(1));
                Validate.AttributeContains(repo.ExcelRelated.Excel.CellC11Info, "Text", "HB.2017.0", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>'2.4') on item 'ExcelRelated.Excel.CellC13'.", repo.ExcelRelated.Excel.CellC13Info, new RecordItemIndex(2));
                Validate.AttributeContains(repo.ExcelRelated.Excel.CellC13Info, "Text", "2.4", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                //Report.Log(ReportLevel.Info, "Application", "(Optional Action)\r\nClosing application containing item 'ExcelRelated.Excel'.", repo.ExcelRelated.Excel.SelfInfo, new RecordItemIndex(3));
                //Host.Current.CloseApplication(repo.ExcelRelated.Excel.Self, 10000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ExcelRelated.MicrosoftOfficeActivationWizard'.", repo.ExcelRelated.MicrosoftOfficeActivationWizard.SelfInfo, new RecordItemIndex(4));
            Validate.Exists(repo.ExcelRelated.MicrosoftOfficeActivationWizard.SelfInfo);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExcelRelated.MicrosoftOfficeActivationWizard.CloseButton' at Center.", repo.ExcelRelated.MicrosoftOfficeActivationWizard.CloseButtonInfo, new RecordItemIndex(5));
            repo.ExcelRelated.MicrosoftOfficeActivationWizard.CloseButton.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'ExcelRelated.MicrosoftOfficeActivationWizard'.", repo.ExcelRelated.MicrosoftOfficeActivationWizard.SelfInfo, new RecordItemIndex(6));
            Validate.NotExists(repo.ExcelRelated.MicrosoftOfficeActivationWizard.SelfInfo);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ExcelRelated.Excel.Close' at CenterRight.", repo.ExcelRelated.Excel.CloseInfo, new RecordItemIndex(7));
            repo.ExcelRelated.Excel.Close.Click(Location.CenterRight);
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ExcelRelated.ExcelXMLPopup.DontSaveButton' at Center.", repo.ExcelRelated.ExcelXMLPopup.DontSaveButtonInfo, new RecordItemIndex(8));
                repo.ExcelRelated.ExcelXMLPopup.DontSaveButton.Click();
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            try {
                //Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ExcelRelated.ExcelXMLPopup.DontSaveButton' at Center.", repo.ExcelRelated.ExcelXMLPopup.DontSaveButtonInfo, new RecordItemIndex(9));
                //repo.ExcelRelated.ExcelXMLPopup.DontSaveButton.Click();
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
