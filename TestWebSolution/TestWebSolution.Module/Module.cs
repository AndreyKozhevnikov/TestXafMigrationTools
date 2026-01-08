using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Model.Core;
using DevExpress.ExpressApp.Model.DomainLogics;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.Xpo;
using dxTestSolution.Module.DatabaseUpdate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace TestWebSolution.Module {
    // For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ModuleBase.
    // TODO: The 'TestWebSolution.Module.TestWebSolutionModule' class has been marked automatically due to usage of types that have no XAF for .NET equivalent.
    //       Breaking Change https://supportcenter.devexpress.com/ticket/details/t1312589
    //       Please review the class and implement necessary changes to ensure compatibility with XAF for .NET
    // NOTE:
    //   - Type 'DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule' has no equivalent in XAF for .NET
    //     BusinessClassLibraryCustomizationModule has no equivalent in XAF for .NET (loaded from removed-api.txt)
    //   - Type 'DevExpress.ExpressApp.Kpi.KpiModule' has no equivalent in XAF for .NET
    //     KpiModule has no .NET equivalent
    //   - Type 'DevExpress.ExpressApp.PivotChart.PivotChartModuleBase' has no equivalent in XAF for .NET
    //     PivotChartModuleBase has no equivalent in XAF for .NET (loaded from removed-api.txt)
    //   - Type 'DevExpress.ExpressApp.ScriptRecorder.ScriptRecorderModuleBase' has no equivalent in XAF for .NET
    //     ScriptRecorderModuleBase has no .NET equivalent
    public sealed partial class TestWebSolutionModule : ModuleBase {
        public TestWebSolutionModule() {
            InitializeComponent();
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
            ModuleUpdater updater = new DatabaseUpdate.Updater(objectSpace, versionFromDB);
            return new ModuleUpdater[] { updater, new MyUpdater(objectSpace, versionFromDB) };
        }
        public override void Setup(XafApplication application) {
            base.Setup(application);
            // Manage various aspects of the application UI and behavior at the module level.
        }
        public override void CustomizeTypesInfo(ITypesInfo typesInfo) {
            base.CustomizeTypesInfo(typesInfo);
            CalculatedPersistentAliasHelper.CustomizeTypesInfo(typesInfo);
        }
    }
}
