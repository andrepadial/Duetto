<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ControleAcademia.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link rel="stylesheet" href='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/css/bootstrap.min.css' />

    <title></title>
    <style type="text/css">
        body
        {
            margin: 20pt !important;
        }
    </style>
</head>
<body>
    <script type="text/javascript" src='https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.min.js'></script>
    <script type="text/javascript" src='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/js/bootstrap.min.js'></script>
            
    <form id="form1" runat="server">
    <div style="max-width: 400px;">
        <h2 class="form-signin-heading">
            Acesso</h2>
        <label for="txtUsername">
            Usu&aacute;rio</label>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Enter Username" />
        <br />
        <label for="txtPassword">
            Senha</label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"
            placeholder="Enter Password"  />     
        <br />
        <asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="ValidateUser" Class="btn btn-primary" />
        <br />
        <br />
        <div id="dvMessage" runat="server" visible="false" class="alert alert-danger">
            <strong>Error!</strong>
            <asp:Label ID="lblMessage" runat="server" />
        </div>
    </div>
    </form>
</body>
</html>
