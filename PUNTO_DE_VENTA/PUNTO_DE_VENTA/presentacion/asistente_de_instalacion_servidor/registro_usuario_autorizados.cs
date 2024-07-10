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
    public partial class registro_usuario_autorizados : Form
    {
        public registro_usuario_autorizados()
        {
            InitializeComponent();
        }
        String serial_pc;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registro_usuario_autorizados_Load(object sender, EventArgs e)
        {
            negocio.procedimientos_necesarios.obtener_serial(ref serial_pc);
        }
    
        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (txtcontra.Text !="" && txtusuario.Text!="" && txtnombre_cajero.Text!="")
            {
                string  contra_encrip;
                contra_encrip = conexion.encriptar_en_texto.Encriptar(this.txtcontra.Text.Trim());
                    try
                    {                       
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("insertar_usuario", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@nombres", txtnombre_cajero.Text);
                            cmd.Parameters.AddWithValue("@login", txtusuario.Text);
                            cmd.Parameters.AddWithValue("@password", contra_encrip);
                            cmd.Parameters.AddWithValue("@correo",presentacion.asistente_de_instalacion_servidor.registro_de_empresa.correo_var) ;
                            cmd.Parameters.AddWithValue("@Rol","Administrador");
                            cmd.Parameters.AddWithValue("@Estado", "Activo");
                            cmd.Parameters.AddWithValue("@nombre_de_icono", "NOMBREICONO");
                            System.IO.MemoryStream ms = new System.IO.MemoryStream();
                            pb_imagen.Image.Save(ms, pb_imagen.Image.RawFormat);
                            cmd.Parameters.AddWithValue("@icono", ms.GetBuffer());
                     
                        cmd.ExecuteNonQuery();
                        con.Close();
                 
                        insertar_cliente();
                        insertar_grupo();
                        insertar_inicio_sesion();
                        MessageBox.Show("!Listo! recuerda que para iniciar sesion tu usuario es: " 
                            + txtusuario.Text, "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Dispose();
                    login frm = new login();
                    frm.ShowDialog();

                        }
                    catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
     
        
        private void insertar_cliente()
        {
            try
            {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion.ConexionMaestra.conexion;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("insertar_cliente", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre","GENERICO");
            cmd.Parameters.AddWithValue("@direccion_para_factura",0);
            cmd.Parameters.AddWithValue("@identificador_fiscal", 0);
            cmd.Parameters.AddWithValue("@movil",0);
            cmd.Parameters.AddWithValue("@cliente ","NEUTRO");
           
            cmd.Parameters.AddWithValue("@Estado",0);
            cmd.Parameters.AddWithValue("@Saldo",0);
            cmd.ExecuteNonQuery();
            con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void insertar_grupo()
        {
            try
            {
                SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion.ConexionMaestra.conexion;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("insert_grupo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@grupo", "General");
            cmd.Parameters.AddWithValue("@por_defecto ", "Si");
            cmd.ExecuteNonQuery();
            con.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        private void insertar_inicio_sesion()
        {
            try
            {
            string serialpc;
            serialpc = serial_pc;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion.ConexionMaestra.conexion;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("insertar_inicio_sesion", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@serial_pc", serialpc);
           
            cmd.ExecuteNonQuery();
            con.Close();
}
            catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}        
}

        private void pb_imagen_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = "";
            ofd.Filter = "Imagenes |*.jpg;*.png";
            ofd.FilterIndex = 2;
            ofd.Title = "cargador de imagenes";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pb_imagen.BackgroundImage = null;
                pb_imagen.Image = new Bitmap(ofd.FileName);
                pb_imagen.Text = Path.GetFileName(ofd.FileName);
                pb_imagen.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }
    }
}
