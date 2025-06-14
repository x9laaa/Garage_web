using Garage_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Garage_UI
{
    public partial class DetalleEvento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {        
                if (string.IsNullOrEmpty(Request.QueryString["id"]))
                {
                    lblError.Text = "Debe proporcionar Id";
                    lblError.Visible = true;
                    pnlEvento.Visible = false;
                    return;
                }
                string id = Request.QueryString["id"];
                var evento = EventoController.GetEvento(id);

                if (evento == null)
                {
                    lblError.Text = "Evento no encontrado";
                    lblError.Visible = true;
                    pnlEvento.Visible = false;
                    return;
                }

                pnlEvento.Visible = true;
                lblNombreValor.Text = evento.Nombre;
                lblFechaValor.Text = evento.Fecha.ToString("dd/MM/yyyy");
                lblDireccionValor.Text = evento.Direccion;
                lblPrecioValor.Text = evento.Precio.ToString();

                if (evento is Concierto concierto)
                {
                    lblTipoValor.Text = "Concierto";
                    pnlConcierto.Visible = true;
                    lblArtistaValor.Text = concierto.Artista;
                    lblEstiloValor.Text = concierto.Estilo;
                }
                else if (evento is Exposicion exposicion)
                {
                    lblTipoValor.Text = "Exposición";
                    pnlExposicion.Visible = true;
                    lblExpositorValor.Text = exposicion.Expositor;
                    lblCategoriaValor.Text = exposicion.Categoria;
                }
            }
        }
    }
}