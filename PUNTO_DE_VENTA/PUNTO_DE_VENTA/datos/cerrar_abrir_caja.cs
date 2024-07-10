using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace PUNTO_DE_VENTA.datos
{
    class cerrar_abrir_caja
    {
        private static int idcaja;
        public static bool iniciar_caja(ref int id_caja, double saldo)
        {
            try
            {
             conexion.ConexionMaestra.abrir_conexion();
           SqlCommand cmd = new SqlCommand("editar_dinero_caja_inicial", conexion.ConexionMaestra.conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_caja", id_caja);
            cmd.Parameters.AddWithValue("@saldo", saldo);
            cmd.ExecuteNonQuery();
            conexion.ConexionMaestra.cerrar_conexion();
            return true;
            }
            catch (Exception ex)
            {
                return false;
                MessageBox.Show("Error al aperturar la caja","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          
        }
        public static void mostrar_cierre_de_caja_pendiente(ref DataTable dt)
        {
            datos.procedimientos_reutilizables.obtener_id_caja(ref idcaja);

            try
            {
                conexion.ConexionMaestra.abrir_conexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_cierre_de_caja_pendiente", conexion .ConexionMaestra.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idcaja", idcaja);
                da.Fill(dt);
                conexion.ConexionMaestra.cerrar_conexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
           }
        }
        public bool cerrar_caja(negocio.cerrar_turno prm)        
        {        
          try
            {
             conexion.ConexionMaestra.abrir_conexion();
            SqlCommand cmd = new SqlCommand("cerrar_caja", conexion.ConexionMaestra.conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fechafin",prm.fecha_fin);
            cmd.Parameters.AddWithValue("@fechacierre",prm.fecha_cierre);
            cmd.Parameters.AddWithValue("@ingesos",prm.ingresos);
            cmd.Parameters.AddWithValue("@egresos",prm.egresos);
            cmd.Parameters.AddWithValue("@saldo_en_caja",prm.saldo_en_caja);
            cmd.Parameters.AddWithValue("@id_usuario",prm.id_usuario);
            cmd.Parameters.AddWithValue("@total_calculado",prm.total_calculado);
            cmd.Parameters.AddWithValue("@total_real",prm.total_real);
            cmd.Parameters.AddWithValue("@Estado",prm.estado);
            cmd.Parameters.AddWithValue("@diferencia",prm.diferencia);
            cmd.Parameters.AddWithValue("@idcaja", prm.idcaja);
                cmd.ExecuteNonQuery();
            conexion.ConexionMaestra.cerrar_conexion();
            return true;
            }
            catch (Exception)
            {
                conexion.ConexionMaestra.cerrar_conexion();
                return false;
                MessageBox.Show("Error al cerrar caja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
