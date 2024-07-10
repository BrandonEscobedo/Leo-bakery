using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA.presentacion.configuracion
{
    public partial class form_configuraciones : Form
    {
        public form_configuraciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            productos.productos frm = new productos.productos();
            frm.ShowDialog();
          
        }

        private void form_configuraciones_Load(object sender, EventArgs e)
        {

        }
        
        private void pb_empresa_Click(object sender, EventArgs e)
        {
            configurar_empresa.form_configurar_empresa frm = new configurar_empresa.form_configurar_empresa();
            frm.ShowDialog();
        }

        private void pb_usuarios_Click(object sender, EventArgs e)
        {
            usuarios frm = new usuarios();
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dispose();
           control_negocio.pantalla_principal_admin frm = new control_negocio.pantalla_principal_admin();
            frm.ShowDialog();        
        }

        private void pb_proveedores_Click(object sender, EventArgs e)
        {
            presentacion.inventario_kardex.inventario_menu frm = new inventario_kardex.inventario_menu();
            frm.ShowDialog();
        }

        private void pb_cajas_Click(object sender, EventArgs e)
        {
            presentacion.caja.form_cajas frm = new presentacion.caja.form_cajas();
            frm.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            presentacion.notificaciones.form_notificaciones frm = new presentacion.notificaciones.form_notificaciones();
            frm.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            presentacion.comprobantes.serializacion frm = new comprobantes.serializacion();
            frm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            presentacion.diseño_de_comprobantes.form_ticketcs frm = new presentacion.diseño_de_comprobantes.form_ticketcs();
            frm.ShowDialog();
        }
    }
}
