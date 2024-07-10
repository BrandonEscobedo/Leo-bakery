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
using System.Management;
using PUNTO_DE_VENTA.datos;
using FontAwesome.Sharp;
using System.Collections;
namespace PUNTO_DE_VENTA.presentacion.control_negocio
{
    public partial class pantalla_principal_admin : Form
    {

        private IconButton btn_icon;
        private Panel pan_btn;
        private Form actual_form_hijo ;
        DataTable dtventas;
        DataTable dtproductos;
        double monto_tventas;
        double gananciast;
        public pantalla_principal_admin()
        {
            InitializeComponent();
            pan_btn = new Panel();
            pan_btn.Size = new  Size(10, 60);
            panel_menu.Controls.Add(pan_btn);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
           private void activar_boton(object senderbtn, Color color)
        {
            desactivar_boton();
            if (senderbtn!= null)
            {
                btn_icon = (IconButton)senderbtn;
                btn_icon.BackColor = Color.FromArgb(20, 26, 71);
                btn_icon.ForeColor = Color.White ;
                btn_icon.TextAlign = ContentAlignment.MiddleCenter;
                btn_icon.IconColor = color;
                btn_icon.TextImageRelation = TextImageRelation.TextBeforeImage;
                btn_icon.ImageAlign = ContentAlignment.MiddleRight;
                pan_btn.BackColor = color;
                pan_btn.Location =new Point (0, btn_icon.Location.Y);
                pan_btn.Visible = true;
                pan_btn.BringToFront();
                ic_picture.IconChar = btn_icon.IconChar;
            }
        }
        private void abrir_form_hijo(Form form_hijo)
        {
            if (actual_form_hijo != null)
            {
                actual_form_hijo.Close();
                
            }
            actual_form_hijo = form_hijo;
            form_hijo.TopLevel = false;
            form_hijo.FormBorderStyle = FormBorderStyle.None;
            form_hijo.Dock = DockStyle.None;
            panel_form.Controls.Add(form_hijo);
            panel_form.Tag = form_hijo;
            form_hijo.BringToFront();
            form_hijo.Show();
            lbl_titulo.Text = form_hijo.Text;
        }
        private void desactivar_boton()
        {
            if (btn_icon != null)
            {
                btn_icon.BackColor = Color.FromArgb(22, 21, 33);
                btn_icon.ForeColor =Color.FromArgb(199, 0, 57);
                btn_icon.TextAlign = ContentAlignment.MiddleLeft;
                btn_icon.IconColor = Color.FromArgb(199, 0, 57);
                btn_icon.TextImageRelation = TextImageRelation.ImageBeforeText;
                btn_icon.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
   
        private struct MyStruct
        {

        }
        int contador_cajas;
        string serial_pc;
          int idusuariovariable;
          int idcajavariable;  
        int contar_mostrar_movimientos_caja_por_serial_y_usuario;
        String nombre_cajero;
        String indicador_apertura;
        String rol_usuario_is;
 
        private void btn_pantalla_ventas_Click(object sender, EventArgs e)
        {
            validar_rol_para_iniciar_caja();
        }
        private void pantalla_principal_admin_Load(object sender, EventArgs e)
        {
            negocio.procedimientos_necesarios.obtener_serial(ref serial_pc);
            datos.procedimientos_reutilizables.obtener_id_caja(ref idcajavariable);
            procedimientos_reutilizables.mostrar_inicio_sesion(ref idusuariovariable);
            mostrar_venta_grafico();
            total_ventas();
            mostrar_productos_mv();
            mostrar_productos_bajos();
            cb_filtros.Checked = false;

        }

        private void mostrar_venta_grafico()
        {
            ArrayList fecha = new ArrayList();
            ArrayList monto = new ArrayList();
            dtventas = new DataTable();
            insertar.mostrar_ventas_para_grafico(ref dtventas);
            foreach (DataRow row in dtventas.Rows)
            {
                fecha.Add(row["fecha"]);
                monto.Add(row["total"]);
            }
            chart_ventas.Series[0].Points.DataBindXY(fecha, monto);

        }
        private void mostrar_productos_mv()
        {
            ArrayList cantidad = new ArrayList();
            ArrayList producto = new ArrayList();
            dtproductos = new DataTable();
            insertar.productos_mas_vendidos(ref dtproductos);
            foreach (DataRow row in dtproductos.Rows)
            {
                cantidad.Add(row["cantidad"]);
                producto.Add(row["descripcion"]);
            }
            chart_productos_mv.Series[0].Points.DataBindXY(producto, cantidad);

        }
        private void mostrar_productos_bajos()
        {
            DataTable table = new DataTable();
            datos.insertar.productos_stock_bajos(ref table);
            dgv_productos_stock.DataSource = table;
        }
        private void mostrar_ventas_graficos_parametros()
        {
            ArrayList fecha = new ArrayList();
            ArrayList monto = new ArrayList();
            dtventas = new DataTable();
            insertar.mostrar_ventas_para_grafico_parametros(ref dtventas,dt_fi.Value,dt_ff.Value);
            foreach (DataRow row in dtventas.Rows)
            {
                fecha.Add(row["fecha"]);
                monto.Add(row["total"]);
            }
            chart_ventas.Series[0].Points.DataBindXY(fecha, monto);
            total_ventas_parametros();
            total_ganancias_parametros();
        }
        private void total_ventas()
        {
            insertar.total_ventas(ref monto_tventas);
            lbl_tventas.Text = monto_tventas.ToString();

        }
        private void total_ventas_parametros()
        {
            insertar.total_ventas_parametros(ref monto_tventas,dt_fi.Value,dt_ff.Value);
            lbl_tventas.Text = monto_tventas.ToString();
         
        }
        private void total_ganancias_parametros()
        {
            insertar.total_ventas_parametros(ref gananciast, dt_fi.Value, dt_ff.Value);
            lbl_tganancias.Text = monto_tventas.ToString();
         
        }


        private void listar_aperturas_detalles_cierre_de_caja()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("mostrar_movimientos_de_caja_por_serial", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@serial", serial_pc);
                da.Fill(dt);      
                contador_cajas = dt.Rows.Count;
                if (dt.Rows.Count > 0)
                {
                    rol_usuario_is = dt.Rows[0]["login"].ToString();
                    nombre_cajero = dt.Rows[0]["nombres_apellidos"].ToString();
                }
               
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void aperturar_detalle_de_cierre_caja()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_detalle_cierre_de_caja", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha_inicio", DateTime.Now);
                cmd.Parameters.AddWithValue("@fecha_fin", DateTime.Now);
                cmd.Parameters.AddWithValue("@fecha_cierre", DateTime.Now);
                cmd.Parameters.AddWithValue("@ingresos", "0.00");
                cmd.Parameters.AddWithValue("@egresos", "0.00");
                cmd.Parameters.AddWithValue("@saldo_en_caja", "0.00");
                cmd.Parameters.AddWithValue("@id_usuario", idusuariovariable);
                cmd.Parameters.AddWithValue("@total_calculado", "0.00");
                cmd.Parameters.AddWithValue("@total_real", "0.00");
                cmd.Parameters.AddWithValue("@Estado", "Caja Aperturada");
                cmd.Parameters.AddWithValue("@diferencia", "0.00");
                cmd.Parameters.AddWithValue("@id_caja", idcajavariable);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }
        private void mostrar_movimientos_caja_por_serial_y_usuario()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("mostrar_movimientos_caja_por_serial_y_usuario", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@serial", serial_pc);
                da.SelectCommand.Parameters.AddWithValue("@idusuario", idusuariovariable);
                da.Fill(dt);
                contar_mostrar_movimientos_caja_por_serial_y_usuario = dt.Rows.Count;
              
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void validar_rol_para_iniciar_caja()
        {
            listar_aperturas_detalles_cierre_de_caja();
          
            if (contador_cajas == 0 )
            {
                aperturar_detalle_de_cierre_caja();
                indicador_apertura = "nuevo inicio";
                ingresar_a_menu_ventas();
            }
            else
            {
                mostrar_movimientos_caja_por_serial_y_usuario();
             
                    if (contar_mostrar_movimientos_caja_por_serial_y_usuario == 0)
                    {
                        MessageBox.Show("Vas a continuar con el usuario: " + nombre_cajero + " todos las ventas seran registradas con este usuario ",
                        "Caja Iniciada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                                     
                        indicador_apertura = "Aperturado";
                        ingresar_a_menu_ventas();                   
                
            }
        }
        private void ingresar_a_menu_ventas()
        {
             if (indicador_apertura == "nuevo inicio")
            {
           
                Dispose();
                caja.apertura_de_caja frm = new caja.apertura_de_caja();
                frm.ShowDialog();

            }
            else if (indicador_apertura == "Aperturado")
            {
                Dispose();
                presentacion.Menu_principal.menu_principal frm = new presentacion.Menu_principal.menu_principal();
                frm.ShowDialog();
            }
        }
  

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
            configuracion.form_configuraciones frm = new configuracion.form_configuraciones();
            frm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            activar_boton(sender, Color.FromArgb(55, 88, 122));
            if (actual_form_hijo != null)
            {
                actual_form_hijo.Close();
            }
          

        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            activar_boton(sender, Color.FromArgb(55, 88, 122));
            abrir_form_hijo(new clientes_y_proveedores.clientes());

        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            activar_boton(sender, Color.FromArgb(55, 88, 122));
            abrir_form_hijo(new usuarios());
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            activar_boton(sender, Color.FromArgb(55, 88, 122));
            abrir_form_hijo(new inventario_kardex.inventario_menu());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            activar_boton(sender, Color.FromArgb(55, 88, 122));
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            activar_boton(sender, Color.FromArgb(55, 88, 122));
        }

        private void btn_productos_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_produc_Click(object sender, EventArgs e)
        {
            activar_boton(sender, Color.FromArgb(55, 88, 122));
            abrir_form_hijo(new productos.productos());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            activar_boton(sender, Color.FromArgb(55, 88, 122));
            DialogResult dl;
            dl = MessageBox.Show("¿Estas seguro abrir caja para vender?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if(dl == DialogResult.OK)
            {

                validar_rol_para_iniciar_caja();

            }
        }

        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            activar_boton(sender, Color.FromArgb(55, 88, 122));
            configuracion.form_configuraciones frm = new configuracion.form_configuraciones();
            frm.ShowDialog();
        }

        private void cb_filtros_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_filtros.Checked == true)
            {
                panel_filtros.Visible = true;
                mostrar_ventas_graficos_parametros();
            }
            else
            {
                panel_filtros.Visible = false;
                mostrar_venta_grafico();
            }
        }

        private void dt_fi_ValueChanged(object sender, EventArgs e)
        {
            mostrar_ventas_graficos_parametros();
        }

        private void dt_ff_ValueChanged(object sender, EventArgs e)
        {
            mostrar_ventas_graficos_parametros();
        }

        private void btn_actual_Click(object sender, EventArgs e)
        {
            mostrar_venta_grafico();
            total_ventas();
        }

        private void chart_productos_mv_Click(object sender, EventArgs e)
        {

        }
    }
}
