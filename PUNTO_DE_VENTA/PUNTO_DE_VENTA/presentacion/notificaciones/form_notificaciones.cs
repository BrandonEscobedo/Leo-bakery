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
namespace PUNTO_DE_VENTA.presentacion.notificaciones
{
    public partial class form_notificaciones : Form
    {
        public form_notificaciones()
        {
            InitializeComponent();
        }
        private void mostrar_notificaciones()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("productos_vencidos_contar", con);         
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Label lbl1 = new Label();
                    Label lbl2 = new Label();
                    Panel pn1 = new Panel();
                    Panel pn2 = new Panel();
                    PictureBox pb1 = new PictureBox();
                    PictureBox pb2 = new PictureBox();
                    lbl1.Text = "Tienes productos vencidos";
                    lbl1.Name = rdr["id"].ToString();
                    lbl1.Size = new System.Drawing.Size(430, 35);
                    lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13);
                    lbl1.BackColor = Color.Transparent;
                    lbl1.ForeColor = Color.Black;
                    lbl1.Dock = DockStyle.Top;
                    lbl1.TextAlign = ContentAlignment.MiddleLeft;

                    lbl2.Text = "(" + rdr["id"].ToString() + ") Producto(s) Vencido(s)";
                    lbl1.Name = rdr["id"].ToString();
                    lbl2.Size = new System.Drawing.Size(430, 18);
                    lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13);
                    lbl2.BackColor = Color.Transparent;
                    lbl2.ForeColor = Color.Gray;
                    lbl2.Dock = DockStyle.Fill;
                    lbl2.TextAlign = ContentAlignment.MiddleLeft;
                    pb2.BackgroundImage = Properties.Resources.advertencia_vencidos;
                    pb2.BackgroundImageLayout = ImageLayout.Zoom;
                    pb2.Size = new System.Drawing.Size(20, 20);
                    pb2.Dock = DockStyle.Left;

                    pn1.Size = new System.Drawing.Size(430, 70);
                    pn1.BorderStyle = BorderStyle.FixedSingle;
                    pn1.Dock = DockStyle.Top;
                    pn1.BackColor = Color.White;

                    pn2.Size = new System.Drawing.Size(290, 25);
                    pn2.Dock = DockStyle.Top;

                    pn2.BackColor = Color.Transparent;

                    pb1.BackgroundImage = Properties.Resources.calendario_vencidos;
                    pb1.BackgroundImageLayout = ImageLayout.Zoom;
                    pb1.Size = new System.Drawing.Size(100, 100);
                    pb1.BackColor = Color.Transparent;
                    pb1.Dock = DockStyle.Left;
                    pn1.Controls.Add(lbl1);
                    pn1.Controls.Add(pb1);
                    pn1.Controls.Add(pn2);
                    pn2.Controls.Add(pb2);
                    pn2.Controls.Add(lbl2);
                    pn2.BringToFront();
                    lbl1.SendToBack();
                    pb1.SendToBack();
                    lbl2.BringToFront();
                    panel_notificaciones.Controls.Add(pn1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.StackTrace + ex.Message);
            }
        }
        private void form_notificaciones_Load(object sender, EventArgs e)
        {
            mostrar_notificaciones(); 
        }
    }
}
