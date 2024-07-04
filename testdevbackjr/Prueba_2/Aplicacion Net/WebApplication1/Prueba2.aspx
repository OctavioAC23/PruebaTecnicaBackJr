<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Prueba2.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        
        Generar un archivo csv con las siguienets campos con su información(Login, Nombre completo, sueldo, fecha Ingreso)</p>        
    <p>

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Generer CSV " />

    </p>
</asp:Content>
