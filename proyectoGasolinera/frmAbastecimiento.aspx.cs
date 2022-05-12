using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace proyectoGasolinera
{
    public partial class frmAbastecimiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //se va ejecutar una sola vez, cuando el usuario presione un click 
            {
                wsProveedor.wsProveedoresSoapClient proveedor = new wsProveedor.wsProveedoresSoapClient();
                DataSet dsCliente = new DataSet();
                dsCliente = proveedor.listado_proveedores();
                ddProveedor.DataSource = dsCliente; // guardar en el dowdown list todo lo que tenga mi tabla empleado
                ddProveedor.DataValueField = "idProveedor"; // ocultar el valor idempleado
                ddProveedor.DataTextField = "nombreProveedor"; //mostrar nombre de mi empleado
                ddProveedor.DataBind();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            wsAbastecimiento.wsAbastecimientoSoapClient ws = new wsAbastecimiento.wsAbastecimientoSoapClient();
            //ws.insertar_abastecimiento(Convert.ToInt32(txtProveedor.SelectedValue), 1, 1,25,35.5);
            txtPrueba.Text = ddProveedor.SelectedValue;
        }

        protected void txtPrueba_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            wsAbastecimiento.wsAbastecimientoSoapClient ws = new wsAbastecimiento.wsAbastecimientoSoapClient();
            ws.insertar_abastecimiento(Convert.ToInt32(ddProveedor.SelectedValue), 1, 1,25,35.5);
           
        }
    }
}