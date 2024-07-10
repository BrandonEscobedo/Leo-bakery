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

namespace PUNTO_DE_VENTA.modulos.caja
{
    public partial class cierre_de_caja : Form
    {
        public cierre_de_caja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("CERRAR_CAJA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcaja", lbl_id_caja.Text);
                cmd.Parameters.AddWithValue("@fechafin", dtpfecha.Value);
                cmd.Parameters.AddWithValue("@fechacierre", dtpfecha.Value);
                cmd.ExecuteNonQuery();
                con.Close();
                Application.Exit();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void mostrar_caja_por_sereal()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("mostrar_cajas_por_serial_de_discoDuro", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@serial", lblserialcaja.Text);
                da.Fill(dt);
                dgv1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cierre_de_caja_Load(object sender, EventArgs e)
        {
            try
            {
                string HDD = System.Environment.CurrentDirectory.Substring(0, 1);
                ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + HDD + ":\"");
                disk.Get();
                lblserialcaja.Text = disk["VolumeSerialNumber"].ToString();
                mostrar_caja_por_sereal();
                try
                {
                    
                        lbl_id_caja.Text = dgv1.SelectedCells[1].Value.ToString();
                        lblserialcaja.Text = dgv1.SelectedCells[2].Value.ToString();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
