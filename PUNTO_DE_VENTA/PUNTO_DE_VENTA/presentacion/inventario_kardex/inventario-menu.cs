﻿using System;
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
using System.Collections;
namespace PUNTO_DE_VENTA.presentacion.inventario_kardex
{
    public partial class inventario_menu : Form
    {
        public inventario_menu()
        {
            InitializeComponent();
        }
        public static int id_producto_reporte;
     
        private void inventario_menu_Load(object sender, EventArgs e)
        {
            buscar_usuario();
            panel_inventario_bajo.Visible = false;
            panel_inventario_bajo.Dock = DockStyle.None;
            panel_reportes_inventarios.Dock = DockStyle.None;
            panel_reportes_inventarios.Visible = false;
            panel_vencimiento.Visible = false;
            panel_kardex.Visible = true;
            panel_kardex.Dock = DockStyle.Fill;
            panelmovimientos.Visible = false;
            panelmovimientos.Dock = DockStyle.None;
            gb_movimientos.Dock = DockStyle.None;
            gb_movimientos.Visible = false;
            panel_movimientos.Visible = false;
            panel_movimientos.Dock = DockStyle.None;
            dgv_listado.Dock = DockStyle.None;
            panel_vencimiento.Dock = DockStyle.None;
            txtbuscar_kardex.Text = "Buscar Producto";
            panel_reporte.Dock = DockStyle.Fill;
            this.reportViewer1.RefreshReport();
            
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


                negocio.procedimientos_necesarios.formato_dgv(ref DATALISTADO_PRODUCTOS_Movimientos);
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
     
            id_producto_reporte = Convert.ToInt32(DATALISTADO_PRODUCTOS_Movimientos.SelectedCells[1].Value.ToString());


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

                negocio.procedimientos_necesarios.formato_dgv(ref dgv_listado);

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

                negocio.procedimientos_necesarios.formato_dgv(ref dgv_listado);

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

                negocio.procedimientos_necesarios.formato_dgv(ref dgv_movimientos_acumulados);

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


                negocio.procedimientos_necesarios.formato_dgv(ref dgv_inventarios_bajos);

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
            panel_inventario_bajo.Visible = true;
            panel_inventario_bajo.Dock = DockStyle.Fill;
            panel_reportes_inventarios.Dock = DockStyle.None;
            panel_reportes_inventarios.Visible = false;
            panel_vencimiento.Visible = false;
            panel_reportes_inventarios.Visible = false;
            panel_kardex.Visible = false;
            panelmovimientos.Visible = false;
            panelmovimientos.Dock = DockStyle.Top;
            gb_movimientos.Dock = DockStyle.None;
            gb_movimientos.Visible = false;
            panel_movimientos.Visible = false;
            panel_movimientos.Dock = DockStyle.None;
            txtbuscar_kardex.Text = "Buscar Producto";
            dgv_listado.Dock = DockStyle.None;
            panel_vencimiento.Dock = DockStyle.None;
            dgv_listado.Visible = false;
            panel_kardex.Dock = DockStyle.None;


       
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
                negocio.procedimientos_necesarios.formato_dgv(ref dgv_inventarios_reporte);

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
            panel_inventario_bajo.Visible = false;
            panel_inventario_bajo.Dock = DockStyle.None;
            panel_reportes_inventarios.Dock = DockStyle.Fill;
            panel_reportes_inventarios.Visible = true;
            panel_vencimiento.Visible = false;
            
            panel_kardex.Visible = false;
            panelmovimientos.Visible = false;
            panelmovimientos.Dock = DockStyle.None;
            gb_movimientos.Dock = DockStyle.None;
            gb_movimientos.Visible = false;
            panel_movimientos.Visible = false;
            panel_movimientos.Dock = DockStyle.None;
            dgv_listado.Dock = DockStyle.None;
            panel_vencimiento.Dock = DockStyle.None;
            dgv_listado.Visible = false;
            panel_kardex.Dock = DockStyle.None;


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
                negocio.procedimientos_necesarios.formato_dgv(ref dgv_vencimiento);

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

                negocio.procedimientos_necesarios.formato_dgv(ref dgv_vencimiento);

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

                negocio.procedimientos_necesarios.formato_dgv(ref dgv_inventarios_reporte);

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
            reportViewer1.Refresh();
            panel_inventario_bajo.Visible = false;
            panel_inventario_bajo.Dock = DockStyle.None;
            panel_reportes_inventarios.Dock = DockStyle.None;
            panel_reportes_inventarios.Visible = false;
            panel_vencimiento.Visible = false;
            panel_kardex.Visible = true ;
            panel_kardex.Dock = DockStyle.Fill;
            panelmovimientos.Visible = false;
            panelmovimientos.Dock = DockStyle.None;
            gb_movimientos.Dock = DockStyle.None;
            gb_movimientos.Visible = false;
            panel_movimientos.Visible = false;
            panel_movimientos.Dock = DockStyle.None;
            dgv_listado.Dock = DockStyle.None;
            panel_vencimiento.Dock = DockStyle.None;
            txtbuscar_kardex.Text = "Buscar Producto";
            panel_reporte.Dock = DockStyle.Fill;

      
        }

