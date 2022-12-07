using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Init(object sender, EventArgs e) {
        DevExpress.Web.ASPxWebControl.RegisterBaseScript(Page);//ASPxClientUtils
        RegisterPostBackControl();
    }
    private void RegisterPostBackControl() {
        ScriptManager sm = (ScriptManager)Page.Master.FindControl("ScriptManager1");
        sm.RegisterPostBackControl(ASPxPopupMenu1);
    }
    protected void ASPxPopupMenu1_ItemClick(object source, DevExpress.Web.MenuItemEventArgs e) {
        ASPxGridViewExporter1.WriteXlsToResponse();
    }
    protected void ASPxButton1_Click(object sender, EventArgs e) {
        ASPxGridViewExporter1.WriteXlsToResponse();
    }
}