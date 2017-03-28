<%@ Page Title="" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="ViewCustomer.aspx.cs" Inherits="BlueJackCake.ViewCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>View Customer</h2>
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnDelete" EventName="Click" />
            </Triggers>
            <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <asp:TextBox ID="deleteMember" runat="server"></asp:TextBox>
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />

    </div>
</asp:Content>
