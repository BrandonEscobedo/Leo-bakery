using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using PUNTO_DE_VENTA.conexion;
namespace PUNTO_DE_VENTA.datos
{
    class ventas_espera_proc
    {
        public static void cambiar_caja_v(int idcaja, int idventa)
        {
            try
            {
            ConexionMaestra.abrir_conexion();
            SqlCommand cmd = new SqlCommand("cambiar_caja", ConexionMaestra.conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcaja",idcaja);
            cmd.Parameters.AddWithValue("@idventa",idventa);
            cmd.ExecuteNonQuery();
            ConexionMaestra.cerrar_conexion();
            }
            catch (Exception)
            {

               
            }
           
        }
        public static void nombre_venta_espera(int idventa, string nombre)
        {
            try
            {
                ConexionMaestra.abrir_conexion();
            SqlCommand cmd = new SqlCommand("nombre_venta_espera", ConexionMaestra.conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@idventa", idventa);
            cmd.ExecuteNonQuery();
            ConexionMaestra.cerrar_conexion();
            }
            catch (Exception)
            {

               
            }
           
        }
    }   
}
