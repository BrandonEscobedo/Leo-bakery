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
using System.IO;
using System.Text.RegularExpressions;
using System.Management;

namespace PUNTO_DE_VENTA.presentacion.asistente_de_instalacion_servidor
{
    public partial class registro_de_empresa : Form
    {
        public registro_de_empresa()
        {
            InitializeComponent();
        }
        String serialpc;
        private void insertar_empresa()
        {
            try
            {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion.ConexionMaestra.conexion;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("insertar_empresa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_empresa", txtnombre_empresa.Text);
          
            cmd.Parameters.AddWithValue("@impuesto", cbimpuestos.Text);
            cmd.Parameters.AddWithValue("@porcentaje_impuesto",cmporcentaje_impuesto.Text);
            cmd.Parameters.AddWithValue("@moneda", txtmoneda.Text);
            cmd.Parameters.AddWithValue("@trabajas_con_impuestos", lbltrabajas_conimpuestos.Text);

          
            cmd.Parameters.AddWithValue("@carpeta_para_copia_seguridad", txtcarpeta_copia.Text);
            cmd.Parameters.AddWithValue("@correo_para_enviar_reportes",txtcorreo.Text);
            cmd.Parameters.AddWithValue("@ultima_copia_seguridad","Ninguna");
            cmd.Parameters.AddWithValue("@ultima_copia_date",dtpfecha.Value);
            cmd.Parameters.AddWithValue("@frecuencia_copias", 1);
            cmd.Parameters.AddWithValue("@Estado", "PENDIENTE");
            cmd.Parameters.AddWithValue("@tipo_de_empresa", "GENERAL");
                cmd.Parameters.AddWithValue ("@telefono",txt_telefono.Text);


                if (cblector.Checked == true)
                {

                    cmd.Parameters.AddWithValue("@modo_de_busqueda", "LECTOR");

                }
                if (cbteclado.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@modo_de_busqueda", "TECLADO");
                }

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pb_logo.Image.Save(ms, pb_logo.Image.RawFormat);

                cmd.Parameters.AddWithValue("@logo", ms.GetBuffer());
                cmd.Parameters.AddWithValue("@pais", txtpais.Text);
                cmd.Parameters.AddWithValue("@redondeo_de_total ","NO");
                cmd.ExecuteNonQuery();
            con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static string correo_var;

        private void button1_Click(object sender, EventArgs e)
        {
            if (validar_correo(txtcorreo.Text) == false)

            {
                MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener un formato valido " + "favor de ingresar un correo valido", "Validación de correo", MessageBoxButtons.OK);
                txtcorreo.Focus();
                txtcorreo.SelectAll();

            }
            else
            {
           if (txtnombre_empresa.Text != "")
                {
                    if (txtcarpeta_copia.Text !="")
                    { 
            if (rb_impuestos_no.Checked == true)
            {
                lbltrabajas_conimpuestos.Text = "NO";

            }
            if (rb_impuestos_si.Checked == true)
            {
                lbltrabajas_conimpuestos.Text = "SI";
               
                    }
                        insertar_empresa(); 
                        insertar_caja();
                        insertar_3_comprobantes();
                        correo_var = txtcorreo.Text;
                        Hide();
                     
                        presentacion.asistente_de_instalacion_servidor.registro_usuario_autorizados frm = new presentacion.asistente_de_instalacion_servidor.registro_usuario_autorizados();
                        frm.ShowDialog();
                        this.Dispose();
                }
                    else
                    {
                        MessageBox.Show("Asegurese de llenar todos los campos antes de continuar", "Error al llenar los campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                    }
                }
               
                else
                {
                    MessageBox.Show("Asegurese de llenar todos los campos antes de continuar", "Error al llenar los campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
           
            }
        }

        private void insertar_caja()
        {
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_caja", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", txtnombre_caja.Text);

                cmd.Parameters.AddWithValue("@tema", "blanco");
                cmd.Parameters.AddWithValue("@serial_pc",  serialpc);
                cmd.Parameters.AddWithValue("@impresora_ticket", "Ninguna");
                cmd.Parameters.AddWithValue("@impresora_a4", "Ninguna");
                cmd.Parameters.AddWithValue("@tipo", "PRINCIPAL");   
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void insertar_3_comprobantes()
        {
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_serializacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@serie","T");

                cmd.Parameters.AddWithValue("@numeroinicio",6);
                cmd.Parameters.AddWithValue("@numerofin", 0);
                cmd.Parameters.AddWithValue("@destino", "VENTAS");
                cmd.Parameters.AddWithValue("@tipo_doc", "TICKET");
                cmd.Parameters.AddWithValue("@por_defecto", "SI");
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                cmd = new SqlCommand("insertar_serializacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@serie", "B");

                cmd.Parameters.AddWithValue("@numeroinicio", 6);
                cmd.Parameters.AddWithValue("@numerofin", 0);
                cmd.Parameters.AddWithValue("@destino", "VENTAS");
                cmd.Parameters.AddWithValue("@tipo_doc", "BOLETA");
                cmd.Parameters.AddWithValue("@por_defecto", "-");
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();

                cmd = new SqlCommand("insertar_serializacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@serie", "F");

                cmd.Parameters.AddWithValue("@numeroinicio", 6);
                cmd.Parameters.AddWithValue("@numerofin", 0);
                cmd.Parameters.AddWithValue("@destino", "VENTAS");
                cmd.Parameters.AddWithValue("@tipo_doc", "FACTURA");
                cmd.Parameters.AddWithValue("@por_defecto", "-");
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();

                cmd = new SqlCommand("insertar_serializacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@serie", "I");

                cmd.Parameters.AddWithValue("@numeroinicio", 6);
                cmd.Parameters.AddWithValue("@numerofin", 0);
                cmd.Parameters.AddWithValue("@destino", "INGRESO DE COBROS");
                cmd.Parameters.AddWithValue("@tipo_doc", "INGRESO");
                cmd.Parameters.AddWithValue("@por_defecto", "-");
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();

                cmd = new SqlCommand("insertar_serializacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@serie", "E");

                cmd.Parameters.AddWithValue("@numeroinicio", 6);
                cmd.Parameters.AddWithValue("@numerofin", 0);
                cmd.Parameters.AddWithValue("@destino", "EGRESO DE PAGOS");
                cmd.Parameters.AddWithValue("@tipo_doc", "EGRESO");
                cmd.Parameters.AddWithValue("@por_defecto", "-");
                cmd.ExecuteNonQuery();
                con.Close();
                con.Open();

                cmd = new SqlCommand("insertar_formato_ticket", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@identificador_fiscal", "RFC");

                cmd.Parameters.AddWithValue("@direccion","calle nmo,avenida");
                cmd.Parameters.AddWithValue("@provincia_departamento", "privincia-dep-pais");
                cmd.Parameters.AddWithValue("@nombre_de_moneda", "pesos mxm");
                cmd.Parameters.AddWithValue("@agradecimiento", "gracias_agradecimiento");
                cmd.Parameters.AddWithValue("@paginas_internet ", "paginas web o facebook");
                cmd.Parameters.AddWithValue("@anuncio", "anuncio aqui");
                cmd.Parameters.AddWithValue("@datos_fiscales", "datos fiscales-numero de aut..");
                cmd.Parameters.AddWithValue("@por_defecto","Ticket no Fiscal");
        
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void registro_de_empresa_Load(object sender, EventArgs e)
        {
            negocio.procedimientos_necesarios.obtener_serial(ref serialpc);
            cblector.Checked = true;
            cbteclado.Checked = false;
            rb_impuestos_no.Checked = true;
            panel_impuestos.Visible = false;

        }

        private void cblector_CheckedChanged(object sender, EventArgs e)
        {
            if (cblector.Checked == true)
            {

                cbteclado.Checked = false;

            }
            if (cblector.Checked == false)
            {
                cbteclado.Checked = true;
            }
        }

        private void cbteclado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbteclado.Checked == true)
            {

                cblector.Checked = false;

            }
            if (cbteclado.Checked == false)
            {
                cblector.Checked = true;
            }
        }

        private void txtpais_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmoneda.SelectedIndex = txtpais.SelectedIndex;
        }

        private void txtmoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pb_logo_Click(object sender, EventArgs e)
        {

            ofd.InitialDirectory = "";
            ofd.Filter = "Imagenes |*.jpg;*.png";
            ofd.FilterIndex = 2;
            ofd.Title = "cargador de imagenes";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pb_logo.BackgroundImage = null;
                pb_logo.Image = new Bitmap(ofd.FileName);
                pb_logo.Text = Path.GetFileName(ofd.FileName);
                pb_logo.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }
        public bool validar_correo(string sMail)
        {
            return Regex.IsMatch(sMail, @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$");
        }
        private void txtcarpeta_copia_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (fbd_carpetaseguridad.ShowDialog() == DialogResult.OK)
            {
                txtcarpeta_copia.Text = fbd_carpetaseguridad.SelectedPath;
                string ruta = txtcarpeta_copia.Text;
               
            }
        }

        private void rb_impuestos_si_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_impuestos_si.Checked == true)
            {
                panel_impuestos.Visible = true;
            }
        }

        private void rb_impuestos_no_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_impuestos_no.Checked == true)
            {
                panel_impuestos.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
