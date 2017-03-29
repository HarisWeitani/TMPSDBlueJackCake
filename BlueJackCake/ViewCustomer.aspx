<%@ Page Title="" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="ViewCustomer.aspx.cs" Inherits="BlueJackCake.ViewCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>View Customer</h2>
    <div>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
            
            <ContentTemplate>
                <%-- autogenerate colums false =sesuai nama --%>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand" >
                    <Columns>

                        <asp:BoundField DataField="Email" HeaderText="Email User" />
                        <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Delete" Text="Delete User" />

                        <%-- buat image --%>
                        <%-- atur width sama heigt disini --%>
                        <asp:ImageField DataImageUrlField="Email" HeaderText="Pic"></asp:ImageField>

                    </Columns>
                </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <asp:Label ID="label1" runat="server" Text=""></asp:Label>

        <asp:TextBox ID="deleteMember" runat="server"></asp:TextBox>
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />

    </div>
</asp:Content>
