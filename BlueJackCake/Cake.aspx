﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="Cake.aspx.cs" Inherits="BlueJackCake.Cake" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Cake</h2>
    <div>
        <%-- for Admin --%>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting">
                    <Columns>

                        <asp:BoundField DataField="CakeName" HeaderText="Cake Name" />
                        <asp:BoundField DataField="Price" HeaderText="Price" />
                        <asp:BoundField DataField="Stock" HeaderText="Stock" />
                        <asp:ImageField DataImageUrlField="Picture" HeaderText="Pic" ControlStyle-Width="100" ControlStyle-Height="100"></asp:ImageField>

                        <asp:ButtonField ButtonType="Button" CommandName="Update" Text="Update Cake" />
                        <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete Cake" />

                    </Columns>
                </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>

        <%-- for Customer --%>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false">
                    <Columns>

                        <asp:BoundField DataField="CakeName" HeaderText="Cake Name" />
                        <asp:BoundField DataField="Price" HeaderText="Price" />
                        <asp:BoundField DataField="Stock" HeaderText="Stock" />
                        <asp:ImageField DataImageUrlField="Picture" HeaderText="Pic" ControlStyle-Width="100" ControlStyle-Height="100" ></asp:ImageField>

                    </Columns>
                </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>


        <asp:Button ID="btnAddCake" runat="server" Text="Add Cake" OnClick="btnAddCake_Click"/>
        <asp:Label ID="errorText" runat="server" Text=""></asp:Label>
        <br />
    </div>
</asp:Content>
