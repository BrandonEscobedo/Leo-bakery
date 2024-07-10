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
namespace PUNTO_DE_VENTA.presentacion.caja
{
    public partial class form_cajas : Form
    {
        public form_cajas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void form_cajas_Load(object sender, EventArgs e)
        {
           
            crear_caja_principal();
            crear_caja_secundarias();
        }
        int idcaja;
        private void crear_caja_principal()
        {
            panel_principal.Controls.Clear();
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("mostrar_caja_principal", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read ())
                {
                    Panel p = new Panel();
                    Panel p2 = new Panel();
                    Panel p3 = new Panel();
                    Panel parriba = new Panel();
                    Panel pcostado = new Panel();
                    PictureBox pb = new PictureBox();
                    PictureBox pb2 = new PictureBox();
                    Label l = new Label();
                    Label l2 = new Label();
                    Label lusuario= new Label();

                    l.Text = rdr["descripcion"].ToString();
                    l.Name = rdr["id_caja"].ToString();
                    l.Size = new System.Drawing.Size(175, 25);
                    l.Font = new System.Drawing.Font("Microsoft Sans Serif", 20);
                    l.AutoSize = false;
                    l.BackColor =  Color.Transparent;
                    l.ForeColor = Color.Black;
                    l.Dock = DockStyle.Top;
                    l.TextAlign = ContentAlignment.MiddleCenter;

                    lusuario.Text = "Por " + rdr["nombres_apellidos"].ToString();
                    lusuario.Dock = DockStyle.Bottom;
                    lusuario.AutoSize = false;
                    lusuario.TextAlign = ContentAlignment.MiddleCenter;
                    lusuario.BackColor = Color.Transparent;
                    lusuario.ForeColor = Color.Black;
                    lusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10);
                    lusuario.Size = new System.Drawing.Size(430, 31);

                    p.Size = new System.Drawing.Size(298, 137);
                    p.BorderStyle = BorderStyle.None;
                    p.Dock = DockStyle.Fill;
                    p.BackColor = Color.FromArgb(224, 224, 224);

                    p2.Size =new System.Drawing.Size(298,24);
                    p2.Dock = DockStyle.Top;
                    p2.BackColor = Color.FromArgb(224, 224, 224);
                    l2.Text = rdr["Estado"].ToString();
                    l2.Size = new System.Drawing.Size(408, 188);
                    l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10);
                    l2.BackColor = Color.Transparent;
                    l2.ForeColor = Color.Black;
                    l2.AutoSize = false;
                    l2.Dock = DockStyle.Fill;
                    l2.TextAlign = ContentAlignment.MiddleCenter;

                    MenuStrip ms = new MenuStrip();

                    ms.BackColor = Color.Transparent;
                   
                    ms.Size = new System.Drawing.Size(28, 24);
                    ms.Dock = DockStyle.Right;
                    ms.Name = rdr["id_caja"].ToString();

                    ToolStripMenuItem tsmip = new ToolStripMenuItem();
                    ToolStripMenuItem tsmie= new ToolStripMenuItem();
                    tsmip.Image = Properties.Resources.pngwing_com;
                    tsmip.BackColor = Color.Transparent;
                    tsmie.Text = "Editar";
                    tsmie.Name = rdr["descripcion"].ToString();
                    tsmie.Tag = rdr["id_caja"].ToString();
                    ms.Items.Add(tsmip);
                    tsmip.DropDownItems.Add(tsmie);
                    
                    if (l2.Text== "RECIEN CREADA")
                    {
                        pb.BackgroundImage = Properties.Resources.caja;
                    }
                   else if (l2.Text =="CAJA RESTAURADA")
                    {
                        pb.BackgroundImage = Properties.Resources.caja;
                    }
                   else if (l2.Text=="Caja Aperturada")
                    {
                        pb.BackgroundImage = Properties.Resources.cheque__1_;
                    }
                   else if (l2.Text=="Caja Cerrada")
                    {
                        pb.BackgroundImage = Properties.Resources.circulo;
                    }
                    else if (l2.Text == "Caja Eliminada")
                    {
                        pb.BackgroundImage = Properties.Resources.eliminar;
                        l.ForeColor = Color.DimGray;
                    }
                    pb.BackgroundImageLayout = ImageLayout.Zoom;
                    pb.Size = new System.Drawing.Size(44, 37);
                    pb.Dock = DockStyle.Fill;
                    pb.BackColor = Color.Transparent;

