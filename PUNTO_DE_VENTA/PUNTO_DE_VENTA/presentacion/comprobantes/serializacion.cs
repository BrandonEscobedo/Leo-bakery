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
namespace PUNTO_DE_VENTA.presentacion.comprobantes
{
    public partial class serializacion : Form
    {
        public serializacion()
        {
            InitializeComponent();
        }
        int id_serializacion;
        String valor_por_defecto;
        
        private void bnt_guardar_Click(object sender, EventArgs e)
        {
           
            insertar_serializacion();

        }

        private void serializacion_Load(object sender, EventArgs e)
        {
            listar();
        }
        private void insertar_serializacion()
        {
        
            try
            {
                SqlConnection con = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                cmd = new SqlCommand("insertar_serializacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@serie", txt_num_serie.Text);
                cmd.Parameters.AddWithValue("@numeroinicio", txt_cantidad_de_ceros.Text);
                cmd.Parameters.AddWithValue("@numerofin", txt_numerofin.Text);
                cmd.Parameters.AddWithValue("@destino", "OTROS");
                cmd.Parameters.AddWithValue("@tipo_doc", txt_tipo_comprobante.Text);
               
                cmd.Parameters.AddWithValue("@por_defecto", "-");
                cmd.ExecuteNonQuery();
                con.Close();
                listar();
                panel_factura.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void listar()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Close();
                da = new SqlDataAdapter("mostrar_tipo_de_documentos", con);
                da.Fill(dt);

                dgv_comprobantes.DataSource = dt;
                con.Close();
                dgv_comprobantes.Columns[1].Visible = false;
                dgv_comprobantes.Columns[2].Visible = false;
                dgv_comprobantes.Columns[3].Visible = false;
                dgv_comprobantes.Columns[4].Visible = false;
                dgv_comprobantes.Columns[5].Width = 240;
                dgv_comprobantes.Columns[6].Width = 240;
                negocio.procedimientos_necesarios.formato_dgv(ref dgv_comprobantes);
                dgv_comprobantes.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            cb_elegir_defecto.Checked = false;
            cb_elegir_defecto.Visible = false;
            dgv_comprobantes.Visible = false;
            btn_guardar.Visible = true;

            panel_factura.Visible = true;
            btn_actualizar.Visible = false;
            txt_cantidad_de_ceros.Clear();
            txt_numerofin.Clear();
            txt_num_serie.Clear(); 
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            dgv_comprobantes.Visible = true;
            panel_factura.Visible = false;
            btn_actualizar.Visible = false;
            txt_cantidad_de_ceros.Clear();
            txt_numerofin.Clear();
            txt_num_serie.Clear();
        }
    private void elegir_por_defecto()
        {
            if ( cb_elegir_defecto.Checked==true)
            {

            try
            {
                id_serializacion = Convert.ToInt32(dgv_comprobantes.CurrentRow.Cells[4].Value.ToString());

                SqlConnection con = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                cmd = new SqlCommand("editar_serializacion_por_defecto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue ("@idserie",id_serializacion );
                cmd.ExecuteReader();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }
        }
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            elegir_por_defecto();
            try
            {
                SqlConnection con = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                cmd = new SqlCommand("editar_serializacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@serie", txt_num_serie.Text);
                cmd.Parameters.AddWithValue("@cantidad_numeros", txt_cantidad_de_ceros.Text);
                cmd.Parameters.AddWithValue("@numero_fin", txt_numerofin.Text);
                cmd.Parameters.AddWithValue("@tipo_doc", txt_tipo_comprobante.Text);
                cmd.Parameters.AddWithValue("@id_serie", id_serializacion);
                cmd.ExecuteNonQuery();
                con.Close();
                listar();
                panel_factura.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_comprobantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                txt_cantidad_de_ceros.Text = dgv_comprobantes.CurrentRow.Cells[2].Value.ToString();
                txt_tipo_comprobante.Text = dgv_comprobantes.CurrentRow.Cells[6].Value.ToString();
                txt_numerofin.Text = dgv_comprobantes.CurrentRow.Cells[3].Value.ToString();
                txt_num_serie.Text = dgv_comprobantes.CurrentRow.Cells[1].Value.ToString();
                btn_actualizar.Visible = true;
                btn_guardar.Visible = false;
                panel_factura.Visible = true;
                valor_por_defecto = dgv_comprobantes.CurrentRow.Cells[7].Value.ToString();
                if (valor_por_defecto == "SI")
                {
                    cb_elegir_defecto.Visible = false;
                     cb_elegir_defecto.Checked=true;

                }
                else
                {
                    cb_elegir_defecto.Checked=true;
                    cb_elegir_defecto.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("¿Estas seguro de eliminar los comprobantes seleccionados?", "Eliminar comprobante", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                try
                {



                    int id = Convert.ToInt32(dgv_comprobantes.CurrentRow.Cells["id_serializacion"].Value);

                    SqlConnection con = new SqlConnection();
                    SqlCommand cmd = new SqlCommand();
                    con.ConnectionString = conexion.ConexionMaestra.conexion;
                    con.Open();
                    cmd = new SqlCommand("eliminar_comprobantes", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_serie", id);
                    cmd.ExecuteNonQuery();
                    con.Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            listar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
