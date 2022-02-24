<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="result.aspx.vb" Inherits="GuessingGame.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b>You Guessed it</b>
            <br />
            Congragulations, you took 
            <asp:Label ID="Label1" runat="server"></asp:Label>
&nbsp;guesses to guess the number
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            <br />
            Dare to <a href="StartPage.html">Play Again?</a>
        </div>
    </form>
</body>
</html>
