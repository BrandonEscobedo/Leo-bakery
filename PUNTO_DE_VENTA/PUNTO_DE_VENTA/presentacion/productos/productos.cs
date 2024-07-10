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
using System.Globalization;
using System.Data.OleDb;
using System.IO;
using System.Threading;
using System.Management;

namespace PUNTO_DE_VENTA.presentacion.productos
{

    public partial class productos : Form
    {
       

        public productos()
        {
            InitializeComponent();
        }
        String serial_pc;
        int txtcontar;
        int id_producto;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel_productos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        internal void limpiar()
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel_productos.Visible = true;
            panel_productos.Dock = DockStyle.Fill;
            cbinventario.Checked = true;
            PANELINVENTARIO.Visible = true;
            panel_seleccionar_grupo.Visible = true;
            ms_guardarCambios.Visible = false;
            ms_guardarGrupo.Visible = false;
            ms_cancelar.Visible = false;
            ms_agregar_grupo.Visible = true;
            mostrar_grupos();
            txtgrupo.Clear();
            panel_ver_productos.Visible = false;
            txt_mayoreo.Text = "0";
            txtunidades.Text = "0";
            lblestadocodigo.Text = "EDITAR";
            panel_seleccionar_grupo.Visible = true;
            ms_guardarCambios.Visible = false;
            ms_guardarGrupo.Visible = false;
            ms_cancelar.Visible = false;
            ms_agregar_grupo.Visible = true;
            mostrar_grupos();
            id_producto= 0;
            PANELINVENTARIO.Visible = true;
            Panel25.Enabled = true;
            txtdescripcion.AutoCompleteCustomSource = negocio.procedimientos_necesarios.LoadAutoComplete();
            txtdescripcion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtdescripcion.AutoCompleteSource = AutoCompleteSource.CustomSource;

            panel_productos.Visible = true;
            rbpieza.Checked = true;
            
            cb_no_aplica_fecha.Checked = false;
            LIMPIAR();
            actualizarcambios.Visible = false;
            txtdescripcion.Text = "";
            PANELINVENTARIO.Visible = true;

        }
        internal void LIMPIAR()
        {
            id_producto= 0;
            txtdescripcion.Text = "";
            txtprecio_compra.Text = "0";
            txt_precio_venta.Text = "0";
            txt_mayoreo.Text = "0";
            txtgrupo.Text = "";

            rbgranel.Checked = false;
            rbpieza.Checked = false;
            txtstock_minimo.Text = "0";
            txtstock_hay.Text = "0";
            lblestadocodigo.Text = "NUEVO";
        }
        private void productos_Load(object sender, EventArgs e)
        {
            negocio.procedimientos_necesarios.cambiar_formato_puntos();           
            txtbuscar.Text = "Buscar...";
            sumar_costo_de_inventario_CONTAR_PRODUCTOS();
         
            mostrar_grupos();
            panel_productos.Visible = false;
            panel_productos.Dock = DockStyle.None;
            panel_ver_productos.Visible = true;
            panel_ver_productos.Dock = DockStyle.Fill;
            negocio.procedimientos_necesarios.obtener_serial(ref serial_pc);
            mostrar_inicio_sesion();
            datos.procedimientos_reutilizables.obtener_id_caja(ref id_caja);
          
            buscar();
        } 
       
        private void guardarGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insert_grupo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@grupo", txtgrupo.Text);
                cmd.Parameters.AddWithValue("@por_defecto", "no");
                cmd.ExecuteNonQuery();
                con.Close();
                mostrar_grupos();
                string idgrupo;

                idgrupo = dgv_grupos.SelectedCells[2].Value.ToString();
                txtgrupo.Text = dgv_grupos.SelectedCells[3].Value.ToString();

