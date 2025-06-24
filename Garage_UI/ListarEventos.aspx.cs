using Garage_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Garage_UI
{
    public partial class ListarEventos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check for message in URL
                if (Request.QueryString["message"] != null)
                {
                    lblMessage.Text = Server.UrlDecode(Request.QueryString["message"]);
                    lblMessage.Visible = true;
                }

                gvEventos.DataSource = EventoController.GetEvents();
                gvEventos.DataBind();
            }
        }

        protected void gvEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = gvEventos.SelectedDataKey.Value.ToString();
            Response.Redirect($"DetalleEvento.aspx?id={id}");
        }
    }
}