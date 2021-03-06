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
    ///The DeleteHBFolder recording.
    /// </summary>
    [TestModule("a011b0c9-7a7b-4515-9444-0fb7f1a336c4", ModuleType.Recording, 1)]
    public partial class DeleteHBFolder : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static DeleteHBFolder instance = new DeleteHBFolder();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteHBFolder()
        {
            InstallLocation = "C:\\HeavyBid";
            InstallWorkStation = "C:\\HeavyBidWS";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DeleteHBFolder Instance
        {
            get { return instance; }
        }

#region Variables

        string _InstallLocation;

        /// <summary>
        /// Gets or sets the value of variable InstallLocation.
        /// </summary>
        [TestVariable("da66bd54-edff-4287-871f-34f781216c9a")]
        public string InstallLocation
        {
            get { return _InstallLocation; }
            set { _InstallLocation = value; }
        }

        string _InstallWorkStation;

        /// <summary>
        /// Gets or sets the value of variable InstallWorkStation.
        /// </summary>
        [TestVariable("0fae4486-517d-4cbd-949c-454786094503")]
        public string InstallWorkStation
        {
            get { return _InstallWorkStation; }
            set { _InstallWorkStation = value; }
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

            DeleteHBDirectory(InstallLocation);
            Delay.Milliseconds(0);
            
            //DeleteHBDirectory(InstallWorkStation);
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
