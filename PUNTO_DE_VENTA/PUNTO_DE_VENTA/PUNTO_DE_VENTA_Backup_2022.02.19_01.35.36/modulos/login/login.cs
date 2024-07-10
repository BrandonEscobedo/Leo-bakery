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
using System.IO;
using System.Text.RegularExpressions;
using System.Management;
using System.Management.Instrumentation;

namespace PUNTO_DE_VENTA.modulos
{
    public partial class login : Form
    {
        int contador;
        int contador_cajas;
        int contar_mostrar_movimientos_caja_por_serial_y_usuario;
        public static String idusuariovariable;
        public static String idcajavariable;
        public login()
        {
            InitializeComponent();
        }
        public void imagen_usarios()
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
                Panel p=new Panel();
                PictureBox pb = new PictureBox();
                
                l.Text=sdr["login"].ToString();
           
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

                pb.Size = new System.Drawing.Size(175,132);
                pb.Dock = DockStyle.Top;
                pb.BackgroundImage = null;
                byte[] b =  (byte []) sdr["icono"];
                MemoryStream ms = new MemoryStream(b);
                pb.Image= Image.FromStream(ms);
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
        private void mostrar_permisos()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion.ConexionMaestra.conexion;

            SqlCommand com = new SqlCommand("mostrar_permisos_por_usuario_rol", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@login", lbl_login.Text);
            string importe;
            try
            {
                con.Open();
                importe = Convert.ToString(com.ExecuteScalar());
                con.Close();
                lblrol.Text = importe;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        private void event_pb_password(System.Object sender, EventArgs e)
        {
            lbl_login.Text = ((PictureBox)sender).Tag.ToString();
            panel_login.Visible = true;
            panel_usuarios.Visible = false;
            mostrar_permisos();

        }
        private void event_label_password(System.Object sender, EventArgs e)
        {
            lbl_login.Text = ((Label)sender).Text;
            panel_login.Visible = true;
            panel_usuarios.Visible = false;
            mostrar_permisos();

        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
             imagen_usarios();
            panel_login.Visible = false;
            timer1.Start();
            pb_cargando.Visible = false;    
            dgv1.Visible = true;
            pb_cargando.Location = new Point(( Width - pb_cargando.Width )/ 2, (Height - pb_cargando.Height) / 2);
         
            panel_usuarios.Location = new Point((Width - panel_usuarios.Width) / 2, (Height - panel_usuarios.Height) / 2);
            panel_login.Location = new Point((Width - panel_login.Width) / 2, (Height - panel_login.Height) / 2);
        }
       
        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void conteo_apertura_detalle_cierres_caja()
        {
            int contar;
            contar = dgv2.Rows.Count;

            contador_cajas = (contar);

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
                da.SelectCommand.Parameters.AddWithValue("@serial", lblserialcaja.Text);
                da.Fill(dt);
                dgv2.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                cmd = new SqlCommand("insertar_detalle_cierre_de_caja",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha_inicio", DateTime.Today);
                cmd.Parameters.AddWithValue("@fecha_fin", DateTime.Today);
                cmd.Parameters.AddWithValue("@fecha_cierre", DateTime.Today);
                cmd.Parameters.AddWithValue("@ingresos", "0.00");
                cmd.Parameters.AddWithValue("@egresos", "0.00");
                cmd.Parameters.AddWithValue("@saldo_en_caja", "0.00");
                cmd.Parameters.AddWithValue("@id_usuario", lbl_id_usuario.Text);
                cmd.Parameters.AddWithValue("@total_calculado", "0.00");
                cmd.Parameters.AddWithValue("@total_real", "0.00");
                cmd.Parameters.AddWithValue("@Estado", "Caja Aperturada");
                cmd.Parameters.AddWithValue("@diferencia", "0.00");
                cmd.Parameters.AddWithValue("@id_caja",lblidcaja.Text );         
                cmd.ExecuteNonQuery();
                con.Close();

             

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void txt_login_password_TextChanged(object sender, EventArgs e)
        {
            iniciar_sesion();
          
           
        }
        private void conteo_mostrar_movimientos_caja_por_serial_y_usuario()
        {
            int contar;
            contar = dgv_validar_movimientos.Rows.Count;
            contar_mostrar_movimientos_caja_por_serial_y_usuario = (contar);

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
                da.SelectCommand.Parameters.AddWithValue("@serial", lblserialcaja.Text);
                da.SelectCommand.Parameters.AddWithValue("@idusuario", lbl_id_usuario.Text);
                da.Fill(dt);
                dgv_validar_movimientos.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void iniciar_sesion()
        {
            cargar_usuarios();
            conteo_usuarios();

            try
            {
                if (dgv_listado.Rows.Count >=1 )
                { 
                lbl_id_usuario.Text = dgv_listado.SelectedCells[0].Value.ToString();
                lblnombre.Text = dgv_listado.SelectedCells[1].Value.ToString();
                    idusuariovariable = lbl_id_usuario.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (contador > 0)
            {

                listar_aperturas_detalles_cierre_de_caja();
                conteo_apertura_detalle_cierres_caja();

                if (contador_cajas ==0 & lblrol.Text != "Repartidor" )
                {
                    aperturar_detalle_de_cierre_caja();
                    lblapertura_de_caja.Text = "nuevo*****";
                    timer_cargando.Start();
                }
                else
                {
                    if  (lblrol.Text != "Repartidor")
                        {
                        mostrar_movimientos_caja_por_serial_y_usuario();
                        conteo_mostrar_movimientos_caja_por_serial_y_usuario();
                        try
                        {
                            
                                lbl_usuario_inicio_caja.Text = dgv2.SelectedCells[1].Value.ToString();
                                lblnombre_cajero.Text = dgv2.SelectedCells[2].Value.ToString();
                            
                        }
                        catch (Exception ex)
                        {
                           
                        }
                        if (contar_mostrar_movimientos_caja_por_serial_y_usuario == 0)
                        {
                           
                            if (lbl_usuario_inicio_caja.Text != "Administrador" & lbl_login.Text == "Administrador")
                            {
                                MessageBox.Show("Continuaras Turno de *" + lblnombre_cajero.Text + " Todos los Registros seran con ese Usuario", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                lblpermiso_caja.Text = "correcto";
                            }
                            if (lbl_usuario_inicio_caja.Text == "Administrador" & lbl_login.Text == "Administrador")
                            {

                                lblpermiso_caja.Text = "correcto";
                            }
                           
                            else if (lbl_usuario_inicio_caja.Text != lbl_login.Text & lbl_login.Text != "Administrador")
                            {
                                MessageBox.Show("Para poder continuar con el Turno de *" + lblnombre_cajero.Text + "* ,Inicia sesion con el Usuario " + lbl_usuario_inicio_caja.Text + " -ó-el Usuario *Administrador*", "Caja Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                lblpermiso_caja.Text = "vacio";

                            }
                            else if (lbl_usuario_inicio_caja.Text == lbl_login.Text)
                            {
                                lblpermiso_caja.Text = "correcto";
                            }
                        }
                        else
                        {
                            lblpermiso_caja.Text = "correcto";
                        }

                        if (lblpermiso_caja.Text=="correcto")
                        {
                            lblapertura_de_caja.Text = "Aperturado";
                            timer_cargando.Start();

                        }

                    }
                    else
                    {
                        timer_cargando.Start();
                    }
                   
                }
            }
        }
       

        private void conteo_usuarios()
        {
            int contar;
            contar = dgv_listado.Rows.Count;
            contador = (contar);
            
        }
        private void cargar_usuarios()
        {
            try
            {
                DataTable md = new DataTable();
                SqlDataAdapter datos;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                datos = new SqlDataAdapter("validar_usario", con);
                datos.SelectCommand.CommandType = CommandType.StoredProcedure;
                datos.SelectCommand.Parameters.AddWithValue("@password", txt_login_password.Text);
                datos.SelectCommand.Parameters.AddWithValue("@login",  lbl_login.Text);

                datos.Fill(md);
                dgv_listado.DataSource = md;
                con.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

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
        private void mostrar_caja_por_sereal()
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
                da.SelectCommand.Parameters.AddWithValue("@serial", lblserialcaja.Text);
                da.Fill(dt);
                dgv1.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ola()
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            try
            {
                string HDD = System.Environment.CurrentDirectory.Substring(0, 1);
                ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + HDD + ":\"");
                disk.Get();
                lblserialcaja.Text= disk["VolumeSerialNumber"].ToString();
                mostrar_caja_por_sereal();
                try
                {

                    
                        lblidcaja.Text = dgv1.SelectedCells[0].Value.ToString();
                        lblserialcaja.Text = dgv1.SelectedCells[2].Value.ToString();
                    idcajavariable = lblidcaja.Text;



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
          
        }

        private void btn_num0_Click(object sender, EventArgs e)
        {
            txt_login_password.Text = txt_login_password.Text + "0";
        }

        private void btn_num1_Click(object sender, EventArgs e)
        {
            txt_login_password.Text = txt_login_password.Text + "1";
        }

        private void btn_num2_Click(object sender, EventArgs e)
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

        private void btn_num4_Click(object sender, EventArgs e)
        {
            txt_login_password.Text = txt_login_password.Text + "4";
        }

        private void btn_num5_Click(object sender, EventArgs e)
        {
            txt_login_password.Text = txt_login_password.Text + "5";
        }

        private void btn_num6_Click(object sender, EventArgs e)
        {
            txt_login_password.Text = txt_login_password.Text + "6";
        }

        private void btn_num7_Click(object sender, EventArgs e)
        {
            txt_login_password.Text = txt_login_password.Text + "7";
        }

        private void btn_num8_Click(object sender, EventArgs e)
        {
            txt_login_password.Text = txt_login_password.Text + "8";
        }

        private void btn_num9_Click(object sender, EventArgs e)
        {
            txt_login_password.Text = txt_login_password.Text + "9";
        }

        private void btn_borrar_todo_Click(object sender, EventArgs e)
        {
            txt_login_password.Clear();
        }
        public static string Mid(string param, int startIndex, int v)
        {
            string result = param.Substring(startIndex);
            return result;

        }
        private void btn_borrar_caracter_Click(object sender, EventArgs e)
        {
            try
            {
                int largo;
                    if (txt_login_password.Text !="")
                {
                    largo = txt_login_password.Text.Length;
                    txt_login_password.Text = Mid(txt_login_password.Text, 1, largo - 1);
                }
            }
                catch (Exception ex)
            {

            }
                }

        private void btn_no_ver_Click(object sender, EventArgs e)
        {
            txt_login_password.PasswordChar = '*';
            btn_no_ver.Visible = false;
            btn_ver.Visible = true;
        }

        private void btninicar_sesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario o contraseña incorrectos", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void lblserial1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_cargando_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {  
            progressBar1.Value = progressBar1.Value + 10;
            pb_cargando.Visible = true;
               
            }
            else
            {
                progressBar1.Value = 0;
                timer_cargando.Stop();
            
            if (lblapertura_de_caja.Text == "nuevo*****" & lblrol.Text != "Repartidor")
                {
                
                this.Hide();
                    caja.apertura_de_caja frm =  new caja.apertura_de_caja();
                    frm.ShowDialog();
                    this.Hide();
            }
                else 
            {
                    this.Hide();
                    modulos.Menu_principal.menu_principal frm = new modulos.Menu_principal.menu_principal();

                    frm.ShowDialog();
                    this.Hide();
                }
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
    }
}
