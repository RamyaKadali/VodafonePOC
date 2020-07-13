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
    ///The Click_Alarmschedule_ExceptionLists recording.
    /// </summary>
    [TestModule("e04c81bb-985d-4643-9804-85aad92125fc", ModuleType.Recording, 1)]
    public partial class Click_Alarmschedule_ExceptionLists : ITestModule
    {
        /// <summary>
        /// Holds an instance of the VodafonePOCRepository repository.
        /// </summary>
        public static VodafonePOCRepository repo = VodafonePOCRepository.Instance;

        static Click_Alarmschedule_ExceptionLists instance = new Click_Alarmschedule_ExceptionLists();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Click_Alarmschedule_ExceptionLists()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Click_Alarmschedule_ExceptionLists Instance
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
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContentPage.ExceptionLists' at 36;13.", repo.ApplicationUnderTest.ContentPage.ExceptionListsInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.ContentPage.ExceptionLists.Click("36;13");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
