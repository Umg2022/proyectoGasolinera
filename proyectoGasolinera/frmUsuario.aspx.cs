using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace proyectoGasolinera
{
    public partial class frmUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WServicioWeb.wsUsuarioSoapClient ws = new WServicioWeb.wsUsuarioSoapClient();
            DataSet ds = ws.listado_usuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WServicioWeb.wsUsuarioSoapClient ws = new WServicioWeb.wsUsuarioSoapClient();
            ws.insertar_usuario(int.Parse(txtEmpleado.Text), int.Parse(txtUsuario.Text), txtNombre.Text, txtPassword.Text);
            DataSet ds = ws.listado_usuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            WServicioWeb.wsUsuarioSoapClient ws = new WServicioWeb.wsUsuarioSoapClient();
            ws.actualizar_usuario(int.Parse(txtCodigoUsuario.Text), int.Parse(txtEmpleado.Text), int.Parse(txtUsuario.Text), txtNombre.Text, txtPassword.Text);
            DataSet ds = ws.listado_usuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            WServicioWeb.wsUsuarioSoapClient ws = new WServicioWeb.wsUsuarioSoapClient();
            ws.eliminar_usuario(int.Parse(txtCodigoUsuario.Text));
            DataSet ds = ws.listado_usuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigoUsuario.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            txtEmpleado.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            txtUsuario.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            txtNombre.Text = GridView1.SelectedRow.Cells[4].Text.ToString();
            txtPassword.Text = GridView1.SelectedRow.Cells[5].Text.ToString();
          
        }
    }
    }
