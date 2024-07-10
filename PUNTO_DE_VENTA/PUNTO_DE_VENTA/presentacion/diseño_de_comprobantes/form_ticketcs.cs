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
namespace PUNTO_DE_VENTA.presentacion.diseño_de_comprobantes
{
    public partial class form_ticketcs : Form
    {
        public form_ticketcs()
        {
            InitializeComponent();
        }
        String tipo_ticket;
        String tipo_moneda;
        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
        
        private void form_ticketcs_Load(object sender, EventArgs e)
        {
            mostrar_formato_de_tiket();
        }
        private void mostrar_formato_de_tiket()
        {
            try
            {

            
            SqlCommand cmd = new SqlCommand();
                conexion.ConexionMaestra.conectar.Open();

                cmd = new SqlCommand("mostrar_formato_ticket", conexion.ConexionMaestra.conectar);
                SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                    tipo_ticket = reg["por_defecto"].ToString();
                    if(tipo_ticket == "Ticket no Fiscal")
                    {
                        btn_ticket_no_fiscal.BackColor = Color.Green;
                        btn_factura_boleta.BackColor = Color.WhiteSmoke;
                        txt_datos_para_facturar.Visible = false;
                    }
                    else
                    {
                        btn_factura_boleta.BackColor = Color.Green;
                        btn_ticket_no_fiscal.BackColor = Color.WhiteSmoke;
                        txt_datos_para_facturar.Visible = true;
                    }
                 pb_logo.BackgroundImage = null;
                byte[] b = (byte[])reg["logo"];
                MemoryStream ms = new MemoryStream(b);
                pb_logo.Image= Image.FromStream(ms);
                txt_nombre_empresa.Text= reg["nombre_empresa"].ToString();
                tipo_moneda = reg["nombre_de_moneda"].ToString();
                txt_inf_adicional.Text = reg["anuncio"].ToString();
                txt_telefono.Text = reg["telefono"].ToString();
                txt_identificador_fiscal.Text = reg["identificador_fiscal"].ToString();
                txt_dirrecion.Text = reg["direccion"].ToString();
                txt_departamento.Text = reg["provincia_departamento"].ToString();
                txt_agradecimiento.Text = reg["agradecimiento"].ToString();
                txt_pagina.Text = reg["paginas_internet"].ToString();
             
            }
            else
                {
                    
                }
                conexion.ConexionMaestra.conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ticket_no_fiscal_Click(object sender, EventArgs e)
        {
            tipo_ticket = "Ticket no Fiscal";
            btn_ticket_no_fiscal.BackColor = Color.Green;
            btn_factura_boleta.BackColor = Color.WhiteSmoke;
            txt_datos_para_facturar.Visible = false;
        }

        private void btn_factura_boleta_Click(object sender, EventArgs e)
        {
            tipo_ticket = "Factura-boleta";
            btn_factura_boleta.BackColor = Color.Green;
            btn_ticket_no_fiscal.BackColor = Color.WhiteSmoke;
            txt_datos_para_facturar.Visible = true;
        }

        private void pb_logo_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = "";
            ofd.Filter = "imagenes|*.jpg;*.png";
            ofd.FilterIndex = 2;
            ofd.Title = "Cambiar logo";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pb_logo.BackgroundImage = null;
                pb_logo.Image = new Bitmap(ofd.FileName);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                cmd = new SqlCommand("editar_formato_ticket", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@identificador_fiscal",txt_identificador_fiscal.Text);
                cmd.Parameters.AddWithValue("@direccion",txt_dirrecion.Text);
                cmd.Parameters.AddWithValue("@provincia_departamento",txt_departamento.Text);
                cmd.Parameters.AddWithValue("@nombre_de_moneda", tipo_moneda);
                cmd.Parameters.AddWithValue("@agradecimiento",txt_agradecimiento.Text);
                cmd.Parameters.AddWithValue("@paginas_internet",txt_pagina.Text);
                cmd.Parameters.AddWithValue("@anuncio",txt_inf_adicional.Text);
                if (tipo_ticket == "Ticket no Fiscal")
                {
                  cmd.Parameters.AddWithValue("@datos_fiscales", "-");
                }
                else
                {
                cmd.Parameters.AddWithValue("@datos_fiscales",txt_datos_para_facturar.Text);
                }
                cmd.Parameters.AddWithValue("@por_defecto",tipo_ticket);
                cmd.Parameters.AddWithValue("@nombre_empresa",txt_nombre_empresa.Text);
                cmd.Parameters.AddWithValue("@telefono",txt_telefono.Text);
                MemoryStream ms = new MemoryStream();
                pb_logo.Image.Save(ms, pb_logo.Image.RawFormat);
                cmd.Parameters.AddWithValue("@logo",ms.GetBuffer());
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("datos actualizados correctamente","Actualizacion correcta",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
