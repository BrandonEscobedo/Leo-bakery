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
namespace PUNTO_DE_VENTA.presentacion.asistente_de_instalacion_servidor
{
    public partial class e_servidor_remoto : Form
    {
        string estado_conexion;
        public e_servidor_remoto()
        {
            InitializeComponent();
        }
        private void listar()
        {
            try
            {

            
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion.ConexionMaestra.conexion;
            con.Open();
            da = new SqlDataAdapter("Select * from usuarios", con);
            da.Fill(dt);
            dgv_usuarios_registrados.DataSource = dt;
            con.Close();
            estado_conexion = "conectado";
            }
            catch (Exception ex)
            {
                estado_conexion = "-";
               
            }
        }
        private void e_servidor_remoto_Load(object sender, EventArgs e)
        {
            panel_todo.Location = new Point((Width - panel_todo.Width) / 2,(Height - panel_todo.Height)/2);
            listar();
            if (estado_conexion == "conectado")
            {
                Dispose();
                presentacion.asistente_de_instalacion_servidor.registro_de_empresa frm = new presentacion.asistente_de_instalacion_servidor.registro_de_empresa();
                frm.ShowDialog();
            }
        }

        private void btn_principal_Click(object sender, EventArgs e)
        {
            Dispose();
            presentacion.asistente_de_instalacion_servidor.instalacion_de_servidor_sql frm = new presentacion.asistente_de_instalacion_servidor.instalacion_de_servidor_sql();
            frm.ShowDialog();
        }
         
        private void btn_secundaria_Click(object sender, EventArgs e)
        {
            Dispose();
            remota.conexion frm = new remota.conexion();
            frm.ShowDialog();
        }
    }
}
