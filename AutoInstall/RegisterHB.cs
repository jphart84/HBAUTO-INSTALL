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
    ///The RegisterHB recording.
    /// </summary>
    [TestModule("c8073cc8-23bf-41dc-8ca0-e4df727944a5", ModuleType.Recording, 1)]
    public partial class RegisterHB : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static RegisterHB instance = new RegisterHB();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RegisterHB()
        {
            RegCodeMU = "01af8e32-c236-435f-8c95-2518c339b7c0";
            CompanyName = "Test Company 999";
            RegTypeMU = "Advanced Multiuser";
            Licenses = "100";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RegisterHB Instance
        {
            get { return instance; }
        }

#region Variables

        string _RegCodeMU;

        /// <summary>
        /// Gets or sets the value of variable RegCodeMU.
        /// </summary>
        [TestVariable("6c62a48b-df10-443c-9a27-3b1e4fb05691")]
        public string RegCodeMU
        {
            get { return _RegCodeMU; }
            set { _RegCodeMU = value; }
        }

        string _CompanyName;

        /// <summary>
        /// Gets or sets the value of variable CompanyName.
        /// </summary>
        [TestVariable("1e382ce6-2732-46bf-94f2-41d41dca3140")]
        public string CompanyName
        {
            get { return _CompanyName; }
            set { _CompanyName = value; }
        }

        string _RegTypeMU;

        /// <summary>
        /// Gets or sets the value of variable RegTypeMU.
        /// </summary>
        [TestVariable("653138e4-98db-4416-9f0f-cec9dec4ebb3")]
        public string RegTypeMU
        {
            get { return _RegTypeMU; }
            set { _RegTypeMU = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Licenses.
        /// </summary>
        [TestVariable("5e5301ca-acf0-4561-abac-c3f4587d2055")]
        public string Licenses
        {
            get { return repo.Licenses; }
            set { repo.Licenses = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'HeavyBidRegistration.RegEntryTextbox'", repo.HeavyBidRegistration.RegEntryTextboxInfo, new ActionTimeout(30000), new RecordItemIndex(0));
            repo.HeavyBidRegistration.RegEntryTextboxInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RegCodeMU' with focus on 'HeavyBidRegistration.RegEntryTextbox'.", repo.HeavyBidRegistration.RegEntryTextboxInfo, new RecordItemIndex(1));
            repo.HeavyBidRegistration.RegEntryTextbox.PressKeys(RegCodeMU);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidRegistration.Buttons.CheckButton' at Center.", repo.HeavyBidRegistration.Buttons.CheckButtonInfo, new RecordItemIndex(2));
            repo.HeavyBidRegistration.Buttons.CheckButton.Click();
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeRegex (Windowtext~$CompanyName) on item 'HeavyBidRegistration.TextContainsForValidation.CompanyNameTextbox'.", repo.HeavyBidRegistration.TextContainsForValidation.CompanyNameTextboxInfo, new RecordItemIndex(3));
                Validate.AttributeRegex(repo.HeavyBidRegistration.TextContainsForValidation.CompanyNameTextboxInfo, "Windowtext", new Regex(CompanyName), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeRegex (Windowtext~$RegTypeMU) on item 'HeavyBidRegistration.TextContainsForValidation.SystemDescriptionTextbox'.", repo.HeavyBidRegistration.TextContainsForValidation.SystemDescriptionTextboxInfo, new RecordItemIndex(4));
                Validate.AttributeRegex(repo.HeavyBidRegistration.TextContainsForValidation.SystemDescriptionTextboxInfo, "Windowtext", new Regex(RegTypeMU), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeRegex (WindowText~$Licenses) on item 'HeavyBidRegistration.TextContainsForValidation.LicenseTextbox'.", repo.HeavyBidRegistration.TextContainsForValidation.LicenseTextboxInfo, new RecordItemIndex(5));
                Validate.AttributeRegex(repo.HeavyBidRegistration.TextContainsForValidation.LicenseTextboxInfo, "WindowText", new Regex(Licenses), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidRegistration.Buttons.SubmitButton' at Center.", repo.HeavyBidRegistration.Buttons.SubmitButtonInfo, new RecordItemIndex(6));
            repo.HeavyBidRegistration.Buttons.SubmitButton.Click();
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 30s to exist. Associated repository item: 'HBPopUpScreens.RegisterHB.ActivateHeavyBidServer.ReplaceTheExistingProductionServerW'", repo.HBPopUpScreens.RegisterHB.ActivateHeavyBidServer.ReplaceTheExistingProductionServerWInfo, new ActionTimeout(30000), new RecordItemIndex(7));
                repo.HBPopUpScreens.RegisterHB.ActivateHeavyBidServer.ReplaceTheExistingProductionServerWInfo.WaitForExists(30000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'HBPopUpScreens.RegisterHB.ActivateHeavyBidServer.ReplaceTheExistingProductionServerW' at Center.", repo.HBPopUpScreens.RegisterHB.ActivateHeavyBidServer.ReplaceTheExistingProductionServerWInfo, new RecordItemIndex(8));
                repo.HBPopUpScreens.RegisterHB.ActivateHeavyBidServer.ReplaceTheExistingProductionServerW.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'HBPopUpScreens.RegisterHB.ActivateHeavyBidServer.OKButton' at Center.", repo.HBPopUpScreens.RegisterHB.ActivateHeavyBidServer.OKButtonInfo, new RecordItemIndex(9));
                repo.HBPopUpScreens.RegisterHB.ActivateHeavyBidServer.OKButton.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
