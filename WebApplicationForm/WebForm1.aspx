<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationForm.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12">
        <asp:Label ID="Label1" runat="server" Text="Öğrenciler"></asp:Label>
        <asp:DropDownList ID="ddlOgrenciler" runat="server"></asp:DropDownList>
    </div>
     <div class="col-md-12">
        <asp:Label ID="Label2" runat="server" Text="Türler"></asp:Label>
        <asp:DropDownList ID="ddlTurler" runat="server"></asp:DropDownList>
    </div>
     <div class="col-md-12">
        <asp:Label ID="Label3" runat="server" Text="Yillar"></asp:Label>
        <asp:DropDownList ID="ddlYillar" runat="server"></asp:DropDownList>
    </div> 
    <input id="Button1" type="button" value="button"  class="btn btn-success"/>
</asp:Content>
