Public Class WebForm2
    Inherits System.Web.UI.Page
    Dim generator As System.Random = New System.Random()
    Dim val As Integer = generator.Next(1, 101)


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Label1.Text = "Guess the Number"
            Label2.Text = ""
            Label3.Text = ""
            Session.Add("V", val)
            Session.Add("G", 0)

        End If


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBox1.Text) Or Not IsNumeric(TextBox1.Text) Then
            Label4.Text = "Provide valid value in text box"
        Else

            Session("G") = Convert.ToInt32(Session("G")) + 1
            Label4.Text = ""
            If Convert.ToInt32(TextBox1.Text) = Convert.ToInt32(Session("V")) Then
                Response.Redirect("result.aspx")
            ElseIf Convert.ToInt32(TextBox1.Text) < Convert.ToInt32(Session("V")) Then
                Label1.Text = "Too Lower"
                Label2.Text = "You took" & Session("G").ToString & "Guesses"
                Label3.Text = "Try agin with a higher number"
            ElseIf Convert.ToInt32(TextBox1.Text) > Convert.ToInt32(Session("V")) Then
                Label1.Text = "Too Higher"
                Label2.Text = "You took" & Session("G").ToString & "Guesses"
                Label3.Text = "Try agin with a lower number"
            End If
        End If
    End Sub
End Class