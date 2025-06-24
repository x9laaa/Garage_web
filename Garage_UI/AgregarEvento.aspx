<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AgregarEvento.aspx.cs" Inherits="Garage_UI.AgregarEvento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/AgregarEvento.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contenido-principal">
        <h1>Agregar evento</h1>

        <asp:ValidationSummary ID="valSummary" runat="server"
            ValidationGroup="AddEventoVG"
            HeaderText="Por favor corrige los siguientes errores:"
            ForeColor="Red" />

        <div class="form-columns">
            <div class="form-group">
                <label>Nombre:</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="rfvNombre" runat="server"
                    ControlToValidate="txtNombre"
                    ErrorMessage="El nombre es obligatorio."
                    ValidationGroup="AddEventoVG"
                    Display="None" />
            </div>

            <div class="form-group">
                <label>Fecha:</label>
                <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" TextMode="Date" />

                <asp:RequiredFieldValidator ID="rfvFecha" runat="server"
                    ControlToValidate="txtFecha"
                    ErrorMessage="La fecha es obligatoria."
                    ValidationGroup="AddEventoVG"
                    Display="None" />
            </div>

            <div class="form-group">
                <label>Dirección:</label>
                <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" />
                <asp:RequiredFieldValidator ID="rfvDireccion" runat="server"
                    ControlToValidate="txtDireccion"
                    ErrorMessage="La dirección es obligatoria."
                    ValidationGroup="AddEventoVG"
                    Display="None" />
            </div>

            <div class="form-group">
                <label>Precio:</label>
                <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" />


                <asp:RegularExpressionValidator ID="revPrecio" runat="server"
                    ControlToValidate="txtPrecio"
                    ValidationExpression="^\d{4,6}$"
                    ErrorMessage="El precio debe ser un número válido en pesos chilenos (ej: 19990)."
                    ValidationGroup="AddEventoVG"
                    Display="None" />

            </div>

            <div class="form-group">
                <label>Tipo de evento:</label>
                <asp:DropDownList ID="ddlTipoEvento" runat="server" CssClass="form-control"
                    AutoPostBack="true" OnSelectedIndexChanged="ddlTipoEvento_SelectedIndexChanged">
                    <asp:ListItem Text="Seleccionar" Value="" Selected="True" />
                    <asp:ListItem Text="Concierto" Value="Concierto" />
                    <asp:ListItem Text="Exposición" Value="Exposicion" />
                </asp:DropDownList>
                <asp:CompareValidator ID="cvTipo" runat="server"
                    ControlToValidate="ddlTipoEvento"
                    ValueToCompare="Seleccionar"
                    Operator="NotEqual"
                    Type="String"
                    ErrorMessage="Debe seleccionar un tipo de evento."
                    ValidationGroup="AddEventoVG"
                    Display="None" />
            </div>
        </div>

        <asp:Panel ID="panelConcierto" runat="server" Visible="false">
            <div class="form-section">
                <div class="form-columns">
                    <div class="form-group">
                        <label>Artista:</label>
                        <asp:TextBox ID="txtArtista" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="rfvArtista" runat="server"
                            ControlToValidate="txtArtista"
                            ErrorMessage="Debe ingresar el artista."
                            ValidationGroup="AddEventoVG"
                            Enabled="false"
                            Display="None" />
                    </div>
                    <div class="form-group">
                        <label>Estilo:</label>
                        <asp:TextBox ID="txtEstilo" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="rfvEstilo" runat="server"
                            ControlToValidate="txtEstilo"
                            ErrorMessage="Debe ingresar el estilo."
                            ValidationGroup="AddEventoVG"
                            Enabled="false"
                            Display="None" />
                    </div>
                </div>
            </div>
        </asp:Panel>

        <asp:Panel ID="panelExposicion" runat="server" Visible="false">
            <div class="form-section">
                <div class="form-columns">
                    <div class="form-group">
                        <label>Expositor:</label>
                        <asp:TextBox ID="txtExpositor" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="rfvExpositor" runat="server"
                            ControlToValidate="txtExpositor"
                            ErrorMessage="Debe ingresar el expositor."
                            ValidationGroup="AddEventoVG"
                            Enabled="false"
                            Display="None" />
                    </div>
                    <div class="form-group">
                        <label>Categoría:</label>
                        <asp:TextBox ID="txtCategoria" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="rfvCategoria" runat="server"
                            ControlToValidate="txtCategoria"
                            ErrorMessage="Debe ingresar la categoría."
                            ValidationGroup="AddEventoVG"
                            Enabled="false"
                            Display="None" />
                    </div>
                </div>
            </div>
        </asp:Panel>

        <div class="form-group full-width">
            <asp:Button ID="btnAgregarEvento" runat="server" Text="Agregar evento"
                OnClick="btnAgregarEvento_Click"
                CssClass="btn"
                ValidationGroup="AddEventoVG" />
        </div>
    </div>
</asp:Content>
