<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Welcome.aspx.cs" Inherits="MonsterWeb.Client.Welcome" %>
<%@ Register Src="~/login.ascx" TagPrefix="uc" TagName="login" %>

<asp:Content runat="server" ContentPlaceHolderID="body">
    <uc:login runat="server"></uc:login>
</asp:Content>
