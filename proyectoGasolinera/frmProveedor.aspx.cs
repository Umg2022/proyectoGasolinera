using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace proyectoGasolinera
{
    public partial class frmProveedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            wsProveedor.wsProveedoresSoapClient ws = new wsProveedor.wsProveedoresSoapClient();
            DataSet ds = ws.listado_proveedores();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();

            Label4.Visible = false;
            txtID.Visible = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            wsProveedor.wsProveedoresSoapClient ws = new wsProveedor.wsProveedoresSoapClient();
            ws.insertar_proveedor(txtNombre.Text, int.Parse(txtTelefono.Text), txtEmail.Text);

            DataSet ds = ws.listado_proveedores();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            wsProveedor.wsProveedoresSoapClient ws = new wsProveedor.wsProveedoresSoapClient();
            ws.actualizar_proveedor(int.Parse(txtID.Text), txtNombre.Text, int.Parse(txtTelefono.Text), txtEmail.Text);

            DataSet ds = ws.listado_proveedores();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            wsProveedor.wsProveedoresSoapClient ws = new wsProveedor.wsProveedoresSoapClient();
            ws.eliminar_proveedor(int.Parse(txtID.Text));

            DataSet ds = ws.listado_proveedores();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            txtNombre.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            txtTelefono.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            txtEmail.Text = GridView1.SelectedRow.Cells[4].Text.ToString();

            Label4.Visible = true;
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