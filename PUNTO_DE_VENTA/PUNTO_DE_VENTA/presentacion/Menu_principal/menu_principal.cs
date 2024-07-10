using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PUNTO_DE_VENTA.negocio;
using PUNTO_DE_VENTA.presentacion.Menu_principal;
using PUNTO_DE_VENTA.datos;
namespace PUNTO_DE_VENTA.presentacion.Menu_principal
{
    public partial class menu_principal : Form
    {
        public menu_principal()
        {
            InitializeComponent();
        }
        int contador_detalle_venta;
        int id_prod;
        int idclient_generico;
        public static int idusaurio_inicio_s;
        public static int idventa;
        String tipo_venta;
        int id_detalle_venta;
        String serial_pc;
        String codigo_texto;
        public static double indicador_cantidad;
        String venta_generada;
        double precio_unitario;
        int contador_tabla_ventas;
        public static double total;
        String usa_inventario;
        public static int idcaja;
        double stock_productos;
        string stock_dgv_p;
        string descripcion;
        string codigo;
        string stock_dv;
        double costo;
        double cantidad;
        Panel mostrar_buscador = new Panel();
        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flw_herramientas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            presentacion.productos.productos frm = new presentacion.productos.productos();
            frm.ShowDialog();
        }
     private void validar_config()
        {
            if (idusaurio_inicio_s != 1)
            {
                ms_config.Visible = false;
            }
        }
        private void menu_principal_Load(object sender, EventArgs e)
        {
            procedimientos_necesarios.cambiar_formato_puntos();
            procedimientos_necesarios.obtener_serial(ref serial_pc);
            datos.procedimientos_reutilizables.obtener_id_caja(ref idcaja);
            datos.procedimientos_reutilizables.mostrar_inicio_sesion(ref idusaurio_inicio_s);
            mostrar_tipo_busqueda();
            mostrar_idcliente_generico();       
            limpiar_para_venta_nueva();
         lbl_hora.Text = DateTime.Now.ToString();
            validar_config();
            if (tipo_busqueda == "TECLADO")
            {
                lbltipobusqueda.Text = "Buscar con teclado";
                mslector.BackColor = Color.WhiteSmoke;
                msteclado.BackColor = Color.LightGreen;
            }
            else
            {
                lbltipobusqueda.Text = "Buscar por Codigo de barras";
                msteclado.BackColor = Color.WhiteSmoke;
                mslector.BackColor = Color.LightGreen;
            }
            limpiar_para_venta_nueva();
        }


