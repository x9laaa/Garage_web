<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetalleEvento.aspx.cs" Inherits="Garage_UI.DetalleEvento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/DetalleEvento.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contenido-principal">
        <h1>Detalle del Evento</h1>

        <asp:Label ID="lblError" runat="server" ForeColor="Red" Visible="false" />

        <asp:Panel ID="pnlEvento" runat="server" Visible="false">
            <div class="detalle-linea">
                <strong>Tipo:</strong>
                <asp:Label ID="lblTipoValor" runat="server" />
            </div>
            <div class="detalle-linea">
                <strong>Nombre:</strong>
                <asp:Label ID="lblNombreValor" runat="server" />
            </div>
            <div class="detalle-linea">
                <strong>Fecha:</strong>
                <asp:Label ID="lblFechaValor" runat="server" />
            </div>
            <div class="detalle-linea">
                <strong>Dirección:</strong>
                <asp:Label ID="lblDireccionValor" runat="server" />
            </div>
            <div class="detalle-linea">
                <strong>Precio:</strong>
                <asp:Label ID="lblPrecioValor" runat="server" />
            </div>

            <asp:Panel ID="pnlConcierto" runat="server" Visible="false">
                <div class="detalle-linea">
                    <strong>Artista:</strong>
                    <asp:Label ID="lblArtistaValor" runat="server" />
                </div>
                <div class="detalle-linea">
                    <strong>Estilo:</strong>
                    <asp:Label ID="lblEstiloValor" runat="server" />
                </div>
            </asp:Panel>

            <asp:Panel ID="pnlExposicion" runat="server" Visible="false">
                <div class="detalle-linea">
                    <strong>Expositor:</strong>
                    <asp:Label ID="lblExpositorValor" runat="server" />
                </div>
                <div class="detalle-linea">
                    <strong>Categoría:</strong>
                    <asp:Label ID="lblCategoriaValor" runat="server" />
                </div>
            </asp:Panel>
        </asp:Panel>
    </div>
</asp:Content>
