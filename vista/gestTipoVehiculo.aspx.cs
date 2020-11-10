

using Controlador.TipoVehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vista
{
    public partial class gestTipoVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int idtipovehiculo = Int32.Parse(txtId.Text);
            string typename = textName.Text;

            logicaControladorTipoVehiculo negocioAddtipovehiculo = new logicaControladorTipoVehiculo();

            int resultadoAddTipoVehiculo = negocioAddtipovehiculo.NegociarInsertTipoVehiculo  (idtipovehiculo,typename);

            if (resultadoAddTipoVehiculo > 0)
                lblMensaje.Text = "Registro OK";
            else
                lblMensaje.Text = "No se pudo registrar";

            negocioAddtipovehiculo = null;
        }

        protected void btnlist_Click(object sender, EventArgs e)
        {
           GridView.DataSource=  logicaControladorTipoVehiculo.NegociarSelectTipoVehiculo();
            //hacer llenado de la tabla
            GridView.DataBind();
            //limpiar el formulario
            txtId.Text = textName.Text = "";


        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int idtipovehiculo = Int32.Parse(txtId.Text);
            string typename = textName.Text;

            logicaControladorTipoVehiculo negocioUpdatetipovehiculo = new logicaControladorTipoVehiculo();

            int resultadoUpdateTipoVehiculo = negocioUpdatetipovehiculo.NegociarUpdatetTipoVehiculo(idtipovehiculo, typename);

            if (resultadoUpdateTipoVehiculo > 0)
                lblMensaje.Text = "Update OK";
            else
                lblMensaje.Text = "No se pudo Actualizar";

            negocioUpdatetipovehiculo = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            int idtipovehiculo = Int32.Parse(txtId.Text);
            

            logicaControladorTipoVehiculo negocioDeletetipovehiculo = new logicaControladorTipoVehiculo();

            int resultadoDeleteTipoVehiculo = negocioDeletetipovehiculo.NegociarDeleteTipoVehiculo(idtipovehiculo);

            if (resultadoDeleteTipoVehiculo > 0)
                lblMensaje.Text = "Delete OK";
            else
                lblMensaje.Text = "No se pudo Eliminar";

            negocioDeletetipovehiculo = null;

        }
    }
}