using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using PUNTO_DE_VENTA.negocio;
using System.Security.Cryptography;

namespace PUNTO_DE_VENTA.datos
{
    class procedimientos_reutilizables
    {
        private static String serialpc;
        public static void obtener_id_caja(ref int id_caja)
        {
            negocio.procedimientos_necesarios.obtener_serial(ref serialpc);
            try         
            {
                conexion.ConexionMaestra.abrir_conexion();
                SqlCommand cmd = new SqlCommand("mostrar_cajas_por_serial_de_discoDuro", conexion.ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@serial", serialpc);
                id_caja = Convert.ToInt32(cmd.ExecuteScalar());
                conexion.ConexionMaestra.cerrar_conexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la operacion","ERROR",MessageBoxButton.OK);
            }
        }

        public static void mostrar_inicio_sesion(ref int idusuario)
        {
            negocio.procedimientos_necesarios.obtener_serial(ref serialpc);
            try
            {

                conexion.ConexionMaestra.abrir_conexion();
                SqlCommand cmd = new SqlCommand("mostrar_inicio_sesion", conexion.ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_serial_pc", serialpc);
                idusuario = Convert.ToInt32(cmd.ExecuteScalar());
                conexion.ConexionMaestra.cerrar_conexion();
            }
            catch (Exception)
            {
                conexion.ConexionMaestra.cerrar_conexion();
                MessageBox.Show("Error al realizar la operacion", "ERROR", MessageBoxButton.OK);
            }
        }
        public static void mostrar_ventas_efectivo_turno(int idcaja,DateTime fecha_inicial,DateTime fecha_final, ref double monto_efectivo)
        {
            try
            {
                    conexion.ConexionMaestra.abrir_conexion();
                    SqlCommand da = new SqlCommand("mostrar_ventas_efectivo_turno", conexion.ConexionMaestra.conectar);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.AddWithValue("@idcaja", idcaja);
                    da.Parameters.AddWithValue("@fecha_inicial", fecha_inicial);
                    da.Parameters.AddWithValue("@fecha_final", fecha_final);
                    monto_efectivo =Convert.ToDouble( da.ExecuteScalar());
                    conexion.ConexionMaestra.cerrar_conexion();
            }
            catch (Exception)
            {
                monto_efectivo = 0;
                conexion.ConexionMaestra.cerrar_conexion();
            }        
       }

        public static void mostrar_ventas_tarjeta_turno(int idcaja, DateTime fecha_inicial, DateTime fecha_final, ref double monto_tarjeta)
        {
            try
            {
                conexion.ConexionMaestra.abrir_conexion();
                SqlCommand da = new SqlCommand("mostrar_ventas_tarjeta", conexion.ConexionMaestra.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@idcaja", idcaja);
                da.Parameters.AddWithValue("@fecha_inicial", fecha_inicial);
                da.Parameters.AddWithValue("@fecha_final", fecha_final);
                monto_tarjeta = Convert.ToDouble(da.ExecuteScalar());
                conexion.ConexionMaestra.cerrar_conexion();
            }
            catch (Exception ex)
            {
                monto_tarjeta = 0;
              
                conexion.ConexionMaestra.cerrar_conexion();
            }
        }
        public static void mostrar_ventas_credito_turno(int idcaja, DateTime fecha_inicial, DateTime fecha_final, ref double monto_credito)
        {
            try
            {

                conexion.ConexionMaestra.abrir_conexion();
                SqlCommand da = new SqlCommand("mostrar_ventas_credito", conexion.ConexionMaestra.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@idcaja", idcaja);
                da.Parameters.AddWithValue("@fecha_inicial", fecha_inicial);
                da.Parameters.AddWithValue("@fecha_final", fecha_final);
                monto_credito = Convert.ToDouble(da.ExecuteScalar());
                conexion.ConexionMaestra.cerrar_conexion();
            }
            catch (Exception)
            {
                monto_credito = 0;
                conexion.ConexionMaestra.cerrar_conexion();
            }
        }
    }
}
