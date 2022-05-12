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
    public partial class frmTipoUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            wsTipoUsuario.wsTipoUsuarioSoapClient ws = new wsTipoUsuario.wsTipoUsuarioSoapClient();
            DataSet ds = ws.listado_tipousuario();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void btnGuardar_Click1(object sender, EventArgs e)
        {
            wsTipoUsuario.wsTipoUsuarioSoapClient ws = new wsTipoUsuario.wsTipoUsuarioSoapClient();
            ws.insertar_tipousuario(txtNombre.Text);

            DataSet ds = ws.listado_tipousuario();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            wsTipoUsuario.wsTipoUsuarioSoapClient ws = new wsTipoUsuario.wsTipoUsuarioSoapClient();
            ws.actualizar_tipousuario(int.Parse(txtID.Text), txtNombre.Text);

            DataSet ds = ws.listado_tipousuario();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            wsTipoUsuario.wsTipoUsuarioSoapClient ws = new wsTipoUsuario.wsTipoUsuarioSoapClient();
            ws.eliminar_tipousuario(int.Parse(txtID.Text));

            DataSet ds = ws.listado_tipousuario();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            txtNombre.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
        }
        public void limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
        }
    }
}