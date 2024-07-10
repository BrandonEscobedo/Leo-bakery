using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUNTO_DE_VENTA.conexion;
namespace PUNTO_DE_VENTA.presentacion.inventario_kardex
{
    public partial class inv_entrada : Form
    {
        public inv_entrada()
        {
            InitializeComponent();
        }
        int idproducto;
        double stock;
        double precio_v;
        double precio_c;
        double precio_m;
     


        private void inv_entrada_Load(object sender, EventArgs e)
        {
           
        }
        public void editar_precios_productos()
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_agregar.Text))
                {
                conexion.ConexionMaestra.abrir_conexion();
                SqlCommand cmd = new SqlCommand("editar_precios_productos", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idproductos",idproducto);
                cmd.Parameters.AddWithValue("@precioventa", txt_precio_v.Text);
                cmd.Parameters.AddWithValue("@costo", txt_costo.Text);
                cmd.Parameters.AddWithValue("@preciomayoreo",txt_mayoreo.Text);
                cmd.Parameters.AddWithValue("@cantidad_a", txt_agregar.Text);
                cmd.ExecuteNonQuery();
                    ConexionMaestra.cerrar_conexion();
                }
               
               
            }
            catch (Exception)
            {
              
            }
           
        }
    
      

        private void obtener_datos()
        {
            idproducto = Convert.ToInt32(dgv_productos.CurrentRow.Cells[1].Value.ToString());
            MessageBox.Show(idproducto.ToString());
            stock = Convert.ToDouble(dgv_productos.CurrentRow.Cells[6].Value.ToString());
            precio_v = Convert.ToDouble(dgv_productos.CurrentRow.Cells[9].Value.ToString());
            precio_c = Convert.ToDouble(dgv_productos.CurrentRow.Cells[8].Value.ToString());
            precio_m = Convert.ToDouble(dgv_productos.CurrentRow.Cells[15].Value.ToString());
            lbl_cantidad.Text = stock.ToString();
            txt_costo.Text = precio_c.ToString();
            txt_mayoreo.Text = precio_m.ToString();
            txt_precio_v.Text = precio_v.ToString();
        }
        private void buscar_productos_movimientos()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion.ConexionMaestra.conexion;
            con.Open();

            da = new SqlDataAdapter("buscar_productos_kardex", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@letra", txt_buscar.Text);
            da.Fill(dt);
            dgv_productos.DataSource = dt;
            con.Close();
            try
            {
                
                dgv_productos.Columns[1].Visible = false;
                dgv_productos.Columns[3].Visible = false;
                dgv_productos.Columns[4].Visible = false;
                dgv_productos.Columns[5].Visible = false;
                dgv_productos.Columns[6].Visible = false;
                dgv_productos.Columns[7].Visible = false;


            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            obtener_datos();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            buscar_productos_movimientos();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            editar_precios_productos();
            MessageBox.Show("Actualizado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Dispose();
        }
    }
}
