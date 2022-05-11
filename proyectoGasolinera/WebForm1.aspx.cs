using System;
using System.Data;

namespace ConsumirWebService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WServicioWeb.wsUsuarioSoapClient ws = new WServicioWeb.wsUsuarioSoapClient();
            DataSet ds = ws.listado_usuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void txtTipoUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            WServicioWeb.wsUsuarioSoapClient ws = new WServicioWeb.wsUsuarioSoapClient();
            ws.insertar_usuario(int.Parse(txtempleado.Text), int.Parse(txtTipoUsuario.Text), txtNombreUsuario.Text, txtContra.Text);
            DataSet ds = ws.listado_usuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            WServicioWeb.wsUsuarioSoapClient ws = new WServicioWeb.wsUsuarioSoapClient();
            ws.actualizar_usuario(int.Parse(txtCodigoUsuario.Text), int.Parse(txtempleado.Text), int.Parse(txtTipoUsuario.Text), txtNombreUsuario.Text, txtContra.Text);
            DataSet ds = ws.listado_usuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigoUsuario.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            txtempleado.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            txtTipoUsuario.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            txtNombreUsuario.Text = GridView1.SelectedRow.Cells[4].Text.ToString();
            txtContra.Text = GridView1.SelectedRow.Cells[5].Text.ToString();

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            WServicioWeb.wsUsuarioSoapClient ws = new WServicioWeb.wsUsuarioSoapClient();
            ws.eliminar_usuario(int.Parse(txtCodigoUsuario.Text));
            DataSet ds = ws.listado_usuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void buscar(string usuario, string password)
        {
            string comprobarUser = " ";
            string comporbarPass;
            try
            {
                WServicioWeb.wsUsuarioSoapClient tipo = new WServicioWeb.wsUsuarioSoapClient();
                DataSet dsTipo = new DataSet();
                dsTipo = tipo.usuario(usuario, password);
                if (dsTipo.Tables[0].Rows.Count > 0)

                {
                   
                    comprobarUser = dsTipo.Tables[0].Rows[0]["nombreUsuario"].ToString();
                    comporbarPass = dsTipo.Tables[0].Rows[0]["password"].ToString();

                    if (txtUsuario.Text == comprobarUser && txtPassword.Text == comporbarPass)
                    {
                        txtempleado.Text = "Encontrado";
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            buscar(txtUsuario.Text,txtPassword.Text);

            
        }
    }

}