                    p3.Size = new System.Drawing.Size(30, 24);
                    p3.Dock = DockStyle.Left;
                    p3.BackColor = Color.Transparent;

                    parriba.Size = new System.Drawing.Size(22,5);
                    parriba.Dock = DockStyle.Top;
                    parriba.BackColor = Color.Transparent;

                    pcostado.Size = new System.Drawing.Size(2, 22);
                    pcostado.Dock = DockStyle.Left;
                    pcostado.BackColor = Color.Transparent;

                    p3.Controls.Add(parriba);
                    p3.Controls.Add(pcostado);
                    p3.Controls.Add(pb);

                    p2.Controls.Add(p3);
                    p2.Controls.Add(l2);
                    p2.Controls.Add(ms);

                    p.Controls.Add(p2);
                    p.Controls.Add(l);
                    p.Controls.Add(lusuario);


                    panel_principal.Controls.Add(p);
                    lusuario.BringToFront();
                    pb.BringToFront();

                    tsmie.Click += new EventHandler(eventotseditar);

                }
                con.Close();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void crear_caja_secundarias()
        {
            flp_secundarias.Controls.Clear();
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("mostrar_caja_secundarias", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Panel p = new Panel();
                    Panel p2 = new Panel();
                    Panel p3 = new Panel();
                    Panel parriba = new Panel();
                    Panel pcostado = new Panel();
                    PictureBox pb = new PictureBox();
                    PictureBox pb2 = new PictureBox();
                    Label l = new Label();
                    Label l2 = new Label();
                    Label lusuario = new Label();

                    l.Text = rdr["descripcion"].ToString();
                    l.Name = rdr["id_caja"].ToString();
                    l.Size = new System.Drawing.Size(175, 25);
                    l.Font = new System.Drawing.Font("Microsoft Sans Serif", 20);
                    l.AutoSize = false;
                    l.BackColor = Color.Transparent;
                    l.ForeColor = Color.Black;
                    l.Dock = DockStyle.Fill;
                    l.TextAlign = ContentAlignment.MiddleCenter;

                    lusuario.Text = "Por " + rdr["nombres_apellidos"].ToString();
                    lusuario.Dock = DockStyle.Bottom;
                    lusuario.AutoSize = false;
                    lusuario.TextAlign = ContentAlignment.MiddleCenter;
                    lusuario.BackColor = Color.Transparent;
                    lusuario.ForeColor = Color.Black;
                    lusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10);
                    lusuario.Size = new System.Drawing.Size(430, 31);

                    p.Size = new System.Drawing.Size(298, 137);
                    p.BorderStyle = BorderStyle.None;
                    p.Dock = DockStyle.Top;
                    p.BackColor = Color.FromArgb(224, 224, 224);

                    p2.Size = new System.Drawing.Size(298, 24);
                    p2.Dock = DockStyle.Top;
                    p2.BackColor = Color.FromArgb(224, 224, 224);
                    l2.Text = rdr["Estado"].ToString();
                    l2.Size = new System.Drawing.Size(408, 188);
                    l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10);
                    l2.BackColor = Color.Transparent;
                    l2.ForeColor = Color.Black;
                    l2.AutoSize = false;
                    l2.Dock = DockStyle.Fill;
                    l2.TextAlign = ContentAlignment.MiddleCenter;

                    MenuStrip ms = new MenuStrip();
                    ms.BackColor = Color.Transparent;
                    ms.Size = new System.Drawing.Size(28, 24);
                    ms.Dock = DockStyle.Right;
                    ms.Name = rdr["id_caja"].ToString();

                    ToolStripMenuItem tsmip = new ToolStripMenuItem();
                    ToolStripMenuItem tsmie = new ToolStripMenuItem();
                    ToolStripMenuItem tsmieliminar = new ToolStripMenuItem();
                    ToolStripMenuItem tsmirestaurar = new ToolStripMenuItem();





                    tsmip.Image = Properties.Resources.pngwing_com;
                    tsmip.BackColor = Color.Transparent;
                    tsmie.Text = "Editar";
                    tsmie.Name = rdr["descripcion"].ToString();
                    tsmie.Tag = rdr["id_caja"].ToString();
                    tsmieliminar.Text = "Eliminar";
                    tsmieliminar.Tag = rdr["id_caja"].ToString();
                    tsmirestaurar.Text = "Restaurar";
                    tsmirestaurar.Tag = rdr["id_caja"].ToString();
                    ms.Items.Add(tsmip);


