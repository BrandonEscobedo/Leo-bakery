using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Management;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA.presentacion
{
    public partial class login : Form
    {
        public static string loginid;
        public static string importe;
        int contar_usuarios;
        string indicador;
        int contador;
        int contador_cajas;
        int contar_mostrar_movimientos_caja_por_serial_y_usuario;
        public static int idusuariovariable;
        public static int idcajavariable;
        public static string nombre_usuario;
        string serial_caja;
        String indicador_apertura;
        String cajero = "Cajero";
        String admin = "Administrador";
        int id_usuario_verificar;
        String rol_usuario_is;
        String nombre_cajero;
        string rol_usuario;
        int id_usuario_is_aperturado;
        String contra;
        String ip_ob;
        String usuario_ic;
        public login()
        {
            InitializeComponent();
        }
        public void imagen_usarios()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("select * from usuarios where Estado='Activo'", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Label l = new Label();
                    Panel p = new Panel();
                    PictureBox pb = new PictureBox();
                    l.Text = sdr["login"].ToString();
                    l.Name = sdr["IDusuarios"].ToString();
                    l.Size = new System.Drawing.Size(175, 25);
                    l.Font = new System.Drawing.Font("Microsoft Sans serif", 13);
                    l.BackColor = Color.FromArgb(20, 20, 20);
                    l.ForeColor = Color.White;
                    l.Dock = DockStyle.Bottom;
                    l.TextAlign = ContentAlignment.MiddleCenter;
                    l.Cursor = Cursors.Hand;
                    p.Size = new System.Drawing.Size(155, 167);
                    p.BorderStyle = BorderStyle.None;
                    p.BackColor = Color.FromArgb(20, 20, 20);
                    pb.Size = new System.Drawing.Size(175, 132);
                    pb.Dock = DockStyle.Top;
                    pb.BackgroundImage = null;
                    byte[] b = (byte[])sdr["icono"];
                    MemoryStream ms = new MemoryStream(b);
                    pb.Image = Image.FromStream(ms);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Tag = sdr["login"].ToString();
                    pb.Cursor = Cursors.Hand;
                    p.Controls.Add(l);
                    p.Controls.Add(pb);
                    l.BringToFront();
                    flowLayoutPanel1.Controls.Add(p);
                    l.Click += new EventHandler(event_label_password);
                    pb.Click += new EventHandler(event_pb_password);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                
            }
        }

        private void mostrar_rol_usuarios()
        {
        
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion.ConexionMaestra.conexion;
            SqlCommand com = new SqlCommand("mostrar_permisos_por_usuario_rol", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_usuario",idusuariovariable);
            try
            {
                con.Open();
                rol_usuario = Convert.ToString(com.ExecuteScalar());
              
                con.Close();
            }
            catch (Exception ex)
            {
                

            }


        }
        private void event_pb_password(System.Object sender, EventArgs e)
        {
            rol_usuario_is =Convert.ToString( ((PictureBox)sender).Tag.ToString());
            panel_login.Visible = true;
            panel_usuarios.Visible = false;
        

        }
        private void event_label_password(System.Object sender, EventArgs e)
        {
            rol_usuario_is = ((Label)sender).Text;
            panel_login.Visible = true;
            panel_usuarios.Visible = false;
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mostrar_usuarios_registrado()
        {
            try
            {
               
                conexion.ConexionMaestra.abrir_conexion();
                SqlCommand cmd = new SqlCommand("select IDusuarios from usuarios", conexion.ConexionMaestra.conectar);
                id_usuario_verificar = Convert  .ToInt32( cmd.ExecuteScalar());
                conexion.ConexionMaestra.cerrar_conexion();
                indicador = "correcto";
            }
            catch (Exception ex)
            {
                indicador = "incorrecto";
                id_usuario_verificar = 0;
            }
        }
        private void login_Load(object sender, EventArgs e)
        {         
           panel_login.Visible = false;
            validar_inicio();     
            panel_usuarios.Location = new Point((Width - panel_usuarios.Width) / 2, (Height - panel_usuarios.Height) / 2);
            panel_login.Location = new Point((Width - panel_login.Width) / 2, (Height - panel_login.Height) / 2);
            obtener_ip();
        }
        private void obtener_ip()
        {
          
            negocio.procedimientos_necesarios.obtener_ip(ref ip_ob);
          

        }
        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
                da.SelectCommand.Parameters.AddWithValue("@serial", serial_caja);
                da.Fill(dt);
                contador_cajas = dt.Rows.Count;
                usuario_ic= dt.Rows[0]["login"].ToString();
                nombre_cajero = dt.Rows[0]["nombres_apellidos"].ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                
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
                

            }
        }
        
        private void txt_login_password_TextChanged(object sender, EventArgs e)
        {
            iniciar_sesion();


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
                da.SelectCommand.Parameters.AddWithValue("@serial", serial_caja);
                da.SelectCommand.Parameters.AddWithValue("@idusuario", idusuariovariable);
                da.Fill(dt);
                contar_mostrar_movimientos_caja_por_serial_y_usuario = dt.Rows.Count;            
                con.Close();
            }
            catch (Exception ex)
            {
                
            }
        }
        private void validar_rol_para_iniciar_caja()
        {
            listar_aperturas_detalles_cierre_de_caja();
            if (contador_cajas == 0)
            {
                aperturar_detalle_de_cierre_caja();
                indicador_apertura = "nuevo inicio";
                iniciar_sesion_();           
            }
            else
          {
            mostrar_movimientos_caja_por_serial_y_usuario();
  
                try
                {
                    if (contar_mostrar_movimientos_caja_por_serial_y_usuario == 0)
                    {                                              
                        MessageBox.Show("Para poder continuar con el Turno de *" + nombre_cajero + "* ,Inicia sesion con el Usuario " +
                       usuario_ic + " o el Usuario Administrador", "Caja Iniciada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        indicador_apertura = "Aperturado";
                        iniciar_sesion_();                       
                    }
                }
                catch (Exception ex)
                {
                    
                }
          }          
        }
        private void iniciar_sesion()
        {
            cargar_usuarios();
            
            mostrar_usuarios_registrado();
           if (contador > 0)            
            {
                mostrar_id_usuario();
                mostrar_rol_usuarios();

                if (rol_usuario == admin)
                 {
                iniciar_sesion_();
                  
                   }
                else if (rol_usuario ==cajero)
                {
                    validar_rol_para_iniciar_caja();
                }
            }
        }
        private void mostrar_id_usuario()
        {
            try
            {
                DataTable md = new DataTable();
                SqlDataAdapter datos;
                conexion.ConexionMaestra.abrir_conexion();
                SqlCommand cmd = new SqlCommand();
                datos = new SqlDataAdapter("validar_usario", conexion.ConexionMaestra.conectar);
                datos.SelectCommand.CommandType = CommandType.StoredProcedure;
                datos.SelectCommand.Parameters.AddWithValue("@password", conexion.encriptar_en_texto.Encriptar(txt_login_password.Text));
                datos.SelectCommand.Parameters.AddWithValue("@login", rol_usuario_is);
                datos.Fill(md);        
                idusuariovariable = Convert.ToInt32(md.Rows[0]["IDusuarios"].ToString());
        
                conexion.ConexionMaestra.cerrar_conexion();
            }
            catch (Exception ex)
            {            
            }
        }
        private void cargar_usuarios()
        {
            try
            {
                DataTable md = new DataTable();
                SqlDataAdapter datos;
                conexion.ConexionMaestra.abrir_conexion();
                SqlCommand cmd = new SqlCommand();
                datos = new SqlDataAdapter("validar_usario", conexion.ConexionMaestra.conectar);
                datos.SelectCommand.CommandType = CommandType.StoredProcedure;
                datos.SelectCommand.Parameters.AddWithValue("@password", conexion.encriptar_en_texto.Encriptar(txt_login_password.Text));
                datos.SelectCommand.Parameters.AddWithValue("@login", rol_usuario_is);
                datos.Fill(md);       
                contador = md.Rows.Count;              
                conexion.ConexionMaestra.cerrar_conexion();
            }
            catch (Exception ex)
            {          
            }

        }
        private void dgv_listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            txt_login_password.PasswordChar = '\0';
            btn_no_ver.Visible = true;
            btn_ver.Visible = false;
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
        private void mostrar_caja_por_serial()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("mostrar_cajas_por_serial_de_discoDuro", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@serial", serial_caja);
                da.Fill(dt);
                idcajavariable =Convert.ToInt32( dt.Rows[0]["id_caja"].ToString());
                serial_caja = dt.Rows[0]["serial_pc"].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                
            }
        }
        private void validar_inicio()
        {
            mostrar_usuarios_registrado();

            if (indicador == "correcto")
            {

                if (id_usuario_verificar == 0)
                {
                   Dispose();
                   asistente_de_instalacion_servidor.registro_de_empresa frm = new presentacion.asistente_de_instalacion_servidor.registro_de_empresa();
                    frm.ShowDialog();
                   
                }
                else
                {
                    imagen_usarios();
                }
            }
            if (indicador == "incorrecto")
            {
                Dispose();
                presentacion.asistente_de_instalacion_servidor.e_servidor_remoto frm = new presentacion.asistente_de_instalacion_servidor.e_servidor_remoto();
                frm.ShowDialog();
                
            }
                negocio.procedimientos_necesarios.obtener_serial(ref serial_caja);
                mostrar_caja_por_serial();                                           
        }    
        private void btn_num0_Click_1(object sender, EventArgs e)
        {
            txt_login_password.Text = txt_login_password.Text + "0";
        }
        private void btn_num1_Click_1(object sender, EventArgs e)
        {
            txt_login_password.Text = txt_login_password.Text + "1";
        }
        private void btn_num2_Click_1(object sender, EventArgs e)
        {
            txt_login_password.Text = txt_login_password.Text + "2";
        }
        private void btn_num3_Click(object sender, EventArgs e)
        {
            txt_login_password.Text = txt_login_password.Text + "3";
        }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void btn_num4_Click_1(object sender, EventArgs e)
        {
            txt_login_password.Text = txt_login_password.Text + "4";
        }
        private void btn_num5_Click_1(object sender, EventArgs e)
        {
            txt_login_password.Text = txt_login_password.Text + "5";
        }

        private void btn_num6_Click_1(object sender, EventArgs e)
        {
            txt_login_password.Text = txt_login_password.Text + "6";
        }
        private void btn_num7_Click_1(object sender, EventArgs e)
        {
            txt_login_password.Text = txt_login_password.Text + "7";
        }
        private void btn_num8_Click_1(object sender, EventArgs e)
        {
            txt_login_password.Text = txt_login_password.Text + "8";
        }
        private void btn_num9_Click_1(object sender, EventArgs e)
        {
            txt_login_password.Text = txt_login_password.Text + "9";
        }
        private void btn_borrar_todo_Click_1(object sender, EventArgs e)
        {
            txt_login_password.Clear();
        }
        public static string Mid(string param, int startIndex, int v)
        {
            string result = param.Substring(startIndex);
            return result;
       }
        private void btn_borrar_caracter_Click_1(object sender, EventArgs e)
        {
            try
            {
                int largo;
                if (txt_login_password.Text != "")
                {
                    largo = txt_login_password.Text.Length;
                    txt_login_password.Text = Mid(txt_login_password.Text, 1, largo - 1);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_no_ver_Click_1(object sender, EventArgs e)
        {
            txt_login_password.PasswordChar = '*';
            btn_no_ver.Visible = false;
            btn_ver.Visible = true;
        }

        private void btninicar_sesion_Click_1(object sender, EventArgs e)
        {
            iniciar_sesion();
            if (txt_login_password.Text != contra) { MessageBox.Show("Usuario o contraseña incorrectos", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
           
        }

        private void lblserial1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void editar_inicio_sesion()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("editar_inicio_sesion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@serial_pc", serial_caja);
                cmd.Parameters.AddWithValue("@id_usuario", idusuariovariable);          
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                
            }
        }
        private void iniciar_sesion_()
        {              
                if (rol_usuario_is ==admin)
                {
                editar_inicio_sesion();
                Dispose();             
                presentacion.form_cargando.formulario_cargando frm2 = new presentacion.form_cargando.formulario_cargando();
                frm2.ShowDialog();
                Dispose();
                presentacion.control_negocio.pantalla_principal_admin frm = new presentacion.control_negocio.pantalla_principal_admin();
                    frm.ShowDialog(); 
              
                }       
                   else if (indicador_apertura == "nuevo inicio" )
                    {
                       editar_inicio_sesion();   
                         Dispose();
                       presentacion.form_cargando.formulario_cargando frm2 = new presentacion.form_cargando.formulario_cargando();
                       frm2.ShowDialog();
                Dispose();
                caja.apertura_de_caja frm = new caja.apertura_de_caja();
                       frm.ShowDialog();
                      
                    }
                    else if (indicador_apertura == "Aperturado" & rol_usuario == cajero)
                            {
                       editar_inicio_sesion();
                         Dispose();
                       presentacion.Menu_principal.menu_principal frm = new presentacion.Menu_principal.menu_principal();
                       frm.ShowDialog();         
                            }                   
        }
       
        private void pb_cargando_Click(object sender, EventArgs e)
        {

        }

        private void panel_login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pb_cargando_Click_1(object sender, EventArgs e)
        {

        }

        private void panel_usuarios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_login_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pb_cargando_Click_2(object sender, EventArgs e)
        {

        }

        private void btn_cambiar_usuario_Click_1(object sender, EventArgs e)
        {
            panel_login.Visible = false;      
            panel_usuarios.Visible = true;
            txt_login_password.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_login_password_TextChanged_1(object sender, EventArgs e)
        {
            iniciar_sesion();
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {

            txt_login_password.PasswordChar = '\0';
            btn_no_ver.Visible = true;
            btn_ver.Visible = false;
        }

        private void btn_borrar_todo_Click(object sender, EventArgs e)
        {
            txt_login_password.Clear();
        }

      
    }
}
