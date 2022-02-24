Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("G") Then
            Label1.Text = Session("G")
            Label2.Text = Session("V")
            Session.Clear()
            Session.Abandon()
        Else
            Response.Redirect("HtmlPage1.html")
        End If

    End Sub

End Class