                panel_seleccionar_grupo.Visible = false;
                ms_guardarCambios.Visible = false;
                ms_guardarGrupo.Visible = false;
                ms_cancelar.Visible = false;
                ms_agregar_grupo.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void mostrar_grupos()
        {
            panel_seleccionar_grupo.Visible = true;
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("mostrar_grupos", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@buscar", txtgrupo.Text);
                da.Fill(dt);
                dgv_grupos.DataSource = dt;

                con.Close();
                dgv_grupos.DataSource = dt;
                dgv_grupos.Columns[2].Visible = false;
                dgv_grupos.Columns[3].Width = 500;
            }
            catch (Exception ex)
            {

            }
            
        }
        internal void sumar_costo_de_inventario()
        {

        }

        private void ms_agregar_grupo_Click(object sender, EventArgs e)
        {
            txtgrupo.Text = "Escribe el nombre del nuevo grupo";
            txtgrupo.SelectAll();
            txtgrupo.Focus();
            panel_seleccionar_grupo.Visible = false;
            ms_guardarCambios.Visible = false;
            ms_guardarGrupo.Visible = true;
            ms_cancelar.Visible = true;

            ms_agregar_grupo.Visible = false;

        }

        private void txtgrupo_TextChanged(object sender, EventArgs e)
        {
            mostrar_grupos();

        }

        private void ms_cancelar_Click(object sender, EventArgs e)
        {
            panel_seleccionar_grupo.Visible = false;
            ms_guardarCambios.Visible = false;
            ms_guardarGrupo.Visible = false;
            ms_cancelar.Visible = false;
            ms_agregar_grupo.Visible = true;
            txtgrupo.Clear();
            mostrar_grupos();

        }
       public static int id_usuario;
        private void mostrar_inicio_sesion()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion.ConexionMaestra.conexion;
           
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("mostrar_inicio_sesion", con);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@id_serial_pc", serial_pc);
           
