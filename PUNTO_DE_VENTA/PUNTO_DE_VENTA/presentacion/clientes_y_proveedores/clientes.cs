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
namespace PUNTO_DE_VENTA.presentacion.clientes_y_proveedores
{
    public partial class clientes : Form
    {
        public clientes()
        {
            InitializeComponent();
        }
        int id_cliente;
        String estado_cliente;
        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_ingresar_cliente.Visible = true;
            panel_ingresar_cliente.Dock = DockStyle.Fill;
            dgv_clientes.Dock = DockStyle.None;
            txtbuscar.Clear();
            dgv_clientes.Visible = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
 
        private void clientes_Load(object sender, EventArgs e)
        {
            panel_ingresar_cliente.Visible = false;
            txt_nombre.Focus();
            mostrar_cliente();
            
        }
        private void mostrar_cliente()
        {
            try
            {

            DataTable dt = new DataTable();
            SqlDataAdapter da;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conexion.ConexionMaestra.conexion;
            con.Open();
            da = new SqlDataAdapter("mostrar_clientes", con);
            da.Fill(dt);
            dgv_clientes.DataSource = dt;
            con.Close();
            dgv_clientes.Dock = DockStyle.Fill;
            modificar_diseño_tabla_cliente();
            cambiar_color_clientes_eliminados();
            

            }
            catch (Exception ex)
            {
                 
            }
            negocio.procedimientos_necesarios.formato_dgv(ref dgv_clientes);
            mostrar_clientes_activos();
            mostrar_clientes_eliminados();
        }
        