                    if (l2.Text == "RECIEN CREADA")
                    {
                        pb.BackgroundImage = Properties.Resources.caja;
                    }
                    else if (l2.Text == "CAJA RESTAURADA")
                    {
                        pb.BackgroundImage = Properties.Resources.caja;
                    }
                    else if (l2.Text == "Caja Aperturada")
                    {
                        pb.BackgroundImage = Properties.Resources.cheque__1_;
                    }
                    else if (l2.Text == "Caja Cerrada")
                    {
                        pb.BackgroundImage = Properties.Resources.circulo;
                    }
                    else if (l2.Text == "Caja Eliminada")
                    {
                        pb.BackgroundImage = Properties.Resources.eliminar;
                        l.ForeColor = Color.DimGray;
                    }
                    if (l2.Text != "Caja eliminada")
                    {
                        tsmip.DropDownItems.Add(tsmie);
                        tsmip.DropDownItems.Add(tsmieliminar);

                    }
                    else
                    {
                        tsmip.DropDownItems.Add(tsmirestaurar);
                    }

                    pb.BackgroundImageLayout = ImageLayout.Zoom;
                    pb.Size = new System.Drawing.Size(44, 37);
                    pb.Dock = DockStyle.Fill;
                    pb.BackColor = Color.Transparent;

                    p3.Size = new System.Drawing.Size(30, 24);
                    p3.Dock = DockStyle.Left;
                    p3.BackColor = Color.Transparent;

                    parriba.Size = new System.Drawing.Size(22, 5);
                    parriba.Dock = DockStyle.Top;
                    parriba.BackColor = Color.Transparent;

                    pcostado.Size = new System.Drawing.Size(2, 22);
                    pcostado.Dock = DockStyle.Left;
                    pcostado.BackColor = Color.Transparent;

                    p3.Controls.Add(parriba);
                    p3.Controls.Add(pcostado);
                    p3.Controls.Add(pb);

                    p2.Controls.Add(p3);
                    p2.Controls.Add(l2);
                    p2.Controls.Add(ms);

                    p.Controls.Add(p2);
                    p.Controls.Add(l);
                    p.Controls.Add(lusuario);


                    flp_secundarias.Controls.Add(p);
                    lusuario.BringToFront();
                    pb.BringToFront();

                    tsmie.Click += new EventHandler(eventotseditar);
                    tsmieliminar.Click += new EventHandler(eventoeliminar);
                    tsmirestaurar.Click += new EventHandler(eventorestaurar);

                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        private void eventotseditar(System.Object sender, EventArgs e)
        {
            idcaja = Convert.ToInt32(((ToolStripItem)sender).Tag);
            txtcaja.Text = ((ToolStripMenuItem)sender).Name;
            panel_e_p.Visible = true;
            panel_e_p.Dock = DockStyle.Fill;
            panel_e_p2.Location = new Point((panel_e_p.Width - panel_e_p2.Width) / 2, (panel_e_p.Height - panel_e_p2.Height) / 2);
            txtcaja.SelectAll();
            txtcaja.Focus();

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            panel_e_p.Visible = false;
        }
     
        private void eventoeliminar(System.Object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("¿Realmente quiere eliminar esta caja?", "Elimiando caja", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result== DialogResult.OK)
            {
                idcaja = Convert.ToInt32(((ToolStripMenuItem)sender).Tag);
                eliminar_caja();
                crear_caja_principal();
            }
        }
        private void eliminar_caja()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("eliminar_caja", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcaja", idcaja);
                cmd.ExecuteNonQuery();
                con.Close();
                crear_caja_secundarias();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void restaurar_caja()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("restaurar_caja", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcaja", idcaja);
                cmd.ExecuteNonQuery();
                con.Close();
                crear_caja_secundarias();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void eventorestaurar(System.Object sender, EventArgs e)
        {
            idcaja = Convert.ToInt32(((ToolStripMenuItem)sender).Tag);
            restaurar_caja();
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("editar_caja", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcaja", idcaja);
                cmd.Parameters.AddWithValue("@descripcion", txtcaja.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                panel_e_p.Visible = false;
                panel_e_p.Dock = DockStyle.None;
               
                crear_caja_principal();
                crear_caja_secundarias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
