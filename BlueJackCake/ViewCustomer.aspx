<%@ Page Title="" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="ViewCustomer.aspx.cs" Inherits="BlueJackCake.ViewCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>View Customer</h2>
    <div>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">

            <ContentTemplate>
                <%-- autogenerate colums false =sesuai nama --%>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnRowDeleting="GridView1_RowDeleting">
                    <Columns>

                        <asp:BoundField DataField="Name" HeaderText="Name" />
                        <asp:BoundField DataField="Email" HeaderText="User Email" />
                        <asp:BoundField DataField="DOB" HeaderText="Date Of Birth" />
                        <asp:BoundField DataField="PhoneNumber" HeaderText="Phone Number" />
                        <asp:BoundField DataField="Address" HeaderText="Address" />
                        <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete User" />

                    </Columns>
                </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>

        <asp:Label ID="errorText" runat="server" Text=""></asp:Label>
        <br />

    </div>
</asp:Content>
