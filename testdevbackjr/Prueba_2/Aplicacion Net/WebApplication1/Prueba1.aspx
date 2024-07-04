<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Prueba1.aspx.cs" Inherits="WebApplication1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        
        Listar top 10 usuarios de la base antes creada
        
    <p>
            <asp:GridView ID="grid_Top" runat="server" AutoGenerateColumns="False" DataKeyNames="Login" Height="171px" Width="926px">            
             <Columns>
                <asp:BoundField DataField="Login" HeaderText="Login" />
                <asp:BoundField DataField="NombreCompleto" HeaderText="NombreCompleto" />
                <asp:BoundField DataField="Sueldo" HeaderText="Sueldo" />
            </Columns>
            <EmptyDataTemplate>
Tabla Vacia
            </EmptyDataTemplate>
            <RowStyle BorderColor="#669999" BorderStyle="Double" />
        </asp:GridView>
    </p>
    <p>
        <br />
    </p>
</asp:Content>
