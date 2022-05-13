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
            if (!IsPostBack)
            {
                wsEmpleado.wsEmpleadoSoapClient empleado = new wsEmpleado.wsEmpleadoSoapClient();
                DataSet dsEmpleado = new DataSet();
                dsEmpleado = empleado.listado_empleados();
                ddEmpleado.DataSource = dsEmpleado; // guardar en el dowdown list todo lo que tenga mi tabla empleado
                ddEmpleado.DataValueField = "idEmpleado"; // ocultar el valor idempleado
                ddEmpleado.DataTextField = "nombreEmpleado"; //mostrar nombre de mi empleado
                ddEmpleado.DataBind();

                wsTipoUsuario.wsTipoUsuarioSoapClient tipo = new wsTipoUsuario.wsTipoUsuarioSoapClient();
                DataSet dsTipo = new DataSet();
                dsTipo = tipo.listado_tipousuario();
                ddTipo.DataSource = dsTipo; // guardar en el dowdown list todo lo que tenga mi tabla empleado
                ddTipo.DataValueField = "idTipoUsuario"; // ocultar el valor idempleado
                ddTipo.DataTextField = "nombreTipoUsuario"; //mostrar nombre de mi empleado
                ddTipo.DataBind();

                wsUsuario.wsUsuarioSoapClient ws = new wsUsuario.wsUsuarioSoapClient();
                DataSet ds = ws.listado_usuarios();
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
            wsUsuario.wsUsuarioSoapClient ws = new wsUsuario.wsUsuarioSoapClient();
            ws.insertar_usuario(int.Parse(ddEmpleado.SelectedValue), int.Parse(ddTipo.SelectedValue), txtUsuario.Text, txtPassword.Text);

            DataSet ds = ws.listado_usuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
<<<<<<< HEAD
            limpiar();
=======
<<<<<<< HEAD
            limpiar();
=======
           
>>>>>>> f3847f7792c3c8124314cadbde12039048d26cce
>>>>>>> f3a82f8f0fe54ec964e1270a26f0eda58a9961a8
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            wsUsuario.wsUsuarioSoapClient ws = new wsUsuario.wsUsuarioSoapClient();
            ws.actualizar_usuario(int.Parse(txtID.Text),int.Parse(ddEmpleado.SelectedValue), int.Parse(ddTipo.SelectedValue), txtUsuario.Text, txtPassword.Text);

            DataSet ds = ws.listado_usuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            wsUsuario.wsUsuarioSoapClient ws = new wsUsuario.wsUsuarioSoapClient();
            ws.eliminar_usuario(int.Parse(txtID.Text));

            DataSet ds = ws.listado_usuarios();
            GridView1.DataSource = ds.Tables[0];
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
            limpiar();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            ddEmpleado.SelectedValue = GridView1.SelectedRow.Cells[2].Text.ToString();
            ddTipo.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            txtUsuario.Text = GridView1.SelectedRow.Cells[4].Text.ToString();
            txtPassword.Text = GridView1.SelectedRow.Cells[5].Text.ToString();

            Label1.Visible = true;
            txtID.Visible = true;
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        public void limpiar()
        {
            txtID.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }
    }
}