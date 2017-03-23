<%@ Page Title="" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BlueJackCake.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Register
    </h2>

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <table>
        <tr>
            <td>Name</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="inputName" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>Email</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="inputEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Password</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="inputPassword" runat="server" Type="password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Confirm Password</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="confirmPassword" runat="server" Type="password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Date Of Birth</td>
            <td>:</td>
            <td>
                <asp:Calendar ID="inputDOB" runat="server"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td>Phone Number</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="inputPhoneNumber" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Address</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="inputAddress" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click" />
            </td>
        </tr>

    </table>



</asp:Content>
