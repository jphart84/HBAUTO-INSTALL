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
    ///The DeleteCompareFiles recording.
    /// </summary>
    [TestModule("eb5cca40-0426-49a9-b1ca-b4ca441b9353", ModuleType.Recording, 1)]
    public partial class DeleteCompareFiles : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static DeleteCompareFiles instance = new DeleteCompareFiles();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteCompareFiles()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DeleteCompareFiles Instance
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

            DeleteHBDirectory("BINdiff.txt");
            Delay.Milliseconds(0);
            
            DeleteHBDirectory("CheckExeVersionServer.txt");
            Delay.Milliseconds(0);
            
            DeleteHBDirectory("CheckExeVersionWS.txt");
            Delay.Milliseconds(0);
            
            DeleteHBDirectory("DiffBetweenServWsBIN.txt");
            Delay.Milliseconds(0);
            
            DeleteHBDirectory("DiffUTIL.txt");
            Delay.Milliseconds(0);
            
            DeleteHBDirectory("HCSSdiff.txt");
            Delay.Milliseconds(0);
            
            DeleteHBDirectory("SYSdiff.txt");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
