<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ControleAcademia._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <script type="text/javascript" src='https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.min.js'></script>
    <script type="text/javascript" src='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/js/bootstrap.min.js'></script>
    <link rel="stylesheet" href='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/css/bootstrap.min.css' />
    
    <style type="text/css">
        body
        {
            margin: 20pt !important;
        }
    </style>

    <p style="text-align:center">
        <asp:TextBox ID="txtInfo" runat="server" CssClass="form-control" ReadOnly="true" Font-Size="Large" 
         placeholder="Este site tem como objetivo efetuar o controle de horários à academia, durante a pandemia do COVID19."   />
    </p> 
    

</asp:Content>
