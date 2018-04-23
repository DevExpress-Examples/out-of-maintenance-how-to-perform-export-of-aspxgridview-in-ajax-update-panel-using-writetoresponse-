Imports System
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
        DevExpress.Web.ASPxClasses.ASPxWebControl.RegisterBaseScript(Page) 'ASPxClientUtils
        RegisterPostBackControl()
    End Sub
    Private Sub RegisterPostBackControl()
        Dim sm As ScriptManager = CType(Page.Master.FindControl("ScriptManager1"), ScriptManager)
        sm.RegisterPostBackControl(ASPxPopupMenu1)
    End Sub
    Protected Sub ASPxPopupMenu1_ItemClick(ByVal source As Object, ByVal e As DevExpress.Web.ASPxMenu.MenuItemEventArgs)
        ASPxGridViewExporter1.WriteXlsToResponse()
    End Sub
    Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
        ASPxGridViewExporter1.WriteXlsToResponse()
    End Sub
End Class