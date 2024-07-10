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
using PUNTO_DE_VENTA.negocio;
namespace PUNTO_DE_VENTA.presentacion.remota
{
    public partial class caja_remota : Form
    {
        public caja_remota()
        {
            InitializeComponent();
        }
        String serialpc;
        public static string Conection;
     private void caja_remota_Load(object sender, EventArgs e)
        {
            negocio.procedimientos_necesarios.obtener_serial(ref serialpc);
        }
        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnombre_caja.Text))
            {
              insertar_caja();
            }
          
        }
          private void insertar_caja()
        {
            try
            {

                SqlConnection con = new SqlConnection(Conection);
              
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
                insertar_inicio_sesion();
                MessageBox.Show("Caja Habilitada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Dispose();
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

                SqlConnection con = new SqlConnection(Conection);

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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