        private void mostrar_productos()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("buscar_productos", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", txtbuscar.Text);
                da.Fill(dt);
                dgv_productos.DataSource = dt;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.StackTrace + ex.Message);
            }
        }

        string tipo_busqueda;
        private void mostrar_tipo_busqueda()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                SqlCommand cmd = new SqlCommand("select modo_de_busqueda from empresa", con);
                con.Open();
                tipo_busqueda = Convert.ToString(cmd.ExecuteScalar());
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.StackTrace + ex.Message);
            }
        }

        private void msteclado_Click(object sender, EventArgs e)
        {
            lbltipobusqueda.Text = "Buscar con teclado";
            tipo_busqueda = "TECLADO";
            mslector.BackColor = Color.WhiteSmoke;
            msteclado.BackColor = Color.LightGreen;
            txtbuscar.Clear();
            txtbuscar.Focus();
        }

        private void mslector_Click(object sender, EventArgs e)
        {
            lbltipobusqueda.Text = "Buscar por Codigo de barras";
            tipo_busqueda = "LECTOR";
            msteclado.BackColor = Color.WhiteSmoke;
            mslector.BackColor = Color.LightGreen;
            txtbuscar.Clear();
            txtbuscar.Focus();
        }
        private void mostrar_buscar_productos()
        {
            mostrar_buscador.Size = new System.Drawing.Size(952, 272);
            mostrar_buscador.BackColor = Color.White;
            mostrar_buscador.Location = new Point(11, 50);
            mostrar_buscador.Visible = true;
            dgv_productos.Visible = true;
            dgv_productos.Dock = DockStyle.Fill;
            lbltipobusqueda.Visible = false;
            mostrar_buscador.Controls.Add(dgv_productos);
            this.Controls.Add(mostrar_buscador);
            mostrar_buscador.BringToFront();
        }
        private void ocultar_buscar_productos()
        {
            mostrar_buscador.Visible = false;
            dgv_productos.Visible = false;
            lbltipobusqueda.Visible = true;
        }
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (tipo_busqueda == "LECTOR")
               
            {
                limpiar_para_venta_nueva();
                lbltipobusqueda.Visible = false;
                timer_buscar_por_codigo_barras.Start();


            }
            if (tipo_busqueda == "TECLADO")
            {
                if (txtbuscar.Text == "") {
                    ocultar_buscar_productos();
                }
                else if (txtbuscar.Text != "")
                {
                    mostrar_buscar_productos();
                }

            }

            mostrar_productos();


        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_prod = Convert.ToInt32(dgv_productos.SelectedCells[1].Value.ToString());
            venta_por_teclado();

        }
        String texto;
        private void venta_por_teclado()
        {
            try
            {
                mostrar_stock_detalle_ventas();


                if (contador_detalle_venta == 0)
                {
                    stock_dgv_p = dgv_productos.CurrentRow.Cells[4].Value.ToString();

                }
                else
                { 

                    stock_dgv_p = stock_dv;

                }
                usa_inventario = dgv_productos.CurrentRow.Cells[3].Value.ToString();
               descripcion = dgv_productos.CurrentRow.Cells[9].Value.ToString();
                codigo = dgv_productos.CurrentRow.Cells[7].Value.ToString();
                costo = Convert.ToDouble( dgv_productos.CurrentRow.Cells[5].Value.ToString());
                tipo_venta = dgv_productos.CurrentRow.Cells[8].Value.ToString();
                precio_unitario = Convert.ToDouble(dgv_productos.CurrentRow.Cells[6].Value.ToString());
                texto = dgv_productos.CurrentRow.Cells[2].Value.ToString();
                codigo_texto = dgv_productos.CurrentRow.Cells[7].Value.ToString();


                if (tipo_venta == "unidad")
                {
                    indicador_cantidad = 1;
                    tipo_unidad();
                }
                else if (tipo_venta == "granel")
                {
                    tipo_granel();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.StackTrace + ex.Message);
            }

        }
        public void vender_a_granel()
        {
             
            insertar_ventas();
            if (venta_generada == "VENTA GENERADA")
            {

                indicador_cantidad = 1;
                insertar_detalle_venta();
                productos_agregados();
                txtbuscar.Clear();
                txtbuscar.Focus();
            }
        }
        private void tipo_granel()
        {
            granel frm = new granel();
            frm.precio_u = precio_unitario;
            frm.FormClosed += Frm_FormClosed;
            frm.ShowDialog();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            vender_a_granel();
        }

        private void tipo_unidad()
        {
            try
            {
                if (tipo_busqueda == "TECLADO")
                {
                    txtbuscar.Text = texto;
                }
                else
                {
                    txtbuscar.Text = codigo_texto;
                }
                dgv_productos.Visible = true;
                insertar_ventas();
                if (venta_generada == "VENTA GENERADA")
                {
                
                    insertar_detalle_venta();
                    productos_agregados();
                    txtbuscar.Clear();
                    txtbuscar.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.StackTrace + ex.Message);
            }
        }
        private void insertar_ventas()
        {
            if (venta_generada == "Venta Nueva")
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = conexion.ConexionMaestra.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("insertar_venta", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idcliente", idclient_generico);
                    cmd.Parameters.AddWithValue("@fecha_venta ", DateTime.Today);
                    cmd.Parameters.AddWithValue("@numero_documento", 0);
                    cmd.Parameters.AddWithValue("@monto_total", 0);
                    cmd.Parameters.AddWithValue("@tipo_de_pago", 0);
                    cmd.Parameters.AddWithValue("@estado", "EN ESPERA");
                    cmd.Parameters.AddWithValue("@impuesto", 0);
                    cmd.Parameters.AddWithValue("@comprobante", 0);
                    cmd.Parameters.AddWithValue("@id_usuario", idusaurio_inicio_s);
                    cmd.Parameters.AddWithValue("@fecha_pago", DateTime.Today);
                    cmd.Parameters.AddWithValue("@accion", "Venta");
                    cmd.Parameters.AddWithValue("@saldo", 0);
                    cmd.Parameters.AddWithValue("@formato_pago", 0);
                    cmd.Parameters.AddWithValue("@porcentaje_imp", 0);
                    cmd.Parameters.AddWithValue("@id_caja", idcaja);
                    cmd.Parameters.AddWithValue("@ref_tarjeta", 0);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    mostrar_id_venta();
                    venta_generada = "VENTA GENERADA";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace +  ex.Message);
                }
            }
        }
        private void mostrar_idcliente_generico()
        {

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;

                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(" select idcliente from clientes where  nombre ='GENERICO'", con);
                try
                {
                    con.Open();
                    idclient_generico = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace + ex.StackTrace + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.StackTrace + ex.Message);
            }
        }
        private void mostrar_id_venta() {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion.ConexionMaestra.conexion;
            SqlCommand cmd = new SqlCommand("mostrar_id_venta_por_id_caja", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_caja", idcaja);
            try
            {
                con.Open();
                idventa = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.StackTrace + ex.Message);
            }
        }


        private void insertar_detalle_venta()
        {
            try
            {
                if (usa_inventario == "Si")
                {
                    if (Convert.ToDouble(stock_dgv_p) >= indicador_cantidad)
                    {
                        insertar_detalle_v_validado();
                    }
                    else
                    {
                        MessageBox.Show("PRODUCTO SIN STOCK, AGREGAR MAS UNIDADES AL INVENTARIO PARA PODER SEGUIR VENDIENDO", "PRODUCTO SIN STOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else if (usa_inventario == "NO")
                {
                    insertar_detalle_v_sin_validar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.StackTrace + ex.Message);
            }
        }
        private void productos_agregados()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("mostrar_productos_creados", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idventa", idventa);
                da.Fill(dt);
                dgv_detalle_v.DataSource = dt;
                con.Close();
                dgv_detalle_v.Columns[0].Width = 60;
                dgv_detalle_v.Columns[1].Width = 60;
                dgv_detalle_v.Columns[2].Width = 60;
                dgv_detalle_v.Columns[3].Visible = false;

                dgv_detalle_v.Columns[4].Width = 250;
                dgv_detalle_v.Columns[5].Width = 100;
                dgv_detalle_v.Columns[6].Width = 100;
                dgv_detalle_v.Columns[7].Width = 100;
                dgv_detalle_v.Columns[10].Visible = false;
                dgv_detalle_v.Columns[8].Visible = false;
                dgv_detalle_v.Columns[9].Visible = false;

                dgv_detalle_v.Columns[12].Visible = false;
                dgv_detalle_v.Columns[13].Visible = false;
                dgv_detalle_v.Columns[14].Visible = false;
                dgv_detalle_v.Columns[15].Visible = false;
                dgv_detalle_v.Columns[16].Visible = false;
                mostrar_cantidad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.StackTrace + ex.Message);
            }
        }
        private void disminuir_stock_detalle_venta()
        {
            try
            {
                conexion.ConexionMaestra.abrir_conexion();
                SqlCommand cmd = new SqlCommand("detalle_venta_disminuir_stock", conexion.ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", id_prod);
                cmd.Parameters.AddWithValue("@cantidad", indicador_cantidad);
                cmd.ExecuteNonQuery();
                conexion.ConexionMaestra.cerrar_conexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.StackTrace + ex.Message);
            }
        }
        private void insertar_detalle_v_validado()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_detalle_venta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idventa", idventa);
                cmd.Parameters.AddWithValue("@id_producto", id_prod);
                cmd.Parameters.AddWithValue("@cantidad", indicador_cantidad);
                cmd.Parameters.AddWithValue("@precio_u", precio_unitario);
                cmd.Parameters.AddWithValue("@moneda", 0);
                cmd.Parameters.AddWithValue("@unidades", "unidad");
                cmd.Parameters.AddWithValue("@cantidad_most", indicador_cantidad);
                cmd.Parameters.AddWithValue("@Estado", "EN ESPERA");
                cmd.Parameters.AddWithValue("@descripcion",descripcion);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@stock", stock_dgv_p);
                cmd.Parameters.AddWithValue("@tipo_venta", tipo_venta);
                cmd.Parameters.AddWithValue("@usa_inventario", usa_inventario);
                cmd.Parameters.AddWithValue("@costo", costo);
                cmd.ExecuteNonQuery();
                con.Close();
                disminuir_stock_detalle_venta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.StackTrace + ex.Message);
            }
        }
        private void insertar_detalle_v_sin_validar()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_detalle_venta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idventa", idventa);
                cmd.Parameters.AddWithValue("@id_producto", id_prod);
                cmd.Parameters.AddWithValue("@cantidad", indicador_cantidad);
                cmd.Parameters.AddWithValue("@precio_u", precio_unitario);
                cmd.Parameters.AddWithValue("@moneda", 0);
                cmd.Parameters.AddWithValue("@unidades", "unidad");
                cmd.Parameters.AddWithValue("@cantidad_most", indicador_cantidad);
                cmd.Parameters.AddWithValue("@Estado", "EN ESPERA");

                cmd.Parameters.AddWithValue("@descripcion",descripcion);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@stock", stock_dgv_p);
                cmd.Parameters.AddWithValue("@tipo_venta", tipo_venta);
                cmd.Parameters.AddWithValue("@usa_inventario", usa_inventario);
                cmd.Parameters.AddWithValue("@costo", costo);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.StackTrace + ex.Message);
            }
        }
        private void mostrar_stock_detalle_ventas()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("mostrar_stock_detalle_ventas", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.SelectCommand.Parameters.AddWithValue("@id_producto", id_prod);

                da.Fill(dt);
                contador_detalle_venta = dt.Rows.Count;
                if (contador_detalle_venta > 0)
                {
                    stock_dv = dt.Rows[0]["stock"].ToString();
                }
             
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.Message);
            }
        }
        private void lbltipobusqueda_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {


        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }
        private void editar_cantidad_detalle_venta()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion.ConexionMaestra.conexion;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("agregar_producto_detalle_venta_por_cantidad", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_producto", id_prod);
            cmd.Parameters.AddWithValue("@cantidad", txt_total.Text);
            cmd.Parameters.AddWithValue("@cantidad_mostrada", txt_total.Text);
            cmd.Parameters.AddWithValue("@id_venta ", idventa);
            cmd.ExecuteNonQuery();
            con.Close();
            productos_agregados();
            txt_total.Clear();
            txt_total.Focus();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_total.Text))
            {   
            if (dgv_detalle_v.Rows.Count > 0)
            {

                if (tipo_venta == "unidad")
                {
                    string ruta = txt_total.Text;
                    if (ruta.Contains("."))
                    {
                        MessageBox.Show("Este producto no acepta decimales, solo es posible venderlo por unidades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else 
                    {
                        cantidad_actualizar();
                    }
                    }
                else if (tipo_venta == "granel")
                {
                    cantidad_actualizar();
                }
            }
            else
            {
                txt_total.Clear();
                txt_total.Focus();
            }
            }
        }
        private void cantidad_actualizar()
        {
            double monto_i;
            monto_i = Convert.ToDouble(txt_total.Text);

            double Cantidad;
            Cantidad = Convert.ToDouble(dgv_detalle_v.CurrentRow.Cells[12].Value.ToString());
            double stock ;
            double ind_c ;
            string indi_inv;
            indi_inv = dgv_detalle_v.CurrentRow.Cells[14].Value.ToString();
            if (indi_inv == "Si")
            {
                stock =Convert.ToDouble( dgv_detalle_v.CurrentRow.Cells[11].Value.ToString());
                ind_c = Cantidad + stock;
              if (ind_c >= monto_i)
                {
                    pros_cantidad();
                }
                else
                {
                    MessageBox.Show("PRODUCTO SIN STOCK, AGREGAR MAS UNIDADES AL INVENTARIO PARA PODER SEGUIR VENDIENDO", "PRODUCTO SIN STOCK",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                {
                    pros_cantidad();
                }
           
          
        }
        private void pros_cantidad()
        {
            double monto_i;
            monto_i = Convert.ToDouble(txt_total.Text);

            double Cantidad;
            Cantidad = Convert.ToDouble(dgv_detalle_v.CurrentRow.Cells[12].Value.ToString());
                if (monto_i > Cantidad)
                {
                    indicador_cantidad = monto_i - Cantidad;
                    agregar_productos_detalle_venta();

                }

                else if (monto_i < Cantidad)
                {
                    indicador_cantidad = Cantidad - monto_i;
                    restar_productos_detalle_venta();
                }
            
        }
        private void dgv_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void datos_detalle_ventas()
        {
            try
            {
                if (dgv_detalle_v.Rows.Count > 0)
                {
                   

                id_detalle_venta = Convert.ToInt32(dgv_detalle_v.CurrentRow.Cells[9].Value.ToString());
                id_prod = Convert.ToInt32(dgv_detalle_v.CurrentRow.Cells[8].Value.ToString());
                tipo_venta = dgv_detalle_v.CurrentRow.Cells[15].Value.ToString();
                usa_inventario = dgv_detalle_v.CurrentRow.Cells[14].Value.ToString();
                    cantidad  =Convert.ToDouble( dgv_detalle_v.CurrentRow.Cells[12].Value.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.Message);
            }
        }
        private void agregar_productos_dv()
            {
            try
            {
                SqlCommand cmd;
               SqlConnection con = new SqlConnection();
                 con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                cmd = new SqlCommand("agregar_producto_detalle_venta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", id_prod);
                cmd.Parameters.AddWithValue("@cantidad", indicador_cantidad);
                cmd.Parameters.AddWithValue("@cantidad_mostrada", indicador_cantidad);
                cmd.Parameters.AddWithValue("@id_venta", idventa);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        private void agregar_productos_detalle_venta()
        {
            datos_detalle_ventas();
      
            if (usa_inventario == "Si")
                {
                    stock_productos =Convert.ToDouble( dgv_detalle_v.CurrentRow.Cells[11].Value.ToString());
                    if(stock_productos >0 )
                    {
              
                  agregar_productos_dv();
                disminuir_stock_detalle_venta();
                }
                    else
                    {
                       MessageBox.Show("PRODUCTO SIN STOCK, AGREGAR MAS UNIDADES AL INVENTARIO PARA PODER SEGUIR VENDIENDO",
                      "PRODUCTO SIN STOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }           
                 }
                else
                {
                    agregar_productos_dv();
                }
                productos_agregados();                   
        }

        private void restar_productos_detalle_venta()
        {
            datos_detalle_ventas();
         
                if (usa_inventario == "Si")
                {
                    restar_produc_dv();
                    aumentar_stock_dv();
                }
                else
                {
                    restar_produc_dv();
                }
               
                productos_agregados();          
        }
        private void restar_produc_dv()
        {
            try
            {
            SqlCommand cmd;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion.ConexionMaestra.conexion;
            con.Open();
            cmd = new SqlCommand("restar_productos_detalle_venta", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_detalle_venta", id_detalle_venta);
            cmd.Parameters.AddWithValue("@cantidad", 1);
            cmd.Parameters.AddWithValue("@cantidad_mostrada", 1);
            cmd.Parameters.AddWithValue("@id_producto", id_prod);
            cmd.Parameters.AddWithValue("@id_venta", idventa);
            cmd.ExecuteNonQuery();
            con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          }
        private void aumentar_stock_dv()
        {
            try
            {
                SqlCommand cmd;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                cmd = new SqlCommand("detalle_venta_aumentar_stock", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", id_prod );
                cmd.Parameters.AddWithValue("@cantidad", indicador_cantidad);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void conteo_tabla_ventas()
        {
            int a;
            a = dgv_detalle_v.Rows.Count;
            contador_tabla_ventas = (a);
        }
    private void eliminar_venta_detalle_venta()
        {
            try
            { 
            
            SqlConnection con = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                cmd = new SqlCommand("eliminar_venta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idventa", idventa);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void restar_stock()
        {

        }
        private void dgv_detalle_v_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            datos_detalle_ventas();
            if (e.ColumnIndex == this.dgv_detalle_v.Columns["agregar"].Index)
            {
                indicador_cantidad = 1;
                agregar_productos_detalle_venta();
            }
            if (e.ColumnIndex == this.dgv_detalle_v.Columns["quitar"].Index)
            {
                indicador_cantidad = 1;
                restar_productos_detalle_venta();
                conteo_tabla_ventas();
                if (contador_tabla_ventas == 0)
                {
                    eliminar_venta_detalle_venta();
                    venta_generada = "Venta Nueva";
                }
            }
            if (e.ColumnIndex == this.dgv_detalle_v.Columns["eliminar"].Index)
            {
                foreach (DataGridViewRow row in dgv_detalle_v.SelectedRows)
                {
                    int id_detalle_venta = Convert.ToInt32(row.Cells["id_detalle_venta"].Value);
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = conexion.ConexionMaestra.conexion;
                        con.Open();
                        cmd = new SqlCommand("eliminar_detalle_venta", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_detalleventa", id_detalle_venta);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.StackTrace +  ex.StackTrace + ex.Message);
                    }
                }
                productos_agregados();
            }
        }

        private void mostrar_cantidad()
        {
            try
            {
                int a;
                a = dgv_detalle_v.Rows.Count;
                if(a == 0)
                {
                    lbltotal.Text = "0";
                }
                double precio_f = 0;
                foreach (DataGridViewRow row in dgv_detalle_v.Rows)
                {
                    precio_f +=  Convert.ToDouble( (row.Cells["importe"].Value));
                    lbltotal.Text = Convert.ToString(precio_f);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.StackTrace + ex.Message);
            }

        }
        private void txtventag_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_detalle_v_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtbuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_detalle_v_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos_detalle_ventas();
            if (e.KeyChar == Convert.ToChar( "+"))
            {
                agregar_productos_detalle_venta();
            }
            if (e.KeyChar == Convert.ToChar("-"))
            {
               
                restar_productos_detalle_venta();
            }
        }

        private void btn_num1_Click(object sender, EventArgs e)
        {
            txt_total.Text = txt_total.Text + "1";
        }

        private void btn_num2_Click(object sender, EventArgs e)
        {
            txt_total.Text = txt_total.Text + "2";
        }

        private void btn_num3_Click(object sender, EventArgs e)
        {
            txt_total.Text = txt_total.Text + "3";
        }

        private void btn_num4_Click(object sender, EventArgs e)
        {
            txt_total.Text = txt_total.Text + "4";
        }

        private void btn_num5_Click(object sender, EventArgs e)
        {
            txt_total.Text = txt_total.Text + "5";
        }

        private void btn_num6_Click(object sender, EventArgs e)
        {
            txt_total.Text = txt_total.Text + "6";
        }

        private void btn_num7_Click(object sender, EventArgs e)
        {
            txt_total.Text = txt_total.Text + "7";
        }

        private void btn_num8_Click(object sender, EventArgs e)
        {
            txt_total.Text = txt_total.Text + "8";
        }

        private void btn_num9_Click(object sender, EventArgs e)
        {
            txt_total.Text = txt_total.Text + "9";
        }

        private void btn_num0_Click(object sender, EventArgs e)
        {
            txt_total.Text = txt_total.Text + "0";
        }
        bool texto_m = true;
        private void btn_separar_Click(object sender, EventArgs e)
        {
            if (texto_m == true)
            {
                txt_total.Text = txt_total.Text + ".";
                texto_m = false;

            }
            else
            {
                return;
            }
        }

        private void btn_borrar_todo_Click(object sender, EventArgs e)
        {
            txt_total.Clear();
            texto_m = true;

        }

        private void txt_m_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            presentacion.configuracion.form_configuraciones frm = new presentacion.configuracion.form_configuraciones();
            frm.ShowDialog();
            
        }

        private void btn_cerrar_turno_Click(object sender, EventArgs e)
        {
            caja.cierre_de_caja frm = new caja.cierre_de_caja();
            frm.ShowDialog();
        }

        private void vender_codigo_barras()
        {
            try
            {
if (txtbuscar.Text == "")
            {
                dgv_productos.Visible = false;
                lbltipobusqueda.Visible = true;
            }
            if (txtbuscar.Text != "")
            {
               
                dgv_productos.Visible = true;
                lbltipobusqueda.Visible = false;
                 mostrar_productos();
                             
          
                id_prod = Convert.ToInt32(dgv_productos.SelectedCells[1].Value.ToString());
                MessageBox.Show(id_prod.ToString());
                
                mostrar_stock_detalle_ventas();
               
              
                if (contador_detalle_venta == 0 )
                {
                    stock_dgv_p = dgv_productos.CurrentRow.Cells[4].Value.ToString();
                }
                else
                {
                    stock_dgv_p = stock_dv;
                 
                }
                usa_inventario = dgv_productos.CurrentRow.Cells[3].Value.ToString();
                 descripcion = dgv_productos.CurrentRow.Cells[9].Value.ToString();
                codigo = dgv_productos.CurrentRow.Cells[7].Value.ToString();
                costo = Convert.ToDouble( dgv_productos.CurrentRow.Cells[5].Value.ToString());
                tipo_venta = dgv_productos.CurrentRow.Cells[8].Value.ToString();
                if (tipo_venta == "unidad")
                {
                    indicador_cantidad = 1;
                    tipo_unidad();
                     
                }
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            
        }

        private void timer_buscar_por_codigo_barras_Tick(object sender, EventArgs e)
        {
            timer_buscar_por_codigo_barras.Stop();
            vender_codigo_barras();

        }
        private void limpiar_para_venta_nueva()
        {
            idventa = 0;
            venta_generada = "Venta Nueva";
            productos_agregados();
            mostrar_cantidad();
            

        }
        private void regresar_para_venta_nueva(object sender, FormClosedEventArgs e)
        {
            limpiar_para_venta_nueva();
        }
        private void btncobrar_Click(object sender, EventArgs e)
        {
            total = Convert.ToDouble(lbltotal.Text);
           medios_de_pago frm = new medios_de_pago();
            
            frm.FormClosed += new FormClosedEventHandler(regresar_para_venta_nueva);
            frm.ShowDialog();
        }

        private void ms_restaurar_Click(object sender, EventArgs e)
        {
            ventas_espera frm = new ventas_espera();
            frm.FormClosed += Frm_FormClosed1;
            frm.ShowDialog();
        }

        private void Frm_FormClosed1(object sender, FormClosedEventArgs e)
        {
            productos_agregados();
        }

        private void ms_eliminar_venta_Click(object sender, EventArgs e)
        {
            if(dgv_detalle_v.RowCount > 0)
            {

           
            DialogResult dr = MessageBox.Show("¿Estas seguro de eliminar esta venta?", "Eliminar venta", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr== DialogResult.OK)
            {
                limpiar_para_venta_nueva();
                eliminar_venta.eliminar_venta_espera(idventa);
            }
            }
        }

        private void ms_poner_epera_Click(object sender, EventArgs e)
        {
            if (dgv_detalle_v.RowCount > 0)
            {

             panel_espera.Visible = true;
            panel_espera.BringToFront();
            panel_espera.Location = new Point(216, 161);

            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            panel_espera.Visible = false;
            txt_nombre_Espera.Clear();
        }
        private void ag_venta_espera()
        {
            ventas_espera_proc.nombre_venta_espera(idventa, txt_nombre_Espera.Text);
            limpiar_para_venta_nueva();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_nombre_Espera.Text))
            {
                ag_venta_espera();
                panel_espera.Visible = false;
            }
            else
            {
                MessageBox.Show("Ingrese un nombre o genere uno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_auto_Click(object sender, EventArgs e)
        {
            txt_nombre_Espera.Text = "Ticket" + idventa;
            ag_venta_espera();
            panel_espera.Visible = false;
        }
        private void ms_hora_Click(object sender, EventArgs e)
        {

        }
        private void txt_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            procedimientos_necesarios.evaluar_caracteres(txt_total, e);
        }
        private void aplicar_precio_mayoreo()
        {
            if (dgv_detalle_v.Rows.Count > 0)
            {
             ndv prm = new ndv();
            insertar fns = new insertar();
            prm.id_producto =id_prod;
            prm.id_detalle_venta =id_detalle_venta;
            if (fns.precio_mayoreo(prm) == true)
            {
                productos_agregados();
            }
           }
           

        }
        private void btn_mayoreo_Click(object sender, EventArgs e)
        {
            aplicar_precio_mayoreo();
        }
    }

}
