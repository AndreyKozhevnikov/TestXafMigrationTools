using System;
using System.Configuration;
using System.Web.Configuration;
using System.Web;
using System.Web.Routing;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Web;
using DevExpress.Web;

namespace TestWebSolution.Web {
    // TODO: The 'TestWebSolution.Web.Global' class has been commented out automatically due to usage of types that have no XAF for .NET equivalent.
    //       Breaking Change https://supportcenter.devexpress.com/ticket/details/t1312589
    //       Please review the class and implement necessary changes to ensure compatibility with XAF for .NET
    // NOTE:
    //   - Type 'ASPxWebControl' has no equivalent in XAF for .NET
    //     DevExpress.Web.v25.1 assembly was removed in v25.2 or is not supported in XAF for .NET
    //   - Type 'DevExpress.ExpressApp.Web.Templates.DefaultVerticalTemplateContentNew' has no equivalent in XAF for .NET
    //     DefaultVerticalTemplateContentNew has no equivalent in XAF for .NET (loaded from removed-api.txt)
    //   - Type 'DevExpress.ExpressApp.Web.ErrorHandling' has no equivalent in XAF for .NET
    //     ErrorHandling has no equivalent in XAF for .NET (loaded from removed-api.txt)
    // ========== COMMENTED OUT CLASS ==========
    // public class Global : System.Web.HttpApplication {
    //         public Global() {
    //             InitializeComponent();
    //         }
    //         protected void Application_Start(Object sender, EventArgs e) {
    //             DevExpress.ExpressApp.FrameworkSettings.DefaultSettingsCompatibilityMode = DevExpress.ExpressApp.FrameworkSettingsCompatibilityMode.Latest;
    //             DevExpress.ExpressApp.Security.SecurityStrategy.AutoAssociationReferencePropertyMode = DevExpress.ExpressApp.Security.ReferenceWithoutAssociationPermissionsMode.AllMembers;
    //             RouteTable.Routes.RegisterXafRoutes();
    //             ASPxWebControl.CallbackError += new EventHandler(Application_Error);
    // #if EASYTEST
    //             DevExpress.ExpressApp.Web.TestScripts.TestScriptsManager.EasyTestEnabled = true;
    // #endif
    //         }
    //         protected void Session_Start(Object sender, EventArgs e) {
    //             Tracing.Initialize();
    //             WebApplication.SetInstance(Session, new TestWebSolutionAspNetApplication());
    //             SecurityStrategy security = WebApplication.Instance.GetSecurityStrategy();
    //             security.RegisterXPOAdapterProviders();
    //             DevExpress.ExpressApp.Web.Templates.DefaultVerticalTemplateContentNew.ClearSizeLimit();
    //             WebApplication.Instance.SwitchToNewStyle();
    //             if(ConfigurationManager.ConnectionStrings["ConnectionString"] != null) {
    //                 WebApplication.Instance.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    //             }
    // #if EASYTEST
    //             if(ConfigurationManager.ConnectionStrings["EasyTestConnectionString"] != null) {
    //                 WebApplication.Instance.ConnectionString = ConfigurationManager.ConnectionStrings["EasyTestConnectionString"].ConnectionString;
    //             }
    // #endif
    // #if DEBUG
    //             if(System.Diagnostics.Debugger.IsAttached && WebApplication.Instance.CheckCompatibilityType == CheckCompatibilityType.DatabaseSchema) {
    //                 WebApplication.Instance.DatabaseUpdateMode = DatabaseUpdateMode.UpdateDatabaseAlways;
    //             }
    // #endif
    //             WebApplication.Instance.Setup();
    //             WebApplication.Instance.Start();
    //         }
    //         protected void Application_BeginRequest(Object sender, EventArgs e) {
    //         }
    //         protected void Application_EndRequest(Object sender, EventArgs e) {
    //         }
    //         protected void Application_AuthenticateRequest(Object sender, EventArgs e) {
    //         }
    //         protected void Application_Error(Object sender, EventArgs e) {
    //             ErrorHandling.Instance.ProcessApplicationError();
    //         }
    //         protected void Session_End(Object sender, EventArgs e) {
    //             WebApplication.LogOff(Session);
    //             WebApplication.DisposeInstance(Session);
    //         }
    //         protected void Application_End(Object sender, EventArgs e) {
    //         }
    //         #region Web Form Designer generated code
    //         /// <summary>
    //         /// Required method for Designer support - do not modify
    //         /// the contents of this method with the code editor.
    //         /// </summary>
    //         private void InitializeComponent() {
    //         }
    //         #endregion
    //     }
    // ========================================

}
