using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace proyectoGasolinera
{
    public partial class frmTipoCombustible : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            wsTipoCombustible.wsTipoCombustibleSoapClient ws = new wsTipoCombustible.wsTipoCombustibleSoapClient();
            DataSet ds = ws.Listado_Tipo_De_Combustible();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();

            lblID.Visible = false;
            txtID.Visible = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            txtNombre.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            txtPrecioAuto.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            txtPrecioCompleto.Text = GridView1.SelectedRow.Cells[4].Text.ToString();

            lblID.Visible = true;
            txtID.Visible = true;
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        protected void btnGuardar_Click1(object sender, EventArgs e)
        {
            wsTipoCombustible.wsTipoCombustibleSoapClient ws = new wsTipoCombustible.wsTipoCombustibleSoapClient();
            ws.Insertar_Tipo_De_Combustible(txtNombre.Text, double.Parse(txtPrecioAuto.Text), double.Parse(txtPrecioCompleto.Text));

            DataSet ds = ws.Listado_Tipo_De_Combustible();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            wsTipoCombustible.wsTipoCombustibleSoapClient ws = new wsTipoCombustible.wsTipoCombustibleSoapClient();
            ws.actualizar_Combustible(int.Parse(txtID.Text), txtNombre.Text, double.Parse(txtPrecioAuto.Text), double.Parse(txtPrecioCompleto.Text));

            DataSet ds = ws.Listado_Tipo_De_Combustible();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            wsTipoCombustible.wsTipoCombustibleSoapClient ws = new wsTipoCombustible.wsTipoCombustibleSoapClient();
            ws.eliminar_Combustible(int.Parse(txtID.Text));

            DataSet ds = ws.Listado_Tipo_De_Combustible();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        public void limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtPrecioAuto.Text = "";
            txtPrecioCompleto.Text = "";
        }

        protected void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}