            try
            {
                con.Open();
                id_usuario = Convert.ToInt32(cmd.ExecuteScalar());
               
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
    public static    int id_caja;

        private void pbguardar_Click(object sender, EventArgs e)
        {
            
        }
        private void insertar_productos()
        {
            if (txt_mayoreo.Text == "0" | txt_mayoreo.Text == "") txtunidades.Text = "0"  ;
            try
            {
                if (txtdescripcion.Text == "" | txtgrupo.Text == "" | txt_codigo.Text == "" | txtunidades.Text == "" | txtprecio_compra.Text == "" | txt_precio_venta.Text == "" | rbgranel.Checked == false & rbpieza.Checked==false)
                {
                    MessageBox.Show("Favor de no dejar campos vacios, verifique la informacion", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                try
                    {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_producto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", txtdescripcion.Text);
                cmd.Parameters.AddWithValue("@Imagen", "." );
                cmd.Parameters.AddWithValue("@Precio_de_compra", txtprecio_compra.Text);
                cmd.Parameters.AddWithValue("@Precio_de_venta", txt_precio_venta.Text);
                cmd.Parameters.AddWithValue("@Codigo", txt_codigo.Text);
                cmd.Parameters.AddWithValue("@A_partir_de_pm", txtunidades.Text);
                cmd.Parameters.AddWithValue("@Impuesto", 0);
                cmd.Parameters.AddWithValue("@Precio_mayoreo", txt_mayoreo.Text);
                if (rbgranel.Checked == true) lbl_tipo_venta.Text = "granel";
                if (rbpieza.Checked == true) lbl_tipo_venta.Text = "unidad";

                cmd.Parameters.AddWithValue("@Tipo_venta", lbl_tipo_venta.Text);
                cmd.Parameters.AddWithValue("@Id_grupo", lblid_grupo.Text);
                if (PANELINVENTARIO.Visible == true)
                {
                    cmd.Parameters.AddWithValue("@Usar_inventario", "Si");
                    cmd.Parameters.AddWithValue("@Stock", txtstock_hay.Text);
                    cmd.Parameters.AddWithValue("@Stock_minimo", txtstock_minimo.Text);
                    if (cb_no_aplica_fecha.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@Fecha_de_vencimiento", "NO APLICA");

                    }
                    if (cb_no_aplica_fecha.Checked == false)
                    {
                        cmd.Parameters.AddWithValue("@Fecha_de_vencimiento", txtfecha_vencimiento.Value.ToString("yyyy/MM/dd"));

                    }
                }
                if (PANELINVENTARIO.Visible == false)
                {

                    cmd.Parameters.AddWithValue("@Usar_inventario", "NO");
                    cmd.Parameters.AddWithValue("@Stock_minimo", 0);
                    cmd.Parameters.AddWithValue("@Fecha_de_vencimiento", "NO APLICA");
                    cmd.Parameters.AddWithValue("@Stock", "Ilimitado");
                }
                cmd.Parameters.AddWithValue("@fecha", DateTime.Today);
                cmd.Parameters.AddWithValue("@motivo", "Registro inicial de Producto");
                cmd.Parameters.AddWithValue("@cantidad ", txtstock_hay.Text);
                cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                cmd.Parameters.AddWithValue("@tipo", "ENTRADA");
                cmd.Parameters.AddWithValue("@estado", "CONFIRMADO");
                cmd.Parameters.AddWithValue("@id_caja",id_caja);
                cmd.ExecuteNonQuery();
                con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message+ ex.StackTrace);
                    }
                    PANELINVENTARIO.Visible = false;

                txtbuscar.Text = txtdescripcion.Text;
                LIMPIAR();
                panel_productos.Visible = false;
                panel_ver_productos.Visible = true;
                panel_ver_productos.Dock = DockStyle.Fill;
                buscar();

                   
                   
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void editar_productos()
        {
           
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("editar_producto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", txtdescripcion.Text);
                cmd.Parameters.AddWithValue("@Id_Producto", id_producto);   
                cmd.Parameters.AddWithValue("@Imagen", ".");
                cmd.Parameters.AddWithValue("@Precio_de_compra", txtprecio_compra.Text);
                cmd.Parameters.AddWithValue("@Precio_de_venta", txt_precio_venta.Text);
                cmd.Parameters.AddWithValue("@Codigo", txt_codigo.Text);
                cmd.Parameters.AddWithValue("@A_partir_de_pm", txtunidades.Text);
                cmd.Parameters.AddWithValue("@Impuesto", 0);
                cmd.Parameters.AddWithValue("@Precio_mayoreo", txt_mayoreo.Text);
                if (rbgranel.Checked == true) lbl_tipo_venta.Text = "granel";
                if (rbpieza.Checked == true) lbl_tipo_venta.Text = "unidad";

                cmd.Parameters.AddWithValue("@tipo_venta", lbl_tipo_venta.Text);
                cmd.Parameters.AddWithValue("@Id_grupo", lblid_grupo.Text);
                if (PANELINVENTARIO.Visible == true)
                {
                    cmd.Parameters.AddWithValue("@Usar_inventario", "Si");
                    cmd.Parameters.AddWithValue("@Stock", txtstock_hay.Text);
                    cmd.Parameters.AddWithValue("@Stock_minimo", txtstock_minimo.Text);
                    if (cb_no_aplica_fecha.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@Fecha_de_vencimiento", "NO APLICA");

                    }
                    if (cb_no_aplica_fecha.Checked == false)
                    {
                        cmd.Parameters.AddWithValue("@Fecha_de_vencimiento", txtfecha_vencimiento.Value.ToString("yyyy/MM/dd"));

                    }
                }
                if (PANELINVENTARIO.Visible == false)
                {
                    cmd.Parameters.AddWithValue("@Usar_inventario", "NO");
                    cmd.Parameters.AddWithValue("@Stock_minimo", 0);
                    cmd.Parameters.AddWithValue("@Fecha_de_vencimiento", "NO APLICA");
                    cmd.Parameters.AddWithValue("@Stock", "Ilimitado");
                }
                cmd.ExecuteNonQuery();
                con.Close();
                panel_productos.Visible = false;
                txtbuscar.Text = txtdescripcion.Text;

                panel_productos.Visible = false;
                panel_ver_productos.Visible = true;
                panel_ver_productos.Dock = DockStyle.Fill;
                buscar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.Message);
            }
            

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
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = "";
            ofd.Filter = "Imagenes |*.jpg;*.png";
            ofd.FilterIndex = 2;
            ofd.Title = "cargador de imagenes";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                icono.BackgroundImage = null;
                icono.Image = new Bitmap(ofd.FileName);
                lbl_nombre_icono.Text = Path.GetFileName(ofd.FileName);
                lbl_anuncio.Visible = false;
                Panel_Iconos.Visible = false;

            }
        }
       
      
      

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void generar_codigo_de_barras_automatico()
        {
            double resultado;
            string querymoneda;
            querymoneda = "select max(id_producto) from productos";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion.ConexionMaestra.conexion;
            SqlCommand comMoneda = new SqlCommand(querymoneda,con);
            try
            {
                con.Open();
                resultado = Convert.ToDouble(comMoneda.ExecuteScalar()) +1 ;
                con.Close();

            }
            catch (Exception ex)
            {
                resultado = 1;
            }
            string cadena = txtgrupo.Text;
            string[] Palabra;
            string espacio = " ";
            Palabra = cadena.Split(Convert.ToChar(espacio));
            try
            {
                txt_codigo.Text = resultado + Palabra[0].Substring(0, 2) + 221;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dgv_grupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (id_producto!= 0 & Convert.ToDouble(txtstock_hay.Text) > 0)
            {
                if (cbinventario.Checked == false)
                { 
                    MessageBox.Show("Hay Aun En Stock, Dirijete al Modulo Inventarios para Ajustar el Inventario a cero", "Stock Existente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    PANELINVENTARIO.Visible = true;
                    cbinventario.Checked = true;
                }
            }

            if (id_producto!= 0 & Convert.ToDouble(txtstock_hay.Text) == 0)
            {
                if (cbinventario.Checked == false)
                {
                    PANELINVENTARIO.Visible = false;

                }
            }

            if (id_producto== 0)
            {
                if (cbinventario.Checked == false)
                {
                    PANELINVENTARIO.Visible = false;

                }
            }

            if (cbinventario.Checked == true)
            {

                PANELINVENTARIO.Visible = true;
            }

        }
        private void buscar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion.ConexionMaestra.conexion;
            con.Open();

            da = new SqlDataAdapter("buscar_producto_por_descripcion", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@letra", txtbuscar.Text);
            da.Fill(dt);
            dgv_productos.DataSource = dt;
            con.Close();

            dgv_productos.Columns[7].Visible = false;
            dgv_productos.Columns[10].Visible = false;
            dgv_productos.Columns[15].Visible = false;
            dgv_productos.Columns[2].Visible = false;

        }
        private void mostrar_descripcion_producto_s_repetir()
        {
            try { 
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion.ConexionMaestra.conexion;
            con.Open();
            da = new SqlDataAdapter("mostrar_descripcion_producto_s_repetir", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@buscar", txtdescripcion.Text);
            da.Fill(dt);
            dgv_productos_descripcion.DataSource = dt;

            con.Close();
      
           
               
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);    
            }
    }
        private void contar()
        {
            int contar;
            contar = dgv_productos_descripcion.Rows.Count;
            txtcontar = (contar);
        }
        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {
            mostrar_descripcion_producto_s_repetir();
            contar();
            if (txtcontar == 0)
            {
                dgv_productos_descripcion.Visible = false;

            }
            if (txtcontar >0)
            {
                dgv_productos_descripcion.Visible = true;

            }
            if (pbguardar.Visible ==false)
            {
                dgv_productos_descripcion.Visible = false;

            }
        }

        private void dgv_productos_descripcion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtdescripcion.Text = dgv_productos_descripcion.SelectedCells[0].Value.ToString();
                dgv_productos_descripcion.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_productos_descripcion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void generarCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generar_codigo_de_barras_automatico();
            
        }

        private void txt_ganancia_TextChanged(object sender, EventArgs e)
        {
            
            timer_calcular_porcentaje_ganancia.Stop();
            
                timer_calcular_precio_de_venta.Start();

            timer_calcular_porcentaje_ganancia.Stop();

        }

        private void timer_calcular_porcentaje_ganancia_Tick(object sender, EventArgs e)
        {
            timer_calcular_porcentaje_ganancia.Stop();
            try
            {
                double totalventa;
                double txtprecioventa = Convert.ToDouble(txt_precio_venta.Text);
                double txtcosto = Convert.ToDouble(txtprecio_compra.Text);
                totalventa = ((txtprecioventa - txtcosto) / (txtcosto)) * 100;

                if (totalventa > 0)
                {
                    this.txt_ganancia.Text = Convert.ToString(totalventa);

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void timer_calcular_precio_de_venta_Tick(object sender, EventArgs e)
        {
            timer_calcular_precio_de_venta.Stop();
            try
            {
                double totalventa;
                double txtcosto = Convert.ToDouble(txt_precio_venta.Text);
                double txtporcentajeganancia= Convert.ToDouble(txtprecio_compra.Text);
                totalventa = txtcosto + ((txtcosto * txtporcentajeganancia) / 100) ;

                if (totalventa > 0  & txt_ganancia.Focused==true)
                {
                    this.txt_precio_venta.Text = Convert.ToString(totalventa);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void proceso_para_obtener_datos_de_producto()
        {
            
            try
            {
                panel_ver_productos.Dock = DockStyle.None;

                panel_ver_productos.Visible = false;
                panel_productos.Visible = true;
                panel_productos.Dock = DockStyle.Fill;
                panel_seleccionar_grupo.Visible = false;
                ms_guardarCambios.Visible = false;
                ms_guardarGrupo.Visible = false;
                ms_cancelar.Visible = false;
                ms_agregar_grupo.Visible = true;
                panel_seleccionar_grupo.Visible = false;

                foreach (DataGridViewRow row in dgv_productos.Rows)
                {
                    id_producto= Convert.ToInt32( row.Cells[2].Value.ToString());
                    txt_codigo.Text = row.Cells[3].Value.ToString();
                    txtgrupo.Text = row.Cells[4].Value.ToString();
                    txtdescripcion.Text = row.Cells[5].Value.ToString();
                lblnumigv.Text = row.Cells[6].Value.ToString();
                lblid_grupo.Text = row.Cells[15].Value.ToString();
                lbles_servicio.Text = row.Cells[7].Value.ToString();
                txtprecio_compra.Text = row.Cells[8].Value.ToString();
                txt_mayoreo.Text = row.Cells[9].Value.ToString();
                lbl_tipo_venta.Text = row.Cells[17].Value.ToString();


                if (lbl_tipo_venta.Text== "unidad" )
                {
                    rbpieza.Checked = true;

                }
                if (lbl_tipo_venta.Text == "granel")
                {
                    rbpieza.Checked = true;

                }   
                txtstock_minimo.Text = row.Cells[11].Value.ToString();
                txt_precio_venta.Text = row.Cells[14].Value.ToString();
                if (cb_no_aplica_fecha.Text == "NO APLICA")
                {
                    cb_no_aplica_fecha.Checked = true;

                }
                if (cb_no_aplica_fecha.Text == "NO APLICA")
                {
                    cb_no_aplica_fecha.Checked = false;

                }
                txtstock_hay.Text = row.Cells[13].Value.ToString();
                txt_precio_venta.Text = row.Cells[14].Value.ToString();
                try
                {
                    double TotalVentaVariabledouble;
                    double TXTPRECIODEVENTA2V = Convert.ToDouble(txt_precio_venta.Text);
                    double txtcostov = Convert.ToDouble(txtprecio_compra.Text);
                    TotalVentaVariabledouble = ((TXTPRECIODEVENTA2V - txtcostov) / (txtcostov)) * 100;
                    if (TotalVentaVariabledouble > 0)
                    {
                        this.txt_ganancia.Text = Convert.ToString(TotalVentaVariabledouble);
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                if (lbles_servicio.Text == "SI")
                {

                    PANELINVENTARIO.Visible = true;
                    PANELINVENTARIO.Visible = true;
                    txtstock_hay.ReadOnly = true;
                    cbinventario.Checked = true;

                }
                if (lbles_servicio.Text == "NO")
                {
                    cbinventario.Checked = false;

                    PANELINVENTARIO.Visible = false;
                    PANELINVENTARIO.Visible = false;
                    txtstock_hay.ReadOnly = true;
                    txtstock_hay.Text = "0";
                    txtstock_minimo.Text = "0";
                    cb_no_aplica_fecha.Checked = true;
                    txtstock_hay.ReadOnly = false;
                }
                txtunidades.Text = row.Cells[16].Value.ToString();


                panel_seleccionar_grupo.Visible = false;
                panel_productos.Visible = true;
              
            }
                 }
            catch (Exception ex)
            {
                MessageBox.Show( ex.StackTrace + ex.Message);
            }


          
        }
       
       

        private void dgv_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            proceso_para_obtener_datos_de_producto();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtfecha_vencimiento_ValueChanged(object sender, EventArgs e)
        {
          

        }

        private void lblfecha_Click(object sender, EventArgs e)
        {
            
        }

        private void rbpieza_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pbguardar_Click_1(object sender, EventArgs e)
        {
           
        }

        private void actualizarcambios_Click_1(object sender, EventArgs e)
        {

            double txtpreciomayoreoV = Convert.ToDouble(txt_mayoreo.Text);
            double txtapartirdeV = Convert.ToDouble(txtunidades.Text);
            double txtcostoV = Convert.ToDouble(txtprecio_compra.Text);
            double TXTPRECIODEVENTA2V = Convert.ToDouble(txt_precio_venta.Text);
            if (txt_mayoreo.Text == "") txt_mayoreo.Text = "0";
            if (txtunidades.Text == "") txtunidades.Text = "0";
            if ((txtpreciomayoreoV > 0 & Convert.ToDouble(txtunidades.Text) > 0) | (txtpreciomayoreoV == 0 & txtapartirdeV == 0))
            {
                if (txtcostoV >= TXTPRECIODEVENTA2V)
                {

                    DialogResult result;
                    result = MessageBox.Show("El precio de Venta es menor que el COSTO, Esto Te puede Generar Perdidas", "Producto con Perdidas", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        editar_productos();
                    }
                    else
                    {
                        txt_precio_venta.Focus();
                    }


                }
                else if (txtcostoV < TXTPRECIODEVENTA2V)
                {
                    editar_productos();
                }
            }
            else if (txtpreciomayoreoV != 0 | txtapartirdeV != 0)
            {
                MessageBox.Show("Estas configurando Precio mayoreo, debes completar los campos de Precio mayoreo y A partir de, si no deseas configurarlo dejalos en blanco", "Datos incompletos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
        }

        private void ms_guardarCambios_Click(object sender, EventArgs e)
        {

        }
        private void guardar_grupo()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insert_grupo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@grupo", txtgrupo.Text);
                cmd.Parameters.AddWithValue("@por_defecto", "no");
                cmd.ExecuteNonQuery();
                con.Close();
                mostrar_grupos();
                string idgrupo;

                idgrupo = dgv_grupos.SelectedCells[2].Value.ToString();
                txtgrupo.Text = dgv_grupos.SelectedCells[3].Value.ToString();

                panel_seleccionar_grupo.Visible = false;
                ms_guardarCambios.Visible = false;
                ms_guardarGrupo.Visible = false;
                ms_cancelar.Visible = false;
                ms_agregar_grupo.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ms_guardarGrupo_Click(object sender, EventArgs e)
        {
            guardar_grupo();
        }

        private void ms_cancelar_Click_1(object sender, EventArgs e)
        {
            panel_seleccionar_grupo.Visible = false;
            ms_guardarCambios.Visible = false;
            ms_guardarGrupo.Visible = false;
            ms_cancelar.Visible = false;
            ms_agregar_grupo.Visible = true;
            txtgrupo.Clear();
            mostrar_grupos();
        }

        private void ms_agregar_grupo_Click_1(object sender, EventArgs e)
        {
            txtgrupo.Text = "Escribe el nombre del nuevo grupo";
            txtgrupo.SelectAll();
            txtgrupo.Focus();
            panel_seleccionar_grupo.Visible = false;
            ms_guardarCambios.Visible = false;
            ms_guardarGrupo.Visible = true;
            ms_cancelar.Visible = true;

            ms_agregar_grupo.Visible = false;

        }

        private void generarCodigoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            generar_codigo_de_barras_automatico();
        }

        private void dgv_productos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgv_productos.Columns["eliminar"].Index)
            {
                DialogResult result;
                result = MessageBox.Show("¿Realmente quiere eliminar este producto?", "Eliminando productos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    SqlCommand cmd;
                    try
                    {
                        foreach (DataGridViewRow row in dgv_productos.SelectedCells)
                        {
                            
                            int onekey = Convert.ToInt32(row.Cells["id_producto"].Value);
                            
                            try
                            {
                                try
                                {
                                    SqlConnection con = new SqlConnection();
                                    con.ConnectionString = conexion.ConexionMaestra.conexion;
                                    con.Open();
                                    cmd = new SqlCommand("eliminar_producto", con);
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("@id_producto", onekey);
                                    cmd.ExecuteNonQuery();

                                    con.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show( ex.StackTrace + ex.Message);
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.StackTrace + ex.Message);
                            }

                        }
                        buscar();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.StackTrace + ex.Message);
                    }
                }

            }
            if (e.ColumnIndex == this.dgv_productos.Columns["editar"].Index)
            {
              
                proceso_para_obtener_datos_de_producto();
                
            }
        }

        private void dgv_productos_descripcion_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void dgv_productos_descripcion_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtdescripcion.Text = dgv_productos_descripcion.SelectedCells[0].Value.ToString();
                dgv_productos_descripcion.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_grupos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgv_grupos.Columns["eliminarG"].Index)
            {
                DialogResult result;
                result = MessageBox.Show("¿Realmente quiere eliminar este grupo", "Eliminando grupos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    SqlCommand cmd;
                    try
                    {
                        foreach (DataGridViewRow row in dgv_grupos.SelectedRows)
                        {
                            int onekey = Convert.ToInt32(row.Cells["Idline"].Value);

                            try
                            {
                                try
                                {
                                    SqlConnection con = new SqlConnection();
                                    con.ConnectionString = conexion.ConexionMaestra.conexion;
                                    con.Open();
                                    cmd = new SqlCommand("eliminar_grupos", con);
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("@id", onekey);
                                    cmd.ExecuteNonQuery();

                                    con.Close();
                                }
                                catch (Exception ex)
                                {

                                }

                            }
                            catch (Exception ex)
                            {

                            }

                        }
                        txtgrupo.Text = "general";
                        mostrar_grupos();
                        lblid_grupo.Text = dgv_grupos.SelectedCells[2].Value.ToString();
                        panel_seleccionar_grupo.Visible = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            if (e.ColumnIndex == this.dgv_grupos.Columns["editarG"].Index)
            {
                lblid_grupo.Text = dgv_grupos.SelectedCells[2].Value.ToString();
                txtgrupo.Text = dgv_grupos.SelectedCells[3].Value.ToString();
                panel_seleccionar_grupo.Visible = false;
                ms_guardarCambios.Visible = true;
                ms_guardarGrupo.Visible = false;
                ms_cancelar.Visible = true;
                ms_agregar_grupo.Visible = false;
            }
            if (e.ColumnIndex == this.dgv_grupos.Columns["Grupo"].Index)
            {
                lblid_grupo.Text = dgv_grupos.SelectedCells[2].Value.ToString();
                txtgrupo.Text = dgv_grupos.SelectedCells[3].Value.ToString();
                panel_seleccionar_grupo.Visible = false;
                ms_guardarCambios.Visible = false;
                ms_guardarGrupo.Visible = false;
                ms_cancelar.Visible = false;
                ms_agregar_grupo.Visible = true;
                if (lblestadocodigo.Text == "NUEVO")
                {
                    generar_codigo_de_barras_automatico();
                }
            }
        }

        private void cbinventario_CheckedChanged(object sender, EventArgs e)
        {
            if (id_producto!=0 & Convert.ToDouble(txtstock_hay.Text) > 0)
            {
                if (cbinventario.Checked == false)
                {
                    MessageBox.Show("Hay Aun En Stock, Dirijete al Modulo Inventarios para Ajustar el Inventario a cero", "Stock Existente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    PANELINVENTARIO.Visible = true;
                    cbinventario.Checked = true;
                }
            }

            if (id_producto!= 0 & Convert.ToDouble(txtstock_hay.Text) == 0)
            {
                if (cbinventario.Checked == false)
                {
                    PANELINVENTARIO.Visible = false;

                }
            }

            if (id_producto== 0)
            {
                if (cbinventario.Checked == false)
                {
                    PANELINVENTARIO.Visible = false;

                }
            }

            if (cbinventario.Checked == true)
            {

                PANELINVENTARIO.Visible = true;
            }
        }

        private void cb_no_aplica_fecha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pbguardar_Click_2(object sender, EventArgs e)
        {
            double txtpreciomayoreoV = Convert.ToDouble(txt_mayoreo.Text);
            double txtapartirdeV = Convert.ToDouble(txtunidades.Text);
            double txtcostoV = Convert.ToDouble(txtprecio_compra.Text);
            double TXTPRECIODEVENTA2V = Convert.ToDouble(txt_precio_venta.Text);
            if (txt_mayoreo.Text == "") txt_mayoreo.Text = "0";
            if (txtunidades.Text == "") txtunidades.Text = "0";
            if ((txtpreciomayoreoV > 0 & Convert.ToDouble(txtunidades.Text) > 0) | (txtpreciomayoreoV == 0 & txtapartirdeV == 0))
            {
                if (txtcostoV >= TXTPRECIODEVENTA2V)
                {

                    DialogResult result;
                    result = MessageBox.Show("El precio de Venta es menor que el COSTO, Esto Te puede Generar Perdidas", "Producto con Perdidas", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        insertar_productos();
                    }
                    else
                    {
                        txt_precio_venta.Focus();
                    }


                }
                else if (txtcostoV < TXTPRECIODEVENTA2V)
                {
                    insertar_productos();

                }
            }
            else if (txtpreciomayoreoV != 0 | txtapartirdeV != 0)
            {
                MessageBox.Show("Estas configurando Precio mayoreo, debes completar los campos de Precio mayoreo y A partir de, si no deseas configurarlo dejalos en blanco", "Datos incompletos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
        }

        private void actualizarcambios_Click_2(object sender, EventArgs e)
        {
            double txtpreciomayoreoV = Convert.ToDouble(txt_mayoreo.Text);
            double txtapartirdeV = Convert.ToDouble(txtunidades.Text);
            double txtcostoV = Convert.ToDouble(txtprecio_compra.Text);
            double TXTPRECIODEVENTA2V = Convert.ToDouble(txt_precio_venta.Text);
            if (txt_mayoreo.Text == "") txt_mayoreo.Text = "0";
            if (txtunidades.Text == "") txtunidades.Text = "0";
            if ((txtpreciomayoreoV > 0 & Convert.ToDouble(txtunidades.Text) > 0) | (txtpreciomayoreoV == 0 & txtapartirdeV == 0))
            {
                if (txtcostoV >= TXTPRECIODEVENTA2V)
                {

                    DialogResult result;
                    result = MessageBox.Show("El precio de Venta es menor que el COSTO, Esto Te puede Generar Perdidas", "Producto con Perdidas", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        editar_productos();
                    }
                    else
                    {
                        txt_precio_venta.Focus();
                    }


                }
                else if (txtcostoV < TXTPRECIODEVENTA2V)
                {
                    editar_productos();
                }
            }
            else if (txtpreciomayoreoV != 0 | txtapartirdeV != 0)
            {
                MessageBox.Show("Estas configurando Precio mayoreo, debes completar los campos de Precio mayoreo y A partir de, si no deseas configurarlo dejalos en blanco", "Datos incompletos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
        }

        private void dgv_productos_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void dgv_productos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel_productos_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dgv_productos_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            proceso_para_obtener_datos_de_producto();
        }

        private void importarDesdeEXCElToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presentacion.productos.asistente_de_importacion_productos_e frm = new asistente_de_importacion_productos_e();
            frm.ShowDialog();
        }
    }
}
