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
    ///The DeleteAnEstimate recording.
    /// </summary>
    [TestModule("86517749-ad94-4a26-9fc2-cc4e93b3c806", ModuleType.Recording, 1)]
    public partial class DeleteAnEstimate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static DeleteAnEstimate instance = new DeleteAnEstimate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteAnEstimate()
        {
            EstimateCode = "EST-1";
            EstimateName = "Estimate 1";
            EstimateDescription = "THIS IS A TEST ESTIMATE";
            EstimatePath = "C:\\HEAVYBID\\EST\\EST-1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DeleteAnEstimate Instance
        {
            get { return instance; }
        }

#region Variables

        string _EstimateCode;

        /// <summary>
        /// Gets or sets the value of variable EstimateCode.
        /// </summary>
        [TestVariable("c88df8d8-7295-42aa-bd2d-12e01f5daabc")]
        public string EstimateCode
        {
            get { return _EstimateCode; }
            set { _EstimateCode = value; }
        }

        string _EstimateName;

        /// <summary>
        /// Gets or sets the value of variable EstimateName.
        /// </summary>
        [TestVariable("41e29035-1b8c-443c-bda0-f653246c0023")]
        public string EstimateName
        {
            get { return _EstimateName; }
            set { _EstimateName = value; }
        }

        string _EstimateDescription;

        /// <summary>
        /// Gets or sets the value of variable EstimateDescription.
        /// </summary>
        [TestVariable("3ea92bfe-2cd4-4b77-bd42-09c5d268efb9")]
        public string EstimateDescription
        {
            get { return _EstimateDescription; }
            set { _EstimateDescription = value; }
        }

        string _EstimatePath;

        /// <summary>
        /// Gets or sets the value of variable EstimatePath.
        /// </summary>
        [TestVariable("e95f8df0-e198-44df-b503-d99c917c345b")]
        public string EstimatePath
        {
            get { return _EstimatePath; }
            set { _EstimatePath = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Tabs.FileTab' at Center.", repo.HeavyBidApp.Tabs.FileTabInfo, new RecordItemIndex(0));
            repo.HeavyBidApp.Tabs.FileTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Buttons.File.DeleteEstimateButton' at Center.", repo.HeavyBidApp.Buttons.File.DeleteEstimateButtonInfo, new RecordItemIndex(1));
            repo.HeavyBidApp.Buttons.File.DeleteEstimateButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBDropDownOptions.Estimate' at Center.", repo.HBDropDownOptions.EstimateInfo, new RecordItemIndex(2));
            repo.HBDropDownOptions.Estimate.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EstimatePath' with focus on 'HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.EstimatePathTextbox'.", repo.HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.EstimatePathTextboxInfo, new RecordItemIndex(3));
            repo.HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.EstimatePathTextbox.PressKeys(EstimatePath);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (WindowText~$EstimateName) on item 'HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.EstimateNameTextbox'.", repo.HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.EstimateNameTextboxInfo, new RecordItemIndex(4));
            Validate.AttributeRegex(repo.HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.EstimateNameTextboxInfo, "WindowText", new Regex(EstimateName));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (WindowText~$EstimateCode) on item 'HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.EstimateCodeTextbox'.", repo.HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.EstimateCodeTextboxInfo, new RecordItemIndex(5));
            Validate.AttributeRegex(repo.HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.EstimateCodeTextboxInfo, "WindowText", new Regex(EstimateCode));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.NextButton' at Center.", repo.HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.NextButtonInfo, new RecordItemIndex(6));
            repo.HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.NextButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.DeletePasswordTextbox' at Center.", repo.HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.DeletePasswordTextboxInfo, new RecordItemIndex(7));
            repo.HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.DeletePasswordTextbox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'dozer' with focus on 'HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.DeletePasswordTextbox'.", repo.HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.DeletePasswordTextboxInfo, new RecordItemIndex(8));
            repo.HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.DeletePasswordTextbox.PressKeys("dozer");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.NextButton' at Center.", repo.HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.NextButtonInfo, new RecordItemIndex(9));
            repo.HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.NextButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.FinishButton' at Center.", repo.HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.FinishButtonInfo, new RecordItemIndex(10));
            repo.HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.FinishButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.OKButton' at Center.", repo.HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.OKButtonInfo, new RecordItemIndex(11));
            repo.HBPopUpScreens.FromFileButtons.DeleteEstimateRelated.DeleteEstimate.OKButton.Click();
            Delay.Milliseconds(200);
            
            ValidateEstimateDeleted();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
