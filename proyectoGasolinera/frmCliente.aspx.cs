using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace proyectoGasolinera
{
    public partial class frmCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            wsCliente.wsClienteSoapClient ws = new wsCliente.wsClienteSoapClient();
            DataSet ds = ws.listado_cliente();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();

            lblID.Visible = false;
            txtID.Visible = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            wsCliente.wsClienteSoapClient ws = new wsCliente.wsClienteSoapClient();
            ws.insertar_cliente(txtNombre.Text, txtDireccion.Text, txtNit.Text, txtEmail.Text);

            DataSet ds = ws.listado_cliente();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            wsCliente.wsClienteSoapClient ws = new wsCliente.wsClienteSoapClient();
            ws.actualizar_cliente(int.Parse(txtID.Text), txtNombre.Text, txtDireccion.Text, txtNit.Text, txtEmail.Text);

            DataSet ds = ws.listado_cliente();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            wsCliente.wsClienteSoapClient ws = new wsCliente.wsClienteSoapClient();
            ws.eliminar_cliente(int.Parse(txtID.Text));

            DataSet ds = ws.listado_cliente();
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
            txtNit.Text = GridView1.SelectedRow.Cells[4].Text.ToString();
            txtEmail.Text = GridView1.SelectedRow.Cells[5].Text.ToString();

            lblID.Visible = true;
            txtID.Visible = true;
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        public void limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtNit.Text = "";
            txtEmail.Text = "";
        }
    }
}