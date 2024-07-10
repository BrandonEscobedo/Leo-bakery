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
using PUNTO_DE_VENTA.datos;
using PUNTO_DE_VENTA.presentacion;
namespace PUNTO_DE_VENTA.presentacion.Menu_principal
{
    public partial class ventas_espera : Form
    {
        public ventas_espera()
        {
            InitializeComponent();
        }
        int idcaja;
        int id_venta;
        private void ventas_espera_Load(object sender, EventArgs e)
        {
            mostrar_ventas_espera();
            datos.procedimientos_reutilizables.obtener_id_caja(ref idcaja);

        }
        private void mostrar_ventas_espera()
        {
            try
            {
                DataTable dt = new DataTable();
                conexion.ConexionMaestra.abrir_conexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_venta_espera", conexion.ConexionMaestra.conectar);
                da.Fill(dt);
                dgv_ventas_espera.DataSource = dt;
                dgv_ventas_espera.Columns[4].Visible = false;
                dgv_ventas_espera.Columns[3].Visible = false;
              
                conexion.ConexionMaestra.cerrar_conexion();
                negocio.procedimientos_necesarios.formato_dgv(ref dgv_ventas_espera);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.Message);
            }
        }
        private void mostrar_productos_agregados_a_espera()
        {
            try
            {

            DataTable dt = new DataTable();
            conexion.ConexionMaestra.abrir_conexion();
            SqlDataAdapter da = new SqlDataAdapter("mostrar_productos_agregados_a_espera", conexion.ConexionMaestra.conectar);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@idventa",id_venta);
            da.Fill(dt);
            dgv_venta_seleccionada.DataSource = dt;
            conexion.ConexionMaestra.cerrar_conexion();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);         
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
        private  void mostrar_dv()
        {
            if (dgv_ventas_espera.RowCount > 0)
            {

            id_venta = Convert.ToInt32(dgv_ventas_espera.CurrentRow.Cells[3].Value.ToString());
            mostrar_productos_agregados_a_espera();
            }

        }
        private void dgv_ventas_espera_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrar_dv();
        }

        private void ms_eliminar_venta_Click(object sender, EventArgs e)
        {
            eliminar_venta.eliminar_venta_espera(id_venta);
            id_venta = 0;
            mostrar_ventas_espera();
            mostrar_dv();
        }

        private void ms_restaurar_Click(object sender, EventArgs e)
        {
            menu_principal.idventa = id_venta;
            ventas_espera_proc.cambiar_caja_v(idcaja, id_venta);
            Dispose();
        }
    }
}
