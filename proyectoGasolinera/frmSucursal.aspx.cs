using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proyectoGasolinera
{
    public partial class frmSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            wsSucursal.wsSucursalSoapClient ws = new wsSucursal.wsSucursalSoapClient();
            DataSet ds = ws.listado_sucursales();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();

            lblID.Visible = false;
            txtID.Visible = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        protected void btnGuardar_Click1(object sender, EventArgs e)
        {
            wsSucursal.wsSucursalSoapClient ws = new wsSucursal.wsSucursalSoapClient();
            ws.insertar_sucursal(txtNombre.Text, txtDireccion.Text, int.Parse(txtTelefono.Text));

            DataSet ds = ws.listado_sucursales();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            wsSucursal.wsSucursalSoapClient ws = new wsSucursal.wsSucursalSoapClient();
            ws.actualizar_sucursal(int.Parse(txtID.Text), txtNombre.Text, txtDireccion.Text, int.Parse(txtTelefono.Text));

            DataSet ds = ws.listado_sucursales();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            txtNombre.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            txtDireccion.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            txtTelefono.Text = GridView1.SelectedRow.Cells[4].Text.ToString();

            lblID.Visible = true;
            txtID.Visible = true;
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            wsSucursal.wsSucursalSoapClient ws = new wsSucursal.wsSucursalSoapClient();
            ws.eliminar_sucursal(int.Parse(txtID.Text));

            DataSet ds = ws.listado_sucursales();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        public void limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }
        protected void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}