using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace PUNTO_DE_VENTA.conexion
{
   internal  class ConexionMaestra
    {
        public static string conexion = Convert.ToString(desencriptacion.checkserver());
        public static SqlConnection conectar = new SqlConnection(conexion);
        public static void abrir_conexion()
        {
            if(conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

        }
        public static void cerrar_conexion()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
