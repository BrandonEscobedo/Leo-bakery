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

namespace PUNTO_DE_VENTA
{
    public partial class usuarios : Form
    {
       
        public usuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
 
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
             
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_anuncio_Click(object sender, EventArgs e)
        {
            Panel_Iconos.Visible = true;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            panel5.Visible = false;
          
            Panel_Iconos.Visible= false;
            mostrar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            lbl_anuncio.Visible = true;
            icono.Visible = false;
            panel5.Visible = true;
            icono.Visible = true;
            txtnombre_apellidos.Text = "";
            txt_correo.Text = "";
            txt_password.Text = "";
            txt_usuario.Text = "";
            txt_puesto.Text = "";
            guardar_cambios.Visible = false;



        }
       
        public bool validar_correo(string sMail)
        {
            return Regex.IsMatch(sMail, @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$");
        }
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if(validar_correo(txt_correo.Text) == false)

                {
                MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener un formato valido " + "favor de ingresar un correo valido", "Validación de correo", MessageBoxButtons.OK);
                txt_correo.Focus();
                txt_correo.SelectAll();

            }
            else
            {

           

            if (txtnombre_apellidos.Text != "")
            {
                try
                { 
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_usuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombres", txtnombre_apellidos.Text.Replace(" ", "_"));
                cmd.Parameters.AddWithValue("@login", txt_usuario.Text.Replace(" ","_"));
                cmd.Parameters.AddWithValue("@password", txt_password.Text);
                cmd.Parameters.AddWithValue("@correo", txt_correo.Text);
                cmd.Parameters.AddWithValue("@Rol", txt_puesto.Text);
                    cmd.Parameters.AddWithValue("@Estado", "Activo");
                    cmd.Parameters.AddWithValue("@nombre_de_icono", lbl_nombre_icono.Text);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                icono.Image.Save(ms, icono.Image.RawFormat);
                cmd.Parameters.AddWithValue("@icono", ms.GetBuffer());
                cmd.ExecuteNonQuery();
                            
                    cmd.Parameters.AddWithValue("@Estado", "Activo");
                    con.Close();
                   
                    mostrar();
                panel5.Visible = false;

            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            }
        }
        private void mostrar()
        {
            try
            {
                DataTable md = new DataTable();
                SqlDataAdapter datos;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                datos = new SqlDataAdapter("mostrar_usuario", con);
                
                datos.Fill(md);
                dgv_listado.DataSource = md;
                con.Close(); 
                dgv_listado.Columns[1].Visible = false ;


                dgv_listado.Columns[5].Visible = false;
                dgv_listado.Columns[6].Visible = false;
            }






            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            conexion.tamaño_datatablas.multilinea(ref dgv_listado);

        }
        private void lbl_nombre_icono_Click(object sender, EventArgs e)
        {

        }

        private void guardar_cambios_Click(object sender, EventArgs e)
        {
            if (txtnombre_apellidos.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = conexion.ConexionMaestra.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("actualizar_usuario", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idusuarios", lblid_usuarios.Text);
                    cmd.Parameters.AddWithValue("@nombres", txtnombre_apellidos.Text.Replace(" ", "_"));
                    cmd.Parameters.AddWithValue("@login", txt_usuario.Text.Replace(" ", "_"));
                    cmd.Parameters.AddWithValue("@password", txt_password.Text);
                    cmd.Parameters.AddWithValue("@correo", txt_correo.Text);
                    cmd.Parameters.AddWithValue("@Rol", txt_puesto.Text);
                    cmd.Parameters.AddWithValue("@nombre_de_icono", lbl_nombre_icono.Text);
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    icono.Image.Save(ms, icono.Image.RawFormat);
                    cmd.Parameters.AddWithValue("@icono", ms.GetBuffer());
                    cmd.ExecuteNonQuery();
                    con.Close();

                    mostrar();
                    panel5.Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void dgv_listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }

        private void label7_Click(object sender, EventArgs e)
        {
          

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
          
        }

        private void dgv_listado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid_usuarios.Text = dgv_listado.SelectedCells[1].RowIndex.ToString();
            txtnombre_apellidos.Text = dgv_listado.SelectedCells[2].Value.ToString().Replace("_", " ");
            txt_usuario.Text = dgv_listado.SelectedCells[3].Value.ToString().Replace("_"," ");
            txt_password.Text = dgv_listado.SelectedCells[4].Value.ToString();
            icono.BackgroundImage = null;
            byte[] b = (byte[])dgv_listado.SelectedCells[5].Value;
            MemoryStream ms = new MemoryStream(b);
            icono.Image = Image.FromStream(ms);
            lbl_anuncio.Visible = false;
            lbl_nombre_icono.Text = dgv_listado.SelectedCells[6].Value.ToString();
            txt_correo.Text = dgv_listado.SelectedCells[7].Value.ToString();
            txt_puesto.Text = dgv_listado.SelectedCells[8].Value.ToString();
            panel5.Visible = true;
            btn_guardar.Visible = false;
            guardar_cambios.Visible = true;
            

            
        }

        private void icono_Click(object sender, EventArgs e)
        {
            Panel_Iconos.Visible = true;
        }

        private void dgv_listado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgv_listado.Columns["delete"].Index)
            { 
                DialogResult resultado;
            resultado = MessageBox.Show("¿Realmente quieres eliminar a este usuario?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                    SqlCommand cmd;
                    try
                    {
                         foreach (DataGridViewRow row  in dgv_listado.SelectedRows)
                        {
                            int ukey = Convert.ToInt32(row.Cells["IDusuarios"].Value);
                            string usuario = Convert.ToString(row.Cells["usuario"].Value);
                            try
                            { 
                                try
                                {
                                    SqlConnection con = new SqlConnection();
                                    con.ConnectionString = conexion.ConexionMaestra.conexion;
                                    con.Open();
                                    cmd = new SqlCommand("eliminar_usuario", con);
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@idusuario", ukey);
                                    cmd.Parameters.AddWithValue("@login", usuario);
                                    
                                    cmd.ExecuteNonQuery();
                                    cmd.ExecuteNonQuery();
                                    con.Close();

                                } 
                                catch(Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }



                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);

                            }
                            mostrar();
                        }
                    }
                     

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }


                }

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

        private void ofd_FileOk(object sender, CancelEventArgs e)
        {
            
        }
        private void buscar_usuario()
        {
            try
            {
                DataTable md = new DataTable();
                SqlDataAdapter datos;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                datos = new SqlDataAdapter("buscar_usuario", con);
                datos.SelectCommand.CommandType = CommandType.StoredProcedure;
                datos.SelectCommand.Parameters.AddWithValue("@letras", txtbuscar.Text);
                datos.Fill(md);
                dgv_listado.DataSource = md;
                con.Close();
                dgv_listado.Columns[1].Visible = false;
                dgv_listado.Columns[5].Visible = false;
                dgv_listado.Columns[6].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            conexion.tamaño_datatablas.multilinea(ref dgv_listado);

        }
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            buscar_usuario();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Iconos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
