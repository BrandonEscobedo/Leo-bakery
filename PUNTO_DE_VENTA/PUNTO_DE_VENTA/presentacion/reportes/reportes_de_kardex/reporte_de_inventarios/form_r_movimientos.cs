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
using Microsoft.Reporting.WinForms;
namespace PUNTO_DE_VENTA.presentacion.reportes.reportes_de_kardex.reporte_de_inventarios
{
    public partial class form_r_movimientos : Form
    {
        public form_r_movimientos()
        {
            InitializeComponent();
        }
        private void mostrar_kardex_inventario()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                SqlDataAdapter da = new SqlDataAdapter("mostrar_movimientos_de_kardex_modulo_kardex", con);
                DataTable dt = new DataTable();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idproducto", presentacion.inventario_kardex.inventario_menu.id_producto_reporte);
                

                da.Fill(dt);
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rp = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Add(rp);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            reportViewer1.Refresh();
        }
        private void form_r_movimientos_Load(object sender, EventArgs e)
        {
            mostrar_kardex_inventario();
            this.reportViewer1.RefreshReport();
        }
    }
}
