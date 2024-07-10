using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA.conexion
{
    internal class autocompletar
    {


        public static DataTable loadDataTable()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion.ConexionMaestra.conexion;
            con.Open();
            da = new SqlDataAdapter("select TOP 100 descripcion from productos", con);
            da.Fill(dt);
            return dt;

        }
        public static AutoCompleteStringCollection LoadAutoComplete()
        {
            DataTable dt = loadDataTable();
            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows) 
            {
                stringCol.Add(Convert.ToString(row["descripcion"]));

            }
            return stringCol;

        }
    }

}
