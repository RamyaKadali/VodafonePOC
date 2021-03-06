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
    ///The AddScheduleSave recording.
    /// </summary>
    [TestModule("429990a3-1458-4dfd-990c-16900f0aa5c1", ModuleType.Recording, 1)]
    public partial class AddScheduleSave : ITestModule
    {
        /// <summary>
        /// Holds an instance of the VodafonePOCRepository repository.
        /// </summary>
        public static VodafonePOCRepository repo = VodafonePOCRepository.Instance;

        static AddScheduleSave instance = new AddScheduleSave();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddScheduleSave()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddScheduleSave Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddDay' at 211;15.", repo.ApplicationUnderTest.AddDayInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.AddDay.Click("211;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddDay' at 35;46.", repo.ApplicationUnderTest.AddDayInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.AddDay.Click("35;46");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.NgScope' at 346;229.", repo.ApplicationUnderTest.NgScopeInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.NgScope.Click("346;229");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddTimeHours' at 26;-64.", repo.ApplicationUnderTest.AddTimeHoursInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.AddTimeHours.Click("26;-64");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.NgScope' at 534;226.", repo.ApplicationUnderTest.NgScopeInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.NgScope.Click("534;226");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.NgScope' at 534;229.", repo.ApplicationUnderTest.NgScopeInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.NgScope.Click("534;229");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Submit' at 58;17.", repo.ApplicationUnderTest.SubmitInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.Submit.Click("58;17");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
