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
    ///The WelcomeImage recording.
    /// </summary>
    [TestModule("edeaf7cc-b74d-4e5a-82c8-fd27c03ed8ba", ModuleType.Recording, 1)]
    public partial class WelcomeImage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static WelcomeImage instance = new WelcomeImage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WelcomeImage()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static WelcomeImage Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'HBPopUpScreens.FromHelpButtons.WelcomeToHeavyBidScreen.BitmapImage'", repo.HBPopUpScreens.FromHelpButtons.WelcomeToHeavyBidScreen.BitmapImageInfo, new ActionTimeout(5000), new RecordItemIndex(0));
            repo.HBPopUpScreens.FromHelpButtons.WelcomeToHeavyBidScreen.BitmapImageInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromHelpButtons.WelcomeToHeavyBidScreen.BitmapImage' at Center.", repo.HBPopUpScreens.FromHelpButtons.WelcomeToHeavyBidScreen.BitmapImageInfo, new RecordItemIndex(1));
            repo.HBPopUpScreens.FromHelpButtons.WelcomeToHeavyBidScreen.BitmapImage.Click();
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 5s for the attribute 'Text' to contain the specified value 'hcss.com'. Associated repository item: 'GoogleChrome.AddressBar'", repo.GoogleChrome.AddressBarInfo, new RecordItemIndex(2));
                repo.GoogleChrome.AddressBarInfo.WaitForAttributeContains(5000, "Text", "hcss.com");
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            // E.6
            Report.Log(ReportLevel.Info, "Application", "E.6\r\nClosing application containing item 'GoogleChrome'.", repo.GoogleChrome.SelfInfo, new RecordItemIndex(3));
            Host.Current.CloseApplication(repo.GoogleChrome.Self, 10000);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