        private void limpiar_datos()
        {
            panel_ingresar_cliente.Visible = false;
            dgv_clientes.Visible = true;
            txt_if.Clear();
            txt_direccion.Clear();
            txt_nombre.Clear();
            txt_tnumero.Clear();
            txt_nombre.Focus();
            btn_actualizar.Visible = false;
            btn_agregar.Visible = true;
        }
        private void insertar_cliente()
        { if (txt_nombre.Text == "")
            {
                MessageBox.Show("Favor de Ingresar un nombre, verifique la informacion", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = conexion.ConexionMaestra.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("insertar_cliente", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);           

                    cmd.Parameters.AddWithValue("@cliente", "SI");
               
                    cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
                    cmd.Parameters.AddWithValue("@Saldo", 0);

                    if (txt_direccion.Text != "") cmd.Parameters.AddWithValue("@direccion_para_factura", txt_direccion.Text);
                    else
                    {
                        cmd.Parameters.AddWithValue("@direccion_para_factura", "Ninguna");
                    }
                    if (txt_if.Text != "") cmd.Parameters.AddWithValue("@identificador_fiscal", txt_if.Text);
                    else
                    {
                        cmd.Parameters.AddWithValue("@identificador_fiscal", "Ninguno");
                    }
                    if (txt_tnumero.Text != "")  cmd.Parameters.AddWithValue("@movil", txt_tnumero.Text);
                    else
                    {
                        cmd.Parameters.AddWithValue("@movil","Ninguno");
                    }
                    cmd.ExecuteNonQuery();
                    con.Close();

                    limpiar_datos();
                    mostrar_cliente();


                }
                catch (Exception ex)
                {
                     
                }

            }
        }
        private void cambiar_color_clientes_eliminados()
        {
            foreach (DataGridViewRow row in dgv_clientes.Rows)
            {
               
                if (row.Cells["Estado"].Value.ToString()=="Eliminado")
                {
                    row.DefaultCellStyle.Font = new Font("segoe UI",11,FontStyle.Strikeout | FontStyle.Bold);
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
        private void modificar_diseño_tabla_cliente()
        {
            dgv_clientes.Columns[2].Visible = false;
            dgv_clientes.Columns[7].Visible = false;
            dgv_clientes.Columns[8].Visible = false;
            dgv_clientes.Columns[9].Visible = false;
            dgv_clientes.Columns[10].Visible = false;
            dgv_clientes.Columns[4].Width = 230;
            dgv_clientes.Columns[3].Width = 230;
            dgv_clientes.Columns[5].Width = 230;
       
        }
        private void buscar_cliente()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conexion.ConexionMaestra.conexion;
                con.Open();
                da = new SqlDataAdapter("buscar_cliente", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", txtbuscar.Text);
                da.Fill(dt);
                dgv_clientes.DataSource = dt;
                con.Close();
                modificar_diseño_tabla_cliente();
                cambiar_color_clientes_eliminados();
            }
            catch (Exception ex)
            {
                 
            }
            negocio.procedimientos_necesarios.formato_dgv( ref dgv_clientes);
        }
        private void bnt_guardar_Click(object sender, EventArgs e)
        {
            insertar_cliente();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar_datos();
        }

        private void dgv_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mostrar_clientes_activos()
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = conexion.ConexionMaestra.conexion;
          
            cmd = new SqlCommand("mostrar_clientes_activos", con);
            try
            {
                con.Open();
                lbl_clientes_activos.Text =Convert.ToString(  cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                 
            }
        }
        private void mostrar_clientes_eliminados()
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = conexion.ConexionMaestra.conexion;

            cmd = new SqlCommand("mostrar_clientes_eliminados", con);
            try
            {
                con.Open();
                lbl_clientes_eliminados.Text = Convert.ToString(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                 
            }
        }
       
        private void dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {     
           
            if (e.ColumnIndex == this.dgv_clientes.Columns["editar"].Index)
            {
                recuperar_datos_para_editar();
            }
            if (e.ColumnIndex == this.dgv_clientes.Columns["eliminar"].Index)
            {

                DialogResult result;
                result = MessageBox.Show("Este cliente ha sido eliminado ¿desea habilitarlo?", "Restaurar cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                   

                        try
                        {
                            int Idcliente = Convert.ToInt32(dgv_clientes.CurrentRow.Cells["idcliente"].Value);
                            SqlCommand cmd;
                            SqlConnection con = new SqlConnection();
                            con.ConnectionString = conexion.ConexionMaestra.conexion;
                            con.Open();
                            cmd = new SqlCommand("eliminar_cliente", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idcliente", Idcliente);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                             
                        }
                        mostrar_cliente();
                    
                }
            }   
                
                
            }
      
        private void restaurar_cliente()
        {
            
                  
                    try
                    {
                int idcliente = Convert.ToInt32(dgv_clientes.CurrentRow.Cells[2].Value);
                SqlCommand cmd;
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = conexion.ConexionMaestra.conexion;
                        con.Open();
                        cmd = new SqlCommand("restaurar_cliente", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idcliente", idcliente);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.StackTrace);
                    }
                mostrar_cliente();

            
            
        }
       
        private void recuperar_datos_para_editar()
        {
            try
            {
          estado_cliente = dgv_clientes.CurrentRow.Cells[10].Value.ToString();
                if (estado_cliente == "Eliminado")
                {
                    DialogResult resultado;

                    resultado = MessageBox.Show("Este cliente ha sido eliminado, ¿desea recuperarlo?", "Recuperar cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (resultado == DialogResult.OK)
                    {
                        id_cliente = Convert.ToInt32(dgv_clientes.CurrentRow.Cells[2].Value.ToString());
                        txt_direccion.Text = dgv_clientes.CurrentRow.Cells[4].Value.ToString();
                        txt_nombre.Text = dgv_clientes.CurrentRow.Cells[3].Value.ToString();
                        txt_tnumero.Text = dgv_clientes.CurrentRow.Cells[6].Value.ToString();
                        txt_if.Text = dgv_clientes.CurrentRow.Cells[5].Value.ToString();
                        dgv_clientes.Visible = false;
                        dgv_clientes.Dock = DockStyle.None;
                        panel_ingresar_cliente.Visible = true;
                        panel_ingresar_cliente.Dock = DockStyle.Fill;
                        btn_actualizar.Visible = true;
                        btn_agregar.Visible = false;
                        restaurar_cliente();
                    }
                   
                }
                else  {
                    mostrar_cliente();
                }


             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ex.Message);
            }
        }
        private void dgv_clientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            buscar_cliente();
        }

        private void dgv_clientes_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Favor de Ingresar un nombre, verifique la informacion", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = conexion.ConexionMaestra.conexion;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("actualizar_cliente", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idcliente", id_cliente);
                    cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                
                    

                    if (txt_direccion.Text != "") cmd.Parameters.AddWithValue("@direccion_para_factura", txt_direccion.Text);
                    else
                    {
                        cmd.Parameters.AddWithValue("@direccion_para_factura", "Ninguna");
                    }
                    if (txt_if.Text != "") cmd.Parameters.AddWithValue("@identificador_fiscal", txt_if.Text);
                    else
                    {
                        cmd.Parameters.AddWithValue("@identificador_fiscal", "Ninguno");
                    }
                    if (txt_tnumero.Text != "") cmd.Parameters.AddWithValue("@movil", txt_tnumero.Text);
                    else
                    {
                        cmd.Parameters.AddWithValue("@movil", "Ninguno");
                    }
                    cmd.ExecuteNonQuery();
                    con.Close();

                    limpiar_datos();
                    mostrar_cliente();


                }
                catch (Exception ex)
                {
                     
                }

            }
        }

        private void lbl_clientes_activos_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
