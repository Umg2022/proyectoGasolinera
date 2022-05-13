using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace proyectoGasolinera
{
    public partial class frmFormaPago : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            wsFormaPago.wsFormaPagoSoapClient ws = new wsFormaPago.wsFormaPagoSoapClient();
            DataSet ds = ws.listaFormasdePago();
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
            wsFormaPago.wsFormaPagoSoapClient ws = new wsFormaPago.wsFormaPagoSoapClient();
            ws.insertar_FormadePago(txtFormaPago.Text);

            DataSet ds = ws.listaFormasdePago();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            wsFormaPago.wsFormaPagoSoapClient ws = new wsFormaPago.wsFormaPagoSoapClient();
            ws.actualizar_formapago(int.Parse(txtID.Text), txtFormaPago.Text);

            DataSet ds = ws.listaFormasdePago();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            wsFormaPago.wsFormaPagoSoapClient ws = new wsFormaPago.wsFormaPagoSoapClient();
            ws.eliminar_formapago(int.Parse(txtID.Text));

            DataSet ds = ws.listaFormasdePago();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            txtFormaPago.Text = GridView1.SelectedRow.Cells[2].Text.ToString();

            Label1.Visible = true;
            txtID.Visible = true;
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        public void limpiar()
        {
            txtID.Text = "";
            txtFormaPago.Text = "";
        }
    }
}