        private void msmovimientos_Click(object sender, EventArgs e)
        {
            panel_inventario_bajo.Visible = false;
          
           panel_inventario_bajo.Dock = DockStyle.None;
            panel_reportes_inventarios.Dock = DockStyle.None;
            panel_reportes_inventarios.Visible = false;
            panel_vencimiento.Visible = false;
            panel_reportes_inventarios.Visible = false;
            panel_kardex.Visible = false;
            panelmovimientos.Visible = true;
            panelmovimientos.Dock = DockStyle.Top;
            gb_movimientos.Dock = DockStyle.Fill;
            panel_movimientos.Visible = true;
            panel_movimientos.Dock = DockStyle.Fill;
           
            dgv_listado.Dock = DockStyle.Fill;
            panel_vencimiento.Dock = DockStyle.None;
            dgv_listado.Visible = true;
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

            panel_inventario_bajo.Visible = false;
            panel_inventario_bajo.Dock = DockStyle.None;
            panel_reportes_inventarios.Dock = DockStyle.None;
            panel_reportes_inventarios.Visible = false;
            panel_vencimiento.Visible = true;
            panel_kardex.Visible = false;
            panelmovimientos.Visible = false;
            panelmovimientos.Dock = DockStyle.None;
            gb_movimientos.Dock = DockStyle.None;
            gb_movimientos.Visible = false;
            panel_movimientos.Visible = false;
            panel_movimientos.Dock = DockStyle.None;
            dgv_listado.Dock = DockStyle.None;
            panel_vencimiento.Dock = DockStyle.Fill;
            dgv_listado.Visible = false;
        }
        private void buscar_productos_kardex()
        {
            try
            {

                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();

                da = new SqlDataAdapter("buscar_productos_kardex", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", txtbuscar_kardex.Text);

                da.Fill(dt);
                dgv_productos_kardex.DataSource = dt;
               
                con.Close();
                dgv_productos_kardex.Columns[0].Visible = false;
                dgv_productos_kardex.Columns[1].Visible = false;
            
                dgv_productos_kardex.Columns[3].Visible = false;
                dgv_productos_kardex.Columns[4].Visible = false;
                dgv_productos_kardex.Columns[5].Visible = false;
                dgv_productos_kardex.Columns[6].Visible = false;
                dgv_productos_kardex.Columns[7].Visible = false;

                negocio.procedimientos_necesarios.formato_dgv(ref dgv_productos_kardex);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                da.SelectCommand.Parameters.AddWithValue("@idproducto", SqlDbType.Int).Value = Convert.ToInt32(txtbuscar_kardex.Text = dgv_productos_kardex.SelectedCells[1].Value.ToString());

                da.Fill(dt);
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rp = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Add(rp);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.Refresh();
                this.reportViewer1.RefreshReport();
                dgv_productos_kardex.Visible = false;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            reportViewer1.Refresh();
        }
        private void txtbuscar_kardex_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar_kardex.Text== "Buscar Producto"| txtbuscar_kardex.Text=="")
            {
                dgv_productos_kardex.Visible = false;
            }
            else
            {
                dgv_productos_kardex.Visible = true;
                buscar_productos_kardex();
            }
        }

        private void txtbuscar_movimiento_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_buscar_inventarios_Click(object sender, EventArgs e)
        {
            txt_buscar_inventarios.SelectAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_productos_kardex_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            txtbuscar_kardex.Text = dgv_productos_kardex.SelectedCells[2].Value.ToString();
            dgv_productos_kardex.Visible = false;
            mostrar_kardex_inventario();
            this.reportViewer1.RefreshReport();
            try
            {


                
            }
            catch (Exception ex)
            {

            }
            }



        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void imprimirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            presentacion.reportes.reportes_de_kardex.reporte_de_inventarios.form_r_movimientos frm = new
                presentacion.reportes.reportes_de_kardex.reporte_de_inventarios.form_r_movimientos();
            frm.ShowDialog();

        }
        public static string tipo_movimiento_reporte;
        public static DateTime fecha_reporte;
        public static int id_usuario_reporte;
        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo_movimiento_reporte = txtmovimientos_filtro.Text;
            fecha_reporte = txtfecha_filtro.Value;
            id_usuario_reporte = Convert.ToInt32 (txtIdusuario.Text);
            presentacion.reportes.reportes_de_kardex.reporte_de_inventarios.form_reporte_movimientos_filtros frm = new
               presentacion.reportes.reportes_de_kardex.reporte_de_inventarios.form_reporte_movimientos_filtros();
            frm.ShowDialog();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }

        private void dadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            presentacion.control_negocio.pantalla_principal_admin frm = new presentacion.control_negocio.pantalla_principal_admin();

            frm.ShowDialog();
            Dispose();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void elPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            inventario_kardex.inv_entrada frm = new inv_entrada();
            frm.ShowDialog();
        }
    }
}
