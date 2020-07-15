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
    ///The AddSchedule_ExistingList_Save recording.
    /// </summary>
    [TestModule("8e14c79c-ceaa-4c69-a58b-2a7c0ab39361", ModuleType.Recording, 1)]
    public partial class AddSchedule_ExistingList_Save : ITestModule
    {
        /// <summary>
        /// Holds an instance of the VodafonePOCRepository repository.
        /// </summary>
        public static VodafonePOCRepository repo = VodafonePOCRepository.Instance;

        static AddSchedule_ExistingList_Save instance = new AddSchedule_ExistingList_Save();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddSchedule_ExistingList_Save()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddSchedule_ExistingList_Save Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddDate' at 274;19.", repo.ApplicationUnderTest.AddDateInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.AddDate.Click("274;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddDate' at 110;91.", repo.ApplicationUnderTest.AddDateInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.AddDate.Click("110;91");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Dropdown.September' at 39;9.", repo.Dropdown.SeptemberInfo, new RecordItemIndex(2));
            repo.Dropdown.September.Click("39;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'Dropdown.Accept' at 61;9.", repo.Dropdown.AcceptInfo, new RecordItemIndex(3));
            repo.Dropdown.Accept.MoveTo("61;9");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'Dropdown.Accept' at 61;9.", repo.Dropdown.AcceptInfo, new RecordItemIndex(4));
            repo.Dropdown.Accept.MoveTo("61;9");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'boolean:true' on item 'ApplicationUnderTest.AddAction'.", repo.ApplicationUnderTest.AddActionInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.AddAction.Element.SetAttributeValue("TagValue", "boolean:true");
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ATagAdd' at 35;10.", repo.ApplicationUnderTest.ATagAddInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.ATagAdd.Click("35;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Submit' at 80;11.", repo.ApplicationUnderTest.SubmitInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.Submit.Click("80;11");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}