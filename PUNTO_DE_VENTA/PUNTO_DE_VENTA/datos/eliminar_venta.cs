using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using PUNTO_DE_VENTA.conexion;
namespace PUNTO_DE_VENTA.datos
{
    class eliminar_venta
    {
       
        public static void eliminar_venta_espera(int idventa)
        {
            try
            {
               ConexionMaestra.abrir_conexion();
               SqlCommand cmd = new SqlCommand("eliminar_venta",conexion.ConexionMaestra.conectar);
               cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idventa",idventa);
                cmd.ExecuteNonQuery();
                ConexionMaestra.cerrar_conexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
         
        }
    }
}
