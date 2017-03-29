<%@ Page Title="" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="CakeUpdate.aspx.cs" Inherits="BlueJackCake.CakeUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3>Update Cake</h3>

    <table>
        <tr>
            <td>Cake Name</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="inputCakeName" runat="server"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator
                    ID="cakeNameVal" runat="server" ControlToValidate="inputCakeName" Display="Dynamic"
                    ErrorMessage="Enter Cake Name" ValidationGroup="addcake"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Price</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="inputPrice" runat="server"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator
                    ID="priceVal" runat="server" ControlToValidate="inputPrice" Display="Dynamic"
                    ErrorMessage="Enter Cake Price" ValidationGroup="addcake"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Stock</td>
            <td>:</td>
            <td>
                <asp:TextBox ID="inputStock" runat="server"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator
                    ID="stockVal" runat="server" ControlToValidate="inputStock" Display="Dynamic"
                    ErrorMessage="Enter Cake Stock" ValidationGroup="addcake"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Picture</td>
            <td>:</td>
            <td>
                <asp:FileUpload ID="uploadPicture" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="errorText" runat="server" Text=""></asp:Label>
                <br />
                <asp:Button ID="btnUpdateCake" runat="server" Text="Add Cake" OnClick="btnUpdateCake_Click" />
            </td>
        </tr>

    </table>

</asp:Content>
