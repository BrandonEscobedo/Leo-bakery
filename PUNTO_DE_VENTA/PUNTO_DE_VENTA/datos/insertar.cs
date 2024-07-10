using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PUNTO_DE_VENTA.negocio;
using PUNTO_DE_VENTA.conexion;
using System.Windows;
using System.Data;
namespace PUNTO_DE_VENTA.datos
{
  public  class insertar
    {
        int idcaja;
        public bool insertar_creditos_pagar(ncreditos_pagar prm )
        {
           
            try
            {
                procedimientos_reutilizables.obtener_id_caja(ref idcaja);
                ConexionMaestra.abrir_conexion();
                SqlCommand cmd = new SqlCommand("insertar_creditos_pagar", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion",prm.descripcion);
                cmd.Parameters.AddWithValue("@fecha_registro",prm.fecha_registro);
                cmd.Parameters.AddWithValue("@fecha_vencimiento",prm.fecha_vencimiento  );
                cmd.Parameters.AddWithValue("@total",prm.total);
                cmd.Parameters.AddWithValue("@saldo",prm.saldo);
                cmd.Parameters.AddWithValue("@estado","PENDIENTE");
                cmd.Parameters.AddWithValue("@idcaja", idcaja);
                cmd.Parameters.AddWithValue("@idproveedor",prm.idproveedor);
                cmd.ExecuteNonQuery();
                return true;                   
            }
            catch (Exception)
            {
              
                return false;           
            }
            finally
            {
                conexion.ConexionMaestra.cerrar_conexion();
            }
          
        }
        public static void mostrar_ventas_para_grafico(ref DataTable dt)
        {
            try
            {
                ConexionMaestra.abrir_conexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_ventas_para_grafico", conexion.ConexionMaestra.conectar);
                da.Fill(dt);
                ConexionMaestra.cerrar_conexion();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void mostrar_ventas_para_grafico_parametros(ref DataTable dt, DateTime fi, DateTime ff)
        {
            try
            {
                ConexionMaestra.abrir_conexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_ventas_para_grafico_fechas", conexion.ConexionMaestra.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fi",fi);
                da.SelectCommand.Parameters.AddWithValue("@ff",ff);
                da.Fill(dt);
                ConexionMaestra.cerrar_conexion();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void total_ventas(ref  double monto)
        {
            try
            {
                ConexionMaestra.abrir_conexion();
                SqlCommand cmd = new SqlCommand("total_ventas", ConexionMaestra.conectar);
                monto = Convert.ToDouble(cmd.ExecuteScalar());
                ConexionMaestra.cerrar_conexion();

            }
            catch (Exception)
            {
                monto = 0;
               
              
            }
        }
        public static void total_ventas_parametros(ref double monto, DateTime fi, DateTime ff)
        {
            try
            {
                ConexionMaestra.abrir_conexion();
                SqlCommand cmd = new SqlCommand("total_ventas_fecha", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fi",fi);
                cmd.Parameters.AddWithValue("@ff",ff);
                monto = Convert.ToDouble(cmd.ExecuteScalar());
                ConexionMaestra.cerrar_conexion();

            }
            catch (Exception)
            {
                monto = 0;
            

            }
        }
        public static void total_ganancias_fecha(ref double monto, DateTime fi, DateTime ff)
        {
            try
            {
                ConexionMaestra.abrir_conexion();
                SqlCommand cmd = new SqlCommand("ganancias_fecha", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fi", fi);
                cmd.Parameters.AddWithValue("@ff", ff);
                monto = Convert.ToDouble(cmd.ExecuteScalar());
                ConexionMaestra.cerrar_conexion();

            }
            catch (Exception)
            {
                monto = 0;


            }
        }
        public static void productos_mas_vendidos(ref DataTable dt)
        {
            try
            {
                ConexionMaestra.abrir_conexion();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_productos_mas_vendidos", conexion.ConexionMaestra.conectar);
                da.Fill(dt);
                ConexionMaestra.cerrar_conexion();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void productos_stock_bajos(ref DataTable dt)
        {

            try
            {
          ConexionMaestra.abrir_conexion();
                    SqlDataAdapter da = new SqlDataAdapter("productos_bajos_stock", ConexionMaestra.conectar);
                    da.Fill(dt);
                    ConexionMaestra.cerrar_conexion();
            }
            catch (Exception ex)
            {
               
            }
          
        }
        public bool precio_mayoreo(ndv prm)
        {
            try
            {
                conexion.ConexionMaestra.abrir_conexion();
                SqlCommand cmd = new SqlCommand("aplicar_precio_mayoreo",ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idproducto",prm.id_producto);
                cmd.Parameters.AddWithValue("@iddetallev", prm.id_detalle_venta);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
             

            }
            finally
            {
                ConexionMaestra.cerrar_conexion();        
            }
        }
        public bool editar_precios_productos(npruductos prm)
        {
            try
            {
                conexion.ConexionMaestra.abrir_conexion();
                SqlCommand cmd = new SqlCommand("editar_precios_productos", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idproductos", prm.idproducto);
                cmd.Parameters.AddWithValue("@precioventa", prm.precio_v);
                cmd.Parameters.AddWithValue("@costo", prm.precio_c);
                cmd.Parameters.AddWithValue("@preciomayoreo", prm.precio_m);
                cmd.Parameters.AddWithValue("@cantidad_a", prm.stock);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;


            }
            finally
            {
                ConexionMaestra.cerrar_conexion();
            }
        }
    }
}
