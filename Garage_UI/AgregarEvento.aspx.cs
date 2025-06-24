using Garage_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Garage_UI
{
    public partial class AgregarEvento : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                panelConcierto.Visible = false;
                panelExposicion.Visible = false;
            }
        }

        protected void ddlTipoEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = ddlTipoEvento.SelectedValue;

            panelConcierto.Visible = tipo == "Concierto";
            panelExposicion.Visible = tipo == "Exposicion";

            rfvArtista.Enabled = tipo == "Concierto";
            rfvEstilo.Enabled = tipo == "Concierto";

            rfvExpositor.Enabled = tipo == "Exposicion";
            rfvCategoria.Enabled = tipo == "Exposicion";
        }

         protected void btnAgregarEvento_Click(object sender, EventArgs e)

        {
            string id = Guid.NewGuid().ToString();
            string nombre = txtNombre.Text;
            DateTime fecha = DateTime.Parse(txtFecha.Text);
            string direccion = txtDireccion.Text;
            int precio = int.Parse(txtPrecio.Text);
            string tipo = ddlTipoEvento.SelectedValue;

            if (tipo == "Concierto")
            {
                string artista = txtArtista.Text;
                string estilo = txtEstilo.Text;
                EventoController.AddEvento(new Concierto(id,nombre, fecha, direccion, precio, artista, estilo));
                Response.Redirect("ListarEventos.aspx");

            }
            else if (tipo == "Exposicion")
            {
                string expositor = txtExpositor.Text;
                string categoria = txtCategoria.Text;
                EventoController.AddEvento(new Exposicion(id,nombre, fecha, direccion, precio, expositor, categoria));
                Response.Redirect("ListarEventos.aspx");
            }
        }
    }
}