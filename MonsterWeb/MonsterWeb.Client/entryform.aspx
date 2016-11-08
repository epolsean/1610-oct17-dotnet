<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="entryform.aspx.cs" Inherits="MonsterWeb.Client.entryform" %>

<asp:Content runat="server" ContentPlaceHolderID="body">
    <div>
        <asp:Label runat="server" ID="MonsterName">Name</asp:Label>
        <asp:TextBox runat="server" ID="MonsterName_Text"></asp:TextBox>

        <asp:Label runat="server" ID="MonsterGender">Gender</asp:Label>
        <asp:DropDownList runat="server" ID="MonsterGender_List"></asp:DropDownList>

        <asp:Label runat="server" ID="MonsterType">Type</asp:Label>
        <asp:DropDownList runat="server" ID="MonsterType_List"></asp:DropDownList>

        <asp:Label runat="server" ID="MonsterTitle">Title</asp:Label>
        <asp:DropDownList runat="server" ID="MonsterTitle_List"></asp:DropDownList>

        <asp:Button runat="server" ID="MonsterSubmit" OnClick="MonsterSubmit_Click" Text="Submit"/>
    </div>
    <div>
        <asp:Label runat="server" ID="Monster">Monsters</asp:Label>
        <asp:Table runat="server" ID="Monster_Table"></asp:Table>
    </div>
</asp:Content>
