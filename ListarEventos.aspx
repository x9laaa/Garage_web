<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListarEventos.aspx.cs" Inherits="Garage_UI.ListarEventos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/ListarEventos.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contenido-principal">
        <h1>Lista de eventos</h1>
        <asp:Label ID="lblMessage" runat="server" ForeColor="Green" Visible="false" />
        <asp:GridView ID="gvEventos" runat="server" CssClass="gridview"
            AutoGenerateColumns="false" DataKeyNames="Id"
            OnSelectedIndexChanged="gvEventos_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="Direccion" HeaderText="Dirección" />
                <asp:BoundField DataField="Precio" HeaderText="Precio" />
                <asp:CommandField ShowSelectButton="true" SelectText="Ver Detalle" HeaderText="Acción"
                    ButtonType="Button" ControlStyle-CssClass="select-button" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
