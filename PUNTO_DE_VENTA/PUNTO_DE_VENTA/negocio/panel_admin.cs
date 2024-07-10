using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PUNTO_DE_VENTA.conexion;
using System.Data.SqlClient;
using System.Globalization;

namespace PUNTO_DE_VENTA.negocio
{

    public struct por_fecha
    {
        public string date { get; set; }
        public decimal total { get; set; }

    }
    public class panel_admin
    {
        private DateTime fecha_inicio;
        private DateTime fecha_final;
        private int numero_dias;
        public int num_productos { get; private set; }
        public List<KeyValuePair<String, int>> num_productos_ms_vendidos { get; private set; }
        public List<KeyValuePair<String, int>> num_productos_bajos { get; private set; }
        public List<por_fecha> ingresos_brutos { get; private set; }
        public int num_ventas { get; set; }
        public decimal ganancias { get; set; }
        public decimal total_ingresos { get; set; }
        public panel_admin()
        {

        }
        private void num_total()
        {
          ConexionMaestra.abrir_conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion.ConexionMaestra.conectar;
            cmd.CommandText = "select count(id_producto) from productos";
            num_productos=(int) cmd.ExecuteScalar();
            cmd.CommandText = @"select count (idventa) from ventas  where Estado='CONFIRMADO' and fecha_venta between @desde_fecha and @hasta_fecha";
            cmd.Parameters.Add("@fecha_venta", System.Data.SqlDbType.DateTime).Value = fecha_inicio;
            cmd.Parameters.Add("@hasta_fecha", System.Data.SqlDbType.DateTime).Value = fecha_final;         
            num_ventas = (int)cmd.ExecuteScalar();
            conexion.ConexionMaestra.cerrar_conexion();

        }
        private void ingresos_ventas()
        {
            ingresos_brutos = new List<por_fecha>();
            ganancias = 0;
            total_ingresos = 0;

            ConexionMaestra.abrir_conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion.ConexionMaestra.conectar;
            cmd.CommandText = @" select fecha_venta, sum(efectivo) from ventas where Estado='CONFIRMADO'
                                and fecha_venta between @desde_fecha and @hasta_fecha group by fecha_venta";
            cmd.Parameters.Add("@fecha_venta", System.Data.SqlDbType.DateTime).Value = fecha_inicio;
            cmd.Parameters.Add("@hasta_fecha", System.Data.SqlDbType.DateTime).Value = fecha_final;
            var reader = cmd.ExecuteReader();
            var resultado = new List<KeyValuePair<DateTime, decimal>>();
            while (reader.Read())
            {
                resultado.Add(new KeyValuePair<DateTime,decimal>((DateTime)reader[0],(decimal)reader[1]));
            }
            total_ingresos += (decimal)reader[0];
            ganancias = total_ingresos;
            reader.Close();
            if (numero_dias <= 30)
            {
                foreach(var item in resultado)
                {
                    ingresos_brutos.Add(new por_fecha()
                    {
                        date = item.Key.ToString("dd MMM"),
                       total =item.Value
                    }) ;
                }
            }
            else if (numero_dias<= 92)
            {
                ingresos_brutos = (from orderlist in resultado
                                   group orderlist by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(orderlist.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                   into ventas
                                   select new por_fecha
                                   {
                                       date = "semanas" + ventas.Key.ToString(),
                                       total = ventas.Sum(amount=> amount.Value)

                                   }).ToList();
            }
            else if (numero_dias <= (362*2))
            {
                ingresos_brutos = (from orderlist in resultado
                                   group orderlist by orderlist.Key.ToString("MMM yyyy")
                                   into ventas
                                   select new por_fecha
                                   {
                                       date =  ventas.Key,
                                       total = ventas.Sum(amount => amount.Value)

                                   }).ToList();
            }

        } 
    }
}
