using System;
using System.Linq;
using System.Text;
using System.ComponentModel;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.Model.Core;
using DevExpress.ExpressApp.Model.DomainLogics;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.Persistent.BaseImpl;

namespace TestWebSolution.Module.Web {
    // TODO: The 'TestWebSolution.Module.Web.TestWebSolutionAspNetModule' class has been marked automatically due to usage of types that have no XAF for .NET equivalent.
    //       Breaking Change https://supportcenter.devexpress.com/ticket/details/t1312589
    //       Please review the class and implement necessary changes to ensure compatibility with XAF for .NET
    // NOTE:
    //   - Type 'DevExpress.ExpressApp.Chart.Web.ChartAspNetModule' has no equivalent in XAF for .NET
    //     ChartAspNetModule has no equivalent in XAF for .NET (loaded from removed-api.txt)
    //   - Type 'DevExpress.ExpressApp.FileAttachments.Web.FileAttachmentsAspNetModule' has no equivalent in XAF for .NET
    //     FileAttachmentsAspNetModule has no equivalent in XAF for .NET (loaded from removed-api.txt)
    //   - Type 'DevExpress.ExpressApp.HtmlPropertyEditor.Web.HtmlPropertyEditorAspNetModule' has no equivalent in XAF for .NET
    //     HtmlPropertyEditorAspNetModule has no equivalent in XAF for .NET (loaded from removed-api.txt)
    //   - Type 'DevExpress.ExpressApp.Maps.Web.MapsAspNetModule' has no equivalent in XAF for .NET
    //     MapsAspNetModule has no Blazor equivalent
    //   - Type 'DevExpress.ExpressApp.Notifications.Web.NotificationsAspNetModule' has no equivalent in XAF for .NET
    //     NotificationsAspNetModule has no equivalent in XAF for .NET (loaded from removed-api.txt)
    //   - Type 'DevExpress.ExpressApp.PivotChart.Web.PivotChartAspNetModule' has no equivalent in XAF for .NET
    //     PivotChartAspNetModule has no equivalent in XAF for .NET (loaded from removed-api.txt)
    //   - Type 'DevExpress.ExpressApp.PivotGrid.Web.PivotGridAspNetModule' has no equivalent in XAF for .NET
    //     PivotGridAspNetModule has no equivalent in XAF for .NET (loaded from removed-api.txt)
    //   - Type 'DevExpress.ExpressApp.ScriptRecorder.Web.ScriptRecorderAspNetModule' has no equivalent in XAF for .NET
    //     ScriptRecorderAspNetModule has no Blazor equivalent
    //   - Type 'DevExpress.ExpressApp.TreeListEditors.Web.TreeListEditorsAspNetModule' has no equivalent in XAF for .NET
    //     TreeListEditorsAspNetModule has no equivalent in XAF for .NET (loaded from removed-api.txt)
    [ToolboxItemFilter("Xaf.Platform.Web")]
    // For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ModuleBase.
    public sealed partial class TestWebSolutionAspNetModule : ModuleBase {
        //private void Application_CreateCustomModelDifferenceStore(Object sender, CreateCustomModelDifferenceStoreEventArgs e) {
        //    e.Store = new ModelDifferenceDbStore((XafApplication)sender, typeof(ModelDifference), true, "Web");
        //    e.Handled = true;
        //}
        private void Application_CreateCustomUserModelDifferenceStore(Object sender, CreateCustomModelDifferenceStoreEventArgs e) {
            e.Store = new ModelDifferenceDbStore((XafApplication)sender, typeof(ModelDifference), false, "Web");
            e.Handled = true;
        }
        public TestWebSolutionAspNetModule() {
            InitializeComponent();
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
            return ModuleUpdater.EmptyModuleUpdaters;
        }
        public override void Setup(XafApplication application) {
            base.Setup(application);
            //application.CreateCustomModelDifferenceStore += Application_CreateCustomModelDifferenceStore;
            application.CreateCustomUserModelDifferenceStore += Application_CreateCustomUserModelDifferenceStore;
            // Manage various aspects of the application UI and behavior at the module level.
        }
    }
}
