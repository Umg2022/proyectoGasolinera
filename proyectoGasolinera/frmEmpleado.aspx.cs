using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace proyectoGasolinera
{
    public partial class frmEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                wsSucursal.wsSucursalSoapClient sucursal = new wsSucursal.wsSucursalSoapClient();
                DataSet dsSucursal = new DataSet();
                dsSucursal = sucursal.listado_sucursales();
                ddSucursal.DataSource = dsSucursal; // guardar en el dowdown list todo lo que tenga mi tabla empleado
                ddSucursal.DataValueField = "idSucursal"; // ocultar el valor idempleado
                ddSucursal.DataTextField = "nombreSucursal"; //mostrar nombre de mi empleado
                ddSucursal.DataBind();

                wsPuesto.wsPuestoSoapClient puesto = new wsPuesto.wsPuestoSoapClient();
                DataSet dsPuesto = new DataSet();
                dsPuesto = puesto.Listado_Puestos();
                ddPuesto.DataSource = dsPuesto; // guardar en el dowdown list todo lo que tenga mi tabla empleado
                ddPuesto.DataValueField = "idPuesto"; // ocultar el valor idempleado
                ddPuesto.DataTextField = "nombrePuesto"; //mostrar nombre de mi empleado
                ddPuesto.DataBind();

                wsEmpleado.wsEmpleadoSoapClient ws = new wsEmpleado.wsEmpleadoSoapClient();
                DataSet ds = ws.listado_empleados();
                GridView1.DataSource = ds.Tables[0];
                GridView1.AutoGenerateSelectButton = true;
                GridView1.DataBind();
            }
            Label1.Visible = false;
            txtID.Visible = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            wsEmpleado.wsEmpleadoSoapClient ws = new wsEmpleado.wsEmpleadoSoapClient();
            ws.insertar_empleado(int.Parse(ddSucursal.SelectedValue), int.Parse(ddPuesto.SelectedValue), txtNombre.Text, int.Parse(txtTelefono.Text), txtEmail.Text);

            DataSet ds = ws.listado_empleados();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            wsEmpleado.wsEmpleadoSoapClient ws = new wsEmpleado.wsEmpleadoSoapClient();
            ws.actualizar_empleado(int.Parse(txtID.Text), int.Parse(ddSucursal.SelectedValue), int.Parse(ddPuesto.SelectedValue), txtNombre.Text, int.Parse(txtTelefono.Text), txtEmail.Text);

            DataSet ds = ws.listado_empleados();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            wsEmpleado.wsEmpleadoSoapClient ws = new wsEmpleado.wsEmpleadoSoapClient();
            ws.eliminar_empleado(int.Parse(txtID.Text));

            DataSet ds = ws.listado_empleados();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            ddSucursal.SelectedValue = GridView1.SelectedRow.Cells[2].Text.ToString();
            ddPuesto.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            txtNombre.Text = GridView1.SelectedRow.Cells[4].Text.ToString();
            txtTelefono.Text = GridView1.SelectedRow.Cells[5].Text.ToString();
            txtEmail.Text = GridView1.SelectedRow.Cells[6].Text.ToString();

            Label1.Visible = true;
            txtID.Visible = true;
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        public void limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }
    }
}