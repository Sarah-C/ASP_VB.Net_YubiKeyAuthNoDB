Imports yubikey.YubikeyAuth
Public Class initialiseSystem
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack then
            Dim newSystem=New createNewSystem()
            CONFIG.newUsers(newSystem)
            Button1.Visible=False
            message.Text="<b style=""background: #ffff00;"">If you're reading this and there was no error anywhere, the store is now created, and you can use the YubiKeys you added to the initialiseSystem.aspx.vb file to authenticate!<br>Click ""Home"" and give it a try!</b><br><br><br>"
        end if
    End Sub

End Class