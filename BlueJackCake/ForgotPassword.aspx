<%@ Page Title="" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="BlueJackCake.ForgotPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Forgot Password</h2>

    <table>
        <tr>
            <td>Email</td>
            <td>:</td>
            <td>
                <asp:textbox id="inputemail" runat="server" text=""></asp:textbox>
            </td>
        </tr>
    </table>
    <asp:Label ID="txtError" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="inputResetPassword" OnClick="inputResetPassword_Click" runat="server" Text="Reset Password" />

</asp:Content>
