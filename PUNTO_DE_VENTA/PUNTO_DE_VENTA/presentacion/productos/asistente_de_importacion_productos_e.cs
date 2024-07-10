using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;
using System.IO;
using System.Data.SqlClient;
namespace PUNTO_DE_VENTA.presentacion.productos
{
    public partial class asistente_de_importacion_productos_e : Form
    {
        public asistente_de_importacion_productos_e()
        {
            InitializeComponent();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flp_principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_descargar_archivo_Paint(object sender, PaintEventArgs e)
        {

        }
      
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                String ruta_archivo;


                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    ruta_archivo =fbd.SelectedPath + "productosExcel.xlsx";
                    SLDocument nombre_archivo_excel = new SLDocument();
                    System.Data.DataTable dt =  new System.Data.DataTable();
                    dt.Columns.Add("Descripcion", typeof(string));
                    dt.Columns.Add("Codigo", typeof(string));
                    nombre_archivo_excel.ImportDataTable(1,1,dt, true);
                    nombre_archivo_excel.SaveAs(ruta_archivo);
                    MessageBox.Show("Plantailla guardada correctamente en: " + ruta_archivo, "Archivo generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.Message);
            }
        }

        private void siguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_eleguir.Visible = false;
            panel_cargar.Visible = true;
            panel_cargar_archivo.Visible = true;


        }

        private void asistente_de_importacion_productos_e_Load(object sender, EventArgs e)
        {
            panel_cargar.Visible = false;
            btn_guardar.Enabled = false;
            panel_guardar.Visible = false;
        }
        String ruta;

        private void link_seleccionar_archivo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"c:\\temp\";
            ofd.Filter = "CSV files |*.csv;*.CSV)";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            ofd.Title = "Elija el archivo .CSV";
            if (ofd.ShowDialog()== DialogResult.OK)
            {
                link_seleccionar_archivo.Text = ofd.SafeFileName.ToString();
              ruta = ofd.FileName.ToString();
                archivo_correcto();
                Console.WriteLine(ruta);
            }
        }
        private void archivo_correcto()
        {
            lbl_archivo_cargado.Visible = true;
            label3.Visible = false;
            ms_siguiente2.Visible = true;
            pb_csv.Visible = true; 
            
        }

        private void panel_arrastra_archivo_DragEnter(object sender, DragEventArgs e)
        {
           
        }

        private void panel_arrastra_archivo_DragDrop(object sender, DragEventArgs e)
        {
        
        }

        private void panel_iniciar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_DragEnter(object sender, DragEventArgs e)
        {
           
        }

        private void panel7_DragDrop(object sender, DragEventArgs e)
        {
          
        }

        private void panel_cargar_archivo_DragDrop(object sender, DragEventArgs e)
        {
          
        }

        private void panel_cargar_archivo_DragEnter(object sender, DragEventArgs e)
        {
        }

        private void panel_descargar_archivo_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void panel_descargar_archivo_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void rellenar_registros_vacios_excel()

        {
            try
            {

            foreach (DataGridViewRow row in dgv_productos.Rows)
            {
                if (row.Cells["Descripcion"].Value.ToString() == "")
                {
                    row.Cells["Descripcion"].Value = "Vacio";

                }
                 if (row.Cells["Codigo"].Value.ToString() == "")
                {
                    row.Cells["Codigo"].Value = "Vacio";
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.Message);
            }
        }
        private void guardar_productos()
        {
            String lineas = "";
            String[] Splitline;
           
            if (File.Exists(ruta) == true)
            {
                StreamReader sr = new StreamReader(ruta);
                while (sr.Peek() != -1)
                {
                    lineas = sr.ReadLine();
                    Splitline = lineas.Split(',');
                    dgv_productos.ColumnCount = Splitline.Length;
                    dgv_productos.Rows.Add(Splitline);
                }
                MessageBox.Show("Importacion exitosa", "Importacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("La importacion a fallado, favor de intentar de nuevo", "Importacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            try
            {
                foreach (DataGridViewRow row in dgv_productos.Rows)
                {
                    rellenar_registros_vacios_excel();
                    String codigo = Convert.ToString(row.Cells["Codigo"].Value);
                    String descripcion = Convert.ToString(row.Cells["Descripcion"].Value);
                    SqlCommand cmd = new SqlCommand();
                    conexion.ConexionMaestra.conectar.Open();
                    cmd = new SqlCommand("insertar_producto_por_importacion", conexion.ConexionMaestra.conectar);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@Imagen", ".");
                    cmd.Parameters.AddWithValue("@Usar_inventario", "Si");
                    cmd.Parameters.AddWithValue("@Stock", 0);
                    cmd.Parameters.AddWithValue("@Precio_de_compra", 0);
                    cmd.Parameters.AddWithValue("@Fecha_de_vencimiento", "NO APLICA");
                    cmd.Parameters.AddWithValue("@Precio_de_venta", 0);
                    cmd.Parameters.AddWithValue("@Codigo", codigo);

                    cmd.Parameters.AddWithValue("@Tipo_venta", "unidad");
                    cmd.Parameters.AddWithValue("@Impuesto", 0);
                    cmd.Parameters.AddWithValue("@Stock_minimo", 0);
                    cmd.Parameters.AddWithValue("@Precio_mayoreo", 0);
                    cmd.Parameters.AddWithValue("@A_partir_de_pm", 0);
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Today);
                    cmd.Parameters.AddWithValue("@motivo", "Registro inicial de Producto");
                    cmd.Parameters.AddWithValue("@cantidad", 0);
                    cmd.Parameters.AddWithValue("@tipo", "ENTRADA");
                    cmd.Parameters.AddWithValue("@Estado", "CONFIRMADO");
                    cmd.Parameters.AddWithValue("@id_caja", presentacion.productos.productos.id_caja);
                    cmd.Parameters.AddWithValue("@id_usuario", presentacion.productos.productos.id_usuario);
                    cmd.ExecuteNonQuery();
                    conexion.ConexionMaestra.conectar.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.Message);
            }
        }
        private void ms_siguiente2_Click(object sender, EventArgs e)
        {
            panel_iniciar.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            guardar_productos();
        }
    }
}
