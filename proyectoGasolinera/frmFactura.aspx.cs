using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace proyectoGasolinera
{
    public partial class frmFactura : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //se va ejecutar una sola vez, cuando el usuario presione un click 
            {
               
                wsEmpleado.wsEmpleadoSoapClient empleado = new wsEmpleado.wsEmpleadoSoapClient();
                DataSet dsEmpleado = new DataSet();
                dsEmpleado = empleado.listado_empleados();
                ddEmpleado.DataSource = dsEmpleado; // guardar en el dowdown list todo lo que tenga mi tabla empleado
                ddEmpleado.DataValueField = "idEmpleado"; // ocultar el valor idempleado
                ddEmpleado.DataTextField = "nombreEmpleado"; //mostrar nombre de mi empleado
                ddEmpleado.DataBind();
                wsCliente.wsClienteSoapClient cliente = new wsCliente.wsClienteSoapClient();
                DataSet dsCliente = new DataSet();
                dsCliente = cliente.listado_cliente();
                ddCliente.DataSource = dsCliente; // guardar en el dowdown list todo lo que tenga mi tabla empleado
                ddCliente.DataValueField = "idCliente"; // ocultar el valor idempleado
                ddCliente.DataTextField = "nombreCliente"; //mostrar nombre de mi empleado
                ddCliente.DataBind();

                wsTipoCombustible.wsTipoCombustibleSoapClient tipo  = new wsTipoCombustible.wsTipoCombustibleSoapClient();
                DataSet dsTipo = new DataSet();
                dsTipo = tipo.Listado_Tipo_De_Combustible();
                ddTipoCombustible.DataSource = dsTipo; // guardar en el dowdown list todo lo que tenga mi tabla empleado
                ddTipoCombustible.DataValueField = "idTipoCombustible"; // ocultar el valor idempleado
                ddTipoCombustible.DataTextField = "nombreTipoCombustible"; //mostrar nombre de mi empleado
                ddTipoCombustible.DataBind();
                buscarPrecioCompleto(Convert.ToInt32(ddTipoCombustible.SelectedValue));

                wsSucursal.wsSucursalSoapClient sucursal = new wsSucursal.wsSucursalSoapClient();
                DataSet dsSucursal = new DataSet();
                dsSucursal = sucursal.listado_sucursales();
                ddSucursal.DataSource = dsSucursal; // guardar en el dowdown list todo lo que tenga mi tabla empleado
                ddSucursal.DataValueField = "idSucursal"; // ocultar el valor idempleado
                ddSucursal.DataTextField = "nombreSucursal"; //mostrar nombre de mi empleado
                ddSucursal.DataBind();


                wsFormaPago.wsFormaPagoSoapClient forma = new wsFormaPago.wsFormaPagoSoapClient();
                DataSet dsForma = new DataSet();
                dsForma = forma.listaFormasdePago();
                ddForma.DataSource = dsForma; // guardar en el dowdown list todo lo que tenga mi tabla empleado
                ddForma.DataValueField = "idFormaPago"; // ocultar el valor idempleado
                ddForma.DataTextField = "tipoFormaPago"; //mostrar nombre de mi empleado
                ddForma.DataBind();

                wsBombaCombustible.wsBombacombustibleSoapClient bomba = new wsBombaCombustible.wsBombacombustibleSoapClient();
                DataSet dsBomba = new DataSet();
                dsBomba = bomba.listado_bombacombustible();
                ddBomba.DataSource = dsBomba; // guardar en el dowdown list todo lo que tenga mi tabla empleado
                ddBomba.DataTextField = "idBombaCombustible"; //mostrar nombre de mi empleado
                ddBomba.DataBind();

                /*
                wsVenta.wsVentaSoapClient venta = new wsVenta.wsVentaSoapClient();
                DataSet dsVenta = new DataSet();
                dsVenta = venta.listado_Venta();
                txtFactura.DataSource = dsSucursal; // guardar en el dowdown list todo lo que tenga mi tabla empleado
                txtFactura.DataValueField = "idSucursal"; // ocultar el valor idempleado
                txtFactura.DataTextField = "nombreSucursal"; //mostrar nombre de mi empleado
                txtFactura.DataBind();*/


                DataColumn id = dt.Columns.Add("idTipoCombustible", typeof(int));
                DataColumn combustible = dt.Columns.Add("Tipo Combustible", typeof(string));
                DataColumn cantidad = dt.Columns.Add("Cantidad", typeof(int));
                DataColumn precio = dt.Columns.Add("Precio", typeof(double));
               DataColumn subTotal = dt.Columns.Add("SubTotal", typeof(double));
                DataColumn bombac = dt.Columns.Add("No Bomba", typeof(int));
                DataColumn tpago = dt.Columns.Add("Forma De Pago", typeof(string));
                DataColumn tprueba = dt.Columns.Add("prueba", typeof(string));
                Session["tablaSesion"] = dt;

                txtFecha.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToString("hh:mm:ss");



            }
        }

        protected void buscarPrecioAuto (int idTipoCombustible)
        {
            try
            {
                wsTipoCombustible.wsTipoCombustibleSoapClient tipo = new wsTipoCombustible.wsTipoCombustibleSoapClient();
                DataSet dsTipo = new DataSet();
                dsTipo = tipo.buscar_Combustible(idTipoCombustible);
                if (dsTipo.Tables[0].Rows.Count > 0)
                {
                    txtPrecio.Text = dsTipo.Tables[0].Rows[0]["PrecioCombustibleAutoservicio"].ToString();
                   
                }
            }
            catch (Exception ex)
            {

            }
           
        }
        protected void buscarPrecioCompleto(int idTipoCombustible)
        {
            try
            {
                wsTipoCombustible.wsTipoCombustibleSoapClient tipo = new wsTipoCombustible.wsTipoCombustibleSoapClient();
                DataSet dsTipo = new DataSet();
                dsTipo = tipo.buscar_Combustible(idTipoCombustible);
                if (dsTipo.Tables[0].Rows.Count > 0)
                //   if (txtbuscar.text == dsTipo.Tables[0].Rows.Count )
                {
                    txtPrecio.Text = dsTipo.Tables[0].Rows[0]["PrecioCombustibleServicioCompleto"].ToString();

                }
            }
            catch (Exception ex)
            {

            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void ddTipoCombustible_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (ddTipoServicio.SelectedValue =="Auto Servicio")
            {
                buscarPrecioAuto(Convert.ToInt32(ddTipoCombustible.SelectedValue));
            } else

                buscarPrecioCompleto(Convert.ToInt32(ddTipoCombustible.SelectedValue));


        }

        protected void ddTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddTipoServicio.SelectedValue == "Auto Servicio")
            {
                buscarPrecioAuto(Convert.ToInt32(ddTipoCombustible.SelectedValue));
            }
            else

                buscarPrecioCompleto(Convert.ToInt32(ddTipoCombustible.SelectedValue));
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
           
          
        }

        public void totalFactura()
        {
            double total =0;
            foreach (GridViewRow row in gvArticulo.Rows)
            {
                total += Convert.ToDouble(row.Cells[4].Text);

            }
            txtTotal.Text = total.ToString();
           
        }

        protected void Insertar_Click(object sender, EventArgs e)
        {
            dt = Session["tablaSesion"] as DataTable;
            DataRow fila = dt.NewRow();
            double subtotal = Convert.ToDouble(txtCantidad.Text);

            dt.Rows.Add(ddTipoCombustible.SelectedValue, ddTipoCombustible.SelectedItem.ToString(),txtCantidad.Text,txtPrecio.Text,subtotal,  ddBomba.SelectedItem.ToString(), ddForma.SelectedItem.ToString());
            //
            gvArticulo.DataSource = dt;
            gvArticulo.DataBind();

            Session["tablaSesion"] = dt;
            totalFactura();
        }

        protected void gvArticulo_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int index    = Convert.ToInt32(e.CommandArgument); // permitir capturar la fila q estamos seleccionando
                dt = (DataTable) Session["tablaSesion"];
                dt.Rows.RemoveAt(index);
                gvArticulo.DataSource= dt;
                gvArticulo.DataBind();

                Session["tablaSesion"] = dt;
                totalFactura();


            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            wsVenta.wsVentaSoapClient  venta = new wsVenta.wsVentaSoapClient();
            int respEncabezado =0;
            int cont = 0;
            string total = (txtTotal.Text);
            respEncabezado = venta.insertar_Venta(txtFactura.Text, Convert.ToInt32(ddCliente.SelectedValue), Convert.ToInt32(ddEmpleado.SelectedValue), Convert.ToDouble(txtTotal.Text)) ;
            if (respEncabezado == 1)
            {
                foreach(GridViewRow row in gvArticulo.Rows)
                {
                    venta.insertar_detalleVenta(txtFactura.Text,Convert.ToInt32(gvArticulo.DataKeys[cont].Value), Convert.ToInt32(ddForma.SelectedValue), Convert.ToInt32(ddBomba.SelectedValue),Convert.ToInt32(row.Cells[2].Text));
                    cont++;
                }

                this.Page.Response.Write("<script language='JavaScript'>window.alert('VENTA REALIZADA');</script>");
                
                txtCantidad.Text ="";
                txtTotal.Text = "";
                txtFactura.Text = "";
                DataTable ds = new DataTable();
                ds = null;
                gvArticulo.DataSource = ds;
                gvArticulo.DataBind();

                for (int i = 0; gvArticulo.Columns.Count > i;)
                {
                    gvArticulo.Columns.RemoveAt(i);
                }

                ViewState["CurrentData"] = null;
            }
            else
            {
                
                
                this.Page.Response.Write("<script language='JavaScript'>window.alert('Venta No Realizada');</script>");
            }
        }

        protected void txtFactura_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
           
    
