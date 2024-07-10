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
using System.Text.RegularExpressions;
using System.IO;
namespace PUNTO_DE_VENTA.presentacion.configurar_empresa
{
    public partial class form_configurar_empresa : Form
    {
        public form_configurar_empresa()
        {
            InitializeComponent();
        }
        
        private void form_configurar_empresa_Load(object sender, EventArgs e)
        {
            mostrar_empresa();
            mostrar_datos();

        }
        string v_impuestos;
        string tipo_cobro;
        private void mostrar_datos()
        {
            txtnombre_empresa.Text = dgv_empresa.SelectedCells[2].Value.ToString();
            pb_logo.BackgroundImage = null;
            byte[] b = (byte[])dgv_empresa.SelectedCells[1].Value;
            MemoryStream ms = new MemoryStream(b);
            pb_logo.Image = Image.FromStream(ms);
            txtpais.Text = dgv_empresa.SelectedCells[13].Value.ToString();
            txtmoneda.Text = dgv_empresa.SelectedCells[4].Value.ToString();
            v_impuestos = dgv_empresa.SelectedCells[9].Value.ToString();
            if (v_impuestos =="SI")
            {
               
                
                rb_impuestos_si.Checked = true;
            }
            if (v_impuestos == "NO")
            {
                panel_impuestos.Visible = false;
                rb_impuestos_no.Checked = true;
             
            }
            cmporcentaje_impuesto.Text = dgv_empresa.SelectedCells[6].Value.ToString();
            cbimpuestos.Text = dgv_empresa.SelectedCells[7].Value.ToString();
            tipo_cobro = dgv_empresa.SelectedCells[8].Value.ToString();
            if (tipo_cobro == "LECTOR")
            {
                cblector.Checked = true;
                cbteclado.Checked = false;
            }
            else
            {
                cbteclado.Checked = true;
                cblector.Checked = false;
            }
            txtcarpeta_copia.Text = dgv_empresa.SelectedCells[11].Value.ToString();
            txtcorreo.Text = dgv_empresa.SelectedCells[10].Value.ToString();

        }

        private void mostrar_empresa()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("mostrar_empresa", con);
                da.Fill(dt);
                dgv_empresa.DataSource = dt;
                con.Close();

            }
                    
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool validar_correo(string sMail)
        {
            return Regex.IsMatch(sMail, @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$");
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (validar_correo(txtcorreo.Text) == false)

            {
                MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener un formato valido " + "favor de ingresar un correo valido", "Validación de correo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtcorreo.Focus();
                txtcorreo.SelectAll();

            }
            else
            {
                if (txtnombre_empresa.Text != "")
                {
                    try
                    {
                        if (rb_impuestos_no.Checked ==true)
                        {
                            v_impuestos = "NO";
                        }
                        else
                        {
                            v_impuestos = "SI";
                        }
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = conexion.ConexionMaestra.conexion;
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("editar_empresa", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre_empresa",txtnombre_empresa.Text);
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        pb_logo.Image.Save(ms, pb_logo.Image.RawFormat);
                        cmd.Parameters.AddWithValue("@logo",ms.GetBuffer());
                        cmd.Parameters.AddWithValue("@impuesto",cbimpuestos.Text);
                        cmd.Parameters.AddWithValue("@porcentaje_impuesto",cmporcentaje_impuesto.Text);
                        cmd.Parameters.AddWithValue("moneda",txtmoneda.Text);
                        cmd.Parameters.AddWithValue("@pais", txtpais.Text);
                        cmd.Parameters.AddWithValue("@trabajas_con_impuestos",v_impuestos);
                        if (cblector.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@modo_de_busqueda", "LECTOR");
                        }
                        if (cbteclado.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@modo_de_busqueda", "TECLADO");
                        }
                        cmd.Parameters.AddWithValue("@carpeta_para_copia_seguridad", txtcarpeta_copia.Text);
                        cmd.Parameters.AddWithValue("@correo_para_enviar_reportes ",txtcorreo.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Cambios guardados","Guardando cambios",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void rb_impuestos_si_CheckedChanged(object sender, EventArgs e)
        {
            panel_impuestos.Visible = true;
        }

        private void rb_impuestos_no_CheckedChanged(object sender, EventArgs e)
        {
            panel_impuestos.Visible = false;
        }

        private void cblector_CheckedChanged(object sender, EventArgs e)
        {
            if (cblector.Checked == true)
            {

                cbteclado.Checked = false;

            }
            if (cblector.Checked == false)
            {
                cbteclado.Checked = true;
            }
        }

        private void cbteclado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbteclado.Checked == true)
            {

                cblector.Checked = false;

            }
            if (cbteclado.Checked == false)
            {
                cblector.Checked = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtpais_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmoneda.SelectedIndex = txtpais.SelectedIndex;
        }

        private void pb_logo_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = "";
            ofd.Filter = "Imagenes |*.jpg;*.png";
            ofd.FilterIndex = 2;
            ofd.Title = "cargador de imagenes";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pb_logo.BackgroundImage = null;
                pb_logo.Image = new Bitmap(ofd.FileName);
                pb_logo.Text = Path.GetFileName(ofd.FileName);
                pb_logo.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            { 
            if (fbd_carpetaseguridad.ShowDialog() == DialogResult.OK)
            {
                txtcarpeta_copia.Text = fbd_carpetaseguridad.SelectedPath;
                string ruta = fbd_carpetaseguridad.SelectedPath;

            }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
