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

namespace VodafonePOC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ChooseExistingList recording.
    /// </summary>
    [TestModule("b92a6d08-83c6-429f-9929-332725d51f8f", ModuleType.Recording, 1)]
    public partial class ChooseExistingList : ITestModule
    {
        /// <summary>
        /// Holds an instance of the VodafonePOCRepository repository.
        /// </summary>
        public static VodafonePOCRepository repo = VodafonePOCRepository.Instance;

        static ChooseExistingList instance = new ChooseExistingList();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ChooseExistingList()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ChooseExistingList Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.EXCEPTIONS' at 698;15.", repo.ApplicationUnderTest.EXCEPTIONSInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.EXCEPTIONS.Click("698;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ApplicationUnderTest.NgScope' at 111;108.", repo.ApplicationUnderTest.NgScopeInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.NgScope.MoveTo("111;108");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'ApplicationUnderTest.NgScope' at 111;108.", repo.ApplicationUnderTest.NgScopeInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.NgScope.MoveTo("111;108");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Submit' at 22;9.", repo.ApplicationUnderTest.SubmitInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Submit.Click("22;9");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}