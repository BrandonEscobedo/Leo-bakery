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
    public partial class form_reporte_movimientos_filtros : Form
    {
        public form_reporte_movimientos_filtros()
        {
            InitializeComponent();
        }
        private void mostrar_kardex_inventario()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                SqlDataAdapter da = new SqlDataAdapter("buscar_movimientos_filtros", con);
                DataTable dt = new DataTable();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fecha", presentacion.inventario_kardex.inventario_menu.fecha_reporte);
                da.SelectCommand.Parameters.AddWithValue("@tipo", presentacion.inventario_kardex.inventario_menu.tipo_movimiento_reporte);
                da.SelectCommand.Parameters.AddWithValue("@id_usuario", presentacion.inventario_kardex.inventario_menu.id_usuario_reporte);
                da.Fill(dt);
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rp = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Add(rp);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.Refresh();
            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            reportViewer1.Refresh();
        }
        private void form_reporte_movimientos_filtros_Load(object sender, EventArgs e)
        {
            mostrar_kardex_inventario();
            this.reportViewer1.RefreshReport();
        }
    }
}
