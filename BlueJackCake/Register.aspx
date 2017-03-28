<%@ Page Title="" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BlueJackCake.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Register
    </h2>


    <table>
        <tr>
            <td>Name</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="inputName" runat="server"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator
                    ID="nameVal" runat="server" ControlToValidate="inputName" Display="Dynamic"
                    ErrorMessage="Enter Your Name" ValidationGroup="register"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Email</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="inputEmail" runat="server"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator
                    ID="emailVal" runat="server" ControlToValidate="inputEmail" Display="Dynamic"
                    ErrorMessage="Enter Your Email" ValidationGroup="register"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Password</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="inputPassword" runat="server" Type="password"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator
                    ID="passVal" runat="server" ControlToValidate="inputPassword" Display="Dynamic"
                    ErrorMessage="Enter Your Password" ValidationGroup="register"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Confirm Password</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="confirmPassword" runat="server" Type="password"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator
                    ID="cpassVal" runat="server" ControlToValidate="confirmPassword" Display="Dynamic"
                    ErrorMessage="Enter Your Confirm Password" ValidationGroup="register"></asp:RequiredFieldValidator>
                <asp:CompareValidator
                    ID="cpassValCompare" runat="server" ControlToValidate="confirmPassword" ControlToCompare="inputPassword"
                    Display="Dynamic" ErrorMessage="Password Not Match" ValidationGroup="register"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>Date Of Birth</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="inputDOB" runat="server" TextMode="Date"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="dobVal" runat="server" ControlToValidate="inputDOB" Display="Dynamic"
                    ErrorMessage="Enter Your DOB" ValidationGroup="Register"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Phone Number</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="inputPhoneNumber" runat="server"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator
                    ID="phoneNumberVal" runat="server" ControlToValidate="inputPhoneNumber" Display="Dynamic"
                    ErrorMessage="Enter Your Phone Number" ValidationGroup="register"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Address</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="inputAddress" runat="server"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator
                    ID="addressVal" runat="server" ControlToValidate="inputAddress" Display="Dynamic"
                    ErrorMessage="Enter Your Address" ValidationGroup="register"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="txtError" runat="server" Text=""></asp:Label>
                <asp:Button ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click" />
            </td>
        </tr>

    </table>



</asp:Content>
