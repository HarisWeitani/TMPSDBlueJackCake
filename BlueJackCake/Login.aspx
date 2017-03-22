<%@ Page Title="" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BlueJackCake.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Login
    </h2>
    <div>
        Email :
        <asp:TextBox ID="inputEmail" runat="server" Text=""></asp:TextBox>
    </div>
    <div>
        Password :<asp:TextBox ID="inputPassword" runat="server" Text=""></asp:TextBox>
    </div>
    <div>
        <asp:CheckBox ID="isRemember" runat="server" />
        Remember Me
    </div>
    <div>
        <asp:Button ID="btnLogin" Text="Login" OnClick="btnLogin_Click" runat="server" />
    </div>
    <div>
        <asp:Label ID="errorMessage" runat="server" Text=""></asp:Label>
    </div>


</asp:Content>
