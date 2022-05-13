using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace proyectoGasolinera
{
    public partial class frmPuestos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            wsPuesto.wsPuestoSoapClient ws = new wsPuesto.wsPuestoSoapClient();
            DataSet ds = ws.Listado_Puestos();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();

            Label1.Visible = false;
            txtID.Visible = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            wsPuesto.wsPuestoSoapClient ws = new wsPuesto.wsPuestoSoapClient();
            ws.Insertar_Puesto(txtNombre.Text, txtCaracteristicas.Text, Int32.Parse(txtSueldo.Text));
            DataSet ds = ws.Listado_Puestos();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            wsPuesto.wsPuestoSoapClient ws = new wsPuesto.wsPuestoSoapClient();
            ws.actualizar_puesto(int.Parse(txtID.Text), txtNombre.Text, txtCaracteristicas.Text, Int32.Parse(txtSueldo.Text));

            DataSet ds = ws.Listado_Puestos();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            wsPuesto.wsPuestoSoapClient ws = new wsPuesto.wsPuestoSoapClient();
            ws.eliminar_sucursal(int.Parse(txtID.Text));

            DataSet ds = ws.Listado_Puestos();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            txtNombre.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            txtCaracteristicas.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            txtSueldo.Text = GridView1.SelectedRow.Cells[4].Text.ToString();

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
            txtCaracteristicas.Text = "";
            txtSueldo.Text = "";
        }
    }
}