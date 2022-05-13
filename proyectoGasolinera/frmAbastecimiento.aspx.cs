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
                DataSet dsProveedor = new DataSet();
                dsProveedor = proveedor.listado_proveedores();
                ddProveedor.DataSource = dsProveedor; // guardar en el dowdown list todo lo que tenga mi tabla empleado
                ddProveedor.DataValueField = "idProveedor"; // ocultar el valor idempleado
                ddProveedor.DataTextField = "nombreProveedor"; //mostrar nombre de mi empleado
                ddProveedor.DataBind();

                wsEmpleado.wsEmpleadoSoapClient empleado = new wsEmpleado.wsEmpleadoSoapClient();
                DataSet dsEmpleado = new DataSet();
                dsEmpleado = empleado.listado_empleados();
                ddEmpleado.DataSource = dsEmpleado; // guardar en el dowdown list todo lo que tenga mi tabla empleado
                ddEmpleado.DataValueField = "idEmpleado"; // ocultar el valor idempleado
                ddEmpleado.DataTextField = "nombreEmpleado"; //mostrar nombre de mi empleado
                ddEmpleado.DataBind();

                wsTipoCombustible.wsTipoCombustibleSoapClient tipo = new wsTipoCombustible.wsTipoCombustibleSoapClient();
                DataSet dsTipo = new DataSet();
                dsTipo = tipo.Listado_Tipo_De_Combustible();
                ddTipo.DataSource = dsTipo; // guardar en el dowdown list todo lo que tenga mi tabla empleado
                ddTipo.DataValueField = "idTIpoCombustible"; // ocultar el valor idempleado
                ddTipo.DataTextField = "nombreTipoCombustible"; //mostrar nombre de mi empleado
                ddTipo.DataBind();

                wsAbastecimiento.wsAbastecimientoSoapClient ws = new wsAbastecimiento.wsAbastecimientoSoapClient();
                DataSet ds = ws.listado_abastecimiento();
                GridView1.DataSource = ds.Tables[0];
                GridView1.AutoGenerateSelectButton = true;
                GridView1.DataBind();
            }

            lblID.Visible = false;
            txtID.Visible = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
        }

        protected void txtPrueba_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            wsAbastecimiento.wsAbastecimientoSoapClient ws = new wsAbastecimiento.wsAbastecimientoSoapClient();
            ws.insertar_abastecimiento(Convert.ToInt32(ddProveedor.SelectedValue), 1, 1,25,35.5);
           
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            wsAbastecimiento.wsAbastecimientoSoapClient ws = new wsAbastecimiento.wsAbastecimientoSoapClient();
            ws.actualizar_abastecimiento(int.Parse(txtID.Text), int.Parse(ddProveedor.SelectedValue), int.Parse(ddEmpleado.SelectedValue), int.Parse(ddTipo.SelectedValue), int.Parse(txtCantidad.Text), double.Parse(txtCompra.Text));

            DataSet ds = ws.listado_abastecimiento();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            wsAbastecimiento.wsAbastecimientoSoapClient ws = new wsAbastecimiento.wsAbastecimientoSoapClient();
            ws.eliminar_abastecimiento(int.Parse(txtID.Text));

            DataSet ds = ws.listado_abastecimiento();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void btnGuardar_Click1(object sender, EventArgs e)
        {
            wsAbastecimiento.wsAbastecimientoSoapClient ws = new wsAbastecimiento.wsAbastecimientoSoapClient();
            ws.insertar_abastecimiento(int.Parse(ddProveedor.SelectedValue), int.Parse(ddEmpleado.SelectedValue), int.Parse(ddTipo.SelectedValue), int.Parse(txtCantidad.Text), double.Parse(txtCompra.Text));

            DataSet ds = ws.listado_abastecimiento();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            ddProveedor.SelectedValue = GridView1.SelectedRow.Cells[2].Text.ToString();
            ddEmpleado.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            ddTipo.Text = GridView1.SelectedRow.Cells[4].Text.ToString();
            txtCantidad.Text = GridView1.SelectedRow.Cells[5].Text.ToString();
            txtCompra.Text = GridView1.SelectedRow.Cells[6].Text.ToString();

            lblID.Visible = true;
            txtID.Visible = true;
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        public void limpiar()
        {
            txtID.Text = "";
            txtCantidad.Text = "";
            txtCompra.Text = "";
        }
    }
}