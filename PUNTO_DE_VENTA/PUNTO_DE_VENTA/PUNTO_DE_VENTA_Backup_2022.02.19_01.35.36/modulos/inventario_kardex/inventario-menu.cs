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
namespace PUNTO_DE_VENTA.modulos.inventario_kardex
{
    public partial class inventario_menu : Form
    {
        public inventario_menu()
        {
            InitializeComponent();
        }

        private void inventario_menu_Load(object sender, EventArgs e)
        {
            panel_inventario_bajo.Visible = false;
            panel_movimientos.Dock = DockStyle.None;
            panel_vencimiento.Dock = DockStyle.None;
            panel_inventario_bajo.Dock = DockStyle.None;
            panel_reportes_inventarios.Dock = DockStyle.None;
            panel_reportes_inventarios.Visible = false;
            panel_vencimiento.Visible = false;
            panel_reportes_inventarios.Visible = false;
            panel_movimientos.Visible = false;
            panel_kardex.Visible = true;
            panel_kardex.Dock = DockStyle.Fill;
            txtbuscar_kardex.Text = "Buscar Producto";
            gb_movimientos.Visible = false;

            gb_movimientos.Visible=false;
            buscar_usuario();
            txtbuscar_kardex.Text = "Buscar Producto";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_movimientos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void elLabel1_Click(object sender, EventArgs e)
        {

        }
        internal void sumar_costo_de_inventario_CONTAR_PRODUCTOS()
        {
            string resultado;
            string queryMoneda;
            queryMoneda = "SELECT moneda  FROM empresa";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion.ConexionMaestra.conexion;
            SqlCommand comMoneda = new SqlCommand(queryMoneda, con);
            try
            {
                con.Open();
                resultado = Convert.ToString(comMoneda.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                resultado = "";
            }

            string importe;
            string query;
            query = "SELECT      CONVERT(NUMERIC(18,2),sum(productos.precio_de_compra * stock )) as suma FROM  productos where  usar_inventario ='Si'";

            SqlCommand com = new SqlCommand(query, con);
            try
            {
                con.Open();
                importe = Convert.ToString(com.ExecuteScalar());
                con.Close();
                lblcosto_inventario.Text = resultado + " " + importe;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);

                lblcosto_inventario.Text = resultado + " " + 0;
            }

            string conteoresultado;
            string querycontar;
            querycontar = "select count(id_producto ) from productos ";
            SqlCommand comcontar = new SqlCommand(querycontar, con);
            try
            {
                con.Open();
                conteoresultado = Convert.ToString(comcontar.ExecuteScalar());
                con.Close();
                lblcantidad_productos.Text = conteoresultado;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);

                conteoresultado = "";
                lblcantidad_productos.Text = "0";
            }

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
            da.SelectCommand.Parameters.AddWithValue("@letra", txtbuscar_movimiento.Text);
            da.Fill(dt);
            DATALISTADO_PRODUCTOS_Movimientos.DataSource = dt;
            con.Close();
           try
            {
                
                DATALISTADO_PRODUCTOS_Movimientos.Columns[1].Visible = false;
            DATALISTADO_PRODUCTOS_Movimientos.Columns[3].Visible = false;
            DATALISTADO_PRODUCTOS_Movimientos.Columns[4].Visible = false;
            DATALISTADO_PRODUCTOS_Movimientos.Columns[5].Visible = false;
            DATALISTADO_PRODUCTOS_Movimientos.Columns[6].Visible = false;
            DATALISTADO_PRODUCTOS_Movimientos.Columns[7].Visible = false;
           
      
                conexion.tamaño_datatablas.multilinea(ref DATALISTADO_PRODUCTOS_Movimientos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if ( txtbuscar_movimiento.Text =="" )
            {
                DATALISTADO_PRODUCTOS_Movimientos.Visible = false;

            }
            else
            {
                DATALISTADO_PRODUCTOS_Movimientos.Visible = true;
                buscar_productos_movimientos(); 
            }
        }

        private void dgv_productos_movimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtbuscar_movimiento.Text = DATALISTADO_PRODUCTOS_Movimientos.SelectedCells[2].Value.ToString ();
            DATALISTADO_PRODUCTOS_Movimientos.Visible = false;
            buscar_movimiento_kardex();

            
            
            
            }

        private void buscar_movimiento_kardex()
        {
            try
            {

                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("buscar_movimientos_kardex", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idproducto", DATALISTADO_PRODUCTOS_Movimientos.SelectedCells[1].Value.ToString());
            da.Fill(dt);
                dgv_listado.DataSource = dt;
            con.Close();

                   dgv_listado.Columns[0].Visible = false;
                dgv_listado.Columns[10].Visible = false;
                dgv_listado.Columns[11].Visible = false;
          
            conexion.tamaño_datatablas.multilinea(ref dgv_listado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void buscar_movimientos_filtros()
        {
            try
            {

                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("buscar_movimientos_filtros", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fecha", txtfecha_filtro.Value);
                da.SelectCommand.Parameters.AddWithValue("@tipo",txtmovimientos_filtro.Text);
                da.SelectCommand.Parameters.AddWithValue("@id_usuario", txtIdusuario.Text);
                da.Fill(dt);
                dgv_listado.DataSource = dt;
                con.Close();

                dgv_listado.Columns[0].Visible = false;
                dgv_listado.Columns[10].Visible = false;
                dgv_listado.Columns[11].Visible = false;

                dgv_listado.Columns[9].Visible = false;
                dgv_listado.Columns[13].Visible = false;
                dgv_listado.Columns[14].Visible = false;

                conexion.tamaño_datatablas.multilinea(ref dgv_listado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buscar_movimientos_filtros_acumulado()
        {
            try
            {

            DataTable dt = new DataTable();
            SqlDataAdapter da;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion.ConexionMaestra.conexion;
            con.Open();

            da = new SqlDataAdapter("buscar_movimientos_filtros_acumulados", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@fecha", txtfecha_filtro.Value);
            da.SelectCommand.Parameters.AddWithValue("@tipo", txtmovimientos_filtro.Text);
            da.SelectCommand.Parameters.AddWithValue("@id_usuario", txtIdusuario.Text);
            da.Fill(dt);
            dgv_movimientos_acumulados.DataSource = dt;
            con.Close();

            dgv_movimientos_acumulados.Columns[4].Visible = false;
            dgv_movimientos_acumulados.Columns[5].Visible = false;
            dgv_movimientos_acumulados.Columns[6].Visible = false;

            conexion.tamaño_datatablas.multilinea(ref dgv_movimientos_acumulados);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buscar_usuario()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion.ConexionMaestra.conexion;
            con.Open();

            da = new SqlDataAdapter("select*from usuarios", con);
      
   
            da.Fill(dt);
            txtvendedor_filtro.DisplayMember = "nombres_apellidos";
            txtvendedor_filtro.ValueMember = "IDusuarios";
            txtvendedor_filtro.DataSource = dt; 
            con.Close();
            buscar_id_usuarios();
        }
        private void buscar_id_usuarios()
        {
            string resultado;
            string query;
            query = "buscar_id_usuarios";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion.ConexionMaestra.conexion;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombres_y_apellidos", txtvendedor_filtro.Text);
            try
            {
                con.Open();
                resultado=Convert.ToString(cmd.ExecuteScalar());
                txtIdusuario.Text = resultado;
                con.Close();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                resultado = "";
            }
  
           
        }
        private void filtrosAvanzadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_inventario_bajo.Visible = false;
            gb_movimientos.Visible = true;
            DATALISTADO_PRODUCTOS_Movimientos.Visible = false;
            txtmovimientos_filtro.Text = "-Todos-";
            buscar_movimientos_filtros();
            buscar_movimientos_filtros_acumulado();
            panel_movimientos_acumulados.Visible = true;

        }

        private void txtvendedor_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gb_movimientos.Visible==true)
            {
                buscar_id_usuarios();
                buscar_movimientos_filtros();
                buscar_movimientos_filtros_acumulado();
            }
        }

        private void ocultarFiltroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_movimientos_acumulados.Visible = false;
            gb_movimientos.Visible = false;
            txtmovimientos_filtro.Text = "-Todos-";

        }

        private void txtfecha_filtro_ValueChanged(object sender, EventArgs e)
        {
            if (gb_movimientos.Visible==true)
            {
                buscar_movimientos_filtros();
                buscar_movimientos_filtros_acumulado();
            }
        }

        private void txtmovimientos_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gb_movimientos.Visible == true)
            {
                buscar_movimientos_filtros();
                buscar_movimientos_filtros_acumulado();
            }
        }
        private void mostrar_inventarios_bajos()
        {
            try
            {

                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("inventarios_bajos", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                dgv_inventarios_bajos.DataSource = dt;
                con.Close();

                dgv_inventarios_bajos.Columns[0].Visible = false;
                dgv_inventarios_bajos.Columns[4].Visible = false;
                dgv_inventarios_bajos.Columns[7].Visible = false;
                dgv_inventarios_bajos.Columns[8].Visible = false;
                dgv_inventarios_bajos.Columns[9].Visible = false;
              

                conexion.tamaño_datatablas.multilinea(ref dgv_inventarios_bajos);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void msinventrios_b_Click(object sender, EventArgs e)
        {
            mostrar_inventarios_bajos();
            panel_movimientos.Dock = DockStyle.None;
            panel_vencimiento.Dock = DockStyle.None;
            panel_inventario_bajo.Dock = DockStyle.Fill;
            panel_reportes_inventarios.Dock = DockStyle.None;
            panel_reportes_inventarios.Visible = false;
            panel_inventario_bajo.Visible = true;
            panel_vencimiento.Visible = false;
          
            panel_movimientos.Visible = false;

            panel_kardex.Visible = false;
            panel_kardex.Dock = DockStyle.None;
            txtbuscar_kardex.Text = "Buscar Producto";
            gb_movimientos.Visible = false;
           
        }
        private void mostrar_inventarios()
        {
            try
            {

                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("mostrar_todos_inventarios", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", txt_buscar_inventarios.Text);
                
                da.Fill(dt);
                dgv_inventarios_reporte.DataSource = dt;
                con.Close();


                dgv_inventarios_reporte.Columns[0].Visible = false;
             
                dgv_inventarios_reporte.Columns[9].Visible = false;
                dgv_inventarios_reporte.Columns[10].Visible = false;
                conexion.tamaño_datatablas.multilinea(ref dgv_inventarios_reporte);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txt_buscar_inventarios_TextChanged(object sender, EventArgs e)
        {
            if (txt_buscar_inventarios.Text !="")
            {
                mostrar_inventarios();
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void msreporte_inv_Click(object sender, EventArgs e)
        {
            sumar_costo_de_inventario_CONTAR_PRODUCTOS();
            mostrar_inventarios();
            panel_movimientos.Dock = DockStyle.None;
            panel_vencimiento.Dock = DockStyle.None;
            panel_inventario_bajo.Dock = DockStyle.None;
            panel_reportes_inventarios.Dock = DockStyle.Fill;
            panel_reportes_inventarios.Visible = true;
            panel_inventario_bajo.Visible = true;
            panel_vencimiento.Visible = false;
            panel_reportes_inventarios.Visible = true;
            panel_movimientos.Visible = false;
         
            panel_kardex.Visible = false;
            panel_kardex.Dock = DockStyle.None;
            
            gb_movimientos.Visible = false;

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            txt_buscar_inventarios.Clear();
            mostrar_inventarios();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }
        private void mostrar_productos_vencidos_en_menos_30_dias()
        {
            try
            {

                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("mostrar_productos_vencidos_en_menos_30_dias", con);
                

                da.Fill(dt);
                da.Fill(dt);
                dgv_vencimiento.DataSource = dt;
                con.Close();

                dgv_vencimiento.Columns[0].Visible = false;
                dgv_vencimiento.Columns[1].Visible = false;
             
                dgv_vencimiento.Columns[6].Visible = false;
                dgv_vencimiento.Columns[7].Visible = false;
                conexion.tamaño_datatablas.multilinea(ref dgv_vencimiento);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void mostrar_productos_vencidos()
        {
            try
            {

                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("mostrar_productos_vencidos", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", txtbuscar_vencimientos.Text);

                da.Fill(dt);
                dgv_vencimiento.DataSource = dt;
                con.Close();


                dgv_vencimiento.Columns[0].Visible = false;
                dgv_vencimiento.Columns[1].Visible = false;
                dgv_vencimiento.Columns[5].Visible = false;
                dgv_vencimiento.Columns[6].Visible = false;
           
                conexion.tamaño_datatablas.multilinea(ref dgv_vencimiento);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtbuscar_vencimientos_TextChanged(object sender, EventArgs e)
        {
            if (txt_buscar_inventarios.Text != "Buscar Producto/Codigo")
            {
                mostrar_productos_vencidos();
                rbvencer30dias.Checked = false;
                rbproductos_vencidos.Checked = false;
            }
        }
        private void mostrar_todos_productos_vencidos()
        {
            try
            {

                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("mostrar_todos_productos_vencidos", con);


                da.Fill(dt);
                dgv_vencimiento.DataSource = dt;
                con.Close();

                dgv_vencimiento.Columns[0].Visible = false;
                dgv_vencimiento.Columns[1].Visible = false;

                conexion.tamaño_datatablas.multilinea(ref dgv_inventarios_reporte);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtbuscar_vencimientos_Click(object sender, EventArgs e)
        {
            rbvencer30dias.Checked = false;
            rbproductos_vencidos.Checked = false;
            
            txtbuscar_vencimientos.SelectAll();
        }

        private void rbproductos_vencidos_CheckedChanged(object sender, EventArgs e)
        {
            mostrar_todos_productos_vencidos();
            txt_buscar_inventarios.Text = "Buscar Producto/Codigo";
        }

        private void rbvencer30dias_CheckedChanged(object sender, EventArgs e)
        {
            mostrar_productos_vencidos_en_menos_30_dias();
            txt_buscar_inventarios.Text = "Buscar Producto/Codigo";
        }

        private void mskardex_Click(object sender, EventArgs e)
        {
            panel_movimientos.Dock = DockStyle.None;
            panel_vencimiento.Dock = DockStyle.None;
            panel_inventario_bajo.Dock = DockStyle.None;
            panel_reportes_inventarios.Dock = DockStyle.None;
            panel_reportes_inventarios.Visible = false;
            panel_vencimiento.Visible = false;
            panel_inventario_bajo.Visible = false;
            panel_reportes_inventarios.Visible = false;
            panel_movimientos.Visible = false;
            panel_kardex.Visible = true;
            panel_kardex.Dock = DockStyle.Fill;
            txtbuscar_kardex.Text = "Buscar Producto";
            gb_movimientos.Visible = false;
        }

        private void msmovimientos_Click(object sender, EventArgs e)
        {
            panel_inventario_bajo.Visible = false;
            panel_movimientos.Dock = DockStyle.Top;
            dgv_listado.Dock = DockStyle.Fill;
            panel_vencimiento.Dock = DockStyle.None;
            dgv_listado.Visible = true;
           panel_inventario_bajo.Dock = DockStyle.None;
            panel_reportes_inventarios.Dock = DockStyle.None;
            panel_reportes_inventarios.Visible = false;
            panel_vencimiento.Visible = false;
            panel_reportes_inventarios.Visible = false;
            panel_movimientos.Visible = true;
            panel_kardex.Visible = false;
            panel_kardex.Dock = DockStyle.None;
            buscar_productos_movimientos();
            buscar_id_usuarios();
          
            
        }

        private void panel_inventario_bajo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DATALISTADO_PRODUCTOS_Movimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_buscar_inventarios_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_buscar_inventarios.Text != "Buscar...")
            {
                
                mostrar_inventarios();
            }
        }

        private void toolStripMenuItem9_Click_1(object sender, EventArgs e)
        {
            txt_buscar_inventarios.Clear();
            mostrar_inventarios();
        }

        private void msvencimientos_Click(object sender, EventArgs e)
        {
            panel_movimientos.Dock = DockStyle.None;
            panel_vencimiento.Dock = DockStyle.Fill;
            panel_inventario_bajo.Dock = DockStyle.None;
            panel_reportes_inventarios.Dock = DockStyle.None;
            panel_reportes_inventarios.Visible = false;
            panel_inventario_bajo.Visible = false;
            panel_vencimiento.Visible = true;
            panel_reportes_inventarios.Visible = false;
            panel_movimientos.Visible = false;

            panel_kardex.Visible = false;
            panel_kardex.Dock = DockStyle.None;

            gb_movimientos.Visible = false;
        }

        private void txtbuscar_kardex_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbuscar_movimiento_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_buscar_inventarios_Click(object sender, EventArgs e)
        {
            txt_buscar_inventarios.SelectAll();
        }
    }
}
