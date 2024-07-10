using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace PUNTO_DE_VENTA.negocio
{
    class procedimientos_necesarios
    {
      
        public static void obtener_serial(ref string serial_pc)
        {
           string HDD = System.Environment.CurrentDirectory.Substring(0, 1);
           ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + HDD + ":\"");
           disk.Get();
          serial_pc =conexion.encriptar_en_texto.Encriptar( disk["VolumeSerialNumber"].ToString());          
        }
        public static void cambiar_formato_puntos()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-CO");
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ",";
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ",";
        }
       public static void formato_dgv(ref DataGridView List)
        {
            List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            List.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            List.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle stycabeceras = new DataGridViewCellStyle();
            stycabeceras.BackColor = System.Drawing.Color.White;
            stycabeceras.ForeColor = System.Drawing.Color.Black;
            stycabeceras.Font = new Font("Segoe UI,",12, FontStyle.Bold);
            List.ColumnHeadersDefaultCellStyle = stycabeceras;

        }

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
        public static string ceros_comprobantes(string nmro, int cantidad)
        {
            string numero = null;
            string cantidad_ceros = null;
            int i = 0;
            numero = nmro.Trim(' ');
            cantidad_ceros = "0";
            for (i = 1; i <= cantidad; i++)
            {
                cantidad_ceros = cantidad_ceros + "0";
            }
            return cantidad_ceros.Substring(0, cantidad - numero.Length) + numero;
        }
        public static object evaluar_caracteres(TextBox CajaTexto, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {

                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

            }

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && (~CajaTexto.Text.IndexOf(".")) != 0)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',')
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;

            }
            return null;
        }

        public static string obtener_ip(ref string  ip_ob )
        {
            ip_ob = Dns.GetHostEntry(Environment.MachineName).AddressList.FirstOrDefault((i) => i.AddressFamily == System.Net.Sockets.AddressFamily
            .InterNetwork).ToString();
            return ip_ob;
        }
    }
}
