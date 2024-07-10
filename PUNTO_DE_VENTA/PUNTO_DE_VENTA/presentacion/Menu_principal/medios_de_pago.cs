using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Management;
using System.Drawing.Printing;
using Microsoft.Reporting.WinForms;
using System.IO;
using PUNTO_DE_VENTA.presentacion.Menu_principal;
namespace PUNTO_DE_VENTA.presentacion.Menu_principal
{
    public partial class medios_de_pago : Form
    {
        
        
        public medios_de_pago()
        {
            InitializeComponent();
        }
        String serialpc;
        String moneda;
        int idcliente;
        int id_venta;
        double total;
        double feria=0;
        double efectivo_c;
        double restante = 0;
        int foco;
        bool s1 = true;
        bool s2 = true;
        bool s3 = true;
        String indicador;
        String proceso;
        String identificador_tipo_de_pago;
        String tipo_de_pago;
        double credito = 0;
        PrintDocument imprimir_ticket_val;
        int id_comprobante;
        String numero_fin;
        int id_producto;
        double cantidad;
        String stock_para_kardex;
        private void mostrar_comprobante_pordefecto()
        {
            SqlCommand cmd = new SqlCommand("select tipodoc from serializacion where por_defecto='SI'",conexion.ConexionMaestra.conectar);
            try
            {
                conexion.ConexionMaestra.abrir_conexion();
                lbl_comprobante.Text = Convert.ToString(cmd.ExecuteScalar());
                conexion.ConexionMaestra.cerrar_conexion();

            }
            catch  (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mostrar_comprobantes();

        }
        private void mostrar_comprobantes()
        {
            flp_comprobantes.Controls.Clear();
            try
            {
                conexion.ConexionMaestra.abrir_conexion();
                SqlCommand cmd = new SqlCommand("select tipodoc from serializacion where destino ='VENTAS'", conexion.ConexionMaestra.conectar);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Button btn = new Button();
                    btn.Text = rdr["tipodoc"].ToString();
                    btn.BackColor = Color.White;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif",11);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.ForeColor = Color.Black;
                    btn.Size = new System.Drawing.Size(251, 29);
                    flp_comprobantes.Controls.Add(btn);
                    if (btn.Text  == lbl_comprobante.Text)
                    {
                        btn.Visible = false;
                    }
                    btn.Click += Btn_Click;
                }
                conexion.ConexionMaestra.cerrar_conexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            lbl_comprobante.Text = ((Button)sender).Text;
            mostrar_comprobantes();
            validar_comprobantes();
            identificar_tipo_pago();
            if(lbl_comprobante.Text=="FACTURA" && tipo_de_pago== "CREDITO")
            {
                panel_cliente_credito.Visible = false;

            }
            if(lbl_comprobante.Text=="FACTURA" && tipo_de_pago== "EFECTIVO")
            {
                panel_cliente_credito.Visible = true;
                lbl_ind.Text = "Cliente:(obligatorio)";

            }
            else if (lbl_comprobante.Text != "FACTURA" && tipo_de_pago == "EFECTIVO")
            {
                panel_cliente_credito.Visible = true;
                lbl_ind.Text = "Cliente:(opcional)";
            }
            if(lbl_comprobante.Text == "FACTURA" && tipo_de_pago == "TARJETA")
            {
                panel_cliente_credito.Visible = true;
               panel_cliente_credito.Visible = true;
                lbl_ind.Text = "Cliente:(obligatorio)";
            }
            if(lbl_comprobante.Text != "FACTURA" && tipo_de_pago == "TARJETA")
            {
                panel_cliente_credito.Visible = true;
                lbl_ind.Text = "Cliente:(opcional)";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guardarEImprimiarEnterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        void mostrar_moneda_empresa()
        {
           
            try
            {
                SqlCommand cmd = new SqlCommand("select moneda from empresa", conexion.ConexionMaestra.conectar);
                conexion.ConexionMaestra.abrir_conexion();
                moneda =Convert.ToString(cmd.ExecuteScalar());
                Console.WriteLine(moneda);
                conexion.ConexionMaestra.cerrar_conexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void configurarcion_diseño()
        {
           btn_guardar_imprimir.Text = "Guardar e imprimir" + lbl_comprobante.Text +" (Enter)";
            lbl_feria.Text = "0.0";
            lbl_restante.Text ="0.0";
            lbl_total.Text = moneda + " " + Menu_principal.menu_principal.total;
            total =Menu_principal.menu_principal.total;
            idcliente = 0;
            txt_efectivo.Text =Convert.ToString( total);
            
        }
        void obtener_id_venta()
        {
            id_venta = menu_principal.idventa;
        }
        private void identificar_tipo_pago()
        {
            int I_efectivo = 4;
            int I_credito = 2;
            int I_tarjeta = 3;
            if (txt_efectivo.Text == "") txt_efectivo.Text = "0";
            if (txt_tarjeta.Text == "") txt_tarjeta.Text = "0";
            if (txt_credito.Text == "") txt_credito.Text = "0";
            if (txt_efectivo.Text == ".") txt_efectivo.Text = "0";
            if (txt_tarjeta.Text == ".") txt_tarjeta.Text = "0";
            if (txt_credito.Text == ".") txt_credito.Text = "0";
            if (txt_efectivo.Text == "0") I_efectivo = 0;
            if (txt_tarjeta.Text == "0") I_tarjeta = 0;
            if (txt_credito.Text == "0") I_credito= 0;
            int calcular_identificador = I_credito + I_tarjeta + I_efectivo;
            if (calcular_identificador == 4) { identificador_tipo_de_pago = "EFECTIVO"; }
            if (calcular_identificador == 2) { identificador_tipo_de_pago = "CREDITO"; }
            if (calcular_identificador == 3) { identificador_tipo_de_pago = "TARJETA"; }
            if (calcular_identificador > 4) { identificador_tipo_de_pago = "MIXTO"; }
            tipo_de_pago = identificador_tipo_de_pago;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(restante == 0)
            {
                indicador = "Vista previa";
                identificar_tipo_pago();
                rellenar_texbox_vacios();
                verificar_datos();
                mostrar_ticket_impreso();
            }
            else
            {
                MessageBox.Show("EL restante debe ser 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void validar_comprobantes()
        {
            try
            {
                conexion.ConexionMaestra.abrir_conexion();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("buscar_tipo_de_documentos_para_ventas",conexion.ConexionMaestra.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", lbl_comprobante.Text);      
                da.Fill(dt);
                lbl_series.Text = dt.Rows[0]["serie"].ToString();
                id_comprobante = Convert.ToInt32( dt.Rows[0]["id_serializacion"].ToString());
                int numerofin =Convert.ToInt32( dt.Rows[0]["numerofin"].ToString());
                 numero_fin = Convert.ToString(numerofin + 1);
                String cantidad_numeros = dt.Rows[0]["cantidad_numeros"].ToString();
                lbl_corelativo.Text =negocio.procedimientos_necesarios.ceros_comprobantes(numero_fin,Convert.ToInt32( cantidad_numeros));
                conexion.ConexionMaestra.cerrar_conexion();           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void mostrar_cliente_generico()
        {
            SqlCommand cmd = new SqlCommand("select idcliente from clientes where cliente ='NEUTRO'", conexion.ConexionMaestra.conectar);
            try
            {
                conexion.ConexionMaestra.abrir_conexion();
                idcliente =Convert.ToInt32( cmd.ExecuteScalar());
                conexion.ConexionMaestra.cerrar_conexion();
            }
            catch (Exception ex)
            {

            }
        }
        private void venta_en_efectivo()
        {
            validar_comprobantes();
            actualizar_serie();
            confirmar_venta_efectivo();
            if(proceso == "Correcto") {
                disminuir_stock();
                insertar_salida_kardex();
                aumentar_monto_a_cliente();
                validar_tipo_impresion();    
            }
        }
        private void insertar_salida_kardex()
        {
          try
            {
                if (stock_para_kardex != "Ilimitado")
                {
                    conexion.ConexionMaestra.abrir_conexion();
                    SqlCommand cmd = new SqlCommand("insertar_salida_kardex", conexion.ConexionMaestra.conectar);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fecha",DateTime.Today);
                    cmd.Parameters.AddWithValue("@motivo","VENTA. Comprobante: " + lbl_comprobante.Text + " " + lbl_corelativo.Text);
                    cmd.Parameters.AddWithValue("@id_producto",id_producto);
                    cmd.Parameters.AddWithValue("@cantidad",cantidad);
                    cmd.Parameters.AddWithValue("@id_usuario",menu_principal.idusaurio_inicio_s);
                    cmd.Parameters.AddWithValue("@tipo","SALIDA");
                    cmd.Parameters.AddWithValue("@estado","CONFIRMADO");
                    cmd.Parameters.AddWithValue("@id_caja",menu_principal.idcaja);
                    cmd.ExecuteNonQuery();
                    conexion.ConexionMaestra.cerrar_conexion();
                }        
            }
            catch (Exception ex)
            {
                conexion.ConexionMaestra.cerrar_conexion();
                MessageBox.Show(ex.Message);
            }
        }
        private void mostrar_productos()
        {
            try
            {
                conexion.ConexionMaestra.abrir_conexion();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_productos_creados", conexion.ConexionMaestra.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idventa", id_venta);
                da.Fill(dt);
                id_producto = Convert.ToInt32(dt.Rows[0]["id_producto"].ToString());
                cantidad = Convert.ToDouble(dt.Rows[0]["cantidad"].ToString());
                stock_para_kardex =dt.Rows[0]["stock"].ToString();


                conexion.ConexionMaestra.cerrar_conexion();             
            }

            catch(Exception ex)
            {
                conexion.ConexionMaestra.cerrar_conexion();
                MessageBox.Show(ex.Message);
            }
        }

        private void disminuir_stock()
        {
            try
            {
                mostrar_productos();

                conexion.ConexionMaestra.abrir_conexion();
                SqlCommand cmd = new SqlCommand("disminuir_stock_productos", conexion.ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idproducto", id_producto);
                cmd.Parameters.AddWithValue("@cantidad",cantidad);
                cmd.ExecuteNonQuery();
                conexion.ConexionMaestra.cerrar_conexion();
            }
            catch (Exception ex)
            {
                conexion.ConexionMaestra.cerrar_conexion();
                MessageBox.Show(ex.Message);
            }
        }
        private void actualizar_serie()
        {
            try
            {
                conexion.ConexionMaestra.abrir_conexion();
                SqlCommand cmd = new SqlCommand("actualizar_serializacion",conexion.ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idserie",id_comprobante);            
                cmd.ExecuteNonQuery();
                conexion.ConexionMaestra.cerrar_conexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void confirmar_venta_efectivo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("confirmar_venta",conexion.ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.ConexionMaestra.abrir_conexion();
                cmd.Parameters.AddWithValue("@idventa",id_venta);
                cmd.Parameters.AddWithValue("@monto_total",total);
                cmd.Parameters.AddWithValue("@impuesto",0);
                cmd.Parameters.AddWithValue("@saldo",feria);
                cmd.Parameters.AddWithValue("@tipo_de_pago","EFECTIVO");
                cmd.Parameters.AddWithValue("@estado","CONFIRMADO");
                cmd.Parameters.AddWithValue("@comprobante",lbl_comprobante.Text);
                cmd.Parameters.AddWithValue("@numero_documento",(lbl_series.Text + "-"+lbl_corelativo.Text ));
                cmd.Parameters.AddWithValue("@fecha_venta",DateTime.Now);
                cmd.Parameters.AddWithValue("@accion","VENTA");
                cmd.Parameters.AddWithValue("@fecha_pago",dtp_fecha_vencimiento_credito.Value);
                cmd.Parameters.AddWithValue("@ref_tarjeta","NULO");
                cmd.Parameters.AddWithValue("@formato_pago",txt_efectivo.Text);
                cmd.Parameters.AddWithValue("@idcliente",idcliente);
                cmd.Parameters.AddWithValue("@vuelto",feria);
                cmd.Parameters.AddWithValue("@efectivo",efectivo_c);
                cmd.Parameters.AddWithValue("@credito",txt_credito.Text);
                cmd.Parameters.AddWithValue("@tarjeta",txt_tarjeta.Text);
                cmd.ExecuteNonQuery();
                conexion.ConexionMaestra.cerrar_conexion();
                proceso = "Correcto";            
           }
            catch (Exception ex)
            {
                proceso = "incorrecto";
                conexion.ConexionMaestra.cerrar_conexion();
                MessageBox.Show(ex.StackTrace + ex.Message);
            }

        }
        private void validar_tipo_impresion()
        {
            if (indicador == "Vista previa")
            {
                mostrar_ticket_impreso();
            }
            else if (indicador == "IMPRIMIR DIRECTO")
            {
                imprimir_directo();
            }
        }
        private void imprimir_directo()
        {
            try
            {
               

                    conexion.ConexionMaestra.abrir_conexion();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("mostrar_ticket", conexion.ConexionMaestra.conectar);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@idventa", id_venta);
                    da.Fill(dt);
               
                    reportViewer1.LocalReport.DataSources.Clear();
                    ReportDataSource rp = new ReportDataSource("DataSet1", dt);
                    reportViewer1.LocalReport.DataSources.Add(rp);
                    reportViewer1.LocalReport.Refresh();
                    reportViewer1.RefreshReport();
                    conexion.ConexionMaestra.cerrar_conexion();
                
                imprimir_tickets imp = new imprimir_tickets();
                imp.printerName = cb_impresora.Text;
                imp.Imprime(reportViewer1.LocalReport);

                   
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        private void  mostrar_ticket_impreso() {

            panel_ticket_vista.Visible = true;
            panel_ticket_vista.Dock = DockStyle.Fill;
            panel_guardar_datos.Visible = false;
            panel_guardar_datos.Dock = DockStyle.None;
 
            try
            {
                conexion.ConexionMaestra.abrir_conexion();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_ticket",conexion.ConexionMaestra.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idventa", id_venta);
              
                da.Fill(dt);
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rp = new ReportDataSource("DataSet1", dt);
            
              reportViewer1.LocalReport.DataSources.Add(rp);
               
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
                conexion.ConexionMaestra.cerrar_conexion();
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.StackTrace + ex.Message);
            }
        }

        private void aumentar_monto_a_cliente()
        {
            if (credito> 0)
            { 
            try
            {
                conexion.ConexionMaestra.abrir_conexion();
                SqlCommand cmd = new SqlCommand("aumentar_saldo_cliente",conexion.ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcliente",idcliente);
                cmd.Parameters.AddWithValue("@saldo",txt_credito.Text);
                    cmd.ExecuteNonQuery();
                    conexion.ConexionMaestra.cerrar_conexion();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace + ex.Message);
            }

            }
        }
        private void verificar_datos()
        {
            if (tipo_de_pago == "EFECTIVO" && feria >= 0)
            {
                vender_efectivo();
            }
            else if (tipo_de_pago == "EFECTIVO" && feria < 0)
            {
                MessageBox.Show("!La feria no puede ser menor al total!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tipo_de_pago == "CREDITO" && dgv_clientes.Visible == false)
            {
                vender_efectivo();
            }
            else if (tipo_de_pago == "CREDITO" && dgv_clientes.Visible == true)
            {
                MessageBox.Show("Selecciona un cliente para poder proseguir con la venta", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            if (tipo_de_pago == "TARJETA")
            {
                vender_efectivo();
            }
            if (tipo_de_pago == "MIXTO")
            {
                vender_efectivo();
            }



        }
        private void vender_efectivo()
        {
            if (idcliente == 0) 
            {
                mostrar_cliente_generico();
            }
            if (lbl_comprobante.Text == "FACTURA" && idcliente == 0 && tipo_de_pago != "CREDITO")
            {
                MessageBox.Show("Selecciona un cliente para facturar es obligatorio para poder proseguir", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (lbl_comprobante.Text =="FACTURA" && idcliente != 0)
            {
                venta_en_efectivo();
            }
            else if (lbl_comprobante.Text !="FACTURA" && tipo_de_pago != "CREDITO")
            {
                venta_en_efectivo();
            }
            else if (lbl_comprobante.Text != "FACTURA" && tipo_de_pago == "CREDITO") venta_en_efectivo(); 
           
        }
        private void rellenar_texbox_vacios()
        {
            if (txt_efectivo.Text == "") txt_efectivo.Text = "0";
            if (txt_credito.Text == "") txt_credito.Text = "0";
            if (txt_tarjeta.Text == "") txt_tarjeta.Text = "0";

        }
        void mostrar_impresoras_de_equipo()
        {
            cb_impresora.Items.Clear();
            for (var i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)     
            {
                cb_impresora.Items.Add(PrinterSettings.InstalledPrinters[i]);
            }
            cb_impresora.Items.Add("Ninguna");

        }
        void calcular_restante()
        {
            try
            {
                double efectivo = 0;
                double tarjeta = 0;
              
                if (txt_efectivo.Text == "") efectivo = 0;
                else efectivo = Convert.ToDouble(txt_efectivo.Text); 
                if (txt_credito.Text == "") credito = 0;
                else  credito = Convert.ToDouble(txt_credito.Text); 
                if (txt_tarjeta.Text == "") tarjeta = 0;
                else tarjeta = Convert.ToDouble(txt_tarjeta.Text);
                if(txt_efectivo.Text =="0.00") efectivo = 0;
                if (txt_credito.Text == "0.00") credito = 0;
                if (txt_tarjeta.Text == "0.00") tarjeta = 0;
                if (txt_efectivo.Text == ".") efectivo = 0;
                if (txt_credito.Text == ".") credito = 0;
                if (txt_tarjeta.Text == ".") tarjeta = 0;
                try
                {
                    if (efectivo > total)
                    {
                        efectivo_c = efectivo - (total +credito+tarjeta);
                        if(efectivo_c < 0)
                        {
                            feria = 0;
                            lbl_feria.Text = "0";
                            lbl_restante.Text = Convert.ToString( efectivo_c);
                            restante = efectivo_c;
                        }
                        else
                        {
                            feria = efectivo - (total - tarjeta - credito);
                            lbl_feria.Text =Convert.ToString( feria);
                            restante = efectivo - (total + credito + tarjeta+efectivo_c);
                            lbl_restante.Text = Convert.ToString( restante);
                            lbl_restante.Text = Decimal.Parse(lbl_restante.Text).ToString("##0.00");

                        }
                    }
                    else
                    {
                        feria = 0;
                        lbl_feria.Text = "0";
                        efectivo_c = efectivo;
                        restante = total - efectivo_c - credito - tarjeta;
                        lbl_restante.Text = Convert.ToString(restante);
                        lbl_restante.Text = Decimal.Parse(lbl_restante.Text).ToString("##0.00");
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.StackTrace + ex.Message); }
            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace + ex.Message); }
        }
        void mostrar_impresora()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("mostrar_impresora_por_caja", conexion.ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@serial", serialpc);
                try
                {
                    conexion.ConexionMaestra.abrir_conexion();
                    cb_impresora.Text = Convert.ToString( cmd.ExecuteScalar());
                    conexion.ConexionMaestra.cerrar_conexion();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        public void cambiar_formato_decimales()
        {
            negocio.procedimientos_necesarios.cambiar_formato_puntos();
        }
        private void medios_de_pago_Load(object sender, EventArgs e)
        {
           
            string HDD = System.Environment.CurrentDirectory.Substring(0, 1);
            ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + HDD + ":\"");
            disk.Get();
           serialpc = disk["VolumeSerialNumber"].ToString();
            cambiar_formato_decimales();
            mostrar_comprobante_pordefecto();
            validar_comprobantes();
            mostrar_moneda_empresa();
            configurarcion_diseño();
            obtener_id_venta();
            mostrar_impresora();
            mostrar_impresoras_de_equipo();
            calcular_restante();

            this.reportViewer1.RefreshReport();

         
        }

        private void txt_efectivo_TextChanged(object sender, EventArgs e)
        {
            calcular_restante();
        }

        private void txt_tarjeta_TextChanged(object sender, EventArgs e)
        {
            calcular_restante();
        }

        private void txt_credito_TextChanged(object sender, EventArgs e)
        {
            calcular_restante();
            panel_clientes_credito();
         
        }

        private void btn_num1_Click(object sender, EventArgs e)
        {
            if (foco == 1)
            {
                txt_efectivo.Text = txt_efectivo.Text + "1";
            }
            else if (foco == 2)
            {
                txt_tarjeta.Text = txt_tarjeta.Text + "1";
            }
            else if (foco == 3)
            {
                txt_efectivo.Text = txt_efectivo.Text + "1";
            }
        }

        private void btn_num2_Click(object sender, EventArgs e)
        {
            if (foco == 1)
            {
                txt_efectivo.Text = txt_efectivo.Text + "2";
            }
            else if (foco == 2)
            {
                txt_tarjeta.Text = txt_tarjeta.Text + "2";
            }
            else if (foco == 3)
            {
                txt_efectivo.Text = txt_efectivo.Text + "2";
            }
        }

        private void btn_num3_Click(object sender, EventArgs e)
        {
            if (foco == 1)
            {
                txt_efectivo.Text = txt_efectivo.Text + "3";
            }
            else if (foco == 2)
            {
                txt_tarjeta.Text = txt_tarjeta.Text + "3";
            }
            else if (foco == 3)
            {
                txt_efectivo.Text = txt_efectivo.Text + "3";
            }
        }

        private void btn_num4_Click(object sender, EventArgs e)
        {
            if (foco == 1)
            {
                txt_efectivo.Text = txt_efectivo.Text + "4";
            }
            else if (foco == 2)
            {
                txt_tarjeta.Text = txt_tarjeta.Text + "4";
            }
            else if (foco == 3)
            {
                txt_efectivo.Text = txt_efectivo.Text + "4";
            }
        }

        private void btn_num5_Click(object sender, EventArgs e)
        {
            if (foco == 1)
            {
                txt_efectivo.Text = txt_efectivo.Text + "5";
            }
            else if (foco == 2)
            {
                txt_tarjeta.Text = txt_tarjeta.Text + "5";
            }
            else if (foco == 3)
            {
                txt_efectivo.Text = txt_efectivo.Text + "5";
            }
        }

        private void btn_num6_Click(object sender, EventArgs e)
        {
            if (foco == 1)
            {
                txt_efectivo.Text = txt_efectivo.Text + "6";
            }
            else if (foco == 2)
            {
                txt_tarjeta.Text = txt_tarjeta.Text + "6";
            }
            else if (foco == 3)
            {
                txt_efectivo.Text = txt_efectivo.Text + "6";
            }
        }

        private void btn_num7_Click(object sender, EventArgs e)
        {
            if (foco == 1)
            {
                txt_efectivo.Text = txt_efectivo.Text + "7";
            }
            else if (foco == 2)
            {
                txt_tarjeta.Text = txt_tarjeta.Text + "7";
            }
            else if (foco == 3)
            {
                txt_efectivo.Text = txt_efectivo.Text + "7";
            }
        }

        private void btn_num8_Click(object sender, EventArgs e)
        {
            if (foco == 1)
            {
                txt_efectivo.Text = txt_efectivo.Text + "8";
            }
            else if (foco == 2)
            {
                txt_tarjeta.Text = txt_tarjeta.Text + "8";
            }
            else if (foco == 3)
            {
                txt_efectivo.Text = txt_efectivo.Text + "8";
            }
        }

        private void btn_num9_Click(object sender, EventArgs e)
        {
            if (foco == 1)
            {
                txt_efectivo.Text = txt_efectivo.Text + "9";
            }
            else if (foco == 2)
            {
                txt_tarjeta.Text = txt_tarjeta.Text + "9";
            }
            else if (foco == 3)
            {
                txt_efectivo.Text = txt_efectivo.Text + "9";
            }
        }

        private void btn_num0_Click(object sender, EventArgs e)
        {
            if (foco == 1)
            {
                txt_efectivo.Text = txt_efectivo.Text + "0";
            }
            else if (foco == 2)
            {
                txt_tarjeta.Text = txt_tarjeta.Text + "0";
            }
            else if (foco == 3)
            {
                txt_efectivo.Text = txt_efectivo.Text + "0";
            }
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            if (foco == 1)
            {
                if (s1 == true)
                {
                    txt_efectivo.Text = txt_efectivo.Text + ".";
                    s1 = false;
                }
                else
                {  
                    return; 
                }
            }
          else   if (foco == 2)
            {
                if (s2 == true)
                {
                    txt_tarjeta.Text = txt_tarjeta.Text + ".";
                    s2 = false;
                }
                else
                {
                    return;
                }
            }       
           else   if (foco == 3)
            {
                if (s3 == true)
                {
                    txt_buscar_cliente.Text = txt_buscar_cliente.Text + ".";
                    s3 = false;
                }
                else
                {
                    return;
                }
            }      
        }
        private void btn_borrar_todo_Click(object sender, EventArgs e)
        {
            if(foco == 1)
            {
                txt_efectivo.Clear();
                s1 = true;
            }
           else if (foco == 2)
            {
                txt_tarjeta.Clear();
                s2 = true;
            }
          else  if (foco == 3)
            {
                txt_credito.Clear();
                s3 = true;
            }
        }
        private void buscar_cliente()
        {

            try
            {

            
              conexion.ConexionMaestra.abrir_conexion();
            DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("buscar_cliente_por_nombre_para_ventas",conexion.ConexionMaestra.conectar); ;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", txt_buscar_cliente.Text);
                da.Fill(dt);
                dgv_clientes.DataSource = dt;
                dgv_clientes.Columns[2].Visible = false;
            }
            catch (Exception ex) {  }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cliente_TextChanged(object sender, EventArgs e)
        {
            buscar_cliente();
            dgv_clientes.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel_clientes_credito()
        {
            try
            {
                double tcredito = 0;
                if (txt_credito.Text == ".") tcredito = 0;   
                if (txt_credito.Text == "0") tcredito = 0; else tcredito =Convert.ToDouble( txt_credito.Text);
                if (tcredito > 0) panel_credito.Visible = true;
                else { panel_credito.Visible = false; idcliente = 0; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
        }
        private void dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                 txt_buscar_cliente.Text = dgv_clientes.CurrentRow.Cells[1].Value.ToString();
                idcliente =Convert.ToInt32(dgv_clientes.CurrentRow.Cells[2].Value.ToString());
                dgv_clientes.Visible = false;
            
        }
        private void insertar_cliente()
        {
            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Favor de Ingresar un nombre, verifique la informacion", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = conexion.ConexionMaestra.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("insertar_cliente", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);

                    cmd.Parameters.AddWithValue("@cliente", "SI");
                    cmd.Parameters.AddWithValue("@proveedor", "NO");
                    cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
                    cmd.Parameters.AddWithValue("@Saldo", 0);

                    if (txt_direccion.Text != "") cmd.Parameters.AddWithValue("@direccion_para_factura", txt_direccion.Text);
                    else
                    {
                        cmd.Parameters.AddWithValue("@direccion_para_factura", "Ninguna");
                    }
                    if (txt_if.Text != "") cmd.Parameters.AddWithValue("@identificador_fiscal", txt_if.Text);
                    else
                    {
                        cmd.Parameters.AddWithValue("@identificador_fiscal", "Ninguno");
                    }
                    if (txt_tnumero.Text != "") cmd.Parameters.AddWithValue("@movil", txt_tnumero.Text);
                    else
                    {
                        cmd.Parameters.AddWithValue("@movil", "Ninguno");
                    }
                    cmd.ExecuteNonQuery();
                    con.Close();

                  


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void limpiar_cliente()
        {
            txt_nombre.Clear();
            txt_direccion.Clear();
            txt_if.Clear();
            txt_tnumero.Clear();
        }
        private void bnt_guardar_Click(object sender, EventArgs e)
        {
            insertar_cliente();
            panel_ingresar_cliente.Visible = false;
            panel_ingresar_cliente.Dock = DockStyle.None;
            panel_ingresar_cliente.BringToFront();
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            panel_ingresar_cliente.Visible = false;
            panel_ingresar_cliente.Dock = DockStyle.None;
            panel_ingresar_cliente.BringToFront();
            limpiar_cliente();
        }

        private void btn_agregar_cliente_Click(object sender, EventArgs e)
        {
            limpiar_cliente();
            panel_ingresar_cliente.Visible = true;
            panel_ingresar_cliente.Dock = DockStyle.Fill;
        }

        private void txt_efectivo_Click(object sender, EventArgs e)
        {
            calcular_restante();
            foco = 1;
            if(lbl_restante.Text == "0.00")
            {
                txt_efectivo.Text = "";
            }
            else
            {
                txt_efectivo.Text = lbl_restante.Text;
            }
        }

        private void txt_tarjeta_Click(object sender, EventArgs e)
        {
            calcular_restante();
            foco = 2;
            if (lbl_restante.Text == "0.00")
            {
                txt_tarjeta.Text = "";
            }
            else
            {
                txt_tarjeta.Text = lbl_restante.Text;
            }
        }

        private void txt_credito_Click(object sender, EventArgs e)
        {
            calcular_restante();
            foco = 3;
            if (lbl_restante.Text == "0.00")
            {
                txt_credito.Text = "";
            }
            else
            {
                txt_credito.Text = lbl_restante.Text;
                panel_clientes_credito();

            }
        }
 
        private void ms_guardar_ver_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void dgv_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void cambiar_impresora_ticket()
        {
            try
            {
                conexion.ConexionMaestra.abrir_conexion();
                SqlCommand cmd = new SqlCommand("cambiar_eleccion_impresora", conexion.ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcaja",presentacion.Menu_principal.menu_principal.idcaja);
                cmd.Parameters.AddWithValue("@impresora_para_ticket",cb_impresora.Text);
                cmd.ExecuteNonQuery();
                conexion.ConexionMaestra.cerrar_conexion();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        private void guardar_imprimir_Click(object sender, EventArgs e)
        {
           
        }

        private void cb_impresora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_imprimir_Click(object sender, EventArgs e)
        {
            if (restante == 0)
            {
                if (cb_impresora.Text != "Ninguna")
                {
                    cambiar_impresora_ticket();
                    indicador = "IMPRIMIR DIRECTO";
                    identificar_tipo_pago();
                    verificar_datos();

                }
                else
                {
                    MessageBox.Show("Selecciona una impresora para poder imprimir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("EL restante debe ser 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
