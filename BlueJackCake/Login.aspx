 <%@ Page Title="" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BlueJackCake.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Login
    </h2>
    <table>
        <tr>
            <td>Email</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="inputEmail" runat="server" Text=""></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Password</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="inputPassword" runat="server" Text="" Type="password" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td>
                <asp:CheckBox ID="isRemember" runat="server" />
                Remember Me
            </td>
        </tr>

        <tr>
            <asp:Label ID="errorMessage" runat="server" Text=""></asp:Label>
        </tr>
    </table>

    <asp:Button ID="btnLogin" Text="Login" OnClick="btnLogin_Click" runat="server" />


</asp:Content>
