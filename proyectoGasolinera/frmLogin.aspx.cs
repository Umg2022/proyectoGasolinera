using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace proyectoGasolinera
{
    public partial class frmLogin : System.Web.UI.Page
    {
        string comprobarUser = "";
        string comporbarPass = "";
       
        protected void Page_Load(object sender, EventArgs e)
        {
           
;        }
       public Int32 buscar(string usuario, string password)
        {
            int numero = 0;
            try
            {
                wsUsuario.wsUsuarioSoapClient tipo = new wsUsuario.wsUsuarioSoapClient();
                DataSet dsTipo = new DataSet();
                dsTipo = tipo.usuario(usuario, password);
               usuario = dsTipo.Tables[0].Rows[0]["nombreUsuario"].ToString();
               password = dsTipo.Tables[0].Rows[0]["password"].ToString();
                //if (txtUsuario.Text == comprobarUser && txtPassword.Text == comporbarPass)

                if (password == txtPassword.Text && usuario == txtUsuario.Text)
                {
                    numero = 1;
                    
                }

                else
                    numero = 0;

            }
            catch (Exception ex)
            {
                
            }
            return numero;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            
          if (buscar(txtUsuario.Text, txtPassword.Text) ==1)
            {
                this.Page.Response.Write("<script language='JavaScript'>window.alert('Bienvenido');</script>");
                //Response.Redirect("frmFactura.aspx");
            }
          else
                this.Page.Response.Write("<script language='JavaScript'>window.alert('Usuario o Contraseña Invalidos');</script>");
        }


    }
}